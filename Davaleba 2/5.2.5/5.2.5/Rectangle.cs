using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._2._5
{
    class Rectangle
    {
        public float sideA;
        public float sideB;

        private void give(float sideA, float sideB)
        {
            this.sideA = sideA;
            this.sideB = sideB;
        }
        public void writeInfo(float sideA, float sideB)
        {
            give(sideA, sideB);
        }
        public void printInfo()
        {
            Console.WriteLine($"+-----------------------+\nSide A is: { sideA}\nSide B is: {sideB}\n+-----------------------+");
        }
        public float calculateArea()
        {
            return sideA * sideB;
        }
    }
}
