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
    }
}
