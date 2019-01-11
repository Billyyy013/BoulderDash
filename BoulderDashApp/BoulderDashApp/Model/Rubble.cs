using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoulderDashApp.View;

namespace BoulderDashApp.Model
{
    public class Rubble : Fallable
    {

        public override void Accept(Visitor visitor)
        {
            visitor.Visit(this);
        }

        public override void Collision(Entity entity)
        {
            this.Tile.Entity = null;
        }

        public override void Destroy()
        {
            throw new NotImplementedException();
        }

        public override bool Move()
        {
            return base.Move();
        }
    }
}
