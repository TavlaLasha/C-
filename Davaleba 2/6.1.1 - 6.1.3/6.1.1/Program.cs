using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Triangle tri = new Triangle();
                Rectangle rect = new Rectangle();
                Square square = new Square();

                Console.WriteLine("To Calculate Triangle Area, Please fill\nSide 1: ");
                float sideA = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine("Side 2: ");
                float sideB = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine("Side 3: ");
                float sideC = Convert.ToSingle(Console.ReadLine());

                tri.triangleSides(sideA, sideB, sideC);
                Console.WriteLine($"Triangle area is: {tri.triArea()}\n");

                Console.WriteLine("To Calculate Rectangle Perimeter, Please fill\nSide 1: ");
                float SideA = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine("Side 2: ");
                float SideB = Convert.ToSingle(Console.ReadLine());

                rect.rectangleSides(SideA, SideB);
                Console.WriteLine($"Rectangle perimeter is: {rect.rectPerimeter()}");

                Console.WriteLine("To Calculate Sqiare Perimeter, Please fill\nSide: ");
                float side = Convert.ToSingle(Console.ReadLine());

                square.squareSide(side);
                Console.WriteLine($"Rectangle perimeter is: {square.sqarePerimeter()}");
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
