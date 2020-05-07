using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._5._3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Random rand = new Random();
                int[] array = new int[100];
                for (int i = 0; i < 100; i++)
                {
                    array[i] = rand.Next(1, 100);
                }
                var dict = new Dictionary<int, int>();

                foreach (var value in array)
                {
                    if (dict.ContainsKey(value))
                        dict[value]++;
                    else
                        dict[value] = 1;
                }

                foreach (var pair in dict)
                    Console.WriteLine("Value {0} occurred {1} times.", pair.Key, pair.Value);
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
