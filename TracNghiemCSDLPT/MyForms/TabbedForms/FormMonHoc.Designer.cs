
namespace TracNghiemCSDLPT.Views
{
    partial class MonHoc
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
            System.Windows.Forms.Label LabelMaMH;
            System.Windows.Forms.Label LabelTenMH;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MonHoc));
            this.MonHocGridControl = new DevExpress.XtraGrid.GridControl();
            this.MonHocBindingSouce = new System.Windows.Forms.BindingSource(this.components);
            this.TN_CSDLPTDataSet = new TracNghiemCSDLPT.TN_CSDLPTDataSet();
            this.MonHocGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cardView1 = new DevExpress.XtraGrid.Views.Card.CardView();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar4 = new DevExpress.XtraBars.Bar();
            this.bar5 = new DevExpress.XtraBars.Bar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.InfoPanel = new Bunifu.UI.WinForms.BunifuGroupBox();
            this.TextTenMH = new DevExpress.XtraEditors.TextEdit();
            this.TextMaMH = new DevExpress.XtraEditors.TextEdit();
            this.buttonHuy = new Guna.UI2.WinForms.Guna2CircleButton();
            this.buttonRedo = new Guna.UI2.WinForms.Guna2CircleButton();
            this.buttonUndo = new Guna.UI2.WinForms.Guna2CircleButton();
            this.buttonXacNhan = new Guna.UI2.WinForms.Guna2CircleButton();
            this.MonHocTableAdapter = new TracNghiemCSDLPT.TN_CSDLPTDataSetTableAdapters.MONHOCTableAdapter();
            this.tableAdapterManager = new TracNghiemCSDLPT.TN_CSDLPTDataSetTableAdapters.TableAdapterManager();
            this.BoDeBindingSouce = new System.Windows.Forms.BindingSource(this.components);
            this.BoDeTableAdapter = new TracNghiemCSDLPT.TN_CSDLPTDataSetTableAdapters.BODETableAdapter();
            this.BangDiemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BangDiemTableAdapter = new TracNghiemCSDLPT.TN_CSDLPTDataSetTableAdapters.BANGDIEMTableAdapter();
            this.GV_DKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GV_DKTableAdapter = new TracNghiemCSDLPT.TN_CSDLPTDataSetTableAdapters.GIAOVIEN_DANGKYTableAdapter();
            this.buttonXoa = new Guna.UI2.WinForms.Guna2Button();
            this.buttonLamMoi = new Guna.UI2.WinForms.Guna2Button();
            this.buttonThem = new Guna.UI2.WinForms.Guna2Button();
            this.buttonSua = new Guna.UI2.WinForms.Guna2Button();
            this.MaMHEP = new System.Windows.Forms.ErrorProvider(this.components);
            this.TenMHEP = new System.Windows.Forms.ErrorProvider(this.components);
            LabelMaMH = new System.Windows.Forms.Label();
            LabelTenMH = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MonHocGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MonHocBindingSouce)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TN_CSDLPTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MonHocGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.bunifuPanel1.SuspendLayout();
            this.InfoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextTenMH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextMaMH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoDeBindingSouce)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BangDiemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GV_DKBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaMHEP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TenMHEP)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelMaMH
            // 
            LabelMaMH.AutoSize = true;
            LabelMaMH.Font = new System.Drawing.Font("Baloo 2", 10.8F, System.Drawing.FontStyle.Bold);
            LabelMaMH.Location = new System.Drawing.Point(234, 84);
            LabelMaMH.Name = "LabelMaMH";
            LabelMaMH.Size = new System.Drawing.Size(115, 30);
            LabelMaMH.TabIndex = 4;
            LabelMaMH.Text = "Mã môn học";
            // 
            // LabelTenMH
            // 
            LabelTenMH.AutoSize = true;
            LabelTenMH.Font = new System.Drawing.Font("Baloo 2", 10.8F, System.Drawing.FontStyle.Bold);
            LabelTenMH.Location = new System.Drawing.Point(234, 144);
            LabelTenMH.Name = "LabelTenMH";
            LabelTenMH.Size = new System.Drawing.Size(120, 30);
            LabelTenMH.TabIndex = 5;
            LabelTenMH.Text = "Tên môn học";
            // 
            // MonHocGridControl
            // 
            this.MonHocGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MonHocGridControl.DataSource = this.MonHocBindingSouce;
            this.MonHocGridControl.Font = new System.Drawing.Font("Teko SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MonHocGridControl.Location = new System.Drawing.Point(0, 343);
            this.MonHocGridControl.MainView = this.MonHocGridView;
            this.MonHocGridControl.Name = "MonHocGridControl";
            this.MonHocGridControl.Size = new System.Drawing.Size(1192, 312);
            this.MonHocGridControl.TabIndex = 12;
            this.MonHocGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.MonHocGridView,
            this.cardView1});
            // 
            // MonHocBindingSouce
            // 
            this.MonHocBindingSouce.DataMember = "MONHOC";
            this.MonHocBindingSouce.DataSource = this.TN_CSDLPTDataSet;
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
            this.MonHocGridView.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(244)))), ((int)(((byte)(252)))));
            this.MonHocGridView.Appearance.FocusedCell.Options.UseBackColor = true;
            this.MonHocGridView.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(244)))), ((int)(((byte)(252)))));
            this.MonHocGridView.Appearance.FocusedRow.Options.UseBackColor = true;
            this.MonHocGridView.Appearance.GroupRow.Font = new System.Drawing.Font("Baloo 2", 10.2F);
            this.MonHocGridView.Appearance.GroupRow.Options.UseFont = true;
            this.MonHocGridView.Appearance.HeaderPanel.Font = new System.Drawing.Font("Baloo 2", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MonHocGridView.Appearance.HeaderPanel.Options.UseFont = true;
            this.MonHocGridView.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(244)))), ((int)(((byte)(252)))));
            this.MonHocGridView.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.MonHocGridView.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.MonHocGridView.Appearance.OddRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(70)))), ((int)(((byte)(68)))));
            this.MonHocGridView.Appearance.OddRow.Options.UseBackColor = true;
            this.MonHocGridView.Appearance.OddRow.Options.UseForeColor = true;
            this.MonHocGridView.Appearance.Preview.Font = new System.Drawing.Font("Baloo 2", 10.2F);
            this.MonHocGridView.Appearance.Preview.Options.UseFont = true;
            this.MonHocGridView.Appearance.Row.Font = new System.Drawing.Font("Baloo 2", 12F);
            this.MonHocGridView.Appearance.Row.Options.UseFont = true;
            this.MonHocGridView.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(244)))), ((int)(((byte)(252)))));
            this.MonHocGridView.Appearance.SelectedRow.Font = new System.Drawing.Font("Baloo 2", 12F);
            this.MonHocGridView.Appearance.SelectedRow.Options.UseBackColor = true;
            this.MonHocGridView.Appearance.SelectedRow.Options.UseFont = true;
            this.MonHocGridView.Appearance.TopNewRow.Font = new System.Drawing.Font("Baloo 2", 10.2F);
            this.MonHocGridView.Appearance.TopNewRow.Options.UseFont = true;
            this.MonHocGridView.AppearancePrint.OddRow.BackColor = System.Drawing.Color.DimGray;
            this.MonHocGridView.AppearancePrint.OddRow.Options.UseBackColor = true;
            this.MonHocGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAMH,
            this.colTENMH});
            this.MonHocGridView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.MonHocGridView.GridControl = this.MonHocGridControl;
            this.MonHocGridView.Name = "MonHocGridView";
            this.MonHocGridView.OptionsBehavior.Editable = false;
            this.MonHocGridView.OptionsBehavior.ReadOnly = true;
            this.MonHocGridView.OptionsCustomization.AllowRowSizing = true;
            this.MonHocGridView.OptionsDetail.EnableMasterViewMode = false;
            this.MonHocGridView.OptionsPrint.EnableAppearanceOddRow = true;
            this.MonHocGridView.OptionsScrollAnnotations.ShowFocusedRow = DevExpress.Utils.DefaultBoolean.True;
            this.MonHocGridView.OptionsView.EnableAppearanceOddRow = true;
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
            // cardView1
            // 
            this.cardView1.GridControl = this.MonHocGridControl;
            this.cardView1.Name = "cardView1";
            this.cardView1.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Auto;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.Text = "Tools";
            // 
            // bar4
            // 
            this.bar4.BarName = "Custom 4";
            this.bar4.DockCol = 0;
            this.bar4.DockRow = 1;
            this.bar4.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar4.Text = "Custom 4";
            // 
            // bar5
            // 
            this.bar5.BarName = "Custom 4";
            this.bar5.DockCol = 0;
            this.bar5.DockRow = 1;
            this.bar5.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar5.Text = "Custom 4";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TracNghiemCSDLPT.Properties.Resources.book_500px;
            this.pictureBox1.Location = new System.Drawing.Point(62, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 156);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BorderRadius = 3;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.InfoPanel);
            this.bunifuPanel1.Controls.Add(this.buttonHuy);
            this.bunifuPanel1.Controls.Add(this.buttonRedo);
            this.bunifuPanel1.Controls.Add(this.buttonUndo);
            this.bunifuPanel1.Controls.Add(this.buttonXacNhan);
            this.bunifuPanel1.Location = new System.Drawing.Point(0, 12);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(1192, 266);
            this.bunifuPanel1.TabIndex = 10;
            // 
            // InfoPanel
            // 
            this.InfoPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.InfoPanel.BorderColor = System.Drawing.Color.LightGray;
            this.InfoPanel.BorderRadius = 1;
            this.InfoPanel.BorderThickness = 1;
            this.InfoPanel.Controls.Add(LabelTenMH);
            this.InfoPanel.Controls.Add(this.TextTenMH);
            this.InfoPanel.Controls.Add(LabelMaMH);
            this.InfoPanel.Controls.Add(this.TextMaMH);
            this.InfoPanel.Controls.Add(this.pictureBox1);
            this.InfoPanel.Enabled = false;
            this.InfoPanel.Font = new System.Drawing.Font("Baloo 2", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoPanel.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.InfoPanel.LabelAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.InfoPanel.LabelIndent = 10;
            this.InfoPanel.LineStyle = Bunifu.UI.WinForms.BunifuGroupBox.LineStyles.Solid;
            this.InfoPanel.Location = new System.Drawing.Point(272, 7);
            this.InfoPanel.Name = "InfoPanel";
            this.InfoPanel.Size = new System.Drawing.Size(648, 253);
            this.InfoPanel.TabIndex = 12;
            this.InfoPanel.TabStop = false;
            this.InfoPanel.Text = "Thông tin môn học";
            // 
            // TextTenMH
            // 
            this.TextTenMH.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.MonHocBindingSouce, "TENMH", true));
            this.TextTenMH.Location = new System.Drawing.Point(365, 141);
            this.TextTenMH.Name = "TextTenMH";
            this.TextTenMH.Properties.Appearance.BorderColor = System.Drawing.Color.Silver;
            this.TextTenMH.Properties.Appearance.Font = new System.Drawing.Font("Baloo 2", 10.8F, System.Drawing.FontStyle.Bold);
            this.TextTenMH.Properties.Appearance.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.TextTenMH.Properties.Appearance.Options.UseBorderColor = true;
            this.TextTenMH.Properties.Appearance.Options.UseFont = true;
            this.TextTenMH.Properties.Appearance.Options.UseForeColor = true;
            this.TextTenMH.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.TextTenMH.Size = new System.Drawing.Size(252, 34);
            this.TextTenMH.TabIndex = 6;
            // 
            // TextMaMH
            // 
            this.TextMaMH.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.MonHocBindingSouce, "MAMH", true));
            this.TextMaMH.Location = new System.Drawing.Point(365, 78);
            this.TextMaMH.Name = "TextMaMH";
            this.TextMaMH.Properties.Appearance.BorderColor = System.Drawing.Color.Silver;
            this.TextMaMH.Properties.Appearance.Font = new System.Drawing.Font("Baloo 2", 10.8F, System.Drawing.FontStyle.Bold);
            this.TextMaMH.Properties.Appearance.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.TextMaMH.Properties.Appearance.Options.UseBorderColor = true;
            this.TextMaMH.Properties.Appearance.Options.UseFont = true;
            this.TextMaMH.Properties.Appearance.Options.UseForeColor = true;
            this.TextMaMH.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.TextMaMH.Size = new System.Drawing.Size(252, 34);
            this.TextMaMH.TabIndex = 5;
            // 
            // buttonHuy
            // 
            this.buttonHuy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonHuy.CheckedState.Parent = this.buttonHuy;
            this.buttonHuy.CustomImages.Parent = this.buttonHuy;
            this.buttonHuy.FillColor = System.Drawing.Color.Transparent;
            this.buttonHuy.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonHuy.ForeColor = System.Drawing.Color.White;
            this.buttonHuy.HoverState.Parent = this.buttonHuy;
            this.buttonHuy.Image = global::TracNghiemCSDLPT.Properties.Resources.cancel_480px;
            this.buttonHuy.ImageSize = new System.Drawing.Size(31, 31);
            this.buttonHuy.Location = new System.Drawing.Point(933, 137);
            this.buttonHuy.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.buttonHuy.Name = "buttonHuy";
            this.buttonHuy.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.buttonHuy.ShadowDecoration.Parent = this.buttonHuy;
            this.buttonHuy.Size = new System.Drawing.Size(30, 30);
            this.buttonHuy.TabIndex = 2;
            this.buttonHuy.Visible = false;
            this.buttonHuy.Click += new System.EventHandler(this.buttonHuy_Click);
            // 
            // buttonRedo
            // 
            this.buttonRedo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonRedo.CheckedState.Parent = this.buttonRedo;
            this.buttonRedo.CustomImages.Parent = this.buttonRedo;
            this.buttonRedo.FillColor = System.Drawing.Color.Transparent;
            this.buttonRedo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonRedo.ForeColor = System.Drawing.Color.White;
            this.buttonRedo.HoverState.Parent = this.buttonRedo;
            this.buttonRedo.Image = global::TracNghiemCSDLPT.Properties.Resources.redo_480px;
            this.buttonRedo.ImageSize = new System.Drawing.Size(28, 28);
            this.buttonRedo.Location = new System.Drawing.Point(229, 138);
            this.buttonRedo.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.buttonRedo.Name = "buttonRedo";
            this.buttonRedo.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.buttonRedo.ShadowDecoration.Parent = this.buttonRedo;
            this.buttonRedo.Size = new System.Drawing.Size(30, 30);
            this.buttonRedo.TabIndex = 2;
            this.buttonRedo.Visible = false;
            // 
            // buttonUndo
            // 
            this.buttonUndo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonUndo.CheckedState.Parent = this.buttonUndo;
            this.buttonUndo.CustomImages.Parent = this.buttonUndo;
            this.buttonUndo.FillColor = System.Drawing.Color.Transparent;
            this.buttonUndo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonUndo.ForeColor = System.Drawing.Color.White;
            this.buttonUndo.HoverState.Parent = this.buttonUndo;
            this.buttonUndo.Image = global::TracNghiemCSDLPT.Properties.Resources.undo_480px1;
            this.buttonUndo.ImageSize = new System.Drawing.Size(28, 28);
            this.buttonUndo.Location = new System.Drawing.Point(229, 30);
            this.buttonUndo.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.buttonUndo.Name = "buttonUndo";
            this.buttonUndo.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.buttonUndo.ShadowDecoration.Parent = this.buttonUndo;
            this.buttonUndo.Size = new System.Drawing.Size(30, 30);
            this.buttonUndo.TabIndex = 2;
            this.buttonUndo.Visible = false;
            // 
            // buttonXacNhan
            // 
            this.buttonXacNhan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonXacNhan.CheckedState.Parent = this.buttonXacNhan;
            this.buttonXacNhan.CustomImages.Parent = this.buttonXacNhan;
            this.buttonXacNhan.FillColor = System.Drawing.Color.Transparent;
            this.buttonXacNhan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonXacNhan.ForeColor = System.Drawing.Color.White;
            this.buttonXacNhan.HoverState.Parent = this.buttonXacNhan;
            this.buttonXacNhan.Image = global::TracNghiemCSDLPT.Properties.Resources.ok_480px;
            this.buttonXacNhan.ImageSize = new System.Drawing.Size(31, 31);
            this.buttonXacNhan.Location = new System.Drawing.Point(933, 30);
            this.buttonXacNhan.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.buttonXacNhan.Name = "buttonXacNhan";
            this.buttonXacNhan.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.buttonXacNhan.ShadowDecoration.Parent = this.buttonXacNhan;
            this.buttonXacNhan.Size = new System.Drawing.Size(30, 30);
            this.buttonXacNhan.TabIndex = 2;
            this.buttonXacNhan.Visible = false;
            this.buttonXacNhan.Click += new System.EventHandler(this.buttonXacNhan_Click);
            // 
            // MonHocTableAdapter
            // 
            this.MonHocTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BANGDIEMTableAdapter = null;
            this.tableAdapterManager.BODETableAdapter = null;
            this.tableAdapterManager.GIAOVIEN_DANGKYTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = this.MonHocTableAdapter;
            this.tableAdapterManager.UpdateOrder = TracNghiemCSDLPT.TN_CSDLPTDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // BoDeBindingSouce
            // 
            this.BoDeBindingSouce.DataMember = "FK_BODE_MONHOC";
            this.BoDeBindingSouce.DataSource = this.MonHocBindingSouce;
            // 
            // BoDeTableAdapter
            // 
            this.BoDeTableAdapter.ClearBeforeFill = true;
            // 
            // BangDiemBindingSource
            // 
            this.BangDiemBindingSource.DataMember = "FK_BANGDIEM_MONHOC";
            this.BangDiemBindingSource.DataSource = this.MonHocBindingSouce;
            // 
            // BangDiemTableAdapter
            // 
            this.BangDiemTableAdapter.ClearBeforeFill = true;
            // 
            // GV_DKBindingSource
            // 
            this.GV_DKBindingSource.DataMember = "FK_GIAOVIEN_DANGKY_MONHOC1";
            this.GV_DKBindingSource.DataSource = this.MonHocBindingSouce;
            // 
            // GV_DKTableAdapter
            // 
            this.GV_DKTableAdapter.ClearBeforeFill = true;
            // 
            // buttonXoa
            // 
            this.buttonXoa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonXoa.Animated = true;
            this.buttonXoa.CheckedState.Parent = this.buttonXoa;
            this.buttonXoa.CustomImages.Parent = this.buttonXoa;
            this.buttonXoa.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.buttonXoa.Font = new System.Drawing.Font("Baloo 2 ExtraBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(70)))), ((int)(((byte)(68)))));
            this.buttonXoa.HoverState.FillColor = System.Drawing.Color.Gainsboro;
            this.buttonXoa.HoverState.Parent = this.buttonXoa;
            this.buttonXoa.Image = global::TracNghiemCSDLPT.Properties.Resources.minus_sign_480px;
            this.buttonXoa.ImageSize = new System.Drawing.Size(40, 40);
            this.buttonXoa.Location = new System.Drawing.Point(412, 289);
            this.buttonXoa.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(186)))), ((int)(((byte)(185)))));
            this.buttonXoa.ShadowDecoration.Parent = this.buttonXoa;
            this.buttonXoa.Size = new System.Drawing.Size(147, 45);
            this.buttonXoa.TabIndex = 11;
            this.buttonXoa.Text = "Xóa";
            this.buttonXoa.Click += new System.EventHandler(this.buttonXoa_Click);
            // 
            // buttonLamMoi
            // 
            this.buttonLamMoi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonLamMoi.Animated = true;
            this.buttonLamMoi.CheckedState.Parent = this.buttonLamMoi;
            this.buttonLamMoi.CustomImages.Parent = this.buttonLamMoi;
            this.buttonLamMoi.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.buttonLamMoi.Font = new System.Drawing.Font("Baloo 2 ExtraBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLamMoi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(70)))), ((int)(((byte)(68)))));
            this.buttonLamMoi.HoverState.FillColor = System.Drawing.Color.Gainsboro;
            this.buttonLamMoi.HoverState.Parent = this.buttonLamMoi;
            this.buttonLamMoi.Image = global::TracNghiemCSDLPT.Properties.Resources.reset_480px;
            this.buttonLamMoi.ImageSize = new System.Drawing.Size(40, 40);
            this.buttonLamMoi.Location = new System.Drawing.Point(854, 288);
            this.buttonLamMoi.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.buttonLamMoi.Name = "buttonLamMoi";
            this.buttonLamMoi.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(186)))), ((int)(((byte)(185)))));
            this.buttonLamMoi.ShadowDecoration.Parent = this.buttonLamMoi;
            this.buttonLamMoi.Size = new System.Drawing.Size(147, 45);
            this.buttonLamMoi.TabIndex = 11;
            this.buttonLamMoi.Text = "Làm mới";
            this.buttonLamMoi.Click += new System.EventHandler(this.buttonLamMoi_Click);
            // 
            // buttonThem
            // 
            this.buttonThem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonThem.Animated = true;
            this.buttonThem.CheckedState.Parent = this.buttonThem;
            this.buttonThem.CustomImages.Parent = this.buttonThem;
            this.buttonThem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.buttonThem.Font = new System.Drawing.Font("Baloo 2 ExtraBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(70)))), ((int)(((byte)(68)))));
            this.buttonThem.HoverState.FillColor = System.Drawing.Color.Gainsboro;
            this.buttonThem.HoverState.Parent = this.buttonThem;
            this.buttonThem.Image = global::TracNghiemCSDLPT.Properties.Resources.add_480px;
            this.buttonThem.ImageSize = new System.Drawing.Size(40, 40);
            this.buttonThem.Location = new System.Drawing.Point(191, 288);
            this.buttonThem.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(186)))), ((int)(((byte)(185)))));
            this.buttonThem.ShadowDecoration.Parent = this.buttonThem;
            this.buttonThem.Size = new System.Drawing.Size(147, 45);
            this.buttonThem.TabIndex = 11;
            this.buttonThem.Text = "Thêm";
            this.buttonThem.Click += new System.EventHandler(this.buttonThem_Click);
            // 
            // buttonSua
            // 
            this.buttonSua.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonSua.Animated = true;
            this.buttonSua.CheckedState.Parent = this.buttonSua;
            this.buttonSua.CustomImages.Parent = this.buttonSua;
            this.buttonSua.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.buttonSua.Font = new System.Drawing.Font("Baloo 2 ExtraBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(70)))), ((int)(((byte)(68)))));
            this.buttonSua.HoverState.FillColor = System.Drawing.Color.Gainsboro;
            this.buttonSua.HoverState.Parent = this.buttonSua;
            this.buttonSua.Image = global::TracNghiemCSDLPT.Properties.Resources.edit_480px;
            this.buttonSua.ImageSize = new System.Drawing.Size(40, 40);
            this.buttonSua.Location = new System.Drawing.Point(633, 288);
            this.buttonSua.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.buttonSua.Name = "buttonSua";
            this.buttonSua.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(186)))), ((int)(((byte)(185)))));
            this.buttonSua.ShadowDecoration.Parent = this.buttonSua;
            this.buttonSua.Size = new System.Drawing.Size(147, 45);
            this.buttonSua.TabIndex = 11;
            this.buttonSua.Text = "Sửa";
            this.buttonSua.Click += new System.EventHandler(this.buttonSua_Click);
            // 
            // MaMHEP
            // 
            this.MaMHEP.ContainerControl = this;
            this.MaMHEP.Icon = ((System.Drawing.Icon)(resources.GetObject("MaMHEP.Icon")));
            // 
            // TenMHEP
            // 
            this.TenMHEP.ContainerControl = this;
            this.TenMHEP.Icon = ((System.Drawing.Icon)(resources.GetObject("TenMHEP.Icon")));
            // 
            // MonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 654);
            this.Controls.Add(this.buttonSua);
            this.Controls.Add(this.MonHocGridControl);
            this.Controls.Add(this.buttonThem);
            this.Controls.Add(this.bunifuPanel1);
            this.Controls.Add(this.buttonLamMoi);
            this.Controls.Add(this.buttonXoa);
            this.Name = "MonHoc";
            this.Text = "Môn học";
            this.Load += new System.EventHandler(this.MonHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MonHocGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MonHocBindingSouce)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TN_CSDLPTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MonHocGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.bunifuPanel1.ResumeLayout(false);
            this.InfoPanel.ResumeLayout(false);
            this.InfoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextTenMH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextMaMH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoDeBindingSouce)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BangDiemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GV_DKBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaMHEP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TenMHEP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar4;
        private DevExpress.XtraBars.Bar bar5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private Guna.UI2.WinForms.Guna2CircleButton buttonXacNhan;
        private Guna.UI2.WinForms.Guna2CircleButton buttonHuy;
        private Guna.UI2.WinForms.Guna2CircleButton buttonRedo;
        private Guna.UI2.WinForms.Guna2CircleButton buttonUndo;
        private Bunifu.UI.WinForms.BunifuGroupBox InfoPanel;
        private TN_CSDLPTDataSet TN_CSDLPTDataSet;
        private System.Windows.Forms.BindingSource MonHocBindingSouce;
        private TN_CSDLPTDataSetTableAdapters.MONHOCTableAdapter MonHocTableAdapter;
        private TN_CSDLPTDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl MonHocGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView MonHocGridView;
        private DevExpress.XtraEditors.TextEdit TextTenMH;
        private DevExpress.XtraEditors.TextEdit TextMaMH;
        private DevExpress.XtraGrid.Columns.GridColumn colMAMH;
        private DevExpress.XtraGrid.Columns.GridColumn colTENMH;
        private DevExpress.XtraGrid.Views.Card.CardView cardView1;
        private System.Windows.Forms.BindingSource BoDeBindingSouce;
        private TN_CSDLPTDataSetTableAdapters.BODETableAdapter BoDeTableAdapter;
        private System.Windows.Forms.BindingSource BangDiemBindingSource;
        private TN_CSDLPTDataSetTableAdapters.BANGDIEMTableAdapter BangDiemTableAdapter;
        private System.Windows.Forms.BindingSource GV_DKBindingSource;
        private TN_CSDLPTDataSetTableAdapters.GIAOVIEN_DANGKYTableAdapter GV_DKTableAdapter;
        private Guna.UI2.WinForms.Guna2Button buttonXoa;
        private Guna.UI2.WinForms.Guna2Button buttonLamMoi;
        private Guna.UI2.WinForms.Guna2Button buttonThem;
        private Guna.UI2.WinForms.Guna2Button buttonSua;
        private System.Windows.Forms.ErrorProvider MaMHEP;
        private System.Windows.Forms.ErrorProvider TenMHEP;
    }
}