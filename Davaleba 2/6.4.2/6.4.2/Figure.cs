using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._4._2
{
    class Figure
    {
        public double calculateFigure(double a)
        {
            return 4*a;
        }
        public double calculateFigure(double a, double b)
        {
            return 2*(a + b);
        }
        public double calculateFigure(double a, double b, double c)
        {
            return a + b + c;
        }
    }
}
