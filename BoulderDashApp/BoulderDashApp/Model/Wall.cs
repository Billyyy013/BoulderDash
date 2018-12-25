using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoulderDashApp.Model
{
    class Wall : Tile
    {
        public override char Symbol { get; set; }

        public Wall()
        {
            Symbol = '▬';
        }
    }
}
