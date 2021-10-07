using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using Guna.UI2.WinForms;
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

namespace TracNghiemCSDLPT.MyForms.TabbedForms
{
    public partial class FormCauHoi : DevExpress.XtraEditors.XtraForm
    {
        public FormCauHoi()
        {
            InitializeComponent();

        }
        enum State
        {
            add, edit, idle
        }
        State state = State.idle;
        List<Guna2CustomRadioButton> rdoButtons = new List<Guna2CustomRadioButton>();
        private void SetIdleButtonEnabled(bool state)
        {
            buttonThem.Enabled = buttonXoa.Enabled =
                 buttonSua.Enabled = state;
            if (Utils.IsTruong()) buttonLamMoi.Enabled = true;
            else buttonLamMoi.Enabled = state;
        }

        private void PhanQuyen()
        {
            switch (DBConnection.NhomQuyen)
            {
                case "TRUONG":
                    SetIdleButtonEnabled(false);
                    break;
            }

        }

        private void FormCauHoi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'TN_CSDLPTDataSet.MONHOC2' table. You can move, or remove it, as needed.
            this.MH2TableAdapter.Fill(this.TN_CSDLPTDataSet.MONHOC2);

            this.MonHocTableAdapter.Connection.ConnectionString = DBConnection.SubcriberConnectionString;
            this.BoDeTableAdapter.Connection.ConnectionString = DBConnection.SubcriberConnectionString;

            this.MonHocTableAdapter.Fill(this.TN_CSDLPTDataSet.MONHOC);
            this.BoDeTableAdapter.Fill(this.TN_CSDLPTDataSet.BODE);

            MHCombo.DisplayMember = "TENMH";
            MHCombo.ValueMember = "MAMH";


            rdoButtons.Add(rdoDA_A);
            rdoButtons.Add(rdoDA_B);
            rdoButtons.Add(rdoDA_C);
            rdoButtons.Add(rdoDA_D);
            PhanQuyen();
        }

        private void uncheckOtherRDOs(Guna2CustomRadioButton button)
        {
            foreach (Guna2CustomRadioButton element in rdoButtons)
            {
                if (!element.Equals(button))
                {
                    element.Checked = false;
                }
            }
        }

        private void MonHocGridView_MasterRowGetRelationDisplayCaption(object sender, MasterRowGetRelationNameEventArgs e)
        {
            GridView view = sender as GridView;
            if (view is null) return;
            string tenMon = (string)view.GetRowCellValue(e.RowHandle, colTENMH); ;
            if (e.RelationIndex == 1)
                e.RelationName = $"Câu hỏi thuộc môn {tenMon}";
        }

        private void MonHocGridView_DetailTabStyle(object sender, DetailTabStyleEventArgs e)
        {
            e.Appearance.Header.Font = new Font("Baloo 2", 10.0F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void bunifuPanel1_Click(object sender, EventArgs e)
        {

        }

        private void FormCauHoi_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (state != State.idle)
                if (!Utils.ShowConfirmMessage("Hủy những thay đổi đang thực hiện và đóng cửa sổ này?", "Xác nhận"))
                    e.Cancel = true;
        }

        private void MonHocGridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {

        }

        private GridView getCorrTextBoxData(bool getFirstRow)
        {
            GridView detailView;
            if (getFirstRow)
                detailView = MonHocGridView.GetDetailView(0, 1) as GridView;
            else
            {
                int row = MonHocGridView.GetSelectedRows()[0];
                detailView = MonHocGridView.GetDetailView(row, 1) as GridView;
            }
            if (detailView is null) return null;
            Object test = (detailView as GridView).GetFocusedRowCellValue(colCAUHOI);
            string MaCauHoi;
            if (test != null)
                MaCauHoi = test.ToString();
            else return null;
            BoDeBindingSource.Position = BoDeBindingSource.Find("CAUHOI", MaCauHoi);
            
            string maMH = ((DataRowView)BoDeBindingSource[BoDeBindingSource.Position])["MAMH"].ToString();
            MH2BindingSource.Position = MH2BindingSource.Find("MAMH", maMH);
            return detailView;

        }

        private void BoDeGridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            getCorrTextBoxData(false);
        }

        private void tRINHDOTextEdit_EditValueChanged(object sender, EventArgs e)
        {
            String trinhDo = TextTrinhDo.EditValue.ToString();
            switch (trinhDo)
            {
                case "A":
                    rdoA.Checked = true;
                    break;
                case "B":
                    rdoB.Checked = true;
                    break;
                case "C":
                    rdoC.Checked = true;
                    break;
            }
        }

        private void labelDapAn_TextChanged(object sender, EventArgs e)
        {
            switch (labelDapAn.Text)
            {
                case "A":
                    rdoDA_A.Checked = true;
                    break;
                case "B":
                    rdoDA_B.Checked = true;
                    break;
                case "C":
                    rdoDA_C.Checked = true;
                    break;
                case "D":
                    rdoDA_D.Checked = true;
                    break;
            }
        }

        private void rdoDA_A_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoDA_A.Checked)
                uncheckOtherRDOs(rdoDA_A);
        }

        private void rdoDA_C_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoDA_C.Checked)
                uncheckOtherRDOs(rdoDA_C);
        }

        private void rdoDA_B_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoDA_B.Checked)
                uncheckOtherRDOs(rdoDA_B);
        }

        private void rdoDA_D_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoDA_D.Checked)
                uncheckOtherRDOs(rdoDA_D);
        }
    }
}