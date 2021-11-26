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
            Add, Edit, Idle
        }

        private int _origMaCh = -1;
        private string _origMaMh = "!@#$%";
        private string _origTrinhDo = "!@#$%";
        State _state = State.Idle;
        List<Guna2CustomRadioButton> _rdoButtons = new List<Guna2CustomRadioButton>();
        private int _selectedRow;
        private bool _opened = false;
        private void SetIdleButtonEnabled(bool state)
        {
            buttonThem.Enabled = buttonXoa.Enabled =
                 buttonSua.Enabled = state;
            if (Utils.IsTruong() || Utils.IsCoSo()) buttonLamMoi.Enabled = true;
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

        private void SetDefaultOrigValue()
        {
            _origMaCh = -1;
            _origMaMh = "!@#$%";
            _origTrinhDo = "!@#$%";

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

        private void LoadAllData()
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
            LoadAllData();

            MHCombo.DisplayMember = "TENMH";
            MHCombo.ValueMember = "MAMH";

            _rdoButtons.Add(rdoDA_A);
            _rdoButtons.Add(rdoDA_B);
            _rdoButtons.Add(rdoDA_C);
            _rdoButtons.Add(rdoDA_D);

            MonHocGridView.ExpandMasterRow(0);
            GridView view = GetCorrData(true);
            if (view != null)
                view.Focus();
            CheckButtonState();
            PhanQuyen();
        }

        private void BoDeGridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (!_opened)
            {
                for (int i = 1; i < MonHocGridView.RowCount; i++)
                    MonHocGridView.ExpandMasterRow(i);
                _opened = true;
            }
            GetCorrData(false);
        }

        private void UncheckOtherRdOs(Guna2CustomRadioButton button)
        {
            foreach (Guna2CustomRadioButton element in _rdoButtons)
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
            if (e.RelationIndex == 0)
                e.RelationName = $"Câu hỏi thuộc môn {tenMon}";
        }

        private void MonHocGridView_DetailTabStyle(object sender, DetailTabStyleEventArgs e)
        {
            e.Appearance.Header.Font = new Font("Baloo 2", 10.0F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
        }


        private void FormCauHoi_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_state != State.Idle)
                if (!Utils.ShowConfirmMessage("Hủy những thay đổi đang thực hiện và đóng cửa sổ này?", "Xác nhận"))
                    e.Cancel = true;
        }


        private GridView GetCorrData(bool getFirstRow)
        {
            GridView detailView;
            if (getFirstRow)
                detailView = MonHocGridView.GetDetailView(0, 0) as GridView;
            else
            {
                int row = MonHocGridView.GetSelectedRows()[0];
                detailView = MonHocGridView.GetDetailView(row, 0) as GridView;
            }
            if (detailView is null) return null;
            Object test = (detailView as GridView).GetFocusedRowCellValue(colCAUHOI);
            string maCauHoi;
            if (test != null)
                maCauHoi = test.ToString();
            else return null;
            BoDeBindingSource.Position = BoDeBindingSource.Find("CAUHOI", maCauHoi);

            string maMh = ((DataRowView)BoDeBindingSource[BoDeBindingSource.Position])["MAMH"].ToString();
            MH2BindingSource.Position = MH2BindingSource.Find("MAMH", maMh);

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
                    UncheckOtherRdOs(rdoDA_A);
                    labelDapAn.Text = "A";
                }
                else if (rdoButton.Equals(rdoDA_B))
                {
                    UncheckOtherRdOs(rdoDA_B);
                    labelDapAn.Text = "B";
                }
                else if (rdoButton.Equals(rdoDA_C))
                {
                    UncheckOtherRdOs(rdoDA_C);
                    labelDapAn.Text = "C";
                }
                else if (rdoButton.Equals(rdoDA_D))
                {
                    UncheckOtherRdOs(rdoDA_D);
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
            _selectedRow = BoDeBindingSource.Position;
            InfoPanel.Enabled = true;


            SetIdleButtonEnabled(false);
            SetInputButtonEnabled(true);

            MonHocGridControl.Enabled = false;
            _state = State.Add;
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
                LoadAllData();
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

        private string TrimText(Control textEdit)
        {
            textEdit.Text = textEdit.Text.Trim();
            return textEdit.Text;
        }

        private string GetTrinhDo()
        {
            if (rdoA.Checked) return "A";
            else if (rdoB.Checked) return "B";
            else if (rdoC.Checked) return "C";
            else return null;
        }
        private SqlDataReader ExecuteIdCheck(int id)
        {

            string spName = "usp_BoDe_GetInfoByID";

            SqlDataReader result;
            SqlCommand sqlCmd = new SqlCommand(spName, DBConnection.SubcriberConnection);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.Add(new SqlParameter("@ID", id));

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
        private bool AlreadyExistsCh(int id)
        {
            using (SqlDataReader myReader = ExecuteIdCheck(id))
            {
                if (myReader == null)
                {
                    Console.WriteLine(System.Environment.StackTrace);
                    return true;
                }
                return myReader.HasRows;
            }
              
        }

        private void GoToNewlyCreatedRowCh()
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

        private List<string> CanDeleteEdit(string trinhDo, string maMh)
        {
            List<string> result = new List<string>();
            List<Para> paraList = new List<Para>();
            paraList.Add(new Para("@trinhDo", trinhDo));
            paraList.Add(new Para("@maMon", maMh));
            string spName = "usp_BoDe_GetDeletingEditingPossibility";
            using (SqlDataReader myReader = DBConnection.ExecuteSqlDataReaderSP(spName, paraList))
            {
                if (myReader.HasRows)
                {
                    while (myReader.Read())
                    {
                        result.Add("Lớp " + myReader.GetString(1) + " thi môn " + myReader.GetString(0) +
                            " lần " + myReader.GetInt16(2) + " vào ngày " + myReader.GetDateTime(3).ToString("dd/MM/yyyy"));
                    }
                }
                return result;
            }


        }
        private void buttonXacNhan_Click(object sender, EventArgs e)
        {
            bool test1 = string.IsNullOrEmpty(TrimText(textChoiceA));
            bool test2 = string.IsNullOrEmpty(TrimText(textChoiceB));
            bool test3 = string.IsNullOrEmpty(TrimText(textChoiceC));
            bool test4 = string.IsNullOrEmpty(TrimText(textChoiceD));
            bool test5 = string.IsNullOrEmpty(TrimText(textNoiDung));
            bool test6 = string.IsNullOrEmpty(TrimText(textMaCH));

            string maGV = labelGVSoan.Text.Split('-')[0].Trim();
            string maMh = MHCombo.SelectedValue.ToString();
            string trinhDo = GetTrinhDo();

            bool test7 = false;
            if (!int.TryParse(textMaCH.Text, out int maCh))
            {
                test7 = true;
            }
            else if (maCh <= 0)
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

            bool testMaCh = false;
            if (_origMaCh != maCh)
                testMaCh = AlreadyExistsCh(maCh);

            if (testMaCh)
            {
                Utils.SetTextEditError(maCHEP, textMaCH, "Mã câu hỏi đã tồn tại");
                Utils.ShowMessage("Thông tin vừa nhập đã tồn tại", Others.NotiForm.FormType.Error, 2);
                return;
            }
            else
                Utils.SetTextEditError(maCHEP, textMaCH, null);

            if (_state == State.Edit && !(_origMaMh.Equals(maMh)) || !(_origTrinhDo.Equals(trinhDo)))
            {
                List<string> result = CanDeleteEdit(_origTrinhDo, _origMaMh);
                if (result.Count > 0)
                {
                    string listBuoiThi = "";
                    foreach (string record in result)
                    {
                        listBuoiThi += "   - " + record + "\n";
                    }
                    Utils.ShowErrorMessage("Không thể thay đổi TRÌNH ĐỘ hoặc (và) MÔN HỌC của câu hỏi này" +
                        ", vì điều này sẽ dẫn đến thiếu câu hỏi cho các buổi thi sau:\n" +
                        listBuoiThi, "Không thể thay đổi");
                    return;
                }
            }

            try
            {
                ((DataRowView)BoDeBindingSource[BoDeBindingSource.Position])["MAGV"] = maGV;
                ((DataRowView)BoDeBindingSource[BoDeBindingSource.Position])["MAMH"] = maMh;
                ((DataRowView)BoDeBindingSource[BoDeBindingSource.Position])["TRINHDO"] = trinhDo;

                TN_CSDLPTDataSet.BODE.Columns[0].ReadOnly = false;
                ((DataRowView)BoDeBindingSource[BoDeBindingSource.Position])["CAUHOI"] = maCh;
                BoDeBindingSource.EndEdit();
                BoDeBindingSource.ResetCurrentItem();
                this.BoDeTableAdapter.Update(this.TN_CSDLPTDataSet.BODE);
                if (_state == State.Edit)
                    Utils.ShowMessage("Sửa thông tin câu hỏi thành công", Others.NotiForm.FormType.Success, 2);
                else if (_state == State.Add)
                {
                    GoToNewlyCreatedRowCh();
                    Utils.ShowMessage("Thêm câu hỏi thành công", Others.NotiForm.FormType.Success, 2);
                }


                _state = State.Idle;

                ClearError();


                CheckButtonState();
                SetDefaultOrigValue();

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

            _origMaCh = int.Parse(textMaCH.Text);
            _origMaMh = MHCombo.SelectedValue.ToString();
            _origTrinhDo = GetTrinhDo();
            MonHocGridControl.Enabled = false;
            _state = State.Edit;
        }

        private void buttonHuy_Click(object sender, EventArgs e)
        {
            InfoPanel.Enabled = false;


            MonHocGridControl.Enabled = true;
            SetDefaultOrigValue();

            BoDeBindingSource.CancelEdit();
            if (_state == State.Add)
                BoDeBindingSource.Position = _selectedRow;
            SetIdleButtonEnabled(true);
            SetInputButtonEnabled(false);
            _state = State.Idle;

            ClearError();
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {

            int removeCh = -100;
            _selectedRow = BoDeBindingSource.Position;
            if (BaiThiBindingSource.Count > 0)
            {
                Utils.ShowMessage("Không thể xóa, vì câu hỏi đã được sử dụng để thi", Others.NotiForm.FormType.Error, 2);
                return;
            }


            string maMh = MHCombo.SelectedValue.ToString();
            string trinhDo = GetTrinhDo();
            List<string> result = CanDeleteEdit(trinhDo, maMh);
            if (result.Count > 0)
            {
                string listBuoiThi = "";
                foreach (string record in result)
                {
                    listBuoiThi += "   - " + record + "\n";
                }
                Utils.ShowErrorMessage("Không thể xóa câu hỏi này" +
                    ", vì điều này sẽ dẫn đến thiếu câu hỏi cho các buổi thi sau:\n" +
                    listBuoiThi, "Không thể xóa");
                return;
            }



            if (Utils.ShowConfirmMessage("Bạn có chắc muốn xóa câu hỏi này?", "Xác nhận"))
            {
                try
                {
                    removeCh = int.Parse(((DataRowView)BoDeBindingSource[_selectedRow])["CAUHOI"].ToString());
                    BoDeBindingSource.RemoveCurrent();
                    BoDeTableAdapter.Update(TN_CSDLPTDataSet.BODE);
                    Utils.ShowMessage("Xóa câu hỏi " + removeCh + " thành công!", Others.NotiForm.FormType.Success, 1);
                }
                catch (Exception ex)
                {
                    Utils.ShowErrorMessage("Không thể xóa câu hỏi, xin vui lòng thử lại sau\n" + ex.Message, "Lỗi xóa câu hỏi");
                    Console.WriteLine(ex.StackTrace);
                    this.BoDeTableAdapter.Fill(TN_CSDLPTDataSet.BODE);
                    BoDeBindingSource.Position = BoDeBindingSource.Find("CAUHOI", removeCh);
                    return;
                }
            }
            CheckButtonState();
        }

        private void pictureBox1_EnabledChanged(object sender, EventArgs e)
        {
            Image image = pictureBox1.Enabled ? global::TracNghiemCSDLPT.Properties.Resources.info_480px :
                global::TracNghiemCSDLPT.Properties.Resources.info_480px_disabled;
            pictureBox1.Image = image;
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