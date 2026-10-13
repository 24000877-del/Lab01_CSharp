using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int chon;
            do
            {
                Console.WriteLine("1. Tổng 1..n");
                Console.WriteLine("2. Bảng cửu chương");
                Console.WriteLine("0. Thoát");
                int.TryParse(Console.ReadLine(), out chon);
                switch (chon)
                {
                    case 1:
                        Console.Write("n = ");
                        int n = int.Parse(Console.ReadLine());
                        int tong = 0;
                        for (int i = 1; i <= n; i++) tong += i;
                        Console.WriteLine("Tổng = " + tong);
                        break;
                    case 2:
                        for (int i = 1; i <= 10; i++)
                            Console.WriteLine("7 x {0} = {1}", i, 7 * i);
                        break;
                }
            } while (chon != 0);
        }
    }
}
