
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
            this.BoDeTableAdapter = new TracNghiemCSDLPT.TN_CSDLPTDataSetTableAdapters.BODETableAdapter();
            this.BoDeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.BoDeGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MonHocGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MonHocBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TN_CSDLPTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MonHocGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoDeBindingSource)).BeginInit();
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
            this.MonHocGridControl.DataSource = this.MonHocBindingSource;
            this.MonHocGridControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MonHocGridControl.Font = new System.Drawing.Font("Teko SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            gridLevelNode1.LevelTemplate = this.BoDeGridView;
            gridLevelNode1.RelationName = "FK_BODE_MONHOC";
            this.MonHocGridControl.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.MonHocGridControl.Location = new System.Drawing.Point(0, 323);
            this.MonHocGridControl.MainView = this.MonHocGridView;
            this.MonHocGridControl.Margin = new System.Windows.Forms.Padding(0);
            this.MonHocGridControl.Name = "MonHocGridControl";
            this.MonHocGridControl.Size = new System.Drawing.Size(1192, 331);
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
            this.tableAdapterManager.BANGDIEMTableAdapter = null;
            this.tableAdapterManager.BODETableAdapter = this.BoDeTableAdapter;
            this.tableAdapterManager.COSOTableAdapter = null;
            this.tableAdapterManager.GIAOVIEN_DANGKYTableAdapter = null;
            this.tableAdapterManager.GIAOVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = this.MonHocTableAdapter;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TracNghiemCSDLPT.TN_CSDLPTDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // BoDeTableAdapter
            // 
            this.BoDeTableAdapter.ClearBeforeFill = true;
            // 
            // BoDeBindingSource
            // 
            this.BoDeBindingSource.DataMember = "FK_BODE_MONHOC";
            this.BoDeBindingSource.DataSource = this.MonHocBindingSource;
            // 
            // FormCauHoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 654);
            this.Controls.Add(this.MonHocGridControl);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("FormCauHoi.IconOptions.Icon")));
            this.Name = "FormCauHoi";
            this.Text = "Câu hỏi";
            this.Load += new System.EventHandler(this.FormCauHoi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BoDeGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MonHocGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MonHocBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TN_CSDLPTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MonHocGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoDeBindingSource)).EndInit();
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
        private TN_CSDLPTDataSetTableAdapters.BODETableAdapter BoDeTableAdapter;
        private System.Windows.Forms.BindingSource BoDeBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colCAUHOI;
        private DevExpress.XtraGrid.Columns.GridColumn colTRINHDO;
        private DevExpress.XtraGrid.Columns.GridColumn colNOIDUNG;
        private DevExpress.XtraGrid.Columns.GridColumn colMAGV;
        private DevExpress.XtraGrid.Columns.GridColumn colMAMH;
        private DevExpress.XtraGrid.Columns.GridColumn colTENMH;
    }
}