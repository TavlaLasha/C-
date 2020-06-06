using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._1._2
{
    class Martkutxedi
    {
        protected int fuze;
    }
    class Memkvidre:Martkutxedi
    {
        int simagle;

        public Memkvidre(int gverdi_A,int gverdi_B)
        {
            simagle = gverdi_A;
            fuze = gverdi_B;
        }
        public int Fartobi()
        {
            return simagle * fuze;
        }
    }
}
