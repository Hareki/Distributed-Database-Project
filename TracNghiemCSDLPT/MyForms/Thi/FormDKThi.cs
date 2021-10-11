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
using TracNghiemCSDLPT.SQL_Connection;

namespace TracNghiemCSDLPT.MyForms.Thi
{
    public partial class FormDKThi : DevExpress.XtraEditors.XtraForm
    {
        public FormDKThi()
        {
            InitializeComponent();
        }

        private void mONHOCBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.MonHocBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.TN_CSDLPTDataSet);

        }

        private void FormDKThi_Load(object sender, EventArgs e)
        {
            this.TN_CSDLPTDataSet.EnforceConstraints = false;
            this.GVDKTableAdapter.Connection.ConnectionString = DBConnection.SubcriberConnectionString;
            this.LopTableAdapter.Connection.ConnectionString = DBConnection.SubcriberConnectionString;
            this.MonHocTableAdapter.Connection.ConnectionString = DBConnection.SubcriberConnectionString;
           
            this.GVDKTableAdapter.Fill(this.TN_CSDLPTDataSet.GIAOVIEN_DANGKY);
            this.LopTableAdapter.Fill(this.TN_CSDLPTDataSet.LOP);
            this.MonHocTableAdapter.Fill(this.TN_CSDLPTDataSet.MONHOC);

        }
    }
}