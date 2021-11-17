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
    public partial class ItemCauHoi : UserControl
    {
        public ItemCauHoi()
        {
            InitializeComponent();
        }

        private int _stt; // mã stt của câu đó
        private int _maCauHoi; // mã thực của câu đó trong Db
        private int _idBaiThi; // bài thi mà câu hỏi này thuộc về
        private string _ndCauHoi;
        private string _ndCauA;
        private string _ndCauB;
        private string _ndCauC;
        private string _ndCauD;
        private string _daChon = "";
        private string _dapAn = "";

        public int STT
        {
            get { return _stt; }
            set
            {
                _stt = value;
                lblSTT.Text = "Câu số: " + value;
            }
        }

        public int MaCauHoi
        {
            get { return _maCauHoi; }
            set { _maCauHoi = value; }
        }
        public int IDBaiThi
        {
            get { return _idBaiThi; }
            set { _idBaiThi = value; }
        }
        public string NDCauHoi
        {
            get { return _ndCauHoi; }
            set
            {
                _ndCauHoi = value;
                lblNDCH.Text = value;
            }
        }
        public string NDCauA
        {
            get { return _ndCauA; }
            set
            {
                _ndCauA = value;
                lblCA.Text = value;
            }
        }
        public string NDCauB
        {
            get { return _ndCauB; }
            set
            {
                _ndCauB = value;
                lblCB.Text = value;
            }
        }
        public string NDCauC
        {
            get { return _ndCauC; }
            set
            {
                _ndCauC = value;
                lblCC.Text = value;
            }
        }
        public string NDCauD
        {
            get { return _ndCauD; }
            set
            {
                _ndCauD = value;
                lblCD.Text = value;
            }
        }

        public string DapAn
        {
            get { return _dapAn; }
            set
            { _dapAn = value; }
        }

        public string DaChon
        {
            get { return _daChon; }
            set
            { _daChon = value; }
        }
        private void ItemCauHoi_Load(object sender, EventArgs e)
        {

        }
    }
}
