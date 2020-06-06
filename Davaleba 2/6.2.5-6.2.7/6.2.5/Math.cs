using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._2._5
{
    class Math
    {
        public int Math_(params int [] numbers)
        {
            int result = 0;

            for(int i=0;i<numbers.Length ;i++)
            {
                if (numbers[i] > 0) result++;
            }
            return result;
        }
    }
    class Math2
    {
        public int Math_(params int[] numbers)
        {
            int result = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0) result++;
            }
            return result;
        }
    }
    class Math3
    {
        public int Math_(params int[] numbers)
        {
            int result = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i]>result)
                    result = numbers[i];
            }
            return result;
        }
    }
}
