using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double r, h;
            Console.Write("Bán kính r = ");
            if (!double.TryParse(Console.ReadLine(), out r) || r <= 0) return;
            Console.Write("Chiều cao h = ");
            if (!double.TryParse(Console.ReadLine(), out h) || h <= 0) return;
            double dienTichXQ = 2 * Math.PI * r * h;
            double theTich = Math.PI * r * r * h;
            Console.WriteLine("Sxq = {0:N2}; V = {1:N2}", dienTichXQ, theTich);
        }
    }
}
