using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppFlyingBirdApplicationH2
{
    class Gui
    {
        public void GetDrawingOfBird(string wichBird)
        {
            Draw drawing = new Draw();

            if (wichBird == "pingvin")
            {
                wichBird = @"draw an pingvin";
            }
            else if (wichBird == "columbiae")
            {
                wichBird = @"draw an columbiae";
            }
            else
            {
                wichBird = @"draw an bird";
            }

            Console.WriteLine("here is an picture : \n" + drawing.DrawAnBrid(wichBird));
        }

        public void BridInfomation(string chouseAnBrid)
        {
            Bird pingvin = new Pingvin();
            Columbidae columbiae = new Columbidae();
            if (chouseAnBrid == "columbiae")
            {
                Console.WriteLine(columbiae.SetLocation(254, 50));
                Console.WriteLine(columbiae.SetAltitude(30));
                Console.WriteLine(columbiae.Fly());
            }
            else if (chouseAnBrid == "pingvin")
            {
                Console.WriteLine(pingvin.SetLocation(129, 150));
                Console.WriteLine(pingvin.SetAltitude(0));
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("pleace chose an brid there is in the database");
                Console.ResetColor();
            }
        }

        public void GetTermial()
        {
            Console.WriteLine("=============================================");
            Console.WriteLine("             Chose an bird           ");
            Console.WriteLine("=============================================");
            Console.WriteLine();
            Console.WriteLine("1. Pingvin");
            Console.WriteLine("2. Columbiae");

        }
    }
}
