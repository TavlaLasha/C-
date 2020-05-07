using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._1._3
{
    class Program
    {
        private int carriage;
        private int passengerCap;
        static void Main(string[] args)
        {
            Program carriage = new Program();
            Train train = new Train();

            carriage.carriage = 2;
            carriage.passengerCap = 50;

            train.ticketPrice = 12;
            train.soldTickets = 45;

            Console.WriteLine($"We have {carriage.carriage} carriages \nand each carriage has capacity of {carriage.passengerCap} passengers");
            Console.WriteLine($"We sold {train.soldTickets} tickets \nfor {train.ticketPrice} Lari each");
            Console.ReadKey();
        }
    }
}
