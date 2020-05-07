using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._1._4
{
    class Program
    {
        private double perimeter;
        private double area;

        static void Main(string[] args)
        {
            Program calculate = new Program();
            rectangle rect = new rectangle();

            Console.WriteLine("Rectangle side A= ");
            rect.sideA = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Rectangle side B= ");
            rect.sideB = Convert.ToDouble(Console.ReadLine());

            calculate.perimeter = 2 * (rect.sideA + rect.sideB);
            calculate.area = rect.sideA * rect.sideB;

            Console.WriteLine($"\nRectangle perimeter is= {calculate.perimeter}\n");
            Console.WriteLine($"Rectangle area is= {calculate.area}\n");
            Console.ReadKey();
        }
    }
}
