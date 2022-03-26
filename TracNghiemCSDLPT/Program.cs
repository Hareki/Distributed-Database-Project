using System;
using System.Windows.Forms;
using TracNghiemCSDLPT.MyForms;
using TracNghiemCSDLPT.MyForms.QuanLy;
using TracNghiemCSDLPT.MyForms.Thi;
using TracNghiemCSDLPT.Others;

namespace TracNghiemCSDLPT
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        public static MainView MainInstance;
        public static FormLogin LoginInstance;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //LoginInstance = new FormLogin();
            Application.Run(new FormCauHoi());
            //  Application.Run(new Test());
            //  Application.Run(new FormThi());
        }
    }
}
