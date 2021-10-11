
namespace TracNghiemCSDLPT.MyForms.Thi
{
    partial class FormDKThi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDKThi));
            this.TN_CSDLPTDataSet = new TracNghiemCSDLPT.TN_CSDLPTDataSet();
            this.MonHocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MonHocTableAdapter = new TracNghiemCSDLPT.TN_CSDLPTDataSetTableAdapters.MONHOCTableAdapter();
            this.tableAdapterManager = new TracNghiemCSDLPT.TN_CSDLPTDataSetTableAdapters.TableAdapterManager();
            this.LopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LopTableAdapter = new TracNghiemCSDLPT.TN_CSDLPTDataSetTableAdapters.LOPTableAdapter();
            this.label9 = new System.Windows.Forms.Label();
            this.guna2ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MHCombo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.spinEdit2 = new DevExpress.XtraEditors.SpinEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LookUpGV = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAGV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHoTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label13 = new System.Windows.Forms.Label();
            this.rdoB = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.spinEdit1 = new DevExpress.XtraEditors.SpinEdit();
            this.rdoA = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.guna2CustomRadioButton1 = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dateFrom = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.rdoC = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.guna2CustomRadioButton2 = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.GVDKGridControl = new DevExpress.XtraGrid.GridControl();
            this.GVDKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GVDKGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAGV1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMALOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTRINHDO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYTHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOCAUTHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTHOIGIAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cardView1 = new DevExpress.XtraGrid.Views.Card.CardView();
            this.GVDKTableAdapter = new TracNghiemCSDLPT.TN_CSDLPTDataSetTableAdapters.GIAOVIEN_DANGKYTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.TN_CSDLPTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MonHocBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LopBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpGV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit1.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.bunifuPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GVDKGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GVDKBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GVDKGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardView1)).BeginInit();
            this.SuspendLayout();
            // 
            // TN_CSDLPTDataSet
            // 
            this.TN_CSDLPTDataSet.DataSetName = "TN_CSDLPTDataSet";
            this.TN_CSDLPTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // MonHocBindingSource
            // 
            this.MonHocBindingSource.DataMember = "MONHOC";
            this.MonHocBindingSource.DataSource = this.TN_CSDLPTDataSet;
            // 
            // MonHocTableAdapter
            // 
            this.MonHocTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BAITHITableAdapter = null;
            this.tableAdapterManager.BANGDIEMTableAdapter = null;
            this.tableAdapterManager.BODE_BKTableAdapter = null;
            this.tableAdapterManager.BODETableAdapter = null;
            this.tableAdapterManager.COSOTableAdapter = null;
            this.tableAdapterManager.GIAOVIEN_DANGKYTableAdapter = null;
            this.tableAdapterManager.GIAOVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = this.MonHocTableAdapter;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TracNghiemCSDLPT.TN_CSDLPTDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // LopBindingSource
            // 
            this.LopBindingSource.DataMember = "LOP";
            this.LopBindingSource.DataSource = this.TN_CSDLPTDataSet;
            // 
            // LopTableAdapter
            // 
            this.LopTableAdapter.ClearBeforeFill = true;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.label9.Font = new System.Drawing.Font("Baloo 2", 10.8F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(33, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 30);
            this.label9.TabIndex = 21;
            this.label9.Text = "Giáo viên dạy";
            // 
            // guna2ComboBox1
            // 
            this.guna2ComboBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.guna2ComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox1.FocusedColor = System.Drawing.Color.Empty;
            this.guna2ComboBox1.FocusedState.Parent = this.guna2ComboBox1;
            this.guna2ComboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2ComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.guna2ComboBox1.FormattingEnabled = true;
            this.guna2ComboBox1.HoverState.Parent = this.guna2ComboBox1;
            this.guna2ComboBox1.ItemHeight = 30;
            this.guna2ComboBox1.ItemsAppearance.Parent = this.guna2ComboBox1;
            this.guna2ComboBox1.Location = new System.Drawing.Point(694, 61);
            this.guna2ComboBox1.Name = "guna2ComboBox1";
            this.guna2ComboBox1.ShadowDecoration.Parent = this.guna2ComboBox1;
            this.guna2ComboBox1.Size = new System.Drawing.Size(402, 36);
            this.guna2ComboBox1.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.label1.Font = new System.Drawing.Font("Baloo 2", 10.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(642, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 30);
            this.label1.TabIndex = 21;
            this.label1.Text = "Lớp";
            // 
            // MHCombo
            // 
            this.MHCombo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MHCombo.BackColor = System.Drawing.Color.Transparent;
            this.MHCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.MHCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MHCombo.FocusedColor = System.Drawing.Color.Empty;
            this.MHCombo.FocusedState.Parent = this.MHCombo;
            this.MHCombo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.MHCombo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.MHCombo.FormattingEnabled = true;
            this.MHCombo.HoverState.Parent = this.MHCombo;
            this.MHCombo.ItemHeight = 30;
            this.MHCombo.ItemsAppearance.Parent = this.MHCombo;
            this.MHCombo.Location = new System.Drawing.Point(166, 115);
            this.MHCombo.Name = "MHCombo";
            this.MHCombo.ShadowDecoration.Parent = this.MHCombo;
            this.MHCombo.Size = new System.Drawing.Size(402, 36);
            this.MHCombo.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.label8.Font = new System.Drawing.Font("Baloo 2", 10.8F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(593, 194);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 30);
            this.label8.TabIndex = 30;
            this.label8.Text = "Số câu thi";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.label10.Font = new System.Drawing.Font("Baloo 2", 10.8F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(75, 118);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 30);
            this.label10.TabIndex = 19;
            this.label10.Text = "Môn học";
            // 
            // spinEdit2
            // 
            this.spinEdit2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.spinEdit2.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinEdit2.Location = new System.Drawing.Point(693, 187);
            this.spinEdit2.Name = "spinEdit2";
            this.spinEdit2.Properties.Appearance.Font = new System.Drawing.Font("Baloo 2", 13.8F);
            this.spinEdit2.Properties.Appearance.Options.UseFont = true;
            this.spinEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEdit2.Size = new System.Drawing.Size(79, 44);
            this.spinEdit2.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.label2.Font = new System.Drawing.Font("Baloo 2", 10.8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(604, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 30);
            this.label2.TabIndex = 30;
            this.label2.Text = "Ngày thi";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.label5.Font = new System.Drawing.Font("Baloo 2", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(193, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(271, 30);
            this.label5.TabIndex = 29;
            this.label5.Text = "Đại học, không chuyên ngành (B)";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.label7.Font = new System.Drawing.Font("Baloo 2", 10.8F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(836, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 30);
            this.label7.TabIndex = 30;
            this.label7.Text = "Thời gian thi";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.label4.Font = new System.Drawing.Font("Baloo 2", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(193, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(217, 30);
            this.label4.TabIndex = 28;
            this.label4.Text = "Đại học, chuyên ngành (A)";
            // 
            // LookUpGV
            // 
            this.LookUpGV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LookUpGV.EditValue = "Chọn giáo viên đăng ký thi";
            this.LookUpGV.Location = new System.Drawing.Point(166, 60);
            this.LookUpGV.Name = "LookUpGV";
            this.LookUpGV.Properties.Appearance.Font = new System.Drawing.Font("Baloo 2", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LookUpGV.Properties.Appearance.Options.UseFont = true;
            this.LookUpGV.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LookUpGV.Properties.NullText = "Chọn giáo viên đăng ký thi";
            this.LookUpGV.Properties.PopupView = this.gridLookUpEdit1View;
            this.LookUpGV.Properties.PopupWidthMode = DevExpress.XtraEditors.PopupWidthMode.UseEditorWidth;
            this.LookUpGV.Size = new System.Drawing.Size(402, 38);
            this.LookUpGV.TabIndex = 34;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Appearance.HeaderPanel.Font = new System.Drawing.Font("Baloo 2", 12F, System.Drawing.FontStyle.Bold);
            this.gridLookUpEdit1View.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridLookUpEdit1View.Appearance.Row.Font = new System.Drawing.Font("Baloo 2", 12F);
            this.gridLookUpEdit1View.Appearance.Row.Options.UseFont = true;
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAGV,
            this.colHoTen});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsEditForm.PopupEditFormWidth = 361;
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            this.gridLookUpEdit1View.OptionsView.ShowIndicator = false;
            this.gridLookUpEdit1View.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colHoTen, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colMAGV
            // 
            this.colMAGV.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(163)))), ((int)(((byte)(236)))));
            this.colMAGV.AppearanceHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.colMAGV.AppearanceHeader.Options.UseBackColor = true;
            this.colMAGV.AppearanceHeader.Options.UseForeColor = true;
            this.colMAGV.Caption = "Mã GV";
            this.colMAGV.FieldName = "MAGV";
            this.colMAGV.Name = "colMAGV";
            this.colMAGV.Visible = true;
            this.colMAGV.VisibleIndex = 0;
            this.colMAGV.Width = 90;
            // 
            // colHoTen
            // 
            this.colHoTen.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(163)))), ((int)(((byte)(236)))));
            this.colHoTen.AppearanceHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.colHoTen.AppearanceHeader.Options.UseBackColor = true;
            this.colHoTen.AppearanceHeader.Options.UseForeColor = true;
            this.colHoTen.Caption = "Họ và tên";
            this.colHoTen.FieldName = "HoTen";
            this.colHoTen.Name = "colHoTen";
            this.colHoTen.Visible = true;
            this.colHoTen.VisibleIndex = 1;
            this.colHoTen.Width = 310;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.label13.Font = new System.Drawing.Font("Baloo 2", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(1005, 127);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(20, 30);
            this.label13.TabIndex = 28;
            this.label13.Text = "1";
            // 
            // rdoB
            // 
            this.rdoB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rdoB.Animated = true;
            this.rdoB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.rdoB.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(198)))), ((int)(((byte)(203)))));
            this.rdoB.CheckedState.BorderThickness = 0;
            this.rdoB.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(198)))), ((int)(((byte)(203)))));
            this.rdoB.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdoB.CheckedState.Parent = this.rdoB;
            this.rdoB.Location = new System.Drawing.Point(166, 168);
            this.rdoB.Name = "rdoB";
            this.rdoB.ShadowDecoration.Parent = this.rdoB;
            this.rdoB.Size = new System.Drawing.Size(20, 20);
            this.rdoB.TabIndex = 25;
            this.rdoB.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdoB.UncheckedState.BorderThickness = 2;
            this.rdoB.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdoB.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdoB.UncheckedState.Parent = this.rdoB;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.label6.Font = new System.Drawing.Font("Baloo 2", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(456, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 30);
            this.label6.TabIndex = 27;
            this.label6.Text = "Cao đẳng (C)";
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.label15.Font = new System.Drawing.Font("Baloo 2", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(1073, 127);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(23, 30);
            this.label15.TabIndex = 27;
            this.label15.Text = "2";
            // 
            // spinEdit1
            // 
            this.spinEdit1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.spinEdit1.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinEdit1.Location = new System.Drawing.Point(961, 187);
            this.spinEdit1.Name = "spinEdit1";
            this.spinEdit1.Properties.Appearance.Font = new System.Drawing.Font("Baloo 2", 13.8F);
            this.spinEdit1.Properties.Appearance.Options.UseFont = true;
            this.spinEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEdit1.Size = new System.Drawing.Size(79, 44);
            this.spinEdit1.TabIndex = 33;
            // 
            // rdoA
            // 
            this.rdoA.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rdoA.Animated = true;
            this.rdoA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.rdoA.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(198)))), ((int)(((byte)(203)))));
            this.rdoA.CheckedState.BorderThickness = 0;
            this.rdoA.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(198)))), ((int)(((byte)(203)))));
            this.rdoA.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdoA.CheckedState.Parent = this.rdoA;
            this.rdoA.Location = new System.Drawing.Point(166, 205);
            this.rdoA.Name = "rdoA";
            this.rdoA.ShadowDecoration.Parent = this.rdoA;
            this.rdoA.Size = new System.Drawing.Size(20, 20);
            this.rdoA.TabIndex = 24;
            this.rdoA.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdoA.UncheckedState.BorderThickness = 2;
            this.rdoA.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdoA.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdoA.UncheckedState.Parent = this.rdoA;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.label11.Font = new System.Drawing.Font("Baloo 2", 10.8F);
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(779, 194);
            this.label11.Margin = new System.Windows.Forms.Padding(3, 0, 10, 5);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 30);
            this.label11.TabIndex = 36;
            this.label11.Text = "câu";
            // 
            // guna2CustomRadioButton1
            // 
            this.guna2CustomRadioButton1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.guna2CustomRadioButton1.Animated = true;
            this.guna2CustomRadioButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.guna2CustomRadioButton1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(198)))), ((int)(((byte)(203)))));
            this.guna2CustomRadioButton1.CheckedState.BorderThickness = 0;
            this.guna2CustomRadioButton1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(198)))), ((int)(((byte)(203)))));
            this.guna2CustomRadioButton1.CheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2CustomRadioButton1.CheckedState.Parent = this.guna2CustomRadioButton1;
            this.guna2CustomRadioButton1.Location = new System.Drawing.Point(979, 132);
            this.guna2CustomRadioButton1.Name = "guna2CustomRadioButton1";
            this.guna2CustomRadioButton1.ShadowDecoration.Parent = this.guna2CustomRadioButton1;
            this.guna2CustomRadioButton1.Size = new System.Drawing.Size(20, 20);
            this.guna2CustomRadioButton1.TabIndex = 24;
            this.guna2CustomRadioButton1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2CustomRadioButton1.UncheckedState.BorderThickness = 2;
            this.guna2CustomRadioButton1.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.guna2CustomRadioButton1.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.guna2CustomRadioButton1.UncheckedState.Parent = this.guna2CustomRadioButton1;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.label3.Font = new System.Drawing.Font("Baloo 2", 10.8F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(72, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 30);
            this.label3.TabIndex = 26;
            this.label3.Text = "Trình độ:";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.label14.Font = new System.Drawing.Font("Baloo 2", 10.8F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(902, 127);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(71, 30);
            this.label14.TabIndex = 26;
            this.label14.Text = "Lần thi";
            // 
            // dateFrom
            // 
            this.dateFrom.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateFrom.BackColor = System.Drawing.Color.Transparent;
            this.dateFrom.BorderColor = System.Drawing.Color.Silver;
            this.dateFrom.BorderRadius = 1;
            this.dateFrom.Color = System.Drawing.Color.Silver;
            this.dateFrom.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
            this.dateFrom.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.dateFrom.DisabledColor = System.Drawing.Color.Gray;
            this.dateFrom.DisplayWeekNumbers = false;
            this.dateFrom.DPHeight = 0;
            this.dateFrom.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dateFrom.FillDatePicker = false;
            this.dateFrom.Font = new System.Drawing.Font("Baloo 2", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateFrom.ForeColor = System.Drawing.Color.Black;
            this.dateFrom.Icon = ((System.Drawing.Image)(resources.GetObject("dateFrom.Icon")));
            this.dateFrom.IconColor = System.Drawing.Color.Gray;
            this.dateFrom.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.dateFrom.LeftTextMargin = 5;
            this.dateFrom.Location = new System.Drawing.Point(693, 120);
            this.dateFrom.MinimumSize = new System.Drawing.Size(4, 32);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Size = new System.Drawing.Size(188, 44);
            this.dateFrom.TabIndex = 32;
            // 
            // rdoC
            // 
            this.rdoC.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rdoC.Animated = true;
            this.rdoC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.rdoC.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(198)))), ((int)(((byte)(203)))));
            this.rdoC.CheckedState.BorderThickness = 0;
            this.rdoC.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(198)))), ((int)(((byte)(203)))));
            this.rdoC.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdoC.CheckedState.Parent = this.rdoC;
            this.rdoC.Location = new System.Drawing.Point(429, 167);
            this.rdoC.Name = "rdoC";
            this.rdoC.ShadowDecoration.Parent = this.rdoC;
            this.rdoC.Size = new System.Drawing.Size(20, 20);
            this.rdoC.TabIndex = 23;
            this.rdoC.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdoC.UncheckedState.BorderThickness = 2;
            this.rdoC.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdoC.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdoC.UncheckedState.Parent = this.rdoC;
            // 
            // guna2CustomRadioButton2
            // 
            this.guna2CustomRadioButton2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.guna2CustomRadioButton2.Animated = true;
            this.guna2CustomRadioButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.guna2CustomRadioButton2.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(198)))), ((int)(((byte)(203)))));
            this.guna2CustomRadioButton2.CheckedState.BorderThickness = 0;
            this.guna2CustomRadioButton2.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(198)))), ((int)(((byte)(203)))));
            this.guna2CustomRadioButton2.CheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2CustomRadioButton2.CheckedState.Parent = this.guna2CustomRadioButton2;
            this.guna2CustomRadioButton2.Location = new System.Drawing.Point(1047, 132);
            this.guna2CustomRadioButton2.Name = "guna2CustomRadioButton2";
            this.guna2CustomRadioButton2.ShadowDecoration.Parent = this.guna2CustomRadioButton2;
            this.guna2CustomRadioButton2.Size = new System.Drawing.Size(20, 20);
            this.guna2CustomRadioButton2.TabIndex = 23;
            this.guna2CustomRadioButton2.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2CustomRadioButton2.UncheckedState.BorderThickness = 2;
            this.guna2CustomRadioButton2.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.guna2CustomRadioButton2.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.guna2CustomRadioButton2.UncheckedState.Parent = this.guna2CustomRadioButton2;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.label12.Font = new System.Drawing.Font("Baloo 2", 10.8F);
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(1046, 194);
            this.label12.Margin = new System.Windows.Forms.Padding(3, 0, 10, 5);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 30);
            this.label12.TabIndex = 36;
            this.label12.Text = "phút";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.bunifuPanel1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1397, 319);
            this.panel1.TabIndex = 35;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::TracNghiemCSDLPT.Properties.Resources.note;
            this.pictureBox1.Location = new System.Drawing.Point(19, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(243, 287);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BorderRadius = 3;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.label12);
            this.bunifuPanel1.Controls.Add(this.label8);
            this.bunifuPanel1.Controls.Add(this.rdoC);
            this.bunifuPanel1.Controls.Add(this.label9);
            this.bunifuPanel1.Controls.Add(this.label5);
            this.bunifuPanel1.Controls.Add(this.guna2ComboBox1);
            this.bunifuPanel1.Controls.Add(this.label6);
            this.bunifuPanel1.Controls.Add(this.label1);
            this.bunifuPanel1.Controls.Add(this.label3);
            this.bunifuPanel1.Controls.Add(this.MHCombo);
            this.bunifuPanel1.Controls.Add(this.guna2CustomRadioButton2);
            this.bunifuPanel1.Controls.Add(this.label10);
            this.bunifuPanel1.Controls.Add(this.rdoB);
            this.bunifuPanel1.Controls.Add(this.spinEdit2);
            this.bunifuPanel1.Controls.Add(this.rdoA);
            this.bunifuPanel1.Controls.Add(this.label2);
            this.bunifuPanel1.Controls.Add(this.dateFrom);
            this.bunifuPanel1.Controls.Add(this.label7);
            this.bunifuPanel1.Controls.Add(this.label4);
            this.bunifuPanel1.Controls.Add(this.LookUpGV);
            this.bunifuPanel1.Controls.Add(this.label14);
            this.bunifuPanel1.Controls.Add(this.label13);
            this.bunifuPanel1.Controls.Add(this.guna2CustomRadioButton1);
            this.bunifuPanel1.Controls.Add(this.label15);
            this.bunifuPanel1.Controls.Add(this.label11);
            this.bunifuPanel1.Controls.Add(this.spinEdit1);
            this.bunifuPanel1.Location = new System.Drawing.Point(268, 12);
            this.bunifuPanel1.Margin = new System.Windows.Forms.Padding(3, 3, 30, 3);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(1099, 287);
            this.bunifuPanel1.TabIndex = 37;
            // 
            // GVDKGridControl
            // 
            this.GVDKGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GVDKGridControl.DataSource = this.GVDKBindingSource;
            this.GVDKGridControl.Font = new System.Drawing.Font("Teko SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GVDKGridControl.Location = new System.Drawing.Point(12, 439);
            this.GVDKGridControl.MainView = this.GVDKGridView;
            this.GVDKGridControl.Name = "GVDKGridControl";
            this.GVDKGridControl.Size = new System.Drawing.Size(1405, 370);
            this.GVDKGridControl.TabIndex = 36;
            this.GVDKGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GVDKGridView,
            this.cardView1});
            // 
            // GVDKBindingSource
            // 
            this.GVDKBindingSource.DataMember = "GIAOVIEN_DANGKY";
            this.GVDKBindingSource.DataSource = this.TN_CSDLPTDataSet;
            // 
            // GVDKGridView
            // 
            this.GVDKGridView.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.GVDKGridView.Appearance.EvenRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(70)))), ((int)(((byte)(68)))));
            this.GVDKGridView.Appearance.EvenRow.Options.UseBackColor = true;
            this.GVDKGridView.Appearance.EvenRow.Options.UseForeColor = true;
            this.GVDKGridView.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(255)))), ((int)(((byte)(215)))));
            this.GVDKGridView.Appearance.FocusedCell.Options.UseBackColor = true;
            this.GVDKGridView.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(255)))), ((int)(((byte)(215)))));
            this.GVDKGridView.Appearance.FocusedRow.Options.UseBackColor = true;
            this.GVDKGridView.Appearance.GroupRow.Font = new System.Drawing.Font("Baloo 2", 10.2F);
            this.GVDKGridView.Appearance.GroupRow.Options.UseFont = true;
            this.GVDKGridView.Appearance.HeaderPanel.Font = new System.Drawing.Font("Baloo 2", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GVDKGridView.Appearance.HeaderPanel.Options.UseFont = true;
            this.GVDKGridView.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(255)))), ((int)(((byte)(215)))));
            this.GVDKGridView.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.GVDKGridView.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.GVDKGridView.Appearance.OddRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(70)))), ((int)(((byte)(68)))));
            this.GVDKGridView.Appearance.OddRow.Options.UseBackColor = true;
            this.GVDKGridView.Appearance.OddRow.Options.UseForeColor = true;
            this.GVDKGridView.Appearance.Preview.Font = new System.Drawing.Font("Baloo 2", 10.2F);
            this.GVDKGridView.Appearance.Preview.Options.UseFont = true;
            this.GVDKGridView.Appearance.Row.Font = new System.Drawing.Font("Baloo 2", 12F);
            this.GVDKGridView.Appearance.Row.Options.UseFont = true;
            this.GVDKGridView.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(255)))), ((int)(((byte)(215)))));
            this.GVDKGridView.Appearance.SelectedRow.Font = new System.Drawing.Font("Baloo 2", 12F);
            this.GVDKGridView.Appearance.SelectedRow.Options.UseBackColor = true;
            this.GVDKGridView.Appearance.SelectedRow.Options.UseFont = true;
            this.GVDKGridView.Appearance.TopNewRow.Font = new System.Drawing.Font("Baloo 2", 10.2F);
            this.GVDKGridView.Appearance.TopNewRow.Options.UseFont = true;
            this.GVDKGridView.Appearance.ViewCaption.Font = new System.Drawing.Font("Baloo 2", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GVDKGridView.Appearance.ViewCaption.Options.UseFont = true;
            this.GVDKGridView.AppearancePrint.OddRow.BackColor = System.Drawing.Color.DimGray;
            this.GVDKGridView.AppearancePrint.OddRow.Options.UseBackColor = true;
            this.GVDKGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAGV1,
            this.colMAMH,
            this.colMALOP,
            this.colTRINHDO,
            this.colNGAYTHI,
            this.colLAN,
            this.colSOCAUTHI,
            this.colTHOIGIAN});
            this.GVDKGridView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.GVDKGridView.GridControl = this.GVDKGridControl;
            this.GVDKGridView.Name = "GVDKGridView";
            this.GVDKGridView.OptionsBehavior.Editable = false;
            this.GVDKGridView.OptionsBehavior.ReadOnly = true;
            this.GVDKGridView.OptionsCustomization.AllowRowSizing = true;
            this.GVDKGridView.OptionsDetail.EnableMasterViewMode = false;
            this.GVDKGridView.OptionsPrint.EnableAppearanceOddRow = true;
            this.GVDKGridView.OptionsScrollAnnotations.ShowFocusedRow = DevExpress.Utils.DefaultBoolean.True;
            this.GVDKGridView.OptionsView.EnableAppearanceOddRow = true;
            this.GVDKGridView.OptionsView.ShowGroupPanel = false;
            this.GVDKGridView.OptionsView.ShowIndicator = false;
            this.GVDKGridView.OptionsView.ShowViewCaption = true;
            this.GVDKGridView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colTHOIGIAN, DevExpress.Data.ColumnSortOrder.Descending)});
            this.GVDKGridView.ViewCaption = "Danh sách đăng ký thi trắc nghiệm";
            // 
            // colMAGV1
            // 
            this.colMAGV1.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(164)))), ((int)(((byte)(236)))));
            this.colMAGV1.AppearanceHeader.Options.UseBackColor = true;
            this.colMAGV1.Caption = "Mã GV";
            this.colMAGV1.FieldName = "MAGV";
            this.colMAGV1.MinWidth = 25;
            this.colMAGV1.Name = "colMAGV1";
            this.colMAGV1.Visible = true;
            this.colMAGV1.VisibleIndex = 0;
            this.colMAGV1.Width = 94;
            // 
            // colMAMH
            // 
            this.colMAMH.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(164)))), ((int)(((byte)(236)))));
            this.colMAMH.AppearanceHeader.Options.UseBackColor = true;
            this.colMAMH.Caption = "Mã môn học";
            this.colMAMH.FieldName = "MAMH";
            this.colMAMH.MinWidth = 25;
            this.colMAMH.Name = "colMAMH";
            this.colMAMH.Visible = true;
            this.colMAMH.VisibleIndex = 1;
            this.colMAMH.Width = 94;
            // 
            // colMALOP
            // 
            this.colMALOP.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(164)))), ((int)(((byte)(236)))));
            this.colMALOP.AppearanceHeader.Options.UseBackColor = true;
            this.colMALOP.Caption = "Mã lớp";
            this.colMALOP.FieldName = "MALOP";
            this.colMALOP.MinWidth = 25;
            this.colMALOP.Name = "colMALOP";
            this.colMALOP.Visible = true;
            this.colMALOP.VisibleIndex = 2;
            this.colMALOP.Width = 94;
            // 
            // colTRINHDO
            // 
            this.colTRINHDO.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(164)))), ((int)(((byte)(236)))));
            this.colTRINHDO.AppearanceHeader.Options.UseBackColor = true;
            this.colTRINHDO.Caption = "Trình độ";
            this.colTRINHDO.FieldName = "TRINHDO";
            this.colTRINHDO.MinWidth = 25;
            this.colTRINHDO.Name = "colTRINHDO";
            this.colTRINHDO.Visible = true;
            this.colTRINHDO.VisibleIndex = 3;
            this.colTRINHDO.Width = 94;
            // 
            // colNGAYTHI
            // 
            this.colNGAYTHI.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(164)))), ((int)(((byte)(236)))));
            this.colNGAYTHI.AppearanceHeader.Options.UseBackColor = true;
            this.colNGAYTHI.Caption = "Ngày thi";
            this.colNGAYTHI.FieldName = "NGAYTHI";
            this.colNGAYTHI.MinWidth = 25;
            this.colNGAYTHI.Name = "colNGAYTHI";
            this.colNGAYTHI.Visible = true;
            this.colNGAYTHI.VisibleIndex = 4;
            this.colNGAYTHI.Width = 94;
            // 
            // colLAN
            // 
            this.colLAN.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(164)))), ((int)(((byte)(236)))));
            this.colLAN.AppearanceHeader.Options.UseBackColor = true;
            this.colLAN.Caption = "Lần thi";
            this.colLAN.FieldName = "LAN";
            this.colLAN.MinWidth = 25;
            this.colLAN.Name = "colLAN";
            this.colLAN.Visible = true;
            this.colLAN.VisibleIndex = 5;
            this.colLAN.Width = 94;
            // 
            // colSOCAUTHI
            // 
            this.colSOCAUTHI.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(164)))), ((int)(((byte)(236)))));
            this.colSOCAUTHI.AppearanceHeader.Options.UseBackColor = true;
            this.colSOCAUTHI.Caption = "Số câu thi";
            this.colSOCAUTHI.FieldName = "SOCAUTHI";
            this.colSOCAUTHI.MinWidth = 25;
            this.colSOCAUTHI.Name = "colSOCAUTHI";
            this.colSOCAUTHI.Visible = true;
            this.colSOCAUTHI.VisibleIndex = 6;
            this.colSOCAUTHI.Width = 94;
            // 
            // colTHOIGIAN
            // 
            this.colTHOIGIAN.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(164)))), ((int)(((byte)(236)))));
            this.colTHOIGIAN.AppearanceHeader.Options.UseBackColor = true;
            this.colTHOIGIAN.Caption = "Thời gian";
            this.colTHOIGIAN.FieldName = "THOIGIAN";
            this.colTHOIGIAN.MinWidth = 25;
            this.colTHOIGIAN.Name = "colTHOIGIAN";
            this.colTHOIGIAN.Visible = true;
            this.colTHOIGIAN.VisibleIndex = 7;
            this.colTHOIGIAN.Width = 94;
            // 
            // cardView1
            // 
            this.cardView1.GridControl = this.GVDKGridControl;
            this.cardView1.Name = "cardView1";
            this.cardView1.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Auto;
            // 
            // GVDKTableAdapter
            // 
            this.GVDKTableAdapter.ClearBeforeFill = true;
            // 
            // FormDKThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1429, 821);
            this.Controls.Add(this.GVDKGridControl);
            this.Controls.Add(this.panel1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("FormDKThi.IconOptions.Icon")));
            this.Name = "FormDKThi";
            this.Text = "Đăng ký thi";
            this.Load += new System.EventHandler(this.FormDKThi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TN_CSDLPTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MonHocBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LopBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpGV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit1.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.bunifuPanel1.ResumeLayout(false);
            this.bunifuPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GVDKGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GVDKBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GVDKGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TN_CSDLPTDataSet TN_CSDLPTDataSet;
        private System.Windows.Forms.BindingSource MonHocBindingSource;
        private TN_CSDLPTDataSetTableAdapters.MONHOCTableAdapter MonHocTableAdapter;
        private TN_CSDLPTDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource LopBindingSource;
        private TN_CSDLPTDataSetTableAdapters.LOPTableAdapter LopTableAdapter;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox MHCombo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private DevExpress.XtraEditors.SpinEdit spinEdit2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.GridLookUpEdit LookUpGV;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colMAGV;
        private DevExpress.XtraGrid.Columns.GridColumn colHoTen;
        private System.Windows.Forms.Label label13;
        private Guna.UI2.WinForms.Guna2CustomRadioButton rdoB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label15;
        private DevExpress.XtraEditors.SpinEdit spinEdit1;
        private Guna.UI2.WinForms.Guna2CustomRadioButton rdoA;
        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2CustomRadioButton guna2CustomRadioButton1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label14;
        private Bunifu.UI.WinForms.BunifuDatePicker dateFrom;
        private Guna.UI2.WinForms.Guna2CustomRadioButton rdoC;
        private Guna.UI2.WinForms.Guna2CustomRadioButton guna2CustomRadioButton2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl GVDKGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView GVDKGridView;
        private DevExpress.XtraGrid.Views.Card.CardView cardView1;
        private System.Windows.Forms.BindingSource GVDKBindingSource;
        private TN_CSDLPTDataSetTableAdapters.GIAOVIEN_DANGKYTableAdapter GVDKTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colMAGV1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAMH;
        private DevExpress.XtraGrid.Columns.GridColumn colMALOP;
        private DevExpress.XtraGrid.Columns.GridColumn colTRINHDO;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYTHI;
        private DevExpress.XtraGrid.Columns.GridColumn colLAN;
        private DevExpress.XtraGrid.Columns.GridColumn colSOCAUTHI;
        private DevExpress.XtraGrid.Columns.GridColumn colTHOIGIAN;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
    }
}