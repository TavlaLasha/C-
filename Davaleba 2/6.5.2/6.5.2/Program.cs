using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._5._2
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

            Calculate calc1 = new Calculate(A);
            Calculate calc2 = new Calculate(A, B);
            Calculate calc3 = new Calculate(A, B, C);
            

            Console.WriteLine($"\nCube perimeter: {calc1.perim()}");
            Console.WriteLine($"Cube area: {calc1.are()}");
            Console.WriteLine($"\nRectangle perimeter: {calc2.perim()}");
            Console.WriteLine($"Rectangle area: {calc2.are()}");
            Console.WriteLine($"\nTriangle perimeter: {calc3.perim()}");
            Console.WriteLine($"Triangle area: {calc3.are()}");
            Console.ReadKey();
        }
    }
}
