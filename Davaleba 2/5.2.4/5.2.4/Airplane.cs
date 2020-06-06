using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._2._4
{
    class Airplane
    {
        public float tankCap;
        public int range;

        public void writeInfo(float tankCap, int range)
        {
            this.tankCap = tankCap;
            this.range = range;
        }
        public void printInfo()
        {
            Console.WriteLine($"+-----------------------+\nAirplane tank capacity: { tankCap}\nRange with 1L fuel: {range}\n+-----------------------+");
        }
        public float calculateRange()
        {
            return tankCap * range;
        }
    }
}
