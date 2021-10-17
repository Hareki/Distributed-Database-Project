namespace TracNghiemCSDLPT.MyReports
{
    public partial class ReportDsdkttn : DevExpress.XtraReports.UI.XtraReport
    {
        public ReportDsdkttn()
        {
            InitializeComponent();
        }
        public ReportDsdkttn(string dateFrom, string dateTo, string connectionString)
        {
            InitializeComponent();
            this.bANGDIEMTableAdapter.Connection.ConnectionString = connectionString;
            this.sqlDataSource1.Connection.ConnectionString = connectionString;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = dateFrom;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = dateTo;
            this.sqlDataSource1.Fill();

        }

    }
}
