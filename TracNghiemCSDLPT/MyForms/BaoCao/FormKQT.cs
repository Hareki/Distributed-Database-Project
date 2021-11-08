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

namespace TracNghiemCSDLPT.MyForms.BaoCao
{
    public partial class FormKQT : DevExpress.XtraEditors.XtraForm
    {
        public FormKQT()
        {
            InitializeComponent();
        }

        private void FormKQT_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tN_CSDLPTDataSet.DSMONHOC' table. You can move, or remove it, as needed.
            this.DSMHTableAdapter.Fill(this.TN_CSDLPTDataSet.DSMONHOC);
            // TODO: This line of code loads data into the 'tN_CSDLPTDataSet.DSSINHVIEN' table. You can move, or remove it, as needed.
            this.DSSVTableAdapter.Fill(this.TN_CSDLPTDataSet.DSSINHVIEN);

        }
    }
}