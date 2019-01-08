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
    }
}
