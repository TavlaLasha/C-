using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._2._3
{
    class Televizori
    {
        public int namushevari_saatebis_raodenoba;
        public int wati_erti_saati;
        public Televizori(int par1)
        {
            namushevari_saatebis_raodenoba = par1;
        }
        public Televizori(int par1, int par2)
        {
            wati_erti_saati = par1;
            namushevari_saatebis_raodenoba = par2;
        }
    }
    class Memkvidre_3 : Televizori
    {
        public int saatebis_raodenoba;
        public Memkvidre_3(int par5) : base(par5)
        {
            saatebis_raodenoba = namushevari_saatebis_raodenoba;
        }
    }
    class Memkvidre_4 : Televizori
    {
        public int watebis_raodenoba;
        public Memkvidre_4(int par3, int par4) : base(par3, par4)
        {
            watebis_raodenoba = wati_erti_saati * namushevari_saatebis_raodenoba;
        }
    }
}
