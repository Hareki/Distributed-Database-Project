using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TracNghiemCSDLPT.Models
{
    public class SummaryItem
    {
        public int STT { get; set; }
        public string DaChon { get; set; }


        public SummaryItem(int stt, string daChon)
        {
            STT = stt;
            DaChon = daChon;
        }
        public SummaryItem() : base() { }
        
    }
}
