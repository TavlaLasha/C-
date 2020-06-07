using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm
{
    public class Statia : Gamocema
    {
        public string jurnalis_dasaxeleba { set; get; }
        public int nomeri { set; get; }
        
        public Statia(string dasaxeleba, string avtori, int gamocemis_weli, int gverdebis_raodenoba, string jurnalis_dasaxeleba, int nomeri)
        {
            this.dasaxeleba = dasaxeleba;
            avtorebi.Add(avtori);
            this.gamocemis_weli = gamocemis_weli;
            this.gverdebis_raodenoba = gverdebis_raodenoba;
            this.jurnalis_dasaxeleba = jurnalis_dasaxeleba;
            this.nomeri = nomeri;
        }
        public override string PrintInfo()
        {
            StringBuilder s = new StringBuilder();
            s.Append($"Dasaxeleba: {dasaxeleba}\n");
            s.Append($"Avtorebi: ");
            for (int i = 0; i <= avtorebi.Count - 1; i++)
            {
                if (avtorebi.Count > 1)
                    s.Append(avtorebi[i] + ", ");
                else
                    s.Append(avtorebi[i]);
            }
            s.Append($"\nGamocemis weli: {gamocemis_weli}\n");
            s.Append($"Gverdebis raodenoba: {gverdebis_raodenoba}\n");
            s.Append($"Jurnalis dasaxeleba: {jurnalis_dasaxeleba}\n");
            s.Append($"Nomeri: {nomeri}\n");

            return s.ToString();
        }

        public override void SearchByYear(object[] obj, int sawyisi, int bolo)
        {
            throw new NotImplementedException();
        }
    }
}
