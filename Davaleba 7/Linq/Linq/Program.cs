using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {   
            double TotalProfit = Product.GetAllProducts().Sum(std =>std.price);
            double MostExpensive = Product.GetAllProducts().Max(std => std.price);
            double Cheapest = Product.GetAllProducts().Min(std => std.price);
            //bool higherthantwo = Product.GetAllProducts().Any(std => std.price>2);

            Console.Write($"TotalProfit: {TotalProfit}\n");
            Console.Write($"Most Expensive: {MostExpensive}\n");
            Console.Write($"Cheapest: {Cheapest}\n");

            Console.ReadKey();
        }
    }
}
