using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Random rand = new Random();
                Console.WriteLine("q: ");
                int q = Convert.ToInt32(Console.ReadLine());
                int i, c = 0;
                for (i = 0; i <= 50; i++)
                {
                    if (rand.Next(1, 1000) == q)
                    {
                        c++;
                    }
                }
                Console.WriteLine($"{q} ricxvi 1-dan 1000-mde shemtxvevitad agebuli 50 mcdelobis shemdeg shegvxvda {c}-jer");
            }
            catch(FormatException)
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
