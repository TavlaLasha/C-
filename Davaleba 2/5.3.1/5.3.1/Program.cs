using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Airplane airplane = new Airplane();
            airplane.printInfo();
            Console.WriteLine($"Airplane Range With Full Tank: {airplane.calcRange()} km");
            Console.ReadKey();
        }
    }
}
