using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            oddGive odd = new oddGive();

            int i = 0;
            Console.Write("First Number: ");
            do
            {
                Console.Write("Next Number: ");
                odd[i] = Convert.ToInt32(Console.ReadLine());
                i++;
            } while (i < 5);
            Console.Write("Odd Numbers: ");
            for (int n=0; n<=4; n++){
                if (odd[n] != 0)
                {
                    Console.Write(odd[n]+" ");
                }
            }
            Console.ReadKey();
        }
    }
}
