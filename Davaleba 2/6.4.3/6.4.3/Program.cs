using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._4._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Tank Capacity: ");
            int tankCap = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Range With 1L Fuel: ");
            int range = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Top Speed: ");
            float topSpeed = Convert.ToSingle(Console.ReadLine());

            Console.Write("Enter Move Time: ");
            float movetime = Convert.ToSingle(Console.ReadLine());

            Car car = new Car();
            car.printInfo("Range with full tank", car.carParam(tankCap, range));
            car.printInfo("Time with full tank", car.carParam(topSpeed, movetime));
            Console.ReadKey();
        }
    }
}
