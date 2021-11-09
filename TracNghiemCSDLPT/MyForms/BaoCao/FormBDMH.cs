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
using TracNghiemCSDLPT.Others;

namespace TracNghiemCSDLPT.MyForms.BaoCao
{
    public partial class FormBDMH : DevExpress.XtraEditors.XtraForm
    {
        private int _previousIndexCS;
        public FormBDMH()
        {
            InitializeComponent();

            this.CoSoComboBox.DataSource = DBConnection.BsSubcribers;
            this.CoSoComboBox.DisplayMember = "TENCS";
            this.CoSoComboBox.ValueMember = "TENSERVER";
            this.CoSoComboBox.SelectedIndex = DBConnection.IndexCS;
            this._previousIndexCS = this.CoSoComboBox.SelectedIndex;

            LookUpLop.Properties.DisplayMember = "FullInfo";
            LookUpLop.Properties.ValueMember = "MaLop";

            LookUpMh.Properties.DisplayMember = "FullInfo";
            LookUpMh.Properties.ValueMember = "MaMH";

            PhanQuyen();
        }

        private void FormBDMH_Load(object sender, EventArgs e)
        {
            this.DSMHTableAdapter.Connection.ConnectionString = DBConnection.SubcriberConnectionString;
            this.DSLTableAdapter.Connection.ConnectionString = DBConnection.SubcriberConnectionString;
            this.DSMHTableAdapter.Fill(this.TN_CSDLPTDataSet.DSMH);
            this.DSLTableAdapter.Fill(this.TN_CSDLPTDataSet.DSL);

        }

        private void PhanQuyen()
        {
            switch (DBConnection.NhomQuyen)
            {
                case "TRUONG":
                    CoSoComboBox.Enabled = true;
                    break;
                case "GIAOVIEN":
                    CoSoComboBox.Enabled = false;
                    break;
                case "COSO":
                    CoSoComboBox.Enabled = false;
                    break;

            }

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
                this.CoSoComboBox.SelectedIndex = this._previousIndexCS;
                return;
            }
            else
            {
                this._previousIndexCS = this.CoSoComboBox.SelectedIndex;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            if (!(LookUpLop.EditValue is null) && !(LookUpMh.EditValue is null))
            {
                string maLop = (LookUpLop.EditValue as DataRowView)["MALOP"].ToString();
                string maMh = (LookUpMh.EditValue as DataRowView)["MAMH"].ToString();
                int lan;
                if (rdo1.Checked) lan = 1;
                else lan = 2;

                ReportBDMH report = new ReportBDMH(maLop, maMh, lan, DBConnection.SubcriberConnectionString);
                ReportPrintTool printer = new ReportPrintTool(report);
                printer.ShowPreviewDialog();
            }
            else
            {
                Utils.ShowMessage("Vui lòng chọn đầy đủ thông tin trước khi in", NotiForm.FormType.Warning, 2);
                return;
            }

        }
    }
}