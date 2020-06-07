using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Wigni wigni = new Wigni("Raime Wigni Dasaxeleba", "Avtoris saxeli", 2014, 200);
                Statia statia = new Statia("Raime statiis dasaxeleba", "statiis avtori", 2015, 250, "Jurnalis saxeli", 2857);
                ElResursi elresursi = new ElResursi("El Resursis saxeli", "El resursis avtoris saxeli", 2017, "www.youtube.com", "Lorem ipsum dolor sit amet, consectetur adipiscing elit");

                Gamocema[] gamocema = new Gamocema[3] { wigni, statia, elresursi };

                for (int i = 0; i <= 2; i++)
                {
                    Console.WriteLine(gamocema[i].PrintInfo());
                }

                Console.Write("Gamocemis mosadzebnad sheiyvanet sawyisi weli: ");
                int sawyisi = Convert.ToInt32(Console.ReadLine());
                Console.Write("bolo weli: ");
                int bolo = Convert.ToInt32(Console.ReadLine());

                if(sawyisi < 1000 || bolo < 1000)
                {
                    throw new ArgumentException("Gtxovt sheiyvanet swori weli");
                }

                SearchMechanism search = new SearchMechanism();
                search.SearchByYear(gamocema, sawyisi, bolo);
            }
            catch (FormatException e)
            {
                Console.WriteLine($"Gtxov Sheiyvanot mxolod ricxvi. {e.Message}");
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
