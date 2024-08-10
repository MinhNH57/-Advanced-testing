using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class TinhsToan
    {
        public static int TinhTong(object a, object b)
        {
            if (!(a is int) || !(b is int))
            {
                throw new ArgumentException("Cả hai giá trị phải là số nguyên");
            }

            return (int)a + (int)b;
        }

        public static int TinhTich(int a , int b)
        {
            return a * b;
        }

        public static int GiaiThua(int a)
        {
            int giaiThua = 1;
            for (int i = 1; i <= a; i++)
            {
                giaiThua *= i;
            }
            return giaiThua;
        }

        public static int Chia(int a, int b)
        {
            if (b == 0)
                throw new DivideByZeroException("Không thể chia cho 0.");

            return a / b;
        }

        public static double TinhTrungBinh(List<double> numbers)
        {
            if (numbers == null || numbers.Count == 0)
            {
                throw new ArithmeticException("Không thể tính trung bình cho danh sách rỗng.");
            }

            return numbers.Average();
        }

        public static int GetElementAtIndex(int[] array, int index)
        {
            if (index < 0 || index >= array.Length)
            {
                throw new IndexOutOfRangeException("Chỉ mục nằm ngoài phạm vi của mảng.");
            }
            return array[index];
        }
    }
}
