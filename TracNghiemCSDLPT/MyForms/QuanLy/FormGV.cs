using DevExpress.XtraEditors.DXErrorProvider;
using DevExpress.XtraEditors.ViewInfo;
using DevExpress.XtraGrid.Columns;
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
    public partial class FormGv : DevExpress.XtraEditors.XtraForm
    {
        public FormGv()
        {
            InitializeComponent();
        }
        State _state = State.Idle;
        enum State
        {
            Add, Edit, Idle
        }
        private int _selectedRowGv;
        private int _previousIndexCS;
        private string _origMaGv = string.Empty;
        private int _editingGvIndex;


        private void LoadAllData()
        {
            this.TN_CSDLPTDataSet.EnforceConstraints = false;
            this.KhoaTableAdapter.Connection.ConnectionString = DBConnection.SubcriberConnectionString;
            this.GVTableAdapter.Connection.ConnectionString = DBConnection.SubcriberConnectionString;
            this.GVDKTableAdapter.Connection.ConnectionString = DBConnection.SubcriberConnectionString;
            this.BoDeTableAdapter.Connection.ConnectionString = DBConnection.SubcriberConnectionString;

            this.KhoaTableAdapter.Fill(this.TN_CSDLPTDataSet.KHOA);
            this.GVTableAdapter.Fill(this.TN_CSDLPTDataSet.GIAOVIEN);
            this.GVDKTableAdapter.Fill(this.TN_CSDLPTDataSet.GIAOVIEN_DANGKY);
            this.BoDeTableAdapter.Fill(this.TN_CSDLPTDataSet.BODE);

        }


        private void PhanQuyen()
        {
            switch (DBConnection.NhomQuyen)
            {
                case "TRUONG":
                    SetIdleButtonEnabled(false);
                    buttonLamMoi.Enabled = true;
                    break;
                case "COSO":
                    CoSoComboBox.Enabled = false;
                    break;
            }

        }

        private void CheckButtonStateGv()
        {
            if (Utils.IsCoSo())
            {
                if (KhoaBindingSource.Count == 0)
                    buttonXoa.Enabled = buttonSua.Enabled = false;
                else if (_state != State.Add && _state != State.Edit)
                    buttonXoa.Enabled = buttonSua.Enabled = true;
            }

        }
        private void FormGV_Load(object sender, EventArgs e)
        {
            LoadAllData();
            this.TN_CSDLPTDataSet.EnforceConstraints = false;
            Utils.BindingComboData(CoSoComboBox, _previousIndexCS);
            CheckButtonStateGv();
            PhanQuyen();
        }

        private void SetIdleButtonEnabled(bool state)
        {
            if (GVBindingSource.Count == 0 && state == true)
            {
                buttonXoa.Enabled = buttonSua.Enabled = false;
                buttonThem.Enabled = buttonLamMoi.Enabled = true;
            }
            else
            {
                buttonThem.Enabled = buttonSua.Enabled =
              buttonXoa.Enabled = state;
            }

        }

        private void SetInputButtonVisible(bool state)
        {
            buttonHuy.Visible = buttonXacNhan.Visible = state;
        }
        private void SetKhoaGridControlEnabled(bool state)
        {
            KhoaGridControl.Enabled = state;
            Image img = state == true ? global::TracNghiemCSDLPT.Properties.Resources.asd
                : global::TracNghiemCSDLPT.Properties.Resources.disableasd;
            this.pictureBox1.Image = img;
        }

        private void SetCorrButtonsState()
        {
            if (Utils.IsCoSo())
            {
                switch (_state)
                {
                    case State.Add:
                        SetInputButtonVisible(true);
                        SetIdleButtonEnabled(false);
                        break;
                    case State.Edit:
                        SetInputButtonVisible(true);
                        SetIdleButtonEnabled(false);
                        break;
                    case State.Idle:
                        SetInputButtonVisible(false);
                        SetIdleButtonEnabled(true);
                        break;
                }
            }
        }
        private void ConfigAddingState()
        {
            _selectedRowGv = GVBindingSource.Position;

            _state = State.Add;
            SetCorrButtonsState();

            //kết hợp set enabled và reset Customization để hàng chỉnh sửa (hoặc thêm) không bị dịch dời
            Utils.SetCustomizationEnabled(GVGridView, false);
            GVGridView.OptionsBehavior.Editable = true;

            //phải để add new ở cuối => RowHandle trong custom drawcell sẽ ko update kịp (= min int) thì khi vừa bấm nút thêm sẽ ko bị báo lỗi thiếu dữ liệu (do lúc đầu code logic đã thế)
            GVBindingSource.AddNew();
        }


        private void ButtonThem_Click(object sender, EventArgs e)
        {
            ConfigAddingState();
            GVGridView.ClearColumnErrors();
        }

        private void ButtonHuy_Click(object sender, EventArgs e)
        {
            GVBindingSource.CancelEdit();
            ConfigIdleState();
        }

        private void ConfigIdleState()
        {
            if (_state == State.Add)
                GVBindingSource.Position = _selectedRowGv;

            _state = State.Idle;
            SetCorrButtonsState();
            GVGridView.ClearColumnErrors();
            _origMaGv = string.Empty;


            Utils.SetCustomizationEnabled(GVGridView, true);
            GVGridView.OptionsBehavior.Editable = false;

            SetKhoaGridControlEnabled(true);
        }

        private void CoSoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CoSoComboBox.SelectedValue.ToString().Trim() == "System.Data.DataRowView")
                return;
            string login, pass;
            string serverName = CoSoComboBox.SelectedValue.ToString().Trim();
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




        private void ButtonXacNhan_Click(object sender, EventArgs e)
        {
            bool test1 = (GetError(GetEditingIndexGv(), colMAGV) == string.Empty);
            bool test2 = (GetError(GetEditingIndexGv(), colHO) == string.Empty);
            bool test3 = (GetError(GetEditingIndexGv(), colTEN) == string.Empty);
            bool test4 = (GetError(GetEditingIndexGv(), colDIACHI) == string.Empty);
            GVGridView.ClearColumnErrors(); // lệnh này chỉ clear các cột bị lỗi trong show_editor (và chỉ có 1 cột bị chịu tác động của show_editor tại 1 thời điểm)
            if (test1 && test2 & test3 && test4)
            {
                try
                {
                    int editingIndex = GetEditingIndexGv();
                    string ho = Utils.CapitalizeString(Utils.GetCellStringGridView(GVGridView, colHO, editingIndex), Utils.CapitalMode.EveryWord);
                    Utils.SetCellValueGridView(GVGridView, colHO, editingIndex, ho);

                    string ten = Utils.GetCellStringGridView(GVGridView, colTEN, editingIndex);
                    ten = Utils.CapitalizeString(ten, Utils.CapitalMode.EveryWord);
                    Utils.SetCellValueGridView(GVGridView, colTEN, editingIndex, ten);

                    string maGv = Utils.GetCellStringGridView(GVGridView, colMAGV, -1);
                    if (!maGv.Equals(_origMaGv) && _state == State.Edit)
                    {
                        if (!RenameUser(_origMaGv, maGv))
                        {
                            Utils.ShowErrorMessage("Xảy ra lỗi khi đổi username, chặn quá trình cập nhật", "Lỗi");
                            return;
                        }
                    }

                    GVBindingSource.EndEdit();
                    GVBindingSource.ResetCurrentItem();
                    this.GVTableAdapter.Update(this.TN_CSDLPTDataSet.GIAOVIEN);
                    if (_state == State.Edit)
                        Utils.ShowMessage("Sửa thông tin giảng viên thành công", Others.NotiForm.FormType.Success, 2);
                    else if (_state == State.Add)
                        Utils.ShowMessage("Thêm thông tin giảng viên thành công", Others.NotiForm.FormType.Success, 2);


                }
                catch (Exception ex)
                {
                    Utils.ShowErrorMessage("Không thể lưu thông tin giảng viên, xin vui lòng thử lại sau\n" + ex.Message, "Lỗi ghi nhân viên");
                    return;
                }
                finally
                {
                    ConfigIdleState();
                }

            }
            else
            {
                Utils.ShowMessage("Vui lòng xem lại thông tin đã nhập", Others.NotiForm.FormType.Error, 2);
            }
        }
        private bool CheckTheRow(int rowHandle)
        {
            //lúc add new() row handle chưa có dữ liệu (= -2147483647), khi select qua row khác rồi select lại thì mới nhận
            bool test1 = _state == State.Idle;
            bool test2A = rowHandle == GVGridView.RowCount - 1;
            // bool test2b = rowHandle == -2147483647;
            bool test3 = rowHandle == _editingGvIndex;
            if (test1) return false;
            if (((test2A) && _state == State.Add) || (test3 && _state == State.Edit))
            {
                return true;
            }
            return false;
        }
        public string GetError(int rowHandle, GridColumn column)
        {
            if (CheckTheRow(rowHandle))
            {
                GridView view = GVGridView;
                String maGV = Utils.GetCellStringGridView(GVGridView, colMAGV, rowHandle);
                String ho = Utils.GetCellStringGridView(GVGridView, colHO, rowHandle);
                String ten = Utils.GetCellStringGridView(GVGridView, colTEN, rowHandle);
                String diaChi = Utils.GetCellStringGridView(GVGridView, colDIACHI, rowHandle);
                if (column.Equals(view.Columns["MAGV"]))
                    return ValidateMaGv(maGV);
                else if (column.Equals(view.Columns["HO"]))
                    return ValidateHoGv(ho);
                else if (column.Equals(view.Columns["TEN"]))
                    return ValidateTenGv(ten);
                else if (column.Equals(view.Columns["DIACHI"]))
                    return ValidateDiaChi(diaChi);
            }
            return string.Empty;
        }

        private string ValidateDiaChi(string diaChi)
        {
            diaChi = Utils.RemoveExtraSpace(diaChi);
            if (diaChi.Length > 100)
                return "Địa chỉ không vượt quá 100 ký tự";
            return string.Empty;
        }
        private string ValidateMaGv(string maGV)
        {
            if (string.IsNullOrEmpty(maGV))
                return "Vui lòng nhập mã giảng viên";
            if (maGV.Length > 8)
                return "Mã giảng viên không vượt quá 8 ký tự";
            if (!Utils.IsMathRegex(maGV, Utils.RegexType.IDRegex))
                return "Mã giảng viên chỉ được chứa chữ không dấu và số";
            bool test1 = false;
            if (!_origMaGv.Trim().Equals(maGV.Trim()))
            {
                //    Console.WriteLine("MAA" + maGV);
                test1 = AlreadyExistsGv(maGV);
            }


            if (test1)
                return "Mã giảng viên đã tồn tại";

            return string.Empty;
        }
        private string ValidateHoGv(string ho)
        {
            ho = Utils.CapitalizeString(ho, Utils.CapitalMode.EveryWord);
            // setCellAtRowGV(colHO, ho, row);
            if (string.IsNullOrEmpty(ho))
                return "Vui lòng nhập họ và tên đệm giảng viên";

            if (!Utils.IsMathRegex(ho, Utils.RegexType.LetterOnly))
                return "Họ, tên đệm của GV chỉ được chứa chữ";

            if (ho.Length > 40)
                return "Họ giảng viên không vượt quá 40 ký tự";
            return string.Empty;
        }
        private string ValidateTenGv(string ten)
        {
            ten = Utils.CapitalizeString(ten, Utils.CapitalMode.EveryWord);
            //    setCellAtRowGV(colTEN, ten, row);
            if (string.IsNullOrEmpty(ten))
                return "Vui lòng nhập tên giảng viên";

            if (!Utils.IsMathRegex(ten, Utils.RegexType.LetterOnly))
                return "Tên của giảng viên chỉ được chứa chữ";

            if (ten.Length > 10)
                return "Tên giảng viên không vượt quá 10 ký tự";
            return string.Empty;
        }

        private bool RenameUser(string oldUserName, string newUsername)
        {
            List<Para> paraList = new List<Para>();
            paraList.Add(new Para("@OldUsername", oldUserName));
            paraList.Add(new Para("@NewUserName", newUsername));

            string spName = "usp_Login_RenameUser";
            bool success = DBConnection.ExecuteSqlNonQuerySP(spName, paraList);
            if (!success)
            {
                Console.WriteLine(System.Environment.StackTrace);
                return false;
            }

            return true;
        }

        private bool AlreadyExistsGv(string testName)
        {
            List<Para> paraList = new List<Para>();
            paraList.Add(new Para("@ID", testName));
            string spName = "usp_GiaoVien_GetInfoByID";
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
        void SetError(BaseEditViewInfo cellInfo, string errorIconText)
        {
            if (errorIconText == string.Empty) return;
            cellInfo.ErrorIconText = errorIconText;
            cellInfo.ShowErrorIcon = true;
            cellInfo.FillBackground = true;
            cellInfo.ErrorIcon = DXErrorProvider.GetErrorIconInternal(ErrorType.Critical);
        }

        private int GetEditingIndexGv()
        {
            if (_state == State.Edit)
                return _editingGvIndex;
            else if (_state == State.Add)
                return GVGridView.RowCount - 1;
            return -1;
        }
        private void ButtonSua_Click(object sender, EventArgs e)
        {
            ConfigEditingState();
        }
        private void ConfigEditingState()
        {
            string maGV = Utils.GetCellStringGridView(GVGridView, colMAGV, -1);
            _origMaGv = maGV;
            //Set lại cell value, bỏ khoảng trắng do char(n) của SQL;
            Utils.SetCellValueGridView(GVGridView, colMAGV, -1, maGV);

            _editingGvIndex = GVGridView.FocusedRowHandle;

            _state = State.Edit;
            SetCorrButtonsState();

            //kết hợp set enabled và reset Customization để hàng chỉnh sửa (hoặc thêm) không bị dịch dời
            Utils.SetCustomizationEnabled(GVGridView, false);
            GVGridView.OptionsBehavior.Editable = true;

            SetKhoaGridControlEnabled(false);
        }

        private void buttonLamMoiGV_Click(object sender, EventArgs e)
        {
            try
            {
                LoadAllData();
                Utils.ShowMessage("Làm mới thành công", Others.NotiForm.FormType.Success, 1);
                SetCorrButtonsState();
            }
            catch (Exception ex)
            {
                Utils.ShowMessage("Lỗi khi tải lại dữ liệu", Others.NotiForm.FormType.Error, 1);
                Console.WriteLine(ex.StackTrace);
                return;
            }
        }

        private void GVGridView_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (CheckTheRow(e.RowHandle))
            {
                BaseEditViewInfo info = ((GridCellInfo)e.Cell).ViewInfo;
                string error = GetError(e.RowHandle, e.Column);
                SetError(info, error);
                info.CalcViewInfo(e.Cache.Graphics);
            }


            //----
            if (e.RowHandle == GVGridView.FocusedRowHandle) return;
            if (_state == State.Add)
            {
                if (e.RowHandle == GVGridView.RowCount - 1)
                    e.Appearance.BackColor = Color.FromArgb(255, 237, 211);
            }
            if (_state == State.Edit)
            {
                if (e.RowHandle == _editingGvIndex)
                    e.Appearance.BackColor = Color.FromArgb(255, 237, 211);
            }
        }

        private void GVGridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            bool test1 = _state == State.Add && (e.FocusedRowHandle == GVGridView.RowCount - 1
                || e.FocusedRowHandle == -2147483647);
            bool test2 = _state == State.Edit && e.FocusedRowHandle == _editingGvIndex;

            if (test1 || test2)
                GVGridView.OptionsBehavior.Editable = true;
            else
                GVGridView.OptionsBehavior.Editable = false;
        }

        private void GVGridView_ShownEditor(object sender, EventArgs e)
        {
            string error = GetError(GVGridView.FocusedRowHandle, GVGridView.FocusedColumn);
            if (error == string.Empty)
            {
                GVGridView.ClearColumnErrors();
                return;
            }
            //   BaseEdit.DefaultErrorIcon = DXErrorProvider.GetErrorIconInternal(ErrorType.Information);
            GVGridView.SetColumnError(GVGridView.FocusedColumn, error);
        }

        private void KhoaGridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (KhoaBindingSource.Position >= 0)
            {
                string maKhoa = (KhoaBindingSource[KhoaBindingSource.Position] as DataRowView)["MAKH"].ToString().Trim();
                ViewCaption.Text = "Danh sách giảng viên thuộc khoa " + maKhoa.Trim();
            }

        }

        private void ButtonXoa_Click(object sender, EventArgs e)
        {
            string removedGv = "";
            _selectedRowGv = GVBindingSource.Position;
            if (GVDKBindingSource.Count > 0)
            {
                Utils.ShowMessage("Giảng viên này đã tổ chức thi, không thể xóa", Others.NotiForm.FormType.Error, 2);
                return;
            }
            if (BoDeBindingSource.Count > 0)
            {
                Utils.ShowMessage("Giảng viên này đã soạn đề, không thể xóa", Others.NotiForm.FormType.Error, 2);
                return;
            }
            if (Utils.GetCellStringGridView(GVGridView, colMAGV, -1).Equals(DBConnection.UserName))
            {
                Utils.ShowMessage("Không thể tự xóa chính bản thân mình", Others.NotiForm.FormType.Error, 2);
                return;
            }

            if (Utils.ShowConfirmMessage("Bạn có chắc muốn xóa giảng viên này?", "Xác nhận"))
            {
                try
                {
                    removedGv = ((DataRowView)GVBindingSource[_selectedRowGv])["MAGV"].ToString().Trim();
                    GVBindingSource.RemoveCurrent();
                    GVTableAdapter.Update(TN_CSDLPTDataSet.GIAOVIEN);

                    //Xóa user và login tương ứng (nếu có)
                    List<Para> paraList = new List<Para>();
                    paraList.Add(new Para("@UserName", removedGv.Trim()));
                    string spName = "usp_Login_RemoveLoginUser";
                    using (SqlDataReader myReader = DBConnection.ExecuteSqlDataReaderSP(spName, paraList))
                    {
                        if (myReader == null)
                        {
                            Utils.ShowMessage("Xảy ra lỗi khi xóa login và user của giáo viên tương ứng", Others.NotiForm.FormType.Error, 2);
                            Console.WriteLine(System.Environment.StackTrace);
                            return;
                        }
                        else
                        {
                            myReader.Read();
                            // Utils.ShowMessage("Mã của task xóa login: " + myReader.GetValue(0), Others.NotiForm.FormType.Error, 2);
                        }
                    }



                    Utils.ShowMessage("Xóa thông tin giảng viên thành công!", Others.NotiForm.FormType.Success, 2);
                }
                catch (Exception ex)
                {
                    Utils.ShowErrorMessage("Không thể xóa giảng viên này, xin vui lòng thử lại sau\n" + ex.Message, "Lỗi xóa nhân viên");
                    Console.WriteLine(ex.StackTrace);
                    this.GVTableAdapter.Fill(TN_CSDLPTDataSet.GIAOVIEN);
                    GVBindingSource.Position = GVBindingSource.Find("MAGV", removedGv);
                    return;
                }
                finally
                {
                    ConfigIdleState();
                }
            }

        }

        private void FormGV_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_state != State.Idle)
                if (!Utils.ShowConfirmMessage("Hủy những thay đổi đang thực hiện và đóng cửa sổ này?", "Xác nhận"))
                    e.Cancel = true;
        }

        private void GVBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            SetCorrButtonsState();
        }
    }
}