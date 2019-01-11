using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoulderDashApp.Model;

namespace BoulderDashApp.View
{
    class OutputView : Visitor
    {
        private char _drawString;
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
                    horizontal.Accept(this);
                    Console.Write(_drawString);
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

        public void GameWon(int endScore)
        {
            Console.WriteLine("Congatulations You have completed this level! Your end score is: " + endScore);
        }

        internal void RockfordIsKilledMessage()
        {
            
            Console.WriteLine("Rockfort died. Game Over!");
        }

        public void TimesUp()
        {
            Console.WriteLine("Times up! Game Over! ");
        }

        public void PrintDiamondCounter(int counter, int dias)
        {
            Console.WriteLine("DiamondCounter : " + counter);
        }

        public void Score(int score)
        {
            Console.WriteLine("Score = " + score);
        }

        public override void Visit(EmptyTIle tile)
        {
            _drawString = ' ';
        }

        public override void Visit(Boulder boulder)
        {
            _drawString = 'o';
        }

        public override void Visit(Diamond diamond)
        {
            _drawString = 'D';
        }

        public override void Visit(Exit exit)
        {
            _drawString = '0';
        }

        public override void Visit(Firefly firefly)
        {
            _drawString = 'F';
        }

        public override void Visit(HardenedMud hardenedMud)
        {
            _drawString = 'H';
        }

        public override void Visit(Mud mud)
        {
            _drawString = '▒';
        }

        public override void Visit(Rockford rockford)
        {
            _drawString = '@';
        }

        public override void Visit(Rubble rubble)
        {
            _drawString = 'R';
        }

        public override void Visit(Steelwall steelwall)
        {
            _drawString = '■';
        }

        public override void Visit(TNT tnt)
        {
            _drawString = 'T'; 
        }

        public override void Visit(Wall wall)
        {
            _drawString = '=';
        }
    }
}
