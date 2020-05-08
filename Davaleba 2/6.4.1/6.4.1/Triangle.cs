using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._4._1
{
    class Triangle
    {
        public double calculateTriangle(double a, double h)
        {
            return (a * h) / 2;
        }
        public double calculateTriangle(double a, double b, double c)
        {
            return a + b + c;
        }
    }
}
