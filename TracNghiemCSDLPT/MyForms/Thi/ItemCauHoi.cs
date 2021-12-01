﻿using Guna.UI2.WinForms;
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
            InitRdoList();
        }
        public ItemCauHoi(FormThi parentThi)
        {
            InitializeComponent();
            InitRdoList();
            ParentThi = parentThi;
        }

        //thực thể của bài thi, kèm thông tin của câu hỏi hiện lên cho ng` dùng làm bài
        private int _stt; // mã stt của câu đó
        private int _maCauHoi; // mã thực của câu đó trong Db
        private string _maBangDiem; // mã bảng điểm mà câu hỏi (với bài làm) này thuộc về
        private string _ndCauHoi;
        private string _ndCauA;
        private string _ndCauB;
        private string _ndCauC;
        private string _ndCauD;
        private string _daChon = "";
        private string _dapAn = "";
        private FormThi _parentThi;

        public FormThi ParentThi
        {
            get { return _parentThi; }
            set
            {
                _parentThi = value;
            }
        }



        private Guna2CustomRadioButton[] _rdoList = new Guna2CustomRadioButton[4];
        private void InitRdoList()
        {
            _rdoList[0] = rdoA;
            _rdoList[1] = rdoB;
            _rdoList[2] = rdoC;
            _rdoList[3] = rdoD;

        }
        private void UncheckAllOtherRdos(Guna2CustomRadioButton rdo)
        {
            for (int i = 0; i < _rdoList.Length; i++)
            {
                if (_rdoList[i] != rdo)
                {
                    _rdoList[i].Checked = false;
                }
            }
        }
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
        public string MaBangDiem
        {
            get { return _maBangDiem; }
            set { _maBangDiem = value; }
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
        public int ContentHeight
        {
            get { return flowLayoutPanel1.Size.Height; }
            set
            { flowLayoutPanel1.Height = value; }
        }
        private void ItemCauHoi_Load(object sender, EventArgs e)
        {

        }

        private void Rdo_CheckedChanged(object sender, EventArgs e)
        {
            Guna2CustomRadioButton rdo = sender as Guna2CustomRadioButton;
            if (rdo.Checked)
            {
                UncheckAllOtherRdos(rdo);
                string daChon = rdo.Tag.ToString();
                ParentThi.UpdateSummaryTable(STT, daChon);
                ParentThi.UpdateBTDLChiTiet(_maBangDiem, STT, daChon);
                this.DaChon = daChon;
            }

        }
    }

}
