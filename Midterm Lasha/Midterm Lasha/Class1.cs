using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm_Lasha
{
    public abstract class Klienti
    {
        string[] klientebi = { "klienti1", "klienti2", "klienti3" };
        public void info()
        {
            for (int i = 0; i <= 2; i++)
            {
                Console.WriteLine(klientebi[i]);
            }
            Console.WriteLine('\n');
        }
    }

    public class Meanabre : Klienti
    {
        string fname = "klienti1";
        string lname = "klienti11";
        string id = "01000033241";
        DateTime openDate = new DateTime(2013,04,01);
        decimal money = 2550;
        float perc = 15;
        string[] s = new string[6];

        public string _fname() => this.fname;
        public string _lname() => this.lname;
        public string _id() => this.id;
        public DateTime Date() => this.openDate;
        public decimal _money() => this.money;
        public float _perc() =>  this.perc;
        public String[] ret()
        {
            s[0] = "Saxeli: " + _fname();
            s[1] = "Gvari: " + _lname();
            s[2] = "Piradi: " + _id();
            s[3] = Date().ToString();
            s[4] = "Tanxa: " + _money().ToString();
            s[5] = "Procenti: " + _perc().ToString();
            return this.s;
        }
    }

    public class Kreditori : Klienti
    {
        string fname = "klienti2";
        string lname = "klienti22";
        string id = "01000033241";
        DateTime giveDate = new DateTime(2014, 02, 11);
        decimal money = 3050;
        float perc = 10;
        decimal moneyLeft = 10150;

        string[] s = new string[7];
        public string _fname() => this.fname;
        public string _lname() => this.lname;
        public string _id() => this.id;
        public DateTime Date() => this.giveDate;
        public decimal _money() => this.money;
        public float _perc() => this.perc;
        public decimal _moneyLeft() => this.moneyLeft;
        public String[] ret()
        {
            s[0] = "Saxeli: "+_fname();
            s[1] = "Gvari: " + _lname();
            s[2] = "Piradi: "+_id();
            s[3] = Date().ToString();
            s[4] = "Tanxa: "+_money().ToString();
            s[5] = "Procenti: "+_perc().ToString();
            s[6] = "Darchenili Tanxa: "+_moneyLeft().ToString();
            return this.s;
        }
    }

    public class Organizacia : Klienti
    {
        string name = "res1";
        string id = "235112682";
        DateTime openADate = new DateTime(2012, 11, 24);
        string An = "235682";
        decimal money = 15320;
        string[] s = new string[5];

        public string _name() => this.name;
        public string _id() => this.id;
        public DateTime Date() => this.openADate;
        public string _an() => this.An;
        public decimal _money() => this.money;
        public String[] ret()
        {
            s[0] = "Dasaxeleba: " + _name();
            s[1] = "SN: " + _id();
            s[2] = "AN: " + _an();
            s[3] = Date().ToString();
            s[4] = "Tanxa: " + _money().ToString();
            return this.s;
        }
    }
}
