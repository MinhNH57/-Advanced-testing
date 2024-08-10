using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace KiemThuDeMau
{
    public static class TinhTongArr
    {
        public static int TinhTong(int[] arr)
        {
            if(arr == null || arr.Length == 0)
            {
                throw new ArgumentNullException();
            }

            if(arr.Length > 5)
            {
                throw new ArgumentOutOfRangeException();
            }

            if(arr.Length < 2 )
            {
                throw new ArgumentOutOfRangeException();
            }

            return arr.Sum();
        }
    }
}
