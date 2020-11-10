using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppFlyingBirdApplicationH2
{
    class Program
    {
        static void Main(string[] args)
        {
            Gui gui = new Gui();

            gui.GetTermial();
            int usrChosenNum = int.Parse(Console.ReadLine());
            string birdType;
            switch (usrChosenNum)
            {
                case 1:
                    birdType = "pingvin";
                    gui.GetDrawingOfBird(birdType);
                    gui.BridInfomation(birdType);
                    break;

                case 2:
                    birdType = "columbiae";
                    gui.GetDrawingOfBird(birdType);
                    gui.BridInfomation(birdType);

                    break;

                default:
                    Console.WriteLine("Please enter a valid number ");
                    break;
            }

            Console.ReadKey();
        }
    }
}
