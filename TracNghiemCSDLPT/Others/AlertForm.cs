using System;
using System.Drawing;
using System.Windows.Forms;

namespace TracNghiemCSDLPT.Others
{
    public partial class NotiForm : Form
    {
        private readonly int _waitingTime = 3000;
        private FormAction _action;
        private int _x, _y;
        private FormType _type;
        private bool _forceClose = false;
        private readonly Size _origSize = new Size(410, 135);
        private readonly int _lineHeight = 35;
        private readonly int _manualLifting = 140;
        public static int Lifting = 0;
        private static int _notiNum = 0;
        public NotiForm()
        {
            InitializeComponent();
        }
        public NotiForm(String message, FormType type, int lineNum)
        {
            InitializeComponent();
            this.Size = new Size(410, 135 + (lineNum - 1) * _lineHeight);
            _notiNum++;
            ShowNoti(message, type, lineNum);
            Lifting += this.Height;


        }
        public enum FormAction
        {
            Start, Wait, Close
        }
        public enum FormType
        {
            Success, Warning, Error, Info
        }

        private bool InForm()
        {
            Point pos = Control.MousePosition;
            return (pos.X >= Left && pos.Y >= Top && pos.X < Right && pos.Y < Bottom);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (this._action)
            {
                case FormAction.Wait:
                    timer1.Interval = _waitingTime;
                    _action = FormAction.Close;
                    break;
                case FormAction.Start:
                    timer1.Interval = 1;
                    this.Opacity += 0.1;
                    if (this._x < this.Location.X)
                    {
                        this.Left--;
                    }
                    else
                    {
                        if (this.Opacity == 1.0)
                        {
                            _action = FormAction.Wait;
                        }
                    }
                    break;
                case FormAction.Close:
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
            this._forceClose = true;
            timer1.Interval = 1;
            _action = FormAction.Close;
        }

        private void NotiForm_MouseEnter(object sender, EventArgs e)
        {
            if (InForm() && _forceClose == false)
            {
                this.timer1.Stop();
                this.Opacity = 1.0;
            }
        }

        private void NotiForm_MouseLeave(object sender, EventArgs e)
        {
            if (!InForm() && _forceClose == false)
            {
                this.timer1.Interval = _waitingTime;
                this.timer1.Start();
                _action = FormAction.Close;
            }

        }
        private void GetLineNum(string message)
        {

        }

        private void NotiForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Lifting -= this.Height;
            _notiNum--;
        }

        private void ShowNoti(string message, FormType type, int lineNum)
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
                    this._x = Screen.PrimaryScreen.WorkingArea.Width - this.Width + 15;
                    if (_notiNum > i + 1)
                    {
                        this._y = Screen.PrimaryScreen.WorkingArea.Height - _manualLifting - (lineNum - 1) * _lineHeight;
                    }
                    else
                    {
                        this._y = Screen.PrimaryScreen.WorkingArea.Height - Lifting - 15 * i - _manualLifting - (lineNum - 1) * _lineHeight;
                    }

                    this.Location = new Point(this._x, this._y);
                    break;
                }
            }
            this._x = Screen.PrimaryScreen.WorkingArea.Width - base.Width - 5;

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
            this._action = FormAction.Start;
            this.timer1.Interval = 1;
            timer1.Start();
        }
    }
}
