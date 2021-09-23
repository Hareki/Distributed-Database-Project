using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TracNghiemCSDLPT.SQL_Connection;
namespace TracNghiemCSDLPT.Views
{
    public partial class MonHoc : DevExpress.XtraEditors.XtraForm
    {
        int selectedRow = 0;

        public MonHoc()
        {
            InitializeComponent();

            //if (MonHocBindingSouce.Count == 0)
            //    buttonXoa.Enabled = false;
        }


        Color ActiveForeColor = Color.FromArgb(72, 70, 68);
        Color DisabledForeColor = SystemColors.AppWorkspace;
        State state = State.idle;
        enum State
        {
            add, edit, idle
        }
        private void MonHoc_Load(object sender, EventArgs e)
        {
            //TN_CSDLPTDataSet.EnforceConstraints = false;
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
            selectedRow = MonHocBindingSouce.Position;
            InfoPanel.Enabled = true;
            InfoPanel.ForeColor = TextMaMH.ForeColor =
                TextTenMH.ForeColor = ActiveForeColor;

            InfoPanel.Text = "Thêm mới thông tin môn học";

            SetIdleButtonEnabled(false);
            SetInputButtonEnabled(true);

            MonHocGridControl.Enabled = false;
            state = State.add;
            MonHocBindingSouce.AddNew();
        }

        private void buttonHuy_Click(object sender, EventArgs e)
        {
            InfoPanel.Enabled = false;
            MonHocGridControl.Enabled = true;
            MonHocBindingSouce.CancelEdit();
            InfoPanel.Text = "Thông tin môn học";
            if (state == State.add)
                MonHocBindingSouce.Position = selectedRow;
            SetIdleButtonEnabled(true);
            SetInputButtonEnabled(false);

            InfoPanel.Text = "Thông tin môn học";
            TenMHEP.SetError(TextTenMH, null);
            this.TextTenMH.Properties.Appearance.BorderColor = Color.Silver;
            MaMHEP.SetError(TextMaMH, null);
            this.TextMaMH.Properties.Appearance.BorderColor = Color.Silver;
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            InfoPanel.Enabled = true;
            InfoPanel.ForeColor = TextMaMH.ForeColor =
                TextTenMH.ForeColor = ActiveForeColor;

            InfoPanel.Text = "Sửa thông tin môn học";

            SetIdleButtonEnabled(false);
            SetInputButtonEnabled(true);

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
            selectedRow = MonHocBindingSouce.Position;
            if (BoDeBindingSouce.Count > 0)
            {
                Utils.ShowMessage("Không thể xóa vì đã có câu hỏi thuộc môn học này", Others.NotiForm.FormType.Error, 2);
                return;
            }
            if (GV_DKBindingSource.Count > 0)
            {
                Utils.ShowMessage("Không thể xóa vì đã có giảng viên đăng ký thi môn học này", Others.NotiForm.FormType.Error, 4);
                return;
            }
            if (GV_DKBindingSource.Count > 0)
            {
                Utils.ShowMessage("Không thể xóa vì đã có sinh viên thi môn học này", Others.NotiForm.FormType.Error, 4);
                return;
            }
            if (Utils.ShowConfirmMessage("Bạn có chắc muốn xóa môn học này?", "Xác nhận"))
            {
                try
                {
                    RemovedMH = ((DataRowView)MonHocBindingSouce[selectedRow])["MAMH"].ToString();
                    MonHocBindingSouce.RemoveCurrent();
                    MonHocTableAdapter.Update(TN_CSDLPTDataSet.MONHOC);
                    Utils.ShowMessage("Xóa môn học thành công!", Others.NotiForm.FormType.Success, 1);
                }
                catch (Exception ex)
                {
                    Utils.ShowErrorMessage("Không thể xóa nhân viên, xin vui lòng thử lại sau\n" + ex.Message, "Lỗi xóa nhân viên");
                    Console.WriteLine(ex.StackTrace);
                    this.MonHocTableAdapter.Fill(TN_CSDLPTDataSet.MONHOC);
                    MonHocBindingSouce.Position = MonHocBindingSouce.Find("MAMH", RemovedMH);
                    return;
                }
            }

            if (MonHocBindingSouce.Count == 0)
                buttonXoa.Enabled = false;
        }

        private void buttonXacNhan_Click(object sender, EventArgs e)
        {
            TextMaMH.Text = Utils.CapitalizeString
                (TextMaMH.Text, Utils.CapitalMode.FirstWordOnly);
            TextTenMH.Text = Utils.CapitalizeString
                (TextTenMH.Text, Utils.CapitalMode.FirstWordOnly);
            bool test1 = string.IsNullOrEmpty(TextMaMH.Text);
            bool test2 = string.IsNullOrEmpty(TextTenMH.Text);
            if (test1 || test2)
            {
                if (test1)
                {
                    MaMHEP.SetError(TextMaMH, "Vui lòng nhập mã môn học");
                    this.TextMaMH.Properties.Appearance.BorderColor = Color.Red;
                }

                if (test2)
                {
                    TenMHEP.SetError(TextTenMH, "Vui lòng nhập tên môn học");
                    this.TextTenMH.Properties.Appearance.BorderColor = Color.Red;
                }


                Utils.ShowMessage("Vui lòng điền đầy đủ thông tin cần thiết", Others.NotiForm.FormType.Error, 2);
                return;
            }
            if (TextMaMH.Text.Length > 5)
            {
                Utils.ShowMessage("Mã môn học không được quá 5 ký tự", Others.NotiForm.FormType.Warning, 1);
                MaMHEP.SetError(TextMaMH, "Mã môn học không được quá 5 ký tự");
                return;
            }
            string MaMH = ((DataRowView)MonHocBindingSouce[selectedRow])["MAMH"].ToString();
            int index = MonHocBindingSouce.Find("MaMH", MaMH);
            if (index != -1)
            {
                if (state == State.add || (state == State.edit && index != MonHocBindingSouce.Position))
                {
                    Utils.ShowMessage("Mã môn học đã tồn tại", Others.NotiForm.FormType.Warning, 1);
                    MaMHEP.SetError(TextMaMH, "Mã môn học đã tồn tại");
                    return;
                }

            }
            try
            {
                MonHocBindingSouce.EndEdit();
                MonHocBindingSouce.ResetCurrentItem();
                this.MonHocTableAdapter.Update(this.TN_CSDLPTDataSet.MONHOC);
                if (state == State.edit)
                    Utils.ShowMessage("Sửa môn học thành công", Others.NotiForm.FormType.Success, 1);
                else if (state == State.add)
                    Utils.ShowMessage("Thêm môn học thành công", Others.NotiForm.FormType.Success, 1);
                state = State.idle;

                InfoPanel.Text = "Thông tin môn học";
                TenMHEP.SetError(TextTenMH, null);
                this.TextTenMH.Properties.Appearance.BorderColor = Color.Silver;
                MaMHEP.SetError(TextMaMH, null);
                this.TextMaMH.Properties.Appearance.BorderColor = Color.Silver;

            }
            catch (Exception ex)
            {
                Utils.ShowErrorMessage("Không thể ghi nhân viên, xin vui lòng thử lại sau\n" + ex.Message, "Lỗi xóa nhân viên");
                return;
            }
            MonHocGridControl.Enabled = true;
            InfoPanel.Enabled = false;
            SetIdleButtonEnabled(true);
            SetInputButtonEnabled(false);


        }
    }
}