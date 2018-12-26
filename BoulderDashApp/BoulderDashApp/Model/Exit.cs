using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoulderDashApp.Model
{
    class Exit : Tile
    {

        public Exit()
        {
            OwnSymbol = '0';
        }

        public override void PlaceEntity(Tile previous)
        {
            throw new NotImplementedException();
        }

        public override bool PutEntityOnThisField(Cave cave, Tile previous, Tile next)
        {
            throw new NotImplementedException();
        }
    }
}
