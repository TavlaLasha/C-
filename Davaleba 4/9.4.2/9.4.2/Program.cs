using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Memkvidre mem = new Memkvidre();

                int[] masivi = new int[] { 1, 2, 3, 4, -5, 6, 7, 8, -9, 0 };
                int max = mem.Maqsimaluri(masivi);
                int min = mem.Min(masivi);

                Console.WriteLine($"Max: {max}\nMin: {min}");
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
