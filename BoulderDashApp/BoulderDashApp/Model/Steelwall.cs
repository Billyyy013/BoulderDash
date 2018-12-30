using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoulderDashApp.Model
{
    class Steelwall : Wall
    {
        public Steelwall()
        {
            OwnSymbol = '■';
        }

        public override void PlaceEntity(Moveable entity, Tile next)
        {
            return;
        }
    }
}
