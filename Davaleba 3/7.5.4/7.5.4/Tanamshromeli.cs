using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._5._4
{
    abstract class Tanamshromeli
    {
        public abstract int Metodi();
    }
    class Memkvidre_2 : Tanamshromeli
    {
        int xelfasi_erti_tvis;
        public Memkvidre_2(int par1)
        {
            xelfasi_erti_tvis = par1;
        }
        public override int Metodi()
        {
            return xelfasi_erti_tvis * 12;
        }
    }
}
