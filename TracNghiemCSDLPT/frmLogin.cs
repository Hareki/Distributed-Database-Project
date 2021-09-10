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
using System.Windows.Forms;

namespace TracNghiemCSDLPT
{
    
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        public frmLogin()
        {
            InitializeComponent();
            if (ComboBoxCoSo.Items.Count > 0)
            {
                ComboBoxCoSo.SelectedIndex = 0;
            }
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
            if (FieldPasword.Text.Equals(""))
                FieldPasword.UseSystemPasswordChar = false;
            else if (ShowPassword == true)
                FieldPasword.UseSystemPasswordChar = true;
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

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FieldPasword_OnIconRightClick(object sender, EventArgs e)
        {
            if (FieldPasword.UseSystemPasswordChar == true)
            {
                ShowPassword = false;
                FieldPasword.IconRight = global::TracNghiemCSDLPT.Properties.Resources.invisible_512px;
                FieldPasword.UseSystemPasswordChar = false;
            }
            else
            {
                ShowPassword = true;
                FieldPasword.IconRight = global::TracNghiemCSDLPT.Properties.Resources.eye_512px;
                FieldPasword.UseSystemPasswordChar = true;
            }
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