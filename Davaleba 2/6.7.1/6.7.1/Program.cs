using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._7._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Side x: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Side y: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Otxkutxedi otxkutxedi = new Otxkutxedi(a, b);

            Console.WriteLine(Otxkutxedi.perim(otxkutxedi));

            Console.ReadKey();
        }
    }
}
