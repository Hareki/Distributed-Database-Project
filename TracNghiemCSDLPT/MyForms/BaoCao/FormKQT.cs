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

        private void LoadAllSv()
        {
            this.usp_Report_KQT_LaySVThuocLopDaDuThiTableAdapter.Connection.ConnectionString = DBConnection.SubcriberConnectionString;
            this.usp_Report_KQT_LaySVThuocLopDaDuThiTableAdapter.Fill(this.TN_CSDLPTDataSet.usp_Report_KQT_LaySVThuocLopDaDuThi);
        }
        private void FormKQT_Load(object sender, EventArgs e)
        {
            Utils.BindingComboData(this.CoSoComboBox, _previousIndexCS);

            LoadAllSv();
            LookUpSv.Properties.DataSource = this.usp_Report_KQT_LaySVThuocLopDaDuThiBindingSource;
            LookUpSv.Properties.DisplayMember = "FullInfo";

            LookUpMh.Properties.DataSource = this.usp_Report_KQT_LayMonDaThiBindingSource;
            LookUpMh.Properties.DisplayMember = "FullInfo";
            PhanQuyen();

        }

        private void SetReportInfo(ReportKQT report, string tenLop, string tenSv, string tenMh, string ngayThi, string diem, int lan)
        {
            report.lblDiem.Text = ": " + diem;
            report.lblHoTen.Text = ": " + tenSv;
            report.lblMonThi.Text = ": " + tenMh;
            report.lblNgayThi.Text = ": " + ngayThi;
            report.lblLop.Text = ": " + tenLop;
            report.lblLan.Text = ": " + lan;

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
                using (SqlDataReader myReader = DBConnection.ExecuteSqlDataReaderSP(spName, paraList))
                {
                    if (myReader == null)
                    {
                        Console.WriteLine(System.Environment.StackTrace);
                        return;
                    }
                    if (myReader.HasRows)
                    {
                        myReader.Read();
                        string tenLop = myReader.GetString(0);
                        string tenSv = (LookUpSv.EditValue as DataRowView)["HoTen"].ToString();
                        string tenMh = myReader.GetString(2);
                        string ngayThi = myReader.GetDateTime(3).ToString("dd/MM/yyyy");
                        string diem = myReader.GetDouble(4).ToString();
                        SetReportInfo(report, tenLop, tenSv, tenMh, ngayThi, diem, lan);
                        ReportPrintTool printer = new ReportPrintTool(report);
                        printer.ShowPreviewDialog();
                    }
                    else
                    {
                        Utils.ShowMessage("Không có bài thi tương ứng với thông tin đã chọn", NotiForm.FormType.Error, 2);
                        return;
                    }
                }



            }
            else
            {
                Utils.ShowMessage("Vui lòng chọn đầy đủ thông tin trước khi in", NotiForm.FormType.Warning, 2);
                return;
            }
        }

        private void LookUpSv_EditValueChanged(object sender, EventArgs e)
        {
            LoadMonThiCuaSv(Utils.GetLookUpValue(LookUpSv, "MASV"));
            ClearInfo();
        }

        private void LoadMonThiCuaSv(string maSv)
        {
            this.usp_Report_KQT_LayMonDaThiTableAdapter.Connection.ConnectionString = DBConnection.SubcriberConnectionString;
            this.usp_Report_KQT_LayMonDaThiTableAdapter.Fill(this.TN_CSDLPTDataSet.usp_Report_KQT_LayMonDaThi, maSv);
        }

        private void ClearInfo()
        {
            LookUpMh.EditValue = null;
            rdo1.Checked = rdo2.Checked = false;
            rdo1.Enabled = rdo2.Enabled = false;
        }

        private string GetMaSvFromLookUp()
        {
            return Utils.GetLookUpValue(LookUpSv, "MASV");
        }
        private string GetMaMhFromLookUp()
        {
            return Utils.GetLookUpValue(LookUpMh, "MAMH");
        }
        private void LookUpMh_EditValueChanged(object sender, EventArgs e)
        {
            if (LookUpMh.EditValue != null)
            {
                List<Para> paraList = new List<Para>();
                paraList.Add(new Para("@MASV", GetMaSvFromLookUp()));
                paraList.Add(new Para("@MAMH", GetMaMhFromLookUp()));
                string spName = "usp_Report_KQT_LayLanThiTuongUng";
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