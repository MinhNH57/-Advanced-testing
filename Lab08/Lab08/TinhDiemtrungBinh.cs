using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08
{
    public static class TinhDiemtrungBinh
    {
        public static float TinhDiemTrungBinh(float t , float l , float h , int a)
        {
            if(a == 0)
            {
                throw new ArgumentException();
            }

            if(a < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            if(a > 3 )
            {
                throw new ArgumentOutOfRangeException();
            }

            if(t > 10 || l > 10 || h > 10)
            {
                throw new ArgumentOutOfRangeException();
            }

            if(t < 0 || l < 0 || h < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            float tb = (t + l + h) / a;
            return tb;
        }
    }
}
