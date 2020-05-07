using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int i;
            for(i=0; i<=20; i++)
            {
                Console.WriteLine(rand.Next(1, 100)+" ");
            }
            Console.ReadKey();
        }
    }
}
