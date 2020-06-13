using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm
{
    public class Wigni : Gamocema
    {
        public Wigni(string dasaxeleba, string avtori, int gamocemis_weli, int gverdebis_raodenoba)
        {
            this.dasaxeleba = dasaxeleba;
            avtorebi.Add(avtori);
            this.gamocemis_weli = gamocemis_weli;
            this.gverdebis_raodenoba = gverdebis_raodenoba;
        }
        
        public override string PrintInfo()
        {
            StringBuilder s = new StringBuilder();
            s.Append($"Dasaxeleba: {dasaxeleba}\n");
            s.Append($"Avtorebi: ");
            for(int i=0; i<= avtorebi.Count-1; i++)
            {
                if (avtorebi.Count > 1)
                    s.Append(avtorebi[i] + ", ");
                else
                    s.Append(avtorebi[i]);
            }
            s.Append($"\nGamocemis weli: {gamocemis_weli}\n");
            s.Append($"Gverdebis raodenoba: {gverdebis_raodenoba}\n");

            return s.ToString();
        }

        public override void SearchByYear(object obj, int sawyisi, int bolo)
        {
            throw new NotImplementedException();
        }
    }
}
