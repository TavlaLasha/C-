using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Davaleba 4.1.11\n");
            int[] nums = { 12, 0, 23, 5, 0, 11, 3, 0 };
            int count = 0;
            for(int i=0; i<=7; i++)
            {
                if (nums[i] == 0)
                {
                    count++;
                }
            }
            Console.Write("Masivshi gaxlavt " + count + " nulovani elementi");
            Console.ReadKey();
        }
    }
}
