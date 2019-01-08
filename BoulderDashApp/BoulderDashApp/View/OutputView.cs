using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoulderDashApp.Model;

namespace BoulderDashApp.View
{
    class OutputView
    {

        public OutputView()
        {
            PrintWelcomeMessage();
        }

        public void PrintMaze(Tile first, int counter, int dias)
        {
            Console.Clear();
            Console.WriteLine();
            Model.Tile horizontal = first;
            Model.Tile vertical = first;

            while(vertical != null)
            {
                while(horizontal != null)
                {
                    Console.Write(horizontal.Symbol);
                    horizontal = horizontal.Tilelink.Right;
                }
                Console.WriteLine();
                vertical = vertical.Tilelink.Below;
                horizontal = vertical;
            }
            PrintDiamondCounter(counter, dias);
        }

        public void PrintWelcomeMessage()
        {
            Console.WriteLine("┌─────────────────────────────────────────────────────────┐");
            Console.WriteLine("| Welkom bij BoulderDash                                  |");
            Console.WriteLine("|                                                         |");
            Console.WriteLine("| Betekenis van de symbolen    |    Doel van het spel     |");
            Console.WriteLine("|                              |                          |");
            Console.WriteLine("|      @ : rockford            |    Duw met de truck      |");
            Console.WriteLine("|      ▒ : modder              |    De krat(ten)          |");
            Console.WriteLine("|      . : vloer               |    naar de bestemming    |");
            Console.WriteLine("|      o : steen               |                          |");
            Console.WriteLine("|      D : Diamant             |                          |");
            Console.WriteLine("|      0 : exit                |                          |");
            Console.WriteLine("|      ◙ : firefly             |                          |");
            Console.WriteLine("|      H : hardenedmud         |                          |");
            Console.WriteLine("|      T : TNT                 |                          |");
            Console.WriteLine("└─────────────────────────────────────────────────────────┘");
            Console.WriteLine();

        }

        internal void RockfordIsKilledMessage()
        {
            
            Console.WriteLine("Rockfort died. Game Over!");
        }

        public void PrintDiamondCounter(int counter, int dias)
        {
            Console.WriteLine("DiamondCounter : " + counter);
            Console.WriteLine("Diamonds To Collect: " + dias);
        }
    }
}
