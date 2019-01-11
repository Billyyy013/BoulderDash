using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoulderDashApp.View;

namespace BoulderDashApp.Model
{
    public class Wall : Tile
    {
        public override void Accept(Visitor visitor)
        {
            if (Entity != null)
            {
                Entity.Accept(visitor);
            }
            else
            {
                visitor.Visit(this);
            }
        }

        public Wall()
        {
            CanSupport = true;
        }

        public override bool PlaceEntity(Entity entity)
        {
            return false;
        }
    }
}
