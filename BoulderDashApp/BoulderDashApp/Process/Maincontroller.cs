using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            _levelData.BuildMaze();
            Cave = _levelData.Cave;
            outputView.PrintMaze(Cave.First);
            MoveRockford();
            Console.ReadLine();
        }

        public void Game()
        {
            //3 stappen per "seconde"
            //dit is een seconde
            for (int i = 0; i < 3; i++)
            {
                //eerst de Rockford 1 stap
                MoveRockford();
                //daarna de fireflys 1 stap
                Cave.MoveFireflys();
            }
            
        }

        public void MoveRockford()
        {
            //Vraagt om input speler
            //Voert de move uit die de speler aangeeft

            inputView.AskForArrowInput();

            //dit moet nog veranderd worden
            while (true)
            {
                ConsoleKey key = inputView.RetrieveConsoleKey();
                Model.Tile currentTile = Cave.CurrentRockford;
                if (key == ConsoleKey.UpArrow || key == ConsoleKey.DownArrow || key == ConsoleKey.LeftArrow || key == ConsoleKey.RightArrow)
                {
                    switch (key)
                    {
                        case ConsoleKey.UpArrow:
                            if (currentTile.Above.Above == null) { break; }
                            if (Cave.CurrentRockford.Above.PutEntityOnThisField(Cave, Cave.CurrentRockford, Cave.CurrentRockford.Above.Above))
                            {
                                Cave.CurrentRockford = Cave.CurrentRockford.Above;
                            }
                            break;
                        case ConsoleKey.DownArrow:
                            if (currentTile.Below.Below == null) { break; }
                            if (Cave.CurrentRockford.Below.PutEntityOnThisField(Cave, Cave.CurrentRockford, Cave.CurrentRockford.Below.Below))
                            {
                                Cave.CurrentRockford = Cave.CurrentRockford.Below;
                            }
                            break;
                        case ConsoleKey.LeftArrow:
                            if (currentTile.Left.Left == null) { break; }
                            if (Cave.CurrentRockford.Left.PutEntityOnThisField(Cave, Cave.CurrentRockford, Cave.CurrentRockford.Left.Left))
                            {
                                Cave.CurrentRockford = Cave.CurrentRockford.Left;
                            }
                            break;
                        case ConsoleKey.RightArrow:
                            if (currentTile.Right.Right == null) { break; }
                            if (Cave.CurrentRockford.Right.PutEntityOnThisField(Cave, Cave.CurrentRockford, Cave.CurrentRockford.Right.Right))
                            {
                                Cave.CurrentRockford = Cave.CurrentRockford.Right;
                            }
                            break;
                    }
                    outputView.PrintMaze(Cave.First);
                }
                else
                {
                    inputView.InvalidInputMessage();
                }
            }
        }
    }
}
