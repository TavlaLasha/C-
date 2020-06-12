using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._3._25._._26
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Sheiyvanet raime sityva an striqoni: ");
                string str = Console.ReadLine();

                Console.WriteLine($"Didi asoebit: {str.ToUpper()}\nPatara asoebit: {str.ToLower()}");
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
    }
}
