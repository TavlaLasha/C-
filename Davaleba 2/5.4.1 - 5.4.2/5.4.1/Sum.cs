using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._4._1
{
    class Sum
    {
        int n1, n2;

        public int calc1(int n1, int n2)
        {
            this.n1 = n1;
            this.n2 = n2;

            return this.n1 + this.n2;
        }
        public int calc2(int n1, int n2)
        {
            this.n1 = n1;
            this.n2 = n2;

            return this.n1 * this.n2;
        }
    }
}
