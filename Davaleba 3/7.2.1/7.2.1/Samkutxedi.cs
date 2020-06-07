using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._2._1
{
    class Samkutxedi : Figura
    {
        public int perimetri;
        public Samkutxedi(int _a, int _b, int _c) : base(_a, _b, _c)
        {
            perimetri = a + b + c;
        }
    }
}
