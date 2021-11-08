
namespace TracNghiemCSDLPT.MyForms.BaoCao
{
    partial class FormDSDKTTN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDSDKTTN));
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.CoSoComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.dateTo = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.dateFrom = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BorderRadius = 3;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.label2);
            this.bunifuPanel1.Controls.Add(this.CoSoComboBox);
            this.bunifuPanel1.Controls.Add(this.panel1);
            this.bunifuPanel1.Controls.Add(this.pictureBox1);
            this.bunifuPanel1.Location = new System.Drawing.Point(298, 52);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(1026, 708);
            this.bunifuPanel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Baloo 2", 10.8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(5, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 30);
            this.label2.TabIndex = 32;
            this.label2.Text = "Chọn cơ sở";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CoSoComboBox
            // 
            this.CoSoComboBox.BackColor = System.Drawing.Color.Transparent;
            this.CoSoComboBox.BorderRadius = 3;
            this.CoSoComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CoSoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CoSoComboBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(163)))), ((int)(((byte)(236)))));
            this.CoSoComboBox.FocusedColor = System.Drawing.Color.Empty;
            this.CoSoComboBox.FocusedState.Parent = this.CoSoComboBox;
            this.CoSoComboBox.Font = new System.Drawing.Font("Baloo 2", 12F, System.Drawing.FontStyle.Bold);
            this.CoSoComboBox.ForeColor = System.Drawing.Color.White;
            this.CoSoComboBox.FormattingEnabled = true;
            this.CoSoComboBox.HoverState.Parent = this.CoSoComboBox;
            this.CoSoComboBox.ItemHeight = 30;
            this.CoSoComboBox.ItemsAppearance.Parent = this.CoSoComboBox;
            this.CoSoComboBox.Location = new System.Drawing.Point(137, 16);
            this.CoSoComboBox.Name = "CoSoComboBox";
            this.CoSoComboBox.ShadowDecoration.Parent = this.CoSoComboBox;
            this.CoSoComboBox.Size = new System.Drawing.Size(286, 36);
            this.CoSoComboBox.TabIndex = 31;
            this.CoSoComboBox.SelectedIndexChanged += new System.EventHandler(this.CoSoComboBox_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.buttonCancel);
            this.panel1.Controls.Add(this.dateTo);
            this.panel1.Controls.Add(this.dateFrom);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.buttonPrint);
            this.panel1.Location = new System.Drawing.Point(10, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(535, 606);
            this.panel1.TabIndex = 1;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Font = new System.Drawing.Font("Baloo 2 SemiBold", 13.8F, System.Drawing.FontStyle.Bold);
            this.buttonCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonCancel.Location = new System.Drawing.Point(127, 422);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(287, 46);
            this.buttonCancel.TabIndex = 30;
            this.buttonCancel.Text = "Hủy";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // dateTo
            // 
            this.dateTo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateTo.BackColor = System.Drawing.Color.Transparent;
            this.dateTo.BorderColor = System.Drawing.Color.Silver;
            this.dateTo.BorderRadius = 1;
            this.dateTo.Color = System.Drawing.Color.Silver;
            this.dateTo.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
            this.dateTo.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.dateTo.DisabledColor = System.Drawing.Color.Gray;
            this.dateTo.DisplayWeekNumbers = false;
            this.dateTo.DPHeight = 0;
            this.dateTo.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dateTo.FillDatePicker = false;
            this.dateTo.Font = new System.Drawing.Font("Baloo 2", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTo.ForeColor = System.Drawing.Color.Black;
            this.dateTo.Icon = ((System.Drawing.Image)(resources.GetObject("dateTo.Icon")));
            this.dateTo.IconColor = System.Drawing.Color.Gray;
            this.dateTo.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.dateTo.LeftTextMargin = 5;
            this.dateTo.Location = new System.Drawing.Point(127, 278);
            this.dateTo.MinimumSize = new System.Drawing.Size(4, 32);
            this.dateTo.Name = "dateTo";
            this.dateTo.Size = new System.Drawing.Size(286, 44);
            this.dateTo.TabIndex = 29;
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
            this.dateFrom.Location = new System.Drawing.Point(127, 177);
            this.dateFrom.MinimumSize = new System.Drawing.Size(4, 32);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Size = new System.Drawing.Size(286, 44);
            this.dateFrom.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Baloo 2", 10.8F);
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(121, 240);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 11, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 30);
            this.label1.TabIndex = 28;
            this.label1.Text = "Đến ngày";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Baloo 2", 10.8F);
            this.label6.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label6.Location = new System.Drawing.Point(121, 139);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 0, 11, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 30);
            this.label6.TabIndex = 28;
            this.label6.Text = "Từ ngày";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.Font = new System.Drawing.Font("Baloo 2", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(190)))));
            this.label7.Location = new System.Drawing.Point(168, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(307, 93);
            this.label7.TabIndex = 25;
            this.label7.Text = "Danh sách đăng ký thi trắc nghiệm";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox2.Image = global::TracNghiemCSDLPT.Properties.Resources.logo31;
            this.pictureBox2.Location = new System.Drawing.Point(59, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(103, 65);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            // 
            // buttonPrint
            // 
            this.buttonPrint.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(163)))), ((int)(((byte)(236)))));
            this.buttonPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPrint.Font = new System.Drawing.Font("Baloo 2 SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrint.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonPrint.Location = new System.Drawing.Point(127, 348);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(287, 46);
            this.buttonPrint.TabIndex = 23;
            this.buttonPrint.Text = "In xem trước";
            this.buttonPrint.UseVisualStyleBackColor = false;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::TracNghiemCSDLPT.Properties.Resources.medical_history_doctor_svgrepo_com;
            this.pictureBox1.Location = new System.Drawing.Point(552, 77);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(471, 606);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FormDSDKTTN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1624, 813);
            this.Controls.Add(this.bunifuPanel1);
            this.Name = "FormDSDKTTN";
            this.Text = "Danh sách đăng ký thi TN";
            this.bunifuPanel1.ResumeLayout(false);
            this.bunifuPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private Bunifu.UI.WinForms.BunifuDatePicker dateTo;
        private Bunifu.UI.WinForms.BunifuDatePicker dateFrom;
        private System.Windows.Forms.Button buttonCancel;
        private Guna.UI2.WinForms.Guna2ComboBox CoSoComboBox;
        private System.Windows.Forms.Label label2;
    }
}