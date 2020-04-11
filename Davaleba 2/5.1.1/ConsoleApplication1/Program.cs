using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        private int tankCap;
        private int range;
        private string consumption;
        static void Main(string[] args)
        {
            Airplane airplane = new Airplane();
            Program program = new Program();

            program.tankCap = 702;
            program.range = 2500;
            program.consumption = "1L=5km";

            airplane.Passengers = 200;
            airplane.SoldTickets = 220;
        }
    }
}
