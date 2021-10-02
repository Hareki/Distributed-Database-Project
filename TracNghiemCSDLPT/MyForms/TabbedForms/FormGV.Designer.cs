
namespace TracNghiemCSDLPT.MyForms.TabbedForms
{
    partial class FormGV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGV));
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CoSoComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.KhoaTableAdapter = new TracNghiemCSDLPT.TN_CSDLPTDataSetTableAdapters.KHOATableAdapter();
            this.tableAdapterManager = new TracNghiemCSDLPT.TN_CSDLPTDataSetTableAdapters.TableAdapterManager();
            this.GVTableAdapter = new TracNghiemCSDLPT.TN_CSDLPTDataSetTableAdapters.GIAOVIENTableAdapter();
            this.GVGridControl = new DevExpress.XtraGrid.GridControl();
            this.GVBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GVGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAGV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.cardView1 = new DevExpress.XtraGrid.Views.Card.CardView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonLamMoiGV = new Guna.UI2.WinForms.Guna2Button();
            this.buttonThemGV = new Guna.UI2.WinForms.Guna2Button();
            this.buttonSuaGV = new Guna.UI2.WinForms.Guna2Button();
            this.buttonXoaGV = new Guna.UI2.WinForms.Guna2Button();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.ViewCaption = new System.Windows.Forms.Label();
            this.buttonRedoGV = new Guna.UI2.WinForms.Guna2CircleButton();
            this.buttonXacNhanGV = new Guna.UI2.WinForms.Guna2CircleButton();
            this.buttonUndoGV = new Guna.UI2.WinForms.Guna2CircleButton();
            this.buttonHuyGV = new Guna.UI2.WinForms.Guna2CircleButton();
            this.BoDeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BoDeTableAdapter = new TracNghiemCSDLPT.TN_CSDLPTDataSetTableAdapters.BODETableAdapter();
            this.GVDKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GVDKTableAdapter = new TracNghiemCSDLPT.TN_CSDLPTDataSetTableAdapters.GIAOVIEN_DANGKYTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.LopGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KhoaGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KhoaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TN_CSDLPTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KhoaGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GVGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GVBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GVGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.bunifuPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BoDeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GVDKBindingSource)).BeginInit();
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
            this.KhoaGridControl.Location = new System.Drawing.Point(10, 52);
            this.KhoaGridControl.MainView = this.KhoaGridView;
            this.KhoaGridControl.Name = "KhoaGridControl";
            this.KhoaGridControl.Size = new System.Drawing.Size(1008, 351);
            this.KhoaGridControl.TabIndex = 14;
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
            this.KhoaGridView.OptionsDetail.EnableMasterViewMode = false;
            this.KhoaGridView.OptionsPrint.EnableAppearanceOddRow = true;
            this.KhoaGridView.OptionsScrollAnnotations.ShowFocusedRow = DevExpress.Utils.DefaultBoolean.True;
            this.KhoaGridView.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.AnimateAllContent;
            this.KhoaGridView.OptionsView.EnableAppearanceOddRow = true;
            this.KhoaGridView.OptionsView.ShowGroupPanel = false;
            this.KhoaGridView.OptionsView.ShowIndicator = false;
            this.KhoaGridView.OptionsView.ShowViewCaption = true;
            this.KhoaGridView.ViewCaption = "Danh sách lớp theo khoa";
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
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::TracNghiemCSDLPT.Properties.Resources.asd;
            this.pictureBox1.Location = new System.Drawing.Point(1024, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(459, 351);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
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
            this.CoSoComboBox.Location = new System.Drawing.Point(125, 3);
            this.CoSoComboBox.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.CoSoComboBox.Name = "CoSoComboBox";
            this.CoSoComboBox.ShadowDecoration.Parent = this.CoSoComboBox;
            this.CoSoComboBox.Size = new System.Drawing.Size(254, 36);
            this.CoSoComboBox.TabIndex = 22;
            this.CoSoComboBox.TextOffset = new System.Drawing.Point(3, 3);
            this.CoSoComboBox.SelectedIndexChanged += new System.EventHandler(this.CoSoComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Baloo 2", 10.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 30);
            this.label1.TabIndex = 21;
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
            this.bunifuSeparator1.Location = new System.Drawing.Point(17, 410);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.bunifuSeparator1.Size = new System.Drawing.Size(1466, 17);
            this.bunifuSeparator1.TabIndex = 23;
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
            this.tableAdapterManager.GIAOVIENTableAdapter = this.GVTableAdapter;
            this.tableAdapterManager.KHOATableAdapter = this.KhoaTableAdapter;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TracNghiemCSDLPT.TN_CSDLPTDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // GVTableAdapter
            // 
            this.GVTableAdapter.ClearBeforeFill = true;
            // 
            // GVGridControl
            // 
            this.GVGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GVGridControl.DataSource = this.GVBindingSource;
            this.GVGridControl.Font = new System.Drawing.Font("Teko SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GVGridControl.Location = new System.Drawing.Point(160, 482);
            this.GVGridControl.MainView = this.GVGridView;
            this.GVGridControl.Name = "GVGridControl";
            this.GVGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateEdit1});
            this.GVGridControl.Size = new System.Drawing.Size(1323, 335);
            this.GVGridControl.TabIndex = 25;
            this.GVGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GVGridView,
            this.cardView1});
            // 
            // GVBindingSource
            // 
            this.GVBindingSource.DataMember = "FK_GIAOVIEN_KHOA";
            this.GVBindingSource.DataSource = this.KhoaBindingSource;
            // 
            // GVGridView
            // 
            this.GVGridView.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.GVGridView.Appearance.EvenRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(70)))), ((int)(((byte)(68)))));
            this.GVGridView.Appearance.EvenRow.Options.UseBackColor = true;
            this.GVGridView.Appearance.EvenRow.Options.UseForeColor = true;
            this.GVGridView.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(230)))), ((int)(((byte)(203)))));
            this.GVGridView.Appearance.FocusedCell.Options.UseBackColor = true;
            this.GVGridView.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(230)))), ((int)(((byte)(203)))));
            this.GVGridView.Appearance.FocusedRow.Options.UseBackColor = true;
            this.GVGridView.Appearance.GroupRow.Font = new System.Drawing.Font("Baloo 2", 10.2F);
            this.GVGridView.Appearance.GroupRow.Options.UseFont = true;
            this.GVGridView.Appearance.HeaderPanel.Font = new System.Drawing.Font("Baloo 2", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GVGridView.Appearance.HeaderPanel.Options.UseFont = true;
            this.GVGridView.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(230)))), ((int)(((byte)(203)))));
            this.GVGridView.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.GVGridView.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.GVGridView.Appearance.OddRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(70)))), ((int)(((byte)(68)))));
            this.GVGridView.Appearance.OddRow.Options.UseBackColor = true;
            this.GVGridView.Appearance.OddRow.Options.UseForeColor = true;
            this.GVGridView.Appearance.Preview.Font = new System.Drawing.Font("Baloo 2", 10.2F);
            this.GVGridView.Appearance.Preview.Options.UseFont = true;
            this.GVGridView.Appearance.Row.Font = new System.Drawing.Font("Baloo 2", 12F);
            this.GVGridView.Appearance.Row.Options.UseFont = true;
            this.GVGridView.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(230)))), ((int)(((byte)(203)))));
            this.GVGridView.Appearance.SelectedRow.Font = new System.Drawing.Font("Baloo 2", 12F);
            this.GVGridView.Appearance.SelectedRow.Options.UseBackColor = true;
            this.GVGridView.Appearance.SelectedRow.Options.UseFont = true;
            this.GVGridView.Appearance.TopNewRow.Font = new System.Drawing.Font("Baloo 2", 10.2F);
            this.GVGridView.Appearance.TopNewRow.Options.UseFont = true;
            this.GVGridView.Appearance.ViewCaption.Font = new System.Drawing.Font("Baloo 2", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GVGridView.Appearance.ViewCaption.Options.UseFont = true;
            this.GVGridView.AppearancePrint.OddRow.BackColor = System.Drawing.Color.DimGray;
            this.GVGridView.AppearancePrint.OddRow.Options.UseBackColor = true;
            this.GVGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAGV,
            this.colHO,
            this.colTEN,
            this.colDIACHI});
            this.GVGridView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.GVGridView.GridControl = this.GVGridControl;
            this.GVGridView.Name = "GVGridView";
            this.GVGridView.OptionsBehavior.Editable = false;
            this.GVGridView.OptionsCustomization.AllowRowSizing = true;
            this.GVGridView.OptionsDetail.EnableMasterViewMode = false;
            this.GVGridView.OptionsPrint.EnableAppearanceOddRow = true;
            this.GVGridView.OptionsScrollAnnotations.ShowErrors = DevExpress.Utils.DefaultBoolean.True;
            this.GVGridView.OptionsScrollAnnotations.ShowFocusedRow = DevExpress.Utils.DefaultBoolean.True;
            this.GVGridView.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.AnimateAllContent;
            this.GVGridView.OptionsView.EnableAppearanceOddRow = true;
            this.GVGridView.OptionsView.ShowGroupPanel = false;
            this.GVGridView.OptionsView.ShowGroupPanelColumnsAsSingleRow = true;
            this.GVGridView.OptionsView.ShowIndicator = false;
            this.GVGridView.ViewCaption = "Danh sách sinh viên thuộc lớp";
            this.GVGridView.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.GVGridView_CustomDrawCell);
            this.GVGridView.ShownEditor += new System.EventHandler(this.GVGridView_ShownEditor);
            this.GVGridView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.GVGridView_FocusedRowChanged);
            // 
            // colMAGV
            // 
            this.colMAGV.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(164)))), ((int)(((byte)(236)))));
            this.colMAGV.AppearanceHeader.Options.UseBackColor = true;
            this.colMAGV.Caption = "Mã GV";
            this.colMAGV.FieldName = "MAGV";
            this.colMAGV.MinWidth = 25;
            this.colMAGV.Name = "colMAGV";
            this.colMAGV.Visible = true;
            this.colMAGV.VisibleIndex = 0;
            this.colMAGV.Width = 94;
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
            // colDIACHI
            // 
            this.colDIACHI.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(164)))), ((int)(((byte)(236)))));
            this.colDIACHI.AppearanceHeader.Options.UseBackColor = true;
            this.colDIACHI.Caption = "Địa chỉ";
            this.colDIACHI.FieldName = "DIACHI";
            this.colDIACHI.MinWidth = 25;
            this.colDIACHI.Name = "colDIACHI";
            this.colDIACHI.Visible = true;
            this.colDIACHI.VisibleIndex = 3;
            this.colDIACHI.Width = 94;
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
            // cardView1
            // 
            this.cardView1.GridControl = this.GVGridControl;
            this.cardView1.Name = "cardView1";
            this.cardView1.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Auto;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.buttonLamMoiGV);
            this.panel1.Controls.Add(this.buttonThemGV);
            this.panel1.Controls.Add(this.buttonSuaGV);
            this.panel1.Controls.Add(this.buttonXoaGV);
            this.panel1.Location = new System.Drawing.Point(10, 436);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(136, 381);
            this.panel1.TabIndex = 26;
            // 
            // buttonLamMoiGV
            // 
            this.buttonLamMoiGV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonLamMoiGV.Animated = true;
            this.buttonLamMoiGV.CheckedState.Parent = this.buttonLamMoiGV;
            this.buttonLamMoiGV.CustomImages.Parent = this.buttonLamMoiGV;
            this.buttonLamMoiGV.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(216)))), ((int)(((byte)(219)))));
            this.buttonLamMoiGV.Font = new System.Drawing.Font("Baloo 2 ExtraBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLamMoiGV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(70)))), ((int)(((byte)(68)))));
            this.buttonLamMoiGV.HoverState.FillColor = System.Drawing.Color.Gainsboro;
            this.buttonLamMoiGV.HoverState.Parent = this.buttonLamMoiGV;
            this.buttonLamMoiGV.Image = global::TracNghiemCSDLPT.Properties.Resources.reset_480px;
            this.buttonLamMoiGV.ImageSize = new System.Drawing.Size(40, 40);
            this.buttonLamMoiGV.Location = new System.Drawing.Point(8, 280);
            this.buttonLamMoiGV.Margin = new System.Windows.Forms.Padding(3, 3, 3, 27);
            this.buttonLamMoiGV.Name = "buttonLamMoiGV";
            this.buttonLamMoiGV.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(186)))), ((int)(((byte)(185)))));
            this.buttonLamMoiGV.ShadowDecoration.Parent = this.buttonLamMoiGV;
            this.buttonLamMoiGV.Size = new System.Drawing.Size(120, 45);
            this.buttonLamMoiGV.TabIndex = 22;
            this.buttonLamMoiGV.Text = "Làm mới";
            this.buttonLamMoiGV.Click += new System.EventHandler(this.buttonLamMoiGV_Click);
            // 
            // buttonThemGV
            // 
            this.buttonThemGV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonThemGV.Animated = true;
            this.buttonThemGV.CheckedState.Parent = this.buttonThemGV;
            this.buttonThemGV.CustomImages.Parent = this.buttonThemGV;
            this.buttonThemGV.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(216)))), ((int)(((byte)(219)))));
            this.buttonThemGV.Font = new System.Drawing.Font("Baloo 2 ExtraBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThemGV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(70)))), ((int)(((byte)(68)))));
            this.buttonThemGV.HoverState.FillColor = System.Drawing.Color.Gainsboro;
            this.buttonThemGV.HoverState.Parent = this.buttonThemGV;
            this.buttonThemGV.Image = global::TracNghiemCSDLPT.Properties.Resources.add_480px;
            this.buttonThemGV.ImageSize = new System.Drawing.Size(40, 40);
            this.buttonThemGV.Location = new System.Drawing.Point(8, 55);
            this.buttonThemGV.Margin = new System.Windows.Forms.Padding(3, 3, 3, 27);
            this.buttonThemGV.Name = "buttonThemGV";
            this.buttonThemGV.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(186)))), ((int)(((byte)(185)))));
            this.buttonThemGV.ShadowDecoration.Parent = this.buttonThemGV;
            this.buttonThemGV.Size = new System.Drawing.Size(120, 45);
            this.buttonThemGV.TabIndex = 21;
            this.buttonThemGV.Text = "Thêm";
            this.buttonThemGV.Click += new System.EventHandler(this.buttonThemGV_Click);
            // 
            // buttonSuaGV
            // 
            this.buttonSuaGV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSuaGV.Animated = true;
            this.buttonSuaGV.CheckedState.Parent = this.buttonSuaGV;
            this.buttonSuaGV.CustomImages.Parent = this.buttonSuaGV;
            this.buttonSuaGV.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(216)))), ((int)(((byte)(219)))));
            this.buttonSuaGV.Font = new System.Drawing.Font("Baloo 2 ExtraBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSuaGV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(70)))), ((int)(((byte)(68)))));
            this.buttonSuaGV.HoverState.FillColor = System.Drawing.Color.Gainsboro;
            this.buttonSuaGV.HoverState.Parent = this.buttonSuaGV;
            this.buttonSuaGV.Image = global::TracNghiemCSDLPT.Properties.Resources.edit_480px;
            this.buttonSuaGV.ImageSize = new System.Drawing.Size(40, 40);
            this.buttonSuaGV.Location = new System.Drawing.Point(8, 205);
            this.buttonSuaGV.Margin = new System.Windows.Forms.Padding(3, 3, 3, 27);
            this.buttonSuaGV.Name = "buttonSuaGV";
            this.buttonSuaGV.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(186)))), ((int)(((byte)(185)))));
            this.buttonSuaGV.ShadowDecoration.Parent = this.buttonSuaGV;
            this.buttonSuaGV.Size = new System.Drawing.Size(120, 45);
            this.buttonSuaGV.TabIndex = 20;
            this.buttonSuaGV.Text = "Sửa";
            this.buttonSuaGV.Click += new System.EventHandler(this.buttonSuaGV_Click);
            // 
            // buttonXoaGV
            // 
            this.buttonXoaGV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonXoaGV.Animated = true;
            this.buttonXoaGV.CheckedState.Parent = this.buttonXoaGV;
            this.buttonXoaGV.CustomImages.Parent = this.buttonXoaGV;
            this.buttonXoaGV.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(216)))), ((int)(((byte)(219)))));
            this.buttonXoaGV.Font = new System.Drawing.Font("Baloo 2 ExtraBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXoaGV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(70)))), ((int)(((byte)(68)))));
            this.buttonXoaGV.HoverState.FillColor = System.Drawing.Color.Gainsboro;
            this.buttonXoaGV.HoverState.Parent = this.buttonXoaGV;
            this.buttonXoaGV.Image = global::TracNghiemCSDLPT.Properties.Resources.minus_sign_480px;
            this.buttonXoaGV.ImageSize = new System.Drawing.Size(40, 40);
            this.buttonXoaGV.Location = new System.Drawing.Point(8, 130);
            this.buttonXoaGV.Margin = new System.Windows.Forms.Padding(3, 3, 3, 27);
            this.buttonXoaGV.Name = "buttonXoaGV";
            this.buttonXoaGV.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(186)))), ((int)(((byte)(185)))));
            this.buttonXoaGV.ShadowDecoration.Parent = this.buttonXoaGV;
            this.buttonXoaGV.Size = new System.Drawing.Size(120, 45);
            this.buttonXoaGV.TabIndex = 23;
            this.buttonXoaGV.Text = "Xóa";
            this.buttonXoaGV.Click += new System.EventHandler(this.buttonXoaGV_Click);
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
            this.bunifuPanel1.Controls.Add(this.buttonRedoGV);
            this.bunifuPanel1.Controls.Add(this.buttonXacNhanGV);
            this.bunifuPanel1.Controls.Add(this.buttonUndoGV);
            this.bunifuPanel1.Controls.Add(this.buttonHuyGV);
            this.bunifuPanel1.Location = new System.Drawing.Point(160, 436);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(1323, 51);
            this.bunifuPanel1.TabIndex = 32;
            // 
            // ViewCaption
            // 
            this.ViewCaption.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ViewCaption.AutoSize = true;
            this.ViewCaption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ViewCaption.Font = new System.Drawing.Font("Baloo 2", 13.8F, System.Drawing.FontStyle.Bold);
            this.ViewCaption.ForeColor = System.Drawing.Color.Black;
            this.ViewCaption.Location = new System.Drawing.Point(444, 4);
            this.ViewCaption.Name = "ViewCaption";
            this.ViewCaption.Size = new System.Drawing.Size(435, 39);
            this.ViewCaption.TabIndex = 29;
            this.ViewCaption.Text = "Danh sách giảng viên thuộc khoa CNTT";
            // 
            // buttonRedoGV
            // 
            this.buttonRedoGV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonRedoGV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.buttonRedoGV.CheckedState.Parent = this.buttonRedoGV;
            this.buttonRedoGV.CustomImages.Parent = this.buttonRedoGV;
            this.buttonRedoGV.FillColor = System.Drawing.Color.Transparent;
            this.buttonRedoGV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonRedoGV.ForeColor = System.Drawing.Color.White;
            this.buttonRedoGV.HoverState.Parent = this.buttonRedoGV;
            this.buttonRedoGV.Image = global::TracNghiemCSDLPT.Properties.Resources.redo_480px;
            this.buttonRedoGV.ImageSize = new System.Drawing.Size(30, 30);
            this.buttonRedoGV.Location = new System.Drawing.Point(971, 9);
            this.buttonRedoGV.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.buttonRedoGV.Name = "buttonRedoGV";
            this.buttonRedoGV.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.buttonRedoGV.ShadowDecoration.Parent = this.buttonRedoGV;
            this.buttonRedoGV.Size = new System.Drawing.Size(32, 32);
            this.buttonRedoGV.TabIndex = 26;
            this.buttonRedoGV.Visible = false;
            // 
            // buttonXacNhanGV
            // 
            this.buttonXacNhanGV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonXacNhanGV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.buttonXacNhanGV.CheckedState.Parent = this.buttonXacNhanGV;
            this.buttonXacNhanGV.CustomImages.Parent = this.buttonXacNhanGV;
            this.buttonXacNhanGV.FillColor = System.Drawing.Color.Transparent;
            this.buttonXacNhanGV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonXacNhanGV.ForeColor = System.Drawing.Color.White;
            this.buttonXacNhanGV.HoverState.Parent = this.buttonXacNhanGV;
            this.buttonXacNhanGV.Image = global::TracNghiemCSDLPT.Properties.Resources.ok_480px;
            this.buttonXacNhanGV.ImageSize = new System.Drawing.Size(30, 30);
            this.buttonXacNhanGV.Location = new System.Drawing.Point(319, 9);
            this.buttonXacNhanGV.Margin = new System.Windows.Forms.Padding(3, 0, 20, 3);
            this.buttonXacNhanGV.Name = "buttonXacNhanGV";
            this.buttonXacNhanGV.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.buttonXacNhanGV.ShadowDecoration.Parent = this.buttonXacNhanGV;
            this.buttonXacNhanGV.Size = new System.Drawing.Size(30, 30);
            this.buttonXacNhanGV.TabIndex = 28;
            this.buttonXacNhanGV.Visible = false;
            this.buttonXacNhanGV.Click += new System.EventHandler(this.buttonXacNhanGV_Click);
            // 
            // buttonUndoGV
            // 
            this.buttonUndoGV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonUndoGV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.buttonUndoGV.CheckedState.Parent = this.buttonUndoGV;
            this.buttonUndoGV.CustomImages.Parent = this.buttonUndoGV;
            this.buttonUndoGV.FillColor = System.Drawing.Color.Transparent;
            this.buttonUndoGV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonUndoGV.ForeColor = System.Drawing.Color.White;
            this.buttonUndoGV.HoverState.Parent = this.buttonUndoGV;
            this.buttonUndoGV.Image = global::TracNghiemCSDLPT.Properties.Resources.undo_480px1;
            this.buttonUndoGV.ImageSize = new System.Drawing.Size(30, 30);
            this.buttonUndoGV.Location = new System.Drawing.Point(916, 9);
            this.buttonUndoGV.Margin = new System.Windows.Forms.Padding(50, 3, 20, 3);
            this.buttonUndoGV.Name = "buttonUndoGV";
            this.buttonUndoGV.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.buttonUndoGV.ShadowDecoration.Parent = this.buttonUndoGV;
            this.buttonUndoGV.Size = new System.Drawing.Size(32, 32);
            this.buttonUndoGV.TabIndex = 27;
            this.buttonUndoGV.Visible = false;
            // 
            // buttonHuyGV
            // 
            this.buttonHuyGV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonHuyGV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.buttonHuyGV.CheckedState.Parent = this.buttonHuyGV;
            this.buttonHuyGV.CustomImages.Parent = this.buttonHuyGV;
            this.buttonHuyGV.FillColor = System.Drawing.Color.Transparent;
            this.buttonHuyGV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonHuyGV.ForeColor = System.Drawing.Color.White;
            this.buttonHuyGV.HoverState.Parent = this.buttonHuyGV;
            this.buttonHuyGV.Image = global::TracNghiemCSDLPT.Properties.Resources.cancel_480px;
            this.buttonHuyGV.ImageSize = new System.Drawing.Size(30, 30);
            this.buttonHuyGV.Location = new System.Drawing.Point(374, 9);
            this.buttonHuyGV.Margin = new System.Windows.Forms.Padding(3, 3, 50, 3);
            this.buttonHuyGV.Name = "buttonHuyGV";
            this.buttonHuyGV.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.buttonHuyGV.ShadowDecoration.Parent = this.buttonHuyGV;
            this.buttonHuyGV.Size = new System.Drawing.Size(30, 30);
            this.buttonHuyGV.TabIndex = 25;
            this.buttonHuyGV.Visible = false;
            this.buttonHuyGV.Click += new System.EventHandler(this.buttonHuyGV_Click);
            // 
            // BoDeBindingSource
            // 
            this.BoDeBindingSource.DataMember = "FK_BODE_GIAOVIEN";
            this.BoDeBindingSource.DataSource = this.GVBindingSource;
            // 
            // BoDeTableAdapter
            // 
            this.BoDeTableAdapter.ClearBeforeFill = true;
            // 
            // GVDKBindingSource
            // 
            this.GVDKBindingSource.DataMember = "FK_GIAOVIEN_DANGKY_GIAOVIEN1";
            this.GVDKBindingSource.DataSource = this.GVBindingSource;
            // 
            // GVDKTableAdapter
            // 
            this.GVDKTableAdapter.ClearBeforeFill = true;
            // 
            // FormGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1495, 829);
            this.Controls.Add(this.GVGridControl);
            this.Controls.Add(this.bunifuPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.CoSoComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.KhoaGridControl);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("FormGV.IconOptions.Icon")));
            this.Name = "FormGV";
            this.Text = "Giáo viên";
            this.Load += new System.EventHandler(this.FormGV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LopGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KhoaGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KhoaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TN_CSDLPTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KhoaGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GVGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GVBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GVGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.bunifuPanel1.ResumeLayout(false);
            this.bunifuPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BoDeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GVDKBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl KhoaGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView LopGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colMALOP1;
        private DevExpress.XtraGrid.Columns.GridColumn colTENLOP;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKH1;
        private DevExpress.XtraGrid.Views.Grid.GridView KhoaGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKH;
        private DevExpress.XtraGrid.Columns.GridColumn colTENKH;
        private DevExpress.XtraGrid.Columns.GridColumn colMACS;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2ComboBox CoSoComboBox;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator1;
        private TN_CSDLPTDataSet TN_CSDLPTDataSet;
        private System.Windows.Forms.BindingSource KhoaBindingSource;
        private TN_CSDLPTDataSetTableAdapters.KHOATableAdapter KhoaTableAdapter;
        private TN_CSDLPTDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl GVGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView GVGridView;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.XtraGrid.Views.Card.CardView cardView1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button buttonLamMoiGV;
        private Guna.UI2.WinForms.Guna2Button buttonThemGV;
        private Guna.UI2.WinForms.Guna2Button buttonSuaGV;
        private Guna.UI2.WinForms.Guna2Button buttonXoaGV;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private System.Windows.Forms.Label ViewCaption;
        private Guna.UI2.WinForms.Guna2CircleButton buttonRedoGV;
        private Guna.UI2.WinForms.Guna2CircleButton buttonXacNhanGV;
        private Guna.UI2.WinForms.Guna2CircleButton buttonUndoGV;
        private Guna.UI2.WinForms.Guna2CircleButton buttonHuyGV;
        private TN_CSDLPTDataSetTableAdapters.GIAOVIENTableAdapter GVTableAdapter;
        private System.Windows.Forms.BindingSource GVBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colMAGV;
        private DevExpress.XtraGrid.Columns.GridColumn colHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
        private System.Windows.Forms.BindingSource BoDeBindingSource;
        private TN_CSDLPTDataSetTableAdapters.BODETableAdapter BoDeTableAdapter;
        private System.Windows.Forms.BindingSource GVDKBindingSource;
        private TN_CSDLPTDataSetTableAdapters.GIAOVIEN_DANGKYTableAdapter GVDKTableAdapter;
    }
}