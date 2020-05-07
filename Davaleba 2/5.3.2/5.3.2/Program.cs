using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Triangle Side A: ");
            float SideA = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Triangle Side B: ");
            float SideB = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Triangle Side C: ");
            float SideC = Convert.ToSingle(Console.ReadLine());

            Triangle triangle = new Triangle(SideA, SideB, SideC);

            triangle.calculate();
        }
    }
}
