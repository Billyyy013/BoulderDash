using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoulderDashApp.Model
{
    public abstract class Fallable : Entity
    {
        public override bool Move()
        {
            MoveDirection = Direction.DOWN;
            if (!this.Tile.Tilelink.GetTile(MoveDirection).PlaceEntity(this) )
            {
                if (Tile.Tilelink.Below.Entity != null)
                {
                    return FallSideWays();
                }
                return false;
            }
            return true;
        }
        private bool FallSideWays()
        {
            if (!Tile.Tilelink.Below.Entity.CanDie)
            {
                MoveDirection = Direction.RIGHT;
                if (Fall(Direction.LEFT))
                {
                    return true;
                }
                MoveDirection = Direction.LEFT;
                return Fall(Direction.RIGHT);
            }
            return false;
        }
        private bool Fall(Direction d)
        {
            bool canKill = this.CanKill;
            this.CanKill = false;
            if (this.Tile.Tilelink.GetTile(MoveDirection).PlaceEntity(this))
            {
                this.CanKill = canKill;
                MoveDirection = Direction.DOWN;
                if (!this.Tile.Tilelink.GetTile(MoveDirection).PlaceEntity(this))
                {
                    MoveDirection = d;
                    this.Tile.Tilelink.GetTile(MoveDirection).PlaceEntity(this);
                    MoveDirection = Direction.DOWN;
                    return false;
                }
                return true;
            }
            this.CanKill = canKill;
            MoveDirection = Direction.DOWN;
            return false;
        }
    }
}
