using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                TestClass test = new TestClass();
                test.Array_Event += Test_Array_Event;
                test[0] = 5;
                test[1] = 6;
                test[2] = 7;
                test[3] = 88;
                test[4] = 9;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.ReadKey();
            }
        }

        private static void Test_Array_Event(object sender, EventArgs e)
        {
            Console.WriteLine("Max element exceeded 25");
        }
    }
}
