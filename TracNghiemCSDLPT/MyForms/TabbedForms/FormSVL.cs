using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TracNghiemCSDLPT.SQL_Connection;

namespace TracNghiemCSDLPT.MyForms.TabbedForms
{
    public partial class FormSVL : DevExpress.XtraEditors.XtraForm
    {
        public FormSVL()
        {
            InitializeComponent();
        }

        private int PreviousIndexCS;
        private bool opened = false;
        private int selectedRowLop;
        private int selectedRowSV;

        Color ActiveForeColor = Color.FromArgb(72, 70, 68);
        Color DisabledForeColor = SystemColors.AppWorkspace;
        State state = State.idle;
        enum State
        {
            add, edit, idle
        }
        private void LoadAllData()
        {
            this.KhoaTableAdapter.Connection.ConnectionString = DBConnection.SubcriberConnectionString;
            this.LopTableAdapter.Connection.ConnectionString = DBConnection.SubcriberConnectionString;
            this.SinhVienTableAdapter.Connection.ConnectionString = DBConnection.SubcriberConnectionString;

            this.KhoaTableAdapter.Fill(this.TN_CSDLPTDataSet.KHOA);
            this.LopTableAdapter.Fill(this.TN_CSDLPTDataSet.LOP);
            this.SinhVienTableAdapter.Fill(this.TN_CSDLPTDataSet.SINHVIEN);
        }
        private GridView getCorrTextBoxData(bool getFirstRow)
        {
            GridView detailView;
            if (getFirstRow)
                detailView = KhoaGridView.GetDetailView(0, 0) as GridView;
            else
            {
                int row = KhoaGridView.GetSelectedRows()[0];
                detailView = KhoaGridView.GetDetailView(row, 0) as GridView;
            }
            if (detailView is null) return null;
            Object test = (detailView as GridView).GetFocusedRowCellValue(colMALOP1);
            string MaLop;
            if (test != null)
                MaLop = test.ToString();
            else return null;
            LopBindingSource.Position = LopBindingSource.Find("MALOP", MaLop);
            return detailView;

        }
        private void FormSVL_Load(object sender, EventArgs e)
        {
            this.TN_CSDLPTDataSet.EnforceConstraints = false;

            LoadAllData();

            this.CoSoComboBox.DataSource = DBConnection.BS_Subcribers;
            this.CoSoComboBox.DisplayMember = "TENCS";
            this.CoSoComboBox.ValueMember = "TENSERVER";
            this.CoSoComboBox.SelectedIndex = DBConnection.IndexCS;
            this.PreviousIndexCS = this.CoSoComboBox.SelectedIndex;

            KhoaGridView.ExpandMasterRow(0); // dùng để trigger LopGridView FocusedRochanged
            GridView view = getCorrTextBoxData(true);
            if (view != null)
                view.Focus();

        }

        private void LopGridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (!opened)
            {
                for (int i = 1; i < KhoaGridView.RowCount; i++)
                    KhoaGridView.ExpandMasterRow(i);
                opened = true;
            }
            getCorrTextBoxData(false);
        }

        private void KhoaGridView_MasterRowGetRelationDisplayCaption(object sender, MasterRowGetRelationNameEventArgs e)
        {
            GridView view = sender as GridView;
            if (view is null) return;
            string tenKhoa = (string)view.GetRowCellValue(e.RowHandle, colTENKH); ;
            if (e.RelationIndex == 0)
                e.RelationName = $"Lớp thuộc khoa {tenKhoa}";
        }

        private void KhoaGridView_DetailTabStyle(object sender, DetailTabStyleEventArgs e)
        {
            e.Appearance.Header.Font = new Font("Baloo 2", 10.0F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
        }

        private void CoSoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CoSoComboBox.SelectedValue.ToString() == "System.Data.DataRowView")
                return;
            string login, pass;
            string serverName = CoSoComboBox.SelectedValue.ToString();
            if (CoSoComboBox.SelectedIndex != DBConnection.IndexCS)//Không cần check loginSV, vì ko bao giờ hiện CB này
            {
                login = DBConnection.RemoteLogin;
                pass = DBConnection.RemotePassword;
            }
            else
            {
                login = DBConnection.LoginName;
                pass = DBConnection.Password;
            }
            bool success = DBConnection.ConnectToSubcriber(login, pass, serverName);
            if (!success)
            {
                Utils.ShowMessage("Tạm thời không thể kết nối đến cơ sở này", Others.NotiForm.FormType.Error, 2);
                this.CoSoComboBox.SelectedIndex = this.PreviousIndexCS;
                return;
            }
            else
            {
                LoadAllData();
                this.PreviousIndexCS = this.CoSoComboBox.SelectedIndex;
            }
        }

        private void SetIdleButtonEnabledLop(bool state)
        {
            buttonThemLop.Enabled = buttonSuaLop.Enabled =
                buttonXoaLop.Enabled = buttonLamMoiLop.Enabled = state;
        }
        private void SetInputButtonEnabledLop(bool state)
        {
            buttonUndoLop.Visible = buttonRedoLop.Visible =
                buttonHuyLop.Visible = buttonXacNhanLop.Visible = state;
        }
        private void buttonThemLop_Click(object sender, EventArgs e)
        {
            selectedRowLop = LopBindingSource.Position;
          //  InfoPanel.Enabled = true;
            TextMaKH.Enabled = TextTenLop.Enabled = TextMaLop.Enabled = true;
            InfoPanel.ForeColor = TextMaLop.ForeColor =
                TextTenLop.ForeColor = TextMaKH.ForeColor = ActiveForeColor;

            InfoPanel.Text = "Thêm mới thông tin lớp";

            SetIdleButtonEnabledLop(false);
            SetInputButtonEnabledLop(true);

            KhoaGridControl.Enabled = false;
            state = State.add;
            LopBindingSource.AddNew();
        }

        private void buttonHuyLop_Click(object sender, EventArgs e)
        {
            //   InfoPanel.Enabled = false;
            TextMaKH.Enabled = TextTenLop.Enabled = TextMaLop.Enabled = false;
            InfoPanel.ForeColor = TextMaLop.ForeColor =
                TextTenLop.ForeColor = TextMaKH.ForeColor = DisabledForeColor;
            KhoaGridControl.Enabled = true;
            LopBindingSource.CancelEdit();
            InfoPanel.Text = "Thông tin lớp";
            if (state == State.add)
                LopBindingSource.Position = selectedRowLop;

            SetIdleButtonEnabledLop(true);
            SetInputButtonEnabledLop(false);

            Utils.SetTextEditError(MaLopEP, TextMaLop, null);
            Utils.SetTextEditError(TenLopEP, TextTenLop, null);
            Utils.SetTextEditError(MaKhoaEP, TextMaKH, null);
        }

        private void buttonLamMoiLop_Click(object sender, EventArgs e)
        {
            try
            {
                this.KhoaTableAdapter.Connection.ConnectionString = DBConnection.SubcriberConnectionString;
                this.KhoaTableAdapter.Fill(this.TN_CSDLPTDataSet.KHOA);
                this.LopTableAdapter.Connection.ConnectionString = DBConnection.SubcriberConnectionString;
                this.LopTableAdapter.Fill(this.TN_CSDLPTDataSet.LOP);
                Utils.ShowMessage("Làm mới thành công", Others.NotiForm.FormType.Success, 1);
            }
            catch (Exception ex)
            {
                Utils.ShowMessage("Lỗi khi tải lại dữ liệu", Others.NotiForm.FormType.Error, 1);
                Console.WriteLine(ex.StackTrace);
                return;
            }
        }

        private void buttonSuaLop_Click(object sender, EventArgs e)
        {

        }
    }
}