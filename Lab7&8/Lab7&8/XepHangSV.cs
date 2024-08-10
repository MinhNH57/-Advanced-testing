using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_8
{
    public class XepHangSV
    {
        public static string XepHangSinhVien(float diemSo)
        {
            if(diemSo < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            if(diemSo > 100)
            {
                throw new ArgumentException();
            }
            if(diemSo > 0 && diemSo < 40)
            {
                return "F";
            }

            else if(diemSo > 41 && diemSo < 60)
            {
                return "D";
            }
            
            else if(diemSo > 61 && diemSo < 70)
            {
                return "C";
            }

            else if(diemSo > 71 && diemSo < 80)
            {
                return "B";
            }

            else if(diemSo > 81 || diemSo == 100)
            {
                return "A";
            }
            return "Khong xac dinh";
        }
    }
}
