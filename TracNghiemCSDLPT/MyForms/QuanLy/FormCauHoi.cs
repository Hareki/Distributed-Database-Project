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
        private string _origMaMh = string.Empty;
        private string _origTrinhDo = string.Empty;
        State _state = State.Idle;
        List<Guna2CustomRadioButton> _rdoButtons = new List<Guna2CustomRadioButton>();
        private int _selectedRow;
        private void SetIdleButtonEnabled(bool state)
        {
            string maGV = Utils.GetCellStringBds(BoDeBindingSource, BoDeBindingSource.Position, "MAGV");
            bool test1 = BoDeBindingSource.Count == 0;
            bool test2 = !maGV.Equals(DBConnection.UserName);
            bool test3 = state == true;
            if ((test1 || test2) && test3)
            {
                buttonThem.Enabled = buttonLamMoi.Enabled = true;
                buttonXoa.Enabled = buttonSua.Enabled = false;
            }
            else if (state == false && !Utils.IsGV())
            {
                buttonLamMoi.Enabled = true;
                buttonThem.Enabled = buttonXoa.Enabled = buttonSua.Enabled = false;
            }
            else
            {
                buttonThem.Enabled = buttonXoa.Enabled =
                   buttonSua.Enabled = buttonLamMoi.Enabled = state;
            }

        }

        private void ResetOrigValue()
        {
            _origMaCh = -1;
            _origMaMh = string.Empty;
            _origTrinhDo = string.Empty;

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
            this.DSMHTableAdapter.Connection.ConnectionString = DBConnection.SubcriberConnectionString;
            this.DSGVTCSTableAdapter.Connection.ConnectionString = DBConnection.SubcriberConnectionString;
            this.BaiThiTableAdapter.Connection.ConnectionString = DBConnection.SubcriberConnectionString;

            this.MonHocTableAdapter.Fill(this.TN_CSDLPTDataSet.MONHOC);
            this.BoDeTableAdapter.Fill(this.TN_CSDLPTDataSet.BODE);
            this.DSMHTableAdapter.Fill(this.TN_CSDLPTDataSet.DSMH);
            this.DSGVTCSTableAdapter.Fill(this.TN_CSDLPTDataSet.DSGIAOVIENTCS);
            this.BaiThiTableAdapter.Fill(this.TN_CSDLPTDataSet.BAITHI);

        }
        private void SetCorrLookUpDataAfterReset()
        {
            string maMh = Utils.GetCellStringBds(BoDeBindingSource, 0, "MAMH").Trim();
            DSMHBindingSource.Position = DSMHBindingSource.Find("MAMH", maMh);
            MHCombo.EditValue = DSMHBindingSource[DSMHBindingSource.Position];
        }
        private void FormCauHoi_Load(object sender, EventArgs e)
        {
            this.TN_CSDLPTDataSet.EnforceConstraints = false;
            LoadAllData();
            SetCorrLookUpDataAfterReset();

            _rdoButtons.Add(rdoDA_A);
            _rdoButtons.Add(rdoDA_B);
            _rdoButtons.Add(rdoDA_C);
            _rdoButtons.Add(rdoDA_D);

            MonHocGridView.ExpandMasterRow(0);
            GridView view = GetCorrData(true);
            if (view != null)
                view.Focus();
            SetCorrButtonsState();
            PhanQuyen();
            //for (int i = 1; i < MonHocGridView.RowCount; i++)
            //        MonHocGridView.ExpandMasterRow(i);
        }

        private void BoDeGridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
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
        private GridView GetCurrentDetailView()
        {
            GridView detailView = null;

            //int row = MonHocGridView.GetSelectedRows()[0];
            //detailView = MonHocGridView.GetDetailView(row, 0) as GridView;
            if (MonHocGridView.GetSelectedRows().Length == 0)
                detailView = MonHocGridView.GetDetailView(0, 0) as GridView;
            else
            {
                int row = MonHocGridView.GetSelectedRows()[0];
                detailView = MonHocGridView.GetDetailView(row, 0) as GridView;
            }
            return detailView;
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

            GridView detailView = null;
            if (getFirstRow)
                detailView = MonHocGridView.GetDetailView(0, 0) as GridView;
            else
            {
                //int row = MonHocGridView.GetSelectedRows()[0];
                //detailView = MonHocGridView.GetDetailView(row, 0) as GridView;
                if (MonHocGridView.GetSelectedRows().Length == 0)
                    detailView = MonHocGridView.GetDetailView(0, 0) as GridView;
                else
                {
                    int row = MonHocGridView.GetSelectedRows()[0];
                    detailView = MonHocGridView.GetDetailView(row, 0) as GridView;
                }
            }
            if (detailView is null) return null;
            Object test = (detailView as GridView).GetFocusedRowCellValue(colCAUHOI);
            string maCauHoi;
            if (test != null)
                maCauHoi = test.ToString();
            else return null;
            BoDeBindingSource.Position = BoDeBindingSource.Find("CAUHOI", maCauHoi);

            string maMh = ((DataRowView)BoDeBindingSource[BoDeBindingSource.Position])["MAMH"].ToString();

            DSMHBindingSource.Position = DSMHBindingSource.Find("MAMH", maMh);
            MHCombo.EditValue = DSMHBindingSource[DSMHBindingSource.Position];

            string maGV = ((DataRowView)BoDeBindingSource[BoDeBindingSource.Position])["MAGV"].ToString();
            DSGVTCSBindingSource.Position = DSGVTCSBindingSource.Find("MAGV", maGV);

            SetCorrButtonsState();
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


        private void SetInputButtonVisible(bool state)
        {
            panelInput.Visible = buttonXacNhan.Visible = buttonHuy.Visible = state;
        }
        private void buttonThem_Click(object sender, EventArgs e)
        {
            _selectedRow = BoDeBindingSource.Position;
            SetInfoPanelEnabled(true);


            SetIdleButtonEnabled(false);
            SetInputButtonVisible(true);

            MonHocGridControl.Enabled = false;
            _state = State.Add;
            BoDeBindingSource.AddNew();
            labelGVSoan.Text = DBConnection.UserName + " - " + DBConnection.HoTen;
            rdoA.Checked = true;
            rdoDA_A.Checked = true;
            spinMaCH.EditValue = 0;
        }

        private void SetCorrButtonsState()
        {
            if (Utils.IsGV())
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
                        SetIdleButtonEnabled(true);
                        SetInputButtonVisible(false);
                        break;
                }
            }
        }



        private void buttonLamMoi_Click(object sender, EventArgs e)
        {
            try
            {
                LoadAllData();
                SetCorrLookUpDataAfterReset();
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

        private string TrimText(Control textEdit)
        {
            textEdit.Text = Utils.RemoveExtraSpace(textEdit.Text);
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

        private void SetFocusedDetailRow(string maCauHoi)
        {
            GridView detailView;
            string maMh = Utils.GetLookUpString(MHCombo, "MAMH");
            int row = MonHocGridView.LocateByDisplayText(0, colMAMH, Utils.AddExtraWhiteSpace(maMh, 5));
            MonHocGridView.FocusedRowHandle = row;
            MonHocGridView.RefreshDetailTab(row);
            MonHocGridView.Focus();
            MonHocGridView.ExpandMasterRow(row);
            detailView = MonHocGridView.GetDetailView(row, 0) as GridView;
            if (detailView is null)
            {
                Utils.ShowErrorMessage("Lỗi không xác định", "Lỗi");

                Console.WriteLine(System.Environment.StackTrace);
                return;
            }

            detailView.Focus();
            //detailView.FocusedRowHandle = detailView.RowCount - 1;
            //detailView.MakeRowVisible(detailView.RowCount - 1);

            int rowToGo = detailView.LocateByDisplayText(0, colCAUHOI, maCauHoi);
            detailView.FocusedRowHandle = rowToGo;
            detailView.MakeRowVisible(rowToGo);

        }

        private void ClearError()
        {
            Utils.SetTextEditError(choiceAEP, textChoiceA, null);
            Utils.SetTextEditError(choiceBEP, textChoiceB, null);
            Utils.SetTextEditError(choiceCEP, textChoiceC, null);
            Utils.SetTextEditError(choiceDEP, textChoiceD, null);
            Utils.SetTextEditError(noiDungEP, textNoiDung, null);
            Utils.SetTextEditError(maCHEP, spinMaCH, null);
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
            bool test6 = string.IsNullOrEmpty(TrimText(spinMaCH));

            string maGV = labelGVSoan.Text.Split('-')[0].Trim();
            string maMh = Utils.AddExtraWhiteSpace(Utils.GetLookUpString(MHCombo, "MAMH"), 5);
            string trinhDo = GetTrinhDo();

            bool test7 = false;
            int maCh = (int)spinMaCH.Value;
            if (maCh <= 0)
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
                    Utils.SetTextEditError(maCHEP, spinMaCH, "Vui lòng nhập mã câu hỏi");
                else
                    Utils.SetTextEditError(maCHEP, spinMaCH, null);
                if (test7)
                    Utils.SetTextEditError(maCHEP, spinMaCH, "Vui lòng nhập mã câu hỏi là một số nguyên dương");
                else
                    Utils.SetTextEditError(maCHEP, spinMaCH, null);
                Utils.ShowMessage("Vui lòng điền đầy đủ thông tin cần thiết", Others.NotiForm.FormType.Error, 2);
                return;
            }
            else
            {
                ClearError();
            }

            bool test8 = textChoiceA.Text.Length > 256;
            bool test9 = textChoiceB.Text.Length > 256;
            bool test10 = textChoiceC.Text.Length > 256;
            bool test11 = textChoiceD.Text.Length > 256;
            bool test12 = textNoiDung.Text.Length > 300;
            if (test8 || test9 || test10 || test11 || test12)
            {
                if (test8)
                    Utils.SetTextEditError(choiceAEP, textChoiceA, "Nội dung câu trả lời không vượt quá 256 ký tự");
                else
                    Utils.SetTextEditError(choiceAEP, textChoiceA, null);
                if (test9)
                    Utils.SetTextEditError(choiceBEP, textChoiceB, "Nội dung câu trả lời không vượt quá 256 ký tự");
                else
                    Utils.SetTextEditError(choiceBEP, textChoiceB, null);
                if (test10)
                    Utils.SetTextEditError(choiceCEP, textChoiceC, "Nội dung câu trả lời không vượt quá 256 ký tự");
                else
                    Utils.SetTextEditError(choiceCEP, textChoiceC, null);
                if (test11)
                    Utils.SetTextEditError(choiceDEP, textChoiceD, "Nội dung câu trả lời không vượt quá 256 ký tự");
                else
                    Utils.SetTextEditError(choiceDEP, textChoiceD, null);
                if (test12)
                    Utils.SetTextEditError(noiDungEP, textNoiDung, "Nội dung câu hỏi không vượt quá 300 ký tự");
                else
                    Utils.SetTextEditError(noiDungEP, textNoiDung, null);

                Utils.ShowMessage("Thông tin nhập quá dài", Others.NotiForm.FormType.Error, 1);
                return;
            }
            else
            {
                ClearError();
            }



            bool testMaCh = false;
            if (_origMaCh != maCh)
                testMaCh = AlreadyExistsCh(maCh);

            if (testMaCh)
            {
                Utils.SetTextEditError(maCHEP, spinMaCH, "Mã câu hỏi đã tồn tại");
                Utils.ShowMessage("Thông tin vừa nhập đã tồn tại", Others.NotiForm.FormType.Error, 2);
                return;
            }
            else
                Utils.SetTextEditError(maCHEP, spinMaCH, null);

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
                    Utils.ShowMessage("Thêm câu hỏi thành công", Others.NotiForm.FormType.Success, 2);
                SetFocusedDetailRow(maCh.ToString());

            }
            catch (Exception ex)
            {
                Utils.ShowErrorMessage("Xảy ra lỗi\n" + ex.Message, "Lỗi");
                Console.WriteLine(ex.StackTrace);
                return;
            }
            finally
            {
                ConfigIdleState();
            }

        }

        private void ConfigIdleState()
        {
            ResetOrigValue();

            _state = State.Idle;
            SetCorrButtonsState();
            ClearError();


            MonHocGridControl.Enabled = true;
            SetInfoPanelEnabled(false);

            if (_state == State.Add)
                BoDeBindingSource.Position = _selectedRow;
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
        private bool CanPressEditDelete(string maMh, string trinhDo)
        {
            List<Para> paraList = new List<Para>();
            paraList.Add(new Para("@MaMH", maMh));
            paraList.Add(new Para("@TrinhDo", trinhDo));
            string spName = "usp_BoDe_PressingEditDeletePoss";
            using (SqlDataReader myReader = DBConnection.ExecuteSqlDataReaderSP(spName, paraList))
            {
                if (myReader == null)
                    return false;
                else
                {
                    myReader.Read();
                    int result = int.Parse(myReader.GetValue(0).ToString());
                    if (result == 0) return true;
                    else return false;
                }
            }
        }

        private void SetInfoPanelEnabled(bool state)
        {
            InfoPanel.Enabled = state;
            if (state == true && _state == State.Edit)
                spinMaCH.Enabled = false;

        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            string maMh = Utils.AddExtraWhiteSpace(Utils.GetLookUpString(MHCombo, "MAMH"), 5);
            string trinhDo = GetTrinhDo();
            if (CanPressEditDelete(maMh, trinhDo))
            {
                _state = State.Edit;
                SetCorrButtonsState();

                SetInfoPanelEnabled(true);
                MonHocGridControl.Enabled = false;

                _origMaCh = int.Parse(spinMaCH.Text);
                _origMaMh = Utils.AddExtraWhiteSpace(Utils.GetLookUpString(MHCombo, "MAMH"), 5);
                _origTrinhDo = GetTrinhDo();

                GridView detailView = GetCurrentDetailView();
                if (detailView != null)
                {
                    _selectedRow = detailView.FocusedRowHandle;
                }

            }
            else
            {
                Utils.ShowMessage("Không thể chỉnh sửa câu hỏi thuộc môn học và trình độ đã chọn vào ngày có lớp đang thi chúng", NotiForm.FormType.Error, 4);
            }


        }

        private void buttonHuy_Click(object sender, EventArgs e)
        {
            BoDeBindingSource.CancelEdit();
            ConfigIdleState();
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
            string maMh = Utils.AddExtraWhiteSpace(Utils.GetLookUpString(MHCombo, "MAMH"), 5);
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
            SetCorrButtonsState();
        }

        private void IconInfor_EnabledChanged(object sender, EventArgs e)
        {
            Image image = pictureBox1.Enabled ? global::TracNghiemCSDLPT.Properties.Resources.info_480px :
                global::TracNghiemCSDLPT.Properties.Resources.info_480px_disabled;
            pictureBox1.Image = image;
        }

        private void buttonXoa_EnabledChanged(object sender, EventArgs e)
        {
            tipXoa.Visible = !buttonXoa.Enabled;

        }

        private void buttonSua_EnabledChanged(object sender, EventArgs e)
        {
            tipSua.Visible = !buttonSua.Enabled;
        }

        private void MonHocGridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            GetCorrData(false);
        }
    }
}