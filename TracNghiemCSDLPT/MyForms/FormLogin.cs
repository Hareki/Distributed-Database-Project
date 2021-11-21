using DevExpress.Skins;
using DevExpress.Skins.XtraForm;
using DevExpress.Utils.Drawing;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Windows.Forms;
using TracNghiemCSDLPT.Others;
using static Bunifu.UI.WinForms.BunifuTextBox;

namespace TracNghiemCSDLPT.MyForms
{

    public partial class FormLogin : DevExpress.XtraEditors.XtraForm
    {
        public FormLogin()
        {
            InitializeComponent();
            InitializeUI();
            AutoFilled();
        }
        public StateProperties ErrorState;
        private Color _errorColor = Color.FromArgb(236, 65, 52);
        private void InitializeUI()
        {
            DataTable dataTable = GetSubcriber();
            if (dataTable == null)
            {
                return;
            }
            ComboBoxCoSo.DataSource = DBConnection.BsSubcribers.DataSource = dataTable;
            ComboBoxCoSo.DisplayMember = "TENCS";
            ComboBoxCoSo.ValueMember = "TENSERVER";
            ComboBoxCoSo.SelectedIndex = -1;
        }
        private DataTable GetSubcriber()
        {
            if (!DBConnection.ConnectToPublisher())
            {
                Utils.ShowMessage("Kết nối đến CSDL thất bại. " +
                     "Vui lòng xem lại tên server và tên CSDL trong chuỗi kết nối",
                     Others.NotiForm.FormType.Error, 3);
                return null;
            }


            string query = "SELECT * FROM view_GetSubcribers";
            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, DBConnection.PublisherConnection);
            dataAdapter.Fill(dataTable);
            DBConnection.PublisherConnection.Close();
            return dataTable;
        }
        protected override FormPainter CreateFormBorderPainter()
        {
            return new MyFormPainter(this, DevExpress.LookAndFeel.UserLookAndFeel.Default.ActiveLookAndFeel);
        }
        bool _showPassword = true;

        private void AutoFilled()
        {
            ComboBoxCoSo.SelectedIndex = 0;
            rdoSV.Checked = true;
            TextLogin.Text = "002";
            TextPassword.Text = "shiba123";

        }
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
                if (!DBConnection.ConnectToSubcriber(loginName, password, ComboBoxCoSo.SelectedValue.ToString()))
                {
                    Utils.ShowMessage("Tài khoản, mật khẩu hoặc cơ sở không chính xác. Vui lòng xem " +
                        "lại thông tin đăng nhập.", Others.NotiForm.FormType.Error, 4);
                    return;
                }


                List<Para> paraList = new List<Para>();
                paraList.Add(new Para("@LoginName", loginName));
                string spName = "usp_LoginGV_GetInfoByLogin";
                SqlDataReader myReader = DBConnection.ExecuteSqlDataReaderSP(spName, paraList);
                if (myReader == null)
                {
                    Console.WriteLine(System.Environment.StackTrace);
                    return;
                }
                myReader.Read();
                DBConnection.UserName = myReader.GetString(0); // Lấy Mã GV, chính là Username ở cột 1.
                DBConnection.HoTen = myReader.GetString(1);
                DBConnection.NhomQuyen = myReader.GetString(2);
                DBConnection.IndexCS = ComboBoxCoSo.SelectedIndex;
                myReader.Close();
                Program.MainInstance = new MainView();
                Program.MainInstance.statusMa.Caption = "Mã GV: " + DBConnection.UserName;
                Program.MainInstance.statusTen.Caption = "Họ tên: " + DBConnection.HoTen;
                Program.MainInstance.statusQuyen.Caption = "Nhóm: " +
                    DBConnection.GetVnTextNhomQuyen(DBConnection.NhomQuyen);
                Program.MainInstance.Show();
                this.Hide();
            }
            else
            {
                if (!DBConnection.ConnectToSubcriber(ComboBoxCoSo.SelectedValue.ToString()))
                {
                    Utils.ShowMessage("Kết nối đến CSDL thất bại. " +
                        "Login hoặc password của sinh viên trong chuỗi kết nối không chính xác", Others.NotiForm.FormType.Error, 3);
                    return;
                }

                string spName = "usp_LoginSV_GetInfoByLogin";

                List<Para> paraList = new List<Para>();
                paraList.Add(new Para("@LoginName", loginName));
                paraList.Add(new Para("@Password", password));
                SqlDataReader myReader = DBConnection.ExecuteSqlDataReaderSP(spName, paraList);
                if (myReader == null)
                {
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

                DBConnection.UserName = DBConnection.UserNameSV;
                DBConnection.HoTen = myReader.GetString(1);
                DBConnection.NhomQuyen = myReader.GetString(2);
                DBConnection.MaSv = loginName;
                myReader.Close();
                Program.MainInstance = new MainView();
                Program.MainInstance.statusMa.Caption = "Mã SV: " + loginName;
                Program.MainInstance.statusTen.Caption = "Họ tên: " + DBConnection.HoTen;
                Program.MainInstance.statusQuyen.Caption = "Nhóm: " + 
                    DBConnection.GetVnTextNhomQuyen(DBConnection.NhomQuyen);
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
                DBConnection.SubcriberName = ComboBoxCoSo.SelectedValue.ToString();
            }


        }

        private void FieldPasword_OnIconRightClick(object sender, EventArgs e)
        {
            if (TextPassword.UseSystemPasswordChar == true)
            {
                _showPassword = false;
                TextPassword.IconRight = global::TracNghiemCSDLPT.Properties.Resources.eye_512px;
                TextPassword.UseSystemPasswordChar = false;
            }
            else
            {
                _showPassword = true;
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
                SetBorderState(TextLogin, BorderState.Error);
                return false;
            }
            else
            {
                SetBorderState(TextLogin, BorderState.Normal);
                LoginEP.SetError(TextLogin, null);
                return true;
            }

        }
        private bool ValidateCoSo()
        {
            if (ComboBoxCoSo.SelectedIndex == -1)
            {
                ComboBoxCoSo.BorderColor = _errorColor;
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
                SetBorderState(TextPassword, BorderState.Error);
                return false;
            }
            else
            {
                PasswordEP.SetError(TextPassword, null);
                SetBorderState(TextPassword, BorderState.Normal);
                return true;
            }

        }

        private bool ValidateNhomQuyen()
        {
            if (!rdoGV.Checked && !rdoSV.Checked)
            {
                RdoEP.SetError(PanelSV, "Vui lòng chọn nhóm quyền");
                PanelSV.BorderColor = _errorColor;
                PanelGV.BorderColor = _errorColor;
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
            Normal, Error
        }
        private void SetBorderState(Guna2TextBox textBox, BorderState state)
        {
            if (state == BorderState.Error)
            {
                textBox.BorderColor = textBox.HoverState.BorderColor =
                   textBox.FocusedState.BorderColor = _errorColor;


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


        private void TextLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                RequestLogin();
            }

        }

        private void guna2TextBox1_IconRightClick(object sender, EventArgs e)
        {
            if (TextPassword.UseSystemPasswordChar == true)
            {
                _showPassword = false;
                TextPassword.IconRight = global::TracNghiemCSDLPT.Properties.Resources.eye_512px;
                TextPassword.UseSystemPasswordChar = false;
            }
            else
            {
                _showPassword = true;
                TextPassword.IconRight = global::TracNghiemCSDLPT.Properties.Resources.invisible_512px;
                TextPassword.UseSystemPasswordChar = true;
            }
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            if (TextPassword.Text.Equals(""))
                TextPassword.UseSystemPasswordChar = false;
            else if (_showPassword == true)
                TextPassword.UseSystemPasswordChar = true;
        }

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
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