using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._1._1_12._1._4
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                Console.Write("Sheiyvanet raime sityva: ");
                string str = Console.ReadLine();
                IList<int> ssList = new List<int>() { ',', ';', '.', '?', '!', ':' };

                int strlen = str.Length;
                int Bcount = str.Count(f => (f == 'b' || f == 'B' || f == 'ბ'));
                int numCount = str.Count(f => (Char.IsDigit(f)));
                int sasveniCount = str.Count(f => (ssList.Contains(f)));

                sb.Append($"\nSityvashi simboloebis raodenoba: {strlen}\n");
                sb.Append($"Sityvashi 'B' simbolos raodenoba: {Bcount}\n");
                sb.Append($"Sityvashi ciprebis raodenoba: {numCount}\n");
                sb.Append($"Sityvashi sasveni nishnebis raodenoba: {sasveniCount}\n");
                Console.WriteLine(sb);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}
