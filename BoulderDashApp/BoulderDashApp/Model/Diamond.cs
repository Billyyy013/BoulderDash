using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoulderDashApp.Model
{
    public class Diamond : Moveable
    {
        public Diamond()
        {
            Symbol = 'D';
        }

        public override void Collision(Moveable entity, Tile next)
        {
            if (entity.Symbol == '@')
            {
                //iets van diamonds counter ++ ofzo TODO
                entity.DiamondCounter++;
                this.Tile.Entity = null;
                this.Tile.PlaceEntity(entity, next);
            }
        }

        public override void Move(Tile tile, Tile next)
        {
            next.PlaceEntity(this, null);
        }

        public override void Destroy()
        {
            return;
        }

    }
}
