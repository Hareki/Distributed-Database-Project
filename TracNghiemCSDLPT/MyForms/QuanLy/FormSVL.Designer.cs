
namespace TracNghiemCSDLPT.MyForms.QuanLy
{
    partial class FormSvl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSvl));
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
            this.buttonLamMoiLop = new Guna.UI2.WinForms.Guna2Button();
            this.buttonSuaLop = new Guna.UI2.WinForms.Guna2Button();
            this.buttonThemLop = new Guna.UI2.WinForms.Guna2Button();
            this.buttonXoaLop = new Guna.UI2.WinForms.Guna2Button();
            this.buttonHuyLop = new Guna.UI2.WinForms.Guna2CircleButton();
            this.TextTenLop = new DevExpress.XtraEditors.TextEdit();
            this.LopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TextMaLop = new DevExpress.XtraEditors.TextEdit();
            this.buttonXacNhanLop = new Guna.UI2.WinForms.Guna2CircleButton();
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
            this.buttonHuySV = new Guna.UI2.WinForms.Guna2CircleButton();
            this.buttonXacNhanSV = new Guna.UI2.WinForms.Guna2CircleButton();
            this.MaLopEP = new System.Windows.Forms.ErrorProvider(this.components);
            this.TenLopEP = new System.Windows.Forms.ErrorProvider(this.components);
            this.MaKhoaEP = new System.Windows.Forms.ErrorProvider(this.components);
            this.GV_DKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GV_DKTableAdapter = new TracNghiemCSDLPT.TN_CSDLPTDataSetTableAdapters.GIAOVIEN_DANGKYTableAdapter();
            this.ViewCaption = new System.Windows.Forms.Label();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.buttonUndoSV = new Guna.UI2.WinForms.Guna2CircleButton();
            this.buttonRedoSV = new Guna.UI2.WinForms.Guna2CircleButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.dxErrorProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.BangDiemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BangDiemTableAdapter = new TracNghiemCSDLPT.TN_CSDLPTDataSetTableAdapters.BANGDIEMTableAdapter();
            this.FKLopKhoaBds = new System.Windows.Forms.BindingSource(this.components);
            this.buttonUndoLop = new Guna.UI2.WinForms.Guna2CircleButton();
            this.buttonRedoLop = new Guna.UI2.WinForms.Guna2CircleButton();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.InfoPanel = new Bunifu.UI.WinForms.BunifuGroupBox();
            this.ComboMaKH = new DevExpress.XtraEditors.GridLookUpEdit();
            this.DSKhoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAKH2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENKH1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DSKhoaTableAdapter = new TracNghiemCSDLPT.TN_CSDLPTDataSetTableAdapters.DSKhoaTableAdapter();
            mALOPLabel = new System.Windows.Forms.Label();
            tENLOPLabel = new System.Windows.Forms.Label();
            mAKHLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.LopGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KhoaGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KhoaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TN_CSDLPTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KhoaGridView)).BeginInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.GV_DKBindingSource)).BeginInit();
            this.bunifuPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BangDiemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FKLopKhoaBds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.InfoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ComboMaKH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSKhoaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
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
            this.KhoaGridControl.Size = new System.Drawing.Size(843, 351);
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
            this.KhoaGridView.Appearance.Row.Font = new System.Drawing.Font("Baloo 2", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.KhoaGridView.OptionsPrint.EnableAppearanceOddRow = true;
            this.KhoaGridView.OptionsScrollAnnotations.ShowFocusedRow = DevExpress.Utils.DefaultBoolean.True;
            this.KhoaGridView.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.AnimateAllContent;
            this.KhoaGridView.OptionsView.EnableAppearanceOddRow = true;
            this.KhoaGridView.OptionsView.ShowGroupPanel = false;
            this.KhoaGridView.OptionsView.ShowIndicator = false;
            this.KhoaGridView.OptionsView.ShowViewCaption = true;
            this.KhoaGridView.ViewCaption = "Danh sách lớp theo khoa";
            this.KhoaGridView.ViewCaptionHeight = 50;
            this.KhoaGridView.MasterRowGetRelationDisplayCaption += new DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationNameEventHandler(this.KhoaGridView_MasterRowGetRelationDisplayCaption);
            this.KhoaGridView.DetailTabStyle += new System.EventHandler<DevExpress.XtraGrid.Views.Grid.DetailTabStyleEventArgs>(this.KhoaGridView_DetailTabStyle);
            this.KhoaGridView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.KhoaGridView_FocusedRowChanged);
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
            mALOPLabel.Location = new System.Drawing.Point(15, 83);
            mALOPLabel.Name = "mALOPLabel";
            mALOPLabel.Size = new System.Drawing.Size(70, 30);
            mALOPLabel.TabIndex = 0;
            mALOPLabel.Text = "Mã lớp";
            // 
            // tENLOPLabel
            // 
            tENLOPLabel.AutoSize = true;
            tENLOPLabel.Font = new System.Drawing.Font("Baloo 2", 10.8F, System.Drawing.FontStyle.Bold);
            tENLOPLabel.Location = new System.Drawing.Point(15, 165);
            tENLOPLabel.Name = "tENLOPLabel";
            tENLOPLabel.Size = new System.Drawing.Size(75, 30);
            tENLOPLabel.TabIndex = 2;
            tENLOPLabel.Text = "Tên lớp";
            // 
            // mAKHLabel
            // 
            mAKHLabel.AutoSize = true;
            mAKHLabel.Font = new System.Drawing.Font("Baloo 2", 10.8F, System.Drawing.FontStyle.Bold);
            mAKHLabel.Location = new System.Drawing.Point(15, 247);
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
            this.tableAdapterManager.BAITHITableAdapter = null;
            this.tableAdapterManager.BANGDIEMTableAdapter = null;
            this.tableAdapterManager.BODE_BKTableAdapter = null;
            this.tableAdapterManager.BODETableAdapter = null;
            this.tableAdapterManager.COSOTableAdapter = null;
            this.tableAdapterManager.GIAOVIEN_DANGKYTableAdapter = null;
            this.tableAdapterManager.GIAOVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = this.KhoaTableAdapter;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TracNghiemCSDLPT.TN_CSDLPTDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // buttonLamMoiLop
            // 
            this.buttonLamMoiLop.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonLamMoiLop.Animated = true;
            this.buttonLamMoiLop.BorderRadius = 8;
            this.buttonLamMoiLop.CheckedState.Parent = this.buttonLamMoiLop;
            this.buttonLamMoiLop.CustomImages.Parent = this.buttonLamMoiLop;
            this.buttonLamMoiLop.FillColor = System.Drawing.Color.Gainsboro;
            this.buttonLamMoiLop.Font = new System.Drawing.Font("Baloo 2 ExtraBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLamMoiLop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(70)))), ((int)(((byte)(68)))));
            this.buttonLamMoiLop.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.buttonLamMoiLop.HoverState.Parent = this.buttonLamMoiLop;
            this.buttonLamMoiLop.Image = global::TracNghiemCSDLPT.Properties.Resources.reset_480px;
            this.buttonLamMoiLop.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.buttonLamMoiLop.ImageSize = new System.Drawing.Size(35, 35);
            this.buttonLamMoiLop.Location = new System.Drawing.Point(357, 271);
            this.buttonLamMoiLop.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.buttonLamMoiLop.Name = "buttonLamMoiLop";
            this.buttonLamMoiLop.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.buttonLamMoiLop.ShadowDecoration.Parent = this.buttonLamMoiLop;
            this.buttonLamMoiLop.Size = new System.Drawing.Size(129, 45);
            this.buttonLamMoiLop.TabIndex = 18;
            this.buttonLamMoiLop.Text = "Làm mới";
            this.buttonLamMoiLop.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.buttonLamMoiLop.TextOffset = new System.Drawing.Point(-3, 0);
            this.buttonLamMoiLop.Click += new System.EventHandler(this.buttonLamMoiLop_Click);
            // 
            // buttonSuaLop
            // 
            this.buttonSuaLop.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonSuaLop.Animated = true;
            this.buttonSuaLop.BorderRadius = 8;
            this.buttonSuaLop.CheckedState.Parent = this.buttonSuaLop;
            this.buttonSuaLop.CustomImages.Parent = this.buttonSuaLop;
            this.buttonSuaLop.FillColor = System.Drawing.Color.Gainsboro;
            this.buttonSuaLop.Font = new System.Drawing.Font("Baloo 2 ExtraBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSuaLop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(70)))), ((int)(((byte)(68)))));
            this.buttonSuaLop.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.buttonSuaLop.HoverState.Parent = this.buttonSuaLop;
            this.buttonSuaLop.Image = global::TracNghiemCSDLPT.Properties.Resources.edit_480px;
            this.buttonSuaLop.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.buttonSuaLop.ImageSize = new System.Drawing.Size(35, 35);
            this.buttonSuaLop.Location = new System.Drawing.Point(357, 202);
            this.buttonSuaLop.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.buttonSuaLop.Name = "buttonSuaLop";
            this.buttonSuaLop.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.buttonSuaLop.ShadowDecoration.Parent = this.buttonSuaLop;
            this.buttonSuaLop.Size = new System.Drawing.Size(129, 45);
            this.buttonSuaLop.TabIndex = 16;
            this.buttonSuaLop.Text = "Sửa";
            this.buttonSuaLop.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.buttonSuaLop.TextOffset = new System.Drawing.Point(-3, 0);
            this.buttonSuaLop.Click += new System.EventHandler(this.buttonSuaLop_Click);
            // 
            // buttonThemLop
            // 
            this.buttonThemLop.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonThemLop.Animated = true;
            this.buttonThemLop.BorderRadius = 8;
            this.buttonThemLop.CheckedState.Parent = this.buttonThemLop;
            this.buttonThemLop.CustomImages.Parent = this.buttonThemLop;
            this.buttonThemLop.FillColor = System.Drawing.Color.Gainsboro;
            this.buttonThemLop.Font = new System.Drawing.Font("Baloo 2 ExtraBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThemLop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(70)))), ((int)(((byte)(68)))));
            this.buttonThemLop.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.buttonThemLop.HoverState.Parent = this.buttonThemLop;
            this.buttonThemLop.Image = global::TracNghiemCSDLPT.Properties.Resources.add_480px;
            this.buttonThemLop.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.buttonThemLop.ImageSize = new System.Drawing.Size(35, 35);
            this.buttonThemLop.Location = new System.Drawing.Point(357, 64);
            this.buttonThemLop.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.buttonThemLop.Name = "buttonThemLop";
            this.buttonThemLop.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.buttonThemLop.ShadowDecoration.Parent = this.buttonThemLop;
            this.buttonThemLop.Size = new System.Drawing.Size(129, 45);
            this.buttonThemLop.TabIndex = 17;
            this.buttonThemLop.Text = "Thêm";
            this.buttonThemLop.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.buttonThemLop.TextOffset = new System.Drawing.Point(-3, 0);
            this.buttonThemLop.Click += new System.EventHandler(this.buttonThemLop_Click);
            // 
            // buttonXoaLop
            // 
            this.buttonXoaLop.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonXoaLop.Animated = true;
            this.buttonXoaLop.BorderRadius = 8;
            this.buttonXoaLop.CheckedState.Parent = this.buttonXoaLop;
            this.buttonXoaLop.CustomImages.Parent = this.buttonXoaLop;
            this.buttonXoaLop.FillColor = System.Drawing.Color.Gainsboro;
            this.buttonXoaLop.Font = new System.Drawing.Font("Baloo 2 ExtraBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXoaLop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(70)))), ((int)(((byte)(68)))));
            this.buttonXoaLop.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.buttonXoaLop.HoverState.Parent = this.buttonXoaLop;
            this.buttonXoaLop.Image = global::TracNghiemCSDLPT.Properties.Resources.minus_sign_480px;
            this.buttonXoaLop.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.buttonXoaLop.ImageSize = new System.Drawing.Size(35, 35);
            this.buttonXoaLop.Location = new System.Drawing.Point(357, 133);
            this.buttonXoaLop.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.buttonXoaLop.Name = "buttonXoaLop";
            this.buttonXoaLop.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.buttonXoaLop.ShadowDecoration.Parent = this.buttonXoaLop;
            this.buttonXoaLop.Size = new System.Drawing.Size(129, 45);
            this.buttonXoaLop.TabIndex = 19;
            this.buttonXoaLop.Text = "Xóa";
            this.buttonXoaLop.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.buttonXoaLop.TextOffset = new System.Drawing.Point(-3, 0);
            this.buttonXoaLop.Click += new System.EventHandler(this.buttonXoaLop_Click);
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
            this.buttonHuyLop.Location = new System.Drawing.Point(288, 64);
            this.buttonHuyLop.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.buttonHuyLop.Name = "buttonHuyLop";
            this.buttonHuyLop.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.buttonHuyLop.ShadowDecoration.Parent = this.buttonHuyLop;
            this.buttonHuyLop.Size = new System.Drawing.Size(26, 30);
            this.buttonHuyLop.TabIndex = 21;
            this.buttonHuyLop.Visible = false;
            this.buttonHuyLop.Click += new System.EventHandler(this.buttonHuyLop_Click);
            // 
            // TextTenLop
            // 
            this.TextTenLop.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.LopBindingSource, "TENLOP", true));
            this.TextTenLop.Enabled = false;
            this.TextTenLop.Location = new System.Drawing.Point(19, 198);
            this.TextTenLop.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.TextTenLop.Name = "TextTenLop";
            this.TextTenLop.Properties.Appearance.Font = new System.Drawing.Font("Baloo 2", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextTenLop.Properties.Appearance.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.TextTenLop.Properties.Appearance.Options.UseFont = true;
            this.TextTenLop.Properties.Appearance.Options.UseForeColor = true;
            this.TextTenLop.Size = new System.Drawing.Size(292, 38);
            this.TextTenLop.TabIndex = 3;
            this.TextTenLop.Enter += new System.EventHandler(this.Editor_GotFocus);
            this.TextTenLop.Leave += new System.EventHandler(this.Editor_LostFocus);
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
            this.TextMaLop.Location = new System.Drawing.Point(20, 116);
            this.TextMaLop.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.TextMaLop.Name = "TextMaLop";
            this.TextMaLop.Properties.Appearance.Font = new System.Drawing.Font("Baloo 2", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextMaLop.Properties.Appearance.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.TextMaLop.Properties.Appearance.Options.UseFont = true;
            this.TextMaLop.Properties.Appearance.Options.UseForeColor = true;
            this.TextMaLop.Size = new System.Drawing.Size(291, 38);
            this.TextMaLop.TabIndex = 1;
            this.TextMaLop.Enter += new System.EventHandler(this.Editor_GotFocus);
            this.TextMaLop.Leave += new System.EventHandler(this.Editor_LostFocus);
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
            this.buttonXacNhanLop.Location = new System.Drawing.Point(235, 64);
            this.buttonXacNhanLop.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.buttonXacNhanLop.Name = "buttonXacNhanLop";
            this.buttonXacNhanLop.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.buttonXacNhanLop.ShadowDecoration.Parent = this.buttonXacNhanLop;
            this.buttonXacNhanLop.Size = new System.Drawing.Size(26, 30);
            this.buttonXacNhanLop.TabIndex = 24;
            this.buttonXacNhanLop.Visible = false;
            this.buttonXacNhanLop.Click += new System.EventHandler(this.ButtonXacNhanLop_Click);
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
            this.SinhVienGridControl.Size = new System.Drawing.Size(1221, 328);
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
            this.SinhVienGridView.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(this.SinhVienGridView_PopupMenuShowing);
            this.SinhVienGridView.ShownEditor += new System.EventHandler(this.SinhVienGridView_ShownEditor);
            this.SinhVienGridView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.SinhVienGridView_FocusedRowChanged);
            this.SinhVienGridView.InvalidRowException += new DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventHandler(this.SinhVienGridView_InvalidRowException);
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
            this.panel1.Size = new System.Drawing.Size(136, 374);
            this.panel1.TabIndex = 16;
            // 
            // buttonLamMoiSV
            // 
            this.buttonLamMoiSV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonLamMoiSV.Animated = true;
            this.buttonLamMoiSV.BorderRadius = 10;
            this.buttonLamMoiSV.CheckedState.Parent = this.buttonLamMoiSV;
            this.buttonLamMoiSV.CustomImages.Parent = this.buttonLamMoiSV;
            this.buttonLamMoiSV.FillColor = System.Drawing.Color.Gainsboro;
            this.buttonLamMoiSV.Font = new System.Drawing.Font("Baloo 2 ExtraBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLamMoiSV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(70)))), ((int)(((byte)(68)))));
            this.buttonLamMoiSV.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.buttonLamMoiSV.HoverState.Parent = this.buttonLamMoiSV;
            this.buttonLamMoiSV.Image = global::TracNghiemCSDLPT.Properties.Resources.reset_480px;
            this.buttonLamMoiSV.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.buttonLamMoiSV.ImageOffset = new System.Drawing.Point(-3, 0);
            this.buttonLamMoiSV.ImageSize = new System.Drawing.Size(35, 35);
            this.buttonLamMoiSV.Location = new System.Drawing.Point(2, 277);
            this.buttonLamMoiSV.Margin = new System.Windows.Forms.Padding(3, 3, 3, 27);
            this.buttonLamMoiSV.Name = "buttonLamMoiSV";
            this.buttonLamMoiSV.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.buttonLamMoiSV.ShadowDecoration.Parent = this.buttonLamMoiSV;
            this.buttonLamMoiSV.Size = new System.Drawing.Size(133, 45);
            this.buttonLamMoiSV.TabIndex = 22;
            this.buttonLamMoiSV.Text = "Làm mới";
            this.buttonLamMoiSV.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.buttonLamMoiSV.Click += new System.EventHandler(this.buttonLamMoiSV_Click);
            // 
            // buttonThemSV
            // 
            this.buttonThemSV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonThemSV.Animated = true;
            this.buttonThemSV.BorderRadius = 10;
            this.buttonThemSV.CheckedState.Parent = this.buttonThemSV;
            this.buttonThemSV.CustomImages.Parent = this.buttonThemSV;
            this.buttonThemSV.FillColor = System.Drawing.Color.Gainsboro;
            this.buttonThemSV.Font = new System.Drawing.Font("Baloo 2 ExtraBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThemSV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(70)))), ((int)(((byte)(68)))));
            this.buttonThemSV.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.buttonThemSV.HoverState.Parent = this.buttonThemSV;
            this.buttonThemSV.Image = global::TracNghiemCSDLPT.Properties.Resources.add_480px;
            this.buttonThemSV.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.buttonThemSV.ImageOffset = new System.Drawing.Point(-3, 0);
            this.buttonThemSV.ImageSize = new System.Drawing.Size(35, 35);
            this.buttonThemSV.Location = new System.Drawing.Point(2, 52);
            this.buttonThemSV.Margin = new System.Windows.Forms.Padding(3, 3, 3, 27);
            this.buttonThemSV.Name = "buttonThemSV";
            this.buttonThemSV.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.buttonThemSV.ShadowDecoration.Parent = this.buttonThemSV;
            this.buttonThemSV.Size = new System.Drawing.Size(133, 45);
            this.buttonThemSV.TabIndex = 21;
            this.buttonThemSV.Text = "Thêm";
            this.buttonThemSV.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.buttonThemSV.Click += new System.EventHandler(this.ButtonThemSV_Click);
            // 
            // buttonSuaSV
            // 
            this.buttonSuaSV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSuaSV.Animated = true;
            this.buttonSuaSV.BorderRadius = 10;
            this.buttonSuaSV.CheckedState.Parent = this.buttonSuaSV;
            this.buttonSuaSV.CustomImages.Parent = this.buttonSuaSV;
            this.buttonSuaSV.FillColor = System.Drawing.Color.Gainsboro;
            this.buttonSuaSV.Font = new System.Drawing.Font("Baloo 2 ExtraBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSuaSV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(70)))), ((int)(((byte)(68)))));
            this.buttonSuaSV.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.buttonSuaSV.HoverState.Parent = this.buttonSuaSV;
            this.buttonSuaSV.Image = global::TracNghiemCSDLPT.Properties.Resources.edit_480px;
            this.buttonSuaSV.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.buttonSuaSV.ImageOffset = new System.Drawing.Point(-3, 0);
            this.buttonSuaSV.ImageSize = new System.Drawing.Size(35, 35);
            this.buttonSuaSV.Location = new System.Drawing.Point(2, 202);
            this.buttonSuaSV.Margin = new System.Windows.Forms.Padding(3, 3, 3, 27);
            this.buttonSuaSV.Name = "buttonSuaSV";
            this.buttonSuaSV.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.buttonSuaSV.ShadowDecoration.Parent = this.buttonSuaSV;
            this.buttonSuaSV.Size = new System.Drawing.Size(133, 45);
            this.buttonSuaSV.TabIndex = 20;
            this.buttonSuaSV.Text = "Sửa";
            this.buttonSuaSV.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.buttonSuaSV.Click += new System.EventHandler(this.buttonSuaSV_Click);
            // 
            // buttonXoaSV
            // 
            this.buttonXoaSV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonXoaSV.Animated = true;
            this.buttonXoaSV.BorderRadius = 10;
            this.buttonXoaSV.CheckedState.Parent = this.buttonXoaSV;
            this.buttonXoaSV.CustomImages.Parent = this.buttonXoaSV;
            this.buttonXoaSV.FillColor = System.Drawing.Color.Gainsboro;
            this.buttonXoaSV.Font = new System.Drawing.Font("Baloo 2 ExtraBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXoaSV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(70)))), ((int)(((byte)(68)))));
            this.buttonXoaSV.HoverState.FillColor = System.Drawing.Color.Gainsboro;
            this.buttonXoaSV.HoverState.Parent = this.buttonXoaSV;
            this.buttonXoaSV.Image = global::TracNghiemCSDLPT.Properties.Resources.minus_sign_480px;
            this.buttonXoaSV.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.buttonXoaSV.ImageOffset = new System.Drawing.Point(-3, 0);
            this.buttonXoaSV.ImageSize = new System.Drawing.Size(35, 35);
            this.buttonXoaSV.Location = new System.Drawing.Point(2, 127);
            this.buttonXoaSV.Margin = new System.Windows.Forms.Padding(3, 3, 3, 27);
            this.buttonXoaSV.Name = "buttonXoaSV";
            this.buttonXoaSV.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.buttonXoaSV.ShadowDecoration.Parent = this.buttonXoaSV;
            this.buttonXoaSV.Size = new System.Drawing.Size(133, 45);
            this.buttonXoaSV.TabIndex = 23;
            this.buttonXoaSV.Text = "Xóa";
            this.buttonXoaSV.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.buttonXoaSV.Click += new System.EventHandler(this.buttonXoaSV_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Baloo 2", 10.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(15, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 9, 0);
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
            this.bunifuSeparator1.Location = new System.Drawing.Point(7, 425);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.bunifuSeparator1.Size = new System.Drawing.Size(1360, 13);
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
            this.CoSoComboBox.Location = new System.Drawing.Point(126, 19);
            this.CoSoComboBox.Margin = new System.Windows.Forms.Padding(9, 10, 3, 10);
            this.CoSoComboBox.Name = "CoSoComboBox";
            this.CoSoComboBox.ShadowDecoration.Parent = this.CoSoComboBox;
            this.CoSoComboBox.Size = new System.Drawing.Size(254, 36);
            this.CoSoComboBox.TabIndex = 20;
            this.CoSoComboBox.TextOffset = new System.Drawing.Point(3, 3);
            this.CoSoComboBox.SelectedIndexChanged += new System.EventHandler(this.CoSoComboBox_SelectedIndexChanged);
            // 
            // buttonHuySV
            // 
            this.buttonHuySV.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonHuySV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.buttonHuySV.CheckedState.Parent = this.buttonHuySV;
            this.buttonHuySV.CustomImages.Parent = this.buttonHuySV;
            this.buttonHuySV.FillColor = System.Drawing.Color.Transparent;
            this.buttonHuySV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonHuySV.ForeColor = System.Drawing.Color.White;
            this.buttonHuySV.HoverState.Parent = this.buttonHuySV;
            this.buttonHuySV.Image = global::TracNghiemCSDLPT.Properties.Resources.cancel_480px;
            this.buttonHuySV.ImageSize = new System.Drawing.Size(30, 30);
            this.buttonHuySV.Location = new System.Drawing.Point(68, 10);
            this.buttonHuySV.Margin = new System.Windows.Forms.Padding(3, 3, 50, 3);
            this.buttonHuySV.Name = "buttonHuySV";
            this.buttonHuySV.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.buttonHuySV.ShadowDecoration.Parent = this.buttonHuySV;
            this.buttonHuySV.Size = new System.Drawing.Size(30, 30);
            this.buttonHuySV.TabIndex = 25;
            this.buttonHuySV.Visible = false;
            this.buttonHuySV.Click += new System.EventHandler(this.buttonHuySV_Click);
            // 
            // buttonXacNhanSV
            // 
            this.buttonXacNhanSV.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonXacNhanSV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.buttonXacNhanSV.CheckedState.Parent = this.buttonXacNhanSV;
            this.buttonXacNhanSV.CustomImages.Parent = this.buttonXacNhanSV;
            this.buttonXacNhanSV.FillColor = System.Drawing.Color.Transparent;
            this.buttonXacNhanSV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonXacNhanSV.ForeColor = System.Drawing.Color.White;
            this.buttonXacNhanSV.HoverState.Parent = this.buttonXacNhanSV;
            this.buttonXacNhanSV.Image = global::TracNghiemCSDLPT.Properties.Resources.ok_480px;
            this.buttonXacNhanSV.ImageSize = new System.Drawing.Size(30, 30);
            this.buttonXacNhanSV.Location = new System.Drawing.Point(15, 10);
            this.buttonXacNhanSV.Margin = new System.Windows.Forms.Padding(15, 0, 20, 3);
            this.buttonXacNhanSV.Name = "buttonXacNhanSV";
            this.buttonXacNhanSV.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.buttonXacNhanSV.ShadowDecoration.Parent = this.buttonXacNhanSV;
            this.buttonXacNhanSV.Size = new System.Drawing.Size(30, 30);
            this.buttonXacNhanSV.TabIndex = 28;
            this.buttonXacNhanSV.Visible = false;
            this.buttonXacNhanSV.Click += new System.EventHandler(this.buttonXacNhanSV_Click);
            // 
            // MaLopEP
            // 
            this.MaLopEP.ContainerControl = this;
            this.MaLopEP.Icon = ((System.Drawing.Icon)(resources.GetObject("MaLopEP.Icon")));
            // 
            // TenLopEP
            // 
            this.TenLopEP.ContainerControl = this;
            this.TenLopEP.Icon = ((System.Drawing.Icon)(resources.GetObject("TenLopEP.Icon")));
            // 
            // MaKhoaEP
            // 
            this.MaKhoaEP.ContainerControl = this;
            this.MaKhoaEP.Icon = ((System.Drawing.Icon)(resources.GetObject("MaKhoaEP.Icon")));
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
            this.ViewCaption.Location = new System.Drawing.Point(407, 8);
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
            this.bunifuPanel1.Controls.Add(this.buttonUndoSV);
            this.bunifuPanel1.Controls.Add(this.buttonRedoSV);
            this.bunifuPanel1.Controls.Add(this.ViewCaption);
            this.bunifuPanel1.Controls.Add(this.buttonXacNhanSV);
            this.bunifuPanel1.Controls.Add(this.buttonHuySV);
            this.bunifuPanel1.Location = new System.Drawing.Point(149, 445);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(1222, 48);
            this.bunifuPanel1.TabIndex = 31;
            // 
            // buttonUndoSV
            // 
            this.buttonUndoSV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUndoSV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.buttonUndoSV.CheckedState.Parent = this.buttonUndoSV;
            this.buttonUndoSV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonUndoSV.CustomImages.Parent = this.buttonUndoSV;
            this.buttonUndoSV.FillColor = System.Drawing.Color.Transparent;
            this.buttonUndoSV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonUndoSV.ForeColor = System.Drawing.Color.White;
            this.buttonUndoSV.HoverState.Parent = this.buttonUndoSV;
            this.buttonUndoSV.Image = global::TracNghiemCSDLPT.Properties.Resources.undo_480px1;
            this.buttonUndoSV.ImageSize = new System.Drawing.Size(30, 30);
            this.buttonUndoSV.Location = new System.Drawing.Point(1106, 10);
            this.buttonUndoSV.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.buttonUndoSV.Name = "buttonUndoSV";
            this.buttonUndoSV.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.buttonUndoSV.ShadowDecoration.Parent = this.buttonUndoSV;
            this.buttonUndoSV.Size = new System.Drawing.Size(32, 32);
            this.buttonUndoSV.TabIndex = 32;
            this.buttonUndoSV.Visible = false;
            // 
            // buttonRedoSV
            // 
            this.buttonRedoSV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRedoSV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.buttonRedoSV.CheckedState.Parent = this.buttonRedoSV;
            this.buttonRedoSV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRedoSV.CustomImages.Parent = this.buttonRedoSV;
            this.buttonRedoSV.FillColor = System.Drawing.Color.Transparent;
            this.buttonRedoSV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonRedoSV.ForeColor = System.Drawing.Color.White;
            this.buttonRedoSV.HoverState.Parent = this.buttonRedoSV;
            this.buttonRedoSV.Image = global::TracNghiemCSDLPT.Properties.Resources.redo_480px;
            this.buttonRedoSV.ImageSize = new System.Drawing.Size(30, 30);
            this.buttonRedoSV.Location = new System.Drawing.Point(1172, 10);
            this.buttonRedoSV.Margin = new System.Windows.Forms.Padding(20, 10, 15, 3);
            this.buttonRedoSV.Name = "buttonRedoSV";
            this.buttonRedoSV.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.buttonRedoSV.ShadowDecoration.Parent = this.buttonRedoSV;
            this.buttonRedoSV.Size = new System.Drawing.Size(32, 32);
            this.buttonRedoSV.TabIndex = 33;
            this.buttonRedoSV.Visible = false;
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
            // FKLopKhoaBds
            // 
            this.FKLopKhoaBds.DataMember = "FK_LOP_KHOA";
            this.FKLopKhoaBds.DataSource = this.KhoaBindingSource;
            // 
            // buttonUndoLop
            // 
            this.buttonUndoLop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUndoLop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.buttonUndoLop.CheckedState.Parent = this.buttonUndoLop;
            this.buttonUndoLop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonUndoLop.CustomImages.Parent = this.buttonUndoLop;
            this.buttonUndoLop.Enabled = false;
            this.buttonUndoLop.FillColor = System.Drawing.Color.Transparent;
            this.buttonUndoLop.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonUndoLop.ForeColor = System.Drawing.Color.White;
            this.buttonUndoLop.HoverState.Parent = this.buttonUndoLop;
            this.buttonUndoLop.Image = global::TracNghiemCSDLPT.Properties.Resources.undo_480px1;
            this.buttonUndoLop.ImageSize = new System.Drawing.Size(30, 30);
            this.buttonUndoLop.Location = new System.Drawing.Point(746, 79);
            this.buttonUndoLop.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.buttonUndoLop.Name = "buttonUndoLop";
            this.buttonUndoLop.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.buttonUndoLop.ShadowDecoration.Parent = this.buttonUndoLop;
            this.buttonUndoLop.Size = new System.Drawing.Size(32, 32);
            this.buttonUndoLop.TabIndex = 32;
            this.buttonUndoLop.Visible = false;
            // 
            // buttonRedoLop
            // 
            this.buttonRedoLop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRedoLop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.buttonRedoLop.CheckedState.Parent = this.buttonRedoLop;
            this.buttonRedoLop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRedoLop.CustomImages.Parent = this.buttonRedoLop;
            this.buttonRedoLop.Enabled = false;
            this.buttonRedoLop.FillColor = System.Drawing.Color.Transparent;
            this.buttonRedoLop.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonRedoLop.ForeColor = System.Drawing.Color.White;
            this.buttonRedoLop.HoverState.Parent = this.buttonRedoLop;
            this.buttonRedoLop.Image = global::TracNghiemCSDLPT.Properties.Resources.redo_480px;
            this.buttonRedoLop.ImageSize = new System.Drawing.Size(30, 30);
            this.buttonRedoLop.Location = new System.Drawing.Point(808, 79);
            this.buttonRedoLop.Margin = new System.Windows.Forms.Padding(20, 5, 15, 3);
            this.buttonRedoLop.Name = "buttonRedoLop";
            this.buttonRedoLop.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.buttonRedoLop.ShadowDecoration.Parent = this.buttonRedoLop;
            this.buttonRedoLop.Size = new System.Drawing.Size(32, 32);
            this.buttonRedoLop.TabIndex = 33;
            this.buttonRedoLop.Visible = false;
            // 
            // InfoPanel
            // 
            this.InfoPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.InfoPanel.BorderColor = System.Drawing.Color.LightGray;
            this.InfoPanel.BorderRadius = 8;
            this.InfoPanel.BorderThickness = 2;
            this.InfoPanel.Controls.Add(this.ComboMaKH);
            this.InfoPanel.Controls.Add(this.buttonThemLop);
            this.InfoPanel.Controls.Add(this.buttonXacNhanLop);
            this.InfoPanel.Controls.Add(this.buttonLamMoiLop);
            this.InfoPanel.Controls.Add(this.TextMaLop);
            this.InfoPanel.Controls.Add(mALOPLabel);
            this.InfoPanel.Controls.Add(this.buttonSuaLop);
            this.InfoPanel.Controls.Add(this.TextTenLop);
            this.InfoPanel.Controls.Add(tENLOPLabel);
            this.InfoPanel.Controls.Add(mAKHLabel);
            this.InfoPanel.Controls.Add(this.buttonHuyLop);
            this.InfoPanel.Controls.Add(this.buttonXoaLop);
            this.InfoPanel.Font = new System.Drawing.Font("Baloo 2", 13.8F, System.Drawing.FontStyle.Bold);
            this.InfoPanel.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.InfoPanel.LabelAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.InfoPanel.LabelIndent = 10;
            this.InfoPanel.LineStyle = Bunifu.UI.WinForms.BunifuGroupBox.LineStyles.Solid;
            this.InfoPanel.Location = new System.Drawing.Point(867, 49);
            this.InfoPanel.Name = "InfoPanel";
            this.InfoPanel.Size = new System.Drawing.Size(499, 369);
            this.InfoPanel.TabIndex = 34;
            this.InfoPanel.TabStop = false;
            this.InfoPanel.Text = "Thông tin lớp";
            // 
            // ComboMaKH
            // 
            this.ComboMaKH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboMaKH.Enabled = false;
            this.ComboMaKH.Location = new System.Drawing.Point(20, 280);
            this.ComboMaKH.Name = "ComboMaKH";
            this.ComboMaKH.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.ComboMaKH.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.ComboMaKH.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ComboMaKH.Properties.Appearance.Font = new System.Drawing.Font("Baloo 2", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboMaKH.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.ComboMaKH.Properties.Appearance.Options.UseBackColor = true;
            this.ComboMaKH.Properties.Appearance.Options.UseBorderColor = true;
            this.ComboMaKH.Properties.Appearance.Options.UseFont = true;
            this.ComboMaKH.Properties.Appearance.Options.UseForeColor = true;
            this.ComboMaKH.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.ComboMaKH.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(126)))));
            this.ComboMaKH.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.ComboMaKH.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.ComboMaKH.Properties.AppearanceDropDown.ForeColor = System.Drawing.Color.Black;
            this.ComboMaKH.Properties.AppearanceDropDown.Options.UseForeColor = true;
            this.ComboMaKH.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ComboMaKH.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black;
            this.ComboMaKH.Properties.AppearanceFocused.Options.UseBorderColor = true;
            this.ComboMaKH.Properties.AppearanceFocused.Options.UseForeColor = true;
            this.ComboMaKH.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black;
            this.ComboMaKH.Properties.AppearanceReadOnly.Options.UseForeColor = true;
            this.ComboMaKH.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ComboMaKH.Properties.DataSource = this.DSKhoaBindingSource;
            this.ComboMaKH.Properties.DisplayMember = "FullInfo";
            this.ComboMaKH.Properties.NullText = "Chọn khoa";
            this.ComboMaKH.Properties.PopupView = this.gridView1;
            this.ComboMaKH.Properties.PopupWidthMode = DevExpress.XtraEditors.PopupWidthMode.UseEditorWidth;
            this.ComboMaKH.Size = new System.Drawing.Size(292, 38);
            this.ComboMaKH.TabIndex = 57;
            // 
            // DSKhoaBindingSource
            // 
            this.DSKhoaBindingSource.DataMember = "DSKhoa";
            this.DSKhoaBindingSource.DataSource = this.TN_CSDLPTDataSet;
            // 
            // gridView1
            // 
            this.gridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(255)))), ((int)(((byte)(215)))));
            this.gridView1.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Baloo 2", 12F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Baloo 2", 12F);
            this.gridView1.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Appearance.Row.Options.UseForeColor = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAKH2,
            this.colTENKH1});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsEditForm.PopupEditFormWidth = 361;
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.ShowIndicator = false;
            // 
            // colMAKH2
            // 
            this.colMAKH2.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(163)))), ((int)(((byte)(236)))));
            this.colMAKH2.AppearanceHeader.Options.UseBackColor = true;
            this.colMAKH2.Caption = "Mã khoa";
            this.colMAKH2.FieldName = "MAKH";
            this.colMAKH2.MinWidth = 17;
            this.colMAKH2.Name = "colMAKH2";
            this.colMAKH2.OptionsColumn.FixedWidth = true;
            this.colMAKH2.Visible = true;
            this.colMAKH2.VisibleIndex = 0;
            this.colMAKH2.Width = 90;
            // 
            // colTENKH1
            // 
            this.colTENKH1.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(163)))), ((int)(((byte)(236)))));
            this.colTENKH1.AppearanceHeader.Options.UseBackColor = true;
            this.colTENKH1.Caption = "Tên khoa";
            this.colTENKH1.FieldName = "TENKH";
            this.colTENKH1.MinWidth = 17;
            this.colTENKH1.Name = "colTENKH1";
            this.colTENKH1.Visible = true;
            this.colTENKH1.VisibleIndex = 1;
            this.colTENKH1.Width = 260;
            // 
            // DSKhoaTableAdapter
            // 
            this.DSKhoaTableAdapter.ClearBeforeFill = true;
            // 
            // FormSvl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1376, 822);
            this.Controls.Add(this.buttonUndoLop);
            this.Controls.Add(this.buttonRedoLop);
            this.Controls.Add(this.CoSoComboBox);
            this.Controls.Add(this.SinhVienGridControl);
            this.Controls.Add(this.bunifuPanel1);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.KhoaGridControl);
            this.Controls.Add(this.InfoPanel);
            this.IconOptions.Image = global::TracNghiemCSDLPT.Properties.Resources.CSDLPT_Logo1;
            this.Name = "FormSvl";
            this.Text = "Sinh viên và lớp";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormSVL_FormClosing);
            this.Load += new System.EventHandler(this.FormSVL_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LopGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KhoaGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KhoaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TN_CSDLPTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KhoaGridView)).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.GV_DKBindingSource)).EndInit();
            this.bunifuPanel1.ResumeLayout(false);
            this.bunifuPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BangDiemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FKLopKhoaBds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.InfoPanel.ResumeLayout(false);
            this.InfoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ComboMaKH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSKhoaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
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
        private Guna.UI2.WinForms.Guna2CircleButton buttonHuyLop;
        private Guna.UI2.WinForms.Guna2CircleButton buttonXacNhanLop;
        private Guna.UI2.WinForms.Guna2CircleButton buttonHuySV;
        private Guna.UI2.WinForms.Guna2CircleButton buttonXacNhanSV;
        private System.Windows.Forms.ErrorProvider MaLopEP;
        private System.Windows.Forms.ErrorProvider TenLopEP;
        private System.Windows.Forms.ErrorProvider MaKhoaEP;
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
        private System.Windows.Forms.BindingSource FKLopKhoaBds;
        private Guna.UI2.WinForms.Guna2CircleButton buttonUndoLop;
        private Guna.UI2.WinForms.Guna2CircleButton buttonRedoLop;
        private Guna.UI2.WinForms.Guna2CircleButton buttonUndoSV;
        private Guna.UI2.WinForms.Guna2CircleButton buttonRedoSV;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private Bunifu.UI.WinForms.BunifuGroupBox InfoPanel;
        private DevExpress.XtraEditors.GridLookUpEdit ComboMaKH;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource DSKhoaBindingSource;
        private TN_CSDLPTDataSetTableAdapters.DSKhoaTableAdapter DSKhoaTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKH2;
        private DevExpress.XtraGrid.Columns.GridColumn colTENKH1;
    }
}