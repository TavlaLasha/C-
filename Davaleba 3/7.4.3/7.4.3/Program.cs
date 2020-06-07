using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._4._3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Sheiyvanet praza: ");
                string str = Console.ReadLine();

                Baza baza = new Baza();
                int Answer1 = baza.Metodi1(str);

                Memkvidre memkvidre = new Memkvidre();
                int Answer2 = memkvidre.Metodi1(str);

                Console.WriteLine($"\nPrazashi sasveni nishnebis raodenoba: {Answer1}");
                Console.WriteLine($"Prazashi xmovnebis raodenoba: {Answer2}");
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
