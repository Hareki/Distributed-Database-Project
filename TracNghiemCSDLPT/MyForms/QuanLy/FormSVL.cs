using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.DXErrorProvider;
using DevExpress.XtraEditors.ViewInfo;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using TracNghiemCSDLPT.Others;

namespace TracNghiemCSDLPT.MyForms.QuanLy
{
    public partial class FormSvl : DevExpress.XtraEditors.XtraForm
    {
        public FormSvl()
        {
            InitializeComponent();

        }
        private bool _cancelEditSV = false;
        private void PhanQuyen()
        {
            switch (DBConnection.NhomQuyen)
            {
                case "TRUONG":
                    SetIdleButtonEnabledSv(false);
                    SetIdleButtonEnabled_Lop(false);
                    buttonLamMoiSV.Enabled = true;
                    buttonLamMoiLop.Enabled = true;
                    break;
                case "COSO":
                    CoSoComboBox.Enabled = false;
                    break;
            }

        }

        private int _previousIndexCS;
        private int _selectedRowLop;
        private int _selectedRowSV;
        private DataRowView _saveKhoaValue;

        private string _origMaLop = string.Empty;
        private string _origTenLop = string.Empty;

        private string _origMaSV = string.Empty;
        private int _editingSvIndex;




        State _state = State.Idle;
        enum State
        {
            AddLop, EditLop, Idle, AddSv, EditSv
        }



        private void LoadAllData()
        {
            this.KhoaTableAdapter.Connection.ConnectionString = DBConnection.SubcriberConnectionString;
            this.LopTableAdapter.Connection.ConnectionString = DBConnection.SubcriberConnectionString;
            this.SinhVienTableAdapter.Connection.ConnectionString = DBConnection.SubcriberConnectionString;
            this.GV_DKTableAdapter.Connection.ConnectionString = DBConnection.SubcriberConnectionString;
            this.BangDiemTableAdapter.Connection.ConnectionString = DBConnection.SubcriberConnectionString;
            this.DSKhoaTableAdapter.Connection.ConnectionString = DBConnection.SubcriberConnectionString;

            this.KhoaTableAdapter.Fill(this.TN_CSDLPTDataSet.KHOA);
            this.LopTableAdapter.Fill(this.TN_CSDLPTDataSet.LOP);
            this.SinhVienTableAdapter.Fill(this.TN_CSDLPTDataSet.SINHVIEN);
            this.GV_DKTableAdapter.Fill(this.TN_CSDLPTDataSet.GIAOVIEN_DANGKY);
            this.BangDiemTableAdapter.Fill(this.TN_CSDLPTDataSet.BANGDIEM);
            this.DSKhoaTableAdapter.Fill(this.TN_CSDLPTDataSet.DSKhoa);

            SetCorrButtonsState_Lop();
            //    checkButtonStateSV(); lúc nãy chưa có mã lớp, để ở đây sẽ không có dữ liệu
        }
        private bool CheckTheRow(int rowHandle)
        {
            //lúc add new() row handle chưa có dữ liệu (= -2147483647), khi select qua row khác rồi select lại thì mới nhận
            bool test1 = _state != State.AddSv && _state != State.EditSv;
            bool test2A = rowHandle == SinhVienGridView.RowCount - 1;
            // bool test2b = rowHandle == -2147483647;
            bool test3 = rowHandle == _editingSvIndex;
            if (test1) return false;
            if (((test2A) && _state == State.AddSv) || (test3 && _state == State.EditSv))
            {
                return true;
            }
            return false;
        }


        private GridView GetCorrTextBoxData(bool getFirstRow)
        {
            GridView detailView;
            if (getFirstRow)
                detailView = KhoaGridView.GetDetailView(0, 0) as GridView;
            else
            {
                if (KhoaGridView.GetSelectedRows().Length == 0)
                    detailView = KhoaGridView.GetDetailView(0, 0) as GridView;
                else
                {
                    int row = KhoaGridView.GetSelectedRows()[0];
                    detailView = KhoaGridView.GetDetailView(row, 0) as GridView;
                }

            }
            if (detailView is null) return null;
            Object test = (detailView as GridView).GetFocusedRowCellValue(colMALOP1);
            string maLop;
            if (test != null)
                maLop = test.ToString();
            else return null;
            LopBindingSource.Position = LopBindingSource.Find("MALOP", maLop);
            string maLop2 = ((DataRowView)LopBindingSource[LopBindingSource.Position])["MALOP"].ToString();
            this.ViewCaption.Text = "Danh sách sinh viên thuộc lớp " + maLop2.Trim();

            string maKh = ((DataRowView)LopBindingSource[LopBindingSource.Position])["MAKH"].ToString();
            DSKhoaBindingSource.Position = DSKhoaBindingSource.Find("MAKH", maKh);
            ComboMaKH.EditValue = DSKhoaBindingSource[DSKhoaBindingSource.Position];
            return detailView;

        }
        private void FormSVL_Load(object sender, EventArgs e)
        {
            this.TN_CSDLPTDataSet.EnforceConstraints = false;

            LoadAllData();

            Utils.BindingComboData(CoSoComboBox, _previousIndexCS);


            KhoaGridView.ExpandMasterRow(0);
            GridView view = GetCorrTextBoxData(true);
            if (view != null)
                view.Focus();
            SetCorrButtonsState_SV();
            PhanQuyen();

        }

        private void LopGridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            GetCorrTextBoxData(false);
        }

        private void KhoaGridView_MasterRowGetRelationDisplayCaption(object sender, MasterRowGetRelationNameEventArgs e)
        {
            GridView view = sender as GridView;
            if (view is null) return;
            string tenKhoa = (string)view.GetRowCellValue(e.RowHandle, colTENKH); ;
            if (e.RelationIndex == 0)
                e.RelationName = $"Lớp thuộc khoa {tenKhoa}";
        }

        private void KhoaGridView_DetailTabStyle(object sender, DetailTabStyleEventArgs e)
        {
            e.Appearance.Header.Font = new Font("Baloo 2", 10.0F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
        }

        private void CoSoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CoSoComboBox.SelectedValue.ToString() == "System.Data.DataRowView")
                return;
            string login, pass;
            string serverName = CoSoComboBox.SelectedValue.ToString();
            if (CoSoComboBox.SelectedIndex != DBConnection.IndexCS)//Không cần check loginSV, vì ko bao giờ hiện CB này
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

        private void SetIdleButtonEnabled_Lop(bool state)
        {
            if (LopBindingSource.Count == 0 && state == true)
            {
                buttonXoaLop.Enabled = buttonSuaLop.Enabled = false;
                buttonThemLop.Enabled = buttonLamMoiLop.Enabled = true;
            }
            else
            {
                buttonThemLop.Enabled = buttonSuaLop.Enabled =
                buttonXoaLop.Enabled = buttonLamMoiLop.Enabled = state;
            }
        }
        private void SetInputButtonVisible_Lop(bool state)
        {
            buttonHuyLop.Visible = buttonXacNhanLop.Visible = state;
        }

        private void SetIdleButtonEnabledSv(bool state)
        {
            if (SinhVienBindingSource.Count == 0 && state == true)
            {
                buttonXoaSV.Enabled = buttonSuaSV.Enabled = false;
                buttonThemSV.Enabled = buttonLamMoiSV.Enabled = true;
            }
            else
            {
                buttonThemSV.Enabled = buttonSuaSV.Enabled =
                buttonXoaSV.Enabled = state;
            }


        }
        private void SetInputButtonVisibleSv(bool state)
        {
            buttonHuySV.Visible = buttonXacNhanSV.Visible = state;
        }

        private void SetInputColor_Lop(Color color)
        {
            TextMaLop.ForeColor =
                TextTenLop.ForeColor = ComboMaKH.ForeColor = color;
        }

        private void buttonThemLop_Click(object sender, EventArgs e)
        {
            ConfigAddingState_Lop();
        }

        private void ConfigAddingState_Lop()
        {
            _selectedRowLop = LopBindingSource.Position;

            _state = State.AddLop;
            LopBindingSource.AddNew();
            SetCorrButtonsState_Lop();
            SetInputColor_Lop(Utils.ActiveColor);

            Utils.ConfigInfoPanelAppearance(InfoPanel, "Thêm mới thông tin lớp", Utils.AddColor);
            SetInfoPanelEnabled(true);

            KhoaGridControl.Enabled = false;
            SetSvState(false);

            _saveKhoaValue = ComboMaKH.EditValue as DataRowView;
            ComboMaKH.EditValue = null;
        }

        private void buttonHuyLop_Click(object sender, EventArgs e)
        {
            LopBindingSource.CancelEdit();
            ConfigIdleState_Lop();
        }

        private void ResetOrigValue()
        {
            _origMaLop = _origTenLop = string.Empty;
        }

        private void SaveOrigValue()
        {
            _origMaLop = TextMaLop.Text;
            _origTenLop = Utils.CapitalizeString(TextTenLop.Text, Utils.CapitalMode.FirstWordOnly);
        }
        private void ConfigIdleState_Lop()
        {
            ResetOrigValue();

            if (_state == State.AddLop)
                LopBindingSource.Position = _selectedRowLop;

            _state = State.Idle;
            SetCorrButtonsState_Lop();
            SetSvState(true);

            SetInputColor_Lop(Utils.DisabledColor);

            Utils.ConfigInfoPanelAppearance(InfoPanel, "Thông tin lớp", Utils.DisabledColor);

            ComboMaKH.EditValue = _saveKhoaValue;
            KhoaGridControl.Enabled = true;

            SetInfoPanelEnabled(false);

            ClearLopErrors();
        }

        private void SetInfoPanelEnabled(bool enabled)
        {
            // InfoPanel.Enabled = enabled; không thể set panel vì có các nút ở trong, sẽ bị set theo
            ComboMaKH.Enabled = TextTenLop.Enabled = TextMaLop.Enabled = enabled;
        }


        private void buttonLamMoiLop_Click(object sender, EventArgs e)
        {
            try
            {
                LoadAllData();
                this.ComboMaKH.EditValue = this.DSKhoaBindingSource[DSKhoaBindingSource.Position];
                Utils.ShowMessage("Làm mới thành công", Others.NotiForm.FormType.Success, 1);

                SetCorrButtonsState_Lop();
            }
            catch (Exception ex)
            {
                Utils.ShowMessage("Lỗi khi tải lại dữ liệu", Others.NotiForm.FormType.Error, 1);
                Console.WriteLine(ex.StackTrace);
                return;
            }
        }

        private void buttonSuaLop_Click(object sender, EventArgs e)
        {
            ConfigEditingState_Lop();
        }

        private void ConfigEditingState_Lop()
        {
            TextMaLop.Text = Utils.RemoveExtraSpace(TextMaLop.Text);
            SaveOrigValue();

            _state = State.EditLop;
            SetCorrButtonsState_Lop();
            SetInputColor_Lop(Utils.ActiveColor);

            SetInfoPanelEnabled(true);
            Utils.ConfigInfoPanelAppearance(InfoPanel, "Sửa thông tin lớp", Utils.EditColor);

            KhoaGridControl.Enabled = false;
            SetSvState(false);
        }



        private bool AlreadyExistsLop(string testName, bool isId)
        {
            List<Para> paraList = new List<Para>();
            string spName = "usp_Lop_GetInfoByXXX";
            if (isId)
            {
                spName = spName.Replace("XXX", "ID");
                paraList.Add(new Para("@ID", testName));
            }

            else
            {
                spName = spName.Replace("XXX", "Name");
                paraList.Add(new Para("@Name", testName));
            }
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

        private bool AlreadyExistsSv(string testName)
        {
            List<Para> paraList = new List<Para>();
            paraList.Add(new Para("@ID", testName));

            string spName = "usp_SinhVien_GetInfoByID";
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
        private void GoToNewlyCreatedRowLop(string maLop)
        {
            GridView detailView;
            string maKhWithRedunantSpace = (ComboMaKH.GetSelectedDataRow() as DataRowView)["MAKH"].ToString();//Do trong grid view thật sự có khoảng trắng
            int row = KhoaGridView.LocateByDisplayText(0, colMAKH, maKhWithRedunantSpace);
            //Console.WriteLine("Row: " + row);

            KhoaGridView.FocusedRowHandle = row;
            KhoaGridView.Focus();
            KhoaGridView.ExpandMasterRow(row);
            detailView = KhoaGridView.GetDetailView(row, 0) as GridView;
            if (detailView is null)
            {
                Utils.ShowErrorMessage("Lỗi không xác định (GoToNewlyCreatedRowLop)", "Lỗi");
                Console.WriteLine(System.Environment.StackTrace);
                return;
            }
            detailView.Focus();
            //    int rowToGo = detailView.RowCount - 1;
            int rowToGo = detailView.LocateByDisplayText(0, colMALOP1, maLop);
            detailView.FocusedRowHandle = rowToGo;
            detailView.MakeRowVisible(rowToGo);
        }

        private void ClearLopErrors()
        {
            Utils.SetTextEditError(MaLopEP, TextMaLop, null);
            Utils.SetTextEditError(TenLopEP, TextTenLop, null);
        }
        private string GetMaLopWithRedunantSpaces(string maLop)
        {
            string result = maLop;
            Debug.Assert(8 - maLop.Length >= 0);
            for (int i = 0; i < 8 - maLop.Length; i++)
            {
                result += " ";
            }
            return result;
        }
        private void ButtonXacNhanLop_Click(object sender, EventArgs e)
        {
            string maLop = TextMaLop.Text = Utils.RemoveExtraSpace(TextMaLop.Text);
            string tenLop = TextTenLop.Text = Utils.CapitalizeString
                (TextTenLop.Text, Utils.CapitalMode.FirstWordOnly);
            bool test1 = string.IsNullOrEmpty(maLop);
            bool test2 = string.IsNullOrEmpty(tenLop);
            bool testKH = ComboMaKH.EditValue == null;

            if (test1 || test2 || testKH)
            {
                if (test1)
                    Utils.SetTextEditError(MaLopEP, TextMaLop, "Vui lòng nhập mã lớp");
                else
                    Utils.SetTextEditError(MaLopEP, TextMaLop, null);
                if (test2)
                    Utils.SetTextEditError(TenLopEP, TextTenLop, "Vui lòng nhập tên lớp");
                else
                    Utils.SetTextEditError(TenLopEP, TextTenLop, null);
                if (testKH)
                    Utils.SetTextEditError(MaKhoaEP, ComboMaKH, "Vui lòng nhập khoa");
                else
                    Utils.SetTextEditError(MaKhoaEP, ComboMaKH, null);


                Utils.ShowMessage("Vui lòng điền đầy đủ thông tin cần thiết", Others.NotiForm.FormType.Error, 2);
                return;
            }
            else
            {
                ClearLopErrors();
            }


            bool test5 = maLop.Length > 8;
            bool test6 = tenLop.Length > 40;
            if (test5 || test6)
            {
                if (test5)
                    Utils.SetTextEditError(MaLopEP, TextMaLop, "Mã lớp không được quá 8 ký tự");
                else
                    Utils.SetTextEditError(MaLopEP, TextMaLop, null);

                if (test6)
                    Utils.SetTextEditError(TenLopEP, TextTenLop, "Tên lớp không được quá 40 ký tự");
                else
                    Utils.SetTextEditError(TenLopEP, TextTenLop, null);

                Utils.ShowMessage("Thông tin nhập quá dài", Others.NotiForm.FormType.Warning, 1);
                return;
            }


            bool test3 = !Utils.IsMathRegex(maLop, Utils.RegexType.IDRegex);
            bool test4 = !Utils.IsMathRegex(tenLop, Utils.RegexType.LetterDigits);

            if (test3 || test4)
            {
                if (test3)
                    Utils.SetTextEditError(MaLopEP, TextMaLop, "Mã lớp chỉ được chứa chữ không dấu và số");
                else
                    Utils.SetTextEditError(MaLopEP, TextMaLop, null);
                if (test4)
                    Utils.SetTextEditError(TenLopEP, TextTenLop, "Tên lớp chỉ được chứa chữ và số");
                else
                    Utils.SetTextEditError(TenLopEP, TextTenLop, null);


                Utils.ShowMessage("Vui lòng điền thông tin hợp lệ", Others.NotiForm.FormType.Error, 2);
                return;
            }
            else
            {
                ClearLopErrors();
            }

            test1 = test2 = false;
            if (!_origMaLop.ToLower().Equals(TextMaLop.Text.ToLower()))
                test1 = AlreadyExistsLop(TextMaLop.Text, true);
            if (!_origTenLop.ToLower().Equals(TextTenLop.Text.ToLower()))
                test2 = AlreadyExistsLop(TextTenLop.Text, false);

            if (test1 || test2)
            {
                if (test1)
                    Utils.SetTextEditError(MaLopEP, TextMaLop, "Mã lớp đã tồn tại");
                else
                    Utils.SetTextEditError(MaLopEP, TextMaLop, null);
                if (test2)
                    Utils.SetTextEditError(TenLopEP, TextTenLop, "Tên lớp đã tồn tại");
                else
                    Utils.SetTextEditError(TenLopEP, TextTenLop, null);

                Utils.ShowMessage("Thông tin vừa nhập đã tồn tại", Others.NotiForm.FormType.Error, 2);
                return;
            }
            else
            {
                ClearLopErrors();
            }
            try
            {
                ((DataRowView)LopBindingSource[LopBindingSource.Position])["MAKH"] = Utils.GetLookUpString(ComboMaKH, "MAKH");
                LopBindingSource.EndEdit();
                LopBindingSource.ResetCurrentItem();
                this.LopTableAdapter.Update(this.TN_CSDLPTDataSet.LOP);

                if (_state == State.EditLop)
                    Utils.ShowMessage("Sửa lớp thành công", Others.NotiForm.FormType.Success, 1);
                else if (_state == State.AddLop)
                {
                    GoToNewlyCreatedRowLop(GetMaLopWithRedunantSpaces(maLop));
                    Utils.ShowMessage("Thêm lớp thành công", Others.NotiForm.FormType.Success, 1);
                }

            }
            catch (Exception ex)
            {
                Utils.ShowErrorMessage("Không thể lưu lớp, xin vui lòng thử lại sau\n" + ex.Message, "Lỗi ghi lớp");
                return;
            }
            finally
            {
                ConfigIdleState_Lop();
            }

        }

        private void buttonXoaLop_Click(object sender, EventArgs e)
        {
            string removedLop = string.Empty;
            _selectedRowLop = LopBindingSource.Position;
            if (SinhVienBindingSource.Count > 0)
            {
                Utils.ShowMessage("Không thể xóa vì đã có sinh viên thuộc lớp này", Others.NotiForm.FormType.Error, 2);
                return;
            }
            if (GV_DKBindingSource.Count > 0)
            {
                Utils.ShowMessage("Không thể xóa vì đã có giảng viên đăng ký thi cho lớp này", Others.NotiForm.FormType.Error, 4);
                return;
            }

            if (Utils.ShowConfirmMessage("Bạn có chắc muốn xóa lớp này?", "Xác nhận"))
            {
                try
                {
                    removedLop = ((DataRowView)LopBindingSource[_selectedRowLop])["MALOP"].ToString();
                    LopBindingSource.RemoveCurrent();
                    LopTableAdapter.Update(TN_CSDLPTDataSet.LOP);
                    Utils.ShowMessage("Xóa lớp " + removedLop.Trim() + " thành công!", Others.NotiForm.FormType.Success, 1);
                }
                catch (Exception ex)
                {
                    Utils.ShowErrorMessage("Không thể xóa lớp này, xin vui lòng thử lại sau\n" + ex.Message, "Lỗi xóa lớp");
                    Console.WriteLine(ex.StackTrace);
                    this.LopTableAdapter.Fill(TN_CSDLPTDataSet.LOP);
                    LopBindingSource.Position = LopBindingSource.Find("MALOP", removedLop);
                    return;
                }
            }
            SetCorrButtonsState_Lop();
        }

        private void SetCorrButtonsState_SV()
        {
            if (Utils.IsCoSo())
            {
                switch (_state)
                {
                    case State.AddSv:
                        SetInputButtonVisibleSv(true);
                        SetIdleButtonEnabledSv(false);
                        break;
                    case State.EditSv:
                        SetInputButtonVisibleSv(true);
                        SetIdleButtonEnabledSv(false);
                        break;
                    case State.Idle:
                        SetInputButtonVisibleSv(false);
                        SetIdleButtonEnabledSv(true);

                        break;
                }
            }
        }
        private void ButtonThemSV_Click(object sender, EventArgs e)
        {
            ConfigAddingState_SV();

        }

        private void ConfigAddingState_SV()
        {
            _selectedRowSV = SinhVienBindingSource.Position;

            _state = State.AddSv;
            SetCorrButtonsState_SV();

            Utils.SetCustomizationEnabled(SinhVienGridView, false);
            SinhVienGridView.OptionsBehavior.Editable = true;

            SetLopEnabled(false);

            SinhVienBindingSource.AddNew();

        }

        private string ValidateMaSV(string maSv)
        {
            maSv = Utils.RemoveExtraSpace(maSv);
            if (string.IsNullOrEmpty(maSv))
                return "Vui lòng nhập mã sinh viên";
            if (maSv.Length > 8)
                return "Mã sinh viên không vượt quá 8 ký tự";
            if (!Utils.IsMathRegex(maSv, Utils.RegexType.IDRegex))
                return "Mã sinh viên chỉ được chứa chữ không dấu và số";

            bool test1 = false;
            if (!_origMaSV.Trim().Equals(maSv.Trim()))
            {
                //    Console.WriteLine("MAA" + maSV);
                test1 = AlreadyExistsSv(maSv);
            }


            if (test1)
                return "Mã sinh viên đã tồn tại";

            return string.Empty;
        }
        private string ValidateHoSV(string ho, int row)
        {
            ho = Utils.CapitalizeString(ho, Utils.CapitalMode.EveryWord);
            // setCellAtRowSV(colHO, ho, row);
            if (string.IsNullOrEmpty(ho))
                return "Vui lòng nhập họ và tên đệm sinh viên";

            if (!Utils.IsMathRegex(ho, Utils.RegexType.LetterOnly))
                return "Họ, tên đệm của SV chỉ được chứa chữ";

            if (ho.Length > 40)
                return "Họ sinh viên không vượt quá 40 ký tự";
            return string.Empty;
        }
        private string ValidateTenSv(string ten, int row)
        {
            ten = Utils.CapitalizeString(ten, Utils.CapitalMode.EveryWord);
            //    setCellAtRowSV(colTEN, ten, row);
            if (string.IsNullOrEmpty(ten))
                return "Vui lòng nhập tên sinh viên";

            if (!Utils.IsMathRegex(ten, Utils.RegexType.LetterOnly))
                return "Tên của sinh viên chỉ được chứa chữ";

            if (ten.Length > 10)
                return "Tên sinh viên không vượt quá 10 ký tự";
            return string.Empty;
        }

        private string ValidateDiaChi(string diaChi, int row)
        {
            diaChi = Utils.RemoveExtraSpace(diaChi);
            if (diaChi.Length > 100)
                return "Địa chỉ không vượt quá 100 ký tự";
            return string.Empty;
        }
        private string ValidateNgaySinh(DateTime ngaySinh, int row)
        {
            if (DateTime.Now.Year - ngaySinh.Year < 18)
                return "Sinh viên phải đủ 18 tuổi";
            return string.Empty;
        }


        private void SinhVienGridView_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = ExceptionMode.NoAction;
        }


        private void SetLopEnabled(bool state)
        {
            KhoaGridControl.Enabled = InfoPanel.Enabled = state;
            this.TextMaLop.ForeColor = this.ComboMaKH.ForeColor =
                this.TextTenLop.ForeColor = state == true ? Utils.ActiveColor : Utils.DisabledColor;
        }

        private void SetSvState(bool state)
        {
            SinhVienGridControl.Enabled = state;
            SetIdleButtonEnabledSv(state);
        }

        private void SinhVienGridView_CustomDrawCell(object sender, RowCellCustomDrawEventArgs e)
        {
            if (CheckTheRow(e.RowHandle))
            {
                BaseEditViewInfo info = ((GridCellInfo)e.Cell).ViewInfo;
                string error = GetError(e.RowHandle, e.Column);
                SetError(info, error);
                info.CalcViewInfo(e.Cache.Graphics);
            }


            //----
            if (e.RowHandle == SinhVienGridView.FocusedRowHandle) return;
            if (_state == State.AddSv)
            {
                if (e.RowHandle == SinhVienGridView.RowCount - 1)
                    e.Appearance.BackColor = Color.FromArgb(255, 237, 211);
            }
            if (_state == State.EditSv)
            {
                if (e.RowHandle == _editingSvIndex)
                    e.Appearance.BackColor = Color.FromArgb(255, 237, 211);
            }


        }

        private void SinhVienGridView_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            if (SinhVienGridView.RowCount == 1 && _cancelEditSV == true)
            {
                _cancelEditSV = false;
                return;
            }
                bool test1 = _state == State.AddSv && (e.FocusedRowHandle == SinhVienGridView.RowCount - 1
                || e.FocusedRowHandle == -2147483647);
                bool test2 = _state == State.EditSv && e.FocusedRowHandle == _editingSvIndex;

                if (test1 || test2)
                    SinhVienGridView.OptionsBehavior.Editable = true;
                else
                    SinhVienGridView.OptionsBehavior.Editable = false;
            
        }
        private void buttonSuaSV_Click(object sender, EventArgs e)
        {
            ConfigEditingState_SV();
        }

        private void ConfigEditingState_SV()
        {
            string maSv = Utils.GetCellStringGridView(SinhVienGridView, colMASV, -1);
            _origMaSV = maSv;
            Utils.SetCellValueGridView(SinhVienGridView, colMASV, -1, maSv);//loại bỏ khoảng trắng thừa

            _editingSvIndex = SinhVienGridView.FocusedRowHandle;

            _state = State.EditSv;
            SetCorrButtonsState_SV();

            Utils.SetCustomizationEnabled(SinhVienGridView, false);
            SinhVienGridView.OptionsBehavior.Editable = true;

            SetLopEnabled(false);

        }

        private void SetCorrButtonsState_Lop()
        {
            if (Utils.IsCoSo())
            {
                switch (_state)
                {
                    case State.AddLop:
                        SetInputButtonVisible_Lop(true);
                        SetIdleButtonEnabled_Lop(false);
                        break;
                    case State.EditLop:
                        SetInputButtonVisible_Lop(true);
                        SetIdleButtonEnabled_Lop(false);
                        break;
                    case State.Idle:
                        SetInputButtonVisible_Lop(false);
                        SetIdleButtonEnabled_Lop(true);

                        break;
                }
            }
        }
        private void buttonXoaSV_Click(object sender, EventArgs e)
        {
            string removedSv = "";
            _selectedRowSV = SinhVienBindingSource.Position;
            if (BangDiemBindingSource.Count > 0)
            {
                Utils.ShowMessage("Sinh viên này đã dự thi, không thể xóa", Others.NotiForm.FormType.Error, 2);
                return;
            }

            if (Utils.ShowConfirmMessage("Bạn có chắc muốn xóa sinh viên này?", "Xác nhận"))
            {
                try
                {
                    removedSv = ((DataRowView)SinhVienBindingSource[_selectedRowSV])["MASV"].ToString();
                    SinhVienBindingSource.RemoveCurrent();
                    SinhVienTableAdapter.Update(TN_CSDLPTDataSet.SINHVIEN);
                    Utils.ShowMessage("Xóa thông tin sinh viên thành công!", Others.NotiForm.FormType.Success, 2);
                }
                catch (Exception ex)
                {
                    Utils.ShowErrorMessage("Không thể xóa sinh viên này, xin vui lòng thử lại sau\n" + ex.Message, "Lỗi xóa sinh viên");
                    Console.WriteLine(ex.StackTrace);
                    this.SinhVienTableAdapter.Fill(TN_CSDLPTDataSet.SINHVIEN);
                    SinhVienBindingSource.Position = SinhVienBindingSource.Find("MASV", removedSv);
                    return;
                }
            }

            SetCorrButtonsState_SV();
        }

        private void buttonLamMoiSV_Click(object sender, EventArgs e)
        {
            try
            {
                LoadAllData();
                Utils.ShowMessage("Làm mới thành công", Others.NotiForm.FormType.Success, 1);
                SetCorrButtonsState_SV();
            }
            catch (Exception ex)
            {
                Utils.ShowMessage("Lỗi khi tải lại dữ liệu", Others.NotiForm.FormType.Error, 1);
                Console.WriteLine(ex.StackTrace);
                return;
            }

        }

        public string GetError(int rowHandle, GridColumn column)
        {
            if (CheckTheRow(rowHandle))
            {
                GridView view = SinhVienGridView;
                String maSv = Utils.GetCellStringGridView(SinhVienGridView, colMASV, rowHandle);
                String ho = Utils.GetCellStringGridView(SinhVienGridView, colHO, rowHandle);
                String ten = Utils.GetCellStringGridView(SinhVienGridView, colTEN, rowHandle);
                String diaChi = Utils.GetCellStringGridView(SinhVienGridView, colDIACHI, rowHandle);
                DateTime ngaySinh;
                if (string.IsNullOrEmpty(Utils.GetCellStringGridView(SinhVienGridView, colNGAYSINH, rowHandle)))
                {
                    ngaySinh = DateTime.MinValue;
                }
                else
                {
                    ngaySinh = (DateTime)Utils.GetCellValueGridView(SinhVienGridView, colNGAYSINH, rowHandle);
                }

                if (column.Equals(view.Columns["MASV"]))
                    return ValidateMaSV(maSv);
                else if (column.Equals(view.Columns["HO"]))
                    return ValidateHoSV(ho, rowHandle);
                else if (column.Equals(view.Columns["TEN"]))
                    return ValidateTenSv(ten, rowHandle);
                else if (column.Equals(view.Columns["DIACHI"]))
                    return ValidateDiaChi(diaChi, rowHandle);
                else if (column.Equals(view.Columns["NGAYSINH"]))
                    return ValidateNgaySinh(ngaySinh, rowHandle);

            }
            return string.Empty;
        }

        void SetError(BaseEditViewInfo cellInfo, string errorIconText)
        {
            if (errorIconText == string.Empty) return;
            cellInfo.ErrorIconText = errorIconText;
            cellInfo.ShowErrorIcon = true;
            cellInfo.FillBackground = true;
            cellInfo.ErrorIcon = DXErrorProvider.GetErrorIconInternal(ErrorType.Critical);
        }


        private void SinhVienBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            SetCorrButtonsState_SV();
        }

        private void SinhVienGridView_ShownEditor(object sender, EventArgs e)
        {
            string error = GetError(SinhVienGridView.FocusedRowHandle, SinhVienGridView.FocusedColumn);
            if (error == string.Empty)
            {
                SinhVienGridView.ClearColumnErrors();
                return;
            }
            //   BaseEdit.DefaultErrorIcon = DXErrorProvider.GetErrorIconInternal(ErrorType.Information);
            SinhVienGridView.SetColumnError(SinhVienGridView.FocusedColumn, error);

        }

        private int GetEditingIndexSv()
        {
            if (_state == State.EditSv)
                return _editingSvIndex;
            else if (_state == State.AddSv)
                return SinhVienGridView.RowCount - 1;
            return -1;
        }
        private void buttonXacNhanSV_Click(object sender, EventArgs e)
        {
            bool test1 = (GetError(GetEditingIndexSv(), colMASV) == string.Empty);
            bool test2 = (GetError(GetEditingIndexSv(), colHO) == string.Empty);
            bool test3 = (GetError(GetEditingIndexSv(), colTEN) == string.Empty);
            bool test4 = (GetError(GetEditingIndexSv(), colDIACHI) == string.Empty);
            bool test5 = (GetError(GetEditingIndexSv(), colNGAYSINH) == string.Empty);
            SinhVienGridView.ClearColumnErrors(); // lệnh này chỉ clear các cột bị lỗi trong show_editor (và chỉ có 1 cột bị chịu tác động của show_editor tại 1 thời điểm)
            if (test1 && test2 & test3 && test4 && test5)
            {
                try
                {
                    int editingIndex = GetEditingIndexSv();
                    string ho = Utils.CapitalizeString(Utils.GetCellStringGridView(SinhVienGridView, colHO, editingIndex), Utils.CapitalMode.EveryWord);
                    Utils.SetCellValueGridView(SinhVienGridView, colHO, editingIndex, ho);

                    string ten = Utils.CapitalizeString(Utils.GetCellStringGridView(SinhVienGridView, colTEN, editingIndex).ToString(), Utils.CapitalMode.EveryWord);
                    Utils.SetCellValueGridView(SinhVienGridView, colTEN, editingIndex, ten);

                    SinhVienBindingSource.EndEdit();
                    SinhVienBindingSource.ResetCurrentItem();
                    this.SinhVienTableAdapter.Update(this.TN_CSDLPTDataSet.SINHVIEN);
                    if (_state == State.EditSv)
                        Utils.ShowMessage("Sửa thông tin sinh viên thành công", Others.NotiForm.FormType.Success, 2);
                    else if (_state == State.AddSv)
                        Utils.ShowMessage("Thêm thông tin sinh viên thành công", Others.NotiForm.FormType.Success, 2);

                }
                catch (Exception ex)
                {
                    Utils.ShowErrorMessage("Không thể lưu thông tin sinh viên, xin vui lòng thử lại sau\n" + ex.Message, "Lỗi ghi sinh viên");
                    Debug.Assert(false);
                    return;
                }
                finally
                {
                    ConfigIdleState_SV();
                }
            }
            else
            {
                Utils.ShowMessage("Vui lòng xem lại thông tin đã nhập", Others.NotiForm.FormType.Error, 2);
            }
        }

        private void buttonHuySV_Click(object sender, EventArgs e)
        {
            _cancelEditSV = true;
            SinhVienBindingSource.CancelEdit();
            ConfigIdleState_SV();
        }

        private void ConfigIdleState_SV()
        {
            if (_state == State.AddSv)
                SinhVienBindingSource.Position = _selectedRowSV;

            _state = State.Idle;
            SetCorrButtonsState_SV();
            _origMaSV = string.Empty; ;
            SinhVienGridView.ClearColumnErrors();

            Utils.SetCustomizationEnabled(SinhVienGridView, true);
            SinhVienGridView.OptionsBehavior.Editable = false;

            SetLopEnabled(true);
        }
        private void FormSVL_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_state != State.Idle)
                if (!Utils.ShowConfirmMessage("Hủy những thay đổi đang thực hiện và đóng cửa sổ này?", "Xác nhận"))
                    e.Cancel = true;
        }

        private void SinhVienGridView_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            if (_state == State.AddSv || _state == State.EditSv)
                e.Allow = false;
        }

        private void KhoaGridView_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            GetCorrTextBoxData(false);
        }
        private Color GetCorrColor()
        {
            switch (_state)
            {
                case State.AddLop:
                    return Utils.AddColor;
                case State.EditLop:
                    return Utils.EditColor;
                default:
                    return Utils.DisabledColor;
            }
        }
        private void Editor_GotFocus(object sender, EventArgs e)
        {
            (sender as BaseEdit).Properties.Appearance.BorderColor = GetCorrColor();
            (sender as BaseEdit).Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
        }
        private void Editor_LostFocus(object sender, EventArgs e)
        {

            (sender as BaseEdit).Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
        }
    }
}