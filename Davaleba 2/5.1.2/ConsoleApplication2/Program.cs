using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        private string Name;
        private string Last_Name;
        private int Age;
        static void Main(string[] args)
        {
            Program student = new Program();
            University university = new University();

            student.Name = "Lasha";
            student.Last_Name = "Tavlalashvili";
            student.Age = 19;

            university.Uni_Name = "GAU";
            university.Course = 2;
        }
    }
}
