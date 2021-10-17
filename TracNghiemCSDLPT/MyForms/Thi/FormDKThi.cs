using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using TracNghiemCSDLPT.Others;
using static TracNghiemCSDLPT.TN_CSDLPTDataSet;

namespace TracNghiemCSDLPT.MyForms.Thi
{
    public partial class FormDKThi : DevExpress.XtraEditors.XtraForm
    {
        public FormDKThi()
        {
            InitializeComponent();
        }
        private int selectedRow;
        enum State
        {
            idle, edit, add
        }
        private State state = State.idle;
        readonly Color ActiveForeColor = Color.FromArgb(72, 70, 68);
        readonly Color DisabledForeColor = SystemColors.AppWorkspace;
        private int PreviousIndexCS;
        private string origMaMH = "!@#$%";
        private string origMaLop = "!@#$%";
        private int origLan = -1;
        //------------Dùng trong add---------
        private int origSoCau;
        private int origThoiGian;
        private DateTime origNgayThi;
        private void SetInputButtonEnabled(bool state)
        {
            buttonHuy.Visible = buttonXacNhan.Visible = state;
        }
        private void LoadGVDK2()
        {
            this.GVDK2TableAdapter.Connection.ConnectionString = DBConnection.SubcriberConnectionString;
            this.GVDK2TableAdapter.Fill(this.TN_CSDLPTDataSet.GVDK_ENDUSER);
        }
        private void LoadLop()
        {
            this.LopTableAdapter.Connection.ConnectionString = DBConnection.SubcriberConnectionString;
            this.LopTableAdapter.Fill(this.TN_CSDLPTDataSet.LOP);

        }
        private void LoadMonHoc()
        {
            this.MonHocTableAdapter.Connection.ConnectionString = DBConnection.SubcriberConnectionString;
            this.MonHocTableAdapter.Fill(this.TN_CSDLPTDataSet.MONHOC);
        }
        private void LoadDSGV()
        {
            this.DSGVTableAdapter.Connection.ConnectionString = DBConnection.SubcriberConnectionString;
            this.DSGVTableAdapter.Fill(this.TN_CSDLPTDataSet.DSGIAOVIEN);
        }
        private void LoadSV()
        {
            this.SVTableAdapter.Connection.ConnectionString = DBConnection.SubcriberConnectionString;
            this.SVTableAdapter.Fill(this.TN_CSDLPTDataSet.SINHVIEN);
        }

        private void LoadAllData()
        {
            LoadGVDK2();
            LoadLop();
            LoadSV();
            LoadMonHoc();
            LoadDSGV();
        }
        private void SetOrigDefaultValue()
        {
            origMaMH = "!@#$%";
            origMaLop = "!@#$%";
            origLan = -1;
        }
        private void PhanQuyen()
        {
            switch (DBConnection.NhomQuyen)
            {
                case "TRUONG":
                    SetIdleButtonEnabled(false);
                    CoSoComboBox.Enabled = true;
                    break;
                case "GIAOVIEN":
                    SetIdleButtonEnabled(false);
                    CoSoComboBox.Enabled = false;
                    break;
                case "COSO":
                    CoSoComboBox.Enabled = false;
                    break;

            }

        }
        private bool CanDeleteEdit(DateTime ngayThi)
        {
            return (ngayThi.Date > DateTime.Now.Date);
        }
        private void SetIdleButtonEnabled(bool state)
        {
            buttonThem.Enabled = buttonXoa.Enabled = buttonUndo.Enabled = buttonRedo.Enabled =
                 buttonSua.Enabled = state;
            if (Utils.IsTruong()) buttonLamMoi.Enabled = true;
            else buttonLamMoi.Enabled = state;
            if (state == false)
                buttonUndo.BackColor = buttonRedo.BackColor = Color.FromArgb(247, 247, 247);
            else
                buttonUndo.BackColor = buttonRedo.BackColor = Color.FromArgb(240, 240, 240);
        }


        private void FormDKThi_Load(object sender, EventArgs e)
        {
            this.TN_CSDLPTDataSet.EnforceConstraints = false;
            LoadAllData();

            LookUpGV.Properties.DisplayMember = "FullInfo";
            LookUpGV.Properties.ValueMember = "MaGV";
            // DSGVBindingSource.Position = -1;

            MHCombo.DisplayMember = "TENMH";
            MHCombo.ValueMember = "MAMH";

            LopCombo.DisplayMember = "TENLOP";
            LopCombo.ValueMember = "MALOP";

            Utils.BindingComboData(this.CoSoComboBox, this.PreviousIndexCS);

            NgayThi.EditValue = ((DateTime)NgayThi.EditValue).AddDays(1);

            PhanQuyen();
            Utils.ConfigControlColor(InfoPanel);

        }

        private void pictureBox1_EnabledChanged(object sender, EventArgs e)
        {
            Image image = this.pictureBox1.Enabled ? global::TracNghiemCSDLPT.Properties.Resources.note :
                global::TracNghiemCSDLPT.Properties.Resources.note_disabled;

            this.pictureBox1.Image = image;
        }

        private void ConfigInputState()
        {
            InfoPanel.Enabled = true;
            InfoPanel.ForeColor = LookUpGV.ForeColor =
                LopCombo.ForeColor = MHCombo.ForeColor = ActiveForeColor;
            SetIdleButtonEnabled(false);
            SetInputButtonEnabled(true);
            GVDK2GridControl.Enabled = false;

        }
        private void SaveOrigInput()
        {
            //do không dùng binding source nên phải lưu lại những giá trị này, nếu ko sẽ bị lỗi :<
            selectedRow = GVDK2BindingSource.Position;
            origThoiGian = int.Parse(Utils.GetCellValueBDS(GVDK2BindingSource, selectedRow, "THOIGIAN"));
            origSoCau = int.Parse(Utils.GetCellValueBDS(GVDK2BindingSource, selectedRow, "SOCAUTHI"));
            origNgayThi =
            DateTime.ParseExact(Utils.GetCellValueBDS(GVDK2BindingSource, selectedRow, "NGAYTHI"), "dd/MM/yyyy hh:mm:ss tt", CultureInfo.InvariantCulture);
        }
        private void buttonThem_Click(object sender, EventArgs e)
        {
            SaveOrigInput();
            ConfigInputState();
            InfoPanel.Text = "Thêm thông tin đăng ký thi";
            InfoPanel.ForeColor = Utils.AddColor;
            SetBlankDataInput();
            state = State.add;
            SetLan();
        }
        private void ClearErrors()
        {
            GVEP.SetError(LookUpGV, null);
            TrinhDoEP.SetError(panelTrinhDo, null);
            LanEP.SetError(panelLan, null);
            SoCauEP.SetError(labelCau, null);
            ThoiGianEP.SetError(labelPhut, null);
            NgayThiEP.SetError(NgayThi, null);
        }

        private void ConfigIdleState()
        {
            GVDK2GridControl.Enabled = true;
            InfoPanel.Enabled = false;
            InfoPanel.ForeColor = LookUpGV.ForeColor =
                LopCombo.ForeColor = MHCombo.ForeColor = DisabledForeColor;
            SetIdleButtonEnabled(true);
            SetInputButtonEnabled(false);
            ClearErrors();
            SetOrigDefaultValue();

            InfoPanel.Text = "Thông tin đăng ký thi";
            InfoPanel.ForeColor = Utils.DisabledColor;
        }
        private void buttonHuy_Click(object sender, EventArgs e)
        {

            GVDK2BindingSource.Position = selectedRow;
            Utils.SetCellValueBDS(GVDK2BindingSource, selectedRow, "THOIGIAN", origThoiGian);
            Utils.SetCellValueBDS(GVDK2BindingSource, selectedRow, "SOCAUTHI", origSoCau);
            Utils.SetCellValueBDS(GVDK2BindingSource, selectedRow, "NGAYTHI", origNgayThi);
            spinSoCau.Value = origSoCau;
            spinThoiGian.Value = origThoiGian;
            NgayThi.EditValue = origNgayThi;
            GetCorrData();

            ConfigIdleState();
            state = State.idle;

        }

        private void buttonLamMoi_Click(object sender, EventArgs e)
        {
            try
            {
                LoadAllData();
                Utils.ShowMessage("Làm mới thành công", Others.NotiForm.FormType.Success, 1);

            }
            catch (Exception ex)
            {
                Utils.ShowMessage("Lỗi khi tải lại dữ liệu", Others.NotiForm.FormType.Error, 1);
                Console.WriteLine(ex.StackTrace);
                return;
            }
        }

        private string GetTrinhDo()
        {
            if (rdoA.Checked) return "A";
            else if (rdoB.Checked) return "B";
            else if (rdoC.Checked) return "C";
            else return null;
        }
        private int GetLan()
        {
            if (rdo1.Checked) return 1;
            else if (rdo2.Checked) return 2;
            else return -1;
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
                LoadAllData();
                this.PreviousIndexCS = this.CoSoComboBox.SelectedIndex;
            }
        }

        private bool AlreadyExistsDKT(string maMH, string maLop, int lan)
        {
            List<Para> paraList = new List<Para>();
            paraList.Add(new Para("@MaMH", maMH));
            paraList.Add(new Para("@MaLop", maLop));
            paraList.Add(new Para("@Lan", lan));
            string SPName = "usp_GVDK_GetInfoByIDs";
            SqlDataReader myReader = DBConnection.ExecuteSqlDataReaderSP(SPName, paraList);
            if (myReader == null)
            {
                Console.WriteLine(System.Environment.StackTrace);
                return true;
            }
            if (myReader.HasRows)
            {
                myReader.Close();
                return true;

            }
            else
            {
                myReader.Close();
                return false;
            }
        }
        private void UncheckAllRDO()
        {
            rdoA.Checked = rdoB.Checked =
            rdoC.Checked = false;
        }
        private void SetBlankDataInput()
        {
            LookUpGV.EditValue = null;

            //MHCombo.SelectedIndex = 0;
            //LopCombo.SelectedIndex = 0;
            MonHocBindingSource.Position = 0;
            LopBindingSource.Position = 0;


            NgayThi.EditValue = DateTime.Now.AddDays(1);
            spinSoCau.Value = 10;
            spinThoiGian.Value = 15;
            UncheckAllRDO();

        }

        private int CheckSoLan(string maMH, string maLop)
        {
            List<Para> paraList = new List<Para>();
            paraList.Add(new Para("@MaMH", maMH));
            paraList.Add(new Para("@MaLop", maLop));
            string SPName = "usp_GVDK_CheckSoLan";
            SqlDataReader myReader = DBConnection.ExecuteSqlDataReaderSP(SPName, paraList);
            if (myReader == null)
                return -1;
            else
            {
                myReader.Read();
                int resultSQL = int.Parse(myReader.GetValue(0).ToString());
                myReader.Close();
                return resultSQL;
            }


        }
        private void buttonXacNhan_Click(object sender, EventArgs e)
        {
            bool test1 = LookUpGV.EditValue is null;
            bool test2 = !rdoA.Checked && !rdoB.Checked && !rdoC.Checked;
            bool test3 = !rdo1.Checked && !rdo2.Checked;
            bool test4 = spinSoCau.Value < 10 || spinSoCau.Value > 100;
            bool test5 = spinThoiGian.Value < 15 || spinSoCau.Value > 60;
            bool test6 = !CanDeleteEdit(NgayThi.DateTime);
            if (test1 || test2 || test3 || test4 || test5 || test6)
            {
                if (test1)
                    GVEP.SetError(LookUpGV, "Vui lòng chọn giáo viên giảng dạy");
                else
                    GVEP.SetError(LookUpGV, null);
                if (test2)
                    TrinhDoEP.SetError(panelTrinhDo, "Vui lòng chọn trình độ");
                else
                    TrinhDoEP.SetError(panelTrinhDo, null);
                if (test3)
                    LanEP.SetError(panelLan, "Vui lòng chọn lần thi");
                else
                    LanEP.SetError(panelLan, null);
                if (test4)
                    SoCauEP.SetError(labelCau, "Số câu phải nằm trong khoảng từ 10 đến 100 câu");
                else
                    SoCauEP.SetError(labelCau, null);
                if (test5)
                    ThoiGianEP.SetError(labelPhut, "Thời gian phải nằm trong khoảng từ 15 đến 60 phút");
                else
                    ThoiGianEP.SetError(labelPhut, null);
                if (test6)
                    NgayThiEP.SetError(NgayThi, "Ngày thi phải lớn hơn ngày hiện tại");
                else
                    NgayThiEP.SetError(NgayThi, null);


                Utils.ShowMessage("Vui lòng xem lại thông tin đã nhập", Others.NotiForm.FormType.Error, 2);
                return;
            }
            else
            {
                ClearErrors();
            }
            string maGV = (LookUpGV.GetSelectedDataRow() as DataRowView)["MaGV"].ToString().Trim();
            string maMH = MHCombo.SelectedValue.ToString().Trim();
            string maLop = LopCombo.SelectedValue.ToString().Trim();
            string trinhDo = GetTrinhDo();
            string ngayThi = ((DateTime)NgayThi.EditValue).ToString("dd/MM/yyyy");
            int lan = GetLan();
            int soCau = (int)spinSoCau.Value;
            int thoiGian = (int)spinThoiGian.Value;

            bool testMH = !origMaMH.ToLower().Equals(maMH.ToLower());
            bool testLop = !origMaLop.ToLower().Equals(maLop.ToLower());
            bool testLan = lan != origLan;


            if (testMH || testLop || testLan)
            {
                if (AlreadyExistsDKT(maMH, maLop, lan))
                {
                    Utils.ShowMessage("Thông tin này đăng ký đã tồn tại", Others.NotiForm.FormType.Error, 2);
                    return;
                }
            }
            LopBindingSource.Position = LopBindingSource.Find("MALOP", maLop);
            if (SVBindingSource.Count == 0)
            {
                Utils.ShowMessage("Lớp không có sinh viên nào, không thể đăng ký thi", Others.NotiForm.FormType.Error, 2);
                return;
            }






            List<Para> paraList = new List<Para>();
            paraList.Add(new Para("@MaGV", maGV));
            paraList.Add(new Para("@MaMH", maMH));
            paraList.Add(new Para("@MaLop", maLop));
            paraList.Add(new Para("@TrinhDo", trinhDo));
            paraList.Add(new Para("@NgayThi", ngayThi));
            paraList.Add(new Para("@Lan", lan));
            paraList.Add(new Para("@SoCauThi", soCau));
            paraList.Add(new Para("@ThoiGian", thoiGian));
            if (state == State.add)
            {
                string SPName = "usp_GVDK_AddRecord";
                SqlDataReader myReader = DBConnection.ExecuteSqlDataReaderSP(SPName, paraList);
                if (myReader == null)
                {
                    // Console.WriteLine(System.Environment.StackTrace);
                    return;
                }
                myReader.Close();
                Utils.ShowMessage("Thêm thông tin đăng ký thi thành công", Others.NotiForm.FormType.Success, 2);
            }
            else if (state == State.edit)
            {
                paraList.Add(new Para("@OldMaMH", origMaMH));
                paraList.Add(new Para("@OldMaLop", origMaLop));
                paraList.Add(new Para("@OldLan", origLan));
                string SPName = "usp_GVDK_UpdateRecord";
                SqlDataReader myReader = DBConnection.ExecuteSqlDataReaderSP(SPName, paraList);
                if (myReader == null)
                {
                    return;
                }
                myReader.Close();
                Utils.ShowMessage("Sửa thông tin đăng ký thi thành công", Others.NotiForm.FormType.Success, 2);
            }

            string tenMH = MHCombo.Text;
            string tenLop = LopCombo.Text; // phải để trước, để sau sẽ trigger GetCorrData làm dữ liệu bị sai
            LoadGVDK2();
            GVDK2BindingSource.Position = FindGVDK2Row(tenMH, tenLop, (short)lan);

            ConfigIdleState();
            state = State.idle;
        }
        private int FindGVDK2Row(string tenMH, string tenLop, short lan)
        {
            DataTable dt = TN_CSDLPTDataSet.GVDK_ENDUSER;
            int recordsNumber = dt.Rows.Count;

            for (int i = 0; i < recordsNumber; i++)
            {
                var row = dt.Rows[i];
                string test1 = row["TENMH"].ToString();
                string test2 = row["TENLOP"].ToString();
                string test3 = row["LAN"].ToString();
                if (row["TENMH"].ToString().Equals(tenMH) && row["TENLOP"].ToString().Equals(tenLop) && (short)row["LAN"] == lan)
                {
                    return i;
                }
            }
            return -1;
        }
        //private int FindGVDK2Row(string maMH, string maLop, short lan)
        //{
        //    //GVDK và GVDK2 có cùng index, chỉ khác kiểu dữ liệu hiện lên.
        //    DataTable dt = TN_CSDLPTDataSet.GIAOVIEN_DANGKY;
        //    int recordsNumber = dt.Rows.Count;

        //    for (int i = 0; i < recordsNumber; i++)
        //    {
        //        var row = dt.Rows[i] as GIAOVIEN_DANGKYRow;
        //        if (row.MAMH.Trim().Equals(maMH) && row.MALOP.Trim().Equals(maLop) && row.LAN == lan)
        //        {
        //            return i;
        //        }
        //    }
        //    return -1;
        //}
        private void buttonSua_Click(object sender, EventArgs e)
        {
            if (CanDeleteEdit(NgayThi.DateTime))
            {
                SaveOrigInput();
                ConfigInputState();
                InfoPanel.Text = "Sửa thông tin đăng ký thi";
                InfoPanel.ForeColor = Utils.EditColor;
                origMaLop = LopCombo.SelectedValue.ToString().Trim();
                origMaMH = MHCombo.SelectedValue.ToString().Trim();
                origLan = GetLan();
                state = State.edit;
            }
            else
            {
                Utils.ShowMessage("Không thể chỉnh sửa ngày thi đã kết thúc hoặc đang diễn ra", NotiForm.FormType.Error, 3);
                return;
            }

        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            DateTime ngayThi = NgayThi.DateTime;
            if (CanDeleteEdit(ngayThi))
            {
                if (Utils.ShowConfirmMessage("Bạn có chắc muốn xóa thông tin đăng ký thi này?", "Xác nhận"))
                {
                    string maMH = MHCombo.SelectedValue.ToString();
                    string maLop = LopCombo.SelectedValue.ToString();
                    int lan = GetLan();
                    List<Para> paraList = new List<Para>();
                    paraList.Add(new Para("@OldMaMH", maMH));
                    paraList.Add(new Para("@OldMaLop", maLop));
                    paraList.Add(new Para("@OldLan", lan));

                    string SPName = "usp_GVDK_DeleteRecord";
                    SqlDataReader myReader = DBConnection.ExecuteSqlDataReaderSP(SPName, paraList);
                    if (myReader == null)
                        return;
                    else
                    {
                        Utils.ShowMessage("Xóa thông tin đăng ký thi thành công", NotiForm.FormType.Success, 2);
                        LoadGVDK2();
                        myReader.Close();
                        return;
                    }

                }
            }
            else
            {
                Utils.ShowMessage("Không thể xóa ngày thi đã kết thúc hoặc đang diễn ra", NotiForm.FormType.Warning, 2);
                return;
            }

        }

        private void SetCorrRDOTrinhDo()
        {
            string trinhDo = Utils.GetCellValueBDS(GVDK2BindingSource, GVDK2BindingSource.Position, "TRINHDO");
            switch (trinhDo)
            {
                case "A":
                    rdoA.Checked = true;
                    break;
                case "B":
                    rdoB.Checked = true;
                    break;
                case "C":
                    rdoC.Checked = true;
                    break;

            }
        }

        private void SetCorrRDOLan()
        {
            string lan = Utils.GetCellValueBDS(GVDK2BindingSource, GVDK2BindingSource.Position, "LAN");
            switch (lan)
            {
                case "1":
                    rdo1.Checked = true;
                    break;
                case "2":
                    rdo2.Checked = true;
                    break;
            }
        }

        private void SetCorrBDS(BindingSource bds, string columnName)
        {
            bds.Position = bds.Find(columnName,
               Utils.GetCellValueBDS(GVDK2BindingSource, GVDK2BindingSource.Position, columnName));
        }
        private void SetCorrBDS(BindingSource bds, string columnName, GridLookUpEdit lookUp)
        {
            SetCorrBDS(bds, columnName);
            lookUp.EditValue = bds[bds.Position] as DataRowView;
        }


        private void GetCorrData()
        {
            SetCorrBDS(DSGVBindingSource, "MAGV", LookUpGV);
            SetCorrBDS(LopBindingSource, "TENLOP");
            SetCorrBDS(MonHocBindingSource, "TENMH");
            SetCorrRDOTrinhDo();
            SetCorrRDOLan();
            //  không cần ngày thi, thời gian, số câu do dùng data binding của GVDK2 luôn
        }

        private void GVDK2GridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (GVDK2BindingSource.Position != -1)
            {
                GetCorrData();
            }

        }

        private void SetLan()
        {
            if (MHCombo.SelectedValue != null && LopCombo.SelectedValue != null)
            {
                string maMH = MHCombo.SelectedValue.ToString();
                string maLop = LopCombo.SelectedValue.ToString();

                if (maMH != "System.Data.DataRowView" && maLop != "System.Data.DataRowView")
                {
                    int soLan = CheckSoLan(maMH, maLop);
                    if (state == State.add)
                    {
                        if (soLan == 0)
                            rdo1.Checked = true;
                        else rdo2.Checked = true;
                    }



                    if (state == State.edit)
                    {
                        if (maMH != origMaMH && maLop != origMaLop)
                        {
                            if (soLan == 0)
                                rdo1.Checked = true;
                            else rdo2.Checked = true;
                        }
                        else
                        {
                            if (soLan == 1 || soLan == 0) rdo1.Checked = true;
                            else rdo2.Checked = true;
                        }
                    }
                }

            }
            //  if (state == State.edit && maMH.Equals(origMaMH) && maLop.Equals(origMaLop)) return;


        }

        private void LopCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetLan();
        }

        private void MHCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetLan();
        }

        private void FormDKThi_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (state != State.idle)
                if (!Utils.ShowConfirmMessage("Hủy những thay đổi đang thực hiện và đóng cửa sổ này?", "Xác nhận"))
                    e.Cancel = true;
        }

        private void pictureBox2_EnabledChanged(object sender, EventArgs e)
        {
            Image image = pictureBox2.Enabled ? global::TracNghiemCSDLPT.Properties.Resources.info_480px :
                global::TracNghiemCSDLPT.Properties.Resources.info_480px_disabled;
            pictureBox2.Image = image;
        }
    }
}