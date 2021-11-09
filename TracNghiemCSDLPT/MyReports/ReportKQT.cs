using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace TracNghiemCSDLPT.MyReports
{
    public partial class ReportKQT : DevExpress.XtraReports.UI.XtraReport
    {
        public ReportKQT()
        {
            InitializeComponent();
        }

        public ReportKQT(string maSv, string maMh,int lan, string connectionString)
        {
            InitializeComponent();
           // this.bANGDIEMTableAdapter.Connection.ConnectionString = connectionString;
            this.sqlDataSource1.Connection.ConnectionString = connectionString;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = maSv;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = maMh;
            this.sqlDataSource1.Queries[0].Parameters[2].Value = lan;
            this.sqlDataSource1.Fill();

        }
    }
}
