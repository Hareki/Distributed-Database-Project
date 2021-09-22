using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TracNghiemCSDLPT.Others;

namespace TracNghiemCSDLPT
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        public static BindingSource BS_Subcribers = new BindingSource();
        public static string LoginName;
        public static string Password;
        public static string SubcriberName;
        public static string UserName; // aka MaGV
        public static string HoTen; // Ten GV
        public static string NhomQuyen; 

        public static MainView MainInstance;
        public static FormLogin LoginInstance;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            LoginInstance = new FormLogin();
            Application.Run(LoginInstance);  
           // Application.Run(new Test());
        }
    }
}
