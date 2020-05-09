using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Side A: ");
            double A = Convert.ToDouble(Console.ReadLine());
            Console.Write("Side B: ");
            double B = Convert.ToDouble(Console.ReadLine());
            Console.Write("Side C: ");
            double C = Convert.ToDouble(Console.ReadLine());

            inherit inherit = new inherit();

            double Base_Perim = inherit.perimeter(A, B, C);
            double Inherit_Perim = inherit.localPerimeter(A, B, C);

            Console.WriteLine($"Base perimeter: {Base_Perim}");
            Console.WriteLine($"Inherit perimeter: {Inherit_Perim}");
            Console.ReadKey();
        }
    }
}
