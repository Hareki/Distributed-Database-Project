
namespace TracNghiemCSDLPT.MyForms
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.LoginEP = new System.Windows.Forms.ErrorProvider(this.components);
            this.PasswordEP = new System.Windows.Forms.ErrorProvider(this.components);
            this.RdoEP = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.CSEP = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.ComboBoxCoSo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.buttonThoat = new Guna.UI2.WinForms.Guna2Button();
            this.buttonDangNhap = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TextLogin = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.PanelSV = new Bunifu.UI.WinForms.BunifuPanel();
            this.rdoSV = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.LabelSinhVien = new System.Windows.Forms.Label();
            this.PanelGV = new Bunifu.UI.WinForms.BunifuPanel();
            this.rdoGV = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.LabelGiangVien = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginEP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordEP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RdoEP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CSEP)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PanelSV.SuspendLayout();
            this.PanelGV.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Baloo 2", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.label3.Location = new System.Drawing.Point(158, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 91);
            this.label3.TabIndex = 8;
            this.label3.Text = "Quản lý thi trắc nghiệm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Baloo 2", 10.8F);
            this.label2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Location = new System.Drawing.Point(13, 215);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 0, 10, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 30);
            this.label2.TabIndex = 4;
            this.label2.Text = "Vai trò";
            // 
            // LoginEP
            // 
            this.LoginEP.ContainerControl = this;
            this.LoginEP.Icon = ((System.Drawing.Icon)(resources.GetObject("LoginEP.Icon")));
            // 
            // PasswordEP
            // 
            this.PasswordEP.ContainerControl = this;
            this.PasswordEP.Icon = ((System.Drawing.Icon)(resources.GetObject("PasswordEP.Icon")));
            // 
            // RdoEP
            // 
            this.RdoEP.ContainerControl = this;
            this.RdoEP.Icon = ((System.Drawing.Icon)(resources.GetObject("RdoEP.Icon")));
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Baloo 2", 10.8F);
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(13, 134);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 10, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cơ sở";
            // 
            // CSEP
            // 
            this.CSEP.ContainerControl = this;
            this.CSEP.Icon = ((System.Drawing.Icon)(resources.GetObject("CSEP.Icon")));
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.ComboBoxCoSo);
            this.panel1.Controls.Add(this.buttonThoat);
            this.panel1.Controls.Add(this.buttonDangNhap);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.TextLogin);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.TextPassword);
            this.panel1.Controls.Add(this.PanelSV);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.PanelGV);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(38, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(396, 540);
            this.panel1.TabIndex = 14;
            // 
            // ComboBoxCoSo
            // 
            this.ComboBoxCoSo.Animated = true;
            this.ComboBoxCoSo.BackColor = System.Drawing.Color.Transparent;
            this.ComboBoxCoSo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(164)))), ((int)(((byte)(236)))));
            this.ComboBoxCoSo.BorderRadius = 3;
            this.ComboBoxCoSo.BorderThickness = 2;
            this.ComboBoxCoSo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBoxCoSo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxCoSo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(163)))), ((int)(((byte)(236)))));
            this.ComboBoxCoSo.FocusedColor = System.Drawing.Color.Empty;
            this.ComboBoxCoSo.FocusedState.Parent = this.ComboBoxCoSo;
            this.ComboBoxCoSo.Font = new System.Drawing.Font("Baloo 2", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxCoSo.ForeColor = System.Drawing.Color.White;
            this.ComboBoxCoSo.FormattingEnabled = true;
            this.ComboBoxCoSo.HoverState.Parent = this.ComboBoxCoSo;
            this.ComboBoxCoSo.ItemHeight = 30;
            this.ComboBoxCoSo.ItemsAppearance.Parent = this.ComboBoxCoSo;
            this.ComboBoxCoSo.Location = new System.Drawing.Point(18, 169);
            this.ComboBoxCoSo.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.ComboBoxCoSo.Name = "ComboBoxCoSo";
            this.ComboBoxCoSo.ShadowDecoration.Parent = this.ComboBoxCoSo;
            this.ComboBoxCoSo.Size = new System.Drawing.Size(359, 36);
            this.ComboBoxCoSo.TabIndex = 43;
            this.ComboBoxCoSo.TextOffset = new System.Drawing.Point(3, 3);
            // 
            // buttonThoat
            // 
            this.buttonThoat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonThoat.BorderRadius = 8;
            this.buttonThoat.CheckedState.Parent = this.buttonThoat;
            this.buttonThoat.CustomImages.Parent = this.buttonThoat;
            this.buttonThoat.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.buttonThoat.Font = new System.Drawing.Font("Baloo 2", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThoat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonThoat.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.buttonThoat.HoverState.Parent = this.buttonThoat;
            this.buttonThoat.ImageSize = new System.Drawing.Size(35, 35);
            this.buttonThoat.Location = new System.Drawing.Point(18, 470);
            this.buttonThoat.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.buttonThoat.Name = "buttonThoat";
            this.buttonThoat.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.buttonThoat.ShadowDecoration.Parent = this.buttonThoat;
            this.buttonThoat.Size = new System.Drawing.Size(163, 46);
            this.buttonThoat.TabIndex = 42;
            this.buttonThoat.Text = "Thoát";
            this.buttonThoat.TextOffset = new System.Drawing.Point(3, 0);
            // 
            // buttonDangNhap
            // 
            this.buttonDangNhap.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonDangNhap.BorderRadius = 8;
            this.buttonDangNhap.CheckedState.Parent = this.buttonDangNhap;
            this.buttonDangNhap.CustomImages.Parent = this.buttonDangNhap;
            this.buttonDangNhap.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(163)))), ((int)(((byte)(236)))));
            this.buttonDangNhap.Font = new System.Drawing.Font("Baloo 2", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDangNhap.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonDangNhap.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(147)))), ((int)(((byte)(219)))));
            this.buttonDangNhap.HoverState.Parent = this.buttonDangNhap;
            this.buttonDangNhap.ImageSize = new System.Drawing.Size(35, 35);
            this.buttonDangNhap.Location = new System.Drawing.Point(214, 470);
            this.buttonDangNhap.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.buttonDangNhap.Name = "buttonDangNhap";
            this.buttonDangNhap.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.buttonDangNhap.ShadowDecoration.Parent = this.buttonDangNhap;
            this.buttonDangNhap.Size = new System.Drawing.Size(163, 46);
            this.buttonDangNhap.TabIndex = 42;
            this.buttonDangNhap.Text = "Đăng nhập";
            this.buttonDangNhap.TextOffset = new System.Drawing.Point(3, 0);
            this.buttonDangNhap.Click += new System.EventHandler(this.buttonDangNhap_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TracNghiemCSDLPT.Properties.Resources.CSDLPT_Logo1;
            this.pictureBox1.Location = new System.Drawing.Point(80, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(74, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // TextLogin
            // 
            this.TextLogin.BorderThickness = 2;
            this.TextLogin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextLogin.DefaultText = "";
            this.TextLogin.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextLogin.DisabledState.Parent = this.TextLogin;
            this.TextLogin.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextLogin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextLogin.FocusedState.Parent = this.TextLogin;
            this.TextLogin.Font = new System.Drawing.Font("Baloo 2", 10.8F);
            this.TextLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(70)))), ((int)(((byte)(68)))));
            this.TextLogin.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(168)))), ((int)(((byte)(255)))));
            this.TextLogin.HoverState.Parent = this.TextLogin;
            this.TextLogin.IconLeft = global::TracNghiemCSDLPT.Properties.Resources.user_480px1;
            this.TextLogin.IconLeftOffset = new System.Drawing.Point(0, -5);
            this.TextLogin.IconLeftSize = new System.Drawing.Size(35, 35);
            this.TextLogin.IconRightOffset = new System.Drawing.Point(0, -3);
            this.TextLogin.IconRightSize = new System.Drawing.Size(35, 35);
            this.TextLogin.Location = new System.Drawing.Point(15, 319);
            this.TextLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 15);
            this.TextLogin.Name = "TextLogin";
            this.TextLogin.PasswordChar = '\0';
            this.TextLogin.PlaceholderText = "Tài khoản";
            this.TextLogin.SelectedText = "";
            this.TextLogin.ShadowDecoration.Parent = this.TextLogin;
            this.TextLogin.Size = new System.Drawing.Size(361, 49);
            this.TextLogin.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.TextLogin.TabIndex = 13;
            this.TextLogin.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            this.TextLogin.IconRightClick += new System.EventHandler(this.guna2TextBox1_IconRightClick);
            this.TextLogin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextLogin_KeyDown);
            // 
            // TextPassword
            // 
            this.TextPassword.BorderThickness = 2;
            this.TextPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextPassword.DefaultText = "";
            this.TextPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextPassword.DisabledState.Parent = this.TextPassword;
            this.TextPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextPassword.FocusedState.Parent = this.TextPassword;
            this.TextPassword.Font = new System.Drawing.Font("Baloo 2", 10.8F);
            this.TextPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(70)))), ((int)(((byte)(68)))));
            this.TextPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(168)))), ((int)(((byte)(255)))));
            this.TextPassword.HoverState.Parent = this.TextPassword;
            this.TextPassword.IconLeft = global::TracNghiemCSDLPT.Properties.Resources.lock_500px;
            this.TextPassword.IconLeftOffset = new System.Drawing.Point(0, -5);
            this.TextPassword.IconLeftSize = new System.Drawing.Size(35, 35);
            this.TextPassword.IconRight = global::TracNghiemCSDLPT.Properties.Resources.invisible_512px;
            this.TextPassword.IconRightOffset = new System.Drawing.Point(0, -3);
            this.TextPassword.IconRightSize = new System.Drawing.Size(35, 35);
            this.TextPassword.Location = new System.Drawing.Point(15, 387);
            this.TextPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 15);
            this.TextPassword.Name = "TextPassword";
            this.TextPassword.PasswordChar = '\0';
            this.TextPassword.PlaceholderText = "Mật khẩu";
            this.TextPassword.SelectedText = "";
            this.TextPassword.ShadowDecoration.Parent = this.TextPassword;
            this.TextPassword.Size = new System.Drawing.Size(361, 49);
            this.TextPassword.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.TextPassword.TabIndex = 13;
            this.TextPassword.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            this.TextPassword.IconRightClick += new System.EventHandler(this.guna2TextBox1_IconRightClick);
            this.TextPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextLogin_KeyDown);
            // 
            // PanelSV
            // 
            this.PanelSV.BackgroundColor = System.Drawing.Color.Transparent;
            this.PanelSV.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PanelSV.BackgroundImage")));
            this.PanelSV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelSV.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(208)))), ((int)(((byte)(213)))));
            this.PanelSV.BorderRadius = 10;
            this.PanelSV.BorderThickness = 2;
            this.PanelSV.Controls.Add(this.rdoSV);
            this.PanelSV.Controls.Add(this.LabelSinhVien);
            this.PanelSV.Location = new System.Drawing.Point(201, 250);
            this.PanelSV.Margin = new System.Windows.Forms.Padding(3, 0, 3, 15);
            this.PanelSV.Name = "PanelSV";
            this.PanelSV.ShowBorders = true;
            this.PanelSV.Size = new System.Drawing.Size(175, 50);
            this.PanelSV.TabIndex = 11;
            // 
            // rdoSV
            // 
            this.rdoSV.Animated = true;
            this.rdoSV.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdoSV.CheckedState.BorderThickness = 0;
            this.rdoSV.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdoSV.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdoSV.CheckedState.Parent = this.rdoSV;
            this.rdoSV.Location = new System.Drawing.Point(32, 14);
            this.rdoSV.Margin = new System.Windows.Forms.Padding(5, 3, 0, 15);
            this.rdoSV.Name = "rdoSV";
            this.rdoSV.ShadowDecoration.Parent = this.rdoSV;
            this.rdoSV.Size = new System.Drawing.Size(22, 22);
            this.rdoSV.TabIndex = 2;
            this.rdoSV.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdoSV.UncheckedState.BorderThickness = 2;
            this.rdoSV.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdoSV.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdoSV.UncheckedState.Parent = this.rdoSV;
            this.rdoSV.Click += new System.EventHandler(this.LabelSinhVien_Click);
            // 
            // LabelSinhVien
            // 
            this.LabelSinhVien.AutoSize = true;
            this.LabelSinhVien.Font = new System.Drawing.Font("Baloo 2", 10.8F);
            this.LabelSinhVien.Location = new System.Drawing.Point(57, 10);
            this.LabelSinhVien.Name = "LabelSinhVien";
            this.LabelSinhVien.Size = new System.Drawing.Size(86, 30);
            this.LabelSinhVien.TabIndex = 4;
            this.LabelSinhVien.Text = "Sinh viên";
            this.LabelSinhVien.Click += new System.EventHandler(this.LabelSinhVien_Click);
            // 
            // PanelGV
            // 
            this.PanelGV.BackgroundColor = System.Drawing.Color.Transparent;
            this.PanelGV.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PanelGV.BackgroundImage")));
            this.PanelGV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelGV.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(208)))), ((int)(((byte)(213)))));
            this.PanelGV.BorderRadius = 10;
            this.PanelGV.BorderThickness = 2;
            this.PanelGV.Controls.Add(this.rdoGV);
            this.PanelGV.Controls.Add(this.LabelGiangVien);
            this.PanelGV.Location = new System.Drawing.Point(15, 250);
            this.PanelGV.Margin = new System.Windows.Forms.Padding(3, 0, 10, 15);
            this.PanelGV.Name = "PanelGV";
            this.PanelGV.ShowBorders = true;
            this.PanelGV.Size = new System.Drawing.Size(175, 50);
            this.PanelGV.TabIndex = 11;
            // 
            // rdoGV
            // 
            this.rdoGV.Animated = true;
            this.rdoGV.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdoGV.CheckedState.BorderThickness = 0;
            this.rdoGV.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdoGV.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdoGV.CheckedState.Parent = this.rdoGV;
            this.rdoGV.Location = new System.Drawing.Point(26, 14);
            this.rdoGV.Margin = new System.Windows.Forms.Padding(5, 3, 0, 15);
            this.rdoGV.Name = "rdoGV";
            this.rdoGV.ShadowDecoration.Parent = this.rdoGV;
            this.rdoGV.Size = new System.Drawing.Size(22, 22);
            this.rdoGV.TabIndex = 2;
            this.rdoGV.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdoGV.UncheckedState.BorderThickness = 2;
            this.rdoGV.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdoGV.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdoGV.UncheckedState.Parent = this.rdoGV;
            this.rdoGV.Click += new System.EventHandler(this.LabelGiangVien_Click);
            // 
            // LabelGiangVien
            // 
            this.LabelGiangVien.AutoSize = true;
            this.LabelGiangVien.Font = new System.Drawing.Font("Baloo 2", 10.8F);
            this.LabelGiangVien.Location = new System.Drawing.Point(51, 10);
            this.LabelGiangVien.Name = "LabelGiangVien";
            this.LabelGiangVien.Size = new System.Drawing.Size(97, 30);
            this.LabelGiangVien.TabIndex = 4;
            this.LabelGiangVien.Text = "Giảng viên";
            this.LabelGiangVien.Click += new System.EventHandler(this.LabelGiangVien_Click);
            // 
            // FormLogin
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(70)))), ((int)(((byte)(68)))));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 584);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.Image = global::TracNghiemCSDLPT.Properties.Resources.CSDLPT_Logo1;
            this.MaximizeBox = false;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormLogin_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginEP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordEP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RdoEP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CSEP)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PanelSV.ResumeLayout(false);
            this.PanelSV.PerformLayout();
            this.PanelGV.ResumeLayout(false);
            this.PanelGV.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LabelGiangVien;
        private Guna.UI2.WinForms.Guna2CustomRadioButton rdoGV;
        private Bunifu.UI.WinForms.BunifuPanel PanelGV;
        private System.Windows.Forms.Label label2;
        private Bunifu.UI.WinForms.BunifuPanel PanelSV;
        private Guna.UI2.WinForms.Guna2CustomRadioButton rdoSV;
        private System.Windows.Forms.Label LabelSinhVien;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private System.Windows.Forms.ErrorProvider LoginEP;
        private System.Windows.Forms.ErrorProvider PasswordEP;
        private System.Windows.Forms.ErrorProvider RdoEP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider CSEP;
        private Guna.UI2.WinForms.Guna2TextBox TextPassword;
        private Guna.UI2.WinForms.Guna2TextBox TextLogin;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button buttonDangNhap;
        private Guna.UI2.WinForms.Guna2Button buttonThoat;
        private Guna.UI2.WinForms.Guna2ComboBox ComboBoxCoSo;
    }
}