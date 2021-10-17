using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using TracNghiemCSDLPT.Others;

namespace TracNghiemCSDLPT
{
    class Utils
    {

        public readonly static Color AddColor = Color.FromArgb(45, 200, 110);
        public readonly static Color EditColor = Color.FromArgb(2, 163, 236);
        public readonly static Color ActiveColor = Color.FromArgb(72, 70, 68);
        public readonly static Color DisabledColor = SystemColors.AppWorkspace;
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
        private static Regex _letterDigitsRegex = new Regex(@"^[\p{L}\s0-9]*$");
        private static Regex _letterOnlyRegex = new Regex(@"^[\p{L}\s]*$");
        private static Regex _loginNameRegex = new Regex(@"^[._A-Za-z0-9]*$");
        public static bool IsMathRegex(string testString, RegexType type)
        {
            switch (type)
            {
                case RegexType.LetterDigits:
                    return _letterDigitsRegex.IsMatch(testString);
                case RegexType.LetterOnly:
                    return _letterOnlyRegex.IsMatch(testString);
                case RegexType.LoginNameRegex:
                    return _loginNameRegex.IsMatch(testString);
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
        public static void SetTextEditError(ErrorProvider ep, TextEdit textEdit, string errorMessage)
        {
            textEdit.Properties.Appearance.Options.UseBorderColor = true;
            textEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            if (!(errorMessage is null))
            {
                textEdit.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(236, 65, 52);
                ep.SetError(textEdit, errorMessage);
            }
            else
            {
                textEdit.Properties.Appearance.BorderColor = System.Drawing.Color.Silver;
                ep.SetError(textEdit, null);
            }
        }

        public static bool InControl(Control control)
        {
            Console.WriteLine(control.ClientRectangle.Contains(control.PointToClient(Control.MousePosition)));
            return control.ClientRectangle.Contains(control.PointToClient(Control.MousePosition));
        }

        public static bool IsTruong()
        {
            return DBConnection.NhomQuyen.Equals("TRUONG");
        }
        public static bool IsCoSo()
        {
            return DBConnection.NhomQuyen.Equals("COSO");
        }

        public static void BindingComboData(System.Windows.Forms.ComboBox coSoComboBox, int previousIndexCS)
        {
            coSoComboBox.DataSource = DBConnection.BsSubcribers;
            coSoComboBox.DisplayMember = "TENCS";
            coSoComboBox.ValueMember = "TENSERVER";
            coSoComboBox.SelectedIndex = DBConnection.IndexCS;
            previousIndexCS = coSoComboBox.SelectedIndex;
        }
        public static string GetCellValueBds(BindingSource bds, int rowIndex, string columnName)
        {
            return (bds[rowIndex] as DataRowView)[columnName].ToString();
        }
        public static void SetCellValueBds(BindingSource bds, int rowIndex, string columnName, object value)
        {
            ((DataRowView)bds[rowIndex])[columnName] = value;
        }
        public static void ConfigControlColor(GroupBox gb)
        {
            foreach (Control ctl in gb.Controls)
                ctl.ForeColor = SystemColors.ControlText;
        }
    }
}
