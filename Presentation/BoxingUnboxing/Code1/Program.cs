using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Boxing
            int i = 123;

            // Boxing copies the value of i into object o.
            object o = i;

            // Change the value of i.
            i = 456;

            // The change in i doesn't affect the value stored in o.
            Console.WriteLine("The value-type value = {0}", i);
            Console.WriteLine("The object-type value = {0}", o);

            //Unboxing
            try
            {
                int j = (int)o;  // attempt to unbox
                double x = (double)(int)o;

                Console.WriteLine("Unboxing OK.");
            }
            catch (InvalidCastException e)
            {
                Console.WriteLine("{0} Error: Incorrect unboxing.", e.Message);
            }
            Console.ReadKey();
        }
    }
}
