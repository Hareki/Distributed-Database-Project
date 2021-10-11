using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TracNghiemCSDLPT.MyReports;
using TracNghiemCSDLPT.SQL_Connection;

namespace TracNghiemCSDLPT.MyForms.QuanLy
{
    public partial class FormDSDKTTN : XtraForm
    {
        private int PreviousIndexCS;
        public FormDSDKTTN()
        {
            InitializeComponent();

            this.CoSoComboBox.DataSource = DBConnection.BS_Subcribers;
            this.CoSoComboBox.DisplayMember = "TENCS";
            this.CoSoComboBox.ValueMember = "TENSERVER";
            this.CoSoComboBox.SelectedIndex = DBConnection.IndexCS;
            this.PreviousIndexCS = this.CoSoComboBox.SelectedIndex;
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            String textDateFrom = dateFrom.Value.ToString("dd/MM/yyyy");
            String textDateTo = dateTo.Value.ToString("dd/MM/yyyy");
            ReportDSDKTTN report = new ReportDSDKTTN(textDateFrom, textDateTo, DBConnection.SubcriberConnectionString);
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
            if (CoSoComboBox.SelectedIndex != DBConnection.IndexCS)//Không cần check loginGV, vì ko bao giờ hiện CB này
            {
                login = DBConnection.RemoteLogin;
                pass = DBConnection.RemotePassword;
            }
            else
            {
                login = DBConnection.LoginName;
                pass = DBConnection.Password;
            }
            bool success = DBConnection.ConnectToSubcriber(login, pass, serverName);
            if (!success)
            {
                Utils.ShowMessage("Tạm thời không thể kết nối đến cơ sở này", Others.NotiForm.FormType.Error, 2);
                this.CoSoComboBox.SelectedIndex = this.PreviousIndexCS;
                return;
            }
            else
            {
                this.PreviousIndexCS = this.CoSoComboBox.SelectedIndex;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}