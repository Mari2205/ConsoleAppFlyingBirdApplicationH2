using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppFlyingBirdApplicationH2
{
    public abstract class Bird
    {
        public abstract string SetLocation(double longitude, double latitude);
        public abstract string SetAltitude(double altitude);
    }

}
