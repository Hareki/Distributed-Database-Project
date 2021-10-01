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
using TracNghiemCSDLPT.MyForms.TabbedForms;
using TracNghiemCSDLPT.Views;

namespace TracNghiemCSDLPT
{
    public partial class MainView : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public MainView()
        {
            InitializeComponent();
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
    }

}