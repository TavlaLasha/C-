using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();

            Console.Write("Number 1: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Number 2: ");
            int y = Convert.ToInt32(Console.ReadLine());

            program.refStudy(ref x, ref y);

            Console.WriteLine($"Y is: {y}");
            Console.ReadKey();
        }
        public void refStudy(ref int x, ref int y)
        {
            y = Convert.ToInt32(Math.Pow(x, 2));
        }
    }
}
