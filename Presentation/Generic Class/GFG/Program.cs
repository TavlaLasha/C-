using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GFG
{
    class Program
    {
        static void Main(string[] args)
        {
            // instance of string type 
            GFG<string> name = new GFG<string>();
            name.value = "GeeksforGeeks";

            // instance of float type 
            GFG<float> version = new GFG<float>();
            version.value = 5.0f;

            // display GeeksforGeeks 
            Console.WriteLine(name.value);

            // display 5 
            Console.WriteLine(version.value);
            Console.ReadKey();
        }
    }
}
