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

namespace TracNghiemCSDLPT.Views
{
    public partial class MonHoc : DevExpress.XtraEditors.XtraForm
    {
        public MonHoc()
        {
            InitializeComponent();
        }



        private void MonHoc_Load(object sender, EventArgs e)
        { 
            this.MonHocTableAdapter.Fill(this.TN_CSDLPTDataSet.MONHOC);
        }
    }
}