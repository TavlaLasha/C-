using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._5._3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter Wattage: ");
                int wati = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Time: ");
                int saati = Convert.ToInt32(Console.ReadLine());

                if (wati < 0 || saati < 0)
                {
                    throw new Exception("Gtxovt sheiyvanet mxolod dadebiti ricxvi");
                }
                
                Memkvidre_1 obj_Memkvidre = new Memkvidre_1(wati, saati);
                int shedegi = obj_Memkvidre.Metodi();
                
                Console.WriteLine($"Daxarjuli eleqtor energia: {shedegi} W");
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
