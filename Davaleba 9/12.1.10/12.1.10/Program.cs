using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._1._10
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Es aris testi";
            string new_str = str.Replace(" aris", "");
            Console.WriteLine(new_str);
            Console.ReadKey();
        }
    }
}
