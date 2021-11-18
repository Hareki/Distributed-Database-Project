using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TracNghiemCSDLPT.MyForms.Thi
{
    public partial class FormThi : DevExpress.XtraEditors.XtraForm
    {
        public FormThi()
        {
            InitializeComponent();
            
        }

        private void test()
        {
            ItemCauHoi[] items = new ItemCauHoi[2];
            for (int i = 0; i < items.Length; i++)
            {
                if(i == 0)
                {
                    items[i] = new ItemCauHoi();
                    items[i].IDBaiThi = 1;
                    items[i].STT = 1;
                    items[i].NDCauHoi = "Lorem ipsum dol";
                    items[i].NDCauA = "I will give yo will give yo will give yo will give you a complete account of the system, and expound the actual teachings of the great explorer of the truth, the master-builder ";
                    items[i].NDCauB = "Our studies shOur studies shOur studies show that increases in worker productivity have not been adequately ...... rewarded by significant increases in .......";
                    items[i].NDCauC = "I will give you a cI will give you a cI will give you a complete account of the system, and expound the actual teachings of the great explorer of the truth, the master-builder ";
                    items[i].NDCauD = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nosLorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nos";

                    items[i].DaChon = "C";
                    items[i].DapAn = "B";
                    items[i].Width = flowLayoutPanel1.Size.Width - 50;
                    items[i].Height = items[i].ContentHeight + 40;
                }
                else
                {
                    items[i] = new ItemCauHoi();
                    items[i].IDBaiThi = 1;
                    items[i].STT = 1;
                    items[i].NDCauHoi = "Lorem ipsum dol";
                    items[i].NDCauA = "bbb";
                    items[i].NDCauB = "12f";
                    items[i].NDCauC = "dddd";
                    items[i].NDCauD = "asd";

                    items[i].DaChon = "C";
                    items[i].DapAn = "B";
                    items[i].Width = flowLayoutPanel1.Size.Width - 50;
                    items[i].Height = items[i].ContentHeight + 40;
                }
                

                flowLayoutPanel1.Controls.Add(items[i]);
            }
        }


        private void buttonThem_Click(object sender, EventArgs e)
        {
            test();
        }
    }
}