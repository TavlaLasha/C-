using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Number: ");
                int X = Convert.ToInt32(Console.ReadLine());

                evenGive even = new evenGive();
                even.setNum = X;
            }
            catch (FormatException)
            {
                Console.WriteLine("Gtxovt sheiyvanot mxolod mteli ricxvi");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Done :)");
                Console.ReadKey();
            }
        }
    }
}
