using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm
{
    public abstract class Gamocema
    {
        public string dasaxeleba { get; set; }
        public string avtori { get; set; }
        public DateTime gamocemis_weli { get; set; }
        public int gverdebis_raodenoba { get; set; }

        public abstract string PrintInfo();
        public abstract string SearchByDate();
    }
    public class Wigni : Gamocema
    {
        public Wigni(string dasaxeleba, string avtori, DateTime gamocemis_weli, int gverdebis_raodenoba)
        {
            this.dasaxeleba = dasaxeleba;
            this.avtori = avtori;
            this.gamocemis_weli = gamocemis_weli;
            this.gverdebis_raodenoba = gverdebis_raodenoba;
        }
        public override string PrintInfo()
        {
            return "d";
        }

        public override string SearchByDate()
        {
            return "d";
        }
    }
    public class Vka : Gamocema
    {

    }
}
