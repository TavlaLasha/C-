using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Sheiyvanet saatebi: ");
                int saati = Convert.ToInt32(Console.ReadLine());

                Console.Write("Sheiyvanet vatebi: ");
                int wati = Convert.ToInt32(Console.ReadLine());

                if (saati < 0 || wati < 0)
                {
                    throw new Exception("Gtxovt sheiyvanet mxolod dadebiti ricxvi");
                }

                Memkvidre_3 obj_3 = new Memkvidre_3(saati);
                Memkvidre_4 obj_4 = new Memkvidre_4(saati, wati);

                Console.WriteLine($"Saatebis raodenoba: {obj_3.saatebis_raodenoba}");
                Console.WriteLine($"Vatebis raodenoba: {obj_4.watebis_raodenoba}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Gtxovt sheiyvanet mxolod mteli ricxvi");
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
