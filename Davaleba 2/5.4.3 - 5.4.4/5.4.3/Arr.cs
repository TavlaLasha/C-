using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._4._3
{
    class Arr
    {
        int[] Array;
        public int Solve1(int[] Arr1)
        {
            int i;
            this.Array = Arr1;
            for (i = 0; i < Arr1.Length; i++)
                if (Arr1[i] < 0)
                    break;
            return this.Array[i];
        }

        public int Solve2(int[] Arr2)
        {
            Array = Arr2;
            int min = Array[0];
            for (int i = 0; i < Array.Length; i++)
                if (min > Array[i])
                {
                    min = Array[i];
                }
            return min;

        }
    }
}
