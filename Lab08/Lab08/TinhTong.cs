using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08
{
    public static class TinhTong
    {
        public static int TinhTongN(int n)
        {
            if(n < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            if(n > 1000)
            {
                throw new ArgumentOutOfRangeException();
            }

            int tong = 0;
            for (int i = 1; i <= n; i++)
            {
                tong += i;
            }
            return tong;
        }
    }
}
