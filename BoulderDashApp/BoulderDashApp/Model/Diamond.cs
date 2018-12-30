using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoulderDashApp.Model
{
    public class Diamond : Fallable
    {
        public Diamond()
        {
            Symbol = 'D';
        }

        public override void Collision(Entity entity, Tile next)
        {
            if (entity.Symbol == '@')
            {
                //iets van diamonds counter ++ ofzo TODO
                entity.DiamondCounter++;
                this.Tile.Entity = null;
                this.Tile.PlaceEntity(entity, next);
            }
        }

        public void Move(Tile tile)
        {
            tile.PlaceEntity(this, null);
        }
    }
}
