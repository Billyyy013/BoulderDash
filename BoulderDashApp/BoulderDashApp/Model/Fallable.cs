using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoulderDashApp.View;

namespace BoulderDashApp.Model
{
    public abstract class Fallable : Entity
    {
        public Fallable()
        {
            this.MoveDirection = Direction.DOWN;
            
        }

        public override bool Move()
        {
            if (this.IsDestroyed) {
                if (this.Tile != null)
                {
                    this.Tile.Entity = null;
                    this.Tile = null;
                }
                return false;
            }

            MoveDirection = Direction.DOWN;
            if (!this.Tile.Tilelink.GetTile(MoveDirection).PlaceEntity(this))
            {
                if (Tile.Tilelink.Below.Entity != null)
                {
                    return FallSideWays();
                }
                return false;
            }
            return true;
        }
        protected bool FallSideWays()
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
        protected bool Fall(Direction d)
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
