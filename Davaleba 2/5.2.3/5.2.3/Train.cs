using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._2._3
{
    class Train
    {
        private int wagonCount;
        private int passenjerCount;
        public double ticketPrice;
        public int soldTickets;

        public void writeInfo(int WagonCount, int PassenjerCount, double TicketPrice, int SoldTickets)
        {
            wagonCount = WagonCount;
            passenjerCount = PassenjerCount;
            ticketPrice = TicketPrice;
            soldTickets = SoldTickets;
        }
        public void printInfo()
        {
            Console.WriteLine($"+-----------------------+\nNumber of wagons: { wagonCount}\nNumber of Passengers: {passenjerCount}\nPrice ticket: {ticketPrice}\nSell ticket: {soldTickets}\n+-----------------------+");
        }
        public double ticketRevenue()
        {
            return ticketPrice * soldTickets;
        }
    }
}
