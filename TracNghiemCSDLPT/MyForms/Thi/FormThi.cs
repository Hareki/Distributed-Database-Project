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

        }
        private int _lanThi = 0;

        private void SetAllButtonsEnabled(bool enabled)
        {
            btnBatDauThi.Enabled = btnNopBai.Enabled = LookUpLop.Enabled =
                        LookUpMonHoc.Enabled = enabled;
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
                    break;
                case "COSO":
                    SetAllButtonsEnabled(true);
                    FillLookUpLopData("COSO");
                    FillLookUpMonThiData();
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
                    items[i].NDCauB = "Our studies shOur studies shOur studies show that increases in worker productivity have not been adequately ...... rewarded by significant increases in .......";
                    items[i].NDCauC = "I will give you a cI will give you a cI will give you a complete account of the system, and expound the actual teachings of the great explorer of the truth, the master-builder ";
                    items[i].NDCauD = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nosLorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nos";

                    items[i].DaChon = "C";
                    items[i].DapAn = "B";
                    items[i].Width = flowLayoutPanel1.Size.Width - 50;
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
                    items[i].Width = flowLayoutPanel1.Size.Width - 50;
                    items[i].Height = items[i].ContentHeight + 40;
                }


                flowLayoutPanel1.Controls.Add(items[i]);
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

        private void LookUpLop_EditValueChanged(object sender, EventArgs e)
        {
            LoadMonThiTuongUng(Utils.GetLookUpValue(LookUpLop, "MALOP"));
            LookUpMonHoc.EditValue = null;
        }

        private void setRdoLanEnabled(bool enabled)
        {
            rdo1.Enabled = rdo2.Enabled = lbl1.Enabled
                            = lbl2.Enabled = enabled;
            if (enabled)
            {
                rdo1.Checked = rdo2.Checked = false;
            }
        }

        private void LookUpMonHoc_EditValueChanged(object sender, EventArgs e)
        {
            if (LookUpMonHoc != null)
            {
                List<Para> paraList = new List<Para>();
                paraList.Add(new Para("@MAMH", Utils.GetLookUpValue(LookUpMonHoc, "MAMH")));
                paraList.Add(new Para("@MALOP", Utils.GetLookUpValue(LookUpLop, "MALOP")));
                string spName = "usp_Thi_LayLanThiCuaLopVaMonTuongUng";
                SqlDataReader myReader = DBConnection.ExecuteSqlDataReaderSP(spName, paraList);
                if (myReader == null)
                {
                    Console.WriteLine(System.Environment.StackTrace);
                    return;
                }
                myReader.Read();
                int result = int.Parse(myReader.GetValue(0).ToString());
                myReader.Close();
                switch (result)
                {
                    case 1:
                        rdo1.Checked = true;
                        setRdoLanEnabled(false);
                        break;
                    case 2:
                        rdo2.Checked = true;
                        setRdoLanEnabled(false);
                        break;
                    case 3:
                        setRdoLanEnabled(true);
                        break;
                }
                _lanThi = result;
            }
        }
    }
}