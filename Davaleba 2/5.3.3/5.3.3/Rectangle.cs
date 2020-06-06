using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._3._3
{
    class Rectangle
    {
        public float sideA;
        public float sideB;

        private double area;
        private float perimeter;

        public Rectangle(float sideA, float sideB)
        {
            this.sideA = sideA;
            this.sideB = sideB;
            area = sideA * sideB;
            perimeter = 2 * (sideA + sideB);
        }

        public void printInfo()
        {
            Console.WriteLine($"Perimeter is: {perimeter}");
            Console.WriteLine($"Area is: {area}");
            Console.ReadKey();
        }
    }
}
