using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppFlyingBirdApplicationH2
{
    class Pingvin : Bird
    {
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
            //Denne metode vil vil blive implementeret for en pingvin fordi en pingvin kan dykke
            string altiude = $"i´m at this altitude {altitude}";
            return altiude;
        }
    }
}

