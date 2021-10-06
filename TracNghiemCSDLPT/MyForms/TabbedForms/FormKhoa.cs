using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TracNghiemCSDLPT.SQL_Connection;

namespace TracNghiemCSDLPT.MyForms.TabbedForms
{
    public partial class FormKhoa : DevExpress.XtraEditors.XtraForm
    {
        public FormKhoa()
        {
            InitializeComponent();
        }

        private int PreviousIndexCS;
        private int SelectedRow;
        private string origMaKH = "~!@#$%";
        private string origTenKH = "~!@#$%";
        private string MaCS;

        Color ActiveForeColor = Color.FromArgb(72, 70, 68);
        Color DisabledForeColor = SystemColors.AppWorkspace;
        State state = State.idle;

        enum State
        {
            add, edit, idle
        }

        private void FormKhoa_Load(object sender, EventArgs e)
        {
            this.TN_CSDLPTDataSet.EnforceConstraints = false;
            LoadCombobox();
            LoadAllData();
            CheckButtonState();
        }

        private void LoadCombobox()
        {
            this.CoSoComboBox.DataSource = DBConnection.BS_Subcribers;
            this.CoSoComboBox.DisplayMember = "TENCS";
            this.CoSoComboBox.ValueMember = "TENSERVER";
            this.CoSoComboBox.SelectedIndex = DBConnection.IndexCS;
            this.PreviousIndexCS = this.CoSoComboBox.SelectedIndex;
        }

        private void LoadAllData()
        {
            this.LopTableAdapter.Connection.ConnectionString =
            this.GiaoVienTableAdapter.Connection.ConnectionString =
            this.KhoaTableAdapter.Connection.ConnectionString = DBConnection.SubcriberConnectionString;

            this.KhoaTableAdapter.Fill(this.TN_CSDLPTDataSet.KHOA);
            this.GiaoVienTableAdapter.Fill(this.TN_CSDLPTDataSet.GIAOVIEN);
            this.LopTableAdapter.Fill(this.TN_CSDLPTDataSet.LOP);
            this.MaCS = ((DataRowView)DBConnection.BS_Subcribers[CoSoComboBox.SelectedIndex])["MACS"].ToString();
        }

        private void CoSoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CoSoComboBox.SelectedValue.ToString().Equals("System.Data.DataRowView"))
            {
                return;
            }
            string login, pass;
            string serverName = CoSoComboBox.SelectedValue.ToString();
            if (CoSoComboBox.SelectedIndex != DBConnection.IndexCS)
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

        private bool MaKhoaAlreadyExists(string maKhoa)
        {
            string SPName = "usp_Khoa_GetInfoById";
            List<Para> paraList = new List<Para>();
            paraList.Add(new Para("@ID", maKhoa));
            SqlDataReader myReader = DBConnection.ExecuteSqlDataReaderSP(SPName,paraList);
            if (myReader == null)
            {
                Utils.ShowMessage("Xảy ra lỗi không xác định", Others.NotiForm.FormType.Error, 1);
                Console.WriteLine(System.Environment.StackTrace);
                return true;
            }
            bool isExist = myReader.HasRows;
            myReader.Close();
            return isExist;
        }

        private bool TenKhoaAlreadyExists(string tenKhoa)
        {
            string SPName = "usp_Khoa_GetInfoByName";
            List<Para> paraList = new List<Para>();
            paraList.Add(new Para("@Name", tenKhoa));
            SqlDataReader myReader = DBConnection.ExecuteSqlDataReaderSP(SPName,paraList);
            if (myReader == null)
            {
                Utils.ShowMessage("Xảy ra lỗi không xác định", Others.NotiForm.FormType.Error, 1);
                Console.WriteLine(System.Environment.StackTrace);
                return true;
            }
            bool isExist = myReader.HasRows;
            myReader.Close();
            return isExist;
        }

        private void CheckButtonState()
        {
            if (KhoaBindingSource.Count == 0)
            {
                buttonXoa.Enabled = buttonSua.Enabled = false;
            }
            else
            {
                buttonXoa.Enabled = buttonSua.Enabled = true;
            }
        }

        private void SetIdleButtonEnabled(bool state)
        {
            buttonThem.Enabled = 
            buttonLamMoi.Enabled = 
            buttonXoa.Enabled =
            buttonSua.Enabled = state;
        }

        private void SetInputButtonEnabled(bool state)
        {
            buttonUndo.Visible = 
            buttonRedo.Visible =
            buttonHuy.Visible = 
            buttonXacNhan.Visible = state;
        }

        private void SetInfoPanel(bool state, Color color, string message)
        {
            InfoPanel.Enabled = state;
            InfoPanel.ForeColor =
            TextMaKhoa.ForeColor =
            TextTenKhoa.ForeColor = color;
            InfoPanel.Text = message;
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            SelectedRow = KhoaBindingSource.Position;
            SetInfoPanel(true, ActiveForeColor, "Thêm mới thông tin môn học");
            SetIdleButtonEnabled(false);
            SetInputButtonEnabled(true);
            KhoaGridControl.Enabled = false;
            state = State.add;
            KhoaBindingSource.AddNew();
            TextMaCS.Text = MaCS;
        }

        private void buttonHuy_Click(object sender, EventArgs e)
        {
            SetInfoPanel(false, DisabledForeColor, "Thông tin môn học");
            SetIdleButtonEnabled(true);
            SetInputButtonEnabled(false);
            KhoaGridControl.Enabled = true;
            state = State.add;
            KhoaBindingSource.CancelEdit();
            Utils.SetTextEditError(TenKHEP, TextTenKhoa, null);
            Utils.SetTextEditError(MaKHEP, TextMaKhoa, null);
            if (state.Equals(State.add))
            {
                KhoaBindingSource.Position = SelectedRow;
            }
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            string RemovedMaKhoa = string.Empty;

            SelectedRow = KhoaBindingSource.Position;
            if (LopBindingSource.Count > 0)
            {
                Utils.ShowMessage("Không thể xóa vì khoa đã có lớp học", Others.NotiForm.FormType.Error, 2);
                return;
            }
            if (GiaoVienBindingSource.Count > 0)
            {
                Utils.ShowMessage("Không thể xóa vì khoa đã có giảng viên", Others.NotiForm.FormType.Error, 4);
                return;
            }
            if (Utils.ShowConfirmMessage("Bạn có chắc muốn xóa khoa này?", "Xác nhận"))
            {
                try
                {
                    RemovedMaKhoa = ((DataRowView)KhoaBindingSource[SelectedRow])["MAKH"].ToString();
                    string RemovedTenKhoa = ((DataRowView)KhoaBindingSource[SelectedRow])["TENKH"].ToString();
                    KhoaBindingSource.RemoveCurrent();
                    KhoaTableAdapter.Update(TN_CSDLPTDataSet.KHOA);
                    Utils.ShowMessage($"Xóa khoa {RemovedTenKhoa} thành công!", Others.NotiForm.FormType.Success, 1);
                }
                catch (Exception ex)
                {
                    Utils.ShowErrorMessage("Không thể xóa khoa này, xin vui lòng thử lại sau\n" + ex.Message, "Lỗi xóa khoa!");
                    Console.WriteLine(ex.StackTrace);
                    this.KhoaTableAdapter.Fill(TN_CSDLPTDataSet.KHOA);
                    KhoaBindingSource.Position = KhoaBindingSource.Find("MAMH", RemovedMaKhoa);
                    return;
                }
            }

            CheckButtonState();
        }

        private void buttonLamMoi_Click(object sender, EventArgs e)
        {
            try
            {
                this.KhoaTableAdapter.Connection.ConnectionString = DBConnection.SubcriberConnectionString;
                this.KhoaTableAdapter.Fill(this.TN_CSDLPTDataSet.KHOA);
                Utils.ShowMessage("Làm mới thành công", Others.NotiForm.FormType.Success, 1);

                CheckButtonState();
            }
            catch (Exception ex)
            {
                Utils.ShowMessage("Lỗi khi tải lại dữ liệu", Others.NotiForm.FormType.Error, 1);
                Console.WriteLine(ex.StackTrace);
                return;
            }
        }

        private bool IsMaKhoaValid()
        {
            string maKhoa = TextMaKhoa.Text;
            if (string.IsNullOrEmpty(maKhoa))
            {
                Utils.SetTextEditError(MaKHEP, TextMaKhoa, "Vui lòng nhập mã khoa!");
                Utils.ShowMessage("Vui lòng điền đầy đủ thông tin cần thiết", Others.NotiForm.FormType.Error, 2);
                return false;
            }

            if (!origMaKH.Equals(maKhoa.ToLower()) && MaKhoaAlreadyExists(maKhoa))
            {
                Utils.SetTextEditError(MaKHEP, TextMaKhoa, "Mã khoa đã tồn tại");
                Utils.ShowMessage("Thông tin vừa nhập đã tồn tại", Others.NotiForm.FormType.Error, 2);
                return false;
            }

            return true;
        }

        private bool IsTenKhoaValid()
        {
            string tenKhoa = TextTenKhoa.Text;
            if (string.IsNullOrEmpty(tenKhoa))
            {
                Utils.SetTextEditError(TenKHEP, TextTenKhoa, "Vui lòng nhập tên khoa!");
                Utils.ShowMessage("Vui lòng điền đầy đủ thông tin cần thiết", Others.NotiForm.FormType.Error, 2);
                return false;
            }


            if (!origTenKH.Equals(tenKhoa.ToLower()) && TenKhoaAlreadyExists(tenKhoa))
            {
                Utils.SetTextEditError(MaKHEP, TextTenKhoa, "Tên khoa đã tồn tại");
                Utils.ShowMessage("Thông tin vừa nhập đã tồn tại", Others.NotiForm.FormType.Error, 2);
                return false;
            }

            return true;
        }

        private void buttonXacNhan_Click(object sender, EventArgs e)
        {
            TextMaKhoa.Text = TextMaKhoa.Text.Trim();
            TextTenKhoa.Text = Utils.CapitalizeString(TextTenKhoa.Text.Trim(), Utils.CapitalMode.FirstWordOnly);

            if (!IsMaKhoaValid() || !IsTenKhoaValid())
            {
                return;
            }

            try
            {
                KhoaBindingSource.EndEdit();
                KhoaBindingSource.ResetCurrentItem();
                KhoaTableAdapter.Update(TN_CSDLPTDataSet.KHOA);
                String message = string.Empty;
                if (state == State.edit)
                {
                    message = "Sửa khoa thành công!";
                }
                else if (state == State.add)
                {
                    message = "Thêm môn học thành công!";
                }
                Utils.ShowMessage(message, Others.NotiForm.FormType.Success, 1);
                state = State.idle;
                Utils.SetTextEditError(TenKHEP, TextTenKhoa, null);
                Utils.SetTextEditError(MaKHEP, TextMaKhoa, null);
                KhoaGridControl.Enabled = true;
                SetInfoPanel(false, DisabledForeColor, "Thông tin môn học");
                SetIdleButtonEnabled(true);
                SetInputButtonEnabled(false);
                CheckButtonState();
                origMaKH = origTenKH = "~!@#$%";
            }
            catch (Exception ex)
            {
                Utils.ShowErrorMessage($"Không thể lưu môn học, xin vui lòng thử lại sau\n{ex.Message}", "Lỗi ghi nhân viên");
                return;
            }
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            SetInfoPanel(true, ActiveForeColor, "Sửa thông tin môn học");
            SetIdleButtonEnabled(false);
            SetInputButtonEnabled(true);
            KhoaGridControl.Enabled = false;
            state = State.edit;
            origMaKH = TextMaKhoa.Text.Trim().ToLower();
            origTenKH = TextTenKhoa.Text.Trim().ToLower();
        }
    }
}