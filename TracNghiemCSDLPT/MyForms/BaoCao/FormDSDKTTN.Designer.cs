
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDSDKTTN));
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dateFrom = new DevExpress.XtraEditors.DateEdit();
            this.dateTo = new DevExpress.XtraEditors.DateEdit();
            this.dateEP = new System.Windows.Forms.ErrorProvider(this.components);
            this.bunifuPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFrom.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTo.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEP)).BeginInit();
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
            this.bunifuPanel1.Controls.Add(this.panel1);
            this.bunifuPanel1.Controls.Add(this.pictureBox1);
            this.bunifuPanel1.Location = new System.Drawing.Point(298, 52);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(1026, 708);
            this.bunifuPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.dateTo);
            this.panel1.Controls.Add(this.dateFrom);
            this.panel1.Controls.Add(this.buttonCancel);
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
            this.buttonCancel.Location = new System.Drawing.Point(126, 436);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(287, 46);
            this.buttonCancel.TabIndex = 30;
            this.buttonCancel.Text = "Hủy";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
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
            this.label7.Location = new System.Drawing.Point(157, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(329, 94);
            this.label7.TabIndex = 25;
            this.label7.Text = "Danh sách đăng ký thi trắc nghiệm của 2 cơ sở\r\n";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox2.Image = global::TracNghiemCSDLPT.Properties.Resources.logo31;
            this.pictureBox2.Location = new System.Drawing.Point(48, 5);
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
            this.buttonPrint.Location = new System.Drawing.Point(126, 362);
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
            // dateFrom
            // 
            this.dateFrom.EditValue = new System.DateTime(2021, 11, 23, 20, 51, 50, 0);
            this.dateFrom.Location = new System.Drawing.Point(127, 177);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.dateFrom.Properties.Appearance.Font = new System.Drawing.Font("Baloo 2", 13.8F);
            this.dateFrom.Properties.Appearance.Options.UseFont = true;
            this.dateFrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateFrom.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateFrom.Size = new System.Drawing.Size(287, 44);
            this.dateFrom.TabIndex = 31;
            // 
            // dateTo
            // 
            this.dateTo.EditValue = new System.DateTime(2021, 11, 23, 20, 52, 9, 0);
            this.dateTo.Location = new System.Drawing.Point(127, 293);
            this.dateTo.Name = "dateTo";
            this.dateTo.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.dateTo.Properties.Appearance.Font = new System.Drawing.Font("Baloo 2", 13.8F);
            this.dateTo.Properties.Appearance.Options.UseFont = true;
            this.dateTo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateTo.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateTo.Size = new System.Drawing.Size(287, 44);
            this.dateTo.TabIndex = 32;
            // 
            // dateEP
            // 
            this.dateEP.ContainerControl = this;
            this.dateEP.Icon = ((System.Drawing.Icon)(resources.GetObject("dateEP.Icon")));
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFrom.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTo.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEP)).EndInit();
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
        private System.Windows.Forms.Button buttonCancel;
        private DevExpress.XtraEditors.DateEdit dateTo;
        private DevExpress.XtraEditors.DateEdit dateFrom;
        private System.Windows.Forms.ErrorProvider dateEP;
    }
}