using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._5._1
{
    abstract class GeoFigure
    {
        public abstract int perimeter(int A, int B);
    }
    class FirstInherit : GeoFigure
    {
        public override int perimeter(int A, int B)
        {
            return 2 * (A + B);
        }
    }
    class SecondInherit : GeoFigure
    {
        public override int perimeter(int A, int B)
        {
            return (A * B) / 2;
        }
    }
}
