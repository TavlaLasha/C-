using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._2._1
{
    class Kvadrati : Figura
    {
        public int partobi;
        public Kvadrati(int _a, int _b) : base(_a, _b)
        {
            partobi = a * b;
        }
    }
}
