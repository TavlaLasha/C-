using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14._2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> strList = new List<string> {"element1", "element2", "element3", "element4", "element5" };

            Console.WriteLine($"Pirveli elementi: {strList[0]}");
            Console.WriteLine($"List-is zoma: {strList.Count}\nElementebi:\n");
            strList.ForEach(s => Console.WriteLine(s));

            strList.Clear();
            Console.WriteLine($"\nElementebis raodenoba washlis shemdeg: {strList.Count}");
            Console.ReadKey();
        }
    }
}
