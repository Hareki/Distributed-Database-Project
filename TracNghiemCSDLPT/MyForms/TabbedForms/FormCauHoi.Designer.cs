
namespace TracNghiemCSDLPT.MyForms.TabbedForms
{
    partial class FormCauHoi
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCauHoi));
            this.BoDeGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCAUHOI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTRINHDO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNOIDUNG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAGV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MonHocGridControl = new DevExpress.XtraGrid.GridControl();
            this.MonHocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TN_CSDLPTDataSet = new TracNghiemCSDLPT.TN_CSDLPTDataSet();
            this.MonHocGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MonHocTableAdapter = new TracNghiemCSDLPT.TN_CSDLPTDataSetTableAdapters.MONHOCTableAdapter();
            this.tableAdapterManager = new TracNghiemCSDLPT.TN_CSDLPTDataSetTableAdapters.TableAdapterManager();
            this.rdoDA_A = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.rdoDA_C = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.rdoDA_B = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.rdoDA_D = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.labelDapAn = new System.Windows.Forms.Label();
            this.BoDeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.rdoA = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.rdoB = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rdoC = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.labelGVSoan = new System.Windows.Forms.Label();
            this.DSGVTCSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textMaCH = new DevExpress.XtraEditors.TextEdit();
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            this.label13 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.MHCombo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.MH2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.bunifuPanel2 = new Bunifu.UI.WinForms.BunifuPanel();
            this.InfoPanel = new System.Windows.Forms.Panel();
            this.textNoiDung = new DevExpress.XtraEditors.MemoEdit();
            this.TableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.PanelBD = new System.Windows.Forms.Panel();
            this.textChoiceB = new DevExpress.XtraEditors.MemoEdit();
            this.textChoiceD = new DevExpress.XtraEditors.MemoEdit();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.PanelAC = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.textChoiceC = new DevExpress.XtraEditors.MemoEdit();
            this.textChoiceA = new DevExpress.XtraEditors.MemoEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonLamMoi = new Guna.UI2.WinForms.Guna2Button();
            this.buttonThem = new Guna.UI2.WinForms.Guna2Button();
            this.buttonSua = new Guna.UI2.WinForms.Guna2Button();
            this.buttonXoa = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BoDeTableAdapter = new TracNghiemCSDLPT.TN_CSDLPTDataSetTableAdapters.BODETableAdapter();
            this.MH2TableAdapter = new TracNghiemCSDLPT.TN_CSDLPTDataSetTableAdapters.MONHOC2TableAdapter();
            this.buttonUndo = new Guna.UI2.WinForms.Guna2CircleButton();
            this.buttonRedo = new Guna.UI2.WinForms.Guna2CircleButton();
            this.buttonHuy = new Guna.UI2.WinForms.Guna2CircleButton();
            this.buttonXacNhan = new Guna.UI2.WinForms.Guna2CircleButton();
            this.DSGVTCSTableAdapter = new TracNghiemCSDLPT.TN_CSDLPTDataSetTableAdapters.DSGIAOVIENTCSTableAdapter();
            this.noiDungEP = new System.Windows.Forms.ErrorProvider(this.components);
            this.choiceAEP = new System.Windows.Forms.ErrorProvider(this.components);
            this.choiceBEP = new System.Windows.Forms.ErrorProvider(this.components);
            this.choiceCEP = new System.Windows.Forms.ErrorProvider(this.components);
            this.choiceDEP = new System.Windows.Forms.ErrorProvider(this.components);
            this.maCHEP = new System.Windows.Forms.ErrorProvider(this.components);
            this.BaiThiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BaiThiTableAdapter = new TracNghiemCSDLPT.TN_CSDLPTDataSetTableAdapters.BAITHITableAdapter();
            this.panel4 = new System.Windows.Forms.Panel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.BoDeGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MonHocGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MonHocBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TN_CSDLPTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MonHocGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoDeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSGVTCSBindingSource)).BeginInit();
            this.bunifuPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textMaCH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MH2BindingSource)).BeginInit();
            this.bunifuPanel2.SuspendLayout();
            this.InfoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textNoiDung.Properties)).BeginInit();
            this.TableLayout.SuspendLayout();
            this.PanelBD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textChoiceB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textChoiceD.Properties)).BeginInit();
            this.PanelAC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textChoiceC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textChoiceA.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.noiDungEP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.choiceAEP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.choiceBEP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.choiceCEP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.choiceDEP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maCHEP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaiThiBindingSource)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // BoDeGridView
            // 
            this.BoDeGridView.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.BoDeGridView.Appearance.EvenRow.Options.UseBackColor = true;
            this.BoDeGridView.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(198)))), ((int)(((byte)(203)))));
            this.BoDeGridView.Appearance.FixedLine.Font = new System.Drawing.Font("Baloo 2", 12F, System.Drawing.FontStyle.Bold);
            this.BoDeGridView.Appearance.FixedLine.Options.UseBackColor = true;
            this.BoDeGridView.Appearance.FixedLine.Options.UseFont = true;
            this.BoDeGridView.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(237)))), ((int)(((byte)(211)))));
            this.BoDeGridView.Appearance.FocusedCell.Options.UseBackColor = true;
            this.BoDeGridView.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(237)))), ((int)(((byte)(211)))));
            this.BoDeGridView.Appearance.FocusedRow.Options.UseBackColor = true;
            this.BoDeGridView.Appearance.GroupPanel.Font = new System.Drawing.Font("Baloo 2", 13.8F, System.Drawing.FontStyle.Bold);
            this.BoDeGridView.Appearance.GroupPanel.Options.UseFont = true;
            this.BoDeGridView.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(198)))), ((int)(((byte)(203)))));
            this.BoDeGridView.Appearance.HeaderPanel.Font = new System.Drawing.Font("Baloo 2", 12F, System.Drawing.FontStyle.Bold);
            this.BoDeGridView.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.BoDeGridView.Appearance.HeaderPanel.Options.UseFont = true;
            this.BoDeGridView.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(237)))), ((int)(((byte)(211)))));
            this.BoDeGridView.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.BoDeGridView.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.BoDeGridView.Appearance.OddRow.Options.UseBackColor = true;
            this.BoDeGridView.Appearance.Row.Font = new System.Drawing.Font("Baloo 2", 12F);
            this.BoDeGridView.Appearance.Row.Options.UseFont = true;
            this.BoDeGridView.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(237)))), ((int)(((byte)(211)))));
            this.BoDeGridView.Appearance.SelectedRow.Options.UseBackColor = true;
            this.BoDeGridView.Appearance.ViewCaption.Font = new System.Drawing.Font("Baloo 2", 13.8F, System.Drawing.FontStyle.Bold);
            this.BoDeGridView.Appearance.ViewCaption.Options.UseFont = true;
            this.BoDeGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCAUHOI,
            this.colTRINHDO,
            this.colNOIDUNG,
            this.colMAGV});
            this.BoDeGridView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.BoDeGridView.GridControl = this.MonHocGridControl;
            this.BoDeGridView.Name = "BoDeGridView";
            this.BoDeGridView.OptionsBehavior.Editable = false;
            this.BoDeGridView.OptionsDetail.EnableMasterViewMode = false;
            this.BoDeGridView.OptionsPrint.EnableAppearanceOddRow = true;
            this.BoDeGridView.OptionsScrollAnnotations.ShowFocusedRow = DevExpress.Utils.DefaultBoolean.True;
            this.BoDeGridView.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.AnimateAllContent;
            this.BoDeGridView.OptionsView.EnableAppearanceEvenRow = true;
            this.BoDeGridView.OptionsView.EnableAppearanceOddRow = true;
            this.BoDeGridView.OptionsView.ShowGroupPanel = false;
            this.BoDeGridView.ViewCaption = "Lớp";
            this.BoDeGridView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.BoDeGridView_FocusedRowChanged);
            // 
            // colCAUHOI
            // 
            this.colCAUHOI.AppearanceCell.Options.UseTextOptions = true;
            this.colCAUHOI.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCAUHOI.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(198)))), ((int)(((byte)(203)))));
            this.colCAUHOI.AppearanceHeader.Options.UseBackColor = true;
            this.colCAUHOI.Caption = "Mã câu";
            this.colCAUHOI.FieldName = "CAUHOI";
            this.colCAUHOI.MinWidth = 25;
            this.colCAUHOI.Name = "colCAUHOI";
            this.colCAUHOI.OptionsColumn.FixedWidth = true;
            this.colCAUHOI.Visible = true;
            this.colCAUHOI.VisibleIndex = 0;
            this.colCAUHOI.Width = 85;
            // 
            // colTRINHDO
            // 
            this.colTRINHDO.AppearanceCell.Options.UseTextOptions = true;
            this.colTRINHDO.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTRINHDO.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(198)))), ((int)(((byte)(203)))));
            this.colTRINHDO.AppearanceHeader.Options.UseBackColor = true;
            this.colTRINHDO.Caption = "Trình độ";
            this.colTRINHDO.FieldName = "TRINHDO";
            this.colTRINHDO.MinWidth = 25;
            this.colTRINHDO.Name = "colTRINHDO";
            this.colTRINHDO.OptionsColumn.FixedWidth = true;
            this.colTRINHDO.Visible = true;
            this.colTRINHDO.VisibleIndex = 1;
            this.colTRINHDO.Width = 85;
            // 
            // colNOIDUNG
            // 
            this.colNOIDUNG.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(198)))), ((int)(((byte)(203)))));
            this.colNOIDUNG.AppearanceHeader.Options.UseBackColor = true;
            this.colNOIDUNG.Caption = "Nội dung";
            this.colNOIDUNG.FieldName = "NOIDUNG";
            this.colNOIDUNG.MinWidth = 25;
            this.colNOIDUNG.Name = "colNOIDUNG";
            this.colNOIDUNG.Visible = true;
            this.colNOIDUNG.VisibleIndex = 2;
            this.colNOIDUNG.Width = 537;
            // 
            // colMAGV
            // 
            this.colMAGV.AppearanceCell.Options.UseTextOptions = true;
            this.colMAGV.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMAGV.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(198)))), ((int)(((byte)(203)))));
            this.colMAGV.AppearanceHeader.Options.UseBackColor = true;
            this.colMAGV.Caption = "Mã GV soạn";
            this.colMAGV.FieldName = "MAGV";
            this.colMAGV.MinWidth = 25;
            this.colMAGV.Name = "colMAGV";
            this.colMAGV.OptionsColumn.FixedWidth = true;
            this.colMAGV.Visible = true;
            this.colMAGV.VisibleIndex = 3;
            this.colMAGV.Width = 125;
            // 
            // MonHocGridControl
            // 
            this.MonHocGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MonHocGridControl.DataSource = this.MonHocBindingSource;
            this.MonHocGridControl.Font = new System.Drawing.Font("Teko SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            gridLevelNode1.LevelTemplate = this.BoDeGridView;
            gridLevelNode1.RelationName = "FK_BODE_MONHOC";
            this.MonHocGridControl.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.MonHocGridControl.Location = new System.Drawing.Point(148, 393);
            this.MonHocGridControl.MainView = this.MonHocGridView;
            this.MonHocGridControl.Margin = new System.Windows.Forms.Padding(0);
            this.MonHocGridControl.Name = "MonHocGridControl";
            this.MonHocGridControl.Size = new System.Drawing.Size(1277, 261);
            this.MonHocGridControl.TabIndex = 14;
            this.MonHocGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.MonHocGridView,
            this.BoDeGridView});
            // 
            // MonHocBindingSource
            // 
            this.MonHocBindingSource.DataMember = "MONHOC";
            this.MonHocBindingSource.DataSource = this.TN_CSDLPTDataSet;
            // 
            // TN_CSDLPTDataSet
            // 
            this.TN_CSDLPTDataSet.DataSetName = "TN_CSDLPTDataSet";
            this.TN_CSDLPTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // MonHocGridView
            // 
            this.MonHocGridView.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.MonHocGridView.Appearance.EvenRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(70)))), ((int)(((byte)(68)))));
            this.MonHocGridView.Appearance.EvenRow.Options.UseBackColor = true;
            this.MonHocGridView.Appearance.EvenRow.Options.UseForeColor = true;
            this.MonHocGridView.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(255)))), ((int)(((byte)(215)))));
            this.MonHocGridView.Appearance.FocusedCell.Options.UseBackColor = true;
            this.MonHocGridView.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(255)))), ((int)(((byte)(215)))));
            this.MonHocGridView.Appearance.FocusedRow.Options.UseBackColor = true;
            this.MonHocGridView.Appearance.GroupRow.Font = new System.Drawing.Font("Baloo 2", 10.2F);
            this.MonHocGridView.Appearance.GroupRow.Options.UseFont = true;
            this.MonHocGridView.Appearance.HeaderPanel.Font = new System.Drawing.Font("Baloo 2", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MonHocGridView.Appearance.HeaderPanel.Options.UseFont = true;
            this.MonHocGridView.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(255)))), ((int)(((byte)(215)))));
            this.MonHocGridView.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.MonHocGridView.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.MonHocGridView.Appearance.OddRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(70)))), ((int)(((byte)(68)))));
            this.MonHocGridView.Appearance.OddRow.Options.UseBackColor = true;
            this.MonHocGridView.Appearance.OddRow.Options.UseForeColor = true;
            this.MonHocGridView.Appearance.Preview.Font = new System.Drawing.Font("Baloo 2", 10.2F);
            this.MonHocGridView.Appearance.Preview.Options.UseFont = true;
            this.MonHocGridView.Appearance.Row.Font = new System.Drawing.Font("Baloo 2", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MonHocGridView.Appearance.Row.Options.UseFont = true;
            this.MonHocGridView.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(255)))), ((int)(((byte)(215)))));
            this.MonHocGridView.Appearance.SelectedRow.Font = new System.Drawing.Font("Baloo 2", 12F);
            this.MonHocGridView.Appearance.SelectedRow.Options.UseBackColor = true;
            this.MonHocGridView.Appearance.SelectedRow.Options.UseFont = true;
            this.MonHocGridView.Appearance.TopNewRow.Font = new System.Drawing.Font("Baloo 2", 10.2F);
            this.MonHocGridView.Appearance.TopNewRow.Options.UseFont = true;
            this.MonHocGridView.Appearance.ViewCaption.Font = new System.Drawing.Font("Baloo 2", 13.8F, System.Drawing.FontStyle.Bold);
            this.MonHocGridView.Appearance.ViewCaption.Options.UseFont = true;
            this.MonHocGridView.Appearance.ViewCaption.Options.UseTextOptions = true;
            this.MonHocGridView.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.MonHocGridView.Appearance.ViewCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.MonHocGridView.AppearancePrint.OddRow.BackColor = System.Drawing.Color.DimGray;
            this.MonHocGridView.AppearancePrint.OddRow.Options.UseBackColor = true;
            this.MonHocGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAMH,
            this.colTENMH});
            this.MonHocGridView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.MonHocGridView.GridControl = this.MonHocGridControl;
            this.MonHocGridView.Name = "MonHocGridView";
            this.MonHocGridView.OptionsBehavior.AllowGroupExpandAnimation = DevExpress.Utils.DefaultBoolean.True;
            this.MonHocGridView.OptionsBehavior.AllowSortAnimation = DevExpress.Utils.DefaultBoolean.True;
            this.MonHocGridView.OptionsBehavior.AutoExpandAllGroups = true;
            this.MonHocGridView.OptionsBehavior.Editable = false;
            this.MonHocGridView.OptionsBehavior.ReadOnly = true;
            this.MonHocGridView.OptionsCustomization.AllowRowSizing = true;
            this.MonHocGridView.OptionsPrint.EnableAppearanceOddRow = true;
            this.MonHocGridView.OptionsScrollAnnotations.ShowFocusedRow = DevExpress.Utils.DefaultBoolean.True;
            this.MonHocGridView.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.AnimateAllContent;
            this.MonHocGridView.OptionsView.EnableAppearanceOddRow = true;
            this.MonHocGridView.OptionsView.ShowGroupPanel = false;
            this.MonHocGridView.OptionsView.ShowIndicator = false;
            this.MonHocGridView.OptionsView.ShowViewCaption = true;
            this.MonHocGridView.ViewCaption = "Danh sách câu hỏi theo môn học";
            this.MonHocGridView.MasterRowGetRelationDisplayCaption += new DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationNameEventHandler(this.MonHocGridView_MasterRowGetRelationDisplayCaption);
            this.MonHocGridView.DetailTabStyle += new System.EventHandler<DevExpress.XtraGrid.Views.Grid.DetailTabStyleEventArgs>(this.MonHocGridView_DetailTabStyle);
            this.MonHocGridView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.MonHocGridView_FocusedRowChanged);
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
            this.colMAMH.VisibleIndex = 0;
            this.colMAMH.Width = 94;
            // 
            // colTENMH
            // 
            this.colTENMH.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(164)))), ((int)(((byte)(236)))));
            this.colTENMH.AppearanceHeader.Options.UseBackColor = true;
            this.colTENMH.Caption = "Tên môn học";
            this.colTENMH.FieldName = "TENMH";
            this.colTENMH.MinWidth = 25;
            this.colTENMH.Name = "colTENMH";
            this.colTENMH.Visible = true;
            this.colTENMH.VisibleIndex = 1;
            this.colTENMH.Width = 94;
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
            // rdoDA_A
            // 
            this.rdoDA_A.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.rdoDA_A.Animated = true;
            this.rdoDA_A.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdoDA_A.CheckedState.BorderThickness = 0;
            this.rdoDA_A.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdoDA_A.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdoDA_A.CheckedState.Parent = this.rdoDA_A;
            this.rdoDA_A.Location = new System.Drawing.Point(21, 53);
            this.rdoDA_A.Name = "rdoDA_A";
            this.rdoDA_A.ShadowDecoration.Parent = this.rdoDA_A;
            this.rdoDA_A.Size = new System.Drawing.Size(20, 20);
            this.rdoDA_A.TabIndex = 16;
            this.rdoDA_A.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdoDA_A.UncheckedState.BorderThickness = 2;
            this.rdoDA_A.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdoDA_A.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdoDA_A.UncheckedState.Parent = this.rdoDA_A;
            this.rdoDA_A.CheckedChanged += new System.EventHandler(this.rdoDA_A_CheckedChanged);
            // 
            // rdoDA_C
            // 
            this.rdoDA_C.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.rdoDA_C.Animated = true;
            this.rdoDA_C.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdoDA_C.CheckedState.BorderThickness = 0;
            this.rdoDA_C.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdoDA_C.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdoDA_C.CheckedState.Parent = this.rdoDA_C;
            this.rdoDA_C.Location = new System.Drawing.Point(22, 128);
            this.rdoDA_C.Name = "rdoDA_C";
            this.rdoDA_C.ShadowDecoration.Parent = this.rdoDA_C;
            this.rdoDA_C.Size = new System.Drawing.Size(20, 20);
            this.rdoDA_C.TabIndex = 16;
            this.rdoDA_C.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdoDA_C.UncheckedState.BorderThickness = 2;
            this.rdoDA_C.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdoDA_C.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdoDA_C.UncheckedState.Parent = this.rdoDA_C;
            this.rdoDA_C.CheckedChanged += new System.EventHandler(this.rdoDA_A_CheckedChanged);
            // 
            // rdoDA_B
            // 
            this.rdoDA_B.Animated = true;
            this.rdoDA_B.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdoDA_B.CheckedState.BorderThickness = 0;
            this.rdoDA_B.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdoDA_B.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdoDA_B.CheckedState.Parent = this.rdoDA_B;
            this.rdoDA_B.Location = new System.Drawing.Point(22, 53);
            this.rdoDA_B.Name = "rdoDA_B";
            this.rdoDA_B.ShadowDecoration.Parent = this.rdoDA_B;
            this.rdoDA_B.Size = new System.Drawing.Size(21, 20);
            this.rdoDA_B.TabIndex = 16;
            this.rdoDA_B.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdoDA_B.UncheckedState.BorderThickness = 2;
            this.rdoDA_B.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdoDA_B.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdoDA_B.UncheckedState.Parent = this.rdoDA_B;
            this.rdoDA_B.CheckedChanged += new System.EventHandler(this.rdoDA_A_CheckedChanged);
            // 
            // rdoDA_D
            // 
            this.rdoDA_D.Animated = true;
            this.rdoDA_D.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdoDA_D.CheckedState.BorderThickness = 0;
            this.rdoDA_D.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdoDA_D.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdoDA_D.CheckedState.Parent = this.rdoDA_D;
            this.rdoDA_D.Location = new System.Drawing.Point(23, 128);
            this.rdoDA_D.Name = "rdoDA_D";
            this.rdoDA_D.ShadowDecoration.Parent = this.rdoDA_D;
            this.rdoDA_D.Size = new System.Drawing.Size(21, 20);
            this.rdoDA_D.TabIndex = 16;
            this.rdoDA_D.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdoDA_D.UncheckedState.BorderThickness = 2;
            this.rdoDA_D.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdoDA_D.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdoDA_D.UncheckedState.Parent = this.rdoDA_D;
            this.rdoDA_D.CheckedChanged += new System.EventHandler(this.rdoDA_A_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Baloo 2", 10.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(31, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 60);
            this.label1.TabIndex = 17;
            this.label1.Text = "Nội dung";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.Image = global::TracNghiemCSDLPT.Properties.Resources.info_480px;
            this.pictureBox1.Location = new System.Drawing.Point(21, 208);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox1, "-Đáp án: nhấp vào các lựa chọn ở trên để đặt nó làm đáp án.\r\n-Giáo viên soạn: Đượ" +
        "c lấy tự động theo thông tin đăng nhập, không thể sửa.\r\n-Mã câu hỏi: Nhập vào mộ" +
        "t số nguyên dương và không trùng.\r\n");
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 10000;
            this.toolTip1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(70)))), ((int)(((byte)(68)))));
            this.toolTip1.InitialDelay = 500;
            this.toolTip1.ReshowDelay = 100;
            this.toolTip1.ShowAlways = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Một số lưu ý";
            // 
            // labelDapAn
            // 
            this.labelDapAn.AutoSize = true;
            this.labelDapAn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.labelDapAn.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BoDeBindingSource, "DAP_AN", true));
            this.labelDapAn.Font = new System.Drawing.Font("Baloo 2", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDapAn.Location = new System.Drawing.Point(155, 4);
            this.labelDapAn.Name = "labelDapAn";
            this.labelDapAn.Size = new System.Drawing.Size(24, 30);
            this.labelDapAn.TabIndex = 19;
            this.labelDapAn.Text = "A";
            this.labelDapAn.TextChanged += new System.EventHandler(this.LabelDapAn_TextChanged);
            // 
            // BoDeBindingSource
            // 
            this.BoDeBindingSource.DataMember = "BODE";
            this.BoDeBindingSource.DataSource = this.TN_CSDLPTDataSet;
            this.BoDeBindingSource.CurrentItemChanged += new System.EventHandler(this.BoDeBindingSource_CurrentItemChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.label3.Font = new System.Drawing.Font("Baloo 2", 10.8F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(3, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 30);
            this.label3.TabIndex = 17;
            this.label3.Text = "Trình độ:";
            // 
            // rdoA
            // 
            this.rdoA.Animated = true;
            this.rdoA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.rdoA.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(198)))), ((int)(((byte)(203)))));
            this.rdoA.CheckedState.BorderThickness = 0;
            this.rdoA.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(198)))), ((int)(((byte)(203)))));
            this.rdoA.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdoA.CheckedState.Parent = this.rdoA;
            this.rdoA.Location = new System.Drawing.Point(95, 14);
            this.rdoA.Name = "rdoA";
            this.rdoA.ShadowDecoration.Parent = this.rdoA;
            this.rdoA.Size = new System.Drawing.Size(20, 20);
            this.rdoA.TabIndex = 0;
            this.rdoA.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdoA.UncheckedState.BorderThickness = 2;
            this.rdoA.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdoA.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdoA.UncheckedState.Parent = this.rdoA;
            // 
            // rdoB
            // 
            this.rdoB.Animated = true;
            this.rdoB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.rdoB.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(198)))), ((int)(((byte)(203)))));
            this.rdoB.CheckedState.BorderThickness = 0;
            this.rdoB.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(198)))), ((int)(((byte)(203)))));
            this.rdoB.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdoB.CheckedState.Parent = this.rdoB;
            this.rdoB.Location = new System.Drawing.Point(95, 46);
            this.rdoB.Name = "rdoB";
            this.rdoB.ShadowDecoration.Parent = this.rdoB;
            this.rdoB.Size = new System.Drawing.Size(20, 20);
            this.rdoB.TabIndex = 0;
            this.rdoB.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdoB.UncheckedState.BorderThickness = 2;
            this.rdoB.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdoB.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdoB.UncheckedState.Parent = this.rdoB;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.label4.Font = new System.Drawing.Font("Baloo 2", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(121, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(217, 30);
            this.label4.TabIndex = 19;
            this.label4.Text = "Đại học, chuyên ngành (A)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.label5.Font = new System.Drawing.Font("Baloo 2", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(121, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(271, 30);
            this.label5.TabIndex = 19;
            this.label5.Text = "Đại học, không chuyên ngành (B)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.label6.Font = new System.Drawing.Font("Baloo 2", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(121, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 30);
            this.label6.TabIndex = 19;
            this.label6.Text = "Cao đẳng (C)";
            // 
            // rdoC
            // 
            this.rdoC.Animated = true;
            this.rdoC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.rdoC.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(198)))), ((int)(((byte)(203)))));
            this.rdoC.CheckedState.BorderThickness = 0;
            this.rdoC.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(198)))), ((int)(((byte)(203)))));
            this.rdoC.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdoC.CheckedState.Parent = this.rdoC;
            this.rdoC.Location = new System.Drawing.Point(95, 78);
            this.rdoC.Name = "rdoC";
            this.rdoC.ShadowDecoration.Parent = this.rdoC;
            this.rdoC.Size = new System.Drawing.Size(20, 20);
            this.rdoC.TabIndex = 0;
            this.rdoC.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdoC.UncheckedState.BorderThickness = 2;
            this.rdoC.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdoC.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdoC.UncheckedState.Parent = this.rdoC;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.label7.Font = new System.Drawing.Font("Baloo 2", 10.8F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(7, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 30);
            this.label7.TabIndex = 17;
            this.label7.Text = "Giáo viên soạn:";
            // 
            // labelGVSoan
            // 
            this.labelGVSoan.AutoSize = true;
            this.labelGVSoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.labelGVSoan.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.DSGVTCSBindingSource, "FullInfo", true));
            this.labelGVSoan.Font = new System.Drawing.Font("Baloo 2", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGVSoan.Location = new System.Drawing.Point(155, 32);
            this.labelGVSoan.Name = "labelGVSoan";
            this.labelGVSoan.Size = new System.Drawing.Size(181, 30);
            this.labelGVSoan.TabIndex = 19;
            this.labelGVSoan.Text = "Phan Văn Hải - TH139";
            // 
            // DSGVTCSBindingSource
            // 
            this.DSGVTCSBindingSource.DataMember = "DSGIAOVIENTCS";
            this.DSGVTCSBindingSource.DataSource = this.TN_CSDLPTDataSet;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.label9.Font = new System.Drawing.Font("Baloo 2", 10.8F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(41, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 30);
            this.label9.TabIndex = 17;
            this.label9.Text = "Mã câu hỏi:";
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Gainsboro;
            this.bunifuPanel1.BorderRadius = 25;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.tableLayoutPanel1);
            this.bunifuPanel1.Location = new System.Drawing.Point(60, 167);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(614, 112);
            this.bunifuPanel1.TabIndex = 22;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(605, 106);
            this.tableLayoutPanel1.TabIndex = 23;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.panel2.Controls.Add(this.textMaCH);
            this.panel2.Controls.Add(this.separatorControl1);
            this.panel2.Controls.Add(this.labelDapAn);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.labelGVSoan);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(357, 100);
            this.panel2.TabIndex = 26;
            // 
            // textMaCH
            // 
            this.textMaCH.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.BoDeBindingSource, "CAUHOI", true));
            this.textMaCH.Location = new System.Drawing.Point(155, 60);
            this.textMaCH.Name = "textMaCH";
            this.textMaCH.Properties.Appearance.Font = new System.Drawing.Font("Baloo 2", 10.8F);
            this.textMaCH.Properties.Appearance.Options.UseFont = true;
            this.textMaCH.Size = new System.Drawing.Size(122, 34);
            this.textMaCH.TabIndex = 22;
            // 
            // separatorControl1
            // 
            this.separatorControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.separatorControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.separatorControl1.LineOrientation = System.Windows.Forms.Orientation.Vertical;
            this.separatorControl1.Location = new System.Drawing.Point(333, 4);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Size = new System.Drawing.Size(22, 93);
            this.separatorControl1.TabIndex = 21;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.label13.Font = new System.Drawing.Font("Baloo 2", 10.8F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(72, 4);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 30);
            this.label13.TabIndex = 17;
            this.label13.Text = "Đáp án:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.panel3.Controls.Add(this.MHCombo);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(366, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(236, 100);
            this.panel3.TabIndex = 27;
            // 
            // MHCombo
            // 
            this.MHCombo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.MHCombo.BackColor = System.Drawing.Color.Transparent;
            this.MHCombo.DataSource = this.MH2BindingSource;
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
            this.MHCombo.Location = new System.Drawing.Point(6, 47);
            this.MHCombo.Name = "MHCombo";
            this.MHCombo.ShadowDecoration.Parent = this.MHCombo;
            this.MHCombo.Size = new System.Drawing.Size(216, 36);
            this.MHCombo.TabIndex = 18;
            // 
            // MH2BindingSource
            // 
            this.MH2BindingSource.DataMember = "MONHOC2";
            this.MH2BindingSource.DataSource = this.TN_CSDLPTDataSet;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.label10.Font = new System.Drawing.Font("Baloo 2", 10.8F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(3, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 30);
            this.label10.TabIndex = 17;
            this.label10.Text = "Môn học:";
            // 
            // bunifuPanel2
            // 
            this.bunifuPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuPanel2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.bunifuPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel2.BackgroundImage")));
            this.bunifuPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel2.BorderColor = System.Drawing.Color.Gainsboro;
            this.bunifuPanel2.BorderRadius = 25;
            this.bunifuPanel2.BorderThickness = 1;
            this.bunifuPanel2.Controls.Add(this.rdoC);
            this.bunifuPanel2.Controls.Add(this.label3);
            this.bunifuPanel2.Controls.Add(this.rdoA);
            this.bunifuPanel2.Controls.Add(this.label6);
            this.bunifuPanel2.Controls.Add(this.rdoB);
            this.bunifuPanel2.Controls.Add(this.label4);
            this.bunifuPanel2.Controls.Add(this.label5);
            this.bunifuPanel2.Location = new System.Drawing.Point(49, 169);
            this.bunifuPanel2.Name = "bunifuPanel2";
            this.bunifuPanel2.ShowBorders = true;
            this.bunifuPanel2.Size = new System.Drawing.Size(625, 112);
            this.bunifuPanel2.TabIndex = 23;
            // 
            // InfoPanel
            // 
            this.InfoPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InfoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.InfoPanel.Controls.Add(this.textNoiDung);
            this.InfoPanel.Controls.Add(this.TableLayout);
            this.InfoPanel.Controls.Add(this.label1);
            this.InfoPanel.Enabled = false;
            this.InfoPanel.Location = new System.Drawing.Point(0, 2);
            this.InfoPanel.Name = "InfoPanel";
            this.InfoPanel.Size = new System.Drawing.Size(1425, 388);
            this.InfoPanel.TabIndex = 24;
            // 
            // textNoiDung
            // 
            this.textNoiDung.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textNoiDung.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.BoDeBindingSource, "NOIDUNG", true));
            this.textNoiDung.Location = new System.Drawing.Point(94, 10);
            this.textNoiDung.Name = "textNoiDung";
            this.textNoiDung.Properties.Appearance.Font = new System.Drawing.Font("Baloo 2", 10.8F);
            this.textNoiDung.Properties.Appearance.Options.UseFont = true;
            this.textNoiDung.Size = new System.Drawing.Size(1274, 56);
            this.textNoiDung.TabIndex = 25;
            // 
            // TableLayout
            // 
            this.TableLayout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TableLayout.ColumnCount = 2;
            this.TableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayout.Controls.Add(this.PanelBD, 1, 0);
            this.TableLayout.Controls.Add(this.PanelAC, 0, 0);
            this.TableLayout.Location = new System.Drawing.Point(12, 89);
            this.TableLayout.Name = "TableLayout";
            this.TableLayout.RowCount = 1;
            this.TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayout.Size = new System.Drawing.Size(1401, 299);
            this.TableLayout.TabIndex = 24;
            // 
            // PanelBD
            // 
            this.PanelBD.Controls.Add(this.textChoiceB);
            this.PanelBD.Controls.Add(this.textChoiceD);
            this.PanelBD.Controls.Add(this.rdoDA_B);
            this.PanelBD.Controls.Add(this.label12);
            this.PanelBD.Controls.Add(this.label11);
            this.PanelBD.Controls.Add(this.rdoDA_D);
            this.PanelBD.Controls.Add(this.bunifuPanel2);
            this.PanelBD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelBD.Location = new System.Drawing.Point(703, 3);
            this.PanelBD.Name = "PanelBD";
            this.PanelBD.Size = new System.Drawing.Size(695, 293);
            this.PanelBD.TabIndex = 25;
            // 
            // textChoiceB
            // 
            this.textChoiceB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textChoiceB.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.BoDeBindingSource, "B", true));
            this.textChoiceB.Location = new System.Drawing.Point(49, 19);
            this.textChoiceB.Name = "textChoiceB";
            this.textChoiceB.Properties.Appearance.Font = new System.Drawing.Font("Baloo 2", 10.8F);
            this.textChoiceB.Properties.Appearance.Options.UseFont = true;
            this.textChoiceB.Size = new System.Drawing.Size(604, 54);
            this.textChoiceB.TabIndex = 23;
            // 
            // textChoiceD
            // 
            this.textChoiceD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textChoiceD.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.BoDeBindingSource, "D", true));
            this.textChoiceD.Location = new System.Drawing.Point(49, 94);
            this.textChoiceD.Name = "textChoiceD";
            this.textChoiceD.Properties.Appearance.BorderColor = System.Drawing.Color.Silver;
            this.textChoiceD.Properties.Appearance.Font = new System.Drawing.Font("Baloo 2", 10.8F);
            this.textChoiceD.Properties.Appearance.Options.UseBorderColor = true;
            this.textChoiceD.Properties.Appearance.Options.UseFont = true;
            this.textChoiceD.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.textChoiceD.Size = new System.Drawing.Size(604, 54);
            this.textChoiceD.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.label12.Font = new System.Drawing.Font("Baloo 2", 10.8F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(20, 95);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(26, 30);
            this.label12.TabIndex = 17;
            this.label12.Text = "D";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.label11.Font = new System.Drawing.Font("Baloo 2", 10.8F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(20, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(25, 30);
            this.label11.TabIndex = 17;
            this.label11.Text = "B";
            // 
            // PanelAC
            // 
            this.PanelAC.AutoScroll = true;
            this.PanelAC.Controls.Add(this.label14);
            this.PanelAC.Controls.Add(this.textChoiceC);
            this.PanelAC.Controls.Add(this.textChoiceA);
            this.PanelAC.Controls.Add(this.label2);
            this.PanelAC.Controls.Add(this.rdoDA_C);
            this.PanelAC.Controls.Add(this.bunifuPanel1);
            this.PanelAC.Controls.Add(this.rdoDA_A);
            this.PanelAC.Controls.Add(this.pictureBox1);
            this.PanelAC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelAC.Location = new System.Drawing.Point(3, 3);
            this.PanelAC.Name = "PanelAC";
            this.PanelAC.Size = new System.Drawing.Size(694, 293);
            this.PanelAC.TabIndex = 25;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.label14.Font = new System.Drawing.Font("Baloo 2", 10.8F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(20, 20);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(25, 30);
            this.label14.TabIndex = 24;
            this.label14.Text = "A";
            // 
            // textChoiceC
            // 
            this.textChoiceC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textChoiceC.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.BoDeBindingSource, "C", true));
            this.textChoiceC.Location = new System.Drawing.Point(50, 94);
            this.textChoiceC.Name = "textChoiceC";
            this.textChoiceC.Properties.Appearance.Font = new System.Drawing.Font("Baloo 2", 10.8F);
            this.textChoiceC.Properties.Appearance.Options.UseFont = true;
            this.textChoiceC.Size = new System.Drawing.Size(604, 54);
            this.textChoiceC.TabIndex = 23;
            // 
            // textChoiceA
            // 
            this.textChoiceA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textChoiceA.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.BoDeBindingSource, "A", true));
            this.textChoiceA.Location = new System.Drawing.Point(50, 19);
            this.textChoiceA.Name = "textChoiceA";
            this.textChoiceA.Properties.Appearance.Font = new System.Drawing.Font("Baloo 2", 10.8F);
            this.textChoiceA.Properties.Appearance.Options.UseFont = true;
            this.textChoiceA.Size = new System.Drawing.Size(604, 54);
            this.textChoiceA.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.label2.Font = new System.Drawing.Font("Baloo 2", 10.8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(20, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 30);
            this.label2.TabIndex = 17;
            this.label2.Text = "C";
            // 
            // buttonLamMoi
            // 
            this.buttonLamMoi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonLamMoi.Animated = true;
            this.buttonLamMoi.CheckedState.Parent = this.buttonLamMoi;
            this.buttonLamMoi.CustomImages.Parent = this.buttonLamMoi;
            this.buttonLamMoi.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(216)))), ((int)(((byte)(219)))));
            this.buttonLamMoi.Font = new System.Drawing.Font("Baloo 2 ExtraBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLamMoi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(70)))), ((int)(((byte)(68)))));
            this.buttonLamMoi.HoverState.FillColor = System.Drawing.Color.Gainsboro;
            this.buttonLamMoi.HoverState.Parent = this.buttonLamMoi;
            this.buttonLamMoi.Image = global::TracNghiemCSDLPT.Properties.Resources.reset_480px;
            this.buttonLamMoi.ImageSize = new System.Drawing.Size(40, 40);
            this.buttonLamMoi.Location = new System.Drawing.Point(3, 203);
            this.buttonLamMoi.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.buttonLamMoi.Name = "buttonLamMoi";
            this.buttonLamMoi.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(186)))), ((int)(((byte)(185)))));
            this.buttonLamMoi.ShadowDecoration.Parent = this.buttonLamMoi;
            this.buttonLamMoi.Size = new System.Drawing.Size(120, 45);
            this.buttonLamMoi.TabIndex = 22;
            this.buttonLamMoi.Text = "Làm mới";
            this.buttonLamMoi.Click += new System.EventHandler(this.buttonLamMoi_Click);
            // 
            // buttonThem
            // 
            this.buttonThem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonThem.Animated = true;
            this.buttonThem.CheckedState.Parent = this.buttonThem;
            this.buttonThem.CustomImages.Parent = this.buttonThem;
            this.buttonThem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(216)))), ((int)(((byte)(219)))));
            this.buttonThem.Font = new System.Drawing.Font("Baloo 2 ExtraBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(70)))), ((int)(((byte)(68)))));
            this.buttonThem.HoverState.FillColor = System.Drawing.Color.Gainsboro;
            this.buttonThem.HoverState.Parent = this.buttonThem;
            this.buttonThem.Image = global::TracNghiemCSDLPT.Properties.Resources.add_480px;
            this.buttonThem.ImageSize = new System.Drawing.Size(40, 40);
            this.buttonThem.Location = new System.Drawing.Point(3, 5);
            this.buttonThem.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(186)))), ((int)(((byte)(185)))));
            this.buttonThem.ShadowDecoration.Parent = this.buttonThem;
            this.buttonThem.Size = new System.Drawing.Size(120, 45);
            this.buttonThem.TabIndex = 21;
            this.buttonThem.Text = "Thêm";
            this.buttonThem.Click += new System.EventHandler(this.buttonThem_Click);
            // 
            // buttonSua
            // 
            this.buttonSua.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSua.Animated = true;
            this.buttonSua.CheckedState.Parent = this.buttonSua;
            this.buttonSua.CustomImages.Parent = this.buttonSua;
            this.buttonSua.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(216)))), ((int)(((byte)(219)))));
            this.buttonSua.Font = new System.Drawing.Font("Baloo 2 ExtraBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(70)))), ((int)(((byte)(68)))));
            this.buttonSua.HoverState.FillColor = System.Drawing.Color.Gainsboro;
            this.buttonSua.HoverState.Parent = this.buttonSua;
            this.buttonSua.Image = global::TracNghiemCSDLPT.Properties.Resources.edit_480px;
            this.buttonSua.ImageSize = new System.Drawing.Size(40, 40);
            this.buttonSua.Location = new System.Drawing.Point(3, 137);
            this.buttonSua.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.buttonSua.Name = "buttonSua";
            this.buttonSua.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(186)))), ((int)(((byte)(185)))));
            this.buttonSua.ShadowDecoration.Parent = this.buttonSua;
            this.buttonSua.Size = new System.Drawing.Size(120, 45);
            this.buttonSua.TabIndex = 20;
            this.buttonSua.Text = "Sửa";
            this.buttonSua.Click += new System.EventHandler(this.buttonSua_Click);
            // 
            // buttonXoa
            // 
            this.buttonXoa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonXoa.Animated = true;
            this.buttonXoa.CheckedState.Parent = this.buttonXoa;
            this.buttonXoa.CustomImages.Parent = this.buttonXoa;
            this.buttonXoa.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(216)))), ((int)(((byte)(219)))));
            this.buttonXoa.Font = new System.Drawing.Font("Baloo 2 ExtraBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(70)))), ((int)(((byte)(68)))));
            this.buttonXoa.HoverState.FillColor = System.Drawing.Color.Gainsboro;
            this.buttonXoa.HoverState.Parent = this.buttonXoa;
            this.buttonXoa.Image = global::TracNghiemCSDLPT.Properties.Resources.minus_sign_480px;
            this.buttonXoa.ImageSize = new System.Drawing.Size(40, 40);
            this.buttonXoa.Location = new System.Drawing.Point(3, 71);
            this.buttonXoa.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(186)))), ((int)(((byte)(185)))));
            this.buttonXoa.ShadowDecoration.Parent = this.buttonXoa;
            this.buttonXoa.Size = new System.Drawing.Size(120, 45);
            this.buttonXoa.TabIndex = 23;
            this.buttonXoa.Text = "Xóa";
            this.buttonXoa.Click += new System.EventHandler(this.buttonXoa_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.buttonThem);
            this.panel1.Controls.Add(this.buttonLamMoi);
            this.panel1.Controls.Add(this.buttonXoa);
            this.panel1.Controls.Add(this.buttonSua);
            this.panel1.Location = new System.Drawing.Point(12, 396);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(133, 258);
            this.panel1.TabIndex = 25;
            // 
            // BoDeTableAdapter
            // 
            this.BoDeTableAdapter.ClearBeforeFill = true;
            // 
            // MH2TableAdapter
            // 
            this.MH2TableAdapter.ClearBeforeFill = true;
            // 
            // buttonUndo
            // 
            this.buttonUndo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUndo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.buttonUndo.CheckedState.Parent = this.buttonUndo;
            this.buttonUndo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonUndo.CustomImages.Parent = this.buttonUndo;
            this.buttonUndo.Enabled = false;
            this.buttonUndo.FillColor = System.Drawing.Color.Transparent;
            this.buttonUndo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonUndo.ForeColor = System.Drawing.Color.White;
            this.buttonUndo.HoverState.Parent = this.buttonUndo;
            this.buttonUndo.Image = global::TracNghiemCSDLPT.Properties.Resources.undo_480px1;
            this.buttonUndo.ImageSize = new System.Drawing.Size(30, 30);
            this.buttonUndo.Location = new System.Drawing.Point(1316, 396);
            this.buttonUndo.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.buttonUndo.Name = "buttonUndo";
            this.buttonUndo.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.buttonUndo.ShadowDecoration.Parent = this.buttonUndo;
            this.buttonUndo.Size = new System.Drawing.Size(32, 32);
            this.buttonUndo.TabIndex = 34;
            // 
            // buttonRedo
            // 
            this.buttonRedo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRedo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.buttonRedo.CheckedState.Parent = this.buttonRedo;
            this.buttonRedo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRedo.CustomImages.Parent = this.buttonRedo;
            this.buttonRedo.Enabled = false;
            this.buttonRedo.FillColor = System.Drawing.Color.Transparent;
            this.buttonRedo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonRedo.ForeColor = System.Drawing.Color.White;
            this.buttonRedo.HoverState.Parent = this.buttonRedo;
            this.buttonRedo.Image = global::TracNghiemCSDLPT.Properties.Resources.redo_480px;
            this.buttonRedo.ImageSize = new System.Drawing.Size(30, 30);
            this.buttonRedo.Location = new System.Drawing.Point(1378, 396);
            this.buttonRedo.Margin = new System.Windows.Forms.Padding(20, 10, 15, 3);
            this.buttonRedo.Name = "buttonRedo";
            this.buttonRedo.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.buttonRedo.ShadowDecoration.Parent = this.buttonRedo;
            this.buttonRedo.Size = new System.Drawing.Size(32, 32);
            this.buttonRedo.TabIndex = 35;
            // 
            // buttonHuy
            // 
            this.buttonHuy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonHuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(178)))));
            this.buttonHuy.CheckedState.Parent = this.buttonHuy;
            this.buttonHuy.CustomImages.Parent = this.buttonHuy;
            this.buttonHuy.FillColor = System.Drawing.Color.Transparent;
            this.buttonHuy.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonHuy.ForeColor = System.Drawing.Color.White;
            this.buttonHuy.HoverState.Parent = this.buttonHuy;
            this.buttonHuy.Image = global::TracNghiemCSDLPT.Properties.Resources.cancel_480px;
            this.buttonHuy.ImageSize = new System.Drawing.Size(30, 30);
            this.buttonHuy.Location = new System.Drawing.Point(221, 4);
            this.buttonHuy.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.buttonHuy.Name = "buttonHuy";
            this.buttonHuy.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.buttonHuy.ShadowDecoration.Parent = this.buttonHuy;
            this.buttonHuy.Size = new System.Drawing.Size(30, 30);
            this.buttonHuy.TabIndex = 25;
            this.buttonHuy.Visible = false;
            this.buttonHuy.Click += new System.EventHandler(this.buttonHuyLop_Click);
            // 
            // buttonXacNhan
            // 
            this.buttonXacNhan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonXacNhan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(178)))));
            this.buttonXacNhan.CheckedState.Parent = this.buttonXacNhan;
            this.buttonXacNhan.CustomImages.Parent = this.buttonXacNhan;
            this.buttonXacNhan.FillColor = System.Drawing.Color.Transparent;
            this.buttonXacNhan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonXacNhan.ForeColor = System.Drawing.Color.White;
            this.buttonXacNhan.HoverState.Parent = this.buttonXacNhan;
            this.buttonXacNhan.Image = global::TracNghiemCSDLPT.Properties.Resources.ok_480px;
            this.buttonXacNhan.ImageSize = new System.Drawing.Size(30, 30);
            this.buttonXacNhan.Location = new System.Drawing.Point(138, 4);
            this.buttonXacNhan.Margin = new System.Windows.Forms.Padding(15, 3, 20, 3);
            this.buttonXacNhan.Name = "buttonXacNhan";
            this.buttonXacNhan.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.buttonXacNhan.ShadowDecoration.Parent = this.buttonXacNhan;
            this.buttonXacNhan.Size = new System.Drawing.Size(30, 30);
            this.buttonXacNhan.TabIndex = 26;
            this.buttonXacNhan.Visible = false;
            this.buttonXacNhan.Click += new System.EventHandler(this.buttonXacNhanLop_Click);
            // 
            // DSGVTCSTableAdapter
            // 
            this.DSGVTCSTableAdapter.ClearBeforeFill = true;
            // 
            // noiDungEP
            // 
            this.noiDungEP.ContainerControl = this;
            this.noiDungEP.Icon = ((System.Drawing.Icon)(resources.GetObject("noiDungEP.Icon")));
            // 
            // choiceAEP
            // 
            this.choiceAEP.ContainerControl = this;
            this.choiceAEP.Icon = ((System.Drawing.Icon)(resources.GetObject("choiceAEP.Icon")));
            // 
            // choiceBEP
            // 
            this.choiceBEP.ContainerControl = this;
            this.choiceBEP.Icon = ((System.Drawing.Icon)(resources.GetObject("choiceBEP.Icon")));
            // 
            // choiceCEP
            // 
            this.choiceCEP.ContainerControl = this;
            this.choiceCEP.Icon = ((System.Drawing.Icon)(resources.GetObject("choiceCEP.Icon")));
            // 
            // choiceDEP
            // 
            this.choiceDEP.ContainerControl = this;
            this.choiceDEP.Icon = ((System.Drawing.Icon)(resources.GetObject("choiceDEP.Icon")));
            // 
            // maCHEP
            // 
            this.maCHEP.ContainerControl = this;
            this.maCHEP.Icon = ((System.Drawing.Icon)(resources.GetObject("maCHEP.Icon")));
            // 
            // BaiThiBindingSource
            // 
            this.BaiThiBindingSource.DataMember = "FK_BAITHI_BODE";
            this.BaiThiBindingSource.DataSource = this.BoDeBindingSource;
            // 
            // BaiThiTableAdapter
            // 
            this.BaiThiTableAdapter.ClearBeforeFill = true;
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(178)))));
            this.panel4.Controls.Add(this.buttonXacNhan);
            this.panel4.Controls.Add(this.buttonHuy);
            this.panel4.Location = new System.Drawing.Point(592, 401);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(388, 38);
            this.panel4.TabIndex = 36;
            // 
            // guna2Button1
            // 
            this.guna2Button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2Button1.Animated = true;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(216)))), ((int)(((byte)(219)))));
            this.guna2Button1.Font = new System.Drawing.Font("Baloo 2 ExtraBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(70)))), ((int)(((byte)(68)))));
            this.guna2Button1.HoverState.FillColor = System.Drawing.Color.Gainsboro;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Image = global::TracNghiemCSDLPT.Properties.Resources.ok_480px;
            this.guna2Button1.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2Button1.Location = new System.Drawing.Point(290, 401);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(186)))), ((int)(((byte)(185)))));
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(120, 34);
            this.guna2Button1.TabIndex = 21;
            this.guna2Button1.Text = "Xác nhận";
            this.guna2Button1.Click += new System.EventHandler(this.buttonThem_Click);
            // 
            // guna2Button2
            // 
            this.guna2Button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2Button2.Animated = true;
            this.guna2Button2.CheckedState.Parent = this.guna2Button2;
            this.guna2Button2.CustomImages.Parent = this.guna2Button2;
            this.guna2Button2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(216)))), ((int)(((byte)(219)))));
            this.guna2Button2.Font = new System.Drawing.Font("Baloo 2 ExtraBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(70)))), ((int)(((byte)(68)))));
            this.guna2Button2.HoverState.FillColor = System.Drawing.Color.Gainsboro;
            this.guna2Button2.HoverState.Parent = this.guna2Button2;
            this.guna2Button2.Image = global::TracNghiemCSDLPT.Properties.Resources.cancel_480px;
            this.guna2Button2.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2Button2.Location = new System.Drawing.Point(416, 401);
            this.guna2Button2.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(186)))), ((int)(((byte)(185)))));
            this.guna2Button2.ShadowDecoration.Parent = this.guna2Button2;
            this.guna2Button2.Size = new System.Drawing.Size(120, 34);
            this.guna2Button2.TabIndex = 21;
            this.guna2Button2.Text = "Hủy";
            this.guna2Button2.Click += new System.EventHandler(this.buttonThem_Click);
            // 
            // FormCauHoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1425, 654);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.buttonUndo);
            this.Controls.Add(this.buttonRedo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.InfoPanel);
            this.Controls.Add(this.MonHocGridControl);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("FormCauHoi.IconOptions.Icon")));
            this.Name = "FormCauHoi";
            this.Text = "Câu hỏi";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCauHoi_FormClosing);
            this.Load += new System.EventHandler(this.FormCauHoi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BoDeGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MonHocGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MonHocBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TN_CSDLPTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MonHocGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoDeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSGVTCSBindingSource)).EndInit();
            this.bunifuPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textMaCH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MH2BindingSource)).EndInit();
            this.bunifuPanel2.ResumeLayout(false);
            this.bunifuPanel2.PerformLayout();
            this.InfoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textNoiDung.Properties)).EndInit();
            this.TableLayout.ResumeLayout(false);
            this.PanelBD.ResumeLayout(false);
            this.PanelBD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textChoiceB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textChoiceD.Properties)).EndInit();
            this.PanelAC.ResumeLayout(false);
            this.PanelAC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textChoiceC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textChoiceA.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.noiDungEP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.choiceAEP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.choiceBEP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.choiceCEP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.choiceDEP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maCHEP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaiThiBindingSource)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl MonHocGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView BoDeGridView;
        private DevExpress.XtraGrid.Views.Grid.GridView MonHocGridView;
        private TN_CSDLPTDataSet TN_CSDLPTDataSet;
        private System.Windows.Forms.BindingSource MonHocBindingSource;
        private TN_CSDLPTDataSetTableAdapters.MONHOCTableAdapter MonHocTableAdapter;
        private TN_CSDLPTDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.Columns.GridColumn colCAUHOI;
        private DevExpress.XtraGrid.Columns.GridColumn colTRINHDO;
        private DevExpress.XtraGrid.Columns.GridColumn colNOIDUNG;
        private DevExpress.XtraGrid.Columns.GridColumn colMAGV;
        private DevExpress.XtraGrid.Columns.GridColumn colMAMH;
        private DevExpress.XtraGrid.Columns.GridColumn colTENMH;
        private Guna.UI2.WinForms.Guna2CustomRadioButton rdoDA_A;
        private Guna.UI2.WinForms.Guna2CustomRadioButton rdoDA_C;
        private Guna.UI2.WinForms.Guna2CustomRadioButton rdoDA_B;
        private Guna.UI2.WinForms.Guna2CustomRadioButton rdoDA_D;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label labelDapAn;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2CustomRadioButton rdoC;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2CustomRadioButton rdoB;
        private Guna.UI2.WinForms.Guna2CustomRadioButton rdoA;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelGVSoan;
        private System.Windows.Forms.Label label9;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel2;
        private System.Windows.Forms.Panel InfoPanel;
        private System.Windows.Forms.TableLayoutPanel TableLayout;
        private System.Windows.Forms.Panel PanelBD;
        private System.Windows.Forms.Panel PanelAC;
        private Guna.UI2.WinForms.Guna2Button buttonLamMoi;
        private Guna.UI2.WinForms.Guna2Button buttonThem;
        private Guna.UI2.WinForms.Guna2Button buttonSua;
        private Guna.UI2.WinForms.Guna2Button buttonXoa;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2ComboBox MHCombo;
        private DevExpress.XtraEditors.MemoEdit textNoiDung;
        private DevExpress.XtraEditors.MemoEdit textChoiceB;
        private DevExpress.XtraEditors.MemoEdit textChoiceD;
        private DevExpress.XtraEditors.MemoEdit textChoiceC;
        private DevExpress.XtraEditors.MemoEdit textChoiceA;
        private System.Windows.Forms.BindingSource BoDeBindingSource;
        private TN_CSDLPTDataSetTableAdapters.BODETableAdapter BoDeTableAdapter;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.BindingSource MH2BindingSource;
        private TN_CSDLPTDataSetTableAdapters.MONHOC2TableAdapter MH2TableAdapter;
        private Guna.UI2.WinForms.Guna2CircleButton buttonUndo;
        private Guna.UI2.WinForms.Guna2CircleButton buttonRedo;
        private Guna.UI2.WinForms.Guna2CircleButton buttonHuy;
        private Guna.UI2.WinForms.Guna2CircleButton buttonXacNhan;
        private System.Windows.Forms.BindingSource DSGVTCSBindingSource;
        private TN_CSDLPTDataSetTableAdapters.DSGIAOVIENTCSTableAdapter DSGVTCSTableAdapter;
        private System.Windows.Forms.ErrorProvider noiDungEP;
        private System.Windows.Forms.ErrorProvider choiceAEP;
        private System.Windows.Forms.ErrorProvider choiceBEP;
        private System.Windows.Forms.ErrorProvider choiceCEP;
        private System.Windows.Forms.ErrorProvider choiceDEP;
        private System.Windows.Forms.ErrorProvider maCHEP;
        private DevExpress.XtraEditors.TextEdit textMaCH;
        private System.Windows.Forms.BindingSource BaiThiBindingSource;
        private TN_CSDLPTDataSetTableAdapters.BAITHITableAdapter BaiThiTableAdapter;
        private System.Windows.Forms.Panel panel4;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}