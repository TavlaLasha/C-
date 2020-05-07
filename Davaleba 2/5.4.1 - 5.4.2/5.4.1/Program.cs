using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Sum sum = new Sum();

            Console.Write("Num 1: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Num 2: ");
            int n2 = Convert.ToInt32(Console.ReadLine());

            int answer1 = sum.calc1(n1, n2);
            int answer2 = sum.calc2(n1, n2);

            Console.WriteLine($"\nSum: {answer1}");
            Console.WriteLine($"Multiplication: {answer2}");
            Console.ReadKey();
        }
    }
}
