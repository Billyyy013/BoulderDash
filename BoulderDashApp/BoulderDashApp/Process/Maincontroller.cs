﻿using System;
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

            outputView.PrintMaze(Cave.First, Cave.Rockford.CollectedEntities.Count, Cave.AmountOfDiamonds);
            outputView.Score(Cave.GetScore());

            Game();
            Console.ReadLine();
        }

        public void Game()
        {        
            while (Cave.LevelTime > Cave.PlayTime)
            {
                for (int i = 0; i < 3; i++)
                {
                    //eerst de Rockford 1 stap
                    MoveRockford();
                    if (!ChecksAfterMove())
                    {
                        return;
                    }
                    //daarna de movables 1 stap
                    Cave.MoveMovables();
                    if (!ChecksAfterMove())
                    {
                        return;
                    }
                    outputView.PrintMaze(Cave.First, Cave.Rockford.CollectedEntities.Count, Cave.AmountOfDiamonds);
                    outputView.Score(Cave.GetScore());
                }
                Cave.PlayTime++;
                
            }
            outputView.TimesUp();
        }

        private bool ChecksAfterMove()
        {
            if (Cave.Rockford.IsDestroyed)
            {
                outputView.PrintMaze(Cave.First, Cave.Rockford.CollectedEntities.Count, Cave.AmountOfDiamonds);
                outputView.Score(Cave.GetScore());
                outputView.RockfordIsKilledMessage();
                return false;
            }
            if (Cave.Exit != null && Cave.Exit.Entity != null)
            {
                int finalScore = Cave.GetScore() + ((Cave.LevelTime - Cave.PlayTime) * 10);
                outputView.GameWon(finalScore);
                return false;
            }
            //Check if all diamonds are collected
            if (Cave.Rockford.CollectedEntities.Count == Cave.AmountOfDiamonds)
            {
                if (Cave.Exit != null)
                {
                    Cave.Exit.Open();
                }
            }
            return true;
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
                if (key == ConsoleKey.UpArrow || key == ConsoleKey.DownArrow || key == ConsoleKey.LeftArrow || key == ConsoleKey.RightArrow || key == ConsoleKey.B)
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
                        case ConsoleKey.B:
                            return;
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
