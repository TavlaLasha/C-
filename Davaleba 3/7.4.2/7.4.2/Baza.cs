using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._4._2
{
    class Baza
    {
        public virtual int Metodi1(int [] arr)
        {
            return arr.Sum();
        }
    }
    class Memkvidre : Baza
    {
        public override int Metodi1(int[] arr)
        {
            int mult=1;
            foreach (int num in arr)
                mult *= num;
            return mult;
        }
    }
}
