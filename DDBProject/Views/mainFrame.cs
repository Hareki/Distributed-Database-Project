using ComponentFactory.Krypton.Toolkit;
using DDBProject.Views.Custom_UI;
using Guna.UI2.WinForms;
using System;
using System.Drawing;

namespace DDBProject.Views
{
    public partial class MainFrame : KryptonForm
    {
        private Guna2Button selectedButton;
        private static readonly Color SELECTING_BACKCOLOR = Color.FromArgb(241, 244, 255);
        private static readonly Color NOT_SELECTING_BACKCOLOR = Color.FromArgb(250, 252, 252);
        private static readonly Color SELECTING_FORECOLOR = Color.FromArgb(91, 107, 200);
        private static readonly Color NOT_SELECTING_FORECOLOR = Color.FromArgb(127, 130, 143);


        public MainFrame()
        {
            InitializeComponent();
            customizeUI();
        }


        private void customizeUI()
        {
            RoundedPanel.Reshape(panelMainView);
            RoundedPanel.Reshape(panelAccount);

            selectedButton = buttonQuanLy;
            panelMainView.Transition.MaxTime = 0.5F;
        }



        private void buttonQuanLy_Click(object sender, EventArgs e)
        {
            selectedButton = (Guna2Button)sender;
            panelMainView.SetPage(((Guna2Button)sender).Name.Substring(6));
        }



        private void panelMainView_SizeChanged(object sender, EventArgs e)
        {
            RoundedPanel.Reshape(panelMainView);
        }
    }
}
