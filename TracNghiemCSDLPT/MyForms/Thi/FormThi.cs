using DevExpress.XtraEditors;
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
using TracNghiemCSDLPT.Others;

namespace TracNghiemCSDLPT.MyForms.Thi
{
    public partial class FormThi : DevExpress.XtraEditors.XtraForm
    {
        
        public FormThi()
        {
            InitializeComponent();
            PhanQuyen();
            for (int i = 0; i < 2; i++)
            {
                thongTinThi[i] = new ThongTinThi();
            }

        }


        private ThongTinThi[] thongTinThi = new ThongTinThi[2];
        private DataTable _summrayDataTable;
        private void InitSummrayDataTable()
        {
            _summrayDataTable.Clear();
            //_summrayDataTable.Columns.Add("STT")
        }
        private void SetAllButtonsEnabled(bool enabled)
        {
            LookUpLop.Enabled = LookUpMonHoc.Enabled = enabled;
            //btnBatDauThi.Enabled = btnNopBai.Enabled = enabled;
        }
        private void FillLookUpLopData(string NhomQuyen)
        {
            if (NhomQuyen.Equals("SINHVIEN"))
            {

            }
            else
            {
                LoadAllLopThi();
                LookUpLop.Properties.DataSource = usp_ThiThu_LayLopCoLichThi_TatCaBindingSource;
                LookUpLop.Properties.DisplayMember = "FullInfo";
            }
        }
        private void FillLookUpMonThiData()
        {
            LoadMonThiTuongUng(Utils.GetLookUpValue(LookUpLop, "MALOP"));
            LookUpMonHoc.Properties.DataSource = usp_ThiThu_LayMonThiCuaLopTuongUng_TatCaBindingSource;
            LookUpMonHoc.Properties.DisplayMember = "FullInfo";
        }
        private void SetSvInfo(string hoTen, string maSv)
        {
            lblHoTen.Text = hoTen;
            lblMaSV.Text = maSv;
        }
        private void PhanQuyen()
        {
            switch (DBConnection.NhomQuyen)
            {
                case "TRUONG":
                    SetAllButtonsEnabled(false);
                    break;
                case "GIAOVIEN":
                    SetAllButtonsEnabled(true);
                    FillLookUpLopData("GIAOVIEN");
                    FillLookUpMonThiData();
                    SetSvInfo("Giảng viên thi thử", "Test");
                    break;
                case "COSO":
                    SetAllButtonsEnabled(true);
                    FillLookUpLopData("COSO");
                    FillLookUpMonThiData();
                    SetSvInfo("Giảng viên thi thử", "Test");
                    break;
                case "SINHVIEN":
                    SetAllButtonsEnabled(true);
                    FillLookUpLopData("SINHVIEN");
                    FillLookUpMonThiData();
                    break;

            }

        }
        private void test()
        {
            ItemCauHoi[] items = new ItemCauHoi[2];
            for (int i = 0; i < items.Length; i++)
            {
                if (i == 0)
                {
                    items[i] = new ItemCauHoi();
                    items[i].IDBaiThi = 1;
                    items[i].STT = 1;
                    items[i].NDCauHoi = "Lorem ipsum dol";
                    items[i].NDCauA = "I will give yo will give yo will give yo will give you a complete account of the system, and expound the actual teachings of the great explorer of the truth, the master-builder ";
                    items[i].NDCauB = "OurI will give you a cI will giveI will give you a cI will give studies shOur studies shOur studies show that increases in worker productivity have not been adequately ...... rewarded by significant increases in .......";
                    items[i].NDCauC = "I will give you a cI will giveI will give you a cI will giveI will give you a cI will give you a cI will give you a complete account of the system, and expound the actual teachings of the great explorer of the truth, the master-builder ";
                    items[i].NDCauD = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nosLorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nos";

                    items[i].DaChon = "C";
                    items[i].DapAn = "B";
                    items[i].Width = flowPnlBaiThi.Size.Width - 50;
                    items[i].Height = items[i].ContentHeight + 40;
                }
                else
                {
                    items[i] = new ItemCauHoi();
                    items[i].IDBaiThi = 1;
                    items[i].STT = 1;
                    items[i].NDCauHoi = "Lorem ipsum dol";
                    items[i].NDCauA = "bbb";
                    items[i].NDCauB = "12f";
                    items[i].NDCauC = "dddd";
                    items[i].NDCauD = "asd";

                    items[i].DaChon = "C";
                    items[i].DapAn = "B";
                    items[i].Width = flowPnlBaiThi.Size.Width - 50;
                    items[i].Height = items[i].ContentHeight + 40;
                }


                flowPnlBaiThi.Controls.Add(items[i]);
            }
        }


        private void buttonThem_Click(object sender, EventArgs e)
        {
            test();
        }

        private void LoadAllLopThi()
        {
            this.usp_ThiThu_LayLopCoLichThi_TatCaTableAdapter.Connection.ConnectionString = DBConnection.SubcriberConnectionString;
            this.usp_ThiThu_LayLopCoLichThi_TatCaTableAdapter.Fill(this.tN_CSDLPTDataSet.usp_ThiThu_LayLopCoLichThi_TatCa);
        }

        private void LoadMonThiTuongUng(string maLop)
        {
            this.usp_ThiThu_LayMonThiCuaLopTuongUng_TatCaTableAdapter.Connection.ConnectionString = DBConnection.SubcriberConnectionString;
            this.usp_ThiThu_LayMonThiCuaLopTuongUng_TatCaTableAdapter.Fill(this.tN_CSDLPTDataSet.usp_ThiThu_LayMonThiCuaLopTuongUng_TatCa, maLop);
        }
        private void FormThi_Load(object sender, EventArgs e)
        {


        }
        private void ClearInfo()
        {
            LookUpMonHoc.EditValue = null;
            SetRdoLanEnabled(false, true);
            btnBatDauThi.Enabled = false;
            thongTinThi[0].ClearInfo();
            thongTinThi[0].ClearInfo();


            lblSoCauThi.Text = lblNgayThi.Text = lblTrinhDo.Text = lblThoiGian.Text = string.Empty;

        }
        private void LookUpLop_EditValueChanged(object sender, EventArgs e)
        {
            LoadMonThiTuongUng(Utils.GetLookUpValue(LookUpLop, "MALOP"));
            ClearInfo();
        }

        private void SetRdoLanEnabled(bool enabled, bool clearRdo)
        {
            rdo1.Enabled = rdo2.Enabled = lbl1.Enabled
                            = lbl2.Enabled = enabled;
            if (clearRdo)
            {
                rdo1.Checked = rdo2.Checked = false;
            }
        }
        private bool RdoLanIsEnabled()
        {
            return rdo1.Enabled;
        }

        private void Rdo_CheckedChanged(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2CustomRadioButton radio = sender as Guna.UI2.WinForms.Guna2CustomRadioButton;
            if (radio.Checked)
            {
                if (RdoLanIsEnabled())
                {
                    if (radio == rdo1)
                    {
                        //lblNgayThi.Text = thongTinThi[0].NgayThi.ToString("dd/MM/yyyy");
                        SetThongTinThiPanel(0);
                    }
                    else
                    {
                        //lblNgayThi.Text = thongTinThi[1].NgayThi.ToString("dd/MM/yyyy");
                        SetThongTinThiPanel(1);
                    }
                }
                else
                {
                    SetThongTinThiPanel(0);
                    //lblNgayThi.Text = thongTinThi[0].NgayThi.ToString("dd/MM/yyyy");
                    //lblThoiGian = thongTin[0]
                    // nếu ko enabled => chỉ có 1 lần thi, ngày thi của lần đó dù 1 hay 2 vẫn sẽ lưu ở --thongTinThi[0]
                }
                btnBatDauThi.Enabled = true;
            }


        }
        private void SetThongTinThiPanel(int thongTinThiIndex)
        {
            lblNgayThi.Text = thongTinThi[thongTinThiIndex].NgayThi.ToString("dd/MM/yyyy");
            lblThoiGian.Text = thongTinThi[thongTinThiIndex].ThoiGian.ToString();
            lblSoCauThi.Text = thongTinThi[thongTinThiIndex].SoCauThi.ToString();
            lblTrinhDo.Text = thongTinThi[thongTinThiIndex].TrinhDo.ToString();
        }

        private bool isSv()
        {
            return DBConnection.NhomQuyen.Equals("SINHVIEN");
        }

        private void LoadBaiThi(bool thiThu)
        {
            ItemCauHoi[] items = new ItemCauHoi[int.Parse(lblSoCauThi.Text)];
            for (int i = 0; i < items.Length; i++)
            {
                items[i] = new ItemCauHoi();
                //items[i].IDBaiThi = thiThu == true? 0 : Utils.GetCellStringBds(DeThiBindingSource,i,)
                items[i].STT = i + 1;
                items[i].NDCauHoi = Utils.GetCellStringBds(DeThiBindingSource, i, "NOIDUNG");
                items[i].NDCauA = Utils.GetCellStringBds(DeThiBindingSource, i, "A");
                items[i].NDCauB = Utils.GetCellStringBds(DeThiBindingSource, i, "B");
                items[i].NDCauC = Utils.GetCellStringBds(DeThiBindingSource, i, "C");
                items[i].NDCauD = Utils.GetCellStringBds(DeThiBindingSource, i, "D");

                //items[i].DaChon = Utils.GetCellStringBds(DeThiBindingSource, i, "DAP_AN");
                items[i].DapAn = Utils.GetCellStringBds(DeThiBindingSource, i, "DAP_AN");
                items[i].Width = flowPnlBaiThi.Size.Width - 50;
                items[i].Height = items[i].ContentHeight + 40;

                flowPnlBaiThi.Controls.Add(items[i]);
            }

        }
        private void LoadSummarayTable()
        {

        }
        private void btnBatDauThi_Click(object sender, EventArgs e)
        {
            string maMh = Utils.GetLookUpValue(LookUpMonHoc, "MAMH");
            string maLop = Utils.GetLookUpValue(LookUpLop, "MALOP");
            string trinhDo = lblTrinhDo.Text;
            string soCauYeuCau = lblSoCauThi.Text;

            //usp_Thi_LayDeThi
            List<Para> paraList = new List<Para>();
            paraList.Add(new Para("@MaMH", maMh));
            paraList.Add(new Para("@MaLop", maLop));
            paraList.Add(new Para("@SoCauThi", soCauYeuCau));
            paraList.Add(new Para("@TrinhDo", trinhDo));
            string spName = "usp_Thi_LayDeThi";
            DataTable myTable = DBConnection.ExecuteSqlDataTableSP(spName, paraList);
            if (myTable == null)
            {
                Console.WriteLine(System.Environment.StackTrace);
                return;
            }

            DeThiBindingSource.DataSource = myTable;

            pnlThongTinThi.Enabled = false;
            LoadBaiThi(true);
            LoadSummaryTable();


        }

        private void LookUpMonHoc_EditValueChanged(object sender, EventArgs e)
        {
            if (LookUpMonHoc.EditValue != null)
            {
                List<Para> paraList = new List<Para>();
                paraList.Add(new Para("@MAMH", Utils.GetLookUpValue(LookUpMonHoc, "MAMH")));
                paraList.Add(new Para("@MALOP", Utils.GetLookUpValue(LookUpLop, "MALOP")));
                string spName = "usp_Thi_LayThongTinThiCuaLopVaMonTuongUng";
                SqlDataReader myReader = DBConnection.ExecuteSqlDataReaderSP(spName, paraList);
                if (myReader == null)
                {
                    Console.WriteLine(System.Environment.StackTrace);
                    return;
                }
                myReader.Read();
                int rowCount = int.Parse(myReader.GetValue(5).ToString());
                if (rowCount == 1)
                {
                    SetRdoLanEnabled(false, false);

                    //thongTinThi[0].NgayThi = myReader.GetDateTime(1);
                    int lanThi = int.Parse(myReader.GetValue(0).ToString());
                    // nếu chỉ có 1 lần thi và đó lần thứ 2 thì vẫn lưu vào --thongTinThi[0]
                    switch (lanThi)
                    {
                        case 1:
                            SetThongTinThi(0, 1, myReader);
                            rdo1.Checked = true;
                            break;
                        case 2:
                            SetThongTinThi(0, 2, myReader);
                            rdo2.Checked = true;
                            break;
                    }

                }
                else
                {
                    SetRdoLanEnabled(true, false);
                    // _lanThi = 3;
                    // nếu như có 2 ngày thi thì --thongTinThi[0] lưu lần thi 1, --thongTinThi[1] lưu lần thi 2
                    SetThongTinThi(0, 1, myReader);
                    myReader.Read();
                    SetThongTinThi(1, 2, myReader);
                    rdo1.Checked = true;
                }
                myReader.Close();
            }
        }
        private void SetThongTinThi(int index, int lanThi, SqlDataReader myReader)
        {
            thongTinThi[index].LanThi = lanThi;
            thongTinThi[index].NgayThi = myReader.GetDateTime(1);
            thongTinThi[index].SoCauThi = int.Parse(myReader.GetValue(2).ToString());
            thongTinThi[index].TrinhDo = myReader.GetString(3);
            thongTinThi[index].ThoiGian = int.Parse(myReader.GetValue(4).ToString());
        }
    }
    public class ThongTinThi
    {
        public int LanThi { get; set; }
        public int SoCauThi { get; set; }
        public int ThoiGian { get; set; }
        public DateTime NgayThi { get; set; }
        public string TrinhDo { get; set; }

        public ThongTinThi(int lanThi, int soCauThi, int thoiGian, DateTime ngayThi, string trinhDo)
        {
            LanThi = lanThi;
            SoCauThi = soCauThi;
            ThoiGian = thoiGian;
            NgayThi = ngayThi;
            TrinhDo = trinhDo;
        }
        public ThongTinThi()
        {

        }
        public void ClearInfo()
        {
            LanThi = 0;
            SoCauThi = 0;
            ThoiGian = 0;
            NgayThi = DateTime.MinValue;
            TrinhDo = string.Empty;
        }
    }
}