﻿using DevExpress.XtraEditors;
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
namespace TracNghiemCSDLPT.Views
{
    public partial class FormMonHoc : DevExpress.XtraEditors.XtraForm
    {
        int selectedRow = 0;

        public FormMonHoc()
        {
            InitializeComponent();
            //if (MonHocBindingSouce.Count == 0)
            //    buttonXoa.Enabled = false;
            if (MonHocBindingSource.Count == 0)
                buttonXoa.Enabled = false;
        }


        Color ActiveForeColor = Color.FromArgb(72, 70, 68);
        Color DisabledForeColor = SystemColors.AppWorkspace;
        State state = State.idle;
        string origMaMH;
        string origTenMH;
        enum State
        {
            add, edit, idle
        }
        private void MonHoc_Load(object sender, EventArgs e)
        {
            this.TN_CSDLPTDataSet.EnforceConstraints = false;//phải có dòng này, nếu không khi refresh sẽ ko cho, do môn học là khóa chính, đã trỏ ra các bảng khác
            this.MonHocTableAdapter.Connection.ConnectionString = DBConnection.SubcriberConnectionString;
            this.BoDeTableAdapter.Connection.ConnectionString = DBConnection.SubcriberConnectionString;
            this.GV_DKTableAdapter.Connection.ConnectionString = DBConnection.SubcriberConnectionString;
            this.BangDiemTableAdapter.Connection.ConnectionString = DBConnection.SubcriberConnectionString;

            this.MonHocTableAdapter.Fill(this.TN_CSDLPTDataSet.MONHOC);
            this.BoDeTableAdapter.Fill(this.TN_CSDLPTDataSet.BODE);
            this.GV_DKTableAdapter.Fill(this.TN_CSDLPTDataSet.GIAOVIEN_DANGKY);
            this.BangDiemTableAdapter.Fill(this.TN_CSDLPTDataSet.BANGDIEM);
        }

        private void SetIdleButtonEnabled(bool state)
        {
            buttonThem.Enabled = buttonLamMoi.Enabled = buttonXoa.Enabled =
                 buttonSua.Enabled = state;
        }
        private void SetInputButtonEnabled(bool state)
        {
            buttonUndo.Visible = buttonRedo.Visible =
                buttonHuy.Visible = buttonXacNhan.Visible = state;
        }


        private void buttonThem_Click(object sender, EventArgs e)
        {
            selectedRow = MonHocBindingSource.Position;
            InfoPanel.Enabled = true;
            InfoPanel.ForeColor = TextMaMH.ForeColor =
                TextTenMH.ForeColor = ActiveForeColor;

            InfoPanel.Text = "Thêm mới thông tin môn học";

            SetIdleButtonEnabled(false);
            SetInputButtonEnabled(true);

            MonHocGridControl.Enabled = false;
            state = State.add;
            MonHocBindingSource.AddNew();
        }

        private void buttonHuy_Click(object sender, EventArgs e)
        {
            InfoPanel.Enabled = false;
            InfoPanel.ForeColor = TextMaMH.ForeColor =
                TextTenMH.ForeColor = DisabledForeColor;
            MonHocGridControl.Enabled = true;
            MonHocBindingSource.CancelEdit();
            InfoPanel.Text = "Thông tin môn học";
            if (state == State.add)
                MonHocBindingSource.Position = selectedRow;
            SetIdleButtonEnabled(true);
            SetInputButtonEnabled(false);
            Utils.SetTextEditError(TenMHEP, TextTenMH, null);
            Utils.SetTextEditError(MaMHEP, TextMaMH, null);

        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            InfoPanel.Enabled = true;
            InfoPanel.ForeColor = TextMaMH.ForeColor =
                TextTenMH.ForeColor = ActiveForeColor;

            InfoPanel.Text = "Sửa thông tin môn học";

            SetIdleButtonEnabled(false);
            SetInputButtonEnabled(true);

            origMaMH = TextMaMH.Text.Trim();
            origTenMH = Utils.CapitalizeString(TextTenMH.Text, Utils.CapitalMode.FirstWordOnly);
            MonHocGridControl.Enabled = false;
            state = State.edit;
        }

        private void buttonLamMoi_Click(object sender, EventArgs e)
        {
            try
            {
                this.MonHocTableAdapter.Connection.ConnectionString = DBConnection.SubcriberConnectionString;
                this.MonHocTableAdapter.Fill(this.TN_CSDLPTDataSet.MONHOC);
                Utils.ShowMessage("Làm mới thành công", Others.NotiForm.FormType.Success, 1);
            }
            catch (Exception ex)
            {
                Utils.ShowMessage("Lỗi khi tải lại dữ liệu", Others.NotiForm.FormType.Error, 1);
                Console.WriteLine(ex.StackTrace);
                return;
            }
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            string RemovedMH = "";
            selectedRow = MonHocBindingSource.Position;
            if (BoDeBindingSource.Count > 0)
            {
                Utils.ShowMessage("Không thể xóa vì đã có câu hỏi thuộc môn học này", Others.NotiForm.FormType.Error, 2);
                return;
            }
            if (GV_DKBindingSource.Count > 0)
            {
                Utils.ShowMessage("Không thể xóa vì đã có giảng viên đăng ký thi môn học này", Others.NotiForm.FormType.Error, 4);
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
                    RemovedMH = ((DataRowView)MonHocBindingSource[selectedRow])["MAMH"].ToString();
                    MonHocBindingSource.RemoveCurrent();
                    MonHocTableAdapter.Update(TN_CSDLPTDataSet.MONHOC);
                    Utils.ShowMessage("Xóa môn học thành công!", Others.NotiForm.FormType.Success, 1);
                }
                catch (Exception ex)
                {
                    Utils.ShowErrorMessage("Không thể xóa nhân viên, xin vui lòng thử lại sau\n" + ex.Message, "Lỗi xóa nhân viên");
                    Console.WriteLine(ex.StackTrace);
                    this.MonHocTableAdapter.Fill(TN_CSDLPTDataSet.MONHOC);
                    MonHocBindingSource.Position = MonHocBindingSource.Find("MAMH", RemovedMH);
                    return;
                }
            }

            if (MonHocBindingSource.Count == 0)
                buttonXoa.Enabled = false;
        }

        private bool AlreadyExists(string testName, bool isID)
        {
            string query = "EXEC usp_MonHoc_GetInfoByXXX '" + testName + "'";
            if (isID)
                query = query.Replace("XXX", "ID");
            else query = query.Replace("XXX", "Name");
            SqlDataReader myReader = DBConnection.ExecuteSqlDataReader(query);
            if (myReader == null)
            {
                Utils.ShowMessage("Xảy ra lỗi không xác định", Others.NotiForm.FormType.Error, 1);
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
        private void buttonXacNhan_Click(object sender, EventArgs e)
        {
            TextMaMH.Text = TextMaMH.Text.Trim();
            TextTenMH.Text = Utils.CapitalizeString
                (TextTenMH.Text, Utils.CapitalMode.FirstWordOnly);
            bool test1 = string.IsNullOrEmpty(TextMaMH.Text);
            bool test2 = string.IsNullOrEmpty(TextTenMH.Text);
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
            if (TextMaMH.Text.Length > 5)
            {
                Utils.ShowMessage("Mã môn học không được quá 5 ký tự", Others.NotiForm.FormType.Warning, 2);
                Utils.SetTextEditError(MaMHEP, TextMaMH, "Mã môn học không được quá 5 ký tự");
                return;
            }
            test1 = test2 = false;
            if (!origMaMH.ToLower().Equals(TextMaMH.Text.ToLower()))
                test1 = AlreadyExists(TextMaMH.Text, true);

            if (!origTenMH.ToLower().Equals(TextTenMH.Text.ToLower()))
                test2 = AlreadyExists(TextTenMH.Text, false);


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
                if (state == State.edit)
                    Utils.ShowMessage("Sửa môn học thành công", Others.NotiForm.FormType.Success, 1);
                else if (state == State.add)
                    Utils.ShowMessage("Thêm môn học thành công", Others.NotiForm.FormType.Success, 1);
                state = State.idle;

                InfoPanel.Text = "Thông tin môn học";
                Utils.SetTextEditError(MaMHEP, TextMaMH, null);
                Utils.SetTextEditError(TenMHEP, TextTenMH, null);

            }
            catch (Exception ex)
            {
                Utils.ShowErrorMessage("Không thể lưu môn học, xin vui lòng thử lại sau\n" + ex.Message, "Lỗi ghi nhân viên");
                return;
            }
            MonHocGridControl.Enabled = true;
            InfoPanel.Enabled = false;
            InfoPanel.ForeColor = TextMaMH.ForeColor =
                TextTenMH.ForeColor = DisabledForeColor;
            SetIdleButtonEnabled(true);
            SetInputButtonEnabled(false);
        }
    }
}