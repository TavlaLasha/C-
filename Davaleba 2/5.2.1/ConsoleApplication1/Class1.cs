using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Calculate
    {
        public double average(int[] grades)
        {
            double sum = 0;
            for(int i = 0; i < grades.Length; i++)
            {
                sum += grades[i];
            }
            return sum / grades.Length;
        }
    }
}
