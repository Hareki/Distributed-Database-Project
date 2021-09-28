﻿
namespace TracNghiemCSDLPT.MyForms.TabbedForms
{
    partial class FormSVL
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
            System.Windows.Forms.Label mALOPLabel;
            System.Windows.Forms.Label tENLOPLabel;
            System.Windows.Forms.Label mAKHLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSVL));
            this.LopGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMALOP1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENLOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKH1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.KhoaGridControl = new DevExpress.XtraGrid.GridControl();
            this.KhoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TN_CSDLPTDataSet = new TracNghiemCSDLPT.TN_CSDLPTDataSet();
            this.KhoaGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMACS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolTipController1 = new DevExpress.Utils.ToolTipController(this.components);
            this.KhoaTableAdapter = new TracNghiemCSDLPT.TN_CSDLPTDataSetTableAdapters.KHOATableAdapter();
            this.tableAdapterManager = new TracNghiemCSDLPT.TN_CSDLPTDataSetTableAdapters.TableAdapterManager();
            this.InfoPanel = new System.Windows.Forms.GroupBox();
            this.ComboMaKH = new Guna.UI2.WinForms.Guna2ComboBox();
            this.buttonLamMoiLop = new Guna.UI2.WinForms.Guna2Button();
            this.buttonSuaLop = new Guna.UI2.WinForms.Guna2Button();
            this.buttonThemLop = new Guna.UI2.WinForms.Guna2Button();
            this.buttonXoaLop = new Guna.UI2.WinForms.Guna2Button();
            this.TextTenLop = new DevExpress.XtraEditors.TextEdit();
            this.LopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TextMaLop = new DevExpress.XtraEditors.TextEdit();
            this.SinhVienGridControl = new DevExpress.XtraGrid.GridControl();
            this.SinhVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SinhVienGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMASV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYSINH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cardView1 = new DevExpress.XtraGrid.Views.Card.CardView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonLamMoiSV = new Guna.UI2.WinForms.Guna2Button();
            this.buttonThemSV = new Guna.UI2.WinForms.Guna2Button();
            this.buttonSuaSV = new Guna.UI2.WinForms.Guna2Button();
            this.buttonXoaSV = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.LopTableAdapter = new TracNghiemCSDLPT.TN_CSDLPTDataSetTableAdapters.LOPTableAdapter();
            this.SinhVienTableAdapter = new TracNghiemCSDLPT.TN_CSDLPTDataSetTableAdapters.SINHVIENTableAdapter();
            this.CoSoComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.buttonHuyLop = new Guna.UI2.WinForms.Guna2CircleButton();
            this.buttonRedoLop = new Guna.UI2.WinForms.Guna2CircleButton();
            this.buttonUndoLop = new Guna.UI2.WinForms.Guna2CircleButton();
            this.buttonXacNhanLop = new Guna.UI2.WinForms.Guna2CircleButton();
            this.buttonHuySV = new Guna.UI2.WinForms.Guna2CircleButton();
            this.buttonRedoSV = new Guna.UI2.WinForms.Guna2CircleButton();
            this.buttonUndoSV = new Guna.UI2.WinForms.Guna2CircleButton();
            this.buttonXacNhanSV = new Guna.UI2.WinForms.Guna2CircleButton();
            this.MaLopEP = new System.Windows.Forms.ErrorProvider(this.components);
            this.TenLopEP = new System.Windows.Forms.ErrorProvider(this.components);
            this.MaKhoaEP = new System.Windows.Forms.ErrorProvider(this.components);
            this.TextMaKH = new DevExpress.XtraEditors.TextEdit();
            this.GV_DKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GV_DKTableAdapter = new TracNghiemCSDLPT.TN_CSDLPTDataSetTableAdapters.GIAOVIEN_DANGKYTableAdapter();
            this.ViewCaption = new System.Windows.Forms.Label();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.dxErrorProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.BangDiemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BangDiemTableAdapter = new TracNghiemCSDLPT.TN_CSDLPTDataSetTableAdapters.BANGDIEMTableAdapter();
            this.lOPBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            mALOPLabel = new System.Windows.Forms.Label();
            tENLOPLabel = new System.Windows.Forms.Label();
            mAKHLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.LopGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KhoaGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KhoaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TN_CSDLPTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KhoaGridView)).BeginInit();
            this.InfoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextTenLop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LopBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextMaLop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SinhVienGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SinhVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SinhVienGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaLopEP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TenLopEP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaKhoaEP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextMaKH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GV_DKBindingSource)).BeginInit();
            this.bunifuPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BangDiemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // LopGridView
            // 
            this.LopGridView.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.LopGridView.Appearance.EvenRow.Options.UseBackColor = true;
            this.LopGridView.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(198)))), ((int)(((byte)(203)))));
            this.LopGridView.Appearance.FixedLine.Font = new System.Drawing.Font("Baloo 2", 12F, System.Drawing.FontStyle.Bold);
            this.LopGridView.Appearance.FixedLine.Options.UseBackColor = true;
            this.LopGridView.Appearance.FixedLine.Options.UseFont = true;
            this.LopGridView.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(237)))), ((int)(((byte)(211)))));
            this.LopGridView.Appearance.FocusedCell.Options.UseBackColor = true;
            this.LopGridView.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(237)))), ((int)(((byte)(211)))));
            this.LopGridView.Appearance.FocusedRow.Options.UseBackColor = true;
            this.LopGridView.Appearance.GroupPanel.Font = new System.Drawing.Font("Baloo 2", 13.8F, System.Drawing.FontStyle.Bold);
            this.LopGridView.Appearance.GroupPanel.Options.UseFont = true;
            this.LopGridView.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(198)))), ((int)(((byte)(203)))));
            this.LopGridView.Appearance.HeaderPanel.Font = new System.Drawing.Font("Baloo 2", 12F, System.Drawing.FontStyle.Bold);
            this.LopGridView.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.LopGridView.Appearance.HeaderPanel.Options.UseFont = true;
            this.LopGridView.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(237)))), ((int)(((byte)(211)))));
            this.LopGridView.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.LopGridView.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.LopGridView.Appearance.OddRow.Options.UseBackColor = true;
            this.LopGridView.Appearance.Row.Font = new System.Drawing.Font("Baloo 2", 12F);
            this.LopGridView.Appearance.Row.Options.UseFont = true;
            this.LopGridView.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(237)))), ((int)(((byte)(211)))));
            this.LopGridView.Appearance.SelectedRow.Options.UseBackColor = true;
            this.LopGridView.Appearance.ViewCaption.Font = new System.Drawing.Font("Baloo 2", 13.8F, System.Drawing.FontStyle.Bold);
            this.LopGridView.Appearance.ViewCaption.Options.UseFont = true;
            this.LopGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMALOP1,
            this.colTENLOP,
            this.colMAKH1});
            this.LopGridView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.LopGridView.GridControl = this.KhoaGridControl;
            this.LopGridView.Name = "LopGridView";
            this.LopGridView.OptionsBehavior.Editable = false;
            this.LopGridView.OptionsDetail.EnableMasterViewMode = false;
            this.LopGridView.OptionsPrint.EnableAppearanceOddRow = true;
            this.LopGridView.OptionsScrollAnnotations.ShowFocusedRow = DevExpress.Utils.DefaultBoolean.True;
            this.LopGridView.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.AnimateAllContent;
            this.LopGridView.OptionsView.EnableAppearanceEvenRow = true;
            this.LopGridView.OptionsView.EnableAppearanceOddRow = true;
            this.LopGridView.OptionsView.ShowGroupPanel = false;
            this.LopGridView.ViewCaption = "Lớp";
            this.LopGridView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.LopGridView_FocusedRowChanged);
            // 
            // colMALOP1
            // 
            this.colMALOP1.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(198)))), ((int)(((byte)(203)))));
            this.colMALOP1.AppearanceHeader.Options.UseBackColor = true;
            this.colMALOP1.Caption = "Mã lớp";
            this.colMALOP1.FieldName = "MALOP";
            this.colMALOP1.MinWidth = 25;
            this.colMALOP1.Name = "colMALOP1";
            this.colMALOP1.Visible = true;
            this.colMALOP1.VisibleIndex = 0;
            this.colMALOP1.Width = 94;
            // 
            // colTENLOP
            // 
            this.colTENLOP.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(198)))), ((int)(((byte)(203)))));
            this.colTENLOP.AppearanceHeader.Options.UseBackColor = true;
            this.colTENLOP.Caption = "Tên lớp";
            this.colTENLOP.FieldName = "TENLOP";
            this.colTENLOP.MinWidth = 25;
            this.colTENLOP.Name = "colTENLOP";
            this.colTENLOP.Visible = true;
            this.colTENLOP.VisibleIndex = 1;
            this.colTENLOP.Width = 94;
            // 
            // colMAKH1
            // 
            this.colMAKH1.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(198)))), ((int)(((byte)(203)))));
            this.colMAKH1.AppearanceHeader.Options.UseBackColor = true;
            this.colMAKH1.Caption = "Mã khoa";
            this.colMAKH1.FieldName = "MAKH";
            this.colMAKH1.MinWidth = 25;
            this.colMAKH1.Name = "colMAKH1";
            this.colMAKH1.Visible = true;
            this.colMAKH1.VisibleIndex = 2;
            this.colMAKH1.Width = 94;
            // 
            // KhoaGridControl
            // 
            this.KhoaGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.KhoaGridControl.DataSource = this.KhoaBindingSource;
            this.KhoaGridControl.Font = new System.Drawing.Font("Teko SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            gridLevelNode1.LevelTemplate = this.LopGridView;
            gridLevelNode1.RelationName = "FK_LOP_KHOA";
            this.KhoaGridControl.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.KhoaGridControl.Location = new System.Drawing.Point(7, 67);
            this.KhoaGridControl.MainView = this.KhoaGridView;
            this.KhoaGridControl.Name = "KhoaGridControl";
            this.KhoaGridControl.Size = new System.Drawing.Size(934, 351);
            this.KhoaGridControl.TabIndex = 13;
            this.KhoaGridControl.ToolTipController = this.toolTipController1;
            this.KhoaGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.KhoaGridView,
            this.LopGridView});
            // 
            // KhoaBindingSource
            // 
            this.KhoaBindingSource.DataMember = "KHOA";
            this.KhoaBindingSource.DataSource = this.TN_CSDLPTDataSet;
            // 
            // TN_CSDLPTDataSet
            // 
            this.TN_CSDLPTDataSet.DataSetName = "TN_CSDLPTDataSet";
            this.TN_CSDLPTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // KhoaGridView
            // 
            this.KhoaGridView.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.KhoaGridView.Appearance.EvenRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(70)))), ((int)(((byte)(68)))));
            this.KhoaGridView.Appearance.EvenRow.Options.UseBackColor = true;
            this.KhoaGridView.Appearance.EvenRow.Options.UseForeColor = true;
            this.KhoaGridView.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(255)))), ((int)(((byte)(215)))));
            this.KhoaGridView.Appearance.FocusedCell.Options.UseBackColor = true;
            this.KhoaGridView.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(255)))), ((int)(((byte)(215)))));
            this.KhoaGridView.Appearance.FocusedRow.Options.UseBackColor = true;
            this.KhoaGridView.Appearance.GroupRow.Font = new System.Drawing.Font("Baloo 2", 10.2F);
            this.KhoaGridView.Appearance.GroupRow.Options.UseFont = true;
            this.KhoaGridView.Appearance.HeaderPanel.Font = new System.Drawing.Font("Baloo 2", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KhoaGridView.Appearance.HeaderPanel.Options.UseFont = true;
            this.KhoaGridView.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(255)))), ((int)(((byte)(215)))));
            this.KhoaGridView.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.KhoaGridView.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.KhoaGridView.Appearance.OddRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(70)))), ((int)(((byte)(68)))));
            this.KhoaGridView.Appearance.OddRow.Options.UseBackColor = true;
            this.KhoaGridView.Appearance.OddRow.Options.UseForeColor = true;
            this.KhoaGridView.Appearance.Preview.Font = new System.Drawing.Font("Baloo 2", 10.2F);
            this.KhoaGridView.Appearance.Preview.Options.UseFont = true;
            this.KhoaGridView.Appearance.Row.Font = new System.Drawing.Font("Baloo 2", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KhoaGridView.Appearance.Row.Options.UseFont = true;
            this.KhoaGridView.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(255)))), ((int)(((byte)(215)))));
            this.KhoaGridView.Appearance.SelectedRow.Font = new System.Drawing.Font("Baloo 2", 12F);
            this.KhoaGridView.Appearance.SelectedRow.Options.UseBackColor = true;
            this.KhoaGridView.Appearance.SelectedRow.Options.UseFont = true;
            this.KhoaGridView.Appearance.TopNewRow.Font = new System.Drawing.Font("Baloo 2", 10.2F);
            this.KhoaGridView.Appearance.TopNewRow.Options.UseFont = true;
            this.KhoaGridView.Appearance.ViewCaption.Font = new System.Drawing.Font("Baloo 2", 13.8F, System.Drawing.FontStyle.Bold);
            this.KhoaGridView.Appearance.ViewCaption.Options.UseFont = true;
            this.KhoaGridView.AppearancePrint.OddRow.BackColor = System.Drawing.Color.DimGray;
            this.KhoaGridView.AppearancePrint.OddRow.Options.UseBackColor = true;
            this.KhoaGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAKH,
            this.colTENKH,
            this.colMACS});
            this.KhoaGridView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.KhoaGridView.GridControl = this.KhoaGridControl;
            this.KhoaGridView.Name = "KhoaGridView";
            this.KhoaGridView.OptionsBehavior.AllowGroupExpandAnimation = DevExpress.Utils.DefaultBoolean.True;
            this.KhoaGridView.OptionsBehavior.AllowSortAnimation = DevExpress.Utils.DefaultBoolean.True;
            this.KhoaGridView.OptionsBehavior.AutoExpandAllGroups = true;
            this.KhoaGridView.OptionsBehavior.Editable = false;
            this.KhoaGridView.OptionsBehavior.ReadOnly = true;
            this.KhoaGridView.OptionsCustomization.AllowRowSizing = true;
            this.KhoaGridView.OptionsDetail.AllowExpandEmptyDetails = true;
            this.KhoaGridView.OptionsPrint.EnableAppearanceOddRow = true;
            this.KhoaGridView.OptionsScrollAnnotations.ShowFocusedRow = DevExpress.Utils.DefaultBoolean.True;
            this.KhoaGridView.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.AnimateAllContent;
            this.KhoaGridView.OptionsView.EnableAppearanceOddRow = true;
            this.KhoaGridView.OptionsView.ShowGroupPanel = false;
            this.KhoaGridView.OptionsView.ShowIndicator = false;
            this.KhoaGridView.OptionsView.ShowViewCaption = true;
            this.KhoaGridView.ViewCaption = "Danh sách lớp theo khoa";
            this.KhoaGridView.MasterRowGetRelationDisplayCaption += new DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationNameEventHandler(this.KhoaGridView_MasterRowGetRelationDisplayCaption);
            this.KhoaGridView.DetailTabStyle += new System.EventHandler<DevExpress.XtraGrid.Views.Grid.DetailTabStyleEventArgs>(this.KhoaGridView_DetailTabStyle);
            // 
            // colMAKH
            // 
            this.colMAKH.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(164)))), ((int)(((byte)(236)))));
            this.colMAKH.AppearanceHeader.Options.UseBackColor = true;
            this.colMAKH.Caption = "Mã khoa";
            this.colMAKH.FieldName = "MAKH";
            this.colMAKH.MinWidth = 25;
            this.colMAKH.Name = "colMAKH";
            this.colMAKH.Visible = true;
            this.colMAKH.VisibleIndex = 0;
            this.colMAKH.Width = 94;
            // 
            // colTENKH
            // 
            this.colTENKH.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(164)))), ((int)(((byte)(236)))));
            this.colTENKH.AppearanceHeader.Options.UseBackColor = true;
            this.colTENKH.Caption = "Tên khoa";
            this.colTENKH.FieldName = "TENKH";
            this.colTENKH.MinWidth = 25;
            this.colTENKH.Name = "colTENKH";
            this.colTENKH.Visible = true;
            this.colTENKH.VisibleIndex = 1;
            this.colTENKH.Width = 94;
            // 
            // colMACS
            // 
            this.colMACS.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(164)))), ((int)(((byte)(236)))));
            this.colMACS.AppearanceHeader.Options.UseBackColor = true;
            this.colMACS.Caption = "Mã cơ sở";
            this.colMACS.FieldName = "MACS";
            this.colMACS.MinWidth = 25;
            this.colMACS.Name = "colMACS";
            this.colMACS.Visible = true;
            this.colMACS.VisibleIndex = 2;
            this.colMACS.Width = 94;
            // 
            // mALOPLabel
            // 
            mALOPLabel.AutoSize = true;
            mALOPLabel.Font = new System.Drawing.Font("Baloo 2", 10.8F, System.Drawing.FontStyle.Bold);
            mALOPLabel.Location = new System.Drawing.Point(6, 59);
            mALOPLabel.Name = "mALOPLabel";
            mALOPLabel.Size = new System.Drawing.Size(70, 30);
            mALOPLabel.TabIndex = 0;
            mALOPLabel.Text = "Mã lớp";
            // 
            // tENLOPLabel
            // 
            tENLOPLabel.AutoSize = true;
            tENLOPLabel.Font = new System.Drawing.Font("Baloo 2", 10.8F, System.Drawing.FontStyle.Bold);
            tENLOPLabel.Location = new System.Drawing.Point(6, 141);
            tENLOPLabel.Name = "tENLOPLabel";
            tENLOPLabel.Size = new System.Drawing.Size(75, 30);
            tENLOPLabel.TabIndex = 2;
            tENLOPLabel.Text = "Tên lớp";
            // 
            // mAKHLabel
            // 
            mAKHLabel.AutoSize = true;
            mAKHLabel.Font = new System.Drawing.Font("Baloo 2", 10.8F, System.Drawing.FontStyle.Bold);
            mAKHLabel.Location = new System.Drawing.Point(6, 223);
            mAKHLabel.Name = "mAKHLabel";
            mAKHLabel.Size = new System.Drawing.Size(89, 30);
            mAKHLabel.TabIndex = 4;
            mAKHLabel.Text = "Tên khoa";
            // 
            // KhoaTableAdapter
            // 
            this.KhoaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BANGDIEMTableAdapter = null;
            this.tableAdapterManager.BODETableAdapter = null;
            this.tableAdapterManager.COSOTableAdapter = null;
            this.tableAdapterManager.GIAOVIEN_DANGKYTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = this.KhoaTableAdapter;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TracNghiemCSDLPT.TN_CSDLPTDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // InfoPanel
            // 
            this.InfoPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.InfoPanel.Controls.Add(this.ComboMaKH);
            this.InfoPanel.Controls.Add(this.buttonLamMoiLop);
            this.InfoPanel.Controls.Add(this.buttonSuaLop);
            this.InfoPanel.Controls.Add(mAKHLabel);
            this.InfoPanel.Controls.Add(this.buttonThemLop);
            this.InfoPanel.Controls.Add(this.buttonXoaLop);
            this.InfoPanel.Controls.Add(tENLOPLabel);
            this.InfoPanel.Controls.Add(this.TextTenLop);
            this.InfoPanel.Controls.Add(mALOPLabel);
            this.InfoPanel.Controls.Add(this.TextMaLop);
            this.InfoPanel.Font = new System.Drawing.Font("Baloo 2", 13.8F, System.Drawing.FontStyle.Bold);
            this.InfoPanel.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.InfoPanel.Location = new System.Drawing.Point(959, 67);
            this.InfoPanel.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.InfoPanel.Name = "InfoPanel";
            this.InfoPanel.Size = new System.Drawing.Size(459, 351);
            this.InfoPanel.TabIndex = 14;
            this.InfoPanel.TabStop = false;
            this.InfoPanel.Text = "Thông tin lớp";
            // 
            // ComboMaKH
            // 
            this.ComboMaKH.BackColor = System.Drawing.Color.Transparent;
            this.ComboMaKH.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.ComboMaKH.DataSource = this.KhoaBindingSource;
            this.ComboMaKH.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboMaKH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboMaKH.Enabled = false;
            this.ComboMaKH.FocusedColor = System.Drawing.Color.Empty;
            this.ComboMaKH.FocusedState.Parent = this.ComboMaKH;
            this.ComboMaKH.Font = new System.Drawing.Font("Baloo 2", 10.8F, System.Drawing.FontStyle.Bold);
            this.ComboMaKH.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.ComboMaKH.FormattingEnabled = true;
            this.ComboMaKH.HoverState.Parent = this.ComboMaKH;
            this.ComboMaKH.ItemHeight = 30;
            this.ComboMaKH.ItemsAppearance.Parent = this.ComboMaKH;
            this.ComboMaKH.Location = new System.Drawing.Point(6, 256);
            this.ComboMaKH.Name = "ComboMaKH";
            this.ComboMaKH.ShadowDecoration.Parent = this.ComboMaKH;
            this.ComboMaKH.Size = new System.Drawing.Size(292, 36);
            this.ComboMaKH.TabIndex = 20;
            // 
            // buttonLamMoiLop
            // 
            this.buttonLamMoiLop.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonLamMoiLop.Animated = true;
            this.buttonLamMoiLop.CheckedState.Parent = this.buttonLamMoiLop;
            this.buttonLamMoiLop.CustomImages.Parent = this.buttonLamMoiLop;
            this.buttonLamMoiLop.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(216)))), ((int)(((byte)(219)))));
            this.buttonLamMoiLop.Font = new System.Drawing.Font("Baloo 2 ExtraBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLamMoiLop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(70)))), ((int)(((byte)(68)))));
            this.buttonLamMoiLop.HoverState.FillColor = System.Drawing.Color.Gainsboro;
            this.buttonLamMoiLop.HoverState.Parent = this.buttonLamMoiLop;
            this.buttonLamMoiLop.Image = global::TracNghiemCSDLPT.Properties.Resources.reset_480px;
            this.buttonLamMoiLop.ImageSize = new System.Drawing.Size(40, 40);
            this.buttonLamMoiLop.Location = new System.Drawing.Point(339, 256);
            this.buttonLamMoiLop.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.buttonLamMoiLop.Name = "buttonLamMoiLop";
            this.buttonLamMoiLop.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(186)))), ((int)(((byte)(185)))));
            this.buttonLamMoiLop.ShadowDecoration.Parent = this.buttonLamMoiLop;
            this.buttonLamMoiLop.Size = new System.Drawing.Size(120, 45);
            this.buttonLamMoiLop.TabIndex = 18;
            this.buttonLamMoiLop.Text = "Làm mới";
            this.buttonLamMoiLop.Click += new System.EventHandler(this.buttonLamMoiLop_Click);
            // 
            // buttonSuaLop
            // 
            this.buttonSuaLop.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonSuaLop.Animated = true;
            this.buttonSuaLop.CheckedState.Parent = this.buttonSuaLop;
            this.buttonSuaLop.CustomImages.Parent = this.buttonSuaLop;
            this.buttonSuaLop.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(216)))), ((int)(((byte)(219)))));
            this.buttonSuaLop.Font = new System.Drawing.Font("Baloo 2 ExtraBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSuaLop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(70)))), ((int)(((byte)(68)))));
            this.buttonSuaLop.HoverState.FillColor = System.Drawing.Color.Gainsboro;
            this.buttonSuaLop.HoverState.Parent = this.buttonSuaLop;
            this.buttonSuaLop.Image = global::TracNghiemCSDLPT.Properties.Resources.edit_480px;
            this.buttonSuaLop.ImageSize = new System.Drawing.Size(40, 40);
            this.buttonSuaLop.Location = new System.Drawing.Point(339, 191);
            this.buttonSuaLop.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.buttonSuaLop.Name = "buttonSuaLop";
            this.buttonSuaLop.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(186)))), ((int)(((byte)(185)))));
            this.buttonSuaLop.ShadowDecoration.Parent = this.buttonSuaLop;
            this.buttonSuaLop.Size = new System.Drawing.Size(120, 45);
            this.buttonSuaLop.TabIndex = 16;
            this.buttonSuaLop.Text = "Sửa";
            this.buttonSuaLop.Click += new System.EventHandler(this.buttonSuaLop_Click);
            // 
            // buttonThemLop
            // 
            this.buttonThemLop.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonThemLop.Animated = true;
            this.buttonThemLop.CheckedState.Parent = this.buttonThemLop;
            this.buttonThemLop.CustomImages.Parent = this.buttonThemLop;
            this.buttonThemLop.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(216)))), ((int)(((byte)(219)))));
            this.buttonThemLop.Font = new System.Drawing.Font("Baloo 2 ExtraBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThemLop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(70)))), ((int)(((byte)(68)))));
            this.buttonThemLop.HoverState.FillColor = System.Drawing.Color.Gainsboro;
            this.buttonThemLop.HoverState.Parent = this.buttonThemLop;
            this.buttonThemLop.Image = global::TracNghiemCSDLPT.Properties.Resources.add_480px;
            this.buttonThemLop.ImageSize = new System.Drawing.Size(40, 40);
            this.buttonThemLop.Location = new System.Drawing.Point(339, 44);
            this.buttonThemLop.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.buttonThemLop.Name = "buttonThemLop";
            this.buttonThemLop.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(186)))), ((int)(((byte)(185)))));
            this.buttonThemLop.ShadowDecoration.Parent = this.buttonThemLop;
            this.buttonThemLop.Size = new System.Drawing.Size(120, 45);
            this.buttonThemLop.TabIndex = 17;
            this.buttonThemLop.Text = "Thêm";
            this.buttonThemLop.Click += new System.EventHandler(this.buttonThemLop_Click);
            // 
            // buttonXoaLop
            // 
            this.buttonXoaLop.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonXoaLop.Animated = true;
            this.buttonXoaLop.CheckedState.Parent = this.buttonXoaLop;
            this.buttonXoaLop.CustomImages.Parent = this.buttonXoaLop;
            this.buttonXoaLop.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(216)))), ((int)(((byte)(219)))));
            this.buttonXoaLop.Font = new System.Drawing.Font("Baloo 2 ExtraBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXoaLop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(70)))), ((int)(((byte)(68)))));
            this.buttonXoaLop.HoverState.FillColor = System.Drawing.Color.Gainsboro;
            this.buttonXoaLop.HoverState.Parent = this.buttonXoaLop;
            this.buttonXoaLop.Image = global::TracNghiemCSDLPT.Properties.Resources.minus_sign_480px;
            this.buttonXoaLop.ImageSize = new System.Drawing.Size(40, 40);
            this.buttonXoaLop.Location = new System.Drawing.Point(339, 116);
            this.buttonXoaLop.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.buttonXoaLop.Name = "buttonXoaLop";
            this.buttonXoaLop.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(186)))), ((int)(((byte)(185)))));
            this.buttonXoaLop.ShadowDecoration.Parent = this.buttonXoaLop;
            this.buttonXoaLop.Size = new System.Drawing.Size(120, 45);
            this.buttonXoaLop.TabIndex = 19;
            this.buttonXoaLop.Text = "Xóa";
            this.buttonXoaLop.Click += new System.EventHandler(this.buttonXoaLop_Click);
            // 
            // TextTenLop
            // 
            this.TextTenLop.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.LopBindingSource, "TENLOP", true));
            this.TextTenLop.Enabled = false;
            this.TextTenLop.Location = new System.Drawing.Point(6, 174);
            this.TextTenLop.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.TextTenLop.Name = "TextTenLop";
            this.TextTenLop.Properties.Appearance.Font = new System.Drawing.Font("Baloo 2", 10.8F, System.Drawing.FontStyle.Bold);
            this.TextTenLop.Properties.Appearance.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.TextTenLop.Properties.Appearance.Options.UseFont = true;
            this.TextTenLop.Properties.Appearance.Options.UseForeColor = true;
            this.TextTenLop.Size = new System.Drawing.Size(292, 34);
            this.TextTenLop.TabIndex = 3;
            // 
            // LopBindingSource
            // 
            this.LopBindingSource.AllowNew = true;
            this.LopBindingSource.DataMember = "LOP";
            this.LopBindingSource.DataSource = this.TN_CSDLPTDataSet;
            // 
            // TextMaLop
            // 
            this.TextMaLop.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.LopBindingSource, "MALOP", true));
            this.TextMaLop.Enabled = false;
            this.TextMaLop.Location = new System.Drawing.Point(7, 92);
            this.TextMaLop.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.TextMaLop.Name = "TextMaLop";
            this.TextMaLop.Properties.Appearance.Font = new System.Drawing.Font("Baloo 2", 10.8F, System.Drawing.FontStyle.Bold);
            this.TextMaLop.Properties.Appearance.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.TextMaLop.Properties.Appearance.Options.UseFont = true;
            this.TextMaLop.Properties.Appearance.Options.UseForeColor = true;
            this.TextMaLop.Size = new System.Drawing.Size(291, 34);
            this.TextMaLop.TabIndex = 1;
            // 
            // SinhVienGridControl
            // 
            this.SinhVienGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SinhVienGridControl.DataSource = this.SinhVienBindingSource;
            this.SinhVienGridControl.Font = new System.Drawing.Font("Teko SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SinhVienGridControl.Location = new System.Drawing.Point(150, 491);
            this.SinhVienGridControl.MainView = this.SinhVienGridView;
            this.SinhVienGridControl.Name = "SinhVienGridControl";
            this.SinhVienGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateEdit1});
            this.SinhVienGridControl.Size = new System.Drawing.Size(1265, 311);
            this.SinhVienGridControl.TabIndex = 15;
            this.SinhVienGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.SinhVienGridView,
            this.cardView1});
            // 
            // SinhVienBindingSource
            // 
            this.SinhVienBindingSource.DataMember = "FK_SINHVIEN_LOP";
            this.SinhVienBindingSource.DataSource = this.LopBindingSource;
            this.SinhVienBindingSource.CurrentChanged += new System.EventHandler(this.SinhVienBindingSource_CurrentChanged);
            // 
            // SinhVienGridView
            // 
            this.SinhVienGridView.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.SinhVienGridView.Appearance.EvenRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(70)))), ((int)(((byte)(68)))));
            this.SinhVienGridView.Appearance.EvenRow.Options.UseBackColor = true;
            this.SinhVienGridView.Appearance.EvenRow.Options.UseForeColor = true;
            this.SinhVienGridView.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(230)))), ((int)(((byte)(203)))));
            this.SinhVienGridView.Appearance.FocusedCell.Options.UseBackColor = true;
            this.SinhVienGridView.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(230)))), ((int)(((byte)(203)))));
            this.SinhVienGridView.Appearance.FocusedRow.Options.UseBackColor = true;
            this.SinhVienGridView.Appearance.GroupRow.Font = new System.Drawing.Font("Baloo 2", 10.2F);
            this.SinhVienGridView.Appearance.GroupRow.Options.UseFont = true;
            this.SinhVienGridView.Appearance.HeaderPanel.Font = new System.Drawing.Font("Baloo 2", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SinhVienGridView.Appearance.HeaderPanel.Options.UseFont = true;
            this.SinhVienGridView.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(230)))), ((int)(((byte)(203)))));
            this.SinhVienGridView.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.SinhVienGridView.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.SinhVienGridView.Appearance.OddRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(70)))), ((int)(((byte)(68)))));
            this.SinhVienGridView.Appearance.OddRow.Options.UseBackColor = true;
            this.SinhVienGridView.Appearance.OddRow.Options.UseForeColor = true;
            this.SinhVienGridView.Appearance.Preview.Font = new System.Drawing.Font("Baloo 2", 10.2F);
            this.SinhVienGridView.Appearance.Preview.Options.UseFont = true;
            this.SinhVienGridView.Appearance.Row.Font = new System.Drawing.Font("Baloo 2", 12F);
            this.SinhVienGridView.Appearance.Row.Options.UseFont = true;
            this.SinhVienGridView.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(230)))), ((int)(((byte)(203)))));
            this.SinhVienGridView.Appearance.SelectedRow.Font = new System.Drawing.Font("Baloo 2", 12F);
            this.SinhVienGridView.Appearance.SelectedRow.Options.UseBackColor = true;
            this.SinhVienGridView.Appearance.SelectedRow.Options.UseFont = true;
            this.SinhVienGridView.Appearance.TopNewRow.Font = new System.Drawing.Font("Baloo 2", 10.2F);
            this.SinhVienGridView.Appearance.TopNewRow.Options.UseFont = true;
            this.SinhVienGridView.Appearance.ViewCaption.Font = new System.Drawing.Font("Baloo 2", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SinhVienGridView.Appearance.ViewCaption.Options.UseFont = true;
            this.SinhVienGridView.AppearancePrint.OddRow.BackColor = System.Drawing.Color.DimGray;
            this.SinhVienGridView.AppearancePrint.OddRow.Options.UseBackColor = true;
            this.SinhVienGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMASV,
            this.colHO,
            this.colTEN,
            this.colNGAYSINH,
            this.colDIACHI});
            this.SinhVienGridView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.SinhVienGridView.GridControl = this.SinhVienGridControl;
            this.SinhVienGridView.Name = "SinhVienGridView";
            this.SinhVienGridView.OptionsBehavior.Editable = false;
            this.SinhVienGridView.OptionsCustomization.AllowRowSizing = true;
            this.SinhVienGridView.OptionsDetail.EnableMasterViewMode = false;
            this.SinhVienGridView.OptionsPrint.EnableAppearanceOddRow = true;
            this.SinhVienGridView.OptionsScrollAnnotations.ShowErrors = DevExpress.Utils.DefaultBoolean.True;
            this.SinhVienGridView.OptionsScrollAnnotations.ShowFocusedRow = DevExpress.Utils.DefaultBoolean.True;
            this.SinhVienGridView.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.AnimateAllContent;
            this.SinhVienGridView.OptionsView.EnableAppearanceOddRow = true;
            this.SinhVienGridView.OptionsView.ShowGroupPanel = false;
            this.SinhVienGridView.OptionsView.ShowGroupPanelColumnsAsSingleRow = true;
            this.SinhVienGridView.OptionsView.ShowIndicator = false;
            this.SinhVienGridView.ViewCaption = "Danh sách sinh viên thuộc lớp";
            this.SinhVienGridView.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.SinhVienGridView_CustomDrawCell);
            this.SinhVienGridView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.SinhVienGridView_FocusedRowChanged);
            this.SinhVienGridView.InvalidRowException += new DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventHandler(this.SinhVienGridView_InvalidRowException);
            this.SinhVienGridView.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.SinhVienGridView_ValidateRow);
            // 
            // colMASV
            // 
            this.colMASV.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(164)))), ((int)(((byte)(236)))));
            this.colMASV.AppearanceHeader.Options.UseBackColor = true;
            this.colMASV.Caption = "Mã sinh viên";
            this.colMASV.FieldName = "MASV";
            this.colMASV.MinWidth = 25;
            this.colMASV.Name = "colMASV";
            this.colMASV.Visible = true;
            this.colMASV.VisibleIndex = 0;
            this.colMASV.Width = 94;
            // 
            // colHO
            // 
            this.colHO.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(164)))), ((int)(((byte)(236)))));
            this.colHO.AppearanceHeader.Options.UseBackColor = true;
            this.colHO.Caption = "Họ và tên đệm";
            this.colHO.FieldName = "HO";
            this.colHO.MinWidth = 25;
            this.colHO.Name = "colHO";
            this.colHO.Visible = true;
            this.colHO.VisibleIndex = 1;
            this.colHO.Width = 94;
            // 
            // colTEN
            // 
            this.colTEN.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(164)))), ((int)(((byte)(236)))));
            this.colTEN.AppearanceHeader.Options.UseBackColor = true;
            this.colTEN.Caption = "Tên";
            this.colTEN.FieldName = "TEN";
            this.colTEN.MinWidth = 25;
            this.colTEN.Name = "colTEN";
            this.colTEN.Visible = true;
            this.colTEN.VisibleIndex = 2;
            this.colTEN.Width = 94;
            // 
            // colNGAYSINH
            // 
            this.colNGAYSINH.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(164)))), ((int)(((byte)(236)))));
            this.colNGAYSINH.AppearanceHeader.Options.UseBackColor = true;
            this.colNGAYSINH.Caption = "Ngày sinh";
            this.colNGAYSINH.ColumnEdit = this.repositoryItemDateEdit1;
            this.colNGAYSINH.FieldName = "NGAYSINH";
            this.colNGAYSINH.MinWidth = 25;
            this.colNGAYSINH.Name = "colNGAYSINH";
            this.colNGAYSINH.Visible = true;
            this.colNGAYSINH.VisibleIndex = 3;
            this.colNGAYSINH.Width = 94;
            // 
            // repositoryItemDateEdit1
            // 
            this.repositoryItemDateEdit1.AutoHeight = false;
            this.repositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
            // 
            // colDIACHI
            // 
            this.colDIACHI.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(164)))), ((int)(((byte)(236)))));
            this.colDIACHI.AppearanceHeader.Options.UseBackColor = true;
            this.colDIACHI.Caption = "Địa chỉ";
            this.colDIACHI.FieldName = "DIACHI";
            this.colDIACHI.MinWidth = 25;
            this.colDIACHI.Name = "colDIACHI";
            this.colDIACHI.Visible = true;
            this.colDIACHI.VisibleIndex = 4;
            this.colDIACHI.Width = 94;
            // 
            // cardView1
            // 
            this.cardView1.GridControl = this.SinhVienGridControl;
            this.cardView1.Name = "cardView1";
            this.cardView1.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Auto;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.buttonLamMoiSV);
            this.panel1.Controls.Add(this.buttonThemSV);
            this.panel1.Controls.Add(this.buttonSuaSV);
            this.panel1.Controls.Add(this.buttonXoaSV);
            this.panel1.Location = new System.Drawing.Point(7, 445);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(136, 357);
            this.panel1.TabIndex = 16;
            // 
            // buttonLamMoiSV
            // 
            this.buttonLamMoiSV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonLamMoiSV.Animated = true;
            this.buttonLamMoiSV.CheckedState.Parent = this.buttonLamMoiSV;
            this.buttonLamMoiSV.CustomImages.Parent = this.buttonLamMoiSV;
            this.buttonLamMoiSV.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(216)))), ((int)(((byte)(219)))));
            this.buttonLamMoiSV.Font = new System.Drawing.Font("Baloo 2 ExtraBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLamMoiSV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(70)))), ((int)(((byte)(68)))));
            this.buttonLamMoiSV.HoverState.FillColor = System.Drawing.Color.Gainsboro;
            this.buttonLamMoiSV.HoverState.Parent = this.buttonLamMoiSV;
            this.buttonLamMoiSV.Image = global::TracNghiemCSDLPT.Properties.Resources.reset_480px;
            this.buttonLamMoiSV.ImageSize = new System.Drawing.Size(40, 40);
            this.buttonLamMoiSV.Location = new System.Drawing.Point(8, 268);
            this.buttonLamMoiSV.Margin = new System.Windows.Forms.Padding(3, 3, 3, 27);
            this.buttonLamMoiSV.Name = "buttonLamMoiSV";
            this.buttonLamMoiSV.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(186)))), ((int)(((byte)(185)))));
            this.buttonLamMoiSV.ShadowDecoration.Parent = this.buttonLamMoiSV;
            this.buttonLamMoiSV.Size = new System.Drawing.Size(120, 45);
            this.buttonLamMoiSV.TabIndex = 22;
            this.buttonLamMoiSV.Text = "Làm mới";
            this.buttonLamMoiSV.Click += new System.EventHandler(this.buttonLamMoiSV_Click);
            // 
            // buttonThemSV
            // 
            this.buttonThemSV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonThemSV.Animated = true;
            this.buttonThemSV.CheckedState.Parent = this.buttonThemSV;
            this.buttonThemSV.CustomImages.Parent = this.buttonThemSV;
            this.buttonThemSV.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(216)))), ((int)(((byte)(219)))));
            this.buttonThemSV.Font = new System.Drawing.Font("Baloo 2 ExtraBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThemSV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(70)))), ((int)(((byte)(68)))));
            this.buttonThemSV.HoverState.FillColor = System.Drawing.Color.Gainsboro;
            this.buttonThemSV.HoverState.Parent = this.buttonThemSV;
            this.buttonThemSV.Image = global::TracNghiemCSDLPT.Properties.Resources.add_480px;
            this.buttonThemSV.ImageSize = new System.Drawing.Size(40, 40);
            this.buttonThemSV.Location = new System.Drawing.Point(8, 43);
            this.buttonThemSV.Margin = new System.Windows.Forms.Padding(3, 3, 3, 27);
            this.buttonThemSV.Name = "buttonThemSV";
            this.buttonThemSV.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(186)))), ((int)(((byte)(185)))));
            this.buttonThemSV.ShadowDecoration.Parent = this.buttonThemSV;
            this.buttonThemSV.Size = new System.Drawing.Size(120, 45);
            this.buttonThemSV.TabIndex = 21;
            this.buttonThemSV.Text = "Thêm";
            this.buttonThemSV.Click += new System.EventHandler(this.buttonThemSV_Click);
            // 
            // buttonSuaSV
            // 
            this.buttonSuaSV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSuaSV.Animated = true;
            this.buttonSuaSV.CheckedState.Parent = this.buttonSuaSV;
            this.buttonSuaSV.CustomImages.Parent = this.buttonSuaSV;
            this.buttonSuaSV.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(216)))), ((int)(((byte)(219)))));
            this.buttonSuaSV.Font = new System.Drawing.Font("Baloo 2 ExtraBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSuaSV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(70)))), ((int)(((byte)(68)))));
            this.buttonSuaSV.HoverState.FillColor = System.Drawing.Color.Gainsboro;
            this.buttonSuaSV.HoverState.Parent = this.buttonSuaSV;
            this.buttonSuaSV.Image = global::TracNghiemCSDLPT.Properties.Resources.edit_480px;
            this.buttonSuaSV.ImageSize = new System.Drawing.Size(40, 40);
            this.buttonSuaSV.Location = new System.Drawing.Point(8, 193);
            this.buttonSuaSV.Margin = new System.Windows.Forms.Padding(3, 3, 3, 27);
            this.buttonSuaSV.Name = "buttonSuaSV";
            this.buttonSuaSV.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(186)))), ((int)(((byte)(185)))));
            this.buttonSuaSV.ShadowDecoration.Parent = this.buttonSuaSV;
            this.buttonSuaSV.Size = new System.Drawing.Size(120, 45);
            this.buttonSuaSV.TabIndex = 20;
            this.buttonSuaSV.Text = "Sửa";
            this.buttonSuaSV.Click += new System.EventHandler(this.buttonSuaSV_Click);
            // 
            // buttonXoaSV
            // 
            this.buttonXoaSV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonXoaSV.Animated = true;
            this.buttonXoaSV.CheckedState.Parent = this.buttonXoaSV;
            this.buttonXoaSV.CustomImages.Parent = this.buttonXoaSV;
            this.buttonXoaSV.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(216)))), ((int)(((byte)(219)))));
            this.buttonXoaSV.Font = new System.Drawing.Font("Baloo 2 ExtraBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXoaSV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(70)))), ((int)(((byte)(68)))));
            this.buttonXoaSV.HoverState.FillColor = System.Drawing.Color.Gainsboro;
            this.buttonXoaSV.HoverState.Parent = this.buttonXoaSV;
            this.buttonXoaSV.Image = global::TracNghiemCSDLPT.Properties.Resources.minus_sign_480px;
            this.buttonXoaSV.ImageSize = new System.Drawing.Size(40, 40);
            this.buttonXoaSV.Location = new System.Drawing.Point(8, 118);
            this.buttonXoaSV.Margin = new System.Windows.Forms.Padding(3, 3, 3, 27);
            this.buttonXoaSV.Name = "buttonXoaSV";
            this.buttonXoaSV.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(186)))), ((int)(((byte)(185)))));
            this.buttonXoaSV.ShadowDecoration.Parent = this.buttonXoaSV;
            this.buttonXoaSV.Size = new System.Drawing.Size(120, 45);
            this.buttonXoaSV.TabIndex = 23;
            this.buttonXoaSV.Text = "Xóa";
            this.buttonXoaSV.Click += new System.EventHandler(this.buttonXoaSV_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Baloo 2", 10.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(2, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 30);
            this.label1.TabIndex = 18;
            this.label1.Text = "Chọn cơ sở";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuSeparator1.BackgroundImage")));
            this.bunifuSeparator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuSeparator1.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.bunifuSeparator1.ForeColor = System.Drawing.Color.Black;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(189)))), ((int)(((byte)(192)))));
            this.bunifuSeparator1.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
            this.bunifuSeparator1.LineThickness = 2;
            this.bunifuSeparator1.Location = new System.Drawing.Point(-8, 425);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.bunifuSeparator1.Size = new System.Drawing.Size(1419, 13);
            this.bunifuSeparator1.TabIndex = 19;
            // 
            // LopTableAdapter
            // 
            this.LopTableAdapter.ClearBeforeFill = true;
            // 
            // SinhVienTableAdapter
            // 
            this.SinhVienTableAdapter.ClearBeforeFill = true;
            // 
            // CoSoComboBox
            // 
            this.CoSoComboBox.Animated = true;
            this.CoSoComboBox.BackColor = System.Drawing.Color.Transparent;
            this.CoSoComboBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(164)))), ((int)(((byte)(236)))));
            this.CoSoComboBox.BorderRadius = 3;
            this.CoSoComboBox.BorderThickness = 2;
            this.CoSoComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CoSoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CoSoComboBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(163)))), ((int)(((byte)(236)))));
            this.CoSoComboBox.FocusedColor = System.Drawing.Color.Empty;
            this.CoSoComboBox.FocusedState.Parent = this.CoSoComboBox;
            this.CoSoComboBox.Font = new System.Drawing.Font("Baloo 2", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CoSoComboBox.ForeColor = System.Drawing.Color.White;
            this.CoSoComboBox.FormattingEnabled = true;
            this.CoSoComboBox.HoverState.Parent = this.CoSoComboBox;
            this.CoSoComboBox.ItemHeight = 30;
            this.CoSoComboBox.ItemsAppearance.Parent = this.CoSoComboBox;
            this.CoSoComboBox.Location = new System.Drawing.Point(115, 16);
            this.CoSoComboBox.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.CoSoComboBox.Name = "CoSoComboBox";
            this.CoSoComboBox.ShadowDecoration.Parent = this.CoSoComboBox;
            this.CoSoComboBox.Size = new System.Drawing.Size(254, 36);
            this.CoSoComboBox.TabIndex = 20;
            this.CoSoComboBox.TextOffset = new System.Drawing.Point(3, 3);
            this.CoSoComboBox.SelectedIndexChanged += new System.EventHandler(this.CoSoComboBox_SelectedIndexChanged);
            // 
            // buttonHuyLop
            // 
            this.buttonHuyLop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHuyLop.CheckedState.Parent = this.buttonHuyLop;
            this.buttonHuyLop.CustomImages.Parent = this.buttonHuyLop;
            this.buttonHuyLop.FillColor = System.Drawing.Color.Transparent;
            this.buttonHuyLop.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonHuyLop.ForeColor = System.Drawing.Color.White;
            this.buttonHuyLop.HoverState.Parent = this.buttonHuyLop;
            this.buttonHuyLop.Image = global::TracNghiemCSDLPT.Properties.Resources.cancel_480px;
            this.buttonHuyLop.ImageSize = new System.Drawing.Size(30, 30);
            this.buttonHuyLop.Location = new System.Drawing.Point(1066, 31);
            this.buttonHuyLop.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.buttonHuyLop.Name = "buttonHuyLop";
            this.buttonHuyLop.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.buttonHuyLop.ShadowDecoration.Parent = this.buttonHuyLop;
            this.buttonHuyLop.Size = new System.Drawing.Size(30, 30);
            this.buttonHuyLop.TabIndex = 21;
            this.buttonHuyLop.Visible = false;
            this.buttonHuyLop.Click += new System.EventHandler(this.buttonHuyLop_Click);
            // 
            // buttonRedoLop
            // 
            this.buttonRedoLop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRedoLop.CheckedState.Parent = this.buttonRedoLop;
            this.buttonRedoLop.CustomImages.Parent = this.buttonRedoLop;
            this.buttonRedoLop.FillColor = System.Drawing.Color.Transparent;
            this.buttonRedoLop.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonRedoLop.ForeColor = System.Drawing.Color.White;
            this.buttonRedoLop.HoverState.Parent = this.buttonRedoLop;
            this.buttonRedoLop.Image = global::TracNghiemCSDLPT.Properties.Resources.redo_480px;
            this.buttonRedoLop.ImageSize = new System.Drawing.Size(30, 30);
            this.buttonRedoLop.Location = new System.Drawing.Point(1366, 31);
            this.buttonRedoLop.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.buttonRedoLop.Name = "buttonRedoLop";
            this.buttonRedoLop.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.buttonRedoLop.ShadowDecoration.Parent = this.buttonRedoLop;
            this.buttonRedoLop.Size = new System.Drawing.Size(32, 32);
            this.buttonRedoLop.TabIndex = 22;
            this.buttonRedoLop.Visible = false;
            // 
            // buttonUndoLop
            // 
            this.buttonUndoLop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUndoLop.CheckedState.Parent = this.buttonUndoLop;
            this.buttonUndoLop.CustomImages.Parent = this.buttonUndoLop;
            this.buttonUndoLop.FillColor = System.Drawing.Color.Transparent;
            this.buttonUndoLop.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonUndoLop.ForeColor = System.Drawing.Color.White;
            this.buttonUndoLop.HoverState.Parent = this.buttonUndoLop;
            this.buttonUndoLop.Image = global::TracNghiemCSDLPT.Properties.Resources.undo_480px1;
            this.buttonUndoLop.ImageSize = new System.Drawing.Size(30, 30);
            this.buttonUndoLop.Location = new System.Drawing.Point(1313, 31);
            this.buttonUndoLop.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.buttonUndoLop.Name = "buttonUndoLop";
            this.buttonUndoLop.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.buttonUndoLop.ShadowDecoration.Parent = this.buttonUndoLop;
            this.buttonUndoLop.Size = new System.Drawing.Size(32, 32);
            this.buttonUndoLop.TabIndex = 23;
            this.buttonUndoLop.Visible = false;
            // 
            // buttonXacNhanLop
            // 
            this.buttonXacNhanLop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonXacNhanLop.CheckedState.Parent = this.buttonXacNhanLop;
            this.buttonXacNhanLop.CustomImages.Parent = this.buttonXacNhanLop;
            this.buttonXacNhanLop.FillColor = System.Drawing.Color.Transparent;
            this.buttonXacNhanLop.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonXacNhanLop.ForeColor = System.Drawing.Color.White;
            this.buttonXacNhanLop.HoverState.Parent = this.buttonXacNhanLop;
            this.buttonXacNhanLop.Image = global::TracNghiemCSDLPT.Properties.Resources.ok_480px;
            this.buttonXacNhanLop.ImageSize = new System.Drawing.Size(30, 30);
            this.buttonXacNhanLop.Location = new System.Drawing.Point(1013, 31);
            this.buttonXacNhanLop.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.buttonXacNhanLop.Name = "buttonXacNhanLop";
            this.buttonXacNhanLop.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.buttonXacNhanLop.ShadowDecoration.Parent = this.buttonXacNhanLop;
            this.buttonXacNhanLop.Size = new System.Drawing.Size(30, 30);
            this.buttonXacNhanLop.TabIndex = 24;
            this.buttonXacNhanLop.Visible = false;
            this.buttonXacNhanLop.Click += new System.EventHandler(this.buttonXacNhanLop_Click);
            // 
            // buttonHuySV
            // 
            this.buttonHuySV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonHuySV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.buttonHuySV.CheckedState.Parent = this.buttonHuySV;
            this.buttonHuySV.CustomImages.Parent = this.buttonHuySV;
            this.buttonHuySV.FillColor = System.Drawing.Color.Transparent;
            this.buttonHuySV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonHuySV.ForeColor = System.Drawing.Color.White;
            this.buttonHuySV.HoverState.Parent = this.buttonHuySV;
            this.buttonHuySV.Image = global::TracNghiemCSDLPT.Properties.Resources.cancel_480px;
            this.buttonHuySV.ImageSize = new System.Drawing.Size(30, 30);
            this.buttonHuySV.Location = new System.Drawing.Point(346, 18);
            this.buttonHuySV.Margin = new System.Windows.Forms.Padding(3, 3, 50, 3);
            this.buttonHuySV.Name = "buttonHuySV";
            this.buttonHuySV.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.buttonHuySV.ShadowDecoration.Parent = this.buttonHuySV;
            this.buttonHuySV.Size = new System.Drawing.Size(30, 30);
            this.buttonHuySV.TabIndex = 25;
            this.buttonHuySV.Visible = false;
            this.buttonHuySV.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonHuySV_MouseUp);
            // 
            // buttonRedoSV
            // 
            this.buttonRedoSV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonRedoSV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.buttonRedoSV.CheckedState.Parent = this.buttonRedoSV;
            this.buttonRedoSV.CustomImages.Parent = this.buttonRedoSV;
            this.buttonRedoSV.FillColor = System.Drawing.Color.Transparent;
            this.buttonRedoSV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonRedoSV.ForeColor = System.Drawing.Color.White;
            this.buttonRedoSV.HoverState.Parent = this.buttonRedoSV;
            this.buttonRedoSV.Image = global::TracNghiemCSDLPT.Properties.Resources.redo_480px;
            this.buttonRedoSV.ImageSize = new System.Drawing.Size(30, 30);
            this.buttonRedoSV.Location = new System.Drawing.Point(943, 18);
            this.buttonRedoSV.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.buttonRedoSV.Name = "buttonRedoSV";
            this.buttonRedoSV.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.buttonRedoSV.ShadowDecoration.Parent = this.buttonRedoSV;
            this.buttonRedoSV.Size = new System.Drawing.Size(32, 32);
            this.buttonRedoSV.TabIndex = 26;
            this.buttonRedoSV.Visible = false;
            // 
            // buttonUndoSV
            // 
            this.buttonUndoSV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonUndoSV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.buttonUndoSV.CheckedState.Parent = this.buttonUndoSV;
            this.buttonUndoSV.CustomImages.Parent = this.buttonUndoSV;
            this.buttonUndoSV.FillColor = System.Drawing.Color.Transparent;
            this.buttonUndoSV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonUndoSV.ForeColor = System.Drawing.Color.White;
            this.buttonUndoSV.HoverState.Parent = this.buttonUndoSV;
            this.buttonUndoSV.Image = global::TracNghiemCSDLPT.Properties.Resources.undo_480px1;
            this.buttonUndoSV.ImageSize = new System.Drawing.Size(30, 30);
            this.buttonUndoSV.Location = new System.Drawing.Point(888, 18);
            this.buttonUndoSV.Margin = new System.Windows.Forms.Padding(50, 3, 20, 3);
            this.buttonUndoSV.Name = "buttonUndoSV";
            this.buttonUndoSV.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.buttonUndoSV.ShadowDecoration.Parent = this.buttonUndoSV;
            this.buttonUndoSV.Size = new System.Drawing.Size(32, 32);
            this.buttonUndoSV.TabIndex = 27;
            this.buttonUndoSV.Visible = false;
            // 
            // buttonXacNhanSV
            // 
            this.buttonXacNhanSV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonXacNhanSV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.buttonXacNhanSV.CheckedState.Parent = this.buttonXacNhanSV;
            this.buttonXacNhanSV.CustomImages.Parent = this.buttonXacNhanSV;
            this.buttonXacNhanSV.FillColor = System.Drawing.Color.Transparent;
            this.buttonXacNhanSV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonXacNhanSV.ForeColor = System.Drawing.Color.White;
            this.buttonXacNhanSV.HoverState.Parent = this.buttonXacNhanSV;
            this.buttonXacNhanSV.Image = global::TracNghiemCSDLPT.Properties.Resources.ok_480px;
            this.buttonXacNhanSV.ImageSize = new System.Drawing.Size(30, 30);
            this.buttonXacNhanSV.Location = new System.Drawing.Point(291, 18);
            this.buttonXacNhanSV.Margin = new System.Windows.Forms.Padding(3, 0, 20, 3);
            this.buttonXacNhanSV.Name = "buttonXacNhanSV";
            this.buttonXacNhanSV.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.buttonXacNhanSV.ShadowDecoration.Parent = this.buttonXacNhanSV;
            this.buttonXacNhanSV.Size = new System.Drawing.Size(30, 30);
            this.buttonXacNhanSV.TabIndex = 28;
            this.buttonXacNhanSV.Visible = false;
            this.buttonXacNhanSV.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonXacNhanSV_MouseUp);
            // 
            // MaLopEP
            // 
            this.MaLopEP.ContainerControl = this;
            // 
            // TenLopEP
            // 
            this.TenLopEP.ContainerControl = this;
            // 
            // MaKhoaEP
            // 
            this.MaKhoaEP.ContainerControl = this;
            // 
            // TextMaKH
            // 
            this.TextMaKH.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.LopBindingSource, "MAKH", true));
            this.TextMaKH.Location = new System.Drawing.Point(249, 25);
            this.TextMaKH.Name = "TextMaKH";
            this.TextMaKH.Size = new System.Drawing.Size(27, 22);
            this.TextMaKH.TabIndex = 29;
            // 
            // GV_DKBindingSource
            // 
            this.GV_DKBindingSource.DataMember = "FK_GIAOVIEN_DANGKY_LOP";
            this.GV_DKBindingSource.DataSource = this.LopBindingSource;
            // 
            // GV_DKTableAdapter
            // 
            this.GV_DKTableAdapter.ClearBeforeFill = true;
            // 
            // ViewCaption
            // 
            this.ViewCaption.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ViewCaption.AutoSize = true;
            this.ViewCaption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ViewCaption.Font = new System.Drawing.Font("Baloo 2", 13.8F, System.Drawing.FontStyle.Bold);
            this.ViewCaption.ForeColor = System.Drawing.Color.Black;
            this.ViewCaption.Location = new System.Drawing.Point(430, 18);
            this.ViewCaption.Name = "ViewCaption";
            this.ViewCaption.Size = new System.Drawing.Size(405, 39);
            this.ViewCaption.TabIndex = 29;
            this.ViewCaption.Text = "Danh sách sinh viên thuộc lớp TH04";
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.bunifuPanel1.BorderRadius = 3;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.ViewCaption);
            this.bunifuPanel1.Controls.Add(this.buttonRedoSV);
            this.bunifuPanel1.Controls.Add(this.buttonXacNhanSV);
            this.bunifuPanel1.Controls.Add(this.buttonUndoSV);
            this.bunifuPanel1.Controls.Add(this.buttonHuySV);
            this.bunifuPanel1.Location = new System.Drawing.Point(149, 445);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(1267, 68);
            this.bunifuPanel1.TabIndex = 31;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // dxErrorProvider1
            // 
            this.dxErrorProvider1.ContainerControl = this;
            // 
            // BangDiemBindingSource
            // 
            this.BangDiemBindingSource.DataMember = "FK_BANGDIEM_SINHVIEN";
            this.BangDiemBindingSource.DataSource = this.SinhVienBindingSource;
            // 
            // BangDiemTableAdapter
            // 
            this.BangDiemTableAdapter.ClearBeforeFill = true;
            // 
            // lOPBindingSource1
            // 
            this.lOPBindingSource1.DataMember = "FK_LOP_KHOA";
            this.lOPBindingSource1.DataSource = this.KhoaBindingSource;
            // 
            // FormSVL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1421, 805);
            this.Controls.Add(this.CoSoComboBox);
            this.Controls.Add(this.SinhVienGridControl);
            this.Controls.Add(this.bunifuPanel1);
            this.Controls.Add(this.TextMaKH);
            this.Controls.Add(this.buttonHuyLop);
            this.Controls.Add(this.buttonRedoLop);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonUndoLop);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonXacNhanLop);
            this.Controls.Add(this.InfoPanel);
            this.Controls.Add(this.KhoaGridControl);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("FormSVL.IconOptions.Icon")));
            this.Name = "FormSVL";
            this.Text = "Sinh viên và lớp";
            this.Load += new System.EventHandler(this.FormSVL_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LopGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KhoaGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KhoaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TN_CSDLPTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KhoaGridView)).EndInit();
            this.InfoPanel.ResumeLayout(false);
            this.InfoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextTenLop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LopBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextMaLop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SinhVienGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SinhVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SinhVienGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardView1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MaLopEP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TenLopEP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaKhoaEP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextMaKH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GV_DKBindingSource)).EndInit();
            this.bunifuPanel1.ResumeLayout(false);
            this.bunifuPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BangDiemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TN_CSDLPTDataSet TN_CSDLPTDataSet;
        private System.Windows.Forms.BindingSource KhoaBindingSource;
        private TN_CSDLPTDataSetTableAdapters.KHOATableAdapter KhoaTableAdapter;
        private TN_CSDLPTDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl KhoaGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView KhoaGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKH;
        private DevExpress.XtraGrid.Columns.GridColumn colTENKH;
        private DevExpress.XtraGrid.Columns.GridColumn colMACS;
        private DevExpress.XtraGrid.Views.Grid.GridView LopGridView;
        private System.Windows.Forms.GroupBox InfoPanel;
        private DevExpress.XtraEditors.TextEdit TextTenLop;
        private DevExpress.XtraEditors.TextEdit TextMaLop;
        private DevExpress.XtraGrid.GridControl SinhVienGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView SinhVienGridView;
        private DevExpress.XtraGrid.Views.Card.CardView cardView1;
        private Guna.UI2.WinForms.Guna2Button buttonSuaLop;
        private Guna.UI2.WinForms.Guna2Button buttonThemLop;
        private Guna.UI2.WinForms.Guna2Button buttonLamMoiLop;
        private Guna.UI2.WinForms.Guna2Button buttonXoaLop;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button buttonLamMoiSV;
        private Guna.UI2.WinForms.Guna2Button buttonThemSV;
        private Guna.UI2.WinForms.Guna2Button buttonSuaSV;
        private Guna.UI2.WinForms.Guna2Button buttonXoaSV;
        private DevExpress.XtraGrid.Columns.GridColumn colMASV;
        private DevExpress.XtraGrid.Columns.GridColumn colHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYSINH;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.BindingSource LopBindingSource;
        private TN_CSDLPTDataSetTableAdapters.LOPTableAdapter LopTableAdapter;
        private System.Windows.Forms.BindingSource SinhVienBindingSource;
        private TN_CSDLPTDataSetTableAdapters.SINHVIENTableAdapter SinhVienTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colMALOP1;
        private DevExpress.XtraGrid.Columns.GridColumn colTENLOP;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKH1;
        private Guna.UI2.WinForms.Guna2ComboBox CoSoComboBox;
        private Guna.UI2.WinForms.Guna2CircleButton buttonRedoLop;
        private Guna.UI2.WinForms.Guna2CircleButton buttonUndoLop;
        private Guna.UI2.WinForms.Guna2CircleButton buttonHuyLop;
        private Guna.UI2.WinForms.Guna2CircleButton buttonXacNhanLop;
        private Guna.UI2.WinForms.Guna2CircleButton buttonHuySV;
        private Guna.UI2.WinForms.Guna2CircleButton buttonRedoSV;
        private Guna.UI2.WinForms.Guna2CircleButton buttonUndoSV;
        private Guna.UI2.WinForms.Guna2CircleButton buttonXacNhanSV;
        private System.Windows.Forms.ErrorProvider MaLopEP;
        private System.Windows.Forms.ErrorProvider TenLopEP;
        private System.Windows.Forms.ErrorProvider MaKhoaEP;
        private DevExpress.XtraEditors.TextEdit TextMaKH;
        private Guna.UI2.WinForms.Guna2ComboBox ComboMaKH;
        private System.Windows.Forms.BindingSource GV_DKBindingSource;
        private TN_CSDLPTDataSetTableAdapters.GIAOVIEN_DANGKYTableAdapter GV_DKTableAdapter;
        private System.Windows.Forms.Label ViewCaption;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider1;
        private DevExpress.Utils.ToolTipController toolTipController1;
        private System.Windows.Forms.BindingSource BangDiemBindingSource;
        private TN_CSDLPTDataSetTableAdapters.BANGDIEMTableAdapter BangDiemTableAdapter;
        private System.Windows.Forms.BindingSource lOPBindingSource1;
    }
}