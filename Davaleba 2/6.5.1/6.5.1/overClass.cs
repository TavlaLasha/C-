using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._5._1
{
    class overClass
    {
        int Min;

        public overClass(int [] a)
        {
            Min = a[0];
            foreach (int num in a){
                if (num < Min)
                {
                    Min = num;
                }
            }
        }
        public overClass(overClass obj)
        {
            Min = obj.Min;
        }
        public void print(overClass lab)
        {
            Console.WriteLine($"Min number in array: {lab.Min}");
        }
    }
}
