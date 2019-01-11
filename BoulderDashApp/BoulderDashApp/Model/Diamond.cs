using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoulderDashApp.View;

namespace BoulderDashApp.Model
{
    public class Diamond : Fallable
    {
        public Diamond()
        {
            CanDie = false;
            CanDig = false;
            CanKill = true;
            IsCollectible = true;
        }

        public override void Accept(Visitor visitor)
        {
            visitor.Visit(this);
        }

        public override void Collision(Entity entity)
        {
            if (entity.CanDig)
            {
                entity.DiamondCounter++;
                this.Tile.Entity = null;
                this.Tile.PlaceEntity(entity);
                this.IsDestroyed = true;
            }
        }

        public override void Destroy()
        {
            return;
        }

    }
}
