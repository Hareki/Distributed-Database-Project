using DevExpress.XtraEditors;
using DevExpress.XtraEditors.DXErrorProvider;
using DevExpress.XtraEditors.ViewInfo;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
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
using TracNghiemCSDLPT.SQL_Connection;

namespace TracNghiemCSDLPT.MyForms.TabbedForms
{
    public partial class FormGV : DevExpress.XtraEditors.XtraForm
    {
        public FormGV()
        {
            InitializeComponent();
        }
        State state = State.idle;
        enum State
        {
            add, edit, idle
        }
        private int selectedRowGV;
        private int PreviousIndexCS;
        private string origMaGV = "~!@#$%";
        private int editingGVIndex;
        private string saveMaKHForReset;
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
                    SetIdleButtonEnabledGV(false);
                    break;
                case "COSO":
                    CoSoComboBox.Enabled = false;
                    break;
            }

        }

        private void CheckButtonStateGV()
        {
            if (DBConnection.NhomQuyen.Equals("COSO"))
            {
                if (KhoaBindingSource.Count == 0)
                    buttonXoaGV.Enabled = buttonSuaGV.Enabled = false;
                else if (state != State.add && state != State.edit)
                    buttonXoaGV.Enabled = buttonSuaGV.Enabled = true;
            }

        }
        private void FormGV_Load(object sender, EventArgs e)
        {


            LoadAllData();

            this.TN_CSDLPTDataSet.EnforceConstraints = false;

            this.CoSoComboBox.DataSource = DBConnection.BS_Subcribers;
            this.CoSoComboBox.DisplayMember = "TENCS";
            this.CoSoComboBox.ValueMember = "TENSERVER";
            this.CoSoComboBox.SelectedIndex = DBConnection.IndexCS;
            this.PreviousIndexCS = this.CoSoComboBox.SelectedIndex;
            CheckButtonStateGV();
            PhanQuyen();
        }





        private void SetIdleButtonEnabledGV(bool state)
        {
            buttonThemGV.Enabled = buttonSuaGV.Enabled = buttonUndoGV.Enabled =
              buttonRedoGV.Enabled = buttonXoaGV.Enabled = state;
            if (Utils.IsTruong()) buttonLamMoiGV.Enabled = true;
            else buttonLamMoiGV.Enabled = state;
        }

        private void SetInputButtonEnabledGV(bool state)
        {
            buttonHuyGV.Visible = buttonXacNhanGV.Visible = state;
        }
        private void SetKhoaState(bool state)
        {
            KhoaGridControl.Enabled = state;
            Image img = state == true ? global::TracNghiemCSDLPT.Properties.Resources.asd
                : global::TracNghiemCSDLPT.Properties.Resources.disableasd;
            this.pictureBox1.Image = img;
        }

        private void buttonThemGV_Click(object sender, EventArgs e)
        {
            selectedRowGV = GVBindingSource.Position;
            //   SetKhoaState(false);
            //    SetIdleButtonEnabledGV(false);
            SetInputButtonEnabledGV(true);
            state = State.add;
            GVGridView.OptionsBehavior.Editable = true;
            GVBindingSource.AddNew();
        }

        private void buttonHuyGV_Click(object sender, EventArgs e)
        {
            GVGridView.OptionsBehavior.Editable = false;
            GVBindingSource.CancelEdit();
            if (state == State.add)
                GVBindingSource.Position = selectedRowGV;
            state = State.idle;
            SetIdleButtonEnabledGV(true);
            SetInputButtonEnabledGV(false);
            SetKhoaState(true);
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


        private void setCellAtRowGV(GridColumn column, string value, int row)
        {
            GVGridView.SetRowCellValue(row, column, value);
        }

        private void buttonXacNhanGV_Click(object sender, EventArgs e)
        {
            bool test1 = (GetError(GetEditingIndexGV(), colMAGV) == string.Empty);
            bool test2 = (GetError(GetEditingIndexGV(), colHO) == string.Empty);
            bool test3 = (GetError(GetEditingIndexGV(), colTEN) == string.Empty);
            GVGridView.ClearColumnErrors(); // lệnh này chỉ clear các cột bị lỗi trong show_editor (và chỉ có 1 cột bị chịu tác động của show_editor tại 1 thời điểm)
            if (test1 && test2 & test3)
            {
                try
                {
                    int editingIndex = GetEditingIndexGV();
                    string ho = Utils.CapitalizeString(getCellAtRowGV(colHO, editingIndex), Utils.CapitalMode.EveryWord);
                    setCellAtRowGV(colHO, ho, editingIndex);

                    string ten = Utils.CapitalizeString(getCellAtRowGV(colTEN, editingIndex), Utils.CapitalMode.EveryWord);
                    setCellAtRowGV(colTEN, ten, editingIndex);

                    GVBindingSource.EndEdit();
                    GVBindingSource.ResetCurrentItem();
                    this.GVTableAdapter.Update(this.TN_CSDLPTDataSet.GIAOVIEN);
                    if (state == State.edit)
                        Utils.ShowMessage("Sửa thông tin giảng viên thành công", Others.NotiForm.FormType.Success, 2);
                    else if (state == State.add)
                        Utils.ShowMessage("Thêm thông tin giảng viên thành công", Others.NotiForm.FormType.Success, 2);
                    state = State.idle;
                    GVGridView.ClearColumnErrors();
                    CheckButtonStateGV();
                    origMaGV = "~!@#$%";

                }
                catch (Exception ex)
                {
                    Utils.ShowErrorMessage("Không thể lưu thông tin giảng viên, xin vui lòng thử lại sau\n" + ex.Message, "Lỗi ghi nhân viên");
                    return;
                }
                SetKhoaState(true);
                SetIdleButtonEnabledGV(true);
                SetInputButtonEnabledGV(false);
            }
            else
            {
                Utils.ShowMessage("Vui lòng xem lại thông tin đã nhập", Others.NotiForm.FormType.Error, 2);
            }
        }
        private bool checkTheRow(int rowHandle)
        {
            //lúc add new() row handle chưa có dữ liệu (= -2147483647), khi select qua row khác rồi select lại thì mới nhận
            bool test1 = state != State.add && state != State.edit;
            bool test2a = rowHandle == GVGridView.RowCount - 1;
            // bool test2b = rowHandle == -2147483647;
            bool test3 = rowHandle == editingGVIndex;
            if (test1) return false;
            if (((test2a) && state == State.add) || (test3 && state == State.edit))
            {
                return true;
            }
            return false;
        }
        public string GetError(int rowHandle, GridColumn column)
        {
            if (checkTheRow(rowHandle))
            {
                GridView view = GVGridView;
                String maGV = getCellAtRowGV(colMAGV, rowHandle);
                String ho = getCellAtRowGV(colHO, rowHandle);
                String ten = getCellAtRowGV(colTEN, rowHandle);
                if (column.Equals(view.Columns["MAGV"]))
                    return ValidateMaGV(maGV);
                else if (column.Equals(view.Columns["HO"]))
                    return ValidateHoGV(ho, rowHandle);
                else if (column.Equals(view.Columns["TEN"]))
                    return ValidateTenGV(ten, rowHandle);
            }
            return string.Empty;
        }


        private string ValidateMaGV(string maGV)
        {
            if (string.IsNullOrEmpty(maGV))
                return "Vui lòng nhập mã giảng viên";
            if (maGV.Length > 8)
                return "Mã giảng viên không vượt quá 8 ký tự";

            bool test1 = false;
            if (!origMaGV.Trim().Equals(maGV.Trim()))
            {
                //    Console.WriteLine("MAA" + maGV);
                test1 = AlreadyExistsGV(maGV);
            }


            if (test1)
                return "Mã giảng viên đã tồn tại";

            return string.Empty;
        }
        private string ValidateHoGV(string ho, int row)
        {
            ho = Utils.CapitalizeString(ho, Utils.CapitalMode.EveryWord);
            // setCellAtRowGV(colHO, ho, row);
            if (string.IsNullOrEmpty(ho))
                return "Vui lòng nhập họ và tên đệm giảng viên";

            if (!Utils.IsMathRegex(ho, Utils.RegexType.LetterOnly))
                return "Họ, tên đệm của GV chỉ được chứa chữ";
            return string.Empty;
        }
        private string ValidateTenGV(string ten, int row)
        {
            ten = Utils.CapitalizeString(ten, Utils.CapitalMode.EveryWord);
            //    setCellAtRowGV(colTEN, ten, row);
            if (string.IsNullOrEmpty(ten))
                return "Vui lòng nhập tên giảng viên";

            if (!Utils.IsMathRegex(ten, Utils.RegexType.LetterOnly))
                return "Tên của giảng viên chỉ được chứa chữ";
            return string.Empty;
        }


        private bool AlreadyExistsGV(string testName)
        {
            List<Para> paraList = new List<Para>();
            paraList.Add(new Para("@ID", testName));
            string SPName = "usp_GiaoVien_GetInfoByID";
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
        void SetError(BaseEditViewInfo cellInfo, string errorIconText)
        {
            if (errorIconText == string.Empty) return;
            cellInfo.ErrorIconText = errorIconText;
            cellInfo.ShowErrorIcon = true;
            cellInfo.FillBackground = true;
            cellInfo.ErrorIcon = DXErrorProvider.GetErrorIconInternal(ErrorType.Critical);
        }

        private int GetEditingIndexGV()
        {
            if (state == State.edit)
                return editingGVIndex;
            else if (state == State.add)
                return GVGridView.RowCount - 1;
            return -1;
        }
        private string getCellAtRowGV(GridColumn column, int row)
        {
            return GVGridView.GetRowCellValue(row, column).ToString();
        }
        private string getCellAtFRowGV(GridColumn column)
        {
            return GVGridView.GetRowCellValue(GVGridView.FocusedRowHandle, column).ToString();
        }
        private void buttonSuaGV_Click(object sender, EventArgs e)
        {
            SetKhoaState(false);
            SetIdleButtonEnabledGV(false);
            SetInputButtonEnabledGV(true);

            string maGV = getCellAtFRowGV(colMAGV).Trim();
            GVGridView.SetRowCellValue(GVGridView.FocusedRowHandle, colMAGV, maGV);

            editingGVIndex = GVGridView.FocusedRowHandle;
            GVGridView.OptionsBehavior.Editable = true;
            origMaGV = getCellAtFRowGV(colMAGV).Trim();
            state = State.edit;
        }

        private void buttonLamMoiGV_Click(object sender, EventArgs e)
        {
            try
            {
                saveMaKHForReset = (KhoaBindingSource[KhoaBindingSource.Position] as DataRowView)["MAKH"].ToString();
                LoadAllData();
                Utils.ShowMessage("Làm mới thành công", Others.NotiForm.FormType.Success, 1);
                //  GobackAfterReset();
                CheckButtonStateGV();
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
            if (checkTheRow(e.RowHandle))
            {
                BaseEditViewInfo info = ((GridCellInfo)e.Cell).ViewInfo;
                string error = GetError(e.RowHandle, e.Column);
                SetError(info, error);
                info.CalcViewInfo(e.Cache.Graphics);
            }


            //----
            if (e.RowHandle == GVGridView.FocusedRowHandle) return;
            if (state == State.add)
            {
                if (e.RowHandle == GVGridView.RowCount - 1)
                    e.Appearance.BackColor = Color.FromArgb(255, 237, 211);
            }
            if (state == State.edit)
            {
                if (e.RowHandle == editingGVIndex)
                    e.Appearance.BackColor = Color.FromArgb(255, 237, 211);
            }
        }

        private void GVGridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            bool test1 = state == State.add && (e.FocusedRowHandle == GVGridView.RowCount - 1
                || e.FocusedRowHandle == -2147483647);
            bool test2 = state == State.edit && e.FocusedRowHandle == editingGVIndex;

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
                string MaKhoa = (KhoaBindingSource[KhoaBindingSource.Position] as DataRowView)["MAKH"].ToString();
                ViewCaption.Text = "Danh sách giảng viên thuộc khoa " + MaKhoa.Trim();
            }

        }

        private void buttonXoaGV_Click(object sender, EventArgs e)
        {
            string RemovedGV = "";
            selectedRowGV = GVBindingSource.Position;
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
            if (getCellAtFRowGV(colMAGV).Equals(DBConnection.UserName))
            {
                Utils.ShowMessage("Không thể tự xóa chính bản thân mình", Others.NotiForm.FormType.Error, 2);
                return;
            }

            if (Utils.ShowConfirmMessage("Bạn có chắc muốn xóa giảng viên này?", "Xác nhận"))
            {
                try
                {
                    RemovedGV = ((DataRowView)GVBindingSource[selectedRowGV])["MAGV"].ToString();
                    GVBindingSource.RemoveCurrent();
                    GVTableAdapter.Update(TN_CSDLPTDataSet.GIAOVIEN);

                    //Xóa user và login tương ứng (nếu có)
                    List<Para> paraList = new List<Para>();
                    paraList.Add(new Para("@UserName", RemovedGV.Trim()));
                    string SPName = "usp_Login_RemoveLoginUser";
                    SqlDataReader myReader = DBConnection.ExecuteSqlDataReaderSP(SPName, paraList);

                    if (myReader == null)
                    {
                        Utils.ShowMessage("Xảy ra lỗi khi xóa login và user của giáo viên tương ứng", Others.NotiForm.FormType.Error, 2);
                        Console.WriteLine(System.Environment.StackTrace);
                        return;
                    }
                    else
                    {
                        myReader.Read();
                        Utils.ShowMessage("Mã của task xóa login: " + myReader.GetValue(0), Others.NotiForm.FormType.Error, 2);
                    }

                    Utils.ShowMessage("Xóa thông tin giảng viên thành công!", Others.NotiForm.FormType.Success, 2);
                }
                catch (Exception ex)
                {
                    Utils.ShowErrorMessage("Không thể xóa giảng viên này, xin vui lòng thử lại sau\n" + ex.Message, "Lỗi xóa nhân viên");
                    Console.WriteLine(ex.StackTrace);
                    this.GVTableAdapter.Fill(TN_CSDLPTDataSet.GIAOVIEN);
                    GVBindingSource.Position = GVBindingSource.Find("MAGV", RemovedGV);
                    return;
                }
            }
            CheckButtonStateGV();
        }

        private void FormGV_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (state != State.idle)
                if (!Utils.ShowConfirmMessage("Hủy những thay đổi đang thực hiện và đóng cửa sổ này?", "Xác nhận"))
                    e.Cancel = true;
        }
    }
}