using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._6._1
{
    class Square
    {
        public int a, perimeter;
        public Square(int A)
        {
            a = A;
        }
        public Square():this(0)
        {
            perimeter = a * 4;
        }
        public Square(Square obj):this(obj.a)
        {
            perimeter = a * 4;
        }
        public void print(Square pr)
        {
            Console.WriteLine($"Square perimeter: {pr.perimeter}");
        }
    }
}
