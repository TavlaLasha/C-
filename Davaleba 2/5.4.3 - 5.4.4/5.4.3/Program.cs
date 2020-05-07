using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._4._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Arr arr = new Arr();
            int[] masiv = new int[] { -1, 2, 3, 4, 5, -6, 7, 8, 9 };

            int Answer1 = arr.Solve1(masiv);
            int Answer2 = arr.Solve2(masiv);
            Console.WriteLine($"First negative number: { Answer1 }\n");
            Console.WriteLine($"Minimum number: { Answer2 }\n");
            Console.ReadKey();
        }
    }
}
