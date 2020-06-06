using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._5._2
{
    class Calculate
    {
        int a, b, c;
        float perimeter;
        double area;
        public Calculate(int a)
        {
            this.a = a;
            perimeter = 4 * a;
            area = Math.Pow(a, 2);
        }
        public Calculate(int a, int b)
        {
            this.a = a;
            this.b = b;
            perimeter = 2*(a + b);
            area = a * b;
        }
        public Calculate(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            perimeter = a + b + c;
            float p = perimeter / 2;
            area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
        public float perim()
        {
            return perimeter;
        }
        public double are()
        {
            return area;
        }
    }
}
