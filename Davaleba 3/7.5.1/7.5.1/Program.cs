using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Side A: ");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.Write("Side B: ");
            int B = Convert.ToInt32(Console.ReadLine());

            FirstInherit rect = new FirstInherit();
            int rect_peri = rect.perimeter(A, B);
            SecondInherit tri = new SecondInherit();
            int tri_peri = tri.perimeter(A, B);

            Console.WriteLine($"Rectangle perimeter: {rect_peri}");
            Console.WriteLine($"Triangle perimeter: {tri_peri}");
            Console.ReadKey();
        }
    }
}
