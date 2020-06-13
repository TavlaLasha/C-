using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14._1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Lstr = new List<string> { "lasha", "Cotne", "Vigaca1", "Vigaca2", "Vigaca3", "Vigaca4", "Vigaca5", "Vigaca6", "Vigaca7", "Vigaca8" };
            Lstr.Add("Damatebuli1");
            Lstr.Add("Damatebuli2");

            Console.WriteLine($"Masivis zoma: {Lstr.Count}\n");
            Console.WriteLine($"Masivis elementebi: \n");
            Lstr.ForEach(a => Console.WriteLine(a));
            Console.ReadKey();
        }
    }
}
