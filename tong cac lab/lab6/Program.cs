using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;           
            Console.WriteLine("Nhập số thập phân bằng dấu chấm, ví dụ: 1.5");

            Console.Write("Nhập a: ");
            double a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Nhập b: ");
            double b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Nhập c: ");
            double c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (a == 0)
            {
                if (b == 0)
                {
                    if (c == 0)
                        Console.WriteLine("Phương trình có vô số nghiệm.");
                    else
                        Console.WriteLine("Phương trình vô nghiệm.");
                }
                else
                {
                    double x = -c / b;
                    Console.WriteLine("Phương trình có một nghiệm: x = {0:F2}", x);
                }
            }
            else
            {
                double delta = b * b - 4 * a * c;

                if (delta < 0)
                {
                    Console.WriteLine("Phương trình vô nghiệm thực.");
                }
                else if (delta == 0)
                {
                    double x = -b / (2 * a);
                    Console.WriteLine("Phương trình có nghiệm kép: x = {0:F2}", x);
                }
                else
                {
                    double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(delta)) / (2 * a);

                    Console.WriteLine("Phương trình có hai nghiệm:");
                    Console.WriteLine("x1 = {0:F2}", x1);
                    Console.WriteLine("x2 = {0:F2}", x2);
                }
            }
        }
    }
}
