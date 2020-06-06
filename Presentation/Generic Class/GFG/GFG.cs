using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GFG
{
    // We use < > to specify Parameter type 
    public class GFG<T>
    {
        // private data members 
        private T data;

        // using properties 
        public T value
        {
            // using accessors 
            set
            {
                this.data = value;
            }
            get
            {
                return this.data;
            }
        }
    }
}
