using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoulderDashApp.Model
{
    public class Fallable : Entity
    {
        public override void Collision(Entity entity)
        {
            return;
        }

        public override void Destroy()
        {
            return;
        }

        public override bool Move()
        {
            MoveDirection = Direction.DOWN;
            if (!this.Tile.Tilelink.GetTile(MoveDirection).PlaceEntity(this) )
            {
                if (!Tile.Tilelink.Below.Entity.CanDie) {
                    MoveDirection = Direction.RIGHT;
                    if (Fall())
                    {
                        return true;
                    }
                    MoveDirection = Direction.LEFT;
                    return Fall();
                }
                return false;
            }
            return true;
        }

        private bool Fall()
        {
            if (this.Tile.Tilelink.GetTile(MoveDirection).PlaceEntity(this))
            {
                if (this.Tile.Tilelink.GetTile(MoveDirection).PlaceEntity(this))
                {
                    MoveDirection = Direction.LEFT;
                    this.Tile.Tilelink.GetTile(MoveDirection).PlaceEntity(this);
                    return false;
                }
                return true;
            }
            return false;
        }
    }
}
