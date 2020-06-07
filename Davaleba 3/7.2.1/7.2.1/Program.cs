using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter Side A: ");
                int a = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Side B: ");
                int b = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Side C: ");
                int c = Convert.ToInt32(Console.ReadLine());

                if(a<1 || b<1 || c < 1)
                {
                    throw new Exception("Gtxovt sheiyvanet mxolod dadebiti ricxvi");
                }

                Samkutxedi obj_1 = new Samkutxedi(a, b, c);
                Kvadrati obj_2 = new Kvadrati(a, b);

                Console.WriteLine($"Samkutxedis perimetri: {obj_1.perimetri}");
                Console.WriteLine($"Kvadratis partobi: {obj_2.partobi}");
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
