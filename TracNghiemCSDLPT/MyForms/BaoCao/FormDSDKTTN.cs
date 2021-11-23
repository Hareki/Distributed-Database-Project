using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using System;
using TracNghiemCSDLPT.MyReports;
using TracNghiemCSDLPT.Others;

namespace TracNghiemCSDLPT.MyForms.BaoCao
{
    public partial class FormDSDKTTN : XtraForm
    {

        public FormDSDKTTN()
        {
            InitializeComponent();


        }


        private void PhanQuyen()
        {
            switch (DBConnection.NhomQuyen)
            {
                case "TRUONG":
                    break;
                case "GIAOVIEN":
                    buttonPrint.Enabled = false;
                    break;
                case "COSO":  
                    break;

            }

        }
        private void buttonPrint_Click(object sender, EventArgs e)
        {
            //String textDateFrom = dateFrom.Value.ToString("dd/MM/yyyy");
            //String textDateTo = dateTo.Value.ToString("dd/MM/yyyy");
            //ReportDSDKTTN report = new ReportDSDKTTN(textDateFrom, textDateTo, DBConnection.SubcriberConnectionString);
            //report.ReportTitle.Text = "DANH SÁCH ĐĂNG KÝ THI TRẮC NGHIỆM " +
            //    CoSoComboBox.Text.ToUpper() + " TỪ NGÀY " + textDateFrom + " ĐẾN NGÀY " + textDateTo;
            //ReportPrintTool printer = new ReportPrintTool(report);
            //printer.ShowPreviewDialog();
        }

      

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}