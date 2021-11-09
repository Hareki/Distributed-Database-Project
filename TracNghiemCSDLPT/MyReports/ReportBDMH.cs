using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace TracNghiemCSDLPT.MyReports
{
    public partial class ReportBDMH : DevExpress.XtraReports.UI.XtraReport
    {
        public ReportBDMH()
        {
            InitializeComponent();
        }
        public ReportBDMH(string maLop, string maMh, int lan, string connectionString)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = connectionString;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = maLop;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = maMh;
            this.sqlDataSource1.Queries[0].Parameters[2].Value = lan;
            this.sqlDataSource1.Fill();
        }

    }
}
