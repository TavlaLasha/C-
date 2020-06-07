using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._5._4
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Sheiyvanet erti tvis xelpasi: ");
                int erti_tvis_xelfasi = Convert.ToInt32(Console.ReadLine());

                if (erti_tvis_xelfasi < 0)
                {
                    throw new Exception("Gtxovt sheiyvanet mxolod dadebiti ricxvi");
                }

                Memkvidre_2 obj_memkvidre = new Memkvidre_2(erti_tvis_xelfasi);
                int shedegi = obj_memkvidre.Metodi();

                Console.WriteLine($"Xelpasi 1 weliwadshi: {shedegi} Lari");
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
