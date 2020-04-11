using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            double sashualo;
            int[] grades = new int[] { 12, 20, 77, 3, 17, 23, 43, 54, 15, 32 };

            Calculate calculate = new Calculate();

            sashualo = calculate.average(grades);
            Console.WriteLine("Average Grade is:"+sashualo);
            Console.ReadLine();
        }
    }
}
