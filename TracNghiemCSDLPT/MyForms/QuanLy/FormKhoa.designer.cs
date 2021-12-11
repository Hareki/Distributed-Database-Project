
namespace TracNghiemCSDLPT.MyForms.QuanLy
{
    partial class FormKhoa
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
            System.Windows.Forms.Label mAKHLabel;
            System.Windows.Forms.Label tENKHLabel;
            System.Windows.Forms.Label LabelMaCS;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKhoa));
            this.bunifuPanel2 = new Bunifu.UI.WinForms.BunifuPanel();
            this.buttonHuy = new Guna.UI2.WinForms.Guna2CircleButton();
            this.buttonXacNhan = new Guna.UI2.WinForms.Guna2CircleButton();
            this.buttonSua = new Guna.UI2.WinForms.Guna2Button();
            this.buttonThem = new Guna.UI2.WinForms.Guna2Button();
            this.buttonLamMoi = new Guna.UI2.WinForms.Guna2Button();
            this.buttonXoa = new Guna.UI2.WinForms.Guna2Button();
            this.CoSoComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.InfoPanel = new Bunifu.UI.WinForms.BunifuGroupBox();
            this.TextMaCS = new DevExpress.XtraEditors.TextEdit();
            this.KhoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TN_CSDLPTDataSet = new TracNghiemCSDLPT.TN_CSDLPTDataSet();
            this.TextTenKhoa = new DevExpress.XtraEditors.TextEdit();
            this.TextMaKhoa = new DevExpress.XtraEditors.TextEdit();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonRedo = new Guna.UI2.WinForms.Guna2CircleButton();
            this.buttonUndo = new Guna.UI2.WinForms.Guna2CircleButton();
            this.KhoaTableAdapter = new TracNghiemCSDLPT.TN_CSDLPTDataSetTableAdapters.KHOATableAdapter();
            this.tableAdapterManager = new TracNghiemCSDLPT.TN_CSDLPTDataSetTableAdapters.TableAdapterManager();
            this.KhoaGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMACS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LopTableAdapter = new TracNghiemCSDLPT.TN_CSDLPTDataSetTableAdapters.LOPTableAdapter();
            this.GiaoVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GiaoVienTableAdapter = new TracNghiemCSDLPT.TN_CSDLPTDataSetTableAdapters.GIAOVIENTableAdapter();
            this.MaKHEP = new System.Windows.Forms.ErrorProvider(this.components);
            this.TenKHEP = new System.Windows.Forms.ErrorProvider(this.components);
            mAKHLabel = new System.Windows.Forms.Label();
            tENKHLabel = new System.Windows.Forms.Label();
            LabelMaCS = new System.Windows.Forms.Label();
            this.bunifuPanel2.SuspendLayout();
            this.InfoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextMaCS.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KhoaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TN_CSDLPTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextTenKhoa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextMaKhoa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KhoaGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LopBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GiaoVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaKHEP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TenKHEP)).BeginInit();
            this.SuspendLayout();
            // 
            // mAKHLabel
            // 
            mAKHLabel.AutoSize = true;
            mAKHLabel.Font = new System.Drawing.Font("Baloo 2", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mAKHLabel.Location = new System.Drawing.Point(353, 80);
            mAKHLabel.Name = "mAKHLabel";
            mAKHLabel.Size = new System.Drawing.Size(92, 32);
            mAKHLabel.TabIndex = 5;
            mAKHLabel.Text = "Mã khoa";
            // 
            // tENKHLabel
            // 
            tENKHLabel.AutoSize = true;
            tENKHLabel.Font = new System.Drawing.Font("Baloo 2", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tENKHLabel.Location = new System.Drawing.Point(346, 140);
            tENKHLabel.Name = "tENKHLabel";
            tENKHLabel.Size = new System.Drawing.Size(99, 32);
            tENKHLabel.TabIndex = 6;
            tENKHLabel.Text = "Tên Khoa";
            // 
            // LabelMaCS
            // 
            LabelMaCS.AutoSize = true;
            LabelMaCS.Font = new System.Drawing.Font("Baloo 2", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LabelMaCS.Location = new System.Drawing.Point(349, 196);
            LabelMaCS.Name = "LabelMaCS";
            LabelMaCS.Size = new System.Drawing.Size(96, 32);
            LabelMaCS.TabIndex = 7;
            LabelMaCS.Text = "Mã cơ sở";
            // 
            // bunifuPanel2
            // 
            this.bunifuPanel2.BackgroundColor = System.Drawing.Color.Transparent;
            this.bunifuPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel2.BackgroundImage")));
            this.bunifuPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel2.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel2.BorderRadius = 3;
            this.bunifuPanel2.BorderThickness = 1;
            this.bunifuPanel2.Controls.Add(this.buttonHuy);
            this.bunifuPanel2.Controls.Add(this.buttonXacNhan);
            this.bunifuPanel2.Controls.Add(this.buttonSua);
            this.bunifuPanel2.Controls.Add(this.buttonThem);
            this.bunifuPanel2.Controls.Add(this.buttonLamMoi);
            this.bunifuPanel2.Controls.Add(this.buttonXoa);
            this.bunifuPanel2.Controls.Add(this.CoSoComboBox);
            this.bunifuPanel2.Controls.Add(this.label1);
            this.bunifuPanel2.Controls.Add(this.InfoPanel);
            this.bunifuPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuPanel2.Location = new System.Drawing.Point(0, 0);
            this.bunifuPanel2.Name = "bunifuPanel2";
            this.bunifuPanel2.ShowBorders = true;
            this.bunifuPanel2.Size = new System.Drawing.Size(1362, 397);
            this.bunifuPanel2.TabIndex = 24;
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
            this.buttonHuy.Location = new System.Drawing.Point(1110, 210);
            this.buttonHuy.Margin = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.buttonHuy.Name = "buttonHuy";
            this.buttonHuy.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.buttonHuy.ShadowDecoration.Parent = this.buttonHuy;
            this.buttonHuy.Size = new System.Drawing.Size(34, 30);
            this.buttonHuy.TabIndex = 31;
            this.buttonHuy.Visible = false;
            this.buttonHuy.Click += new System.EventHandler(this.ButtonHuy_Click);
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
            this.buttonXacNhan.Location = new System.Drawing.Point(1110, 157);
            this.buttonXacNhan.Margin = new System.Windows.Forms.Padding(11, 9, 8, 20);
            this.buttonXacNhan.Name = "buttonXacNhan";
            this.buttonXacNhan.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.buttonXacNhan.ShadowDecoration.Parent = this.buttonXacNhan;
            this.buttonXacNhan.Size = new System.Drawing.Size(34, 30);
            this.buttonXacNhan.TabIndex = 32;
            this.buttonXacNhan.Visible = false;
            this.buttonXacNhan.Click += new System.EventHandler(this.ButtonXacNhan_Click);
            // 
            // buttonSua
            // 
            this.buttonSua.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSua.Animated = true;
            this.buttonSua.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.buttonSua.BorderRadius = 8;
            this.buttonSua.BorderThickness = 1;
            this.buttonSua.CheckedState.Parent = this.buttonSua;
            this.buttonSua.CustomImages.Parent = this.buttonSua;
            this.buttonSua.FillColor = System.Drawing.Color.Gainsboro;
            this.buttonSua.Font = new System.Drawing.Font("Baloo 2 ExtraBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(70)))), ((int)(((byte)(68)))));
            this.buttonSua.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.buttonSua.HoverState.Parent = this.buttonSua;
            this.buttonSua.Image = global::TracNghiemCSDLPT.Properties.Resources.edit_480px;
            this.buttonSua.ImageSize = new System.Drawing.Size(35, 35);
            this.buttonSua.Location = new System.Drawing.Point(708, 341);
            this.buttonSua.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.buttonSua.Name = "buttonSua";
            this.buttonSua.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.buttonSua.ShadowDecoration.Parent = this.buttonSua;
            this.buttonSua.Size = new System.Drawing.Size(168, 45);
            this.buttonSua.TabIndex = 25;
            this.buttonSua.Text = "Sửa";
            this.buttonSua.TextOffset = new System.Drawing.Point(3, 0);
            this.buttonSua.Click += new System.EventHandler(this.ButtonSua_Click);
            // 
            // buttonThem
            // 
            this.buttonThem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonThem.Animated = true;
            this.buttonThem.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.buttonThem.BorderRadius = 8;
            this.buttonThem.BorderThickness = 1;
            this.buttonThem.CheckedState.Parent = this.buttonThem;
            this.buttonThem.CustomImages.Parent = this.buttonThem;
            this.buttonThem.FillColor = System.Drawing.Color.Gainsboro;
            this.buttonThem.Font = new System.Drawing.Font("Baloo 2 ExtraBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(70)))), ((int)(((byte)(68)))));
            this.buttonThem.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.buttonThem.HoverState.Parent = this.buttonThem;
            this.buttonThem.Image = global::TracNghiemCSDLPT.Properties.Resources.add_480px;
            this.buttonThem.ImageSize = new System.Drawing.Size(35, 35);
            this.buttonThem.Location = new System.Drawing.Point(267, 341);
            this.buttonThem.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.buttonThem.ShadowDecoration.Parent = this.buttonThem;
            this.buttonThem.Size = new System.Drawing.Size(168, 45);
            this.buttonThem.TabIndex = 26;
            this.buttonThem.Text = "Thêm";
            this.buttonThem.TextOffset = new System.Drawing.Point(3, 0);
            this.buttonThem.Click += new System.EventHandler(this.ButtonThem_Click);
            // 
            // buttonLamMoi
            // 
            this.buttonLamMoi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonLamMoi.Animated = true;
            this.buttonLamMoi.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.buttonLamMoi.BorderRadius = 8;
            this.buttonLamMoi.CheckedState.Parent = this.buttonLamMoi;
            this.buttonLamMoi.CustomImages.Parent = this.buttonLamMoi;
            this.buttonLamMoi.FillColor = System.Drawing.Color.Gainsboro;
            this.buttonLamMoi.Font = new System.Drawing.Font("Baloo 2 ExtraBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLamMoi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(70)))), ((int)(((byte)(68)))));
            this.buttonLamMoi.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.buttonLamMoi.HoverState.Parent = this.buttonLamMoi;
            this.buttonLamMoi.Image = global::TracNghiemCSDLPT.Properties.Resources.reset_480px;
            this.buttonLamMoi.ImageSize = new System.Drawing.Size(35, 35);
            this.buttonLamMoi.Location = new System.Drawing.Point(928, 341);
            this.buttonLamMoi.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.buttonLamMoi.Name = "buttonLamMoi";
            this.buttonLamMoi.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.buttonLamMoi.ShadowDecoration.Parent = this.buttonLamMoi;
            this.buttonLamMoi.Size = new System.Drawing.Size(168, 45);
            this.buttonLamMoi.TabIndex = 27;
            this.buttonLamMoi.Text = "Làm mới";
            this.buttonLamMoi.TextOffset = new System.Drawing.Point(3, 0);
            this.buttonLamMoi.Click += new System.EventHandler(this.ButtonLamMoi_Click);
            // 
            // buttonXoa
            // 
            this.buttonXoa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonXoa.Animated = true;
            this.buttonXoa.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.buttonXoa.BorderRadius = 8;
            this.buttonXoa.BorderThickness = 1;
            this.buttonXoa.CheckedState.Parent = this.buttonXoa;
            this.buttonXoa.CustomImages.Parent = this.buttonXoa;
            this.buttonXoa.FillColor = System.Drawing.Color.Gainsboro;
            this.buttonXoa.Font = new System.Drawing.Font("Baloo 2 ExtraBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(70)))), ((int)(((byte)(68)))));
            this.buttonXoa.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.buttonXoa.HoverState.Parent = this.buttonXoa;
            this.buttonXoa.Image = global::TracNghiemCSDLPT.Properties.Resources.minus_sign_480px;
            this.buttonXoa.ImageSize = new System.Drawing.Size(35, 35);
            this.buttonXoa.Location = new System.Drawing.Point(487, 342);
            this.buttonXoa.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.buttonXoa.ShadowDecoration.Parent = this.buttonXoa;
            this.buttonXoa.Size = new System.Drawing.Size(168, 45);
            this.buttonXoa.TabIndex = 28;
            this.buttonXoa.Text = "Xóa";
            this.buttonXoa.TextOffset = new System.Drawing.Point(3, 0);
            this.buttonXoa.Click += new System.EventHandler(this.ButtonXoa_Click);
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
            this.CoSoComboBox.Location = new System.Drawing.Point(144, 19);
            this.CoSoComboBox.Margin = new System.Windows.Forms.Padding(10, 10, 3, 10);
            this.CoSoComboBox.Name = "CoSoComboBox";
            this.CoSoComboBox.ShadowDecoration.Parent = this.CoSoComboBox;
            this.CoSoComboBox.Size = new System.Drawing.Size(290, 36);
            this.CoSoComboBox.TabIndex = 24;
            this.CoSoComboBox.TextOffset = new System.Drawing.Point(3, 3);
            this.CoSoComboBox.SelectedIndexChanged += new System.EventHandler(this.CoSoComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Baloo 2", 10.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(17, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 10, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 30);
            this.label1.TabIndex = 23;
            this.label1.Text = "Chọn cơ sở";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // InfoPanel
            // 
            this.InfoPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.InfoPanel.BorderColor = System.Drawing.Color.LightGray;
            this.InfoPanel.BorderRadius = 8;
            this.InfoPanel.BorderThickness = 2;
            this.InfoPanel.Controls.Add(LabelMaCS);
            this.InfoPanel.Controls.Add(this.TextMaCS);
            this.InfoPanel.Controls.Add(tENKHLabel);
            this.InfoPanel.Controls.Add(this.TextTenKhoa);
            this.InfoPanel.Controls.Add(mAKHLabel);
            this.InfoPanel.Controls.Add(this.TextMaKhoa);
            this.InfoPanel.Controls.Add(this.pictureBox1);
            this.InfoPanel.Enabled = false;
            this.InfoPanel.Font = new System.Drawing.Font("Baloo 2", 15F, System.Drawing.FontStyle.Bold);
            this.InfoPanel.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.InfoPanel.LabelAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.InfoPanel.LabelIndent = 10;
            this.InfoPanel.LineStyle = Bunifu.UI.WinForms.BunifuGroupBox.LineStyles.Solid;
            this.InfoPanel.Location = new System.Drawing.Point(267, 74);
            this.InfoPanel.Name = "InfoPanel";
            this.InfoPanel.Size = new System.Drawing.Size(829, 257);
            this.InfoPanel.TabIndex = 0;
            this.InfoPanel.TabStop = false;
            this.InfoPanel.Text = "Thông tin khoa";
            // 
            // TextMaCS
            // 
            this.TextMaCS.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.KhoaBindingSource, "MACS", true));
            this.TextMaCS.Enabled = false;
            this.TextMaCS.Location = new System.Drawing.Point(454, 194);
            this.TextMaCS.Name = "TextMaCS";
            this.TextMaCS.Properties.Appearance.Font = new System.Drawing.Font("Baloo 2", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextMaCS.Properties.Appearance.Options.UseFont = true;
            this.TextMaCS.Size = new System.Drawing.Size(288, 38);
            this.TextMaCS.TabIndex = 8;
            this.TextMaCS.Enter += new System.EventHandler(this.Editor_GotFocus);
            this.TextMaCS.Leave += new System.EventHandler(this.Editor_LostFocus);
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
            // TextTenKhoa
            // 
            this.TextTenKhoa.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.KhoaBindingSource, "TENKH", true));
            this.TextTenKhoa.Location = new System.Drawing.Point(454, 137);
            this.TextTenKhoa.Name = "TextTenKhoa";
            this.TextTenKhoa.Properties.Appearance.Font = new System.Drawing.Font("Baloo 2", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextTenKhoa.Properties.Appearance.Options.UseFont = true;
            this.TextTenKhoa.Properties.MaxLength = 50;
            this.TextTenKhoa.Size = new System.Drawing.Size(288, 38);
            this.TextTenKhoa.TabIndex = 7;
            this.TextTenKhoa.Enter += new System.EventHandler(this.Editor_GotFocus);
            this.TextTenKhoa.Leave += new System.EventHandler(this.Editor_LostFocus);
            // 
            // TextMaKhoa
            // 
            this.TextMaKhoa.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.KhoaBindingSource, "MAKH", true));
            this.TextMaKhoa.Location = new System.Drawing.Point(454, 80);
            this.TextMaKhoa.Name = "TextMaKhoa";
            this.TextMaKhoa.Properties.Appearance.Font = new System.Drawing.Font("Baloo 2", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextMaKhoa.Properties.Appearance.Options.UseFont = true;
            this.TextMaKhoa.Properties.MaxLength = 8;
            this.TextMaKhoa.Size = new System.Drawing.Size(288, 38);
            this.TextMaKhoa.TabIndex = 5;
            this.TextMaKhoa.Enter += new System.EventHandler(this.Editor_GotFocus);
            this.TextMaKhoa.Leave += new System.EventHandler(this.Editor_LostFocus);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TracNghiemCSDLPT.Properties.Resources.school_disabled;
            this.pictureBox1.Location = new System.Drawing.Point(53, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(205, 166);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.EnabledChanged += new System.EventHandler(this.pictureBox1_EnabledChanged);
            // 
            // buttonRedo
            // 
            this.buttonRedo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRedo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.buttonRedo.CheckedState.Parent = this.buttonRedo;
            this.buttonRedo.CustomImages.Parent = this.buttonRedo;
            this.buttonRedo.FillColor = System.Drawing.Color.Transparent;
            this.buttonRedo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonRedo.ForeColor = System.Drawing.Color.White;
            this.buttonRedo.HoverState.Parent = this.buttonRedo;
            this.buttonRedo.Image = global::TracNghiemCSDLPT.Properties.Resources.redo_480px;
            this.buttonRedo.ImageSize = new System.Drawing.Size(28, 28);
            this.buttonRedo.Location = new System.Drawing.Point(1306, 403);
            this.buttonRedo.Margin = new System.Windows.Forms.Padding(17, 3, 11, 3);
            this.buttonRedo.Name = "buttonRedo";
            this.buttonRedo.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.buttonRedo.ShadowDecoration.Parent = this.buttonRedo;
            this.buttonRedo.Size = new System.Drawing.Size(34, 30);
            this.buttonRedo.TabIndex = 29;
            this.buttonRedo.Click += new System.EventHandler(this.ButtonRedo_Click);
            // 
            // buttonUndo
            // 
            this.buttonUndo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUndo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.buttonUndo.CheckedState.Parent = this.buttonUndo;
            this.buttonUndo.CustomImages.Parent = this.buttonUndo;
            this.buttonUndo.FillColor = System.Drawing.Color.Transparent;
            this.buttonUndo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonUndo.ForeColor = System.Drawing.Color.White;
            this.buttonUndo.HoverState.Parent = this.buttonUndo;
            this.buttonUndo.Image = global::TracNghiemCSDLPT.Properties.Resources.undo_480px1;
            this.buttonUndo.ImageSize = new System.Drawing.Size(28, 28);
            this.buttonUndo.Location = new System.Drawing.Point(1243, 403);
            this.buttonUndo.Margin = new System.Windows.Forms.Padding(3, 3, 11, 3);
            this.buttonUndo.Name = "buttonUndo";
            this.buttonUndo.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.buttonUndo.ShadowDecoration.Parent = this.buttonUndo;
            this.buttonUndo.Size = new System.Drawing.Size(34, 30);
            this.buttonUndo.TabIndex = 30;
            this.buttonUndo.Click += new System.EventHandler(this.ButtonUndo_Click);
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
            // KhoaGridControl
            // 
            this.KhoaGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.KhoaGridControl.DataSource = this.KhoaBindingSource;
            this.KhoaGridControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.KhoaGridControl.Location = new System.Drawing.Point(0, 396);
            this.KhoaGridControl.MainView = this.gridView1;
            this.KhoaGridControl.Name = "KhoaGridControl";
            this.KhoaGridControl.Size = new System.Drawing.Size(1362, 259);
            this.KhoaGridControl.TabIndex = 24;
            this.KhoaGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.gridView1.Appearance.EvenRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(70)))), ((int)(((byte)(68)))));
            this.gridView1.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridView1.Appearance.EvenRow.Options.UseForeColor = true;
            this.gridView1.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(255)))), ((int)(((byte)(215)))));
            this.gridView1.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(255)))), ((int)(((byte)(215)))));
            this.gridView1.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView1.Appearance.GroupRow.Font = new System.Drawing.Font("Baloo 2", 10.2F);
            this.gridView1.Appearance.GroupRow.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Baloo 2", 12F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(255)))), ((int)(((byte)(215)))));
            this.gridView1.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gridView1.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.gridView1.Appearance.OddRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(70)))), ((int)(((byte)(68)))));
            this.gridView1.Appearance.OddRow.Options.UseBackColor = true;
            this.gridView1.Appearance.OddRow.Options.UseForeColor = true;
            this.gridView1.Appearance.Preview.Font = new System.Drawing.Font("Baloo 2", 10.2F);
            this.gridView1.Appearance.Preview.Options.UseFont = true;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Baloo 2", 12F);
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(255)))), ((int)(((byte)(215)))));
            this.gridView1.Appearance.SelectedRow.Font = new System.Drawing.Font("Baloo 2", 12F);
            this.gridView1.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridView1.Appearance.SelectedRow.Options.UseFont = true;
            this.gridView1.Appearance.TopNewRow.Font = new System.Drawing.Font("Baloo 2", 10.2F);
            this.gridView1.Appearance.TopNewRow.Options.UseFont = true;
            this.gridView1.Appearance.ViewCaption.Font = new System.Drawing.Font("Baloo 2", 13.8F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.ViewCaption.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAKH,
            this.colTENKH,
            this.colMACS});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.GridControl = this.KhoaGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsCustomization.AllowRowSizing = true;
            this.gridView1.OptionsDetail.EnableMasterViewMode = false;
            this.gridView1.OptionsPrint.EnableAppearanceOddRow = true;
            this.gridView1.OptionsScrollAnnotations.ShowFocusedRow = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsView.EnableAppearanceOddRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.ShowIndicator = false;
            this.gridView1.OptionsView.ShowViewCaption = true;
            this.gridView1.ViewCaption = "Danh sách khoa";
            // 
            // colMAKH
            // 
            this.colMAKH.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(164)))), ((int)(((byte)(236)))));
            this.colMAKH.AppearanceHeader.Options.UseBackColor = true;
            this.colMAKH.Caption = "Mã khoa";
            this.colMAKH.FieldName = "MAKH";
            this.colMAKH.MinWidth = 29;
            this.colMAKH.Name = "colMAKH";
            this.colMAKH.Visible = true;
            this.colMAKH.VisibleIndex = 0;
            this.colMAKH.Width = 107;
            // 
            // colTENKH
            // 
            this.colTENKH.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(164)))), ((int)(((byte)(236)))));
            this.colTENKH.AppearanceHeader.Options.UseBackColor = true;
            this.colTENKH.Caption = "Tên khoa";
            this.colTENKH.FieldName = "TENKH";
            this.colTENKH.MinWidth = 29;
            this.colTENKH.Name = "colTENKH";
            this.colTENKH.Visible = true;
            this.colTENKH.VisibleIndex = 1;
            this.colTENKH.Width = 107;
            // 
            // colMACS
            // 
            this.colMACS.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(164)))), ((int)(((byte)(236)))));
            this.colMACS.AppearanceHeader.Options.UseBackColor = true;
            this.colMACS.Caption = "Mã cơ sở";
            this.colMACS.FieldName = "MACS";
            this.colMACS.MinWidth = 29;
            this.colMACS.Name = "colMACS";
            this.colMACS.Visible = true;
            this.colMACS.VisibleIndex = 2;
            this.colMACS.Width = 107;
            // 
            // LopBindingSource
            // 
            this.LopBindingSource.DataMember = "FK_LOP_KHOA";
            this.LopBindingSource.DataSource = this.KhoaBindingSource;
            // 
            // LopTableAdapter
            // 
            this.LopTableAdapter.ClearBeforeFill = true;
            // 
            // GiaoVienBindingSource
            // 
            this.GiaoVienBindingSource.DataMember = "FK_GIAOVIEN_KHOA";
            this.GiaoVienBindingSource.DataSource = this.KhoaBindingSource;
            // 
            // GiaoVienTableAdapter
            // 
            this.GiaoVienTableAdapter.ClearBeforeFill = true;
            // 
            // MaKHEP
            // 
            this.MaKHEP.ContainerControl = this;
            // 
            // TenKHEP
            // 
            this.TenKHEP.ContainerControl = this;
            this.TenKHEP.Icon = ((System.Drawing.Icon)(resources.GetObject("TenKHEP.Icon")));
            // 
            // FormKhoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 654);
            this.Controls.Add(this.bunifuPanel2);
            this.Controls.Add(this.buttonUndo);
            this.Controls.Add(this.buttonRedo);
            this.Controls.Add(this.KhoaGridControl);
            this.IconOptions.Image = global::TracNghiemCSDLPT.Properties.Resources.CSDLPT_Logo1;
            this.Name = "FormKhoa";
            this.Text = "Khoa";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormKhoa_FormClosing);
            this.Load += new System.EventHandler(this.FormKhoa_Load);
            this.bunifuPanel2.ResumeLayout(false);
            this.bunifuPanel2.PerformLayout();
            this.InfoPanel.ResumeLayout(false);
            this.InfoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextMaCS.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KhoaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TN_CSDLPTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextTenKhoa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextMaKhoa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KhoaGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LopBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GiaoVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaKHEP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TenKHEP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel2;
        private TN_CSDLPTDataSetTableAdapters.KHOATableAdapter KhoaTableAdapter;
        private TN_CSDLPTDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private TN_CSDLPTDataSet TN_CSDLPTDataSet;
        private System.Windows.Forms.BindingSource KhoaBindingSource;
        private DevExpress.XtraGrid.GridControl KhoaGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKH;
        private DevExpress.XtraGrid.Columns.GridColumn colTENKH;
        private Bunifu.UI.WinForms.BunifuGroupBox InfoPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.TextEdit TextMaKhoa;
        private System.Windows.Forms.BindingSource LopBindingSource;
        private TN_CSDLPTDataSetTableAdapters.LOPTableAdapter LopTableAdapter;
        private System.Windows.Forms.BindingSource GiaoVienBindingSource;
        private TN_CSDLPTDataSetTableAdapters.GIAOVIENTableAdapter GiaoVienTableAdapter;
        private Guna.UI2.WinForms.Guna2ComboBox CoSoComboBox;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.Columns.GridColumn colMACS;
        private DevExpress.XtraEditors.TextEdit TextMaCS;
        private Guna.UI2.WinForms.Guna2Button buttonSua;
        private Guna.UI2.WinForms.Guna2Button buttonThem;
        private Guna.UI2.WinForms.Guna2Button buttonLamMoi;
        private Guna.UI2.WinForms.Guna2Button buttonXoa;
        private Guna.UI2.WinForms.Guna2CircleButton buttonRedo;
        private Guna.UI2.WinForms.Guna2CircleButton buttonUndo;
        private Guna.UI2.WinForms.Guna2CircleButton buttonHuy;
        private Guna.UI2.WinForms.Guna2CircleButton buttonXacNhan;
        private System.Windows.Forms.ErrorProvider MaKHEP;
        private System.Windows.Forms.ErrorProvider TenKHEP;
        private DevExpress.XtraEditors.TextEdit TextTenKhoa;
    }
}