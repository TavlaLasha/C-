using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._5._1
{
    interface Interpeisi
    {
        int Met(int side1, int side2, int side3);
    }
    interface Interpeisi2
    {
        int Met2(int side1, int side2);
    }
    class Class : Interpeisi, Interpeisi2
    {
        Interpeisi obieqti_1;
        Interpeisi2 obieqti_2;
        int Interpeisi.Met(int side1, int side2, int side3)
        {
            return side1 + side2 + side3;
        }
        int Interpeisi2.Met2(int side1, int side2)
        {
            return side1 * side2 / 2;
        }
        public int metodi_1(int side1, int side2, int side3)
        {
            obieqti_1 = this;
            return obieqti_1.Met(side1, side2, side3);
        }
        public int metodi_2(int side1, int side2)
        {
            obieqti_2 = this;
            return obieqti_2.Met2(side1, side2);
        }
    }
}
