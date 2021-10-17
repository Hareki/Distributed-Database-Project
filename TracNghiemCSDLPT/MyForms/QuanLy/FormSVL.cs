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

        private void PhanQuyen()
        {
            switch (DBConnection.NhomQuyen)
            {
                case "TRUONG":
                    SetIdleButtonEnabledSv(false);
                    SetIdleButtonEnabledLop(false);
                    break;
                case "COSO":
                    CoSoComboBox.Enabled = false;
                    break;
            }

        }

        private int _previousIndexCS;
        private bool _opened = false;
        private int _selectedRowLop;
        private int _selectedRowSV;
        private int _saveKhIndex;

        private string _origMaLop = "~!@#$%";
        private string _origTenLop = "~!@#$%";

        private string _origMaSV = "~!@#$%";
        private int _editingSvIndex;

        private bool _canSaveSv = true;
        private string _saveMaKhForReset;
        private string _saveMaLopForReset;


        Color _activeForeColor = Color.FromArgb(72, 70, 68);
        Color _disabledForeColor = SystemColors.AppWorkspace;
        State _state = State.Idle;
        enum State
        {
            AddLop, EditLop, Idle, AddSv, EditSv
        }

        private void SetDefaultOrigValueLop()
        {
            _origTenLop = "~!@#$%";
            _origMaLop = "~!@#$%";
        }
        private void SetDefaultOrigValueSV()
        {
            _origMaSV = "~!@#$%";
        }

        private void LoadAllData()
        {
            this.KhoaTableAdapter.Connection.ConnectionString = DBConnection.SubcriberConnectionString;
            this.LopTableAdapter.Connection.ConnectionString = DBConnection.SubcriberConnectionString;
            this.SinhVienTableAdapter.Connection.ConnectionString = DBConnection.SubcriberConnectionString;
            this.GV_DKTableAdapter.Connection.ConnectionString = DBConnection.SubcriberConnectionString;
            this.BangDiemTableAdapter.Connection.ConnectionString = DBConnection.SubcriberConnectionString;
            this.Khoa2TableAdapter.Connection.ConnectionString = DBConnection.SubcriberConnectionString;

            this.KhoaTableAdapter.Fill(this.TN_CSDLPTDataSet.KHOA);
            this.LopTableAdapter.Fill(this.TN_CSDLPTDataSet.LOP);
            this.SinhVienTableAdapter.Fill(this.TN_CSDLPTDataSet.SINHVIEN);
            this.GV_DKTableAdapter.Fill(this.TN_CSDLPTDataSet.GIAOVIEN_DANGKY);
            this.BangDiemTableAdapter.Fill(this.TN_CSDLPTDataSet.BANGDIEM);
            this.Khoa2TableAdapter.Fill(this.TN_CSDLPTDataSet.KHOA2);

            CheckButtonStateLop();
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

        private void CheckButtonStateLop()
        {
            if (DBConnection.NhomQuyen.Equals("COSO"))
            {
                if (LopBindingSource.Count == 0)
                    buttonXoaLop.Enabled = buttonSuaLop.Enabled = false;
                else buttonXoaLop.Enabled = buttonSuaLop.Enabled = true;
            }

        }

        private void CheckButtonStateSV()
        {
            if (DBConnection.NhomQuyen.Equals("COSO"))
            {
                if (SinhVienBindingSource.Count == 0)
                    buttonXoaSV.Enabled = buttonSuaSV.Enabled = false;
                else if (_state != State.AddSv && _state != State.EditSv)
                    buttonXoaSV.Enabled = buttonSuaSV.Enabled = true;
            }

        }

        private GridView GetCorrTextBoxData(bool getFirstRow)
        {
            GridView detailView;
            if (getFirstRow)
                detailView = KhoaGridView.GetDetailView(0, 0) as GridView;
            else
            {
                int row = KhoaGridView.GetSelectedRows()[0];
                detailView = KhoaGridView.GetDetailView(row, 0) as GridView;
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
            Khoa2BindingSource.Position = Khoa2BindingSource.Find("MAKH", maKh);
            return detailView;

        }
        private void FormSVL_Load(object sender, EventArgs e)
        {


            this.TN_CSDLPTDataSet.EnforceConstraints = false;

            LoadAllData();

            this.CoSoComboBox.DataSource = DBConnection.BsSubcribers;
            this.CoSoComboBox.DisplayMember = "TENCS";
            this.CoSoComboBox.ValueMember = "TENSERVER";
            this.CoSoComboBox.SelectedIndex = DBConnection.IndexCS;
            this._previousIndexCS= this.CoSoComboBox.SelectedIndex;

            //  this.ComboMaKH.DataSource = KhoaBindingSource;
            this.ComboMaKH.DisplayMember = "TENKH";
            this.ComboMaKH.ValueMember = "MAKH";

            KhoaGridView.ExpandMasterRow(0); // dùng để trigger LopGridView FocusedRochanged
            GridView view = GetCorrTextBoxData(true);
            if (view != null)
                view.Focus();
            CheckButtonStateSV();
            PhanQuyen();

        }

        private void LopGridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (!_opened)
            {
                for (int i = 1; i < KhoaGridView.RowCount; i++)
                    KhoaGridView.ExpandMasterRow(i);
                _opened = true;
            }
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
                this._previousIndexCS= this.CoSoComboBox.SelectedIndex;
            }
        }

        private void SetIdleButtonEnabledLop(bool state)
        {
            buttonThemLop.Enabled = buttonSuaLop.Enabled = buttonUndoLop.Enabled = buttonRedoLop.Enabled =
                buttonXoaLop.Enabled = state;
            if (Utils.IsTruong()) buttonLamMoiLop.Enabled = true;
            else buttonLamMoiLop.Enabled = state;


            if (state == false)
            {
                buttonUndoLop.BackColor = buttonRedoLop.BackColor = Color.FromArgb(247, 247, 247);
            }
            else
            {
                buttonUndoLop.BackColor = buttonRedoLop.BackColor = Color.FromArgb(240, 240, 240);
            }
        }
        private void SetInputButtonEnabledLop(bool state)
        {
            buttonHuyLop.Visible = buttonXacNhanLop.Visible = state;
        }

        private void SetIdleButtonEnabledSv(bool state)
        {
            buttonThemSV.Enabled = buttonSuaSV.Enabled = buttonUndoSV.Enabled = buttonRedoSV.Enabled =
                buttonXoaSV.Enabled = state;
            if (Utils.IsTruong()) buttonLamMoiSV.Enabled = true;
            else buttonLamMoiSV.Enabled = state;

            if (state == false)
            {
                buttonUndoSV.BackColor = buttonRedoSV.BackColor = Color.FromArgb(247, 247, 247);
            }
            else
            {
                buttonUndoSV.BackColor = buttonRedoSV.BackColor = Color.FromArgb(240, 240, 240);
            }
        }
        private void SetInputButtonEnabledSV(bool state)
        {
            buttonHuySV.Visible = buttonXacNhanSV.Visible = state;
        }

        private void buttonThemLop_Click(object sender, EventArgs e)
        {
            _selectedRowLop = LopBindingSource.Position;
            //  InfoPanel.Enabled = true;
            ComboMaKH.Enabled = TextTenLop.Enabled = TextMaLop.Enabled = true;
            InfoPanel.ForeColor = TextMaLop.ForeColor =
                TextTenLop.ForeColor = ComboMaKH.ForeColor = _activeForeColor;

            InfoPanel.Text = "Thêm mới thông tin lớp";

            SetIdleButtonEnabledLop(false);
            SetInputButtonEnabledLop(true);

            _saveKhIndex = ComboMaKH.SelectedIndex;
            KhoaGridControl.Enabled = false;
            // KhoaBindingSource.SuspendBinding();
            ComboMaKH.SelectedIndex = 0;
            SetSvState(false);
            _state = State.AddLop;
            LopBindingSource.AddNew();
        }

        private void buttonHuyLop_Click(object sender, EventArgs e)
        {
            //   InfoPanel.Enabled = false;
            ComboMaKH.Enabled = TextTenLop.Enabled = TextMaLop.Enabled = false;
            InfoPanel.ForeColor = TextMaLop.ForeColor =
                TextTenLop.ForeColor = ComboMaKH.ForeColor = _disabledForeColor;

            KhoaGridControl.Enabled = true;
            // KhoaBindingSource.ResumeBinding();
            ComboMaKH.SelectedIndex = _saveKhIndex;
            SetDefaultOrigValueLop();
            LopBindingSource.CancelEdit();
            InfoPanel.Text = "Thông tin lớp";
            if (_state == State.AddLop)
                LopBindingSource.Position = _selectedRowLop;

            SetIdleButtonEnabledLop(true);
            SetInputButtonEnabledLop(false);
            SetSvState(true);
            Utils.SetTextEditError(MaLopEP, TextMaLop, null);
            Utils.SetTextEditError(TenLopEP, TextTenLop, null);
            _state = State.Idle;
        }

        private void buttonLamMoiLop_Click(object sender, EventArgs e)
        {
            try
            {
                //this.KhoaTableAdapter.Connection.ConnectionString = DBConnection.SubcriberConnectionString;
                //this.KhoaTableAdapter.Fill(this.TN_CSDLPTDataSet.KHOA);
                //this.LopTableAdapter.Connection.ConnectionString = DBConnection.SubcriberConnectionString;
                //this.LopTableAdapter.Fill(this.TN_CSDLPTDataSet.LOP);
                LoadAllData();
                Utils.ShowMessage("Làm mới thành công", Others.NotiForm.FormType.Success, 1);

                CheckButtonStateLop();
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
            //InfoPanel.Enabled = true;InfoPanel.Enabled = true;
            ComboMaKH.Enabled = TextTenLop.Enabled = TextMaLop.Enabled = true;
            InfoPanel.ForeColor = TextMaLop.ForeColor =
                TextTenLop.ForeColor = ComboMaKH.ForeColor = _activeForeColor;

            TextMaLop.Text = TextMaLop.Text.Trim();

            InfoPanel.Text = "Sửa thông tin lớp";

            SetIdleButtonEnabledLop(false);
            SetInputButtonEnabledLop(true);
            SetSvState(false);

            _origMaLop = TextMaLop.Text.Trim();
            _origTenLop = Utils.CapitalizeString(TextTenLop.Text, Utils.CapitalMode.FirstWordOnly);
            KhoaGridControl.Enabled = false;
            _state = State.EditLop;
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

        private bool AlreadyExistsSv(string testName)
        {
            List<Para> paraList = new List<Para>();
            paraList.Add(new Para("@ID", testName));

            string spName = "usp_SinhVien_GetInfoByID";
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
        private void GoToNewlyCreatedRowLop()
        {
            GridView detailView;
            int row = KhoaGridView.LocateByDisplayText(0, colMAKH, ComboMaKH.SelectedValue.ToString());
            //Console.WriteLine("Row: " + row);

            KhoaGridView.FocusedRowHandle = row;
            KhoaGridView.Focus();
            KhoaGridView.ExpandMasterRow(row);
            detailView = KhoaGridView.GetDetailView(row, 0) as GridView;
            if (detailView is null)
            {
                Utils.ShowErrorMessage("Lỗi không xác định", "Lỗi");
                Console.WriteLine(System.Environment.StackTrace);
                return;
            }
            detailView.Focus();
            detailView.FocusedRowHandle = detailView.RowCount - 1;
            detailView.MakeRowVisible(detailView.RowCount - 1);
        }

        private void GobackAfterReset()
        {//lỗi dòng cuối, chưa chạy dc
            GridView detailView;
            int row = KhoaGridView.LocateByDisplayText(0, colMAKH, _saveMaKhForReset);
            //   Console.WriteLine("Row: " + row);

            KhoaGridView.FocusedRowHandle = row;
            KhoaGridView.Focus();
            KhoaGridView.ExpandMasterRow(row);
            detailView = KhoaGridView.GetDetailView(row, 0) as GridView;
            if (detailView is null)
            {
                Utils.ShowErrorMessage("Lỗi không xác định", "Lỗi");
                Console.WriteLine(System.Environment.StackTrace);
                return;
            }
            detailView.Focus();

            //  detailView.FocusedRowHandle = LopBindingSource.Find("MALOP", TextMaLop.Text);
            detailView.FocusedRowHandle = lOPBindingSource1.Find("MALOP", _saveMaLopForReset);

        }
        private void ButtonXacNhanLop_Click(object sender, EventArgs e)
        {
            TextMaLop.Text = TextMaLop.Text.Trim();
            TextTenLop.Text = Utils.CapitalizeString
                (TextTenLop.Text, Utils.CapitalMode.FirstWordOnly);
            bool test1 = string.IsNullOrEmpty(TextTenLop.Text);
            bool test2 = string.IsNullOrEmpty(TextMaLop.Text);

            if (test1 || test2)
            {
                if (test1)
                    Utils.SetTextEditError(MaLopEP, TextMaLop, "Vui lòng nhập mã lớp");
                else
                    Utils.SetTextEditError(MaLopEP, TextMaLop, null);
                if (test2)
                    Utils.SetTextEditError(TenLopEP, TextTenLop, "Vui lòng nhập tên lớp");
                else
                    Utils.SetTextEditError(TenLopEP, TextTenLop, null);

                Utils.ShowMessage("Vui lòng điền đầy đủ thông tin cần thiết", Others.NotiForm.FormType.Error, 2);
                return;
            }
            if (TextMaLop.Text.Length > 8)
            {
                Utils.ShowMessage("Mã lớp không được quá 8 ký tự", Others.NotiForm.FormType.Warning, 2);
                Utils.SetTextEditError(MaLopEP, TextMaLop, "Mã lớp không được quá 8 ký tự");
                return;
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
            try
            {
                //    saveKHIndex = ComboMaKH.SelectedIndex; //giữ lại index trước khi bị reset, rồi gán lại cho combo
                //  KhoaBindingSource.ResumeBinding();
                //     ComboMaKH.SelectedIndex = saveKHIndex;
                // TextMaKH.Text = ComboMaKH.SelectedValue.ToString();//truyền giá trị vào để đủ dữ liệu trước khi end edit
                ((DataRowView)LopBindingSource[LopBindingSource.Position])["MAKH"] = ComboMaKH.SelectedValue.ToString();
                LopBindingSource.EndEdit();
                LopBindingSource.ResetCurrentItem();
                this.LopTableAdapter.Update(this.TN_CSDLPTDataSet.LOP);

                if (_state == State.EditLop)
                    Utils.ShowMessage("Sửa lớp thành công", Others.NotiForm.FormType.Success, 1);
                else if (_state == State.AddLop)
                {
                    GoToNewlyCreatedRowLop();
                    Utils.ShowMessage("Thêm lớp thành công", Others.NotiForm.FormType.Success, 1);
                }


                _state = State.Idle;

                InfoPanel.Text = "Thông tin lớp";
                Utils.SetTextEditError(MaLopEP, TextMaLop, null);
                Utils.SetTextEditError(TenLopEP, TextTenLop, null);
                SetSvState(true);
                CheckButtonStateLop();
                SetDefaultOrigValueLop();

            }
            catch (Exception ex)
            {
                Utils.ShowErrorMessage("Không thể lưu lớp, xin vui lòng thử lại sau\n" + ex.Message, "Lỗi ghi lớp");
                return;
            }
            KhoaGridControl.Enabled = true;


            TextMaLop.Enabled = TextTenLop.Enabled = ComboMaKH.Enabled = false;
            InfoPanel.ForeColor = TextTenLop.ForeColor = TextMaLop.ForeColor = ComboMaKH.ForeColor
                        = _disabledForeColor;
            SetIdleButtonEnabledLop(true);
            SetInputButtonEnabledLop(false);

        }

        private void buttonXoaLop_Click(object sender, EventArgs e)
        {
            string removedLop = "";
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
            CheckButtonStateLop();
        }

        private void buttonThemSV_Click(object sender, EventArgs e)
        {
            _selectedRowSV = SinhVienBindingSource.Position;

            SetLopState(false);

            SetIdleButtonEnabledSv(false);
            SetInputButtonEnabledSV(true);
            _state = State.AddSv;
            SinhVienGridView.OptionsBehavior.Editable = true;
            SinhVienBindingSource.AddNew();

        }

        private string GetCellAtRowSV(GridColumn column, int row)
        {
            return SinhVienGridView.GetRowCellValue(row, column).ToString();
        }
        private string GetCellAtFRowSV(GridColumn column)
        {
            return SinhVienGridView.GetRowCellValue(SinhVienGridView.FocusedRowHandle, column).ToString();
        }
        private void SetCellAtRowSV(GridColumn column, string value, int row)
        {
            SinhVienGridView.SetRowCellValue(row, column, value);
        }

        private void SinhVienGridView_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {

            //String maSV = getCellAtFRowSV(colMASV);
            //String ho = getCellAtFRowSV(colHO);
            //String ten = getCellAtFRowSV(colTEN);
            //bool maError = false, hoError = false, tenError = false;
            //ho = Utils.CapitalizeString(ho, Utils.CapitalMode.EveryWord);
            //ten = Utils.CapitalizeString(ten, Utils.CapitalMode.EveryWord);
            //if (string.IsNullOrEmpty(maSV))
            //{
            //    SinhVienGridView.SetColumnError(colMASV, "Vui lòng nhập mã sinh viên");
            //    e.Valid = canSaveSV = false;
            //    maError = true;

            //}
            //if (maSV.Length > 8)
            //{
            //    SinhVienGridView.SetColumnError(colMASV, "Mã sinh viên không vượt quá 8 ký tự");
            //    e.Valid = canSaveSV = false;
            //    maError = true;

            //}


            //bool test1 = false;
            //if (!origMaSV.ToLower().Trim().Equals(maSV.Trim()))
            //    test1 = AlreadyExistsSV(maSV);

            //if (test1)
            //{
            //    SinhVienGridView.SetColumnError(colMASV, "Mã sinh viên đã tồn tại");
            //    e.Valid = false;
            //    maError = true;
            //}
            //if (!maError)
            //    SinhVienGridView.SetColumnError(colMASV, null);


            //if (string.IsNullOrEmpty(ho))
            //{
            //    SinhVienGridView.SetColumnError(colHO, "Vui lòng nhập họ và tên đệm sinh viên");
            //    e.Valid = false;
            //    hoError = true;
            //}
            //if (!Utils.IsMathRegex(ho, Utils.RegexType.LetterOnly))
            //{
            //    SinhVienGridView.SetColumnError(colHO, "Họ, tên đệm của SV chỉ được chứa chữ");
            //    e.Valid = false;
            //    hoError = true;
            //}

            //if (!hoError)
            //    SinhVienGridView.SetColumnError(colHO, null);


            //if (string.IsNullOrEmpty(ten))
            //{

            //    SinhVienGridView.SetColumnError(colTEN, "Vui lòng nhập tên sinh viên");
            //    e.Valid = false;
            //    tenError = true;
            //}
            //if (!Utils.IsMathRegex(ten, Utils.RegexType.LetterOnly))
            //{
            //    SinhVienGridView.SetColumnError(colTEN, "Tên của SV chỉ được chứa chữ");
            //    e.Valid = false;
            //    tenError = true;
            //}
            //if (!tenError)
            //    SinhVienGridView.SetColumnError(colTEN, null);


            //canSaveSV = e.Valid;

        }

        private string ValidateMaSV(string maSv)
        {
            if (string.IsNullOrEmpty(maSv))
                return "Vui lòng nhập mã sinh viên";
            if (maSv.Length > 8)
                return "Mã sinh viên không vượt quá 8 ký tự";

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
            return string.Empty;
        }


        private void SinhVienGridView_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = ExceptionMode.NoAction;
        }


        private void SetLopState(bool state)
        {
            KhoaGridControl.Enabled = InfoPanel.Enabled = state;
            this.TextMaLop.ForeColor = this.ComboMaKH.ForeColor =
                this.TextTenLop.ForeColor = state == true ? _activeForeColor : _disabledForeColor;
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
            SetLopState(false);
            SetIdleButtonEnabledSv(false);
            SetInputButtonEnabledSV(true);


            string maSv = GetCellAtFRowSV(colMASV).Trim();
            SinhVienGridView.SetRowCellValue(SinhVienGridView.FocusedRowHandle, colMASV, maSv);

            _editingSvIndex = SinhVienGridView.FocusedRowHandle;
            SinhVienGridView.OptionsBehavior.Editable = true;
            _origMaSV = GetCellAtFRowSV(colMASV).Trim();
            _state = State.EditSv;
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

            CheckButtonStateSV();
        }

        private void buttonLamMoiSV_Click(object sender, EventArgs e)
        {
            try
            {
                _saveMaKhForReset = ComboMaKH.SelectedValue.ToString();
                _saveMaLopForReset = TextMaLop.Text;
                LoadAllData();
                Utils.ShowMessage("Làm mới thành công", Others.NotiForm.FormType.Success, 1);
                //  GobackAfterReset();
                CheckButtonStateLop();
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
                String maSv = GetCellAtRowSV(colMASV, rowHandle);
                String ho = GetCellAtRowSV(colHO, rowHandle);
                String ten = GetCellAtRowSV(colTEN, rowHandle);
                if (column.Equals(view.Columns["MASV"]))
                    return ValidateMaSV(maSv);
                else if (column.Equals(view.Columns["HO"]))
                    return ValidateHoSV(ho, rowHandle);
                else if (column.Equals(view.Columns["TEN"]))
                    return ValidateTenSv(ten, rowHandle);
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
            CheckButtonStateSV();
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
            SinhVienGridView.ClearColumnErrors(); // lệnh này chỉ clear các cột bị lỗi trong show_editor (và chỉ có 1 cột bị chịu tác động của show_editor tại 1 thời điểm)
            if (test1 && test2 & test3)
            {
                try
                {
                    int editingIndex = GetEditingIndexSv();
                    string ho = Utils.CapitalizeString(GetCellAtRowSV(colHO, editingIndex), Utils.CapitalMode.EveryWord);
                    SetCellAtRowSV(colHO, ho, editingIndex);

                    string ten = Utils.CapitalizeString(GetCellAtRowSV(colTEN, editingIndex), Utils.CapitalMode.EveryWord);
                    SetCellAtRowSV(colTEN, ten, editingIndex);

                    SinhVienBindingSource.EndEdit();
                    SinhVienBindingSource.ResetCurrentItem();
                    this.SinhVienTableAdapter.Update(this.TN_CSDLPTDataSet.SINHVIEN);
                    if (_state == State.EditSv)
                        Utils.ShowMessage("Sửa thông tin sinh viên thành công", Others.NotiForm.FormType.Success, 2);
                    else if (_state == State.AddSv)
                        Utils.ShowMessage("Thêm thông tin sinh viên thành công", Others.NotiForm.FormType.Success, 2);
                    _state = State.Idle;
                    SinhVienGridView.ClearColumnErrors();
                    CheckButtonStateSV();
                    SetDefaultOrigValueSV();

                }
                catch (Exception ex)
                {
                    Utils.ShowErrorMessage("Không thể lưu thông tin sinh viên, xin vui lòng thử lại sau\n" + ex.Message, "Lỗi ghi sinh viên");
                    return;
                }
                SetLopState(true);
                SetIdleButtonEnabledSv(true);
                SetInputButtonEnabledSV(false);
            }
            else
            {
                Utils.ShowMessage("Vui lòng xem lại thông tin đã nhập", Others.NotiForm.FormType.Error, 2);
            }
        }

        private void buttonHuySV_Click(object sender, EventArgs e)
        {
            SinhVienGridView.OptionsBehavior.Editable = false;
            SinhVienBindingSource.CancelEdit();
            if (_state == State.AddSv)
                SinhVienBindingSource.Position = _selectedRowSV;
            _state = State.Idle;
            SetDefaultOrigValueSV();
            SetIdleButtonEnabledSv(true);
            SetInputButtonEnabledSV(false);
            SetLopState(true);
        }

        private void FormSVL_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_state != State.Idle)
                if (!Utils.ShowConfirmMessage("Hủy những thay đổi đang thực hiện và đóng cửa sổ này?", "Xác nhận"))
                    e.Cancel = true;
        }
    }
}