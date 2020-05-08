using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._1._1
{
    class Triangle
    {
        float sideA, sideB, sideC;
        public void triangleSides(float sideA, float sideB, float sideC)
        {
            this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;
        }
        public double triArea()
        {
            double perimeter = sideA + sideB + sideC;
            double p = perimeter / 2;
            return Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));
        }
    }
    class Rectangle
    {
        float sideA, sideB;
        public void rectangleSides(float sideA, float sideB)
        {
            this.sideA = sideA;
            this.sideB = sideB;
        }
        public double rectPerimeter()
        {
            return 2 * (sideA + sideB);
        }
    }
    class Square
    {
        float side;
        public void squareSide(float side)
        {
            this.side = side;
        }
        public double sqarePerimeter()
        {
            return 4 * side;
        }
    }
}
