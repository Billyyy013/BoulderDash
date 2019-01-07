using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoulderDashApp.Model
{
    public class Diamond : Entity
    {
        public Diamond()
        {
            this.MoveDirection = Direction.DOWN;
            Symbol = 'D';
            CanDie = false;
            CanDig = false;
            CanKill = true;
            IsCollectible = true;
        }

        public override void Collision(Entity entity)
        {
            if (entity.CanDig)
            {
                //iets van diamonds counter ++ ofzo TODO
                entity.DiamondCounter++;
                this.Tile.Entity = null;
                this.Tile.PlaceEntity(entity);
            }
        }

        public override bool Move()
        {
            return this.Tile.Tilelink.GetTile(MoveDirection).PlaceEntity(this);
        }

        public override void Destroy()
        {
            return;
        }

    }
}
