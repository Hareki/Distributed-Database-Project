using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using TracNghiemCSDLPT.Others;

namespace TracNghiemCSDLPT.MyForms.TaiKhoan
{
    public partial class FormTaoLogin : DevExpress.XtraEditors.XtraForm
    {
        public FormTaoLogin()
        {
            InitializeComponent();
        }

        private void PhanQuyen()
        {
            switch (DbConnection.NhomQuyen)
            {
                case "TRUONG":
                    LoadGvData();
                    LookUpGV.Properties.DataSource = DSGVBindingSource;
                    LookUpGV.Properties.DisplayMember = "FullInfo";
                    LookUpGV.Properties.ValueMember = "MaGV";
                    panelCSGV.SendToBack();
                    panelCSGV.Visible = false;
                    rdoCS.Checked = rdoGV.Checked = false;
                    rdoTruong.Checked = true;
                    break;
                case "COSO":
                    LoadGvtcsData();
                    LookUpGV.Properties.DataSource = DSGVTCSBindingSource;
                    LookUpGV.Properties.DisplayMember = "FullInfo";
                    LookUpGV.Properties.ValueMember = "MaGV";
                    rdoTruong.Checked = false;
                    panelTruong.Visible = false;
                    panelCSGV.BringToFront();
                    break;
            }
        }

        private void LoadGvData()
        {
            this.DSGVTableAdapter.Connection.ConnectionString = DbConnection.SubcriberConnectionString;
            this.DSGVTableAdapter.Fill(this.TN_CSDLPTDataSet.DSGIAOVIEN);
        }
        private void LoadGvtcsData()
        {
            this.DSGVTCSTableAdapter.Connection.ConnectionString = DbConnection.SubcriberConnectionString;
            this.DSGVTCSTableAdapter.Fill(this.TN_CSDLPTDataSet.DSGIAOVIENTCS);
        }

        private void FormTaoLogin_Load(object sender, EventArgs e)
        {
            TextMatKhau.UseSystemPasswordChar = TextXacNhan.UseSystemPasswordChar = true;
            PhanQuyen();
        }

        private void buttonDangKy_Click(object sender, EventArgs e)
        {
            bool test1 = LookUpGV.EditValue is null;
            bool test2 = (!rdoCS.Checked && !rdoGV.Checked && panelCSGV.Visible == true) || (!rdoTruong.Checked && panelTruong.Visible == true);
            bool test3 = string.IsNullOrEmpty(TextTenDangNhap.Text);
            bool test4 = !TextMatKhau.Text.Equals(TextXacNhan.Text) || string.IsNullOrEmpty(TextMatKhau.Text);
            bool test5 = !Utils.IsMathRegex(TextTenDangNhap.Text, Utils.RegexType.LoginNameRegex);
            if (test1 || test2 || test3 || test4)
            {
                Utils.ShowMessage("Vui lòng xem lại thông tin đã nhập", Others.NotiForm.FormType.Error, 2);
                if (test1)
                    LookUpEP.SetError(LookUpGV, "Vui lòng chọn giáo viên để cấp tài khoản");
                else LookUpEP.SetError(LookUpGV, null);
                if (test2)
                    AccTypeEP.SetError(panelCSGV, "Vui lòng chọn loại tài khoản");
                else AccTypeEP.SetError(panelCSGV, null);
                if (test3)
                    TenDangNhapEP.SetError(TextTenDangNhap, "Vui lòng nhập tên tài khoản");
                else TenDangNhapEP.SetError(TextTenDangNhap, null);
                if (test4)
                {
                    XacNhanEP.SetError(TextXacNhan, "Mật khẩu và xác nhận mất khẩu phải giống nhau và không được trống");
                    MatKhauEP.SetError(TextMatKhau, "Mật khẩu và xác nhận mất khẩu phải giống nhau và không được trống");
                }
                else
                {
                    XacNhanEP.SetError(TextXacNhan, null);
                    MatKhauEP.SetError(TextMatKhau, null);
                }
                if (test5 && !test3)
                    TenDangNhapEP.SetError(TextTenDangNhap, "Tên tài khoản chỉ được chứa ký tự '/', '.' chữ và số");
                return;
            }
            string loginName = TextTenDangNhap.Text.Trim();
            string password = TextMatKhau.Text;
            string maGv = (LookUpGV.GetSelectedDataRow() as DataRowView)["MaGV"].ToString();
            string accType;
            if (panelCSGV.Visible)
                accType = rdoCS.Checked ? "COSO" : "GIAOVIEN";
            else accType = "TRUONG";

            List<Para> paraList = new List<Para>();
            paraList.Add(new Para("@LoginName", loginName));
            paraList.Add(new Para("@Password", password));
            paraList.Add(new Para("@Username", maGv));
            paraList.Add(new Para("@Role", accType));

            string spName = "usp_Login_AddLoginUser";


            SqlDataReader myReader = DbConnection.ExecuteSqlDataReaderSp(spName, paraList);
            if (myReader == null)
            {
                Console.WriteLine(System.Environment.StackTrace);
                return;
            }
            myReader.Read();
            int result = int.Parse(myReader.GetValue(0).ToString());
            myReader.Close();
            switch (result)
            {
                case 1:
                    {
                        TenDangNhapEP.SetError(TextTenDangNhap, "Tên đăng nhập đã tồn tại, vui lòng thử tên khác");
                        Utils.ShowMessage("Tên đăng nhập đã tồn tại, vui lòng thử tên khác", Others.NotiForm.FormType.Warning, 2);
                        return;
                    }

                case 2:
                    {
                        TenDangNhapEP.SetError(TextTenDangNhap, "Giảng viên này đã có tài khoản, không thể tạo thêm");
                        Utils.ShowMessage("Giảng viên này đã có tài khoản, không thể tạo thêm", Others.NotiForm.FormType.Warning, 2);
                        return;
                    }
                case 0:
                    {
                        TextTenDangNhap.Text = TextMatKhau.Text =
                        TextXacNhan.Text = string.Empty;
                        rdoCS.Checked = rdoGV.Checked = false;
                        break;
                    }
            }
            Utils.ShowMessage("Đăng ký thành công!", Others.NotiForm.FormType.Success, 1);


        }

        private void LabelGiangVien_Click(object sender, EventArgs e)
        {
            rdoGV.Checked = true;
            rdoCS.Checked = !rdoGV.Checked;
        }

        private void LabelCoSo_Click(object sender, EventArgs e)
        {
            rdoCS.Checked = true;
            rdoGV.Checked = !rdoCS.Checked;
        }

        private void ToggleHienMK_CheckedChanged(object sender, EventArgs e)
        {
            TextMatKhau.UseSystemPasswordChar = !TextMatKhau.UseSystemPasswordChar;
            TextXacNhan.UseSystemPasswordChar = !TextXacNhan.UseSystemPasswordChar;
        }

        private void buttonHuy_Click(object sender, EventArgs e)
        {
            if (Utils.ShowConfirmMessage("Hủy thao tác đăng ký tài khoản? Mọi dữ liệu đang nhập sẽ bị xóa.", "Xác nhận"))
            {
                this.Close();
            }
        }
    }
}