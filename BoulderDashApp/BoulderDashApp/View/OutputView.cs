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

        public void PrintMaze(Tile first)
        {
            Console.WriteLine();
            Model.Tile horizontal = first;
            Model.Tile vertical = first;

            while(vertical != null)
            {
                while(horizontal != null)
                {
                    Console.Write(horizontal.Symbol);
                    horizontal = horizontal.Right;
                }
                Console.WriteLine();
                vertical = vertical.Below;
                horizontal = vertical;
            }
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

        public void PrintDiamondCounter(int counter)
        {
            Console.WriteLine("DiamondCounter = " + counter);
        }
    }
}
