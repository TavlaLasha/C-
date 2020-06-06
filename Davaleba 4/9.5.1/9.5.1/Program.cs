using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Class obj = new Class();

                Console.Write($"Side_A: ");
                int side_1 = Convert.ToInt32(Console.ReadLine());
                Console.Write($"Side_B: ");
                int side_2 = Convert.ToInt32(Console.ReadLine());
                Console.Write($"Side_B: ");
                int side_3 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"Martkutxedis perimetri: {obj.metodi_1(side_1, side_2, side_3)}");
                Console.WriteLine($"Martkutxedis fartobi: {obj.metodi_2(side_1, side_2)}");
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
