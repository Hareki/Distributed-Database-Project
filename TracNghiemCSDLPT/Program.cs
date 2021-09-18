using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        public static string UserName;
        public static string HoTen;
        public static string Quyen;

        public static MainView FormMain;
        public static Login FormLogin;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FormLogin = new Login();
            Application.Run(FormLogin);
            
        }
    }
}
