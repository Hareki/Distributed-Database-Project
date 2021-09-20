using DevExpress.Skins;
using DevExpress.Skins.XtraForm;
using DevExpress.Utils.Drawing;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using TracNghiemCSDLPT.SQL_Connection;
using System.Windows.Forms;
using System.Data.SqlTypes;

namespace TracNghiemCSDLPT
{

    public partial class FormLogin : DevExpress.XtraEditors.XtraForm
    {
        public FormLogin()
        {
            InitializeComponent();
            InitializeUI();
        }


        private void InitializeUI()
        {
            DataTable dataTable = GetSubcriber();
            if (dataTable == null)
            {
                Utils.ShowErrorMessage("Lỗi không xác định", "Lỗi kết nối");
                return;
            }
            ComboBoxCoSo.DataSource = Program.BS_Subcribers.DataSource = dataTable;
            ComboBoxCoSo.DisplayMember = "TENCS";
            ComboBoxCoSo.ValueMember = "TENSERVER";
            if (ComboBoxCoSo.Items.Count > 0)
                ComboBoxCoSo.SelectedIndex = 0;
        }
        private DataTable GetSubcriber()
        {
            SqlConnection MyConnection = MySQLConnection.GetPublisherConnection();
            if (MyConnection == null)
            {
                Utils.ShowErrorMessage("Kết nối đến CSDL thất bại. " +
                     "Vui lòng xem lại tên server và tên CSDL trong chuỗi kết nối", "Lỗi kết nối");
                return null;
            }


            string query = "SELECT * FROM V_GET_SUBSCRIBER";
            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, MyConnection);
            dataAdapter.Fill(dataTable);
            MyConnection.Close();
            return dataTable;
        }
        protected override FormPainter CreateFormBorderPainter()
        {
            return new MyFormPainter(this, DevExpress.LookAndFeel.UserLookAndFeel.Default.ActiveLookAndFeel);
        }
        bool ShowPassword = true;


        private void LabelGiangVien_Click(object sender, EventArgs e)
        {
            rdoGV.Checked = true;
            rdoSV.Checked = !rdoGV.Checked;
            ValidateNhomQuyen();
        }

        private void LabelSinhVien_Click(object sender, EventArgs e)
        {
            rdoSV.Checked = true;
            rdoGV.Checked = !rdoSV.Checked;
            ValidateNhomQuyen();
        }

        private void ComboBoxCoSo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Program.SubcriberName = ComboBoxCoSo.SelectedValue.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FieldPasword_OnIconRightClick(object sender, EventArgs e)
        {
            if (TextPassword.UseSystemPasswordChar == true)
            {
                ShowPassword = false;
                TextPassword.IconRight = global::TracNghiemCSDLPT.Properties.Resources.eye_512px;
                TextPassword.UseSystemPasswordChar = false;
            }
            else
            {
                ShowPassword = true;
                TextPassword.IconRight = global::TracNghiemCSDLPT.Properties.Resources.invisible_512px;
                TextPassword.UseSystemPasswordChar = true;
            }
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void buttonDangNhap_Click(object sender, EventArgs e)
        {
            string loginName = TextLogin.Text.Trim();
            string password = TextPassword.Text.Trim();

            Program.LoginName = loginName;
            Program.Password = password;

            bool test1 = ValidatePassword();
            bool test2 = ValidateLoginName();
            bool test3 = ValidateNhomQuyen();
            if (!(test1 && test2 && test3))
                return;
            if (rdoGV.Checked)
            {
                if (MySQLConnection.GetSubcriberConnection(loginName, password, ComboBoxCoSo.SelectedValue.ToString()) == null)
                {
                    Utils.ShowErrorMessage("Kết nối đến CSDL thất bại. " +
                        "Tài khoản, mật khẩu hoặc cơ sở không chính xác. Vui lòng xem " +
                        "lại thông tin đăng nhập.", "Lỗi đăng nhập");
                    return;
                }


                string query = "EXEC SP_GET_GV_INFO_FROM_LOGIN_NAME '" + loginName + "'";
                SqlDataReader myReader = MySQLConnection.ExecuteSqlDataReader(query);
                if (myReader == null)
                {
                    Utils.ShowErrorMessage("Xảy ra lỗi không xác định", "Lỗi kết nối");
                    Console.WriteLine(System.Environment.StackTrace);
                    return;
                }
                myReader.Read();
                Program.UserName = myReader.GetString(0); // Lấy Mã GV, chính là Username ở cột 1.
                Program.HoTen = myReader.GetString(1);
                Program.NhomQuyen = myReader.GetString(2);
                myReader.Close();
                Program.MainInstance = new MainView();
                Program.MainInstance.statusMa.Caption = "Mã GV: " + Program.UserName;
                Program.MainInstance.statusTen.Caption = "Họ tên: " + Program.HoTen;
                Program.MainInstance.statusQuyen.Caption = "Nhóm: " + Program.NhomQuyen;
                Program.MainInstance.Show();
                this.Hide();
            }
            else
            {
                if (MySQLConnection.GetSubcriberConnection(ComboBoxCoSo.SelectedValue.ToString()) == null)
                {
                    Utils.ShowErrorMessage("Kết nối đến CSDL thất bại. " +
                        "Login hoặc password của sinh viên trong chuỗi kết nối không chính xác", "Lỗi" +
                        "đăng nhập");
                    return;
                }
                string query = "EXEC SP_GET_SV_INFO_FROM_LOGIN_NAME '" + loginName + "', '"
                    + password + "'";
                SqlDataReader myReader = MySQLConnection.ExecuteSqlDataReader(query);
                if (myReader == null)
                {
                    Utils.ShowErrorMessage("Xảy ra lỗi không xác định", "Lỗi kết nối");
                    Console.WriteLine(System.Environment.StackTrace);
                    return;
                }
                myReader.Read();
                try
                {
                    myReader.GetString(1);
                }
                catch(SqlNullValueException ex)
                {
                    Utils.ShowErrorMessage("Kết nối đến CSDL thất bại. " +
                        "Mã sinh viên, mật khẩu hoặc cơ sở không chính xác. Vui lòng xem " +
                        "lại thông tin đăng nhập.", "Lỗi đăng nhập");
                    return;
                }
                Program.UserName = "USER_SINHVIEN"; // Lấy Mã GV, chính là Username ở cột 1.
                Program.HoTen = myReader.GetString(1);
                Program.NhomQuyen = myReader.GetString(2);
                myReader.Close();
                Program.MainInstance = new MainView();
                Program.MainInstance.statusMa.Caption = "Mã SV: " + Program.UserName;
                Program.MainInstance.statusTen.Caption = "Họ tên: " + Program.HoTen;
                Program.MainInstance.statusQuyen.Caption = "Nhóm: " + Program.NhomQuyen;
                Program.MainInstance.Show();
                this.Hide();
            }



        }
        private bool ValidateLoginName()
        {
            if (string.IsNullOrEmpty(TextLogin.Text))
            {
                LoginEP.SetError(TextLogin, "Vui lòng nhập tài khoản");
                return false;
            }
            else
            {
                LoginEP.SetError(TextLogin, null);
                return true;
            }



        }
        private bool ValidatePassword()
        {
            if (string.IsNullOrEmpty(TextPassword.Text))
            {
                PasswordEP.SetError(TextPassword, "Vui lòng nhập mật khẩu");
                return false;
            }
            else
            {
                PasswordEP.SetError(TextPassword, null);
                return true;
            }

        }

        private bool ValidateNhomQuyen()
        {
            if (!rdoGV.Checked && !rdoSV.Checked)
            {
                RdoEP.SetError(PanelSV, "Vui lòng chọn nhóm quyền");
                return false;
            }
            else
            {
                RdoEP.SetError(PanelSV, null);
                return true;
            }
        }


        private void TextLogin_TextChange(object sender, EventArgs e)
        {
            ValidateLoginName();
        }

        private void TextPassword_TextChange(object sender, EventArgs e)
        {
            ValidatePassword();
            if (TextPassword.Text.Equals(""))
                TextPassword.UseSystemPasswordChar = false;
            else if (ShowPassword == true)
                TextPassword.UseSystemPasswordChar = true;
        }

        private void rdoSV_Validating(object sender, CancelEventArgs e)
        {
            ValidateNhomQuyen();
        }

        private void rdoGV_Validating(object sender, CancelEventArgs e)
        {
            ValidateNhomQuyen();
        }
    }

    class MyFormPainter : FormPainter
    {
        public MyFormPainter(Control owner, ISkinProvider provider) : base(owner, provider) { }
        protected override void DrawBackground(GraphicsCache cache)
        {
            base.DrawBackground(cache);
            cache.FillRectangle(Color.FromArgb(255, 255, 255), CaptionBounds);
        }
    }
}