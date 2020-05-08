using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._7._1
{
    class Otxkutxedi
    {
        static int a, b;
        public Otxkutxedi(int A, int B)
        {
            a = A;
            b = B;
        }
        public double perimeter()
        {
            return 2*(a * b);
        }
        public static double perim(Otxkutxedi obj)
        {
            double perimeter = obj.perimeter();
            return perimeter;
        }
    }
}
