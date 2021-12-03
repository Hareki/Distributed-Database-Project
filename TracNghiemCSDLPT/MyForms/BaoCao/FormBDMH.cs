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
    public partial class FormBDMH : DevExpress.XtraEditors.XtraForm
    {
        private int _previousIndexCS;
        public FormBDMH()
        {
            InitializeComponent();
        }

        private void LoadAllLopThi()
        {
            this.usp_Report_BDMH_LayLopDaDKTableAdapter.Connection.ConnectionString = DBConnection.SubcriberConnectionString;
            this.usp_Report_BDMH_LayLopDaDKTableAdapter.Fill(this.TN_CSDLPTDataSet.usp_Report_BDMH_LayLopDaDK);
        }

        private void LoadMonThiCuaLop(string maLop)
        {
            this.usp_Report_BDMH_LayMonDaDKTableAdapter.Connection.ConnectionString = DBConnection.SubcriberConnectionString;
            this.usp_Report_BDMH_LayMonDaDKTableAdapter.Fill(this.TN_CSDLPTDataSet.usp_Report_BDMH_LayMonDaDK, maLop);
        }
        private void FormBDMH_Load(object sender, EventArgs e)
        {
            Utils.BindingComboData(this.CoSoComboBox, this._previousIndexCS);

            LoadAllLopThi();
            LookUpLop.Properties.DataSource = this.usp_Report_BDMH_LayLopDaDKBindingSource;
            LookUpLop.Properties.DisplayMember = "FullInfo";

            this.LookUpMh.Properties.DataSource = this.usp_Report_BDMH_LayMonDaDKBindingSource;
            LookUpMh.Properties.DisplayMember = "FullInfo";

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
                case "SINHVIEN":
                    CoSoComboBox.Enabled = false;
                    buttonPrint.Enabled = false;
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

        private void SetReportInfo(string tenMh, string tenLop, int lan, DateTime ngayThi, ReportBDMH report)
        {
            report.lblLop.Text = ": " + tenLop;
            report.lblLan.Text = ": " + lan.ToString();
            report.lblNgayThi.Text = ": " + ngayThi.ToString("dd/MM/yyyy");
            report.lblMonThi.Text = ": " + tenMh;
        }
        private DateTime GetNgayThiFromSP(string maLop, string maMh, int lan)
        {
            List<Para> paraList = new List<Para>();
            paraList.Add(new Para("@MALOP", maLop));
            paraList.Add(new Para("@MAMH", maMh));
            paraList.Add(new Para("@LAN", lan));
            string spName = "usp_Report_BDMH2";
            using (SqlDataReader myReader = DBConnection.ExecuteSqlDataReaderSP(spName, paraList))
            {
                if (myReader == null)
                {
                    Console.WriteLine(System.Environment.StackTrace);
                    return DateTime.MinValue;
                }
                if (myReader.HasRows)
                {
                    myReader.Read();
                    DateTime ngayThi = myReader.GetDateTime(0);
                    return ngayThi;
                }
                else
                {
                    Utils.ShowMessage("Xảy ra lỗi trong quá trình truy vấn, không tìm thấy thông" +
                        " tin thi", NotiForm.FormType.Error, 2);
                    return DateTime.MinValue;
                }
            }
        }
        private int GetLanFromRdo()
        {
            if (rdo1.Checked) return 1;
            else if (rdo2.Checked) return 2;
            else return -1;
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            int lan = GetLanFromRdo();
            if (!(LookUpLop.EditValue is null) && !(LookUpMh.EditValue is null) && lan != -1)
            {
                string maLop = Utils.GetLookUpString(LookUpLop, "MALOP");
                string maMh = Utils.GetLookUpString(LookUpMh, "MAMH");

                string tenLop = Utils.GetLookUpString(LookUpLop, "TENLOP");
                string tenMh = Utils.GetLookUpString(LookUpMh, "TENMH");

                DateTime ngayThi = GetNgayThiFromSP(maLop, maMh, lan);
                if (DateTime.Compare(ngayThi, DateTime.MinValue) == 0)
                {
                    return;
                }

                ReportBDMH report = new ReportBDMH(maLop, maMh, lan, DBConnection.SubcriberConnectionString);
                SetReportInfo(tenMh, tenLop, lan, ngayThi, report);

                ReportPrintTool printer = new ReportPrintTool(report);
                printer.ShowPreviewDialog();
            }
            else
            {
                Utils.ShowMessage("Vui lòng chọn đầy đủ thông tin trước khi in", NotiForm.FormType.Warning, 2);
                return;
            }

        }


        private void ClearInfo()
        {
            LookUpMh.EditValue = null;
            rdo1.Checked = rdo2.Checked = false;
            rdo1.Enabled = rdo2.Enabled = false;
        }
        private void LookUpLop_EditValueChanged(object sender, EventArgs e)
        {
            LoadMonThiCuaLop(Utils.GetLookUpString(LookUpLop, "MALOP"));
            ClearInfo();
        }

        private string GetMaMhFromLookUp()
        {
            return Utils.GetLookUpString(LookUpMh, "MAMH");
        }
        private string GetMaLopFromLookUp()
        {
            return Utils.GetLookUpString(LookUpLop, "MALOP");
        }
        private void LookUpMh_EditValueChanged(object sender, EventArgs e)
        {
            if (LookUpMh.EditValue != null)
            {
                List<Para> paraList = new List<Para>();
                paraList.Add(new Para("@MALOP", GetMaLopFromLookUp()));
                paraList.Add(new Para("@MAMH", GetMaMhFromLookUp()));
                string spName = "usp_Report_BDMH_LayLanThiTuongUng";
                using (SqlDataReader myReader = DBConnection.ExecuteSqlDataReaderSP(spName, paraList))
                {
                    if (myReader == null)
                    {
                        Console.WriteLine(System.Environment.StackTrace);
                        return;
                    }
                    myReader.Read();
                    int soLanThi = int.Parse(myReader.GetValue(0).ToString());
                    switch (soLanThi)
                    {
                        case 1:
                            rdo1.Checked = true;
                            rdo1.Enabled = rdo2.Enabled = false;
                            break;
                        case 2:
                            rdo2.Checked = true;
                            rdo1.Enabled = rdo2.Enabled = false;
                            break;
                        case 3:
                            rdo1.Checked = true;
                            rdo1.Enabled = rdo2.Enabled = true;
                            break;
                    }

                }
            }

        }
    }
}