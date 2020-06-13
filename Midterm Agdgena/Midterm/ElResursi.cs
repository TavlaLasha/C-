using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm
{
    class ElResursi : Gamocema
    {
        public string bmuli { get; set; }
        public string anotacia { get; set; }

        public ElResursi(string dasaxeleba, string avtori, int gamocemis_weli, string bmuli, string anotacia)
        {
            this.dasaxeleba = dasaxeleba;
            avtorebi.Add(avtori);
            this.gamocemis_weli = gamocemis_weli;
            this.bmuli = bmuli;
            this.anotacia = anotacia;
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
            s.Append($"Bmuli: {bmuli}\n");
            s.Append($"Anotacia: {anotacia}\n");

            return s.ToString();
        }

        public override void SearchByYear(object obj, int sawyisi, int bolo)
        {
            throw new NotImplementedException();
        }
    }
}
