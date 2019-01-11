using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoulderDashApp.View;

namespace BoulderDashApp.Model
{
    public class Steelwall : Wall
    {
        public Steelwall()
        {
            CanBeDestroyed = false;
        }

        public override bool PlaceEntity(Entity entity)
        {
            return false;
        }

        public override void Accept(Visitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
