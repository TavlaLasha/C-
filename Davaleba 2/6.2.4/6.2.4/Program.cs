using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] masv = new int[] { 2, -4, -3, -1, -5, 8, -9, 3, 7, 2, 1, 10 };
            Math math = new Math();

            int dadeb, uaryof, luw, kent;

            kent = math.Math_(masv, out dadeb, out uaryof, out luw);

            Console.WriteLine($"Dadebiti: {dadeb}");
            Console.WriteLine($"Uaryofiti: {uaryof}");
            Console.WriteLine($"Luwi elementebis jami: {luw}");
            Console.WriteLine($"Kenti elementebis jami: {kent}");

            Console.ReadLine();
        }


    }
}
