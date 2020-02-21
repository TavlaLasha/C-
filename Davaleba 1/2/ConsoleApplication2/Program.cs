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
            Console.Write("Davaleba 2.2.1\n");
            bool x1 = true, x2 = false, x3 = true, x4 = false;
            bool y = x1 && x2 || x3 && !x4;
            Console.Write("y is: " + y);
            Console.ReadKey();
        }
    }
}
