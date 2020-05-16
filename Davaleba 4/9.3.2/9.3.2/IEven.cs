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
        private int x;
        public int setNum
        {
            set
            {
                if (value % 2 == 0)
                    x = value;
                else
                    throw new ArgumentException("Sheyvanili ricxvi unda iyos luwi");
            }
        }
    }
}
