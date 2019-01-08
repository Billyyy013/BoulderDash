using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoulderDashApp.Model;
using BoulderDashApp.View;

namespace BoulderDashApp.Process
{
    class Maincontroller
    {
        private View.OutputView outputView;
        private InputView inputView;
        private LevelData _levelData;

        public Model.Cave Cave { get; set; }

        public Maincontroller()
        {
            outputView = new View.OutputView();
            inputView = new View.InputView();
            _levelData = new LevelData();
            _levelData.BuildMaze(inputView.AskForLevelNumber());
            Cave = _levelData.Cave;
            outputView.PrintMaze(Cave.First);
            Game();
            Console.ReadLine();
        }

        public void Game()
        {
            bool gameFinished = false;
            int seconds = 0;
            while (!gameFinished)
                //3 stappen per "seconde"
                //dit is een seconde
                for (int i = 0; i < 3; i++)
                {
                    //eerst de Rockford 1 stap
                    MoveRockford();
                    //Check if all diamonds are collected
                    if (Cave.Rockford.DiamondCounter == Cave.Diamonds.Count)
                    {
                        if (Cave.Exit != null)
                        {
                            Cave.Exit.Open();
                        }
                    }
                    //daarna de movables 1 stap
                    Cave.MoveMovables();
                    //view stuff dat hier niet hoort
                    Console.Clear();
                    outputView.PrintMaze(Cave.First);
                    outputView.PrintDiamondCounter(Cave.Rockford.DiamondCounter);
                    Console.WriteLine(Cave.Diamonds.Count);
                }
            seconds++;
            if (seconds == 30)
            {
                //laat tnt exploderen of geef door en laat ergens anders gebeuren
            }

        }

        

        public void MoveRockford()
        {
            //Vraagt om input speler
            //Voert de move uit die de speler aangeeft

            inputView.AskForArrowInput();

            //dit moet nog veranderd worden
            bool correctInput = false;
            while (!correctInput)
            {

                Rockford rockford = Cave.Rockford;
                ConsoleKey key = inputView.RetrieveConsoleKey();
                if (key == ConsoleKey.UpArrow || key == ConsoleKey.DownArrow || key == ConsoleKey.LeftArrow || key == ConsoleKey.RightArrow)
                {
                    switch (key)
                    {
                        case ConsoleKey.UpArrow:
                            rockford.MoveDirection = Direction.UP;
                            break;
                        case ConsoleKey.DownArrow:
                            rockford.MoveDirection = Direction.DOWN;
                            break;
                        case ConsoleKey.LeftArrow:
                            rockford.MoveDirection = Direction.LEFT;
                            break;
                        case ConsoleKey.RightArrow:
                            rockford.MoveDirection = Direction.RIGHT;
                            break;
                    }
                    rockford.Move();

                    correctInput = true;
                }
                else
                {
                    inputView.InvalidInputMessage();
                }
            }
        }
    }
}
