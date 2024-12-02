using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("vuvedi a:");
            double a=double.Parse(Console.ReadLine());
            Console.Write("vuvedi b:");
            double b=double.Parse(Console.ReadLine());
            Console.Write("vuvedi c:");
            double c = double.Parse(Console.ReadLine());

            double rezultat=PiS.Perimetur(a,b,c);
            Console.Write($"perimeturut e:{rezultat}");
            Console.WriteLine();
            double rezultat1 = PiS.Lice(a, b, c);
            Console.WriteLine($"liceto e:{rezultat1}");
        }
    }
}
