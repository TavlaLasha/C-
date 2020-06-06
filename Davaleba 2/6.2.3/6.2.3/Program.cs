using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                float perim;
                Console.Write("a: ");
                float a = Convert.ToSingle(Console.ReadLine());
                Console.Write("b: ");
                float b = Convert.ToSingle(Console.ReadLine());
                Console.Write("c: ");
                float c = Convert.ToSingle(Console.ReadLine());

                double area = Triangle(a, b, c, out perim);
                if (area <= 0 || double.IsNaN(area))
                {
                    throw new Exception("Sheyvanili ricxvebi arasworia.");
                }

                Console.WriteLine($"\nPerimeter: {perim}");
                Console.WriteLine($"Area: {area}");
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
                Console.ReadKey();
            }
        }
        static public double Triangle(float a, float b, float c, out float perim)
        {
            perim = a + b + c;
            float p = perim / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }
}
