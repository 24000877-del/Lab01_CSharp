using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            while (true)
            {
                Console.WriteLine("\n===== MENU VẼ HÌNH =====");
                Console.WriteLine("1. Tam giác vuông đặc");
                Console.WriteLine("2. Tam giác vuông rỗng");
                Console.WriteLine("3. Hình vuông rỗng");
                Console.WriteLine("0. Thoát");
                Console.Write("Chọn: ");

                int luaChon;
                if (!int.TryParse(Console.ReadLine(), out luaChon)
                    || luaChon < 0 || luaChon > 3)
                {
                    Console.WriteLine("Vui lòng chọn từ 0 đến 3.");
                    continue;
                }

                if (luaChon == 0)
                    break;

                int h;
                do
                {
                    Console.Write("Nhập chiều cao/cạnh h > 0: ");
                } while (!int.TryParse(Console.ReadLine(), out h) || h <= 0);

                switch (luaChon)
                {
                    case 1:
                        // Tam giác vuông đặc
                        for (int i = 0; i < h; i++)
                        {
                            for (int j = 0; j <= i; j++)
                                Console.Write("* ");

                            Console.WriteLine();
                        }
                        break;

                    case 2:
                        // Tam giác vuông rỗng
                        for (int i = 0; i < h; i++)
                        {
                            for (int j = 0; j <= i; j++)
                            {
                                if (j == 0 || j == i || i == h - 1)
                                    Console.Write("* ");
                                else
                                    Console.Write("  ");
                            }

                            Console.WriteLine();
                        }
                        break;

                    case 3:
                        // Hình vuông rỗng
                        for (int i = 0; i < h; i++)
                        {
                            for (int j = 0; j < h; j++)
                            {
                                if (i == 0 || i == h - 1
                                    || j == 0 || j == h - 1)
                                    Console.Write("* ");
                                else
                                    Console.Write("  ");
                            }

                            Console.WriteLine();
                        }
                        break;
                }
            }

            Console.WriteLine("Đã thoát chương trình.");
        }
    }
}
