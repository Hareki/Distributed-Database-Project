using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TracNghiemCSDLPT.Others
{
    public partial class ConfirmForm : Form
    {
        public ConfirmForm()
        {
            InitializeComponent();
        }
        public ConfirmForm(string message, string message2)
        {
            InitializeComponent();
            ShowForm(message, message2);
        }

        public bool Confirmed;

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            Confirmed = true;
            HideForm();
        }

        public void HideForm()
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Confirmed = false;
            HideForm();
        }



        public void ShowForm(string message, string message2)
        {
            this.message.Text = message;
            this.lblTieuDe.Text = message2;
            this.ShowDialog();
        }

        private void pictureClose_Click(object sender, EventArgs e)
        {
            Confirmed = false;
            HideForm();
        }
    }
}
