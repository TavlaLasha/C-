using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Davaleba 3.4.1\n");
            Console.Write("Sadamde?: ");
            int a = Convert.ToInt32(Console.ReadLine()), i=1;
            double sum = 0;

            for (i = 1; i <= a; i++)
            {
                sum += Math.Pow(i, 2);
            }
            //do
            //{
            //    sum += Math.Pow(i, 2);
            //    i++;
            //} while (i <= a);
            Console.Write("1-dan " + a + "mde ricxvebis kvadratebis jamia: " + sum);
            Console.ReadKey();
        }
    }
}
