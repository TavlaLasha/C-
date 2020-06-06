using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._4._3
{
    class Car
    {
        public int carParam(int tankCap, int range)
        {
            return tankCap * range;
        }
        public float carParam(float topSpeed, float movetime)
        {
            return topSpeed * movetime;
        }
        public void printInfo(string inf, float data)
        {
            Console.WriteLine($"{inf} is: {data}");
        }
    }
}
