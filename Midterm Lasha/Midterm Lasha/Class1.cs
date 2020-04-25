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
        int id = 01000033241;
        DateTime openDate = new DateTime(2013,04,01);
        long money = 2550;
        int perc = 15;
        string[] s = new string[6];

        public string _fname() => this.fname;
        public string _lname() => this.lname;
        public int _id() => this.id;
        public DateTime Date() => this.openDate;
        public long _money() => this.money;
        public int _perc() =>  this.perc;
        public String[] ret()
        {
            s[0] = "Saxeli: " + _fname();
            s[1] = "Gvari: " + _lname();
            s[2] = "Piradi: " + _id().ToString();
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
        int id = 01000033241;
        DateTime giveDate = new DateTime(2014, 02, 11);
        long money = 3050;
        int perc = 10;
        long moneyLeft = 10150;

        string[] s = new string[7];
        public string _fname() => this.fname;
        public string _lname() => this.lname;
        public int _id() => this.id;
        public DateTime Date() => this.giveDate;
        public long _money() => this.money;
        public int _perc() => this.perc;
        public long _moneyLeft() => this.moneyLeft;
        public String[] ret()
        {
            s[0] = "Saxeli: "+_fname();
            s[1] = "Gvari: " + _lname();
            s[2] = "Piradi: "+_id().ToString();
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
        int id = 235112682;
        DateTime openADate = new DateTime(2012, 11, 24);
        int An = 235682;
        long money = 15320;
        string[] s = new string[5];

        public string _name() => this.name;
        public int _id() => this.id;
        public DateTime Date() => this.openADate;
        public int _an() => this.An;
        public long _money() => this.money;
        public String[] ret()
        {
            s[0] = "Dasaxeleba: " + _name();
            s[1] = "SN: " + _id().ToString();
            s[2] = "AN: " + _an().ToString();
            s[3] = Date().ToString();
            s[4] = "Tanxa: " + _money().ToString();
            return this.s;
        }
    }
}
