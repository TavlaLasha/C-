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
        public List<string> avtorebi = new List<string>();
        public int gamocemis_weli { get; set; }
        public int gverdebis_raodenoba { get; set; }

        public abstract string PrintInfo();
        public abstract void SearchByYear(object[] obj, int sawyisi, int bolo);
    }
}
