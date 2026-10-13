using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8
{
    class Program
    {
        static bool LaSoNguyenTo(long x)
        {
            if (x < 2)
                return false;

            if (x == 2)
                return true;

            if (x % 2 == 0)
                return false;

            long gioiHan = (long)Math.Sqrt(x);

            for (long i = 3; i <= gioiHan; i += 2)
            {
                if (x % i == 0)
                    return false;
            }

            return true;
        }

        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            int n;
            do
            {
                Console.Write("Nhập số nguyên n: ");
            } while (!int.TryParse(Console.ReadLine(), out n));

            if (n < 2)
            {
                Console.WriteLine("Không có số nguyên tố nào không vượt quá n.");
                return;
            }

            Console.WriteLine("Các số nguyên tố không vượt quá {0}:", n);

            // Dùng long để tránh tràn bộ đếm khi n bằng int.MaxValue.
            for (long x = 2; x <= n; x++)
            {
                if (LaSoNguyenTo(x))
                    Console.Write("{0} ", x);
            }

            Console.WriteLine();
        }
    }
}
