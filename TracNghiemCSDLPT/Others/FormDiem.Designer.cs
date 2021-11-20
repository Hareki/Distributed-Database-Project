
namespace TracNghiemCSDLPT.Others
{
    partial class FormDiem
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
            this.message = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureClose = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDiem = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.btnConfirm = new Guna.UI2.WinForms.Guna2Button();
            this.lblSoCauDung = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // message
            // 
            this.message.AutoSize = true;
            this.message.Font = new System.Drawing.Font("Baloo 2", 16.2F);
            this.message.ForeColor = System.Drawing.Color.White;
            this.message.Location = new System.Drawing.Point(85, 58);
            this.message.MaximumSize = new System.Drawing.Size(570, 0);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(209, 45);
            this.message.TabIndex = 5;
            this.message.Text = "Hoàn tất bài thi!";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(493, 38);
            this.panel1.TabIndex = 6;
            // 
            // pictureClose
            // 
            this.pictureClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureClose.Image = global::TracNghiemCSDLPT.Properties.Resources.cancel_35px;
            this.pictureClose.Location = new System.Drawing.Point(451, 3);
            this.pictureClose.Name = "pictureClose";
            this.pictureClose.Size = new System.Drawing.Size(39, 40);
            this.pictureClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureClose.TabIndex = 7;
            this.pictureClose.TabStop = false;
            this.pictureClose.Click += new System.EventHandler(this.pictureClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Baloo 2", 16.2F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(85, 111);
            this.label1.MaximumSize = new System.Drawing.Size(570, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 45);
            this.label1.TabIndex = 7;
            this.label1.Text = "Bạn đã trả lời đúng";
            // 
            // lblDiem
            // 
            this.lblDiem.AutoSize = true;
            this.lblDiem.Font = new System.Drawing.Font("Baloo 2", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(255)))), ((int)(((byte)(183)))));
            this.lblDiem.Location = new System.Drawing.Point(85, 166);
            this.lblDiem.MaximumSize = new System.Drawing.Size(570, 0);
            this.lblDiem.Name = "lblDiem";
            this.lblDiem.Size = new System.Drawing.Size(130, 43);
            this.lblDiem.TabIndex = 8;
            this.lblDiem.Text = "Điểm: 8.5";
            // 
            // pictureBox
            // 
            this.pictureBox.Image = global::TracNghiemCSDLPT.Properties.Resources.ok_45px;
            this.pictureBox.Location = new System.Drawing.Point(12, 58);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(52, 56);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 9;
            this.pictureBox.TabStop = false;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnConfirm.BorderRadius = 10;
            this.btnConfirm.CheckedState.Parent = this.btnConfirm;
            this.btnConfirm.CustomImages.Parent = this.btnConfirm;
            this.btnConfirm.FillColor = System.Drawing.Color.White;
            this.btnConfirm.Font = new System.Drawing.Font("Baloo 2", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(164)))), ((int)(((byte)(236)))));
            this.btnConfirm.HoverState.Parent = this.btnConfirm;
            this.btnConfirm.Location = new System.Drawing.Point(186, 212);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.ShadowDecoration.Parent = this.btnConfirm;
            this.btnConfirm.Size = new System.Drawing.Size(121, 41);
            this.btnConfirm.TabIndex = 10;
            this.btnConfirm.Text = "Xác nhận";
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // lblSoCauDung
            // 
            this.lblSoCauDung.AutoSize = true;
            this.lblSoCauDung.Font = new System.Drawing.Font("Baloo 2", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoCauDung.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(255)))), ((int)(((byte)(183)))));
            this.lblSoCauDung.Location = new System.Drawing.Point(335, 112);
            this.lblSoCauDung.MaximumSize = new System.Drawing.Size(570, 0);
            this.lblSoCauDung.Name = "lblSoCauDung";
            this.lblSoCauDung.Size = new System.Drawing.Size(135, 43);
            this.lblSoCauDung.TabIndex = 11;
            this.lblSoCauDung.Text = "35/40 câu";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // FormDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(164)))), ((int)(((byte)(236)))));
            this.ClientSize = new System.Drawing.Size(493, 262);
            this.Controls.Add(this.lblSoCauDung);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.lblDiem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.message);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDiem";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label message;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDiem;
        private System.Windows.Forms.PictureBox pictureBox;
        private Guna.UI2.WinForms.Guna2Button btnConfirm;
        private System.Windows.Forms.Label lblSoCauDung;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}