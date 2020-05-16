using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("A: ");
                double A = Convert.ToDouble(Console.ReadLine());

                methods calc = new methods();

                double Answer1 = calc.square(A);
                double Answer2 = calc.cube(A);

                Console.WriteLine($"Square: {Answer1}");
                Console.WriteLine($"Cube: {Answer2}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Gtxovt sheiyvanet mxolod ricxvi");
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
