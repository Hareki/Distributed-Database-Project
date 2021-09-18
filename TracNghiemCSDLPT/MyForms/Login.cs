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

namespace TracNghiemCSDLPT
{

    public partial class Login : DevExpress.XtraEditors.XtraForm
    {
        public Login()
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
            SqlConnection MyConnection = MySQLConncetion.GetPublisherConnection();
            if (MyConnection == null)
                return null;

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

        private void rdoGV_Click(object sender, EventArgs e)
        {
            rdoSV.Checked = !rdoGV.Checked;
        }

        private void rdoSV_Click(object sender, EventArgs e)
        {
            rdoGV.Checked = !rdoSV.Checked;
        }

        private void FieldPasword_TextChange(object sender, EventArgs e)
        {
            if (TextPassword.Text.Equals(""))
                TextPassword.UseSystemPasswordChar = false;
            else if (ShowPassword == true)
                TextPassword.UseSystemPasswordChar = true;
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

            if (loginName.Equals("") || password.Equals(""))
            {
                Utils.ShowErrorMessage("Không được để trống tên đăng nhập và mật khẩu", "Lỗi đăng nhập");
                return;
            }
            if (MySQLConncetion.GetSubcriberConnection(loginName, password, ComboBoxCoSo.SelectedValue.ToString()) == null)
            {
                return;
            }


            string query = "EXEC SP_GET_INFO_FROM_LOGIN_NAME '" + loginName + "'";
            SqlDataReader myReader = MySQLConncetion.ExecuteSqlDataReader(query);
            if (myReader == null)
            {
                Utils.ShowErrorMessage("Xảy ra lỗi không xác định", "Lỗi kết nối");
                Console.WriteLine(System.Environment.StackTrace);
                return;
            }
            myReader.Read();
            Program.UserName = myReader.GetString(0); // Lấy Mã GV, chính là Username ở cột 1.
            Program.HoTen = myReader.GetString(1);
            Program.Quyen = myReader.GetString(2);
            myReader.Close();
            Program.FormMain = new MainView();
            Program.FormMain.statusMa.Caption = "Mã GV: " + Program.UserName;
            Program.FormMain.statusTen.Caption = "Họ tên: " + Program.HoTen;
            Program.FormMain.statusQuyen.Caption = "Nhóm: " + Program.Quyen;
            Program.FormMain.Show();
            this.Hide();
            
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