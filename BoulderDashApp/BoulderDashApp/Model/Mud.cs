using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoulderDashApp.Model
{
    class Mud : Tile
    {
        public override char Symbol { get; set; }

        public Mud()
        {
            Symbol = '▒';
        }
    }
}
