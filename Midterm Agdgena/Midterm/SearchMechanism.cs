using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm
{
    class SearchMechanism : Gamocema
    {
        public override void SearchByYear(object[] obj, int sawyisi, int bolo)
        {
            //Ver avamushave
            /*foreach(object i in obj)
            {
                if (i.gamocemis_weli > bolo && i.gamocemis_weli< sawyisi)
                {
                    i.PrintInfo();
                }
            }*/
        }
        public override string PrintInfo()
        {
            throw new NotImplementedException();
        }
    }
}
