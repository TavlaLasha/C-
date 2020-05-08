using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._6._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect1 = new Rectangle();
            rect1.print(rect1);

            Console.Write("Side a: ");
            rect1.a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Side b: ");
            rect1.b = Convert.ToInt32(Console.ReadLine());

            Rectangle rect2 = new Rectangle(rect1);
            rect2.print(rect2);

            Console.ReadKey();
        }
    }
}
