using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoulderDashApp.Model
{
    class Mud : Tile
    {

        public Mud()
        {
            OwnSymbol = '▒';
        }

        public override bool PutEntityOnThisField(Cave cave, Tile previous, Tile next)
        {
            if (Entity == null)
            {
                Entity = previous.Entity;
                previous.Entity = null;
                return true;
            }
            else
            {
                if (next.Entity != null) { return false; }
                if (next.PutEntityOnThisField(cave, this, next))
                {
                    Entity = previous.Entity;
                    previous.Entity = null;
                    return true;
                }
                return false;
            }
        }

        public override void PlaceEntity(Tile previous)
        {
            Entity = previous.Entity;
            previous.Entity = null;
        }
    }
}
