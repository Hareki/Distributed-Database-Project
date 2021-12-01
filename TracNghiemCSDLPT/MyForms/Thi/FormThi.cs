using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TracNghiemCSDLPT.Models;
using TracNghiemCSDLPT.Others;

namespace TracNghiemCSDLPT.MyForms.Thi
{
    public partial class FormThi : DevExpress.XtraEditors.XtraForm
    {

        public FormThi()
        {
            InitializeComponent();
            PhanQuyen();
            InitThongTinThi();
            Utils.ConfigControlColor(pnlThongTinThi);
            savingTimer.Start();
        }


        private ThongTinThi[] thongTinThi = new ThongTinThi[2];
        private List<SummaryItem> summaryItems = new List<SummaryItem>();
        private int _min, _sec;
        private string[] ABCD = { "A", "B", "C", "D" };
        private string _maBangDiem;
        private DateTime _ngayThi;
        private string _maLopSv;
        private string basePath = "context/";

        private void ResetABCD()
        {
            ABCD[0] = "A";
            ABCD[1] = "B";
            ABCD[2] = "C";
            ABCD[3] = "D";
        }

        private void GenerateMaCauHoiSummary(int soCauThi)
        {
            for (int i = 1; i <= soCauThi; i++)
            {
                summaryItems.Add(new SummaryItem(i, string.Empty));
            }
        }
        private void InitThongTinThi()
        {
            for (int i = 0; i < 2; i++)
            {
                thongTinThi[i] = new ThongTinThi();
            }
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
                List<Para> paraList = new List<Para>();
                paraList.Add(new Para("@MaSV", lblMaSV.Text));
                string spName = "usp_Thi_LayLopCuaSV";
                using (SqlDataReader myReader = DBConnection.ExecuteSqlDataReaderSP(spName, paraList))
                {
                    if (myReader == null)
                    {
                        Console.WriteLine(System.Environment.StackTrace);
                        return;
                    }
                    myReader.Read();
                    string maLop = myReader.GetString(0).Trim();
                    string tenLop = myReader.GetString(1);
                    string fullInfo = maLop + " - " + tenLop;
                    _maLopSv = maLop;
                    LookUpLop.Properties.NullText = fullInfo;
                }


            }
            else
            {
                LoadAllLopThi();
                LookUpLop.Properties.DataSource = usp_ThiThu_LayLopCoLichThi_TatCaBindingSource;
                LookUpLop.Properties.DisplayMember = "FullInfo";
            }
        }
        private string GetMaLopSv() //
        {
            return _maLopSv;
        }

        private void SetSvInfo(string hoTen, string maSv)
        {
            lblHoTen.Text = hoTen;
            lblMaSV.Text = maSv;
        }
        private void ConfigLookUpMhCSGV()
        {
            LookUpLop.Enabled = LookUpMonHoc.Enabled = true;
            LookUpMonHoc.Properties.DataSource = usp_ThiThu_LayMonThiCuaLopTuongUng_TatCaBindingSource;
            LookUpMonHoc.Properties.DisplayMember = "FullInfo";// chỉ ra data source thôi chứ chưa có dữ liệu
            SetSvInfo("Giảng viên thi thử", "Test");
        }
        private void PhanQuyen()
        {
            switch (DBConnection.NhomQuyen)
            {
                case "TRUONG":
                    LookUpLop.Enabled = LookUpMonHoc.Enabled = false;
                    break;
                case "GIAOVIEN":
                    ConfigLookUpMhCSGV();
                    FillLookUpLopData("GIAOVIEN");
                    break;
                case "COSO":
                    ConfigLookUpMhCSGV();
                    FillLookUpLopData("COSO");
                    break;
                case "SINHVIEN":
                    LookUpLop.Enabled = false;
                    LookUpMonHoc.Enabled = true;
                    LookUpMonHoc.Properties.DataSource = usp_Thi_LayMonThiCuaLopTuongUng_TrongNgayBindingSource;
                    LookUpMonHoc.Properties.DisplayMember = "FullInfo";
                    SetSvInfo(DBConnection.HoTen, DBConnection.MaSv);// đặt trước filllookup để filllookup dùng
                    FillLookUpLopData("SINHVIEN");
                    LoadMonThiTuongUng(GetMaLopSv());

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
                    items[i].MaBangDiem = "1";
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
                    items[i].MaBangDiem = "1";
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

        private string GetUncheckedQuestions()
        {
            string result = string.Empty;
            for (int i = 0; i < summaryGridView.RowCount; i++)
            {
                SummaryItem item = (summaryGridView.GetRow(i) as SummaryItem);
                if (item.DaChon.Equals(string.Empty))
                {
                    result += item.STT + ", ";
                }
            }
            if (!result.Equals(string.Empty))
            {
                result = result.Substring(0, result.Length - 2);
            }


            return result;
        }
        private void ShowResult(double[] result)
        {

            //Utils.ShowInformationMessage("Hoàn tất bài thi.\nBạn trả lời đúng " + result[1] + "/" +
            //    lblSoCauThi.Text + " câu. Điểm: " + result[0], "Kết quả");
            string soCauDung = result[1] + "/" + lblSoCauThi.Text + " câu";
            string diem = "Điểm: " + result[0];
            countDownTimer.Stop();
            ResultForm formThongBaoDiem = new ResultForm(soCauDung, diem);
            this.Close();
        }

        private void ExecuteMergingDataTable(DataTable dataTable, string spName)
        {
            SqlParameter para = new SqlParameter();
            para.SqlDbType = SqlDbType.Structured;
            para.TypeName = "dbo.Table_BaiThi";
            para.ParameterName = "@BaiThi";
            para.Value = dataTable;

            SqlConnection connection = DBConnection.SubcriberConnection;
            SqlCommand sqlCmd = new SqlCommand(spName, connection);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.Add(para);

            if (connection.State == ConnectionState.Closed)
                connection.Open();
            try
            {
                sqlCmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                connection.Close();
                Utils.ShowErrorMessage("Xảy ra lỗi \n" + ex.ToString(), "Lỗi kết nối");
                connection.Close();
                Console.WriteLine(ex.StackTrace);
            }
        }
        private void InsertBaiThi()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("MABANGDIEM", typeof(string));
            dataTable.Columns.Add("CAUHOI", typeof(int));
            dataTable.Columns.Add("STT", typeof(int));
            dataTable.Columns.Add("LUACHON", typeof(string));

            string maBangDiem = _maBangDiem;
            for (int i = 0; i < DeThiBindingSource.Count; i++)
            {
                int maCauHoi = int.Parse(Utils.GetCellStringBds(DeThiBindingSource, i, "CAUHOI"));
                int STT = (summaryBindingSource[i] as SummaryItem).STT;

                string fakeAnswerStr = (summaryBindingSource[i] as SummaryItem).DaChon;
                char fakeAnswer;
                if (!fakeAnswerStr.Equals(""))
                {
                    fakeAnswer = fakeAnswerStr.ToCharArray()[0];
                }
                else
                {
                    fakeAnswer = ' ';
                }
                string daChon = GetRealAnswerByFakeAnswer(fakeAnswer, _shuffledAnswersList[i]);

                dataTable.Rows.Add(maBangDiem, maCauHoi, STT, daChon);
            }

            ExecuteMergingDataTable(dataTable, "usp_Thi_ThemBaiThi");

        }

        private string GetMaMhFromLookUp()
        {
            return Utils.GetLookUpValue(LookUpMonHoc, "MAMH");
        }
        private int GetLan()
        {
            Debug.Assert(rdo1.Checked || rdo2.Checked);
            if (rdo1.Checked)
                return 1;
            else return 2;
        }
        private string GetMaSvFromLabel()
        {
            return lblMaSV.Text;
        }
        private void InsertBangDiem(string maBangDiem, double diem, string maSv, string maMh, int lan, DateTime ngayThi)
        {
            //string maSv = lblMaSV.Text;
            //string maMh = GetMaMhFromLookUp();
            //int lan = GetLan();
            //DateTime ngayThi = _ngayThi;

            List<Para> paraList = new List<Para>();
            paraList.Add(new Para("@MABANGDIEM", maBangDiem));
            paraList.Add(new Para("@MASV", maSv));
            paraList.Add(new Para("@MAMH", maMh));
            paraList.Add(new Para("@LAN", lan));
            paraList.Add(new Para("@NGAYTHI", ngayThi));
            paraList.Add(new Para("@DIEM", diem));

            string spName = "usp_Thi_BD_Insert";
            bool success = DBConnection.ExecuteSqlNonQuerySP(spName, paraList);
            if (!success)
            {
                Console.WriteLine(System.Environment.StackTrace);
                return;
            }
        }

        private void UpdateBangDiem(string maBangDiem, double diem)
        {

            List<Para> paraList = new List<Para>();
            paraList.Add(new Para("@MABANGDIEM", maBangDiem));
            paraList.Add(new Para("@DIEM", diem));

            string spName = "usp_Thi_BD_Update";
            bool success = DBConnection.ExecuteSqlNonQuerySP(spName, paraList);
            if (!success)
            {
                Console.WriteLine(System.Environment.StackTrace);
                return;
            }
        }

        private void UpdateOrInsertBTDLChung(string maBangDiem, int min, int sec, bool insert)
        {
            List<Para> paraList = new List<Para>();
            paraList.Add(new Para("@MaBangDiem", maBangDiem));
            paraList.Add(new Para("@Phut", min));
            paraList.Add(new Para("@Giay", sec));
            string spName;
            if (insert)
                spName = "usp_Thi_BTDL_Chung_Insert";
            else spName = "usp_Thi_BTDL_Chung_Update";
            bool success = DBConnection.ExecuteSqlNonQuerySP(spName, paraList);
            if (!success)
            {
                Console.WriteLine(System.Environment.StackTrace);
                return;
            }
        }

        public void UpdateBTDLChiTiet(string maBangDiem, int STT, string daChon)
        {
            List<Para> paraList = new List<Para>();
            paraList.Add(new Para("@MaBangDiem", maBangDiem));
            paraList.Add(new Para("@STT", STT));
            paraList.Add(new Para("@DaChon", daChon));
            string spName = "usp_Thi_BTDL_ChiTiet_Update";
            bool success = DBConnection.ExecuteSqlNonQuerySP(spName, paraList);
            if (!success)
            {
                Console.WriteLine(System.Environment.StackTrace);
                return;
            }
        }
        private void InsertAllBTDLChiTiet()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("MABANGDIEM", typeof(string));
            dataTable.Columns.Add("CAUHOI", typeof(int));
            dataTable.Columns.Add("STT", typeof(int));
            dataTable.Columns.Add("LUACHON", typeof(string));

            string maBangDiem = _maBangDiem;
            for (int i = 0; i < DeThiBindingSource.Count; i++)
            {
                int maCauHoi = int.Parse(Utils.GetCellStringBds(DeThiBindingSource, i, "CAUHOI"));
                int STT = (summaryBindingSource[i] as SummaryItem).STT;

                string fakeAnswerStr = (summaryBindingSource[i] as SummaryItem).DaChon;
                char fakeAnswer;
                if (!fakeAnswerStr.Equals(""))
                {
                    fakeAnswer = fakeAnswerStr.ToCharArray()[0];
                }
                else
                {
                    fakeAnswer = ' ';
                }
                string daChon = GetRealAnswerByFakeAnswer(fakeAnswer, _shuffledAnswersList[i]);

                dataTable.Rows.Add(maBangDiem, maCauHoi, STT, daChon);
            }

            ExecuteMergingDataTable(dataTable, "usp_Thi_ThemBaiThi");

        }
        private void DeleteBTDLChung(string maBangDiem)
        {
            List<Para> paraList = new List<Para>();
            paraList.Add(new Para("@MaBangDiem", _maBangDiem));
            string spName = "usp_Thi_BTDL_Chung_Delete";
            bool success = DBConnection.ExecuteSqlNonQuerySP(spName, paraList);
            if (!success)
            {
                Console.WriteLine(System.Environment.StackTrace);
                return;
            }
        }
        private void DeleteBTDLChiTiet(string maBangDiem)
        {
            List<Para> paraList = new List<Para>();
            paraList.Add(new Para("@MaBangDiem", _maBangDiem));
            string spName = "usp_Thi_BTDL_ChiTiet_Delete";
            bool success = DBConnection.ExecuteSqlNonQuerySP(spName, paraList);
            if (!success)
            {
                Console.WriteLine(System.Environment.StackTrace);
                return;
            }
        }


        private void BtnNopBai_Click(object sender, EventArgs e)
        {
            //test();
            string uncheckedQuestions = GetUncheckedQuestions();
            if (!uncheckedQuestions.Equals(string.Empty))
            {
                bool confirmed = Utils.ShowConfirmMessage("Bạn vẫn còn câu hỏi chưa hoàn tất: "
                    + uncheckedQuestions + "\n\nXác nhận nộp bài?", "Cảnh báo");
                if (!confirmed)
                {
                    return;
                }
            }
            else
            {
                bool confirmed = Utils.ShowConfirmMessage("Xác nhận nộp bài?", "Cảnh báo");
                if (!confirmed)
                {
                    return;
                }
            }
            double[] result = GetResult();
            ShowResult(result);

            if (isSv())
            {
                UpdateBangDiem(_maBangDiem, result[0]);
                InsertBaiThi();
                DeleteBTDLChiTiet(_maBangDiem);
                DeleteBTDLChung(_maBangDiem);
            }

        }



        private void LoadAllLopThi()
        {
            this.usp_ThiThu_LayLopCoLichThi_TatCaTableAdapter.Connection.ConnectionString = DBConnection.SubcriberConnectionString;
            this.usp_ThiThu_LayLopCoLichThi_TatCaTableAdapter.Fill(this.tN_CSDLPTDataSet.usp_ThiThu_LayLopCoLichThi_TatCa);
        }

        private void LoadMonThiTuongUng(string maLop)
        {
            if (!isSv())
            {
                this.usp_ThiThu_LayMonThiCuaLopTuongUng_TatCaTableAdapter.Connection.ConnectionString = DBConnection.SubcriberConnectionString;
                this.usp_ThiThu_LayMonThiCuaLopTuongUng_TatCaTableAdapter.Fill(this.tN_CSDLPTDataSet.usp_ThiThu_LayMonThiCuaLopTuongUng_TatCa, maLop);
            }
            else
            {
                this.usp_Thi_LayMonThiCuaLopTuongUng_TrongNgayTableAdapter.Connection.ConnectionString = DBConnection.SubcriberConnectionString;
                this.usp_Thi_LayMonThiCuaLopTuongUng_TrongNgayTableAdapter.Fill(this.tN_CSDLPTDataSet.usp_Thi_LayMonThiCuaLopTuongUng_TrongNgay, maLop);
            }

        }
        private void FormThi_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
        private void ClearInfo()
        {
            LookUpMonHoc.EditValue = null;
            SetRdoLanEnabled(false, true);
            btnBatDauThi.Enabled = false;
            thongTinThi[0].ClearInfo();
            thongTinThi[1].ClearInfo();


            lblSoCauThi.Text = lblNgayThi.Text = lblTrinhDo.Text = lblThoiGian.Text = string.Empty;

        }
        private void LookUpLop_EditValueChanged(object sender, EventArgs e)
        {
            if (!isSv())
            {
                LoadMonThiTuongUng(Utils.GetLookUpValue(LookUpLop, "MALOP"));
                ClearInfo();
            }
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

        private void SwapABCD(int posA, int posB)
        {
            string temp;
            temp = ABCD[posA];
            ABCD[posA] = ABCD[posB];
            ABCD[posB] = temp;
        }
        private void ShuffleABCD()
        {
            Random random = new Random();
            for (int i = 0; i < ABCD.Length; i++)
            {
                SwapABCD(i, random.Next(i, ABCD.Length));
            }
        }
        private int GetAnswerIndexInABCD(string realAnswer)//lấy đáp án thật dò trong ABCD
        {
            for (int i = 0; i < ABCD.Length; i++)
            {
                if (realAnswer.Equals(ABCD[i]))
                {
                    return i;
                }
            }
            return -1;
        }
        //private string GetAnswerAfterShuffling(int answerIndex)
        //{

        //}

        private string GetRealAnswerByFakeAnswer(char fakeAnswer, string[] shuffledAnswers)// do value này đảm bảo tính unique
        {
            Debug.Assert(fakeAnswer >= 65 && fakeAnswer <= 68 || fakeAnswer == 32);
            if (fakeAnswer == 32) return " ";
            int index = fakeAnswer - 65;
            return shuffledAnswers[index];

        }
        private string GetFakeAnswerByShuffledIndex(int index)
        {
            Debug.Assert(index >= 0 && index <= 3);
            return Char.ConvertFromUtf32(index + 65);
        }
        private List<string[]> _shuffledAnswersList = new List<string[]>();
        private void LoadBaiThi(bool thiThu)
        {
            ItemCauHoi[] items = new ItemCauHoi[int.Parse(lblSoCauThi.Text)];
            _shuffledAnswersList.Clear();


            for (int i = 0; i < items.Length; i++)
            {
                ShuffleABCD();
                //Key (theo thứ tự trong dictonary) là thứ tự các câu hỏi thật, bị shuffle
                //Value là  câu trả lời giả tương ứng

                items[i] = new ItemCauHoi(this)
                {
                    //items[i].IDBaiThi = thiThu == true? 0 : Utils.GetCellStringBds(DeThiBindingSource,i,)
                    STT = i + 1,
                    MaBangDiem = isSv() ? _maBangDiem : string.Empty,
                    NDCauHoi = Utils.GetCellStringBds(DeThiBindingSource, i, "NOIDUNG"),
                    NDCauA = Utils.GetCellStringBds(DeThiBindingSource, i, ABCD[0]),
                    NDCauB = Utils.GetCellStringBds(DeThiBindingSource, i, ABCD[1]),
                    NDCauC = Utils.GetCellStringBds(DeThiBindingSource, i, ABCD[2]),
                    NDCauD = Utils.GetCellStringBds(DeThiBindingSource, i, ABCD[3]),
                    MaCauHoi = int.Parse(Utils.GetCellStringBds(DeThiBindingSource, i, "CAUHOI"))
                };


                //Value: A B C D:  thứ tự trong chương trình
                //Key:   D C A B:  nội dung thực trên db
                _shuffledAnswersList.Add(new string[4] { ABCD[0], ABCD[1], ABCD[2], ABCD[3] });


                string answer = Utils.GetCellStringBds(DeThiBindingSource, i, "DAP_AN");
                int answerIndex = GetAnswerIndexInABCD(answer);

                //items[i].DapAn = Utils.GetCellStringBds(DeThiBindingSource, i, "DAP_AN");
                string fakeAnswer = GetFakeAnswerByShuffledIndex(answerIndex);
                items[i].DapAn = fakeAnswer;

                items[i].Width = flowPnlBaiThi.Size.Width - 50;
                items[i].Height = items[i].ContentHeight + 40;
                flowPnlBaiThi.Controls.Add(items[i]);

                //ResetABCD(); khỏi reset cũng dc
            }

        }
        private void LoadSummarayTable()
        {
            GenerateMaCauHoiSummary(int.Parse(lblSoCauThi.Text));
            summaryBindingSource.DataSource = summaryItems;
        }
        private void SetPnlThongTinThiEnabled(bool enabled)
        {

            if (enabled)
            {
                pnlThongTinThi.Enabled = true;
                pnlThongTinThi.ForeColor = Utils.ActiveColor;
            }
            else
            {
                pnlThongTinThi.Enabled = false;
                pnlThongTinThi.ForeColor = Utils.DisabledColor;

            }

        }
        private string GenerateMbd()
        {
            return DateTimeOffset.UtcNow.ToUnixTimeMilliseconds().ToString();
        }
        private bool Tested()
        {
            List<Para> paraList = new List<Para>();
            paraList.Add(new Para("@MaSv", GetMaSvFromLabel()));
            paraList.Add(new Para("@MaMh", GetMaMhFromLookUp()));
            paraList.Add(new Para("@Lan", GetLan()));
            string spName = "usp_Thi_KiemTraThiChua";
            using (SqlDataReader myReader = DBConnection.ExecuteSqlDataReaderSP(spName, paraList))
            {
                if (myReader == null)
                {
                    Console.WriteLine(System.Environment.StackTrace);
                    return true;
                }
                return myReader.HasRows;
            }
        }
        private void BtnBatDauThi_Click(object sender, EventArgs e)
        {
            string maLop = isSv() ? GetMaLopSv() : Utils.GetLookUpValue(LookUpLop, "MALOP");
            string maMh = GetMaMhFromLookUp();
            string trinhDo = lblTrinhDo.Text;
            string soCauYeuCau = lblSoCauThi.Text;

            if (isSv())
            {
                if (Tested())
                {
                    Utils.ShowMessage("Sinh viên đã dự thi môn và lần thi này rồi", NotiForm.FormType.Error, 2);
                    return;
                }

            }

            //usp_Thi_LayDeThi
            List<Para> paraList = new List<Para>();
            paraList.Add(new Para("@maMon", maMh));
            paraList.Add(new Para("@maLop", maLop));
            paraList.Add(new Para("@soCauYeuCau", soCauYeuCau));
            paraList.Add(new Para("@trinhDo", trinhDo));
            string spName = "usp_Thi_LayDeThi";
            DataTable myTable = DBConnection.ExecuteSqlDataTableSP(spName, paraList);
            if (myTable == null)
            {
                Console.WriteLine(System.Environment.StackTrace);
                return;
            }

            DeThiBindingSource.DataSource = myTable;

            SetPnlThongTinThiEnabled(false);
            btnBatDauThi.Enabled = false;
            LoadBaiThi(true);

            LoadSummarayTable();
            _min = int.Parse(lblThoiGian.Text);
            _sec = 1;
            countDownTimer.Start();
            btnNopBai.Enabled = true;

            if (isSv())
            {
                _maBangDiem = GenerateMbd();
                _ngayThi = DateTime.Now;
                string maSv = lblMaSV.Text;
                int lan = GetLan();
                InsertBangDiem(_maBangDiem, 0, maSv, maMh, lan, _ngayThi);//phải insert vào trước để có mã bảng điểm

                UpdateOrInsertBTDLChung(_maBangDiem, _min, 0, true);
            }



        }


        private void LookUpMonHoc_EditValueChanged(object sender, EventArgs e)
        {
            if (LookUpMonHoc.EditValue != null)
            {
                string maLop;
                int trongNgay;
                if (isSv())
                {
                    maLop = GetMaLopSv();
                    trongNgay = 1;
                }
                else
                {
                    maLop = Utils.GetLookUpValue(LookUpLop, "MALOP");
                    trongNgay = 0;
                }
                List<Para> paraList = new List<Para>();
                paraList.Add(new Para("@MAMH", Utils.GetLookUpValue(LookUpMonHoc, "MAMH")));
                paraList.Add(new Para("@MALOP", maLop));
                paraList.Add(new Para("@TrongNgay", trongNgay));
                string spName = "usp_Thi_LayThongTinThiCuaLopVaMonTuongUng";
                using (SqlDataReader myReader = DBConnection.ExecuteSqlDataReaderSP(spName, paraList))
                {
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
                }


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

        private void gridView1_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            e.Allow = false;
        }

        private void ScrollToControl(int index)
        {
            //var control = flowPnlBaiThi.Controls[index];
            //Point controlLocation = control.Location;
            //int x = Math.Abs(controlLocation.X);
            //int y = Math.Abs(controlLocation.Y);
            //flowPnlBaiThi.AutoScrollPosition = new Point(x, y);
            //Console.WriteLine("a");

            var control = flowPnlBaiThi.Controls[index];
            var controlLocation = control.Location - new Size(flowPnlBaiThi.AutoScrollPosition);
            controlLocation -= new Size(control.Margin.Left, control.Margin.Top);
            flowPnlBaiThi.AutoScrollPosition = controlLocation;
        }
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            ScrollToControl(summaryBindingSource.Position);
        }

        public void UpdateSummaryTable(int stt, string daChon)
        {
            int index = stt - 1;
            (summaryBindingSource[index] as SummaryItem).DaChon = daChon;
            summaryGridView.RefreshData();
        }

        private void CountDownTimer_Tick(object sender, EventArgs e)
        {

            if (_sec == 0)
            {
                if (_min == 0)
                {
                    lblCountDown.Text = "Hết giờ";

                    double[] result = GetResult();
                    ShowResult(result);

                    if (isSv())
                    {
                        UpdateBangDiem(_maBangDiem, result[0]);
                        InsertBaiThi();
                        DeleteBTDLChiTiet(_maBangDiem);
                        DeleteBTDLChung(_maBangDiem);
                    }
                }
                else
                {
                    _min--;
                    _sec = 59;
                }

            }
            else
            {
                _sec--;
            }
            lblCountDown.Text = string.Format("{0} : {1}", _min.ToString().PadLeft(2, '0'), _sec.ToString().PadLeft(2, '0'));
        }

        private void summaryGridView_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            //if (e.RowHandle == summaryGridView.FocusedRowHandle)
            //{
            //    e.Appearance.BackColor = Color.FromArgb(255, 237, 211);
            //    return;
            //}

            if (!(summaryGridView.GetRow(e.RowHandle) as SummaryItem).DaChon.Equals(string.Empty))
            {
                e.Appearance.BackColor = Color.FromArgb(193, 255, 215);
                Console.WriteLine("painted");
            }

        }

        private void FormThi_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (countDownTimer.Enabled)
                if (!Utils.ShowConfirmMessage("Xác nhận ngừng làm bài thi?", "Xác nhận"))
                    e.Cancel = true;
        }

        enum FileType
        {
            General, Timer, Detail
        }

        private string GetFileNameOfCurrentSv(FileType type)
        {
            string maSv = DBConnection.MaSv;
            string tenSv = DBConnection.HoTen;
            string maLop = GetMaLopSv();
            string maMh = GetMaMhFromLookUp();
            int lanThi = GetLan();
            return maSv + "-" + maMh + "-" + lanThi.ToString() + "-" + type.ToString() + ".dat";


        }
        private void savingTimer_Tick(object sender, EventArgs e)
        {

            if (countDownTimer.Enabled)
            {

            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filePath = basePath + GetFileNameOfCurrentSv(FileType.Timer);
            File.Decrypt(filePath);
            using (BinaryReader reader = new BinaryReader(File.Open(filePath, FileMode.Open)))
            {
                int min = reader.ReadInt16();
                int sec = reader.ReadInt16();
                Console.WriteLine("Min: " + min);
                Console.WriteLine("Sec: " + sec);
            }
        }

        private void SaveTimeLeftTimer_Tick(object sender, EventArgs e)
        {
            UpdateOrInsertBTDLChung(_maBangDiem, _min, _sec, false);
        }

        private double[] GetResult()
        {
            int soCauThi = int.Parse(lblSoCauThi.Text);
            int soCauDung = 0;
            for (int i = 0; i < flowPnlBaiThi.Controls.Count; i++)
            {
                ItemCauHoi item = flowPnlBaiThi.Controls[i] as ItemCauHoi;
                if (item.DaChon.Equals(item.DapAn))
                {
                    soCauDung++;
                }
            }
            double mark = ((double)soCauDung * ((double)10 / (double)soCauThi));
            mark = Math.Round((double)mark, 1);
            double[] result = { mark, soCauDung };
            return result;
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