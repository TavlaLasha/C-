using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._2._5
{
    class Program
    {
        static void Main(string[] args)
        {
            int result1, result2, result3, result4, result5, result6;

            Math math = new Math();
            Math2 math2 = new Math2();
            Math3 math3 = new Math3();

            result1 = math.Math_(2, 3, -1, 4, 2, -4, 7, 8, -9, 2, 3, -1, 1, 1, 1, 1, 1, -1);
            result2 = math.Math_(new int[] { -1, 2, -3, -4, 5, 6 }); //masivs gadaecema

            result3 = math2.Math_(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);
            result4 = math2.Math_(new int[] { 2, 34, 5, 6, 7, 8, 9, 10, 23, 3, 4, 5, 12 }); //masivs gadaecema

            result5 = math3.Math_(1, 2, 3, 24, 5, 6, 10);
            result6 = math3.Math_(new int[] { 2, 3, 543, 6, 7, 8, 9, 32, 45, 67 }); //masivs gadaecema

            Console.WriteLine($"Dadebiti ricxvebis raodenoba: {result1}");
            Console.WriteLine($"Dadebiti ricxvebis raodenoba: {result2}");

            Console.WriteLine($"Luwi ricxvebis raodenoba: {result3}");
            Console.WriteLine($"Luwi ricxvebis raodenoba: {result4}");

            Console.WriteLine($"Luwi ricxvebis raodenoba: {result5}");
            Console.WriteLine($"Luwi ricxvebis raodenoba: {result6}");
            Console.ReadLine();

        }
    }
}
