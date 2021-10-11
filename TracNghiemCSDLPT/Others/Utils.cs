﻿using DevExpress.XtraEditors;
using System;
using System.Text.RegularExpressions;
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

            DialogResult result = MessageBox.Show(text, title, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes) return true;
            else return false;
        }
        public static void ShowMessage(string message, NotiForm.FormType type, int lineNum)
        {
            NotiForm frm = new NotiForm(message, type, lineNum);
        }

        public enum RegexType
        {
            LetterDigits, LetterOnly, LoginNameRegex
        }
        private static Regex LetterDigitsRegex = new Regex(@"^[\p{L}\s0-9]*$");
        private static Regex LetterOnlyRegex = new Regex(@"^[\p{L}\s]*$");
        private static Regex LoginNameRegex = new Regex(@"^[._A-Za-z0-9]*$");
        public static bool IsMathRegex(string testString, RegexType type)
        {
            switch (type)
            {
                case RegexType.LetterDigits:
                    return LetterDigitsRegex.IsMatch(testString);
                case RegexType.LetterOnly:
                    return LetterOnlyRegex.IsMatch(testString);
                case RegexType.LoginNameRegex:
                    return LoginNameRegex.IsMatch(testString);
                default:
                    return false;
            }
        }

        public enum CapitalMode
        {
            FirstWordOnly, EveryWord
        }
        public static string CapitalizeString(string name, CapitalMode mode)
        {
            string temp = Regex.Replace(name.Trim(), @"\s+", " ");
            if (temp.Equals("")) return "";
            if (mode == CapitalMode.FirstWordOnly)
                return temp.Substring(0, 1).ToUpper() + temp.Substring(1);
            else temp = temp.ToLower();

            string[] words = temp.Split(' ');
            string result = "";
            foreach (string word in words)
                result += word.Substring(0, 1).ToUpper() + word.Substring(1).ToLower() + " ";
            return result.Trim();
        }
        public static void SetTextEditError(ErrorProvider EP, TextEdit textEdit, string errorMessage)
        {
            textEdit.Properties.Appearance.Options.UseBorderColor = true;
            textEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            if (!(errorMessage is null))
            {
                textEdit.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(236, 65, 52);
                EP.SetError(textEdit, errorMessage);
            }
            else
            {
                textEdit.Properties.Appearance.BorderColor = System.Drawing.Color.Silver;
                EP.SetError(textEdit, null);
            }
        }

        public static bool inControl(Control control)
        {
            Console.WriteLine(control.ClientRectangle.Contains(control.PointToClient(Control.MousePosition)));
            return control.ClientRectangle.Contains(control.PointToClient(Control.MousePosition));
        }

        public static bool IsTruong()
        {
            return DBConnection.NhomQuyen.Equals("TRUONG");
        }
        public static bool isCoSo()
        {
            return DBConnection.NhomQuyen.Equals("COSO");
        }

    }
}
