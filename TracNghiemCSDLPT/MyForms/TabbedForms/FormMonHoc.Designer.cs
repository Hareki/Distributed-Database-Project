
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
            this.bunifuGroupBox1 = new Bunifu.UI.WinForms.BunifuGroupBox();
            this.TFTenMH = new DevExpress.XtraEditors.TextEdit();
            this.TFMaMH = new DevExpress.XtraEditors.TextEdit();
            this.guna2CircleButton2 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2CircleButton4 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2CircleButton3 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.MonHocTableAdapter = new TracNghiemCSDLPT.TN_CSDLPTDataSetTableAdapters.MONHOCTableAdapter();
            this.tableAdapterManager = new TracNghiemCSDLPT.TN_CSDLPTDataSetTableAdapters.TableAdapterManager();
            LabelMaMH = new System.Windows.Forms.Label();
            LabelTenMH = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MonHocGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MonHocBindingSouce)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TN_CSDLPTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MonHocGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.bunifuPanel1.SuspendLayout();
            this.bunifuGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TFTenMH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TFMaMH.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelMaMH
            // 
            LabelMaMH.AutoSize = true;
            LabelMaMH.Font = new System.Drawing.Font("Baloo 2", 10.8F, System.Drawing.FontStyle.Bold);
            LabelMaMH.Location = new System.Drawing.Point(234, 70);
            LabelMaMH.Name = "LabelMaMH";
            LabelMaMH.Size = new System.Drawing.Size(115, 30);
            LabelMaMH.TabIndex = 4;
            LabelMaMH.Text = "Mã môn học";
            // 
            // LabelTenMH
            // 
            LabelTenMH.AutoSize = true;
            LabelTenMH.Font = new System.Drawing.Font("Baloo 2", 10.8F, System.Drawing.FontStyle.Bold);
            LabelTenMH.Location = new System.Drawing.Point(234, 130);
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
            this.MonHocGridControl.Location = new System.Drawing.Point(0, 341);
            this.MonHocGridControl.MainView = this.MonHocGridView;
            this.MonHocGridControl.Name = "MonHocGridControl";
            this.MonHocGridControl.Size = new System.Drawing.Size(1029, 313);
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
            this.MonHocGridView.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(164)))), ((int)(((byte)(236)))));
            this.MonHocGridView.Appearance.FocusedCell.Options.UseBackColor = true;
            this.MonHocGridView.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(164)))), ((int)(((byte)(236)))));
            this.MonHocGridView.Appearance.FocusedRow.Options.UseBackColor = true;
            this.MonHocGridView.Appearance.GroupRow.Font = new System.Drawing.Font("Baloo 2", 10.2F);
            this.MonHocGridView.Appearance.GroupRow.Options.UseFont = true;
            this.MonHocGridView.Appearance.HeaderPanel.Font = new System.Drawing.Font("Baloo 2", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MonHocGridView.Appearance.HeaderPanel.Options.UseFont = true;
            this.MonHocGridView.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(164)))), ((int)(((byte)(236)))));
            this.MonHocGridView.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.MonHocGridView.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.MonHocGridView.Appearance.OddRow.Options.UseBackColor = true;
            this.MonHocGridView.Appearance.Preview.Font = new System.Drawing.Font("Baloo 2", 10.2F);
            this.MonHocGridView.Appearance.Preview.Options.UseFont = true;
            this.MonHocGridView.Appearance.Row.Font = new System.Drawing.Font("Baloo 2", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MonHocGridView.Appearance.Row.Options.UseFont = true;
            this.MonHocGridView.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(164)))), ((int)(((byte)(236)))));
            this.MonHocGridView.Appearance.SelectedRow.Font = new System.Drawing.Font("Source Serif Pro", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MonHocGridView.Appearance.SelectedRow.Options.UseBackColor = true;
            this.MonHocGridView.Appearance.SelectedRow.Options.UseFont = true;
            this.MonHocGridView.Appearance.TopNewRow.Font = new System.Drawing.Font("Baloo 2", 10.2F);
            this.MonHocGridView.Appearance.TopNewRow.Options.UseFont = true;
            this.MonHocGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAMH,
            this.colTENMH});
            this.MonHocGridView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.MonHocGridView.GridControl = this.MonHocGridControl;
            this.MonHocGridView.Name = "MonHocGridView";
            this.MonHocGridView.OptionsBehavior.Editable = false;
            this.MonHocGridView.OptionsDetail.EnableMasterViewMode = false;
            this.MonHocGridView.OptionsScrollAnnotations.ShowFocusedRow = DevExpress.Utils.DefaultBoolean.True;
            // 
            // colMAMH
            // 
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
            this.pictureBox1.Location = new System.Drawing.Point(64, 33);
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
            this.bunifuPanel1.Controls.Add(this.bunifuGroupBox1);
            this.bunifuPanel1.Controls.Add(this.guna2CircleButton2);
            this.bunifuPanel1.Controls.Add(this.guna2CircleButton4);
            this.bunifuPanel1.Controls.Add(this.guna2CircleButton3);
            this.bunifuPanel1.Controls.Add(this.guna2CircleButton1);
            this.bunifuPanel1.Location = new System.Drawing.Point(0, 12);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(1029, 242);
            this.bunifuPanel1.TabIndex = 10;
            // 
            // bunifuGroupBox1
            // 
            this.bunifuGroupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuGroupBox1.BorderColor = System.Drawing.Color.LightGray;
            this.bunifuGroupBox1.BorderRadius = 1;
            this.bunifuGroupBox1.BorderThickness = 1;
            this.bunifuGroupBox1.Controls.Add(LabelTenMH);
            this.bunifuGroupBox1.Controls.Add(this.TFTenMH);
            this.bunifuGroupBox1.Controls.Add(LabelMaMH);
            this.bunifuGroupBox1.Controls.Add(this.TFMaMH);
            this.bunifuGroupBox1.Controls.Add(this.pictureBox1);
            this.bunifuGroupBox1.Font = new System.Drawing.Font("Baloo 2", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuGroupBox1.LabelAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuGroupBox1.LabelIndent = 10;
            this.bunifuGroupBox1.LineStyle = Bunifu.UI.WinForms.BunifuGroupBox.LineStyles.Solid;
            this.bunifuGroupBox1.Location = new System.Drawing.Point(185, 3);
            this.bunifuGroupBox1.Name = "bunifuGroupBox1";
            this.bunifuGroupBox1.Size = new System.Drawing.Size(659, 223);
            this.bunifuGroupBox1.TabIndex = 12;
            this.bunifuGroupBox1.TabStop = false;
            this.bunifuGroupBox1.Text = "Nhập thông tin môn học";
            // 
            // TFTenMH
            // 
            this.TFTenMH.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.MonHocBindingSouce, "TENMH", true));
            this.TFTenMH.Location = new System.Drawing.Point(365, 127);
            this.TFTenMH.Name = "TFTenMH";
            this.TFTenMH.Properties.Appearance.Font = new System.Drawing.Font("Baloo 2", 10.8F, System.Drawing.FontStyle.Bold);
            this.TFTenMH.Properties.Appearance.Options.UseFont = true;
            this.TFTenMH.Size = new System.Drawing.Size(252, 34);
            this.TFTenMH.TabIndex = 6;
            // 
            // TFMaMH
            // 
            this.TFMaMH.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.MonHocBindingSouce, "MAMH", true));
            this.TFMaMH.Location = new System.Drawing.Point(365, 64);
            this.TFMaMH.Name = "TFMaMH";
            this.TFMaMH.Properties.Appearance.Font = new System.Drawing.Font("Baloo 2", 10.8F, System.Drawing.FontStyle.Bold);
            this.TFMaMH.Properties.Appearance.Options.UseFont = true;
            this.TFMaMH.Size = new System.Drawing.Size(252, 34);
            this.TFMaMH.TabIndex = 5;
            // 
            // guna2CircleButton2
            // 
            this.guna2CircleButton2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2CircleButton2.CheckedState.Parent = this.guna2CircleButton2;
            this.guna2CircleButton2.CustomImages.Parent = this.guna2CircleButton2;
            this.guna2CircleButton2.FillColor = System.Drawing.Color.Transparent;
            this.guna2CircleButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2CircleButton2.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton2.HoverState.Parent = this.guna2CircleButton2;
            this.guna2CircleButton2.Image = global::TracNghiemCSDLPT.Properties.Resources.cancel_480px;
            this.guna2CircleButton2.ImageSize = new System.Drawing.Size(31, 31);
            this.guna2CircleButton2.Location = new System.Drawing.Point(857, 148);
            this.guna2CircleButton2.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.guna2CircleButton2.Name = "guna2CircleButton2";
            this.guna2CircleButton2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton2.ShadowDecoration.Parent = this.guna2CircleButton2;
            this.guna2CircleButton2.Size = new System.Drawing.Size(30, 30);
            this.guna2CircleButton2.TabIndex = 2;
            // 
            // guna2CircleButton4
            // 
            this.guna2CircleButton4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2CircleButton4.CheckedState.Parent = this.guna2CircleButton4;
            this.guna2CircleButton4.CustomImages.Parent = this.guna2CircleButton4;
            this.guna2CircleButton4.FillColor = System.Drawing.Color.Transparent;
            this.guna2CircleButton4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2CircleButton4.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton4.HoverState.Parent = this.guna2CircleButton4;
            this.guna2CircleButton4.Image = global::TracNghiemCSDLPT.Properties.Resources.redo_480px;
            this.guna2CircleButton4.ImageSize = new System.Drawing.Size(28, 28);
            this.guna2CircleButton4.Location = new System.Drawing.Point(142, 148);
            this.guna2CircleButton4.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.guna2CircleButton4.Name = "guna2CircleButton4";
            this.guna2CircleButton4.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton4.ShadowDecoration.Parent = this.guna2CircleButton4;
            this.guna2CircleButton4.Size = new System.Drawing.Size(30, 30);
            this.guna2CircleButton4.TabIndex = 2;
            // 
            // guna2CircleButton3
            // 
            this.guna2CircleButton3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2CircleButton3.CheckedState.Parent = this.guna2CircleButton3;
            this.guna2CircleButton3.CustomImages.Parent = this.guna2CircleButton3;
            this.guna2CircleButton3.FillColor = System.Drawing.Color.Transparent;
            this.guna2CircleButton3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2CircleButton3.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton3.HoverState.Parent = this.guna2CircleButton3;
            this.guna2CircleButton3.Image = global::TracNghiemCSDLPT.Properties.Resources.undo_480px1;
            this.guna2CircleButton3.ImageSize = new System.Drawing.Size(28, 28);
            this.guna2CircleButton3.Location = new System.Drawing.Point(142, 69);
            this.guna2CircleButton3.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.guna2CircleButton3.Name = "guna2CircleButton3";
            this.guna2CircleButton3.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton3.ShadowDecoration.Parent = this.guna2CircleButton3;
            this.guna2CircleButton3.Size = new System.Drawing.Size(30, 30);
            this.guna2CircleButton3.TabIndex = 2;
            // 
            // guna2CircleButton1
            // 
            this.guna2CircleButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2CircleButton1.CheckedState.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.CustomImages.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.FillColor = System.Drawing.Color.Transparent;
            this.guna2CircleButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2CircleButton1.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton1.HoverState.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.Image = global::TracNghiemCSDLPT.Properties.Resources.ok_480px;
            this.guna2CircleButton1.ImageSize = new System.Drawing.Size(31, 31);
            this.guna2CircleButton1.Location = new System.Drawing.Point(857, 69);
            this.guna2CircleButton1.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.guna2CircleButton1.Name = "guna2CircleButton1";
            this.guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton1.ShadowDecoration.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.Size = new System.Drawing.Size(30, 30);
            this.guna2CircleButton1.TabIndex = 2;
            // 
            // guna2Button1
            // 
            this.guna2Button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.guna2Button1.Animated = true;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.guna2Button1.Font = new System.Drawing.Font("Baloo 2 ExtraBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(70)))), ((int)(((byte)(68)))));
            this.guna2Button1.HoverState.FillColor = System.Drawing.Color.Gainsboro;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Image = global::TracNghiemCSDLPT.Properties.Resources.reset_480px;
            this.guna2Button1.ImageSize = new System.Drawing.Size(40, 40);
            this.guna2Button1.Location = new System.Drawing.Point(784, 264);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(186)))), ((int)(((byte)(185)))));
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(147, 45);
            this.guna2Button1.TabIndex = 11;
            this.guna2Button1.Text = "Làm mới";
            // 
            // guna2Button2
            // 
            this.guna2Button2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.guna2Button2.Animated = true;
            this.guna2Button2.CheckedState.Parent = this.guna2Button2;
            this.guna2Button2.CustomImages.Parent = this.guna2Button2;
            this.guna2Button2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.guna2Button2.Font = new System.Drawing.Font("Baloo 2 ExtraBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(70)))), ((int)(((byte)(68)))));
            this.guna2Button2.HoverState.FillColor = System.Drawing.Color.Gainsboro;
            this.guna2Button2.HoverState.Parent = this.guna2Button2;
            this.guna2Button2.Image = global::TracNghiemCSDLPT.Properties.Resources.edit_480px;
            this.guna2Button2.ImageSize = new System.Drawing.Size(40, 40);
            this.guna2Button2.Location = new System.Drawing.Point(555, 264);
            this.guna2Button2.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(186)))), ((int)(((byte)(185)))));
            this.guna2Button2.ShadowDecoration.Parent = this.guna2Button2;
            this.guna2Button2.Size = new System.Drawing.Size(147, 45);
            this.guna2Button2.TabIndex = 11;
            this.guna2Button2.Text = "Sửa";
            // 
            // guna2Button3
            // 
            this.guna2Button3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.guna2Button3.Animated = true;
            this.guna2Button3.CheckedState.Parent = this.guna2Button3;
            this.guna2Button3.CustomImages.Parent = this.guna2Button3;
            this.guna2Button3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.guna2Button3.Font = new System.Drawing.Font("Baloo 2 ExtraBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(70)))), ((int)(((byte)(68)))));
            this.guna2Button3.HoverState.FillColor = System.Drawing.Color.Gainsboro;
            this.guna2Button3.HoverState.Parent = this.guna2Button3;
            this.guna2Button3.Image = global::TracNghiemCSDLPT.Properties.Resources.minus_sign_480px;
            this.guna2Button3.ImageSize = new System.Drawing.Size(40, 40);
            this.guna2Button3.Location = new System.Drawing.Point(326, 265);
            this.guna2Button3.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(186)))), ((int)(((byte)(185)))));
            this.guna2Button3.ShadowDecoration.Parent = this.guna2Button3;
            this.guna2Button3.Size = new System.Drawing.Size(147, 45);
            this.guna2Button3.TabIndex = 11;
            this.guna2Button3.Text = "Xóa";
            // 
            // guna2Button4
            // 
            this.guna2Button4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.guna2Button4.Animated = true;
            this.guna2Button4.CheckedState.Parent = this.guna2Button4;
            this.guna2Button4.CustomImages.Parent = this.guna2Button4;
            this.guna2Button4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.guna2Button4.Font = new System.Drawing.Font("Baloo 2 ExtraBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(70)))), ((int)(((byte)(68)))));
            this.guna2Button4.HoverState.FillColor = System.Drawing.Color.Gainsboro;
            this.guna2Button4.HoverState.Parent = this.guna2Button4;
            this.guna2Button4.Image = global::TracNghiemCSDLPT.Properties.Resources.add_480px;
            this.guna2Button4.ImageSize = new System.Drawing.Size(40, 40);
            this.guna2Button4.Location = new System.Drawing.Point(97, 264);
            this.guna2Button4.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(186)))), ((int)(((byte)(185)))));
            this.guna2Button4.ShadowDecoration.Parent = this.guna2Button4;
            this.guna2Button4.Size = new System.Drawing.Size(147, 45);
            this.guna2Button4.TabIndex = 11;
            this.guna2Button4.Text = "Thêm";
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
            // MonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 652);
            this.Controls.Add(this.MonHocGridControl);
            this.Controls.Add(this.guna2Button4);
            this.Controls.Add(this.guna2Button3);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.bunifuPanel1);
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
            this.bunifuGroupBox1.ResumeLayout(false);
            this.bunifuGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TFTenMH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TFMaMH.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar4;
        private DevExpress.XtraBars.Bar bar5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton2;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton4;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton3;
        private Bunifu.UI.WinForms.BunifuGroupBox bunifuGroupBox1;
        private TN_CSDLPTDataSet TN_CSDLPTDataSet;
        private System.Windows.Forms.BindingSource MonHocBindingSouce;
        private TN_CSDLPTDataSetTableAdapters.MONHOCTableAdapter MonHocTableAdapter;
        private TN_CSDLPTDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl MonHocGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView MonHocGridView;
        private DevExpress.XtraEditors.TextEdit TFTenMH;
        private DevExpress.XtraEditors.TextEdit TFMaMH;
        private DevExpress.XtraGrid.Columns.GridColumn colMAMH;
        private DevExpress.XtraGrid.Columns.GridColumn colTENMH;
        private DevExpress.XtraGrid.Views.Card.CardView cardView1;
    }
}