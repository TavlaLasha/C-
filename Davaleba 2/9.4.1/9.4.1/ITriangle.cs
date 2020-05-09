using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._4._1
{
    interface ITriangle
    {
        int perimeter(int a, int b, int c);
    }
    class calc : Baza, ITriangle
    {
        public int perimeter(int a, int b, int c)
        {
            return a + b + c;
        }
    }
}
