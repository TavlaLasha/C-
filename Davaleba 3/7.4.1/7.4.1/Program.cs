using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Side A: ");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.Write("Side B: ");
            int B = Convert.ToInt32(Console.ReadLine());
            Console.Write("Side C: ");
            int C = Convert.ToInt32(Console.ReadLine());
            Console.Write("Side D: ");
            int D = Convert.ToInt32(Console.ReadLine());

            GeoFigure fig = new GeoFigure();
            fig.A = A;
            fig.B = B;
            fig.C = C;
            fig.D = D;
            
            inherit inherit = new inherit();
            inherit.A = A;
            inherit.B = B;

            int Answer1 = fig.perimeter();
            int Answer2 = inherit.perimeter();

            Console.WriteLine($"Base perimeter: {Answer1}");
            Console.WriteLine($"Inherit perimeter: {Answer2}");
            Console.ReadKey();
        }
    }
}
