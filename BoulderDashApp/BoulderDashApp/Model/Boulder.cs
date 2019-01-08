using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoulderDashApp.Model
{
    public class Boulder : Fallable
    {
        public Boulder()
        {
            Symbol = 'o';
            CanDie = false;
            CanDig = false;
            CanKill = true;
            IsCollectible = false;
        }

        public override void Collision(Entity entity)
        {
            //een rockford kan een boulder 1 plaats opschuiven
            if (entity.CanDig && entity.MoveDirection == Direction.LEFT || entity.CanDig && entity.MoveDirection == Direction.RIGHT)
            {
                MoveDirection = entity.MoveDirection;
                if (this.Tile.Tilelink.GetTile(MoveDirection).PlaceEntity(this))
                {
                    entity.Move();
                }
                MoveDirection = Direction.DOWN;

            }
            return;
        }

        public override void Destroy()
        {
            this.IsDestroyed = true;
            this.Tile.Entity = null;
            return;
        }

        // al de move methodes die los in de entity klassen staan moeten nog overerven van 1 move klasse. die moet dus nog gemaakt worden
        //public override bool Move()
        //{
        //    return this.Tile.Tilelink.GetTile(MoveDirection).PlaceEntity(this);

        //    //if (this.Tile.Tilelink.Below.Entity != null)
        //    //{
        //    //    FallSideWays(this.Tile.Tilelink.GetTile(MoveDirection));
        //    //}
        //}

        //private void FallSideWays(Tile tile)
        //{
            //    if (this.Tile.Left.Entity == null && this.Tile.Left.Below.Entity == null)
            //    {
            //        if (this.Tile.Left.PlaceEntity(this, null))
            //        {
            //            if (!this.Tile.Below.PlaceEntity(this, null))
            //            {
            //                this.Tile.Right.PlaceEntity(this, null);
            //            }
            //        }
            //    }
            //    else if (this.Tile.Right.Entity == null && this.Tile.Right.Below.Entity == null)
            //    {
            //        if (this.Tile.Right.PlaceEntity(this, null))
            //        {
            //            if (!this.Tile.Below.PlaceEntity(this, null))
            //            {
            //                this.Tile.Left.PlaceEntity(this, null);
            //            }
            //        }
            //    }
        //}
    }
}
