using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using TracNghiemCSDLPT.Others;
namespace TracNghiemCSDLPT.MyForms.QuanLy
{
    public partial class FormMonHoc : DevExpress.XtraEditors.XtraForm
    {
        private int _selectedRow = 0;

        public FormMonHoc()
        {
            InitializeComponent();

        }
        private void PhanQuyen()
        {
            switch (DBConnection.NhomQuyen)
            {
                case "TRUONG":
                    SetIdleButtonEnabled(false);
                    buttonLamMoi.Enabled = true;
                    break;
                case "GIAOVIEN":
                    SetIdleButtonEnabled(false);
                    break;
            }

        }

        State _state = State.Idle;
        string _origMaMH = null;
        string _origTenMh = null;

        enum State
        {
            Add, Edit, Idle
        }


        private void LoadAllData()
        {

            this.MonHocTableAdapter.Connection.ConnectionString = DBConnection.SubcriberConnectionString;
            this.BoDeTableAdapter.Connection.ConnectionString = DBConnection.SubcriberConnectionString;
            this.GV_DKTableAdapter.Connection.ConnectionString = DBConnection.SubcriberConnectionString;
            this.BangDiemTableAdapter.Connection.ConnectionString = DBConnection.SubcriberConnectionString;

            this.MonHocTableAdapter.Fill(this.TN_CSDLPTDataSet.MONHOC);
            this.BoDeTableAdapter.Fill(this.TN_CSDLPTDataSet.BODE);
            this.GV_DKTableAdapter.Fill(this.TN_CSDLPTDataSet.GIAOVIEN_DANGKY);
            this.BangDiemTableAdapter.Fill(this.TN_CSDLPTDataSet.BANGDIEM);
        }
        private void MonHoc_Load(object sender, EventArgs e)
        {
            this.TN_CSDLPTDataSet.EnforceConstraints = false;//phải có dòng này, nếu không khi refresh sẽ ko cho, do môn học là khóa chính, đã trỏ ra các bảng khác
            LoadAllData();
            PhanQuyen();
            SetCorrButtonsState();
        }

        private void SetIdleButtonEnabled(bool state)
        {
            buttonThem.Enabled = buttonXoa.Enabled =
                 buttonSua.Enabled = buttonLamMoi.Enabled = state;

        }
        private void SetInputButtonVisible(bool state)
        {
            buttonHuy.Visible = buttonXacNhan.Visible = state;
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

                        if (MonHocBindingSource.Count > 0)
                            SetIdleButtonEnabled(true);
                        else SetIdleButtonEnabled(false);

                        break;
                }
            }
        }
        private void SetInputColor(Color color)
        {
            TextMaMH.ForeColor = TextTenMH.ForeColor = color;
        }
        private void ButtonThem_Click(object sender, EventArgs e)
        {
            ConfigAddingState();
        }

        private void ButtonHuy_Click(object sender, EventArgs e)
        {
            ConfigIdleState();
        }

        private void SaveOrigValue()
        {
            _origMaMH = TextMaMH.Text;
            _origTenMh = Utils.CapitalizeString(TextTenMH.Text, Utils.CapitalMode.FirstWordOnly);
        }

        private void ResetOrigValue()
        {
            _origMaMH = _origTenMh = null;
        }

        private void ConfigIdleState()
        {
            ResetOrigValue();

            _state = State.Idle;
            SetInputColor(Utils.DisabledColor);
            MonHocBindingSource.CancelEdit();
            SetCorrButtonsState();
            ClearErrors();

            if (_state == State.Add)
                MonHocBindingSource.Position = _selectedRow;


            Utils.ConfigInfoPanelAppearance(InfoPanel, "Thông tin môn học", Utils.DisabledColor);
            InfoPanel.Enabled = false;

            MonHocGridControl.Enabled = true;

        }
        private void ConfigAddingState()
        {
            _selectedRow = MonHocBindingSource.Position;

            _state = State.Add;
            SetCorrButtonsState();
            MonHocBindingSource.AddNew();
            SetInputColor(Utils.ActiveColor);


            Utils.ConfigInfoPanelAppearance(InfoPanel, "Thêm mới thông tin môn học", Utils.AddColor);
            InfoPanel.Enabled = true;

            MonHocGridControl.Enabled = false;

        }
        private void ConfigEditingState()
        {
            TextMaMH.Text = Utils.RemoveExtraSpace(TextMaMH.Text);
            SaveOrigValue();

            _state = State.Edit;
            SetCorrButtonsState();
            SetInputColor(Utils.ActiveColor);

            Utils.ConfigInfoPanelAppearance(InfoPanel, "Sửa thông tin môn học", Utils.EditColor);
            InfoPanel.Enabled = true;

            MonHocGridControl.Enabled = false;
        }
        private void ButtonSua_Click(object sender, EventArgs e)
        {
            ConfigEditingState();
        }

        private void buttonLamMoi_Click(object sender, EventArgs e)
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

        private void ButtonXoa_Click(object sender, EventArgs e)
        {
            string removedMH = string.Empty;
            _selectedRow = MonHocBindingSource.Position;
            if (BoDeBindingSource.Count > 0)
            {
                Utils.ShowMessage("Không thể xóa vì đã có câu hỏi thuộc môn học này", Others.NotiForm.FormType.Error, 2);
                return;
            }
            if (GV_DKBindingSource.Count > 0)
            {
                Utils.ShowMessage("Không thể xóa vì đã có giảng viên đăng ký thi môn học này", Others.NotiForm.FormType.Error, 3);
                return;
            }
            if (BangDiemBindingSource.Count > 0)
            {
                Utils.ShowMessage("Không thể xóa vì đã có sinh viên thi môn học này", Others.NotiForm.FormType.Error, 4);
                return;
            }
            if (Utils.ShowConfirmMessage("Bạn có chắc muốn xóa môn học này?", "Xác nhận"))
            {
                try
                {
                    removedMH = ((DataRowView)MonHocBindingSource[_selectedRow])["MAMH"].ToString();
                    MonHocBindingSource.RemoveCurrent();
                    MonHocTableAdapter.Update(TN_CSDLPTDataSet.MONHOC);
                    Utils.ShowMessage("Xóa môn học thành công!", Others.NotiForm.FormType.Success, 1);
                }
                catch (Exception ex)
                {
                    Utils.ShowErrorMessage("Không thể xóa môn học này, xin vui lòng thử lại sau\n" + ex.Message, "Lỗi xóa môn học");
                    Console.WriteLine(ex.StackTrace);
                    this.MonHocTableAdapter.Fill(TN_CSDLPTDataSet.MONHOC);
                    MonHocBindingSource.Position = MonHocBindingSource.Find("MAMH", removedMH);
                    return;
                }
            }

            SetCorrButtonsState();
        }

        private bool AlreadyExists(string testName, bool isId)
        {
            List<Para> paraList = new List<Para>();
            string spName = "usp_MonHoc_GetInfoByXXX";
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
        private void ButtonXacNhan_Click(object sender, EventArgs e)
        {
            string maMh = TextMaMH.Text = Utils.RemoveExtraSpace(TextMaMH.Text);
            string tenMh = TextTenMH.Text = Utils.CapitalizeString
                (TextTenMH.Text, Utils.CapitalMode.FirstWordOnly);
            bool test1 = string.IsNullOrEmpty(maMh);
            bool test2 = string.IsNullOrEmpty(tenMh);
            if (test1 || test2)
            {
                if (test1)
                    Utils.SetTextEditError(MaMHEP, TextMaMH, "Vui lòng nhập mã môn học");
                else
                    Utils.SetTextEditError(MaMHEP, TextMaMH, null);
                if (test2)
                    Utils.SetTextEditError(TenMHEP, TextTenMH, "Vui lòng nhập tên môn học");
                else
                    Utils.SetTextEditError(TenMHEP, TextTenMH, null);


                Utils.ShowMessage("Vui lòng điền đầy đủ thông tin cần thiết", Others.NotiForm.FormType.Error, 2);
                return;
            }
            else
            {
                ClearErrors();
            }


            bool test5 = maMh.Length > 5;
            bool test6 = tenMh.Length > 40;
            if (test5 || test6)
            {
                if (test5)
                    Utils.SetTextEditError(MaMHEP, TextMaMH, "Mã môn học không được quá 5 ký tự");
                else
                    Utils.SetTextEditError(MaMHEP, TextMaMH, null);

                if (test6)
                    Utils.SetTextEditError(TenMHEP, TextTenMH, "Tên môn học không được quá 40 ký tự");
                else
                    Utils.SetTextEditError(TenMHEP, TextTenMH, null);

                Utils.ShowMessage("Thông tin nhập quá dài", Others.NotiForm.FormType.Warning, 1);
                return;
            }

            bool test3 = !Utils.IsMathRegex(maMh, Utils.RegexType.IDRegex);
            bool test4 = !Utils.IsMathRegex(tenMh, Utils.RegexType.LetterDigits);
            if (test3 || test4)
            {
                if (test3)
                    Utils.SetTextEditError(MaMHEP, TextMaMH, "Mã môn học chỉ được chứa chữ không dấu và số");
                else
                    Utils.SetTextEditError(MaMHEP, TextMaMH, null);
                if (test4)
                    Utils.SetTextEditError(TenMHEP, TextTenMH, "Tên môn học chỉ được chứa chữ và số");
                else
                    Utils.SetTextEditError(TenMHEP, TextTenMH, null);


                Utils.ShowMessage("Vui lòng điền thông tin hợp lệ", Others.NotiForm.FormType.Error, 2);
                return;
            }
            else
            {
                ClearErrors();
            }


            test1 = test2 = false;
            if (!_origMaMH.ToLower().Equals(maMh.ToLower()))
                test1 = AlreadyExists(maMh, true);

            if (!_origTenMh.ToLower().Equals(tenMh.ToLower()))
                test2 = AlreadyExists(tenMh, false);


            if (test1 || test2)
            {
                if (test1)
                    Utils.SetTextEditError(MaMHEP, TextMaMH, "Mã môn học đã tồn tại");
                else
                    Utils.SetTextEditError(MaMHEP, TextMaMH, null);
                if (test2)
                    Utils.SetTextEditError(TenMHEP, TextTenMH, "Tên môn học đã tồn tại");
                else
                    Utils.SetTextEditError(TenMHEP, TextTenMH, null);

                Utils.ShowMessage("Thông tin vừa nhập đã tồn tại", Others.NotiForm.FormType.Error, 2);
                return;
            }



            try
            {
                MonHocBindingSource.EndEdit();

                MonHocBindingSource.ResetCurrentItem();
                this.MonHocTableAdapter.Update(this.TN_CSDLPTDataSet.MONHOC);
                if (_state == State.Edit)
                    Utils.ShowMessage("Sửa môn học thành công", Others.NotiForm.FormType.Success, 1);
                else if (_state == State.Add)
                    Utils.ShowMessage("Thêm môn học thành công", Others.NotiForm.FormType.Success, 1);
                _state = State.Idle;

                Utils.ConfigInfoPanelAppearance(InfoPanel, "Thông tin môn học", Utils.DisabledColor);
                ClearErrors();

            }
            catch (Exception ex)
            {
                Utils.ShowErrorMessage("Không thể lưu môn học, xin vui lòng thử lại sau\n" + ex.Message, "Lỗi ghi môn học");
                return;
            }

            ConfigIdleState();
        }

        private void FormMonHoc_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_state != State.Idle)
                if (!Utils.ShowConfirmMessage("Hủy những thay đổi đang thực hiện và đóng cửa sổ này?", "Xác nhận"))
                    e.Cancel = true;
        }

        private void ImageBook_EnabledChanged(object sender, EventArgs e)
        {
            if (ImageBook.Enabled)
            {
                this.ImageBook.Image = global::TracNghiemCSDLPT.Properties.Resources.book_500px;
            }
            else
            {
                this.ImageBook.Image = global::TracNghiemCSDLPT.Properties.Resources.book_500px_disabled;
            }
        }
        private void ClearErrors()
        {
            Utils.SetTextEditError(MaMHEP, TextMaMH, null);
            Utils.SetTextEditError(TenMHEP, TextTenMH, null);
        }

        private Color GetCorrColor()
        {
            switch (_state)
            {
                case State.Add:
                    return Utils.AddColor;
                case State.Edit:
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