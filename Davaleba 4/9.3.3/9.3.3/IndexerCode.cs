using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._3._3
{
    interface IndexerCode
    {
        int this[int i] { set; get; }
    }
    class oddGive : IndexerCode
    {
        int[] arr = new int[5];
        public int this[int i]
        {
            set
            { if (value % 2 != 0)
                    arr[i] = value;
                else
                    throw new ArgumentException("Sheyvanili ricxvi unda iyos kenti");
            }
            get { return arr[i]; }
        }
    }
}
