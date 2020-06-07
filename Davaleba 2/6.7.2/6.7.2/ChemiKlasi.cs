using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._7._2
{
    class ChemiKlasi
    {
        public static int [] nums;

        public ChemiKlasi(int[] _nums)
        {
            nums = _nums;
        }
        int Kenti_Jami()
        {
            int jami = 0;
            for (int i = 0; i < nums.Length; i++)
                if (nums[i] % 2 == 1) jami += nums[i];
            return jami;
        }
        public static int StatikuriMetodi(ChemiKlasi obieqti)
        {
            return obieqti.Kenti_Jami();
        }
    }
}
