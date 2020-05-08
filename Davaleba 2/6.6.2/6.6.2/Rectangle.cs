using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._6._2
{
    class Rectangle
    {
        public int a, b;
        double area;

        public Rectangle(int A, int B)
        {
            a = A;
            b = B;
        }
        public Rectangle():this(0, 0)
        {
            area = a * b;
        }
        public Rectangle(Rectangle obj) : this(obj.a, obj.b)
        {
            area = a * b;
        }
        public void print(Rectangle pr)
        {
            Console.WriteLine($"Rectangle area: {pr.area}");
        }
    }
}
