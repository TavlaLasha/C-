using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._3._1
{
    class Airplane
    {
        private float tankCapacity;
        private float literRange;

        public Airplane()
        {
            tankCapacity = 250;
            literRange = 5;
        }
        public void printInfo()
        {
            Console.WriteLine($"Tank Capacity is: {tankCapacity} L\n1 Liter Range is: {literRange} km");
        }
        public double calcRange()
        {
            return tankCapacity * literRange;
        }
    }
}
