using DevExpress.XtraEditors;
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
namespace TracNghiemCSDLPT.Views
{
    public partial class MonHoc : DevExpress.XtraEditors.XtraForm
    {
        int selectedRow = 0;
        public MonHoc()
        {
            InitializeComponent();

            //if (MonHocBindingSouce.Count == 0)
            //    buttonXoa.Enabled = false;
        }


        Color ActiveForeColor = Color.FromArgb(72, 70, 68);
        Color DisabledForeColor = SystemColors.AppWorkspace;
        State state = State.idle;
        enum State
        {
            add, edit, idle
        }
        private void MonHoc_Load(object sender, EventArgs e)
        {
            //TN_CSDLPTDataSet.EnforceConstraints = false;

            this.MonHocTableAdapter.Connection.ConnectionString = DBConnection.SubcriberConnectionString;
            this.BoDeTableAdapter.Connection.ConnectionString = DBConnection.SubcriberConnectionString;
            this.GV_DKTableAdapter.Connection.ConnectionString = DBConnection.SubcriberConnectionString;
            this.BangDiemTableAdapter.Connection.ConnectionString = DBConnection.SubcriberConnectionString;

            this.MonHocTableAdapter.Fill(this.TN_CSDLPTDataSet.MONHOC);
            this.BoDeTableAdapter.Fill(this.TN_CSDLPTDataSet.BODE);
            this.GV_DKTableAdapter.Fill(this.TN_CSDLPTDataSet.GIAOVIEN_DANGKY);
            this.BangDiemTableAdapter.Fill(this.TN_CSDLPTDataSet.BANGDIEM);
        }

        private void SetIdleButtonEnabled(bool state)
        {
            buttonThem.Enabled = buttonLamMoi.Enabled = buttonXoa.Enabled =
                 buttonSua.Enabled = state;
        }

        private void SetInputButtonEnabled(bool state)
        {
            buttonUndo.Visible = buttonRedo.Visible =
                buttonHuy.Visible = buttonXacNhan.Visible = state;
        }
        private void buttonThem_Click(object sender, EventArgs e)
        {
            selectedRow = MonHocBindingSouce.Position;
            InfoPanel.Enabled = true;
            InfoPanel.ForeColor = TextMaMH.ForeColor =
                TextTenMH.ForeColor = ActiveForeColor;

            InfoPanel.Text = "Thêm mới môn học";

            SetIdleButtonEnabled(false);
            SetInputButtonEnabled(true);

            MonHocGridControl.Enabled = false;
            state = State.add;
            MonHocBindingSouce.AddNew();
        }

        private void buttonHuy_Click(object sender, EventArgs e)
        {
            InfoPanel.Enabled = false;
            MonHocGridControl.Enabled = true;
            MonHocBindingSouce.CancelEdit();
            InfoPanel.Text = "Thông tin môn học";
            if (state == State.add)
                MonHocBindingSouce.Position = selectedRow;
            SetIdleButtonEnabled(true);
            SetInputButtonEnabled(false);
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            InfoPanel.Enabled = true;
            InfoPanel.ForeColor = TextMaMH.ForeColor =
                TextTenMH.ForeColor = ActiveForeColor;

            InfoPanel.Text = "Thêm mới môn học";

            SetIdleButtonEnabled(false);
            SetInputButtonEnabled(true);

            MonHocGridControl.Enabled = false;
            state = State.edit;
        }

        private void buttonLamMoi_Click(object sender, EventArgs e)
        {
            try
            {
                this.MonHocTableAdapter.Fill(this.TN_CSDLPTDataSet.MONHOC);
            }
            catch (Exception ex)
            {
                Utils.ShowMessage("Lỗi khi tải lại dữ liệu", Others.NotiForm.FormType.Error, 2);
                Console.WriteLine(ex.StackTrace);
                return;
            }
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            int RemovedMH = 0;
            selectedRow = MonHocBindingSouce.Position;
            if(BoDeBindingSouce.Count > 0)
            {
                Utils.ShowMessage("Không thể xóa vì đã có câu hỏi thuộc môn học này", Others.NotiForm.FormType.Error, 3);
                return;
            }
            if (GV_DKBindingSource.Count > 0)
            {
                Utils.ShowMessage("Không thể xóa vì đã có giảng viên đăng ký thi môn học này", Others.NotiForm.FormType.Error, 4);
                return;
            }
            if (GV_DKBindingSource.Count > 0)
            {
                Utils.ShowMessage("Không thể xóa vì đã có sinh viên thi môn học này", Others.NotiForm.FormType.Error, 4);
                return;
            }
            if(Utils.ShowConfirmMessage("Bạn có chắc muốn xóa môn học này?","Xác nhận"))
            {
                try
                {
                    RemovedMH = int.Parse(((DataRowView)MonHocBindingSouce[selectedRow])["MAMH"].ToString());
                    MonHocBindingSouce.RemoveCurrent();
                    MonHocTableAdapter.Update(TN_CSDLPTDataSet.MONHOC);
                }catch (Exception ex)
                {
                    Utils.ShowErrorMessage("Không thể xóa nhân viên, xin vui lòng thử lại\n" + ex.Message,"Lỗi xóa nhân viên");
                    this.MonHocTableAdapter.Fill(TN_CSDLPTDataSet.MONHOC);
                    MonHocBindingSouce.Position = MonHocBindingSouce.Find("MAMH", RemovedMH);
                    return;
                }
            }

            if (MonHocBindingSouce.Count == 0)
                buttonXoa.Enabled = false;


        }

        private void buttonXacNhan_Click(object sender, EventArgs e)
        {

        }

        private void TextMaMH_EditValueChanged(object sender, EventArgs e)
        {
           
        }

        private void TextMaMH_TextChanged(object sender, EventArgs e)
        {
        }

        private void TextMaMH_KeyDown(object sender, KeyEventArgs e)
        {
            
        }
    }
}