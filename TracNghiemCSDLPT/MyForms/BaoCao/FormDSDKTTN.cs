using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using System;
using TracNghiemCSDLPT.MyReports;
using TracNghiemCSDLPT.Others;

namespace TracNghiemCSDLPT.MyForms.BaoCao
{
    public partial class FormDsdkttn : XtraForm
    {
        private int _previousIndexCs;
        public FormDsdkttn()
        {
            InitializeComponent();

            this.CoSoComboBox.DataSource = DbConnection.BsSubcribers;
            this.CoSoComboBox.DisplayMember = "TENCS";
            this.CoSoComboBox.ValueMember = "TENSERVER";
            this.CoSoComboBox.SelectedIndex = DbConnection.IndexCs;
            this._previousIndexCs = this.CoSoComboBox.SelectedIndex;
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            String textDateFrom = dateFrom.Value.ToString("dd/MM/yyyy");
            String textDateTo = dateTo.Value.ToString("dd/MM/yyyy");
            ReportDsdkttn report = new ReportDsdkttn(textDateFrom, textDateTo, DbConnection.SubcriberConnectionString);
            report.ReportTitle.Text = "DANH SÁCH ĐĂNG KÝ THI TRẮC NGHIỆM " +
                CoSoComboBox.Text.ToUpper() + " TỪ NGÀY " + textDateFrom + " ĐẾN NGÀY " + textDateTo;
            ReportPrintTool printer = new ReportPrintTool(report);
            printer.ShowPreviewDialog();
        }

        private void CoSoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CoSoComboBox.SelectedValue.ToString() == "System.Data.DataRowView")
                return;
            string login, pass;
            string serverName = CoSoComboBox.SelectedValue.ToString();
            if (CoSoComboBox.SelectedIndex != DbConnection.IndexCs)//Không cần check loginGV, vì ko bao giờ hiện CB này
            {
                login = DbConnection.RemoteLogin;
                pass = DbConnection.RemotePassword;
            }
            else
            {
                login = DbConnection.LoginName;
                pass = DbConnection.Password;
            }
            bool success = DbConnection.ConnectToSubcriber(login, pass, serverName);
            if (!success)
            {
                Utils.ShowMessage("Tạm thời không thể kết nối đến cơ sở này", Others.NotiForm.FormType.Error, 2);
                this.CoSoComboBox.SelectedIndex = this._previousIndexCs;
                return;
            }
            else
            {
                this._previousIndexCs = this.CoSoComboBox.SelectedIndex;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}