using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoulderDashApp.Process
{
    class Maincontroller
    {
        private LevelData _levelData;

        public Model.Cave Cave { get; set; }

        public Maincontroller()
        {
            _levelData = new LevelData();
            _levelData.PrintMaze();
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
        }
    }
}
