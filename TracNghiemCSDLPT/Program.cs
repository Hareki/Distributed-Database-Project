﻿using System;
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

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainView());
            
        }
    }
}
