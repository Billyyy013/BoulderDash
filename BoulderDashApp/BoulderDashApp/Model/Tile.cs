using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoulderDashApp.Model
{
    public abstract class Tile
    {
        public char Symbol
        {
            get
            {
                if (Entity != null)
                {
                    return Entity.Symbol;
                }
                else
                {
                    return OwnSymbol;
                }
            }
        }
        
        public char OwnSymbol { get; set; }

        public Tile Above { get; set; }
        public Tile Below { get; set; }
        public Tile Left { get; set; }
        public Tile Right { get; set; }

        public Entity Entity { get; set; }

        public abstract bool PutEntityOnThisField(Cave cave, Tile previous, Tile next);

        public abstract void PlaceEntity(Tile previous);

    }
}
