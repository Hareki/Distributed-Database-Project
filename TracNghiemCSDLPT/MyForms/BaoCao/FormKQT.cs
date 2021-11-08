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
using TracNghiemCSDLPT.Others;

namespace TracNghiemCSDLPT.MyForms.BaoCao
{
    public partial class FormKQT : DevExpress.XtraEditors.XtraForm
    {
        private int _previousIndexCS;
        public FormKQT()
        {
            InitializeComponent();

            this.CoSoComboBox.DataSource = DBConnection.BsSubcribers;
            this.CoSoComboBox.DisplayMember = "TENCS";
            this.CoSoComboBox.ValueMember = "TENSERVER";
            this.CoSoComboBox.SelectedIndex = DBConnection.IndexCS;
            this._previousIndexCS = this.CoSoComboBox.SelectedIndex;
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
                this.CoSoComboBox.SelectedIndex = this._previousIndexCS;
                return;
            }
            else
            {
                this._previousIndexCS = this.CoSoComboBox.SelectedIndex;
            }
        }

        private void FormKQT_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tN_CSDLPTDataSet.DSMONHOC' table. You can move, or remove it, as needed.
            this.DSMHTableAdapter.Fill(this.TN_CSDLPTDataSet.DSMONHOC);
            // TODO: This line of code loads data into the 'tN_CSDLPTDataSet.DSSINHVIEN' table. You can move, or remove it, as needed.
            this.DSSVTableAdapter.Fill(this.TN_CSDLPTDataSet.DSSINHVIEN);

        }
    }
}