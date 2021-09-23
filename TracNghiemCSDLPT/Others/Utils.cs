using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using TracNghiemCSDLPT.Others;

namespace TracNghiemCSDLPT
{
    class Utils
    {
        public static void ShowErrorMessage(string text, string title)
        {
            MessageBox.Show(text, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static bool ShowConfirmMessage(string text, string title)
        {

            DialogResult result = MessageBox.Show(text, title, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes) return true;
            else return false;
        }
        public static void ShowMessage(string message, NotiForm.FormType type, int lineNum)
        {
            NotiForm frm = new NotiForm(message, type, lineNum);
        }
        public static bool  HaveOnlyLettersAndDigits(string nameWithDigits)
        {
            return new Regex(@"^[\p{L}\s0-9]*$").IsMatch(nameWithDigits);
        }
    }
}
