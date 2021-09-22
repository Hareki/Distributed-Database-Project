﻿using DevExpress.Skins;
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
using Bunifu.UI.WinForms;
using static Bunifu.UI.WinForms.BunifuTextBox;
using Guna.UI2.WinForms;

namespace TracNghiemCSDLPT
{

    public partial class FormLogin : DevExpress.XtraEditors.XtraForm
    {
        public FormLogin()
        {
            InitializeComponent();
            InitializeUI();
        }
        public StateProperties ErrorState;
        private Color ErrorColor = Color.FromArgb(236, 65, 52);
        private void InitializeUI()
        {
            DataTable dataTable = GetSubcriber();
            if (dataTable == null)
            {
                Utils.ShowMessage("Lỗi không xác định", Others.NotiForm.FormType.Error, 1);
                return;
            }
            ComboBoxCoSo.DataSource = Program.BS_Subcribers.DataSource = dataTable;
            ComboBoxCoSo.DisplayMember = "TENCS";
            ComboBoxCoSo.ValueMember = "TENSERVER";
            ComboBoxCoSo.SelectedIndex = -1;
        }
        private DataTable GetSubcriber()
        {
            SqlConnection MyConnection = DatabaseConnection.GetPublisherConnection();
            if (MyConnection == null)
            {
                Utils.ShowMessage("Kết nối đến CSDL thất bại. " +
                     "Vui lòng xem lại tên server và tên CSDL trong chuỗi kết nối",
                     Others.NotiForm.FormType.Error, 3);
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

        private void RequestLogin()
        {
            string loginName = TextLogin.Text.Trim();
            string password = TextPassword.Text.Trim();




            bool test1 = ValidatePassword();
            bool test2 = ValidateLoginName();
            bool test3 = ValidateNhomQuyen();
            bool test4 = ValidateCoSo();
            if (!(test1 && test2 && test3 && test4))
            {
                Utils.ShowMessage("Vui lòng điền đầy đủ thông tin đăng nhập!", Others.NotiForm.FormType.Error, 2);
                return;
            }

            if (rdoGV.Checked)
            {
                Program.LoginName = loginName;
                Program.Password = password;
                if (DatabaseConnection.GetSubcriberConnection(loginName, password, ComboBoxCoSo.SelectedValue.ToString()) == null)
                {
                    Utils.ShowMessage("Tài khoản, mật khẩu hoặc cơ sở không chính xác. Vui lòng xem " +
                        "lại thông tin đăng nhập.", Others.NotiForm.FormType.Error, 4);
                    return;
                }


                string query = "EXEC SP_GET_GV_INFO_FROM_LOGIN_NAME '" + loginName + "'";
                SqlDataReader myReader = DatabaseConnection.ExecuteSqlDataReader(query);
                if (myReader == null)
                {
                    Utils.ShowMessage("Xảy ra lỗi không xác định", Others.NotiForm.FormType.Error, 1);
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
                if (DatabaseConnection.GetSubcriberConnection(ComboBoxCoSo.SelectedValue.ToString()) == null)
                {
                    Utils.ShowMessage("Kết nối đến CSDL thất bại. " +
                        "Login hoặc password của sinh viên trong chuỗi kết nối không chính xác", Others.NotiForm.FormType.Error, 3);
                    return;
                }
                string query = "EXEC SP_GET_SV_INFO_FROM_LOGIN_NAME '" + loginName + "', '"
                    + password + "'";
                SqlDataReader myReader = DatabaseConnection.ExecuteSqlDataReader(query);
                if (myReader == null)
                {
                    Utils.ShowMessage("Xảy ra lỗi không xác định", Others.NotiForm.FormType.Error, 1);
                    Console.WriteLine(System.Environment.StackTrace);
                    return;
                }
                myReader.Read();
                try
                {
                    myReader.GetString(1);
                }
                catch (SqlNullValueException ex)
                {
                    Utils.ShowMessage("Mã sinh viên, mật khẩu hoặc cơ sở không chính xác. Vui lòng xem " +
                        "lại thông tin đăng nhập.", Others.NotiForm.FormType.Error, 4);
                    return;
                }
                Program.LoginName = DatabaseConnection.LoginSV;
                Program.Password = DatabaseConnection.PasswordSV;
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

        private void LabelGiangVien_Click(object sender, EventArgs e)
        {
            rdoGV.Checked = true;
            rdoSV.Checked = !rdoGV.Checked;

        }

        private void LabelSinhVien_Click(object sender, EventArgs e)
        {
            rdoSV.Checked = true;
            rdoGV.Checked = !rdoSV.Checked;
        }

        private void ComboBoxCoSo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxCoSo.SelectedIndex != -1)
            {
                Program.SubcriberName = ComboBoxCoSo.SelectedValue.ToString();
            }


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
            RequestLogin();
        }
        private bool ValidateLoginName()
        {
            if (string.IsNullOrEmpty(TextLogin.Text))
            {
                LoginEP.SetError(TextLogin, "Vui lòng nhập tài khoản");
                SetBorderState(TextLogin, BorderState.error);
                return false;
            }
            else
            {
                SetBorderState(TextLogin, BorderState.normal);
                LoginEP.SetError(TextLogin, null);
                return true;
            }

        }
        private bool ValidateCoSo()
        {
            if (ComboBoxCoSo.SelectedIndex == -1)
            {
                ComboBoxCoSo.BorderColor = ErrorColor;
                CSEP.SetError(ComboBoxCoSo, "Vui lòng chọn cơ sở công tác/học tập");
                return false;
            }
            else
            {
                ComboBoxCoSo.BorderColor = Color.FromArgb(204, 208, 213);
                CSEP.SetError(ComboBoxCoSo, null);
                return true;
            }
        }

        private bool ValidatePassword()
        {
            if (string.IsNullOrEmpty(TextPassword.Text))
            {
                PasswordEP.SetError(TextPassword, "Vui lòng nhập mật khẩu");
                SetBorderState(TextPassword, BorderState.error);
                return false;
            }
            else
            {
                PasswordEP.SetError(TextPassword, null);
                SetBorderState(TextPassword, BorderState.normal);
                return true;
            }

        }

        private bool ValidateNhomQuyen()
        {
            if (!rdoGV.Checked && !rdoSV.Checked)
            {
                RdoEP.SetError(PanelSV, "Vui lòng chọn nhóm quyền");
                PanelSV.BorderColor = ErrorColor;
                PanelGV.BorderColor = ErrorColor;
                return false;
            }
            else
            {
                PanelSV.BorderColor = Color.FromArgb(204, 208, 213);
                PanelGV.BorderColor = Color.FromArgb(204, 208, 213);
                RdoEP.SetError(PanelSV, null);
                return true;
            }
        }

        enum BorderState
        {
            normal, error
        }
        private void SetBorderState(Guna2TextBox textBox, BorderState state)
        {
            if (state == BorderState.error)
            {
                textBox.BorderColor = textBox.HoverState.BorderColor =
                   textBox.FocusedState.BorderColor = ErrorColor;


            }
            else
            {
                textBox.FocusedState.BorderColor = Color.FromArgb(16, 110, 190);
                textBox.HoverState.BorderColor = Color.FromArgb(104, 168, 255);
                textBox.BorderColor = Color.Silver;
            }
        }


        private void TextLogin_TextChange(object sender, EventArgs e)
        {
            ValidateLoginName();
        }

        private void TextPassword_TextChange(object sender, EventArgs e)
        {
            if (TextPassword.Text.Equals(""))
                TextPassword.UseSystemPasswordChar = false;
            else if (ShowPassword == true)
                TextPassword.UseSystemPasswordChar = true;
        }


        private void TextLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                RequestLogin();
        }

        private void guna2TextBox1_IconRightClick(object sender, EventArgs e)
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

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            if (TextPassword.Text.Equals(""))
                TextPassword.UseSystemPasswordChar = false;
            else if (ShowPassword == true)
                TextPassword.UseSystemPasswordChar = true;
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