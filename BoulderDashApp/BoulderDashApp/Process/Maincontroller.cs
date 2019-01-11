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
            outputView.PrintMaze(Cave.First, Cave.Rockford.DiamondCounter, Cave.AmountOfDiamonds);
            outputView.Score(Cave.GetScore());
            Game();
            Console.ReadLine();
        }

        public void Game()
        {
            bool gameFinished = false;
            while (!gameFinished)
            {
                int seconds = 0;
                for (int i = 0; i < 3; i++)
                {
                    //eerst de Rockford 1 stap
                    MoveRockford();
                    if (Cave.Rockford.IsDestroyed)
                    {
                        outputView.PrintMaze(Cave.First, Cave.Rockford.DiamondCounter, Cave.AmountOfDiamonds);
                        outputView.Score(Cave.GetScore() + seconds*10);
                        outputView.RockfordIsKilledMessage();
                        return;
                    }
                    //Check if all diamonds are collected
                    if (Cave.Rockford.DiamondCounter == Cave.AmountOfDiamonds)
                    {
                        if (Cave.Exit != null)
                        {
                            Cave.Exit.Open();
                        }
                    }
                    //daarna de movables 1 stap
                    Cave.MoveMovables();
                    if (Cave.Rockford.IsDestroyed)
                    {
                        outputView.PrintMaze(Cave.First, Cave.Rockford.DiamondCounter, Cave.AmountOfDiamonds);
                        outputView.Score(Cave.GetScore() + seconds * 10);
                        outputView.RockfordIsKilledMessage();
                        return;
                    }



                    outputView.PrintMaze(Cave.First, Cave.Rockford.DiamondCounter, Cave.AmountOfDiamonds);
                    outputView.Score(Cave.GetScore());
                }
                seconds++;

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
