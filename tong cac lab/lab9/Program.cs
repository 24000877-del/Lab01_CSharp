using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9
{
    class Program
    {
        static string DocChuSo(int so)
        {
            switch (so)
            {
                case 0: return "không";
                case 1: return "một";
                case 2: return "hai";
                case 3: return "ba";
                case 4: return "bốn";
                case 5: return "năm";
                case 6: return "sáu";
                case 7: return "bảy";
                case 8: return "tám";
                case 9: return "chín";
                default: return "";
            }
        }

        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            int n;
            do
            {
                Console.Write("Nhập số nguyên từ 0 đến 99: ");
            } while (!int.TryParse(Console.ReadLine(), out n)
                     || n < 0 || n > 99);

            int chuc = n / 10;
            int donVi = n % 10;
            string ketQua;

            switch (chuc)
            {
                case 0:
                    ketQua = DocChuSo(donVi);
                    break;

                case 1:
                    ketQua = "mười";
                    break;

                default:
                    ketQua = DocChuSo(chuc) + " mươi";
                    break;
            }

            if (chuc > 0)
            {
                switch (donVi)
                {
                    case 0:
                        break;

                    case 1:
                        ketQua += chuc >= 2 ? " mốt" : " một";
                        break;

                    case 5:
                        ketQua += " lăm";
                        break;

                    default:
                        ketQua += " " + DocChuSo(donVi);
                        break;
                }
            }

            Console.WriteLine("Cách đọc: {0}", ketQua);
        }
    }
}
