namespace TracNghiemCSDLPT.MyReports
{
    public partial class ReportDSDKTTN : DevExpress.XtraReports.UI.XtraReport
    {
        public ReportDSDKTTN()
        {
            InitializeComponent();
        }
        public ReportDSDKTTN(string dateFrom, string dateTo, string connectionString, int CSCL)
        {
            InitializeComponent();
          //  this.bANGDIEMTableAdapter.Connection.ConnectionString = connectionString;
            this.sqlDataSource2.Connection.ConnectionString = connectionString;
            this.sqlDataSource2.Queries[0].Parameters[0].Value = dateFrom;
            this.sqlDataSource2.Queries[0].Parameters[1].Value = dateTo;
            this.sqlDataSource2.Queries[0].Parameters[2].Value = CSCL;
            this.sqlDataSource2.Fill();

        }

    }
}
