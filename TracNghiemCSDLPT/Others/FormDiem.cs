using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TracNghiemCSDLPT.Others
{
    public partial class FormDiem : Form
    {
        public FormDiem(string soCauDung, string diem)
        {
            InitializeComponent();
            lblSoCauDung.Text = soCauDung;
            lblDiem.Text = diem;
            this.ShowDialog();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
