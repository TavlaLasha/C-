using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._6._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Square kvadrat1 = new Square();
            kvadrat1.print(kvadrat1);

            Console.Write("Siede a: ");
            kvadrat1.a = Convert.ToInt32(Console.ReadLine());

            Square kvadrat2 = new Square(kvadrat1);
            kvadrat2.print(kvadrat2);

            Console.ReadKey();
        }
    }
}
