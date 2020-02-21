using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Davaleba 2.1.11\n");
            Console.Write("Sheiyvanet samkutxedis pirveli gverdis sigrdze: ");
            float a = Convert.ToSingle(Console.ReadLine());
            Console.Write("Sheiyvanet meore gverdis sigrdze: ");
            float b = Convert.ToSingle(Console.ReadLine());
            Console.Write("Sheiyvanet mesame gverdis sigrdze: ");
            float c = Convert.ToSingle(Console.ReadLine());

            float P = a + b + c;
            Console.Write("\nSamkutxedis perimetri gaxlavt: " + P);
            Console.ReadKey();
        }
    }
}

