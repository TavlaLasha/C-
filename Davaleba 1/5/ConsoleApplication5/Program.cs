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
            Console.Write("Davaleba 3.3.1\n");
            Console.Write("Sheiyvanet ricxvi: ");
            double x = Convert.ToDouble(Console.ReadLine());

            if (x > 0 && x <= 17)
            {
                Console.Write("Sheyvanili ricxvi gaxlavt dadgenil diapazonshi");
            }
            else
            {
                Console.Write("Sheyvanili ricxvi ar gaxlavt dadgenil diapazonshi");
            }
            Console.ReadKey();
        }
    }
}
