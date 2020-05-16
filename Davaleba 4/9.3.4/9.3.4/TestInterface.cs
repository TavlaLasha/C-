using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._3._4
{
    interface ITestInterface
    {
        event EventHandler Array_Event;
    }
    class TestClass : ITestInterface
    {
        int[] arr = new int[5];
        public int this[int i]
        {
            set
            {
                arr[i] = value;
                if (GetMax() > 25)
                    Array_Event?.Invoke(this, new EventArgs {});
            }
            get { return arr[i]; }
        }
        public int GetMax()
        {
            int max = arr[0];
            for(int i=1; i<arr.Length; i++)
            {
                if (arr[i] > max)
                    max = arr[i];
            }
            return max;
        }
        public event EventHandler Array_Event;
    }
}
