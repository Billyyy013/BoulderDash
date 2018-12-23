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

        public Maincontroller()
        {
            _levelData = new LevelData();
            _levelData.PrintMaze();
            Console.ReadLine();
        }
    }
}
