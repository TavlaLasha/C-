using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter Km/H: ");
                int stkm = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter travel time: ");
                int trtm = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Km/Energy: ");
                int kme = Convert.ToInt32(Console.ReadLine());

                if (stkm < 0 || trtm < 0 || kme < 0)
                {
                    throw new Exception("Gtxovt sheiyvanet mxolod dadebiti ricxvi");
                }

                FirstDerive obj_1 = new FirstDerive();
                int answer1 = obj_1.Gamotvla(stkm, trtm);
                SecondDerive obj_2 = new SecondDerive();
                int answer2 = obj_2.Gamotvla(kme, answer1);

                Console.WriteLine($"\nGavlili mandzili: {answer1}");
                Console.WriteLine($"Daxarjuli eleqtor energia: {answer2}");
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
