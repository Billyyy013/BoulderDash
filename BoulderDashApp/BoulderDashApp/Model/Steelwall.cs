using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoulderDashApp.Model
{
    class Steelwall : Wall
    {
        public Steelwall()
        {
            OwnSymbol = '■';
            CanBeDestroyed = false;
        }

        public override bool PlaceEntity(Entity entity)
        {
            return false;
        }
    }
}
