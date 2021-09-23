﻿using System;
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

        public enum RegexType
        {
            LetterDigits, LetterOnly
        }
        private static Regex LetterDigitsRegex = new Regex(@"^[\p{L}\s0-9]*$");
        private static Regex LetterOnlyRegex = new Regex(@"^[\p{L}\s]*$");
        public static bool IsMathRegex(string testString, RegexType type)
        {
            switch (type)
            {
                case RegexType.LetterDigits:
                    return LetterDigitsRegex.IsMatch(testString);
                case RegexType.LetterOnly:
                    return LetterOnlyRegex.IsMatch(testString);
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

        public static string CapitalizeString2(string name, CapitalMode mode)
        {
            name = "hahaha";
            string temp = Regex.Replace(name.Trim(), @"\s+", " ");
            if (mode == CapitalMode.FirstWordOnly)
                return temp.Substring(0, 1).ToUpper() + temp.Substring(1);
            else temp = temp.ToLower();

            string[] words = temp.Split(' ');
            string result = "";
            foreach (string word in words)
                result += word.Substring(0, 1).ToUpper() + word.Substring(1).ToLower() + " ";
            return result.Trim();
        }
    }
}
