using Bunifu.Framework.UI;
using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Bunifu.UI.WinForms.BunifuButton;
using Guna.UI2.WinForms;

namespace DDBProject.Views
{
    public partial class mainFrame : KryptonForm
    {
        private  Guna2Button selectedButton;
        private static readonly Color SELECTING_BACKCOLOR = Color.FromArgb(241, 244, 255);
        private static readonly Color NOT_SELECTING_BACKCOLOR = Color.FromArgb(250, 252, 252);
        private static readonly Color SELECTING_FORECOLOR = Color.FromArgb(91, 107, 200);
        private static readonly Color NOT_SELECTING_FORECOLOR = Color.FromArgb(127, 130, 143);
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );
        
        public mainFrame()
        {
            InitializeComponent();
            customizeUI();
        }
        private void customizeUI()
        {
            panelMainView.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelMainView.Width,
            panelMainView.Height, 50, 50));

            panelAccount.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelAccount.Width,
            panelAccount.Height, 50, 50));

            selectedButton = buttonQuanLy;


            

        }


        private void panelMainView_SizeChanged(object sender, EventArgs e)
        {
            panelMainView.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelMainView.Width,
            panelMainView.Height, 50, 50));
        }
    }
}
