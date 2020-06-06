using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Side a: ");
            int gverdi_A = Convert.ToInt32(Console.ReadLine());
            Console.Write("Side b: ");
            int gverdi_B = Convert.ToInt32(Console.ReadLine());

            Memkvidre memkvidre = new Memkvidre(gverdi_A, gverdi_B);

            int shedegi = memkvidre.Fartobi();

            Console.WriteLine($"\nMartkutxedis fartobi: {shedegi}");
            Console.ReadLine();
        }
    }
}
