using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._5._2
{
    abstract class Train
    {
        public abstract int Gamotvla(int time, int kilometers);
    }
    class FirstDerive : Train
    {
        public override int Gamotvla(int time, int kilometers)
        {
            return time * kilometers;
        }
    }
    class SecondDerive : Train
    {
        public override int Gamotvla(int energy, int kilometersWent)
        {
            return energy * kilometersWent;
        }
    }
}
