using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_8
{
    public class BaiHat
    {
        //Tạo class BaiHat gồm các thuộc tính: id  - String, ten - String, tenCaSi - String, doDai - int, tenNhacSi - String và các constructor getter setter(1 điểm)
        public string ID { get; set; }
        public string ten { get; set; }
        public string tenCaSi { get; set; }
        public string tenNhacSi { get; set; }
        public int doDai { get; set; }

        public BaiHat()
        {

        }

        public BaiHat(string iD, string ten, string tenCaSi, string tenNhacSi, int doDai)
        {
            ID = iD;
            this.ten = ten;
            this.tenCaSi = tenCaSi;
            this.tenNhacSi = tenNhacSi;
            this.doDai = doDai;
        }
    }
}
