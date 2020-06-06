using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._2._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Side A: ");
            float sideA = Convert.ToSingle(Console.ReadLine());

            Console.Write("Enter Side B: ");
            float sideB = Convert.ToSingle(Console.ReadLine());

            Rectangle rect = new Rectangle();

            rect.writeInfo(sideA, sideB);
            rect.printInfo();

            Console.WriteLine($"Rectangle area is: {rect.calculateArea()}");
            Console.ReadKey();
        }
    }
}
