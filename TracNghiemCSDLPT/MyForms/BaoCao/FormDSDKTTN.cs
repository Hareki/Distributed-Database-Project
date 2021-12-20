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
            dateFrom.EditValue = dateTo.EditValue = DateTime.Now.Date;
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

        private int GetOtherIndex(int indexCS)
        {
            if (indexCS == 1) return 0;
            else return 1;
        }
        private void buttonPrint_Click(object sender, EventArgs e)
        {
            DateTime inputFrom = (DateTime)dateFrom.EditValue;
            DateTime inputTo = (DateTime)dateTo.EditValue;
            if (DateTime.Compare(inputFrom, inputTo) > 0)
            {
                Utils.SetTextEditError(dateEP, dateFrom, "Ngày trước phải nhỏ hơn ngày sau");
                return;
            }
            else
            {
                Utils.SetTextEditError(dateEP, dateFrom, null);
            }
            String textDateFrom = inputFrom.ToString("dd/MM/yyyy");
            String textDateTo = inputTo.ToString("dd/MM/yyyy");

            ReportDSDKTTN report1 = new ReportDSDKTTN(textDateFrom, textDateTo, DBConnection.SubcriberConnectionString, 0);
            report1.ReportTitle.Text = "DANH SÁCH ĐĂNG KÝ THI TRẮC NGHIỆM " +
                Utils.GetCellStringBds(DBConnection.BsSubcribers, DBConnection.IndexCS, "TENCS").ToUpper() + " TỪ NGÀY " + textDateFrom + " ĐẾN NGÀY " + textDateTo;
            report1.CreateDocument();

            ReportDSDKTTN report2 = new ReportDSDKTTN(textDateFrom, textDateTo, DBConnection.SubcriberConnectionString, 1);
            report2.ReportTitle.Text = "DANH SÁCH ĐĂNG KÝ THI TRẮC NGHIỆM " +
                Utils.GetCellStringBds(DBConnection.BsSubcribers, GetOtherIndex(DBConnection.IndexCS), "TENCS").ToUpper() + " TỪ NGÀY " + textDateFrom + " ĐẾN NGÀY " + textDateTo;
            report2.CreateDocument();

            report1.Pages.AddRange(report2.Pages);
            ReportPrintTool printer = new ReportPrintTool(report1);
            printer.ShowPreviewDialog();
        }



        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}