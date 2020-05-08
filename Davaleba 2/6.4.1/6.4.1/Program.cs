using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle tri = new Triangle();

            Console.Write("Side A: ");
            double A = Convert.ToDouble(Console.ReadLine());
            Console.Write("Side B: ");
            double B = Convert.ToInt32(Console.ReadLine());
            Console.Write("Side C: ");
            double C = Convert.ToInt32(Console.ReadLine());

            double Answer1 = tri.calculateTriangle(A, C);
            double Answer2 = tri.calculateTriangle(A, B, C);

            Console.WriteLine($"\nTriangle Area: {Answer1}");
            Console.WriteLine($"Triangle perimeter: {Answer2}");
            Console.ReadKey();
        }
    }
}
