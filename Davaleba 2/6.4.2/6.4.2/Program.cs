using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Figure fig = new Figure();

            Console.Write("A: ");
            double A = Convert.ToDouble(Console.ReadLine());
            Console.Write("B: ");
            double B = Convert.ToInt32(Console.ReadLine());
            Console.Write("C: ");
            double C = Convert.ToInt32(Console.ReadLine());

            double answer1 = fig.calculateFigure(A);
            double answer2 = fig.calculateFigure(A, B);
            double answer3 = fig.calculateFigure(A, B, C);

            Console.WriteLine($"\nSquare perimeter: {answer1}");
            Console.WriteLine($"Rectangle perimeter: {answer2}");
            Console.WriteLine($"Triangle perimeter: {answer3}");
            Console.ReadKey();

        }
    }
}
