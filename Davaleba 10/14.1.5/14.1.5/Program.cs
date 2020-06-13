using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14._1._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable() { {1, "Pirveli" }, { 2, "Meore" }, { 3, "Mesame" }, { 4, "Meotxe" }, { 5, "Mexute" } };

            ht.Add(10, "Damatebuli1");
            ht.Add(8, "Damatebuli2");

            Console.WriteLine("Length: {0}", ht.Count);

            foreach (var key in ht.Keys)
                Console.WriteLine("Key: {0}, Value: {1}", key, ht[key]);
            Console.ReadKey();
        }
    }
}
