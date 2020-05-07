using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._1._5
{
    class Program
    {
        private string color;
        private byte doorCount;
        static void Main(string[] args)
        {
            Program car = new Program();
            Car cardet = new Car();

            car.color = "black";
            car.doorCount = 4;
            cardet.ownerLastName = "tavlalashvili";
            cardet.manufacturer = "BMW";

            Console.WriteLine($"Car manufacturer: {cardet.manufacturer}\nNumber of Doors: {car.doorCount}");
            Console.WriteLine($"Car color: {car.color}\nCar owner: {cardet.ownerLastName}\n");
            Console.ReadKey();
        }
    }
}
