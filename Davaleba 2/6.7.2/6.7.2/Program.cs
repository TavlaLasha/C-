using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._7._2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
                ChemiKlasi obj = new ChemiKlasi(arr);
                int answer = ChemiKlasi.StatikuriMetodi(obj);
                Console.WriteLine($"Masivshi arsebuli kenti ricxvebis jami: {answer}");
            }
            catch (Exception e)
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
