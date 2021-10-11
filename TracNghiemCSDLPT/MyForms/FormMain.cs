using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TracNghiemCSDLPT.MyForms.QuanLy;
using TracNghiemCSDLPT.Views;
using TracNghiemCSDLPT.SQL_Connection;
using TracNghiemCSDLPT.MyForms.Thi;

namespace TracNghiemCSDLPT
{
    public partial class MainView : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public MainView()
        {
            InitializeComponent();
            PhanQuyen();
        }

        private void PhanQuyen()
        {
            switch (DBConnection.NhomQuyen)
            {
                case "TRUONG":
                    buttonToChucThi.Enabled = buttonThamGiaThi.Enabled = false;
                    break;
                case "COSO":
                    buttonThamGiaThi.Caption = "Thi thử";
                    break;
                case "GIAOVIEN":
                    buttonMonHoc.Enabled = buttonSVL.Enabled = buttonKhoa.Enabled
                        = buttonGV.Enabled = false;

                    buttonDKTN.Enabled  = false;
                    buttonToChucThi.Enabled = false;
                    buttonThamGiaThi.Caption = "Thi thử";
                    buttonTaoTK.Enabled = false;
                    break;
                case "SINHVIEN":
                    buttonToChucThi.Visibility = BarItemVisibility.Never;
                    pageQuanLy.Visible = pageBaoCao.Visible = false;
                    buttonTaoTK.Visibility = BarItemVisibility.Never;
                    break;
            }
        }

        private Form GetFormIfExists(Type type)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == type)
                    return f;
            }
            return null;
        }

        private void showForm(Type type)
        {
            Form form = GetFormIfExists(type);
            if (form != null)
                form.Activate();
            else
            {
                form = (Form)Activator.CreateInstance(type);
                form.MdiParent = this;
                form.Show();
            }
        }

        private void buttonMonHoc_ItemClick(object sender, ItemClickEventArgs e)
        {
            showForm(typeof(FormMonHoc));
        }

        private void MainView_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Program.FormLogin.Close();
            Application.Exit();
        }

        private void buttonBangDiem_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void buttonSinhVien_ItemClick(object sender, ItemClickEventArgs e)
        {
            showForm(typeof(FormSVL));
        }

        private void buttonTaoTK_ItemClick(object sender, ItemClickEventArgs e)
        {
            showForm(typeof(FormTaoLogin));
        }

        private void buttonKhoaLop_ItemClick(object sender, ItemClickEventArgs e)
        {
            showForm(typeof(FormKhoa));
        }

        private void butonGiaoVien_ItemClick(object sender, ItemClickEventArgs e)
        {
            showForm(typeof(FormGV));
        }

        private void buttonDeThi_ItemClick(object sender, ItemClickEventArgs e)
        {
            showForm(typeof(FormCauHoi));
        }

        private void buttonDKTN_ItemClick(object sender, ItemClickEventArgs e)
        {
            showForm(typeof(FormDSDKTTN));
        }

        private void buttonDangXuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            if(Utils.ShowConfirmMessage("Bạn có chắc muốn đăng xuất khỏi hệ thống?", "Xác nhận")){
                Program.LoginInstance = new FormLogin();
                Program.LoginInstance.Show();
                this.Hide();
            }
        }

        private void buttonToChucThi_ItemClick(object sender, ItemClickEventArgs e)
        {
            showForm(typeof(FormDKThi));
        }

        private void buttonKQThi_ItemClick(object sender, ItemClickEventArgs e)
        {

        }
    }

}