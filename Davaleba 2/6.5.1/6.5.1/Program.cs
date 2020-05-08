using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 3, -4, 5, -2, 7, 8, 4, 5 };

            overClass new1 = new overClass(arr);
            overClass new2 = new overClass(new1);
            
            new1.print(new2);
            Console.ReadKey();
        }
    }
}
