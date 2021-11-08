using DevExpress.XtraBars;
using System;
using System.Windows.Forms;
using TracNghiemCSDLPT.MyForms.BaoCao;
using TracNghiemCSDLPT.MyForms.QuanLy;
using TracNghiemCSDLPT.MyForms.TaiKhoan;
using TracNghiemCSDLPT.MyForms.Thi;
using TracNghiemCSDLPT.Others;

namespace TracNghiemCSDLPT.MyForms
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

                    buttonDKTN.Enabled = false;
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

        private void ShowForm(Type type)
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
            ShowForm(typeof(FormMonHoc));
        }

        private void MainView_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Program.FormLogin.Close();
            Application.Exit();
        }

        private void buttonBangDiem_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowForm(typeof(FormBDMH));
        }

        private void buttonSinhVien_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowForm(typeof(FormSvl));
        }

        private void buttonTaoTK_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowForm(typeof(FormTaoLogin));
        }

        private void buttonKhoaLop_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowForm(typeof(FormKhoa));
        }

        private void butonGiaoVien_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowForm(typeof(FormGv));
        }

        private void buttonDeThi_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowForm(typeof(FormCauHoi));
        }

        private void buttonDKTN_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowForm(typeof(FormDSDKTTN));
        }

        private void buttonDangXuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Utils.ShowConfirmMessage("Bạn có chắc muốn đăng xuất khỏi hệ thống?", "Xác nhận"))
            {
                Program.LoginInstance = new FormLogin();
                Program.LoginInstance.Show();
                this.Hide();
            }
        }

        private void buttonToChucThi_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowForm(typeof(FormDkThi));
        }

        private void buttonKQThi_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowForm(typeof(FormKQT));
        }
    }

}