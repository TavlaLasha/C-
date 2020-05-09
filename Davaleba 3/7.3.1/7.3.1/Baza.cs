using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._3._1
{
    class Baza
    {
        public double a, b, c;
    }
    class inherit : Baza
    {
        new public double a, b, c;
        public double perimeter(double num1, double num2, double num3)
        {
            base.a = num1+5;
            base.b = num2+5;
            base.c = num3+5;
            return base.a + base.b + base.c;
        }
        public double localPerimeter(double num1, double num2, double num3)
        {
            a = num1;
            b = num2;
            c = num3;
            return a + b + c;
        }
    }
}
