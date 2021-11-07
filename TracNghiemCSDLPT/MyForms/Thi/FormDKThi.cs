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
using static TracNghiemCSDLPT.TnCsdlptDataSet;

namespace TracNghiemCSDLPT.MyForms.Thi
{
    public partial class FormDkThi : DevExpress.XtraEditors.XtraForm
    {
        public FormDkThi()
        {
            InitializeComponent();
        }
        private int _selectedRow;
        enum State
        {
            Idle, Edit, Add
        }
        private State _state = State.Idle;
        readonly Color _activeForeColor = Color.FromArgb(72, 70, 68);
        readonly Color _disabledForeColor = SystemColors.AppWorkspace;
        private int _previousIndexCS;
        private string _origMaMH = "!@#$%";
        private string _origMaLop = "!@#$%";
        private int _origLan = -1;
        //------------Dùng trong add---------
        private int _origSoCau;
        private int _origThoiGian;
        private DateTime _origNgayThi;
        private void SetInputButtonEnabled(bool state)
        {
            buttonHuy.Visible = buttonXacNhan.Visible = state;
        }
        private void LoadGvdk2()
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
        private void LoadDsgv()
        {
            this.DSGVTableAdapter.Connection.ConnectionString = DBConnection.SubcriberConnectionString;
            this.DSGVTableAdapter.Fill(this.TN_CSDLPTDataSet.DSGIAOVIEN);
        }
        private void LoadSv()
        {
            this.SVTableAdapter.Connection.ConnectionString = DBConnection.SubcriberConnectionString;
            this.SVTableAdapter.Fill(this.TN_CSDLPTDataSet.SINHVIEN);
        }

        private void LoadAllData()
        {
            LoadGvdk2();
            LoadLop();
            LoadSv();
            LoadMonHoc();
            LoadDsgv();
        }
        private void SetOrigDefaultValue()
        {
            _origMaMH = "!@#$%";
            _origMaLop = "!@#$%";
            _origLan = -1;
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

            Utils.BindingComboData(this.CoSoComboBox, this._previousIndexCS);

            NgayThi.EditValue = ((DateTime)NgayThi.EditValue).AddDays(1);

            PhanQuyen();
            Utils.ConfigControlColor(InfoPanel);
            GVDK2GridView.Columns["NGAYTHI"].SortOrder = DevExpress.Data.ColumnSortOrder.Descending;

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
                LopCombo.ForeColor = MHCombo.ForeColor = _activeForeColor;
            SetIdleButtonEnabled(false);
            SetInputButtonEnabled(true);
            GVDK2GridControl.Enabled = false;

        }
        private void SaveOrigInput()
        {
            //do không dùng binding source nên phải lưu lại những giá trị này, nếu ko sẽ bị lỗi :<
            _selectedRow = GVDK2BindingSource.Position;
            _origThoiGian = int.Parse(Utils.GetCellStringBds(GVDK2BindingSource, _selectedRow, "THOIGIAN"));
            _origSoCau = int.Parse(Utils.GetCellStringBds(GVDK2BindingSource, _selectedRow, "SOCAUTHI"));
            _origNgayThi =
            DateTime.ParseExact(Utils.GetCellStringBds(GVDK2BindingSource, _selectedRow, "NGAYTHI"), "dd/MM/yyyy hh:mm:ss tt", CultureInfo.InvariantCulture);
        }
        private void buttonThem_Click(object sender, EventArgs e)
        {
            SaveOrigInput();
            ConfigInputState();
            Utils.ConfigInfoPanelAppearance(InfoPanel, "Thêm thông tin đăng ký thi", Utils.AddColor);
            SetBlankDataInput();
            _state = State.Add;
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
                LopCombo.ForeColor = MHCombo.ForeColor = _disabledForeColor;
            SetIdleButtonEnabled(true);
            SetInputButtonEnabled(false);
            ClearErrors();
            SetOrigDefaultValue();

            Utils.ConfigInfoPanelAppearance(InfoPanel, "Thông tin đăng ký thi", Utils.DisabledColor);
        }
        private void buttonHuy_Click(object sender, EventArgs e)
        {

            GVDK2BindingSource.Position = _selectedRow;
            Utils.SetCellValueBds(GVDK2BindingSource, _selectedRow, "THOIGIAN", _origThoiGian);
            Utils.SetCellValueBds(GVDK2BindingSource, _selectedRow, "SOCAUTHI", _origSoCau);
            Utils.SetCellValueBds(GVDK2BindingSource, _selectedRow, "NGAYTHI", _origNgayThi);
            spinSoCau.Value = _origSoCau;
            spinThoiGian.Value = _origThoiGian;
            NgayThi.EditValue = _origNgayThi;
            GetCorrData();

            ConfigIdleState();
            _state = State.Idle;

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
                this.CoSoComboBox.SelectedIndex = this._previousIndexCS;
                return;
            }
            else
            {
                LoadAllData();
                this._previousIndexCS = this.CoSoComboBox.SelectedIndex;
            }
        }

        private bool AlreadyExistsDkt(string maMh, string maLop, int lan)
        {
            List<Para> paraList = new List<Para>();
            paraList.Add(new Para("@MaMH", maMh));
            paraList.Add(new Para("@MaLop", maLop));
            paraList.Add(new Para("@Lan", lan));
            string spName = "usp_GVDK_GetInfoByIDs";
            SqlDataReader myReader = DBConnection.ExecuteSqlDataReaderSP(spName, paraList);
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

        private int GetNumberOfQuestsions(string maMh, string trinhDo, int soCauHoi)
        {
            List<Para> paraList = new List<Para>();
            paraList.Add(new Para("@MaMH", maMh));
            paraList.Add(new Para("@TrinhDo", trinhDo));
            string spName = "usp_BoDe_CheckNumberOfQuestions";
            SqlDataReader myReader = DBConnection.ExecuteSqlDataReaderSP(spName, paraList);
            if (myReader == null)
            {
                Console.WriteLine(System.Environment.StackTrace);
                return -1;
            }
            myReader.Read();
            int soCauHoiReal = int.Parse(myReader.GetValue(0).ToString());
            myReader.Close();
            return soCauHoiReal;
        }
        private void UncheckAllRdo()
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
            UncheckAllRdo();

        }

        private int CheckSoLan(string maMh, string maLop)
        {
            List<Para> paraList = new List<Para>();
            paraList.Add(new Para("@MaMH", maMh));
            paraList.Add(new Para("@MaLop", maLop));
            string spName = "usp_GVDK_CheckSoLan";
            SqlDataReader myReader = DBConnection.ExecuteSqlDataReaderSP(spName, paraList);
            if (myReader == null)
                return -1;
            else
            {
                myReader.Read();
                int resultSql = int.Parse(myReader.GetValue(0).ToString());
                myReader.Close();
                return resultSql;
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
            string maMh = MHCombo.SelectedValue.ToString().Trim();
            string maLop = LopCombo.SelectedValue.ToString().Trim();
            string trinhDo = GetTrinhDo();
            string ngayThi = ((DateTime)NgayThi.EditValue).ToString("dd/MM/yyyy");
            int lan = GetLan();
            int soCau = (int)spinSoCau.Value;
            int thoiGian = (int)spinThoiGian.Value;

            bool testMh = !_origMaMH.ToLower().Equals(maMh.ToLower());
            bool testLop = !_origMaLop.ToLower().Equals(maLop.ToLower());
            bool testLan = lan != _origLan;


            if (testMh || testLop || testLan)
            {
                if (AlreadyExistsDkt(maMh, maLop, lan))
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
            int soCauHoiReal = GetNumberOfQuestsions(maMh, trinhDo, soCau);
            Console.WriteLine("Real: " + soCauHoiReal);
            if (soCauHoiReal < soCau)
            {
                Utils.ShowMessage("Không đủ số câu hỏi để tạo đề thi (" + 
                    soCauHoiReal +" < " +  soCau + ")", Others.NotiForm.FormType.Error, 2);
                return;
            }
            


            List<Para> paraList = new List<Para>();
            paraList.Add(new Para("@MaGV", maGV));
            paraList.Add(new Para("@MaMH", maMh));
            paraList.Add(new Para("@MaLop", maLop));
            paraList.Add(new Para("@TrinhDo", trinhDo));
            paraList.Add(new Para("@NgayThi", ngayThi));
            paraList.Add(new Para("@Lan", lan));
            paraList.Add(new Para("@SoCauThi", soCau));
            paraList.Add(new Para("@ThoiGian", thoiGian));
            if (_state == State.Add)
            {
                string spName = "usp_GVDK_AddRecord";
                SqlDataReader myReader = DBConnection.ExecuteSqlDataReaderSP(spName, paraList);
                if (myReader == null)
                {
                    // Console.WriteLine(System.Environment.StackTrace);
                    return;
                }
                myReader.Close();
                Utils.ShowMessage("Thêm thông tin đăng ký thi thành công", Others.NotiForm.FormType.Success, 2);
            }
            else if (_state == State.Edit)
            {
                paraList.Add(new Para("@OldMaMH", _origMaMH));
                paraList.Add(new Para("@OldMaLop", _origMaLop));
                paraList.Add(new Para("@OldLan", _origLan));
                string spName = "usp_GVDK_UpdateRecord";
                SqlDataReader myReader = DBConnection.ExecuteSqlDataReaderSP(spName, paraList);
                if (myReader == null)
                {
                    return;
                }
                myReader.Close();
                Utils.ShowMessage("Sửa thông tin đăng ký thi thành công", Others.NotiForm.FormType.Success, 2);
            }

            string tenMh = MHCombo.Text;
            string tenLop = LopCombo.Text; // phải để trước, để sau sẽ trigger GetCorrData làm dữ liệu bị sai
            LoadGvdk2();
            GVDK2BindingSource.Position = FindGvdk2Row(tenMh, tenLop, (short)lan);

            ConfigIdleState();
            _state = State.Idle;
        }
        private int FindGvdk2Row(string tenMh, string tenLop, short lan)
        {
            DataTable dt = TN_CSDLPTDataSet.GVDK_ENDUSER;
            int recordsNumber = dt.Rows.Count;

            for (int i = 0; i < recordsNumber; i++)
            {
                var row = dt.Rows[i];
                string test1 = row["TENMH"].ToString();
                string test2 = row["TENLOP"].ToString();
                string test3 = row["LAN"].ToString();
                if (row["TENMH"].ToString().Equals(tenMh) && row["TENLOP"].ToString().Equals(tenLop) && (short)row["LAN"] == lan)
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
                Utils.ConfigInfoPanelAppearance(InfoPanel, "Sửa thông tin đăng ký thi", Utils.EditColor);
                _origMaLop = LopCombo.SelectedValue.ToString().Trim();
                _origMaMH = MHCombo.SelectedValue.ToString().Trim();
                _origLan = GetLan();
                _state = State.Edit;
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
                    string maMh = MHCombo.SelectedValue.ToString();
                    string maLop = LopCombo.SelectedValue.ToString();
                    int lan = GetLan();
                    List<Para> paraList = new List<Para>();
                    paraList.Add(new Para("@OldMaMH", maMh));
                    paraList.Add(new Para("@OldMaLop", maLop));
                    paraList.Add(new Para("@OldLan", lan));

                    string spName = "usp_GVDK_DeleteRecord";
                    SqlDataReader myReader = DBConnection.ExecuteSqlDataReaderSP(spName, paraList);
                    if (myReader == null)
                        return;
                    else
                    {
                        Utils.ShowMessage("Xóa thông tin đăng ký thi thành công", NotiForm.FormType.Success, 2);
                        LoadGvdk2();
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

        private void SetCorrRdoTrinhDo()
        {
            string trinhDo = Utils.GetCellStringBds(GVDK2BindingSource, GVDK2BindingSource.Position, "TRINHDO");
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

        private void SetCorrRdoLan()
        {
            string lan = Utils.GetCellStringBds(GVDK2BindingSource, GVDK2BindingSource.Position, "LAN");
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

        private void SetCorrBds(BindingSource bds, string columnName)
        {
            bds.Position = bds.Find(columnName,
               Utils.GetCellStringBds(GVDK2BindingSource, GVDK2BindingSource.Position, columnName));
        }
        private void SetCorrBds(BindingSource bds, string columnName, GridLookUpEdit lookUp)
        {
            SetCorrBds(bds, columnName);
            lookUp.EditValue = bds[bds.Position] as DataRowView;
        }


        private void GetCorrData()
        {
            SetCorrBds(DSGVBindingSource, "MAGV", LookUpGV);
            SetCorrBds(LopBindingSource, "TENLOP");
            SetCorrBds(MonHocBindingSource, "TENMH");
            SetCorrRdoTrinhDo();
            SetCorrRdoLan();
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
                string maMh = MHCombo.SelectedValue.ToString();
                string maLop = LopCombo.SelectedValue.ToString();

                if (maMh != "System.Data.DataRowView" && maLop != "System.Data.DataRowView")
                {
                    int soLan = CheckSoLan(maMh, maLop);
                    if (_state == State.Add)
                    {
                        if (soLan == 0)
                            rdo1.Checked = true;
                        else rdo2.Checked = true;
                    }



                    if (_state == State.Edit)
                    {
                        if (maMh != _origMaMH && maLop != _origMaLop)
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
            if (_state != State.Idle)
                if (!Utils.ShowConfirmMessage("Hủy những thay đổi đang thực hiện và đóng cửa sổ này?", "Xác nhận"))
                    e.Cancel = true;
        }

        private void pictureBox2_EnabledChanged(object sender, EventArgs e)
        {
            Image image = pictureBox2.Enabled ? global::TracNghiemCSDLPT.Properties.Resources.info_480px :
                global::TracNghiemCSDLPT.Properties.Resources.info_480px_disabled;
            pictureBox2.Image = image;
        }

        private void GVDK2GridView_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.RowHandle == GVDK2GridView.FocusedRowHandle) return;

            //if (((DateTime)Utils.GetCellValueBds(GVDK2BindingSource, e.RowHandle, "NGAYTHI")).Date >= DateTime.Now.Date)
            //{
            //    e.Appearance.BackColor = Color.FromArgb(255, 237, 211);
            //}
            if (((DateTime)GVDK2GridView.GetDataRow(e.RowHandle)["NGAYTHI"]).Date >= DateTime.Now.Date)
            {
                e.Appearance.BackColor = Color.FromArgb(255, 237, 211);
            }
        }
    }
}