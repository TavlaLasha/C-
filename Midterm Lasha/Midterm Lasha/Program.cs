using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Midterm_Lasha
{
    class Program
    {
        static void Main(string[] args)
        {
            string[][] data = new string[3][];
            Meanabre m = new Meanabre();
            Kreditori k = new Kreditori();
            Organizacia o = new Organizacia();
            string[] Arr1 = m.ret();
            string[] Arr2 = k.ret();
            string[] Arr3 = o.ret();

            data[0] = Arr1;
            data[1] = Arr2;
            data[2] = Arr3;
            m.info();
            
            for (int i = 0; i < data.Length; i++)
            {
                Console.WriteLine("Klienti"+(i+1));
                for (int j = 0; j < data[i].Length; j++)
                {
                    Console.WriteLine(data[i][j]);
                }
                Console.WriteLine('\n');
            }
        Re: Console.WriteLine("Klientis mosadzebnad sheiyvanet tarigis shualedi. Default(01/01/2013 - 12/12/2014)\n");
            Console.WriteLine("Minimaluri:");
            string minD = Console.ReadLine();
            Console.WriteLine("Maqsimaluri:");
            string maxD = Console.ReadLine();
            Console.WriteLine('\n');
            string info = "Sheyvanil shualedshi\n";
            if (minD == "" && maxD == "")
            {
                minD = "01/01/2013";
                maxD = "12/12/2014";
                info = "Default shualedshi\n";
            }
            DateTime date1;
            DateTime date2;

            try
            {
                date1 = DateTime.ParseExact(minD, "d/M/yyyy", CultureInfo.InvariantCulture);
                date2 = DateTime.ParseExact(maxD, "d/M/yyyy", CultureInfo.InvariantCulture);
                Find(date1, date2, data, info);
            }
            catch
            {
                Console.WriteLine("Tarigis pormati arasworia. Scadet tavidan. Sworia: d/M/yyyy");
                goto Re;
            }
        }
        static void Find(DateTime date1, DateTime date2, String[][] dataa, string inf)
        {
            Console.WriteLine(inf);
            int A = 0;
            for (int c=0; c<=2; c++)
            {
                int d1 = DateTime.Compare(date1, Convert.ToDateTime(dataa[c][3]));
                int d11 = DateTime.Compare(date2, Convert.ToDateTime(dataa[c][3]));
                if (d1 < 0)
                {
                    if (d11 > 0)
                    {
                        A++;
                        Console.WriteLine("Klienti" + (c + 1));
                        for (int i = 0; i < dataa[c].Length; i++)
                        {
                            Console.WriteLine(dataa[c][i]);
                        }
                        Console.WriteLine('\n');
                    }
                }
            }
            if (A == 0)
            {
                Console.WriteLine("klienti ver moidzebna.");
            }
            Console.ReadKey();
        }
    }
}
    
