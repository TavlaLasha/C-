using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._1._3
{//CHEMIT UBRALOD DAVAMATE SIMAGLE ROM MONACEMEBIS SHEYVANIS =>
                    //DROS GAMOCHNDES FUDZESTAN ERTAD ES ARIYO MOCEMULI DAVALEBASHI...
    class Martkutxedi
    {
        protected int fudze;
        protected int simagle;

        public Martkutxedi()
        {
            fudze = 0;
            simagle = 0;
        }
        public Martkutxedi(int side_B, int side_A)
        {
            simagle = side_A;
            fudze = side_B;
        }
        public void See(Martkutxedi see)
        {
            Console.WriteLine($"fudze: {see.fudze}\nSimagle: {see.simagle}");
        }
    }
    class Memkvidre:Martkutxedi
    {
        private int simagle;
        public Memkvidre(int side_b,int side_a)
        {
            simagle = side_a;
            fudze = side_b;
        }
        public int Fartobi()
        {
            return fudze * simagle;
        }
    }
}
