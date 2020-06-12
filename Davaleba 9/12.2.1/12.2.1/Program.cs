using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder("Saxeli: ", 50);
            sb.Append("Lasha ");
            sb.Append("Tavlalashvili");

            Console.WriteLine(sb);
            Console.ReadKey();
        }
    }
}
