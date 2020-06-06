using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Color: ");
            string color = Console.ReadLine();
            Console.Write("Doors: ");
            byte doors = Convert.ToByte(Console.ReadLine());
            Console.Write("Owners Last Name: ");
            string owner = Console.ReadLine();
            Console.Write("Brand: ");
            string brand = Console.ReadLine();

            Car car = new Car(color, doors, owner, brand);
            car.printInfo();
            Console.ReadKey();
        }
    }
}
