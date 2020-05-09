using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._4._1
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

            calc calculate = new calc();

            int perimeter = calculate.perimeter(A, B, C);
            double area = calculate.area(A, B, C);

            Console.WriteLine($"Perimeter: {perimeter}");
            Console.WriteLine($"Area: {area}");
            Console.ReadKey();
        }
    }
}
