using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8 };

                Baza baza = new Baza();
                int Answer1 = baza.Metodi1(arr);

                Memkvidre memkvidre = new Memkvidre();
                int Answer2 = memkvidre.Metodi1(arr);

                Console.WriteLine($"Masivshi arsebuli ricxvebis jami: {Answer1}");
                Console.WriteLine($"Masivshi arsebuli ricxvebis namravli: {Answer2}");
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
