using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._3._2
{
    interface IEven
    {
        int setNum { set; }
    }
    class evenGive : IEven
    {
        private int X;
        public int setNum
        {
            set { if (value % 2 == 0) X = value; }
        }
    }
}
