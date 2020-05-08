using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Side A: ");
            float A = Convert.ToSingle(Console.ReadLine());
            Console.Write("Side B: ");
            float B = Convert.ToSingle(Console.ReadLine());
            Console.Write("Side C: ");
            float C = Convert.ToSingle(Console.ReadLine());

            inherit inherit = new inherit(A, B, C);

            double shedegi1 = inherit.area();
            double shedegi2 = inherit.Perimeter();

            Console.WriteLine($"\nSamkutxedis fartobi: {shedegi1}\nSamkutxedis perimetri: {shedegi2}");
            Console.ReadKey();
        }
    }
}
