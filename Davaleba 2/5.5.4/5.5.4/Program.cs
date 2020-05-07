using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._5._4
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Random rand = new Random();
                Console.WriteLine("Sheiyvanet R: ");
                int R = Convert.ToInt32(Console.ReadLine());
                int i=0, c=0;
                do
                {
                    c++;
                    if (R == rand.Next(1, 30))
                    {
                        i++;
                    }
                } while (i < 7);
                Console.WriteLine($"1-dan 30-mde intervalshi shemtxvevitad agebuli ricxvi {R}-is toli rom yopiliyo 7-jer,\nshemtxveviti ricxvis amorcheva dagvchirda {c}-jer");
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
