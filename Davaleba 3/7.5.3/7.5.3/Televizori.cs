using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._5._3
{
    abstract class Televizori
    {
        public abstract int Metodi();
    }
    class Memkvidre_1 : Televizori
    {
        int Wati_Erti_Saati;
        int Namushevari_Saatebi;
        public Memkvidre_1(int par1, int par2)
        {
            Wati_Erti_Saati = par1;
            Namushevari_Saatebi = par2;
        }
        public override int Metodi()
        {
            return Wati_Erti_Saati * Namushevari_Saatebi;
        }
    }
}
