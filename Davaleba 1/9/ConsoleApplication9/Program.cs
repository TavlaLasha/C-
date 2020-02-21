using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Davaleba 4.2.11\n");
            int[,] nums = new int[,] { { 12, 0, 23, 5 }, { 0, 11, 3, 0 }, { 45, 3, 26, 33 }, { 10, 15, 32, 19 } };
            int sum = 0;
            for (int i = 0; i <= 3; i++)
            {
                sum += nums[i, i];
            }
            Console.Write("Masivshi mtavari diagonalis elementebis jami gaxlavt " + sum);
            Console.ReadKey();
        }
    }
}
