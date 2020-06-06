using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter airplane tank capacity: ");
            float tankCap = Convert.ToSingle(Console.ReadLine());

            Console.Write("Enter range with 1L fuel: ");
            int range = Convert.ToInt32(Console.ReadLine());

            Airplane airplane = new Airplane();

            airplane.writeInfo(tankCap, range);
            airplane.printInfo();
            Console.WriteLine($"That airplane can fly {airplane.calculateRange()} kilometers with full tank");
            Console.ReadKey();
        }
    }
}
