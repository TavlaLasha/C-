using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Side B: ");
            int side_B = Convert.ToInt32(Console.ReadLine());
            Console.Write("Side A: ");
            int side_A = Convert.ToInt32(Console.ReadLine());

            Martkutxedi martkutxedi = new Martkutxedi(side_B, side_A);
            martkutxedi.See(martkutxedi);

            Memkvidre memkvidre = new Memkvidre(side_A, side_B);
            int shedegi = memkvidre.Fartobi();
            
            Console.WriteLine($"fatrobi: {shedegi}");
            Console.ReadKey();
        }
    }
}
