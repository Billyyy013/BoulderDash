using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoulderDashApp.View;

namespace BoulderDashApp.Model
{
    public class EmptyTIle : Tile
    {

        public override void Accept(Visitor visitor)
        {
            if(Entity != null)
            {
                Entity.Accept(visitor);
            } else
            {
                visitor.Visit(this);
            }
        }

        public override bool PlaceEntity(Entity entity)
        {
            if (this.Entity == null)
            {
                entity.Tile.Entity = null;
                entity.Tile = this;
                this.Entity = entity;
                return true;
            }
            else
            {
                this.Entity.Collision(entity);
                return false;
            }
        }


    }
}
