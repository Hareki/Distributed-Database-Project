using DevExpress.XtraGrid.Views.Grid;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using TracNghiemCSDLPT.Others;

namespace TracNghiemCSDLPT.MyForms.QuanLy
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

        private int origMaCH = -1;
        State state = State.idle;
        List<Guna2CustomRadioButton> rdoButtons = new List<Guna2CustomRadioButton>();
        private int selectedRow;
        private bool opened = false;
        private void SetIdleButtonEnabled(bool state)
        {
            buttonThem.Enabled = buttonXoa.Enabled =
                 buttonSua.Enabled = state;
            if (Utils.IsTruong() || Utils.isCoSo()) buttonLamMoi.Enabled = true;
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

        private void setDefaultOrigValue()
        {
            origMaCH = -1;
        }
        private void PhanQuyen()
        {
            switch (DBConnection.NhomQuyen)
            {
                case "TRUONG":
                    SetIdleButtonEnabled(false);
                    break;
                case "COSO":
                    SetIdleButtonEnabled(false);
                    break;
            }

        }

        private void loadAllData()
        {
            this.MonHocTableAdapter.Connection.ConnectionString = DBConnection.SubcriberConnectionString;
            this.BoDeTableAdapter.Connection.ConnectionString = DBConnection.SubcriberConnectionString;
            this.MH2TableAdapter.Connection.ConnectionString = DBConnection.SubcriberConnectionString;
            this.DSGVTCSTableAdapter.Connection.ConnectionString = DBConnection.SubcriberConnectionString;
            this.BaiThiTableAdapter.Connection.ConnectionString = DBConnection.SubcriberConnectionString;

            this.MonHocTableAdapter.Fill(this.TN_CSDLPTDataSet.MONHOC);
            this.BoDeTableAdapter.Fill(this.TN_CSDLPTDataSet.BODE);
            this.MH2TableAdapter.Fill(this.TN_CSDLPTDataSet.MONHOC2);
            this.DSGVTCSTableAdapter.Fill(this.TN_CSDLPTDataSet.DSGIAOVIENTCS);
            this.BaiThiTableAdapter.Fill(this.TN_CSDLPTDataSet.BAITHI);
        }

        private void FormCauHoi_Load(object sender, EventArgs e)
        {

            this.TN_CSDLPTDataSet.EnforceConstraints = false;
            loadAllData();

            MHCombo.DisplayMember = "TENMH";
            MHCombo.ValueMember = "MAMH";

            rdoButtons.Add(rdoDA_A);
            rdoButtons.Add(rdoDA_B);
            rdoButtons.Add(rdoDA_C);
            rdoButtons.Add(rdoDA_D);

            MonHocGridView.ExpandMasterRow(0);
            GridView view = GetCorrData(true);
            if (view != null)
                view.Focus();
            CheckButtonState();
            PhanQuyen();
        }

        private void BoDeGridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (!opened)
            {
                for (int i = 1; i < MonHocGridView.RowCount; i++)
                    MonHocGridView.ExpandMasterRow(i);
                opened = true;
            }
            GetCorrData(false);
        }

        private void UncheckOtherRDOs(Guna2CustomRadioButton button)
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


        private void FormCauHoi_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (state != State.idle)
                if (!Utils.ShowConfirmMessage("Hủy những thay đổi đang thực hiện và đóng cửa sổ này?", "Xác nhận"))
                    e.Cancel = true;
        }


        private GridView GetCorrData(bool getFirstRow)
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

            string maGV = ((DataRowView)BoDeBindingSource[BoDeBindingSource.Position])["MAGV"].ToString();
            DSGVTCSBindingSource.Position = DSGVTCSBindingSource.Find("MAGV", maGV);

            CheckButtonState();
            return detailView;

        }


        private void LabelDapAn_TextChanged(object sender, EventArgs e)
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
            Guna2CustomRadioButton rdoButton = (sender as Guna2CustomRadioButton);
            if (rdoButton.Checked)
            {
                if (rdoButton.Equals(rdoDA_A))
                {
                    UncheckOtherRDOs(rdoDA_A);
                    labelDapAn.Text = "A";
                }
                else if (rdoButton.Equals(rdoDA_B))
                {
                    UncheckOtherRDOs(rdoDA_B);
                    labelDapAn.Text = "B";
                }
                else if (rdoButton.Equals(rdoDA_C))
                {
                    UncheckOtherRDOs(rdoDA_C);
                    labelDapAn.Text = "C";
                }
                else if (rdoButton.Equals(rdoDA_D))
                {
                    UncheckOtherRDOs(rdoDA_D);
                    labelDapAn.Text = "D";
                }
            }


        }


        private void SetInputButtonEnabled(bool state)
        {
            panelInput.Visible = buttonXacNhan.Visible = buttonHuy.Visible = state;
        }
        private void buttonThem_Click(object sender, EventArgs e)
        {
            selectedRow = BoDeBindingSource.Position;
            InfoPanel.Enabled = true;


            SetIdleButtonEnabled(false);
            SetInputButtonEnabled(true);

            MonHocGridControl.Enabled = false;
            state = State.add;
            BoDeBindingSource.AddNew();
            labelGVSoan.Text = DBConnection.UserName + " - " + DBConnection.HoTen;
            rdoA.Checked = true;
            rdoDA_A.Checked = true;
            textMaCH.EditValue = 0;
        }

        private void CheckButtonState()
        {
            if (DBConnection.NhomQuyen.Equals("GIAOVIEN"))
            {
                string maGV = (BoDeBindingSource[BoDeBindingSource.Position] as DataRowView)["MAGV"].ToString();
                maGV = maGV.Trim();
                bool test1 = BoDeBindingSource.Count == 0;
                bool test2 = !maGV.Equals(DBConnection.UserName);
                if (test1 || test2)
                {
                    buttonXoa.Enabled = buttonSua.Enabled = false;
                    if (test2)
                    {
                        tipXoa.Visible = true;
                        tipSua.Visible = true;
                    }
                }
                else
                {
                    buttonXoa.Enabled = buttonSua.Enabled = true;
                    tipXoa.Visible = false;
                    tipSua.Visible = false;
                }
            }
        }



        private void buttonLamMoi_Click(object sender, EventArgs e)
        {
            try
            {
                loadAllData();
                CheckButtonState();
                Utils.ShowMessage("Làm mới thành công", Others.NotiForm.FormType.Success, 1);
            }
            catch (Exception ex)
            {
                Utils.ShowMessage("Lỗi khi tải lại dữ liệu", Others.NotiForm.FormType.Error, 1);
                Console.WriteLine(ex.StackTrace);
                return;
            }
        }

        private string trimText(Control textEdit)
        {
            textEdit.Text = textEdit.Text.Trim();
            return textEdit.Text;
        }

        private string getTrinhDo()
        {
            if (rdoA.Checked) return "A";
            else if (rdoB.Checked) return "B";
            else if (rdoC.Checked) return "C";
            else return null;
        }
        private SqlDataReader ExecuteIdCheck(int ID)
        {

            string SPName = "usp_BoDe_GetInfoByID";

            SqlDataReader result;
            SqlCommand sqlCmd = new SqlCommand(SPName, DBConnection.SubcriberConnection);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.Add(new SqlParameter("@ID", ID));

            if (DBConnection.SubcriberConnection.State == ConnectionState.Closed)
                DBConnection.SubcriberConnection.Open();
            try
            {
                result = sqlCmd.ExecuteReader();
                return result;
            }
            catch (SqlException ex)
            {
                DBConnection.SubcriberConnection.Close();
                Utils.ShowErrorMessage("Xảy ra lỗi" + ex.Message, "Lỗi kết nối");
                Console.WriteLine(ex.StackTrace);
                return null;
            }
        }
        private bool AlreadyExistsCH(int ID)
        {
            SqlDataReader myReader = ExecuteIdCheck(ID);
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

        private void GoToNewlyCreatedRowCH()
        {
            GridView detailView;
            int row = MonHocGridView.LocateByDisplayText(0, colMAMH, MHCombo.SelectedValue.ToString());

            MonHocGridView.FocusedRowHandle = row;
            MonHocGridView.Focus();
            MonHocGridView.ExpandMasterRow(row);
            detailView = MonHocGridView.GetDetailView(row, 1) as GridView;
            if (detailView is null)
            {
                Utils.ShowErrorMessage("Lỗi không xác định", "Lỗi");
                Console.WriteLine(System.Environment.StackTrace);
                return;
            }

            detailView.Focus();
            detailView.FocusedRowHandle = detailView.RowCount - 1;
            detailView.MakeRowVisible(detailView.RowCount - 1);

        }

        private void ClearError()
        {
            Utils.SetTextEditError(choiceAEP, textChoiceA, null);
            Utils.SetTextEditError(choiceBEP, textChoiceB, null);
            Utils.SetTextEditError(choiceCEP, textChoiceC, null);
            Utils.SetTextEditError(choiceDEP, textChoiceD, null);
            Utils.SetTextEditError(noiDungEP, textNoiDung, null);
            Utils.SetTextEditError(maCHEP, textMaCH, null);
        }
        private void buttonXacNhan_Click(object sender, EventArgs e)
        {
            bool test1 = string.IsNullOrEmpty(trimText(textChoiceA));
            bool test2 = string.IsNullOrEmpty(trimText(textChoiceB));
            bool test3 = string.IsNullOrEmpty(trimText(textChoiceC));
            bool test4 = string.IsNullOrEmpty(trimText(textChoiceD));
            bool test5 = string.IsNullOrEmpty(trimText(textNoiDung));
            bool test6 = string.IsNullOrEmpty(trimText(textMaCH));

            string maGV = labelGVSoan.Text.Split('-')[0].Trim();
            string maMH = MHCombo.SelectedValue.ToString();
            string trinhDo = getTrinhDo();

            bool test7 = false;
            if (!int.TryParse(textMaCH.Text, out int maCH))
            {
                test7 = true;
            }
            else if (maCH <= 0)
            {
                test7 = true;
            }


            if (test1 || test2 || test3 || test4 || test5 || test6 || test7)
            {
                if (test1)
                    Utils.SetTextEditError(choiceAEP, textChoiceA, "Vui lòng nhập lựa chọn A");
                else
                    Utils.SetTextEditError(choiceAEP, textChoiceA, null);
                if (test2)
                    Utils.SetTextEditError(choiceBEP, textChoiceB, "Vui lòng nhập lựa chọn B");
                else
                    Utils.SetTextEditError(choiceBEP, textChoiceB, null);
                if (test3)
                    Utils.SetTextEditError(choiceCEP, textChoiceC, "Vui lòng nhập lựa chọn C");
                else
                    Utils.SetTextEditError(choiceCEP, textChoiceC, null);
                if (test4)
                    Utils.SetTextEditError(choiceDEP, textChoiceD, "Vui lòng nhập lựa chọn D");
                else
                    Utils.SetTextEditError(choiceDEP, textChoiceD, null);
                if (test5)
                    Utils.SetTextEditError(noiDungEP, textNoiDung, "Vui lòng nhập nội dung câu hỏi");
                else
                    Utils.SetTextEditError(noiDungEP, textNoiDung, null);
                if (test6)
                    Utils.SetTextEditError(maCHEP, textMaCH, "Vui lòng nhập mã câu hỏi");
                else
                    Utils.SetTextEditError(maCHEP, textMaCH, null);
                if (test7)
                    Utils.SetTextEditError(maCHEP, textMaCH, "Vui lòng nhập mã câu hỏi là một số nguyên dương");
                else
                    Utils.SetTextEditError(maCHEP, textMaCH, null);
                Utils.ShowMessage("Vui lòng điền đầy đủ thông tin cần thiết", Others.NotiForm.FormType.Error, 2);
                return;
            }

            bool testMaCH = false;
            if (origMaCH != maCH)
                testMaCH = AlreadyExistsCH(maCH);

            if (testMaCH)
            {
                Utils.SetTextEditError(maCHEP, textMaCH, "Mã câu hỏi đã tồn tại");
                Utils.ShowMessage("Thông tin vừa nhập đã tồn tại", Others.NotiForm.FormType.Error, 2);
                return;
            }
            else
                Utils.SetTextEditError(maCHEP, textMaCH, null);


            try
            {
                ((DataRowView)BoDeBindingSource[BoDeBindingSource.Position])["MAGV"] = maGV;
                ((DataRowView)BoDeBindingSource[BoDeBindingSource.Position])["MAMH"] = maMH;
                ((DataRowView)BoDeBindingSource[BoDeBindingSource.Position])["TRINHDO"] = trinhDo;

                TN_CSDLPTDataSet.BODE.Columns[0].ReadOnly = false;
                ((DataRowView)BoDeBindingSource[BoDeBindingSource.Position])["CAUHOI"] = maCH;
                BoDeBindingSource.EndEdit();
                BoDeBindingSource.ResetCurrentItem();
                this.BoDeTableAdapter.Update(this.TN_CSDLPTDataSet.BODE);
                if (state == State.edit)
                    Utils.ShowMessage("Sửa thông tin câu hỏi thành công", Others.NotiForm.FormType.Success, 2);
                else if (state == State.add)
                {
                    GoToNewlyCreatedRowCH();
                    Utils.ShowMessage("Thêm câu hỏi thành công", Others.NotiForm.FormType.Success, 2);
                }


                state = State.idle;

                ClearError();


                CheckButtonState();
                setDefaultOrigValue();

            }
            catch (Exception ex)
            {
                Utils.ShowErrorMessage("Xảy ra lỗi\n" + ex.Message, "Lỗi");
                Console.WriteLine(ex.StackTrace);
                return;
            }
            MonHocGridControl.Enabled = true;


            InfoPanel.Enabled = false;
            SetIdleButtonEnabled(true);
            SetInputButtonEnabled(false);
        }

        private void BoDeBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            if (BoDeBindingSource.Position >= 0)
            {
                String trinhDo = ((DataRowView)BoDeBindingSource[BoDeBindingSource.Position])["TRINHDO"].ToString();
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

        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            InfoPanel.Enabled = true;

            SetIdleButtonEnabled(false);
            SetInputButtonEnabled(true);

            origMaCH = int.Parse(textMaCH.Text);
            MonHocGridControl.Enabled = false;
            state = State.edit;
        }

        private void buttonHuy_Click(object sender, EventArgs e)
        {
            InfoPanel.Enabled = false;


            MonHocGridControl.Enabled = true;
            setDefaultOrigValue();

            BoDeBindingSource.CancelEdit();
            if (state == State.add)
                BoDeBindingSource.Position = selectedRow;
            SetIdleButtonEnabled(true);
            SetInputButtonEnabled(false);
            state = State.idle;

            ClearError();
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {

            int RemoveCH = -100;
            selectedRow = BoDeBindingSource.Position;
            if (BaiThiBindingSource.Count > 0)
            {
                Utils.ShowMessage("Không thể xóa vì đã câu hỏi đã được sử dụng để thi", Others.NotiForm.FormType.Error, 2);
                return;
            }


            if (Utils.ShowConfirmMessage("Bạn có chắc muốn xóa câu hỏi này?", "Xác nhận"))
            {
                try
                {
                    RemoveCH = int.Parse(((DataRowView)BoDeBindingSource[selectedRow])["CAUHOI"].ToString());
                    BoDeBindingSource.RemoveCurrent();
                    BoDeTableAdapter.Update(TN_CSDLPTDataSet.BODE);
                    Utils.ShowMessage("Xóa câu hỏi " + RemoveCH + " thành công!", Others.NotiForm.FormType.Success, 1);
                }
                catch (Exception ex)
                {
                    Utils.ShowErrorMessage("Không thể xóa câu hỏi, xin vui lòng thử lại sau\n" + ex.Message, "Lỗi xóa câu hỏi");
                    Console.WriteLine(ex.StackTrace);
                    this.BoDeTableAdapter.Fill(TN_CSDLPTDataSet.BODE);
                    BoDeBindingSource.Position = BoDeBindingSource.Find("CAUHOI", RemoveCH);
                    return;
                }
            }
            CheckButtonState();
        }

        private void pictureBox1_EnabledChanged(object sender, EventArgs e)
        {
            if (pictureBox1.Enabled)
            {
                pictureBox1.Image = global::TracNghiemCSDLPT.Properties.Resources.info_480px;
            }
            else
            {
                pictureBox1.Image = global::TracNghiemCSDLPT.Properties.Resources.info_480px_disabled;
            }
        }

        private void buttonXoa_EnabledChanged(object sender, EventArgs e)
        {
            if (buttonXoa.Enabled)
                toolTip2.SetToolTip(buttonXoa, "Không thể xóa câu hỏi của giảng viên khác!");
            else
                toolTip2.SetToolTip(buttonXoa, null);
        }

        private void buttonSua_EnabledChanged(object sender, EventArgs e)
        {
            if (buttonSua.Enabled)
                toolTip2.SetToolTip(buttonSua, "Không thể sửa câu hỏi của giảng viên khác!");
            else
                toolTip2.SetToolTip(buttonSua, null);
        }


    }
}