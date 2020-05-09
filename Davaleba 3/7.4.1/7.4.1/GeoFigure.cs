using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._4._1
{
    class GeoFigure
    {
        public int A, B, C, D;
        public GeoFigure() { }
        public GeoFigure(int a, int b, int c, int d)
        {
            A = a;
            B = b;
            C = c;
            D = d;
        }
        public virtual int perimeter()
        {
            return A + B + C + D;
        }
    }
    class inherit : GeoFigure
    {
        public override int perimeter()
        {
            return 2*(A+B);
        }
    }
}
