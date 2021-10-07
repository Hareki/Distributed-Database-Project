using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TracNghiemCSDLPT.Models;
using TracNghiemCSDLPT.SQL_Connection;

namespace TracNghiemCSDLPT.MyForms.TabbedForms
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
            switch (DBConnection.NhomQuyen)
            {
                case "TRUONG":
                    SetIdleButtonEnabled(false);
                    break;
                case "COSO":
                    CoSoComboBox.Enabled = false;
                    break;
            }

        }

        private int _previousIndexCS;
        private int _oldPositionRow;
        private string _origMaKH = "~!@#$%";
        private string _origTenKH = "~!@#$%";
        private string _maCS;

        private readonly Stack<Khoa> _undoStack = new Stack<Khoa>();
        private readonly Stack<Khoa> _redoStack = new Stack<Khoa>();
        private Khoa _beforeEditKhoa = null;

        private readonly Color _activeForeColor = Color.FromArgb(72, 70, 68);
        private readonly Color _disabledForeColor = SystemColors.AppWorkspace;
        private State _state = State.Idle;

        private const string ColMaKhoa = "MAKH";
        private const string ColTenKhoa = "TENKH";
        private const string ColMaCoSo = "MACS";

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
            this.CoSoComboBox.DataSource = DBConnection.BS_Subcribers;
            this.CoSoComboBox.DisplayMember = "TENCS";
            this.CoSoComboBox.ValueMember = "TENSERVER";
            this.CoSoComboBox.SelectedIndex = DBConnection.IndexCS;
            this._previousIndexCS = this.CoSoComboBox.SelectedIndex;
        }

        private void LoadAllData()
        {
            this.LopTableAdapter.Connection.ConnectionString =
            this.GiaoVienTableAdapter.Connection.ConnectionString =
            this.KhoaTableAdapter.Connection.ConnectionString = DBConnection.SubcriberConnectionString;

            this.KhoaTableAdapter.Fill(this.TN_CSDLPTDataSet.KHOA);
            this.GiaoVienTableAdapter.Fill(this.TN_CSDLPTDataSet.GIAOVIEN);
            this.LopTableAdapter.Fill(this.TN_CSDLPTDataSet.LOP);
            this._maCS = ((DataRowView)DBConnection.BS_Subcribers[CoSoComboBox.SelectedIndex])[ColMaCoSo].ToString();
        }

        private void CoSoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CoSoComboBox.SelectedValue.ToString().Equals("System.Data.DataRowView"))
            {
                return;
            }
            string login, pass;
            string serverName = CoSoComboBox.SelectedValue.ToString();
            if (CoSoComboBox.SelectedIndex != DBConnection.IndexCS)
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
                LoadAllData();
                this._previousIndexCS = this.CoSoComboBox.SelectedIndex;
                
            }
            else
            {
                Utils.ShowMessage("Tạm thời không thể kết nối đến cơ sở này", Others.NotiForm.FormType.Error, 2);
                this.CoSoComboBox.SelectedIndex = this._previousIndexCS;
            }
        }

        private bool MaKhoaAlreadyExists(string maKhoa)
        {
            string SPName = "usp_Khoa_GetInfoById";
            List<Para> paraList = new List<Para>();
            paraList.Add(new Para("@ID", maKhoa));
            SqlDataReader myReader = DBConnection.ExecuteSqlDataReaderSP(SPName,paraList);
            if (myReader == null)
            {
                Utils.ShowMessage("Xảy ra lỗi không xác định", Others.NotiForm.FormType.Error, 1);
                Console.WriteLine(System.Environment.StackTrace);
                return true;
            }
            bool isExist = myReader.HasRows;
            myReader.Close();
            return isExist;
        }



        private bool TenKhoaAlreadyExists(string tenKhoa)
        {
            string SPName = "usp_Khoa_GetInfoByName";
            List<Para> paraList = new List<Para>();
            paraList.Add(new Para("@Name", tenKhoa));
            SqlDataReader myReader = DBConnection.ExecuteSqlDataReaderSP(SPName,paraList);
            if (myReader == null)
            {
                Utils.ShowMessage("Xảy ra lỗi không xác định", Others.NotiForm.FormType.Error, 1);
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
            buttonThem.Enabled = 
            buttonXoa.Enabled =
            buttonSua.Enabled = state;

            if (Utils.IsTruong()) buttonLamMoi.Enabled = true;
            else buttonLamMoi.Enabled = state;
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
            SetInfoPanel(true, _activeForeColor, "Thêm mới thông tin khoa");
            SetIdleButtonEnabled(false);
            SetInputButtonEnabled(true);
            KhoaGridControl.Enabled = false;
            _state = State.Add;
            KhoaBindingSource.AddNew();
            TextMaCS.Text = _maCS;
        }

        private void  ResetTextEditErrors()
        {
            Utils.SetTextEditError(TenKHEP, TextTenKhoa, null);
            Utils.SetTextEditError(MaKHEP, TextMaKhoa, null);
        }
        private void ButtonHuy_Click(object sender, EventArgs e)
        {
            SetInfoPanel(false, _disabledForeColor, "Thông tin khoa");
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
                    deletedKhoa.Update(removedMaKhoa, removedTenKhoa, this._maCS, ActionType.Insert);
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
                this.KhoaTableAdapter.Connection.ConnectionString = DBConnection.SubcriberConnectionString;
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

        private bool IsMaKhoaValid()
        {
            string maKhoa = TextMaKhoa.Text;
            if (string.IsNullOrEmpty(maKhoa))
            {
                Utils.SetTextEditError(MaKHEP, TextMaKhoa, "Vui lòng nhập mã khoa!");
                Utils.ShowMessage("Vui lòng điền đầy đủ thông tin cần thiết", Others.NotiForm.FormType.Error, 2);
                return false;
            }

            if (!_origMaKH.Equals(maKhoa.ToLower()) && MaKhoaAlreadyExists(maKhoa))
            {
                Utils.SetTextEditError(MaKHEP, TextMaKhoa, "Mã khoa đã tồn tại");
                Utils.ShowMessage("Thông tin vừa nhập đã tồn tại", Others.NotiForm.FormType.Error, 2);
                return false;
            }

            return true;
        }

        private bool IsTenKhoaValid()
        {
            string tenKhoa = TextTenKhoa.Text;
            if (string.IsNullOrEmpty(tenKhoa))
            {
                Utils.SetTextEditError(TenKHEP, TextTenKhoa, "Vui lòng nhập tên khoa!");
                Utils.ShowMessage("Vui lòng điền đầy đủ thông tin cần thiết", Others.NotiForm.FormType.Error, 2);
                return false;
            }


            if (!_origTenKH.Equals(tenKhoa.ToLower()) && TenKhoaAlreadyExists(tenKhoa))
            {
                Utils.SetTextEditError(MaKHEP, TextTenKhoa, "Tên khoa đã tồn tại");
                Utils.ShowMessage("Thông tin vừa nhập đã tồn tại", Others.NotiForm.FormType.Error, 2);
                return false;
            }

            return true;
        }

        private Khoa ApplyInsertUpdate()
        {
            Khoa changedKhoa = new Khoa();
            TextMaKhoa.Text = TextMaKhoa.Text.Trim();
            TextTenKhoa.Text = Utils.CapitalizeString(TextTenKhoa.Text.Trim(), Utils.CapitalMode.FirstWordOnly);
            if (!IsMaKhoaValid() || !IsTenKhoaValid())
            {
                changedKhoa.ActionType = ActionType.NotValid;
                return changedKhoa;
            }

            string message = string.Empty;

            if (_state == State.Add)
            {
                changedKhoa.Update(TextMaKhoa.Text, TextTenKhoa.Text, this._maCS, ActionType.Delete);
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
                SetInfoPanel(false, _disabledForeColor, "Thông tin khoa");
                SetIdleButtonEnabled(true);
                SetInputButtonEnabled(false);
                CheckButtonState();
                _origMaKH = _origTenKH = "~!@#$%";
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
            khoa.MaCoSo = this._maCS;
            return khoa;
        }

        private void ButtonSua_Click(object sender, EventArgs e)
        {
            _beforeEditKhoa = GetKhoaAtPosition(KhoaBindingSource.Position);
            SetInfoPanel(true, _activeForeColor, "Sửa thông tin khoa");
            SetIdleButtonEnabled(false);
            SetInputButtonEnabled(true);
            KhoaGridControl.Enabled = false;
            _state = State.Edit;
            _origMaKH = TextMaKhoa.Text.Trim().ToLower();
            _origTenKH = TextTenKhoa.Text.Trim().ToLower();
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
            _origMaKH = _beforeEditKhoa.MaKhoa.ToLower();
            _origTenKH = _beforeEditKhoa.TenKhoa.ToLower();
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
            Khoa changedKhoa = ApplyInsertUpdate();
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
    }
}