using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._3._4
{
    class Car
    {
        private string color;
        private byte doors;
        public string owner;
        public string brand;

        public Car(string color, byte doors, string owner, string brand)
        {
            this.color = color;
            this.doors = doors;
            this.owner = owner;
            this.brand = brand;
        }
        public void printInfo()
        {
            Console.WriteLine($"+-----------------------+\nColor: { color}\nDoors: {doors}\nOwner Last Name: {owner}\nBrand: {brand}\n+-----------------------+");
        }
    }
}
