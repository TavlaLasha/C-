using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();

            Console.WriteLine("Type student name: ");
            string _fn = Console.ReadLine();
            Console.WriteLine("Type student last name: ");
            string _ln = Console.ReadLine();
            Console.WriteLine("Type student age: ");
            short _age = Convert.ToInt16(Console.ReadLine());

            student.accept(_fn, _ln, _age);
            student.print();
            Console.ReadKey();
        }
    }
}
