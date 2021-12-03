using Bunifu.UI.WinForms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
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
        public static void ShowWarningMessage(string text, string title)
        {
            MessageBox.Show(text, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static bool ShowConfirmMessage(string text, string title)
        {

            //DialogResult result = MessageBox.Show(text, title, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            //if (result == DialogResult.Yes) return true;
            //else return false;
            ConfirmForm confirmForm = new ConfirmForm(text, title);
            return confirmForm.Confirmed;
        }
        public static void ShowMessage(string message, NotiForm.FormType type, int lineNum)
        {
            NotiForm frm = new NotiForm(message, type, lineNum);
        }

        public enum RegexType
        {
            LetterDigits, LetterOnly, LoginNameRegex, IDRegex
        }
        private static Regex _letterDigitsRegex = new Regex(@"^[\p{L}\s0-9]*$");
        private static Regex _letterOnlyRegex = new Regex(@"^[\p{L}\s]*$");
        private static Regex _loginNameRegex = new Regex(@"^[._A-Za-z0-9]*$");
        private static Regex _idRegex = new Regex(@"^[A-Za-z0-9]*$");
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
                case RegexType.IDRegex:
                    return _idRegex.IsMatch(testString);
                default:
                    return false;
            }
        }

        public enum CapitalMode
        {
            FirstWordOnly, EveryWord//every word = chuẩn hóa tên riêng, chỉ cho phép viết hoa đầu mỗi từ, FirstWord only = chuẩn hóa chính tả, viết hoa chữ cái đầu của string
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
        public static void SetTextEditError(ErrorProvider ep, BaseEdit textEdit, string errorMessage)
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
        public static string GetCellStringBds(BindingSource bds, int rowIndex, string columnName)
        {
            return (bds[rowIndex] as DataRowView)[columnName].ToString();
        }
        public static object GetCellValueBds(BindingSource bds, int rowIndex, string columnName)
        {
            return (bds[rowIndex] as DataRowView)[columnName];
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
        public static void SetCustomizationEnabled(GridView gridView1, bool enabled)
        {
            gridView1.OptionsCustomization.AllowSort = enabled;
            gridView1.OptionsCustomization.AllowFilter = enabled;
            gridView1.OptionsCustomization.AllowGroup = enabled;
            gridView1.ActiveFilter.Clear();
            gridView1.ClearSorting();
            gridView1.ClearGrouping();
            gridView1.ClearColumnsFilter();
            foreach (GridColumn column in gridView1.Columns)
            {
                column.Visible = true;
            }

        }
        public static void ConfigInfoPanelAppearance(BunifuGroupBox infoPanel, string text, Color color)
        {
            infoPanel.Text = text;
            infoPanel.BorderColor = color;
            infoPanel.ForeColor = color;
        }

        public static string GetLookUpValue(GridLookUpEdit lookUp, string columnName)
        {
            if (lookUp.GetSelectedDataRow() != null)
                return (lookUp.GetSelectedDataRow() as DataRowView)[columnName].ToString().Trim();
            else return string.Empty;
        }
    }
}
