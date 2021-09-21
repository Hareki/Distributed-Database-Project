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
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
        }
        public static int time;

        private void button1_Click(object sender, EventArgs e)
        {
            NotiForm frm = new NotiForm("Đăng nhập thành công",NotiForm.FormType.Success);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NotiForm frm = new NotiForm("Đăng nhập thành công", NotiForm.FormType.Error);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NotiForm frm = new NotiForm("Đăng nhập thành công", NotiForm.FormType.Warning);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            NotiForm frm = new NotiForm("Đăng nhập thành công", NotiForm.FormType.Info);
        }

        private void showTime_Click(object sender, EventArgs e)
        {
            Console.WriteLine("time: " + time);
        }
    }
}
