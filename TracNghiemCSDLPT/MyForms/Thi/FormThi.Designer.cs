
namespace TracNghiemCSDLPT.MyForms.Thi
{
    partial class FormThi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label LabelMaMH;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label2;
            this.pnlThongTinThi = new Bunifu.UI.WinForms.BunifuGroupBox();
            this.LookUpLop = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.TextMaMH = new DevExpress.XtraEditors.TextEdit();
            this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CauHoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DaChon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tblLayoutThongTinThi = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.LookUpMh = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.colMALOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENLOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENMH = new DevExpress.XtraGrid.Columns.GridColumn();
            LabelMaMH = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            this.pnlThongTinThi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpLop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextMaMH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.tblLayoutThongTinThi.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpMh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlThongTinThi
            // 
            this.pnlThongTinThi.BorderColor = System.Drawing.Color.LightGray;
            this.pnlThongTinThi.BorderRadius = 1;
            this.pnlThongTinThi.BorderThickness = 1;
            this.pnlThongTinThi.Controls.Add(this.tblLayoutThongTinThi);
            this.pnlThongTinThi.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlThongTinThi.Font = new System.Drawing.Font("Baloo 2", 15F, System.Drawing.FontStyle.Bold);
            this.pnlThongTinThi.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.pnlThongTinThi.LabelAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.pnlThongTinThi.LabelIndent = 10;
            this.pnlThongTinThi.LineStyle = Bunifu.UI.WinForms.BunifuGroupBox.LineStyles.Solid;
            this.pnlThongTinThi.Location = new System.Drawing.Point(0, 0);
            this.pnlThongTinThi.Name = "pnlThongTinThi";
            this.pnlThongTinThi.Size = new System.Drawing.Size(1066, 219);
            this.pnlThongTinThi.TabIndex = 0;
            this.pnlThongTinThi.TabStop = false;
            this.pnlThongTinThi.Text = "Thông tin thi";
            // 
            // LookUpLop
            // 
            this.LookUpLop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LookUpLop.Location = new System.Drawing.Point(97, 27);
            this.LookUpLop.Margin = new System.Windows.Forms.Padding(3, 3, 3, 40);
            this.LookUpLop.Name = "LookUpLop";
            this.LookUpLop.Properties.Appearance.Font = new System.Drawing.Font("Baloo 2", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LookUpLop.Properties.Appearance.Options.UseFont = true;
            this.LookUpLop.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LookUpLop.Properties.DisplayMember = "FullInfo";
            this.LookUpLop.Properties.NullText = "Chọn lớp";
            this.LookUpLop.Properties.PopupView = this.gridLookUpEdit1View;
            this.LookUpLop.Properties.PopupWidthMode = DevExpress.XtraEditors.PopupWidthMode.UseEditorWidth;
            this.LookUpLop.Size = new System.Drawing.Size(317, 38);
            this.LookUpLop.TabIndex = 32;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(255)))), ((int)(((byte)(215)))));
            this.gridLookUpEdit1View.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridLookUpEdit1View.Appearance.HeaderPanel.Font = new System.Drawing.Font("Baloo 2", 12F, System.Drawing.FontStyle.Bold);
            this.gridLookUpEdit1View.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridLookUpEdit1View.Appearance.Row.Font = new System.Drawing.Font("Baloo 2", 12F);
            this.gridLookUpEdit1View.Appearance.Row.Options.UseFont = true;
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMALOP,
            this.colTENLOP});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsEditForm.PopupEditFormWidth = 361;
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            this.gridLookUpEdit1View.OptionsView.ShowIndicator = false;
            // 
            // LabelMaMH
            // 
            LabelMaMH.AutoSize = true;
            LabelMaMH.Font = new System.Drawing.Font("Baloo 2", 10.8F, System.Drawing.FontStyle.Bold);
            LabelMaMH.Location = new System.Drawing.Point(18, 30);
            LabelMaMH.Name = "LabelMaMH";
            LabelMaMH.Size = new System.Drawing.Size(73, 30);
            LabelMaMH.TabIndex = 34;
            LabelMaMH.Text = "Lớp thi";
            LabelMaMH.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Baloo 2", 10.8F, System.Drawing.FontStyle.Bold);
            label1.Location = new System.Drawing.Point(3, 30);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(160, 30);
            label1.TabIndex = 35;
            label1.Text = "Họ và tên thí sinh";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TextMaMH
            // 
            this.TextMaMH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TextMaMH.Location = new System.Drawing.Point(169, 26);
            this.TextMaMH.Name = "TextMaMH";
            this.TextMaMH.Properties.Appearance.BorderColor = System.Drawing.Color.Silver;
            this.TextMaMH.Properties.Appearance.Font = new System.Drawing.Font("Baloo 2", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextMaMH.Properties.Appearance.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.TextMaMH.Properties.Appearance.Options.UseBorderColor = true;
            this.TextMaMH.Properties.Appearance.Options.UseFont = true;
            this.TextMaMH.Properties.Appearance.Options.UseForeColor = true;
            this.TextMaMH.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.TextMaMH.Size = new System.Drawing.Size(317, 38);
            this.TextMaMH.TabIndex = 36;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Baloo 2", 10.8F, System.Drawing.FontStyle.Bold);
            label3.Location = new System.Drawing.Point(7, 34);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(84, 30);
            label3.TabIndex = 38;
            label3.Text = "Ngày thi";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dateEdit1
            // 
            this.dateEdit1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dateEdit1.EditValue = null;
            this.dateEdit1.Location = new System.Drawing.Point(97, 26);
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.Appearance.Font = new System.Drawing.Font("Baloo 2", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateEdit1.Properties.Appearance.Options.UseFont = true;
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Size = new System.Drawing.Size(317, 38);
            this.dateEdit1.TabIndex = 39;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CauHoi,
            this.DaChon});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(253, 414);
            this.dataGridView1.TabIndex = 1;
            // 
            // CauHoi
            // 
            this.CauHoi.HeaderText = "Câu hỏi";
            this.CauHoi.MinimumWidth = 6;
            this.CauHoi.Name = "CauHoi";
            this.CauHoi.Width = 125;
            // 
            // DaChon
            // 
            this.DaChon.HeaderText = "Đã chọn";
            this.DaChon.MinimumWidth = 6;
            this.DaChon.Name = "DaChon";
            this.DaChon.Width = 125;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(253, 100);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(813, 219);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(253, 514);
            this.panel2.TabIndex = 3;
            // 
            // tblLayoutThongTinThi
            // 
            this.tblLayoutThongTinThi.ColumnCount = 2;
            this.tblLayoutThongTinThi.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutThongTinThi.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutThongTinThi.Controls.Add(this.panel6, 1, 1);
            this.tblLayoutThongTinThi.Controls.Add(this.panel5, 0, 1);
            this.tblLayoutThongTinThi.Controls.Add(this.panel3, 0, 0);
            this.tblLayoutThongTinThi.Controls.Add(this.panel4, 1, 0);
            this.tblLayoutThongTinThi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutThongTinThi.Location = new System.Drawing.Point(3, 44);
            this.tblLayoutThongTinThi.Name = "tblLayoutThongTinThi";
            this.tblLayoutThongTinThi.RowCount = 2;
            this.tblLayoutThongTinThi.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutThongTinThi.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutThongTinThi.Size = new System.Drawing.Size(1060, 172);
            this.tblLayoutThongTinThi.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.LookUpLop);
            this.panel3.Controls.Add(LabelMaMH);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(524, 80);
            this.panel3.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(label2);
            this.panel4.Controls.Add(this.LookUpMh);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(533, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(524, 80);
            this.panel4.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Baloo 2", 10.8F, System.Drawing.FontStyle.Bold);
            label2.Location = new System.Drawing.Point(86, 25);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(77, 30);
            label2.TabIndex = 39;
            label2.Text = "Môn thi";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LookUpMh
            // 
            this.LookUpMh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LookUpMh.Location = new System.Drawing.Point(169, 21);
            this.LookUpMh.Margin = new System.Windows.Forms.Padding(3, 3, 3, 40);
            this.LookUpMh.Name = "LookUpMh";
            this.LookUpMh.Properties.Appearance.Font = new System.Drawing.Font("Baloo 2", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LookUpMh.Properties.Appearance.Options.UseFont = true;
            this.LookUpMh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LookUpMh.Properties.DisplayMember = "FullInfo";
            this.LookUpMh.Properties.NullText = "Chọn môn đã thi";
            this.LookUpMh.Properties.PopupFormSize = new System.Drawing.Size(0, 300);
            this.LookUpMh.Properties.PopupView = this.gridView1;
            this.LookUpMh.Properties.PopupWidthMode = DevExpress.XtraEditors.PopupWidthMode.UseEditorWidth;
            this.LookUpMh.Size = new System.Drawing.Size(317, 38);
            this.LookUpMh.TabIndex = 38;
            // 
            // gridView1
            // 
            this.gridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(255)))), ((int)(((byte)(215)))));
            this.gridView1.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Baloo 2", 12F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Baloo 2", 12F);
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAMH,
            this.colTENMH});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsEditForm.PopupEditFormWidth = 361;
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.ShowIndicator = false;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dateEdit1);
            this.panel5.Controls.Add(label3);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(3, 89);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(524, 80);
            this.panel5.TabIndex = 5;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.TextMaMH);
            this.panel6.Controls.Add(label1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(533, 89);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(524, 80);
            this.panel6.TabIndex = 5;
            // 
            // colMALOP
            // 
            this.colMALOP.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(163)))), ((int)(((byte)(236)))));
            this.colMALOP.AppearanceHeader.Options.UseBackColor = true;
            this.colMALOP.Caption = "Mã lớp";
            this.colMALOP.FieldName = "MALOP";
            this.colMALOP.Name = "colMALOP";
            this.colMALOP.OptionsColumn.FixedWidth = true;
            this.colMALOP.Visible = true;
            this.colMALOP.VisibleIndex = 0;
            this.colMALOP.Width = 100;
            // 
            // colTENLOP
            // 
            this.colTENLOP.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(163)))), ((int)(((byte)(236)))));
            this.colTENLOP.AppearanceHeader.Options.UseBackColor = true;
            this.colTENLOP.Caption = "Tên lớp";
            this.colTENLOP.FieldName = "TENLOP";
            this.colTENLOP.Name = "colTENLOP";
            this.colTENLOP.Visible = true;
            this.colTENLOP.VisibleIndex = 1;
            this.colTENLOP.Width = 300;
            // 
            // colMAMH
            // 
            this.colMAMH.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(163)))), ((int)(((byte)(236)))));
            this.colMAMH.AppearanceHeader.Options.UseBackColor = true;
            this.colMAMH.Caption = "Mã MH";
            this.colMAMH.FieldName = "MAMH";
            this.colMAMH.Name = "colMAMH";
            this.colMAMH.OptionsColumn.FixedWidth = true;
            this.colMAMH.Visible = true;
            this.colMAMH.VisibleIndex = 0;
            this.colMAMH.Width = 100;
            // 
            // colTENMH
            // 
            this.colTENMH.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(163)))), ((int)(((byte)(236)))));
            this.colTENMH.AppearanceHeader.Options.UseBackColor = true;
            this.colTENMH.Caption = "Tên môn học";
            this.colTENMH.FieldName = "TENMH";
            this.colTENMH.Name = "colTENMH";
            this.colTENMH.Visible = true;
            this.colTENMH.VisibleIndex = 1;
            this.colTENMH.Width = 300;
            // 
            // FormThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 733);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlThongTinThi);
            this.Name = "FormThi";
            this.Text = "FormThi";
            this.pnlThongTinThi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LookUpLop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextMaMH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.tblLayoutThongTinThi.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpMh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuGroupBox pnlThongTinThi;
        private DevExpress.XtraEditors.GridLookUpEdit LookUpLop;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colMALOP;
        private DevExpress.XtraGrid.Columns.GridColumn colTENLOP;
        private DevExpress.XtraEditors.TextEdit TextMaMH;
        private DevExpress.XtraEditors.DateEdit dateEdit1;
        private System.Windows.Forms.TableLayoutPanel tblLayoutThongTinThi;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private DevExpress.XtraEditors.GridLookUpEdit LookUpMh;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAMH;
        private DevExpress.XtraGrid.Columns.GridColumn colTENMH;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CauHoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn DaChon;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}