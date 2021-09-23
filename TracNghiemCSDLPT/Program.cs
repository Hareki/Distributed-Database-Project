using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TracNghiemCSDLPT.Others;
using TracNghiemCSDLPT.SQL_Connection;

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
            LoginInstance = new FormLogin();
            Application.Run(LoginInstance);
             //Application.Run(new Test());
        }
    }
}
