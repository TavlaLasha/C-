using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._2._2
{
    class Student
    {
        private string fn;
        private string ln;
        private short age;
        private void give(string _fn, string _ln, int _age)
        {
            fn = _fn;
            ln = _ln;
            age = _age;
        }
        public void accept(string _fn, string _ln, int _age)
        {
            give(_fn, _ln, _age);
        }
        public void print()
        {
            Console.WriteLine($"First name: {fn}\nLast name: {ln}\nAge: {age}");
        }
    }
}
