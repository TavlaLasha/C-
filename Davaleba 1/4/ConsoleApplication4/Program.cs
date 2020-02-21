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
            int count = 0;
            Console.Write("Davaleba 3.2.11\n");
            Console.Write("Sheiyvanet pirveli ricxvi A: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Sheiyvanet meore ricxvi B: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Sheiyvanet mesame ricxvi C: ");
            double c = Convert.ToDouble(Console.ReadLine());

            if (a > 10)
            {
                count++;
            }
            if (b > 10)
            {
                count++;
            }
            if (c > 10)
            {
                count++;
            }
            if (count < 3 && count > 0)
            {
                Console.Write("10-ze meti gaxlavt " + count + " ricxvi");
            }
            else if (count == 0)
            {
                Console.Write("Arcerti ricxvi ar aris 10-ze meti ");
            }
            else
            {
                Console.Write("Samive ricxvi 10-ze metia ");
            }
            Console.ReadKey();
        }
    }
}
