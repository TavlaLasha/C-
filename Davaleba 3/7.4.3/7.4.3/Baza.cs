using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._4._3
{
    class Baza
    {
        public virtual int Metodi1(string str)
        {
            int count = 0;
            foreach(char c in str)
                if(c == ',' || c == '.')
                    count++;
            return count;
        }
    }
    class Memkvidre : Baza
    {
        //public List<string>chars = new List<string>{"a", "e", "i", "o", "u"};
        public override int Metodi1(string str)
        {
            int count = 0;
            foreach (char c in str)
                if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                    count++;
            return count;
        }
    }
}
