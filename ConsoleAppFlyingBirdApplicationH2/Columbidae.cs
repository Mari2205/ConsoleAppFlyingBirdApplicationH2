using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppFlyingBirdApplicationH2
{

    class Columbidae : Bird, IFlying
    {

        public string Fly()
        {
            return "i´m can fly";
        }


        /// <summary>
        /// longitude = y/længde
        /// latitude = x/breddegander
        /// </summary>
        /// <param name="longitude"></param>
        /// <param name="latitude"></param>
        public override string SetLocation(double longitude, double latitude)
        {
            //sæt en lokation
            string location = $"i´m at this location ({longitude} , {latitude})";
            return location;
        }

        public override string SetAltitude(double altitude)
        {
            //sæt en altiude
            string altiude = $"i´m at this altitude {altitude}";
            return altiude;
        }
    }
}
