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
        private string stringTest;
        public Test()
        {
            InitializeComponent();
          //  Console.WriteLine(Utils.CapitalizeString(test, Utils.CapitalMode.EveryWord));
         //   Console.WriteLine(test);
        }
        public static int time;

        private void button1_Click(object sender, EventArgs e)
        {
            NotiForm frm = new NotiForm("Kết nối đến CSDL thất bại. " +
                     "Vui lòng xem lại tên server và tên CSDL ", NotiForm.FormType.Success,4);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NotiForm frm = new NotiForm("aaaaaaaaaaaaaaaaaa", NotiForm.FormType.Error,1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NotiForm frm = new NotiForm("Đăng nhập thành công\n Dòng 3 là đây\n Dòng 3 là đây", NotiForm.FormType.Warning,3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            NotiForm frm = new NotiForm("Đăng nhập thành công", NotiForm.FormType.Info,1);
        }

        private void showTime_Click(object sender, EventArgs e)
        {
            
        }
    }
}
