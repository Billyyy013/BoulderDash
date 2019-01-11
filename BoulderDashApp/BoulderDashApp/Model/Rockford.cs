using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoulderDashApp.Model
{
    public class Rockford : Entity
    {
        public int Score { get { return DiamondCounter * 10; } }
        public Rockford()
        {
            Symbol = '@';
            CanDie = true;
            CanDig = true;
            CanKill = false;
            IsCollectible = false;
        }

        public override void Collision(Entity entity)
        {
            if (entity.CanKill && !entity.IsCollectible)
            {
                this.Destroy();
            }
        }

        public override void Destroy()
        {
            IsDestroyed = true;
            this.Tile.Entity = null;
        }

        public override bool Move()
        {
            return Tile.Tilelink.GetTile(MoveDirection).PlaceEntity(this);
        }
    }
}
