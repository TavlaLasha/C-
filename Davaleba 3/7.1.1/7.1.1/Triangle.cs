using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._1._1
{
    class Triangle
    {
        protected float A;
        protected float B;
        protected float C;
    }
    class inherit : Triangle
    {
        private double perimeter;

        public inherit(float A, float B, float C)
        {
            this.A = A;
            this.B = B;
            this.C = C;
        }
        public double area()
        {
            return (A*B)/2;
        }
        public double Perimeter()
        {
            perimeter = A + B + C;
            return perimeter;
        }
    }
}
