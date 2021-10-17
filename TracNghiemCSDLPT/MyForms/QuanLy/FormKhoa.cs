using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using TracNghiemCSDLPT.Models;
using TracNghiemCSDLPT.Others;

namespace TracNghiemCSDLPT.MyForms.QuanLy
{
    public partial class FormKhoa : DevExpress.XtraEditors.XtraForm
    {
        public FormKhoa()
        {
            InitializeComponent();

        }

        enum State
        {
            Add, Edit, Idle
        }

        private void PhanQuyen()
        {
            switch (DbConnection.NhomQuyen)
            {
                case "TRUONG":
                    SetIdleButtonEnabled(false);
                    break;
                case "COSO":
                    CoSoComboBox.Enabled = false;
                    break;
            }

        }

        private int _previousIndexCs;
        private int _oldPositionRow;
        private string _origMaKh = "~!@#$%";
        private string _origTenKh = "~!@#$%";
        private string _maCs;

        private readonly Stack<Khoa> _undoStack = new Stack<Khoa>();
        private readonly Stack<Khoa> _redoStack = new Stack<Khoa>();
        private Khoa _beforeEditKhoa = null;

        private State _state = State.Idle;

        private const string ColMaKhoa = "MAKH";
        private const string ColTenKhoa = "TENKH";
        private const string ColMaCoSo = "MACS";

        private void SetDefaultOrigValue()
        {
            _origMaKh = "~!@#$%";
            _origTenKh = "~!@#$%";

        }
        private void FormKhoa_Load(object sender, EventArgs e)
        {
            this.TN_CSDLPTDataSet.EnforceConstraints = false;
            LoadCombobox();
            LoadAllData();
            CheckButtonState();
            buttonUndo.Enabled = buttonRedo.Enabled = false;
            PhanQuyen();
        }

        private void LoadCombobox()
        {
            this.CoSoComboBox.DataSource = DbConnection.BsSubcribers;
            this.CoSoComboBox.DisplayMember = "TENCS";
            this.CoSoComboBox.ValueMember = "TENSERVER";
            this.CoSoComboBox.SelectedIndex = DbConnection.IndexCs;
            this._previousIndexCs = this.CoSoComboBox.SelectedIndex;
        }

        private void LoadAllData()
        {
            this.LopTableAdapter.Connection.ConnectionString =
            this.GiaoVienTableAdapter.Connection.ConnectionString =
            this.KhoaTableAdapter.Connection.ConnectionString = DbConnection.SubcriberConnectionString;

            this.KhoaTableAdapter.Fill(this.TN_CSDLPTDataSet.KHOA);
            this.GiaoVienTableAdapter.Fill(this.TN_CSDLPTDataSet.GIAOVIEN);
            this.LopTableAdapter.Fill(this.TN_CSDLPTDataSet.LOP);
            this._maCs = ((DataRowView)DbConnection.BsSubcribers[CoSoComboBox.SelectedIndex])[ColMaCoSo].ToString();
        }

        private void CoSoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CoSoComboBox.SelectedValue.ToString().Equals("System.Data.DataRowView"))
            {
                return;
            }
            string login, pass;
            string serverName = CoSoComboBox.SelectedValue.ToString();
            if (CoSoComboBox.SelectedIndex != DbConnection.IndexCs)
            {
                login = DbConnection.RemoteLogin;
                pass = DbConnection.RemotePassword;
            }
            else
            {
                login = DbConnection.LoginName;
                pass = DbConnection.Password;
            }
            bool success = DbConnection.ConnectToSubcriber(login, pass, serverName);
            if (success)
            {
                LoadAllData();
                this._previousIndexCs = this.CoSoComboBox.SelectedIndex;

            }
            else
            {
                Utils.ShowMessage("Tạm thời không thể kết nối đến cơ sở này", Others.NotiForm.FormType.Error, 2);
                this.CoSoComboBox.SelectedIndex = this._previousIndexCs;
            }
        }

        private bool MaKhoaAlreadyExists(string maKhoa, bool isUndoRedo)
        {
            string spName = "usp_Khoa_GetInfoById";
            List<Para> paraList = new List<Para>();
            paraList.Add(new Para("@ID", maKhoa));
            if (isUndoRedo)
            {
                paraList.Add(new Para("@MACS", this._maCs));
            }
            SqlDataReader myReader = DbConnection.ExecuteSqlDataReaderSp(spName, paraList);
            if (myReader == null)
            {
                Console.WriteLine(System.Environment.StackTrace);
                return true;
            }
            bool isExist = myReader.HasRows;
            myReader.Close();
            return isExist;
        }



        private bool TenKhoaAlreadyExists(string tenKhoa, bool isUndoRedo)
        {
            string spName = "usp_Khoa_GetInfoByName";
            List<Para> paraList = new List<Para>();
            paraList.Add(new Para("@Name", tenKhoa));
            if (isUndoRedo)
            {
                paraList.Add(new Para("@MACS", this._maCs));
            }
            SqlDataReader myReader = DbConnection.ExecuteSqlDataReaderSp(spName, paraList);
            if (myReader == null)
            {
                Console.WriteLine(System.Environment.StackTrace);
                return true;
            }
            bool isExist = myReader.HasRows;
            myReader.Close();
            return isExist;
        }

        private void CheckButtonState()
        {
            if (KhoaBindingSource.Count == 0)
            {
                buttonXoa.Enabled = buttonSua.Enabled = false;
            }
            else
            {
                buttonXoa.Enabled = buttonSua.Enabled = true;
            }
        }

        private void SetIdleButtonEnabled(bool state)
        {
            buttonUndo.Enabled =
            buttonRedo.Enabled =
            buttonThem.Enabled =
            buttonXoa.Enabled =
            buttonSua.Enabled = state;

            if (Utils.IsTruong()) buttonLamMoi.Enabled = true;
            else buttonLamMoi.Enabled = state;

            if (state == false)
            {
                buttonUndo.BackColor = buttonRedo.BackColor = Color.FromArgb(247, 247, 247);
            }
            else
            {
                buttonUndo.BackColor = buttonRedo.BackColor = Color.FromArgb(240, 240, 240);
            }
        }

        private void SetInputButtonEnabled(bool state)
        {
            // buttonUndo.Visible = 
            // buttonRedo.Visible =
            buttonHuy.Visible =
            buttonXacNhan.Visible = state;
           
        }

        private void SetInfoPanel(bool state, Color color, string message)
        {
            InfoPanel.Enabled = state;
            InfoPanel.ForeColor =
            TextMaKhoa.ForeColor =
            TextTenKhoa.ForeColor = color;
            InfoPanel.Text = message;
        }

        private void ButtonThem_Click(object sender, EventArgs e)
        {
            _oldPositionRow = KhoaBindingSource.Position;
            SetInfoPanel(true, Utils.ActiveColor, "Thêm mới thông tin khoa");
            SetIdleButtonEnabled(false);
            SetInputButtonEnabled(true);
            KhoaGridControl.Enabled = false;
            _state = State.Add;
            KhoaBindingSource.AddNew();
            TextMaCS.Text = _maCs;
        }

        private void ResetTextEditErrors()
        {
            Utils.SetTextEditError(TenKHEP, TextTenKhoa, null);
            Utils.SetTextEditError(MaKHEP, TextMaKhoa, null);
        }
        private void ButtonHuy_Click(object sender, EventArgs e)
        {
            SetInfoPanel(false, Utils.DisabledColor, "Thông tin khoa");
            SetIdleButtonEnabled(true);
            SetInputButtonEnabled(false);
            KhoaGridControl.Enabled = true;
            KhoaBindingSource.CancelEdit();
            ResetTextEditErrors();
            Debug.WriteLine(KhoaBindingSource.Position);
            if (_state.Equals(State.Add))
            {
                KhoaBindingSource.Position = _oldPositionRow;
            }
            _state = State.Idle;
            SetDefaultOrigValue();
        }

        private bool CheckDeleteCondition()
        {
            if (LopBindingSource.Count > 0)
            {
                Utils.ShowMessage("Không thể xóa vì khoa đã có lớp học", Others.NotiForm.FormType.Error, 2);
                return false;
            }
            if (GiaoVienBindingSource.Count > 0)
            {
                Utils.ShowMessage("Không thể xóa vì khoa đã có giảng viên", Others.NotiForm.FormType.Error, 4);
                return false;
            }
            return true;
        }

        private Khoa DeleteKhoa()
        {
            Khoa deletedKhoa = new Khoa();
            int selectedRow = KhoaBindingSource.Position;
            DataRowView rowView = ((DataRowView)KhoaBindingSource[selectedRow]);
            string removedMaKhoa = rowView[ColMaKhoa].ToString();
            string removedTenKhoa = rowView[ColTenKhoa].ToString();

            if (CheckDeleteCondition() == false)
            {
                deletedKhoa.ActionType = ActionType.NotValid;
            }

            if (Utils.ShowConfirmMessage($"Bạn có chắc muốn xóa khoa {removedTenKhoa}?", "Xác nhận"))
            {
                try
                {

                    removedMaKhoa = rowView[ColMaKhoa].ToString();
                    KhoaBindingSource.RemoveCurrent();
                    KhoaTableAdapter.Update(TN_CSDLPTDataSet.KHOA);
                    deletedKhoa.Update(removedMaKhoa, removedTenKhoa, this._maCs, ActionType.Insert);
                    Utils.ShowMessage($"Xóa khoa {deletedKhoa.TenKhoa} thành công!", Others.NotiForm.FormType.Success, 1);
                    CheckButtonState();
                }
                catch (Exception ex)
                {
                    Utils.ShowErrorMessage($"Không thể xóa khoa {removedTenKhoa}, xin vui lòng thử lại sau\n" + ex.Message, "Lỗi xóa khoa!");
                    Console.WriteLine(ex.StackTrace);
                    this.KhoaTableAdapter.Fill(TN_CSDLPTDataSet.KHOA);
                    KhoaBindingSource.Position = KhoaBindingSource.Find(ColMaKhoa, removedMaKhoa);
                    deletedKhoa.ActionType = ActionType.NotValid;
                }
            }
            else
            {
                deletedKhoa.ActionType = ActionType.NotValid;
            }
            return deletedKhoa;
        }

        private void CreateUndo(Khoa khoa)
        {
            switch (khoa.ActionType)
            {
                case ActionType.Insert:
                case ActionType.Update:
                case ActionType.Delete:
                    _undoStack.Push(khoa);
                    buttonUndo.Enabled = true;
                    break;
                case ActionType.NotValid:
                    if (_undoStack.Count > 0) _undoStack.Pop();
                    break;
            }
        }

        private void ButtonXoa_Click(object sender, EventArgs e)
        {
            Khoa undoKhoa = DeleteKhoa();
            CreateUndo(undoKhoa);
            this._redoStack.Clear();
            this.buttonRedo.Enabled = false;
        }

        private void ButtonLamMoi_Click(object sender, EventArgs e)
        {
            try
            {
                this.KhoaTableAdapter.Connection.ConnectionString = DbConnection.SubcriberConnectionString;
                this.KhoaTableAdapter.Fill(this.TN_CSDLPTDataSet.KHOA);
                Utils.ShowMessage("Làm mới thành công", Others.NotiForm.FormType.Success, 1);
                CheckButtonState();
            }
            catch (Exception ex)
            {
                Utils.ShowMessage("Lỗi khi tải lại dữ liệu", Others.NotiForm.FormType.Error, 1);
                Console.WriteLine(ex.StackTrace);
                return;
            }
        }

        private bool IsMaKhoaValid(bool isUndoRedo)
        {
            string maKhoa = TextMaKhoa.Text;
            if (string.IsNullOrEmpty(maKhoa))
            {
                Utils.SetTextEditError(MaKHEP, TextMaKhoa, "Vui lòng nhập mã khoa!");
                Utils.ShowMessage("Vui lòng điền đầy đủ thông tin cần thiết", Others.NotiForm.FormType.Error, 2);
                return false;
            }

            if (!_origMaKh.Equals(maKhoa.ToLower()) && MaKhoaAlreadyExists(maKhoa, isUndoRedo))
            {
                Utils.SetTextEditError(MaKHEP, TextMaKhoa, "Mã khoa đã tồn tại");
                Utils.ShowMessage("Thông tin vừa nhập đã tồn tại", Others.NotiForm.FormType.Error, 2);
                return false;
            }

            return true;
        }

        private bool IsTenKhoaValid(bool isUndoRedo)
        {
            string tenKhoa = TextTenKhoa.Text;
            if (string.IsNullOrEmpty(tenKhoa))
            {
                Utils.SetTextEditError(TenKHEP, TextTenKhoa, "Vui lòng nhập tên khoa!");
                Utils.ShowMessage("Vui lòng điền đầy đủ thông tin cần thiết", Others.NotiForm.FormType.Error, 2);
                return false;
            }


            if (!_origTenKh.Equals(tenKhoa.ToLower()) && TenKhoaAlreadyExists(tenKhoa, isUndoRedo))
            {
                Utils.SetTextEditError(MaKHEP, TextTenKhoa, "Tên khoa đã tồn tại");
                Utils.ShowMessage("Thông tin vừa nhập đã tồn tại", Others.NotiForm.FormType.Error, 2);
                return false;
            }

            return true;
        }

        private Khoa ApplyInsertUpdate(bool isUndoRedo = false)
        {
            Khoa changedKhoa = new Khoa();
            TextMaKhoa.Text = TextMaKhoa.Text.Trim();
            TextTenKhoa.Text = Utils.CapitalizeString(TextTenKhoa.Text.Trim(), Utils.CapitalMode.FirstWordOnly);
            if (!IsMaKhoaValid(isUndoRedo) || !IsTenKhoaValid(isUndoRedo))
            {
                changedKhoa.ActionType = ActionType.NotValid;
                return changedKhoa;
            }

            string message = string.Empty;

            if (_state == State.Add)
            {
                changedKhoa.Update(TextMaKhoa.Text, TextTenKhoa.Text, this._maCs, ActionType.Delete);
                message = $"Thêm khoa {changedKhoa.TenKhoa} thành công!";
            }
            else if (_state == State.Edit)
            {
                changedKhoa = _beforeEditKhoa;
                changedKhoa.ActionType = ActionType.Update;
                message = $"Sửa khoa {TextTenKhoa.Text.Trim()} thành công!";
            }

            try
            {
                KhoaBindingSource.EndEdit();
                KhoaBindingSource.ResetCurrentItem();
                KhoaTableAdapter.Update(TN_CSDLPTDataSet.KHOA);
                Utils.ShowMessage(message, Others.NotiForm.FormType.Success, 1);
                _state = State.Idle;
                ResetTextEditErrors();
                KhoaGridControl.Enabled = true;
                SetInfoPanel(false, Utils.DisabledColor, "Thông tin khoa");
                SetIdleButtonEnabled(true);
                SetInputButtonEnabled(false);
                CheckButtonState();
                SetDefaultOrigValue();
            }
            catch (Exception ex)
            {
                Utils.ShowErrorMessage($"Không thể lưu khoa, xin vui lòng thử lại sau\n{ex.Message}", "Lỗi ghi nhân viên");
                changedKhoa.ActionType = ActionType.NotValid;
            }
            return changedKhoa;
        }

        private void ButtonXacNhan_Click(object sender, EventArgs e)
        {
            Khoa undoKhoa = ApplyInsertUpdate();
            CreateUndo(undoKhoa);
            this._redoStack.Clear();
            this.buttonRedo.Enabled = false;
        }

        private Khoa GetKhoaAtPosition(int selectedRow)
        {
            Khoa khoa = new Khoa();
            DataRowView rowView = ((DataRowView)KhoaBindingSource[selectedRow]);
            khoa.MaKhoa = rowView[ColMaKhoa].ToString().Trim().ToUpper();
            khoa.TenKhoa = Utils.CapitalizeString(rowView[ColTenKhoa].ToString(), Utils.CapitalMode.FirstWordOnly);
            khoa.MaCoSo = this._maCs;
            return khoa;
        }

        private void ButtonSua_Click(object sender, EventArgs e)
        {
            _beforeEditKhoa = GetKhoaAtPosition(KhoaBindingSource.Position);
            SetInfoPanel(true, Utils.ActiveColor, "Sửa thông tin khoa");
            SetIdleButtonEnabled(false);
            SetInputButtonEnabled(true);
            KhoaGridControl.Enabled = false;
            _state = State.Edit;
            _origMaKh = TextMaKhoa.Text.Trim().ToLower();
            _origTenKh = TextTenKhoa.Text.Trim().ToLower();
        }


        private void CreateRedo(Khoa khoa)
        {
            switch (khoa.ActionType)
            {
                case ActionType.Insert:
                case ActionType.Update:
                case ActionType.Delete:
                    _redoStack.Push(khoa);
                    buttonRedo.Enabled = true;
                    break;
                case ActionType.NotValid:
                    break;
            }
        }

        private Khoa DoInsertUndoRedo(Khoa undoRedoKhoa)
        {
            _state = State.Add;
            KhoaBindingSource.AddNew();
            return ApplyInsertUpdateUndoRedo(undoRedoKhoa);
        }

        private Khoa DoUpdateUndoRedo(Khoa undoRedoKhoa)
        {
            _state = State.Edit;
            int selectedRow = KhoaBindingSource.Find(ColMaKhoa, undoRedoKhoa.MaKhoa);
            _beforeEditKhoa = GetKhoaAtPosition(selectedRow);
            _origMaKh = _beforeEditKhoa.MaKhoa.ToLower();
            _origTenKh = _beforeEditKhoa.TenKhoa.ToLower();
            return ApplyInsertUpdateUndoRedo(undoRedoKhoa);
        }

        private Khoa DoDeleteUndoRedo(Khoa undoRedoKhoa)
        {
            KhoaBindingSource.Position = KhoaBindingSource.Find(ColMaKhoa, undoRedoKhoa.MaKhoa);
            return DeleteKhoa();
        }

        private Khoa ApplyInsertUpdateUndoRedo(Khoa undoKhoa)
        {
            TextMaKhoa.Text = undoKhoa.MaKhoa;
            TextTenKhoa.Text = undoKhoa.TenKhoa;
            TextMaCS.Text = undoKhoa.MaCoSo;
            Khoa changedKhoa = ApplyInsertUpdate(true);
            return changedKhoa;
        }

        private void ButtonUndo_Click(object sender, EventArgs e)
        {
            if (_undoStack.Count == 0) return;
            this.buttonUndo.Enabled = _redoStack.Count != 0;

            Khoa undoKhoa = _undoStack.Pop();
            Khoa redoKhoa;
            switch (undoKhoa.ActionType)
            {
                case ActionType.Insert:
                    redoKhoa = DoInsertUndoRedo(undoKhoa);
                    CreateRedo(redoKhoa);
                    break;
                case ActionType.Update:
                    redoKhoa = DoUpdateUndoRedo(undoKhoa);
                    CreateRedo(redoKhoa);
                    break;
                case ActionType.Delete:
                    redoKhoa = DoDeleteUndoRedo(undoKhoa);
                    CreateRedo(redoKhoa);
                    break;
                case ActionType.NotValid:
                    break;
            }
        }

        private void ButtonRedo_Click(object sender, EventArgs e)
        {
            if (_redoStack.Count == 0) return;

            Khoa redoKhoa = _redoStack.Pop();
            this.buttonRedo.Enabled = _redoStack.Count != 0;
            Khoa undoKhoa;

            switch (redoKhoa.ActionType)
            {
                case ActionType.Insert:
                    undoKhoa = DoInsertUndoRedo(redoKhoa);
                    CreateUndo(undoKhoa);
                    break;
                case ActionType.Update:
                    undoKhoa = DoUpdateUndoRedo(redoKhoa);
                    CreateUndo(undoKhoa);
                    break;
                case ActionType.Delete:
                    undoKhoa = DoDeleteUndoRedo(redoKhoa);
                    CreateUndo(undoKhoa);
                    break;
                case ActionType.NotValid:
                    break;
            }
        }

        private void FormKhoa_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_state != State.Idle)
                if (!Utils.ShowConfirmMessage("Hủy những thay đổi đang thực hiện và đóng cửa sổ này?", "Xác nhận"))
                    e.Cancel = true;
        }

        private void pictureBox1_EnabledChanged(object sender, EventArgs e)
        {
            if (pictureBox1.Enabled)
                pictureBox1.Image = global::TracNghiemCSDLPT.Properties.Resources.school;
            else
                pictureBox1.Image = global::TracNghiemCSDLPT.Properties.Resources.school_disabled;
        }
    }
}