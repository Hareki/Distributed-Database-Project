using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using TracNghiemCSDLPT.Others;

namespace TracNghiemCSDLPT.MyForms.Thi
{
    public partial class FormDKThi : DevExpress.XtraEditors.XtraForm
    {
        public FormDKThi()
        {
            InitializeComponent();
        }
        private int selectedRow;
        enum State
        {
            idle, edit, add
        }
        private State state = State.idle;
        readonly Color ActiveForeColor = Color.FromArgb(72, 70, 68);
        readonly Color DisabledForeColor = SystemColors.AppWorkspace;
        private int PreviousIndexCS;
        private string origMaMH = "!@#$%";
        private string origMaLop = "!@#$%";
        private int origLan = -1;

        private void SetInputButtonEnabled(bool state)
        {
            buttonHuy.Visible = buttonXacNhan.Visible = state;
        }
        private void LoadData()
        {
            this.GVDK2TableAdapter.Connection.ConnectionString = DBConnection.SubcriberConnectionString;
            this.LopTableAdapter.Connection.ConnectionString = DBConnection.SubcriberConnectionString;
            this.MonHocTableAdapter.Connection.ConnectionString = DBConnection.SubcriberConnectionString;
            this.DSGVTableAdapter.Connection.ConnectionString = DBConnection.SubcriberConnectionString;
            this.SVTableAdapter.Connection.ConnectionString = DBConnection.SubcriberConnectionString;

            this.GVDK2TableAdapter.Fill(this.TN_CSDLPTDataSet.GVDK_ENDUSER);
            this.LopTableAdapter.Fill(this.TN_CSDLPTDataSet.LOP);
            this.MonHocTableAdapter.Fill(this.TN_CSDLPTDataSet.MONHOC);
            this.DSGVTableAdapter.Fill(this.TN_CSDLPTDataSet.DSGIAOVIEN);
            this.SVTableAdapter.Fill(this.TN_CSDLPTDataSet.SINHVIEN);

        }
        private void SetOrigDefaultValue()
        {
            origMaMH = "!@#$%";
            origMaLop = "!@#$%";
            origLan = -1;
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
            LoadData();
            LookUpGV.Properties.DataSource = DSGVBindingSource;
            LookUpGV.Properties.DisplayMember = "FullInfo";
            LookUpGV.Properties.ValueMember = "MaGV";

            MHCombo.DisplayMember = "TENMH";
            MHCombo.ValueMember = "MAMH";

            LopCombo.DisplayMember = "TENLOP";
            LopCombo.ValueMember = "MALOP";

            this.CoSoComboBox.DataSource = DBConnection.BS_Subcribers;
            this.CoSoComboBox.DisplayMember = "TENCS";
            this.CoSoComboBox.ValueMember = "TENSERVER";
            this.CoSoComboBox.SelectedIndex = DBConnection.IndexCS;
            this.PreviousIndexCS = this.CoSoComboBox.SelectedIndex;

            NgayThi.Value = NgayThi.Value.AddDays(1);
            PhanQuyen();


        }

        private void pictureBox1_EnabledChanged(object sender, EventArgs e)
        {
            if (pictureBox1.Enabled)
            {
                pictureBox1.Image = global::TracNghiemCSDLPT.Properties.Resources.note;
            }
            else
            {
                pictureBox1.Image = global::TracNghiemCSDLPT.Properties.Resources.note_disabled;
            }
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            selectedRow = GVDK2BindingSource.Position;
            InfoPanel.Enabled = true;
            InfoPanel.ForeColor = LookUpGV.ForeColor =
                LopCombo.ForeColor = MHCombo.ForeColor = ActiveForeColor;

            InfoPanel.Text = "Thêm thông tin đăng ký thi";

            SetIdleButtonEnabled(false);
            SetInputButtonEnabled(true);

            GVDK2GridControl.Enabled = false;
            state = State.add;
        }
        private void ClearErrors()
        {
            GVEP.SetError(LookUpGV, null);
            TrinhDoEP.SetError(panelTrinhDo, null);
            LanEP.SetError(panelLan, null);
            SoCauEP.SetError(labelCau, null);
            ThoiGianEP.SetError(labelPhut, null);
        }
        private void buttonHuy_Click(object sender, EventArgs e)
        {
            InfoPanel.Enabled = false;
            InfoPanel.ForeColor = LookUpGV.ForeColor =
                LopCombo.ForeColor = MHCombo.ForeColor = DisabledForeColor;
            GVDK2GridControl.Enabled = true;
            //GVDK2BindingSource.CancelEdit();
            InfoPanel.Text = "Thông tin đăng ký trắc nghiệm";
            if (state == State.add)
                GVDK2BindingSource.Position = selectedRow;
            SetIdleButtonEnabled(true);
            SetInputButtonEnabled(false);
            ClearErrors();
            SetOrigDefaultValue();
            state = State.idle;
        }

        private void buttonLamMoi_Click(object sender, EventArgs e)
        {
            try
            {
                LoadData();
                Utils.ShowMessage("Làm mới thành công", Others.NotiForm.FormType.Success, 1);

                // checkButtonState();
            }
            catch (Exception ex)
            {
                Utils.ShowMessage("Lỗi khi tải lại dữ liệu", Others.NotiForm.FormType.Error, 1);
                Console.WriteLine(ex.StackTrace);
                return;
            }
        }

        private string getTrinhDo()
        {
            if (rdoA.Checked) return "A";
            else if (rdoB.Checked) return "B";
            else if (rdoC.Checked) return "C";
            else return null;
        }
        private int getLan()
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
                this.CoSoComboBox.SelectedIndex = this.PreviousIndexCS;
                return;
            }
            else
            {
                LoadData();
                this.PreviousIndexCS = this.CoSoComboBox.SelectedIndex;
            }
        }

        private bool AlreadyExistsDKT(string maMH, string maLop, int lan)
        {
            List<Para> paraList = new List<Para>();
            paraList.Add(new Para("@MaMH", maMH));
            paraList.Add(new Para("@MaLop", maLop));
            paraList.Add(new Para("@Lan", lan));
            string SPName = "usp_GVDK_GetInfoByIDs";
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

        private void buttonXacNhan_Click(object sender, EventArgs e)
        {
            bool test1 = LookUpGV.EditValue is null;
            bool test2 = !rdoA.Checked && !rdoB.Checked && !rdoC.Checked;
            bool test3 = !rdo1.Checked && !rdo2.Checked;
            bool test4 = spinSoCau.Value < 10 || spinSoCau.Value > 100;
            bool test5 = spinThoiGian.Value < 15 || spinSoCau.Value > 60;
            if (test1 || test2 || test3 || test4 || test5)
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
                Utils.ShowMessage("Vui lòng xem lại thông tin đã nhập", Others.NotiForm.FormType.Error, 2);
                return;
            }
            string maGV = (LookUpGV.GetSelectedDataRow() as DataRowView)["MaGV"].ToString();
            string maMH = MHCombo.SelectedValue.ToString();
            string maLop = LopCombo.SelectedValue.ToString();
            string trinhDo = getTrinhDo();
            string ngayThi = NgayThi.Value.ToString("dd/MM/yyyy");
            int lan = getLan();
            int soCau = (int)spinSoCau.Value;
            int thoiGian = (int)spinThoiGian.Value;

            bool testMH = !origMaMH.ToLower().Equals(maMH.ToLower());
            bool testLop = !origMaLop.ToLower().Equals(maLop.ToLower());
            bool testLan = lan != origLan;


            if (testMH || testLop || testLan)
            {
                if (AlreadyExistsDKT(maMH, maLop, lan))
                {
                    SetOrigDefaultValue();
                    Utils.ShowMessage("Thông tin này đăng ký đã tồn tại", Others.NotiForm.FormType.Error, 2);
                    return;
                }
            }
            LopBindingSource.Position = LopBindingSource.Find("MALOP", maLop);
            if (SVBindingSource.Count == 0)
            {
                SetOrigDefaultValue();
                Utils.ShowMessage("Lớp không có sinh viên nào, không thể đăng ký thi", Others.NotiForm.FormType.Error, 2);
                return;
            }


            List<Para> paraList = new List<Para>();
            paraList.Add(new Para("@MaGV", maGV));
            paraList.Add(new Para("@MaMH", maMH));
            paraList.Add(new Para("@MaLop", maLop));
            paraList.Add(new Para("@TrinhDo", trinhDo));
            paraList.Add(new Para("@NgayThi", ngayThi));
            paraList.Add(new Para("@Lan", lan));
            paraList.Add(new Para("@SoCauThi", soCau));
            paraList.Add(new Para("@ThoiGian", thoiGian));
            if (state == State.add)
            {
                string SPName = "usp_GVDK_AddRecord";
                SqlDataReader myReader = DBConnection.ExecuteSqlDataReaderSP(SPName, paraList);
                if (myReader == null)
                {
                    // Console.WriteLine(System.Environment.StackTrace);
                    return;
                }
                Utils.ShowMessage("Thêm thông tin đăng ký thi thành công", Others.NotiForm.FormType.Success, 2);
            }
            else if (state == State.edit)
            {
                paraList.Add(new Para("@OldMaMH", origMaMH));
                paraList.Add(new Para("@OldMaLop", origMaLop));
                paraList.Add(new Para("@OldLan", origLan));
                string SPName = "usp_GVDK_UpdateRecord";
                SqlDataReader myReader = DBConnection.ExecuteSqlDataReaderSP(SPName, paraList);
                if (myReader == null)
                {
                    return;
                }
                Utils.ShowMessage("Sửa thông tin đăng ký thi thành công", Others.NotiForm.FormType.Success, 2);
            }
            //chưa làm load lại dữ liệu, đã thêm dc

        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            InfoPanel.Enabled = true;
            InfoPanel.Text = "Sửa thông tin đăng ký thi";
            SetIdleButtonEnabled(false);
            SetInputButtonEnabled(true);
            origMaLop = LopCombo.SelectedValue.ToString().Trim();
            origMaMH = MHCombo.SelectedValue.ToString().Trim();
            origLan = getLan();
            GVDK2GridControl.Enabled = false;
            state = State.edit;
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {

        }
    }
}