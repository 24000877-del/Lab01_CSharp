using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int n;
            do
            {
                Console.Write("Nhập số lượng phần tử n > 0: ");
            } while (!int.TryParse(Console.ReadLine(), out n) || n <= 0);

            long tong = 0;
            int lonNhat = int.MinValue;
            int nhoNhat = int.MaxValue;
            int soLuongChan = 0;

            for (int i = 0; i < n; i++)
            {
                int x;
                do
                {
                    Console.Write("Nhập số nguyên thứ {0}: ", i + 1);
                } while (!int.TryParse(Console.ReadLine(), out x));

                tong += x;

                if (x > lonNhat)
                    lonNhat = x;

                if (x < nhoNhat)
                    nhoNhat = x;

                if (x % 2 == 0)
                    soLuongChan++;
            }

            double trungBinh = (double)tong / n;

            Console.WriteLine("Tổng = {0}", tong);
            Console.WriteLine("Trung bình = {0:F2}", trungBinh);
            Console.WriteLine("Số lớn nhất = {0}", lonNhat);
            Console.WriteLine("Số nhỏ nhất = {0}", nhoNhat);
            Console.WriteLine("Số lượng số chẵn = {0}", soLuongChan);
        }
    }
}
