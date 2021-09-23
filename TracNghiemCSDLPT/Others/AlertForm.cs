using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TracNghiemCSDLPT.Others
{
    public partial class NotiForm : Form
    {
        private readonly int waitingTime = 5000;
        private FormAction action;
        private int x, y;
        private FormType type;
        private bool forceClose = false;
        private readonly Size origSize = new Size(410, 135);
        private readonly int lineHeight = 35;
        private readonly int manualLifting = 140;
        public static int Lifting = 0;
        private static int NotiNum = 0;
        public NotiForm()
        {
            InitializeComponent();
        }
        public NotiForm(String message, FormType type, int lineNum)
        {
            InitializeComponent();
            this.Size = new Size(410, 135 + (lineNum - 1) * lineHeight);
            NotiNum++;
            showNoti(message, type, lineNum);
            Lifting += this.Height;
            
            
        }
        public enum FormAction
        {
            start, wait, close
        }
        public enum FormType
        {
            Success, Warning, Error, Info
        }

        private bool inForm()
        {
            Point pos = Control.MousePosition;
            return (pos.X >= Left && pos.Y >= Top && pos.X < Right && pos.Y < Bottom);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (this.action)
            {
                case FormAction.wait:
                    timer1.Interval = waitingTime;
                    action = FormAction.close;
                    break;
                case FormAction.start:
                    timer1.Interval = 1;
                    this.Opacity += 0.1;
                    if (this.x < this.Location.X)
                    {
                        this.Left--;
                    }
                    else
                    {
                        if (this.Opacity == 1.0)
                        {
                            action = FormAction.wait;
                        }
                    }
                    break;
                case FormAction.close:
                    timer1.Interval = 1;
                    this.Opacity -= 0.1;
                    this.Left -= 3;
                    if (this.Opacity == 0.0)
                    {
                        this.Close();
                    }
                    break;
            }
        }

        private void PictureClose_Click(object sender, EventArgs e)
        {
            timer1.Start();
            this.forceClose = true;
            timer1.Interval = 1;
            action = FormAction.close;
        }

        private void NotiForm_MouseEnter(object sender, EventArgs e)
        {
            if (inForm() && forceClose == false)
            {
                this.timer1.Stop();
                this.Opacity = 1.0;
            }
        }

        private void NotiForm_MouseLeave(object sender, EventArgs e)
        {
            if (!inForm() && forceClose == false)
            {
                this.timer1.Interval = 5000;
                this.timer1.Start();
                action = FormAction.close;
            }

        }
        private void GetLineNum(string message)
        {

        }

        private void NotiForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Lifting -= this.Height;
            NotiNum--;
        }

        private void showNoti(string message, FormType type, int lineNum)
        {
            this.Opacity = 0.0;
            this.StartPosition = FormStartPosition.Manual;
            string fname;

            for (int i = 0; i < 10; i++)
            {
                fname = "noti" + i.ToString();
                NotiForm frm = (NotiForm)Application.OpenForms[fname];
                if (frm == null)
                {
                    
                    this.Name = fname;
                    this.x = Screen.PrimaryScreen.WorkingArea.Width - this.Width + 15;
                    if (NotiNum > i + 1)
                    {
                        this.y = Screen.PrimaryScreen.WorkingArea.Height - manualLifting - (lineNum - 1) * lineHeight;
                    }
                    else
                    {
                        this.y = Screen.PrimaryScreen.WorkingArea.Height - Lifting - 15 * i - manualLifting - (lineNum - 1) * lineHeight;
                    }
                    
                    this.Location = new Point(this.x, this.y);
                    break;
                }
            }
            this.x = Screen.PrimaryScreen.WorkingArea.Width - base.Width - 5;

            switch (type)
            {
                case FormType.Success:
                    this.pictureBox.Image = global::TracNghiemCSDLPT.Properties.Resources.ok_45px;
                    this.BackColor = Color.SeaGreen;
                    break;
                case FormType.Error:
                    this.pictureBox.Image = global::TracNghiemCSDLPT.Properties.Resources.error_45px;
                    this.BackColor = Color.FromArgb(226, 54, 54);
                    break;
                case FormType.Info:
                    this.pictureBox.Image = global::TracNghiemCSDLPT.Properties.Resources.info_45px;
                    this.BackColor = Color.RoyalBlue;
                    break;
                case FormType.Warning:
                    this.pictureBox.Image = global::TracNghiemCSDLPT.Properties.Resources.warning_shield_45px;
                    this.BackColor = Color.DarkOrange;
                    break;


            }

            this.message.Text = message;
            this.Show();
            this.action = FormAction.start;
            this.timer1.Interval = 1;
            timer1.Start();
        }
    }
}
