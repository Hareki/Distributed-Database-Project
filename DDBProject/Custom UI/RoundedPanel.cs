using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace DDBProject.Views.Custom_UI
{
    class RoundedPanel
    {
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
        public static void Reshape(Control panel)
        {
            panel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel.Width,
            panel.Height, 50, 50));
        }
    }
}
