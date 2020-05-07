using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._3._2
{
    class Triangle
    {
        public float sideA;
        public float sideB;
        public float sideC;
        private double perimeter;
        private double area;

        public Triangle(float SideA, float SideB, float SideC)
        {
            sideA = SideA;
            sideB = SideB;
            sideC = SideC;
        }
        public void calculate()
        {
            perimeter = sideA + sideB + sideC;
            double p = perimeter / 2;
            area = Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));
            Console.WriteLine($"Perimeter is: {perimeter}");
            Console.WriteLine($"Area is: {area}");
            Console.ReadKey();
        }
    }
}
