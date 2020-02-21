using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0, i=1;
            Console.Write("Davaleba 3.5.1\n");
            for(i=1; i<=20; i++)
            {
                sum += i;
                if (sum > 24)
                {
                    Console.Write(sum);
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}
