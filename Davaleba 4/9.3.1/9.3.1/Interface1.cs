using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._3._1
{
    interface ICalculate
    {
        double square(double A);
        double cube(double A);
    }
    public class methods : ICalculate
    {
        public double square(double A)
        {
            return Math.Pow(A, 2);
        }
        public double cube(double A)
        {
            return Math.Pow(A, 3);
        }
    }
}
