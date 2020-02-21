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
            Console.Write("Davaleba 3.1.9\n");
            Console.Write("Sheiyvanet pirveli ricxvi A: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Sheiyvanet meore ricxvi B: ");
            double b = Convert.ToDouble(Console.ReadLine());

            if (a > b)
            {
                Console.Write("Max is A: " + a);
            }
            else if (a < b)
            {
                Console.Write("Max is B: " + b);
            }
            else
            {
                Console.Write("Sheyvanili ricxvebi tolia A=B=" + a);
            }
            Console.ReadKey();
        }
    }
}
