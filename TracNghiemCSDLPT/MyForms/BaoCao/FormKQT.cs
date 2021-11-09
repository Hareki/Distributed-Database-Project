using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TracNghiemCSDLPT.MyReports;
using TracNghiemCSDLPT.Others;

namespace TracNghiemCSDLPT.MyForms.BaoCao
{
    public partial class FormKQT : DevExpress.XtraEditors.XtraForm
    {
        private int _previousIndexCS;
        public FormKQT()
        {
            InitializeComponent();

            this.CoSoComboBox.DataSource = DBConnection.BsSubcribers;
            this.CoSoComboBox.DisplayMember = "TENCS";
            this.CoSoComboBox.ValueMember = "TENSERVER";
            this.CoSoComboBox.SelectedIndex = DBConnection.IndexCS;
            this._previousIndexCS = this.CoSoComboBox.SelectedIndex;
            PhanQuyen();
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

        private void FormKQT_Load(object sender, EventArgs e)
        {
            this.DSSVTableAdapter.Connection.ConnectionString = DBConnection.SubcriberConnectionString;
            this.DSMHTableAdapter.Connection.ConnectionString = DBConnection.SubcriberConnectionString;

            this.DSSVTableAdapter.Fill(this.TN_CSDLPTDataSet.DSSV);
            this.DSMHTableAdapter.Fill(this.TN_CSDLPTDataSet.DSMH);

        }

        private void SetReportInfo(ReportKQT report, string tenLop, string tenSv, string tenMh, string ngayThi, string diem)
        {
            report.lblDiem.Text = ": " + diem;
            report.lblHoTen.Text = ": " + tenSv;
            report.lblMonThi.Text = ": " + tenMh;
            report.lblNgayThi.Text = ": " + ngayThi;
            report.lblLop.Text = ": " + tenLop;

        }
        private void buttonPrint_Click(object sender, EventArgs e)
        {
            if (!(LookUpSv.EditValue is null) && !(LookUpMh.EditValue is null))
            {
                string maSv = (LookUpSv.EditValue as DataRowView)["MASV"].ToString();
                string maMh = (LookUpMh.EditValue as DataRowView)["MAMH"].ToString();
                int lan;
                if (rdo1.Checked) lan = 1;
                else lan = 2;
                ReportKQT report = new ReportKQT(maSv, maMh, lan, DBConnection.SubcriberConnectionString);


                List<Para> paraList = new List<Para>();
                paraList.Add(new Para("@MASV", maSv));
                paraList.Add(new Para("@MAMH", maMh));
                paraList.Add(new Para("@LAN", lan));
                string spName = "usp_Report_KQT2";
                SqlDataReader myReader = DBConnection.ExecuteSqlDataReaderSP(spName, paraList);
                if (myReader == null)
                {
                    Console.WriteLine(System.Environment.StackTrace);
                    return;
                }
                myReader.Read();
                if (myReader.HasRows)
                {
                    string tenLop = myReader.GetString(0);
                    string tenSv = (LookUpSv.EditValue as DataRowView)["HoTen"].ToString();
                    string tenMh = myReader.GetString(2);
                    string ngayThi = myReader.GetDateTime(3).ToString("dd/MM/yyyy");
                    string diem = myReader.GetDouble(4).ToString();

                    SetReportInfo(report, tenLop, tenSv, tenMh, ngayThi, diem);
                    ReportPrintTool printer = new ReportPrintTool(report);
                    printer.ShowPreviewDialog();
                    myReader.Close();
                }
                else
                {
                    Utils.ShowMessage("Không có bài thi tương ứng với thông tin đã chọn", NotiForm.FormType.Error, 2);
                    myReader.Close();
                    return;
                }
                

            }
            else
            {
                Utils.ShowMessage("Vui lòng chọn đầy đủ thông tin trước khi in", NotiForm.FormType.Warning, 2);
                return;
            }
        }
    }
}