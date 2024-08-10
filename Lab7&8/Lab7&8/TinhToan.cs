using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_8
{
    public class TinhToan
    {
        public static int Chia(int a, int b)
        {
            if (b == 0)
                throw new DivideByZeroException("Không thể chia cho 0.");

            return a / b;
        }

        public static int Nhan(int a , int b)
        {
            if(a > 100 || b > 100)
            {
                throw new ArgumentOutOfRangeException();
            }

            if(a < 0 || b < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            return a * b;
        }
    }
}
