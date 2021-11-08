
namespace TracNghiemCSDLPT.MyForms.BaoCao
{
    partial class FormBDMH
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBDMH));
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.CoSoComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panelLan = new System.Windows.Forms.Panel();
            this.rdo1 = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.rdo2 = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.LookUpMh = new DevExpress.XtraEditors.GridLookUpEdit();
            this.DSMHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TN_CSDLPTDataSet = new TracNghiemCSDLPT.TN_CSDLPTDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LookUpLop = new DevExpress.XtraEditors.GridLookUpEdit();
            this.DSLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMALOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENLOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DSLTableAdapter = new TracNghiemCSDLPT.TN_CSDLPTDataSetTableAdapters.DSLTableAdapter();
            this.tableAdapterManager = new TracNghiemCSDLPT.TN_CSDLPTDataSetTableAdapters.TableAdapterManager();
            this.DSMHTableAdapter = new TracNghiemCSDLPT.TN_CSDLPTDataSetTableAdapters.DSMHTableAdapter();
            this.bunifuPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelLan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpMh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSMHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TN_CSDLPTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpLop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSLBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BorderRadius = 3;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.label2);
            this.bunifuPanel1.Controls.Add(this.CoSoComboBox);
            this.bunifuPanel1.Controls.Add(this.panel1);
            this.bunifuPanel1.Controls.Add(this.pictureBox1);
            this.bunifuPanel1.Location = new System.Drawing.Point(299, 52);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(1026, 708);
            this.bunifuPanel1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Baloo 2", 10.8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(5, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 30);
            this.label2.TabIndex = 32;
            this.label2.Text = "Chọn cơ sở";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CoSoComboBox
            // 
            this.CoSoComboBox.BackColor = System.Drawing.Color.Transparent;
            this.CoSoComboBox.BorderRadius = 3;
            this.CoSoComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CoSoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CoSoComboBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(163)))), ((int)(((byte)(236)))));
            this.CoSoComboBox.FocusedColor = System.Drawing.Color.Empty;
            this.CoSoComboBox.FocusedState.Parent = this.CoSoComboBox;
            this.CoSoComboBox.Font = new System.Drawing.Font("Baloo 2", 12F, System.Drawing.FontStyle.Bold);
            this.CoSoComboBox.ForeColor = System.Drawing.Color.White;
            this.CoSoComboBox.FormattingEnabled = true;
            this.CoSoComboBox.HoverState.Parent = this.CoSoComboBox;
            this.CoSoComboBox.ItemHeight = 30;
            this.CoSoComboBox.ItemsAppearance.Parent = this.CoSoComboBox;
            this.CoSoComboBox.Location = new System.Drawing.Point(137, 16);
            this.CoSoComboBox.Name = "CoSoComboBox";
            this.CoSoComboBox.ShadowDecoration.Parent = this.CoSoComboBox;
            this.CoSoComboBox.Size = new System.Drawing.Size(286, 36);
            this.CoSoComboBox.TabIndex = 31;
            this.CoSoComboBox.SelectedIndexChanged += new System.EventHandler(this.CoSoComboBox_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.buttonCancel);
            this.panel1.Controls.Add(this.buttonPrint);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.panelLan);
            this.panel1.Controls.Add(this.LookUpMh);
            this.panel1.Controls.Add(this.LookUpLop);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(10, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(535, 606);
            this.panel1.TabIndex = 1;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Font = new System.Drawing.Font("Baloo 2 SemiBold", 13.8F, System.Drawing.FontStyle.Bold);
            this.buttonCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonCancel.Location = new System.Drawing.Point(285, 404);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(207, 46);
            this.buttonCancel.TabIndex = 52;
            this.buttonCancel.Text = "Hủy";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonPrint
            // 
            this.buttonPrint.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(163)))), ((int)(((byte)(236)))));
            this.buttonPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPrint.Font = new System.Drawing.Font("Baloo 2 SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrint.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonPrint.Location = new System.Drawing.Point(47, 404);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(207, 46);
            this.buttonPrint.TabIndex = 51;
            this.buttonPrint.Text = "In xem trước";
            this.buttonPrint.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Baloo 2", 10.8F);
            this.label6.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label6.Location = new System.Drawing.Point(42, 315);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 0, 11, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 30);
            this.label6.TabIndex = 29;
            this.label6.Text = "Lần thi";
            // 
            // panelLan
            // 
            this.panelLan.Controls.Add(this.rdo1);
            this.panelLan.Controls.Add(this.label15);
            this.panelLan.Controls.Add(this.label13);
            this.panelLan.Controls.Add(this.rdo2);
            this.panelLan.Location = new System.Drawing.Point(124, 309);
            this.panelLan.Margin = new System.Windows.Forms.Padding(3, 3, 3, 40);
            this.panelLan.Name = "panelLan";
            this.panelLan.Size = new System.Drawing.Size(145, 43);
            this.panelLan.TabIndex = 50;
            // 
            // rdo1
            // 
            this.rdo1.Animated = true;
            this.rdo1.BackColor = System.Drawing.Color.White;
            this.rdo1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(198)))), ((int)(((byte)(203)))));
            this.rdo1.CheckedState.BorderThickness = 0;
            this.rdo1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(198)))), ((int)(((byte)(203)))));
            this.rdo1.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdo1.CheckedState.Parent = this.rdo1;
            this.rdo1.Enabled = false;
            this.rdo1.Location = new System.Drawing.Point(16, 13);
            this.rdo1.Name = "rdo1";
            this.rdo1.ShadowDecoration.Parent = this.rdo1;
            this.rdo1.Size = new System.Drawing.Size(20, 20);
            this.rdo1.TabIndex = 24;
            this.rdo1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdo1.UncheckedState.BorderThickness = 2;
            this.rdo1.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdo1.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdo1.UncheckedState.Parent = this.rdo1;
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.White;
            this.label15.Enabled = false;
            this.label15.Font = new System.Drawing.Font("Baloo 2", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(119, 8);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(23, 30);
            this.label15.TabIndex = 27;
            this.label15.Text = "2";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Enabled = false;
            this.label13.Font = new System.Drawing.Font("Baloo 2", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(42, 8);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(20, 30);
            this.label13.TabIndex = 28;
            this.label13.Text = "1";
            // 
            // rdo2
            // 
            this.rdo2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.rdo2.Animated = true;
            this.rdo2.BackColor = System.Drawing.Color.White;
            this.rdo2.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(198)))), ((int)(((byte)(203)))));
            this.rdo2.CheckedState.BorderThickness = 0;
            this.rdo2.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(198)))), ((int)(((byte)(203)))));
            this.rdo2.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdo2.CheckedState.Parent = this.rdo2;
            this.rdo2.Enabled = false;
            this.rdo2.Location = new System.Drawing.Point(93, 13);
            this.rdo2.Name = "rdo2";
            this.rdo2.ShadowDecoration.Parent = this.rdo2;
            this.rdo2.Size = new System.Drawing.Size(20, 20);
            this.rdo2.TabIndex = 23;
            this.rdo2.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdo2.UncheckedState.BorderThickness = 2;
            this.rdo2.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdo2.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdo2.UncheckedState.Parent = this.rdo2;
            // 
            // LookUpMh
            // 
            this.LookUpMh.Location = new System.Drawing.Point(47, 237);
            this.LookUpMh.Margin = new System.Windows.Forms.Padding(3, 3, 3, 40);
            this.LookUpMh.Name = "LookUpMh";
            this.LookUpMh.Properties.Appearance.Font = new System.Drawing.Font("Baloo 2", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LookUpMh.Properties.Appearance.Options.UseFont = true;
            this.LookUpMh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LookUpMh.Properties.DataSource = this.DSMHBindingSource;
            this.LookUpMh.Properties.DisplayMember = "FullInfo";
            this.LookUpMh.Properties.NullText = "Chọn môn đã thi";
            this.LookUpMh.Properties.PopupFormSize = new System.Drawing.Size(0, 300);
            this.LookUpMh.Properties.PopupView = this.gridView1;
            this.LookUpMh.Properties.PopupWidthMode = DevExpress.XtraEditors.PopupWidthMode.UseEditorWidth;
            this.LookUpMh.Size = new System.Drawing.Size(445, 38);
            this.LookUpMh.TabIndex = 31;
            // 
            // DSMHBindingSource
            // 
            this.DSMHBindingSource.DataMember = "DSMH";
            this.DSMHBindingSource.DataSource = this.TN_CSDLPTDataSet;
            // 
            // TN_CSDLPTDataSet
            // 
            this.TN_CSDLPTDataSet.DataSetName = "TN_CSDLPTDataSet";
            this.TN_CSDLPTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // LookUpLop
            // 
            this.LookUpLop.Location = new System.Drawing.Point(47, 156);
            this.LookUpLop.Margin = new System.Windows.Forms.Padding(3, 3, 3, 40);
            this.LookUpLop.Name = "LookUpLop";
            this.LookUpLop.Properties.Appearance.Font = new System.Drawing.Font("Baloo 2", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LookUpLop.Properties.Appearance.Options.UseFont = true;
            this.LookUpLop.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LookUpLop.Properties.DataSource = this.DSLBindingSource;
            this.LookUpLop.Properties.DisplayMember = "FullInfo";
            this.LookUpLop.Properties.NullText = "Chọn lớp";
            this.LookUpLop.Properties.PopupView = this.gridLookUpEdit1View;
            this.LookUpLop.Properties.PopupWidthMode = DevExpress.XtraEditors.PopupWidthMode.UseEditorWidth;
            this.LookUpLop.Size = new System.Drawing.Size(445, 38);
            this.LookUpLop.TabIndex = 30;
            // 
            // DSLBindingSource
            // 
            this.DSLBindingSource.DataMember = "DSL";
            this.DSLBindingSource.DataSource = this.TN_CSDLPTDataSet;
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
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.Font = new System.Drawing.Font("Baloo 2", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(190)))));
            this.label7.Location = new System.Drawing.Point(183, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(278, 93);
            this.label7.TabIndex = 25;
            this.label7.Text = "Bảng điểm môn học";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox2.Image = global::TracNghiemCSDLPT.Properties.Resources.logo31;
            this.pictureBox2.Location = new System.Drawing.Point(74, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(103, 65);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::TracNghiemCSDLPT.Properties.Resources.transcript;
            this.pictureBox1.Location = new System.Drawing.Point(542, 77);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(481, 606);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // DSLTableAdapter
            // 
            this.DSLTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BAITHITableAdapter = null;
            this.tableAdapterManager.BANGDIEMTableAdapter = null;
            this.tableAdapterManager.BODE_BKTableAdapter = null;
            this.tableAdapterManager.BODETableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.COSOTableAdapter = null;
            this.tableAdapterManager.GIAOVIEN_DANGKYTableAdapter = null;
            this.tableAdapterManager.GIAOVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TracNghiemCSDLPT.TN_CSDLPTDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // DSMHTableAdapter
            // 
            this.DSMHTableAdapter.ClearBeforeFill = true;
            // 
            // FormBDMH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1624, 813);
            this.Controls.Add(this.bunifuPanel1);
            this.Name = "FormBDMH";
            this.Text = "Bảng điểm MH";
            this.Load += new System.EventHandler(this.FormBDMH_Load);
            this.bunifuPanel1.ResumeLayout(false);
            this.bunifuPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelLan.ResumeLayout(false);
            this.panelLan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpMh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSMHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TN_CSDLPTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpLop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSLBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox CoSoComboBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panelLan;
        private Guna.UI2.WinForms.Guna2CustomRadioButton rdo1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private Guna.UI2.WinForms.Guna2CustomRadioButton rdo2;
        private DevExpress.XtraEditors.GridLookUpEdit LookUpMh;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAMH;
        private DevExpress.XtraGrid.Columns.GridColumn colTENMH;
        private DevExpress.XtraEditors.GridLookUpEdit LookUpLop;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private TN_CSDLPTDataSet TN_CSDLPTDataSet;
        private System.Windows.Forms.BindingSource DSLBindingSource;
        private TN_CSDLPTDataSetTableAdapters.DSLTableAdapter DSLTableAdapter;
        private TN_CSDLPTDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource DSMHBindingSource;
        private TN_CSDLPTDataSetTableAdapters.DSMHTableAdapter DSMHTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colMALOP;
        private DevExpress.XtraGrid.Columns.GridColumn colTENLOP;
    }
}