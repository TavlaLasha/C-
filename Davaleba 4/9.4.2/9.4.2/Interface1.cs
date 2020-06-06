using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._4._2
{
    public interface Interpeisi
    {
        int Min(int[] masivi1);
    }
    public class Sabazo
    {
        public int Maqsimaluri(int[] masivi2)
        {
            int max = masivi2[0];
            for (int indeqsi = 0; indeqsi < masivi2.Length; indeqsi++)
                if (max < masivi2[indeqsi]) max = masivi2[indeqsi];
            return max;
        }
    }
    public class Memkvidre : Sabazo, Interpeisi
    {
        public int Min(int[] masivi3)
        {
            int min = masivi3[0];
            for (int indeqsi = 0; indeqsi < masivi3.Length; indeqsi++)
                if (min > masivi3[indeqsi]) min = masivi3[indeqsi];
            return min;
        }
    }
}
