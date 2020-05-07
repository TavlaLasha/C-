using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter amount of wagons: ");
            int WagonCount = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter amount of Passengers: ");
            int PassenjerCount = Convert.ToInt32(Console.ReadLine());

            Train train = new Train();

            Console.Write("Ticket price: ");
            train.ticketPrice = Convert.ToInt32(Console.ReadLine());

            Console.Write("Sold tickets: ");
            train.soldTickets = Convert.ToInt32(Console.ReadLine());

            train.writeInfo(WagonCount, PassenjerCount, train.ticketPrice, train.soldTickets);
            train.printInfo();

            train.ticketRevenue();

            Console.WriteLine($"Revenue is: {train.ticketRevenue()}");
            Console.ReadKey();
        }
    }
}
