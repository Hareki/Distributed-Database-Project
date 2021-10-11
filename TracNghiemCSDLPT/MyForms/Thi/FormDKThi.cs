using System;
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

            this.GVDK2TableAdapter.Fill(this.TN_CSDLPTDataSet.GVDK_ENDUSER);
            this.LopTableAdapter.Fill(this.TN_CSDLPTDataSet.LOP);
            this.MonHocTableAdapter.Fill(this.TN_CSDLPTDataSet.MONHOC);
            this.DSGVTableAdapter.Fill(this.TN_CSDLPTDataSet.DSGIAOVIEN);

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
            LookUpGV.Properties.DisplayMember = "FullInfo";
            LookUpGV.Properties.ValueMember = "MaGV";

            MHCombo.DisplayMember = "TENMH";
            MHCombo.ValueMember = "MAMH";

            LopCombo.DisplayMember = "TENLOP";
            LopCombo.ValueMember = "MALOP";

            this.CoSoComboBox.SelectedIndex = DBConnection.IndexCS;
            this.PreviousIndexCS = this.CoSoComboBox.SelectedIndex;

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
            //Utils.SetTextEditError(TenMHEP, TextTenMH, null);
            //Utils.SetTextEditError(MaMHEP, TextMaMH, null);
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
    }
}