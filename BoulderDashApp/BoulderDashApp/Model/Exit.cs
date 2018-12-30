using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoulderDashApp.Model
{
    class Exit : Tile
    {
        // als alle diamonds gevonden zijn moet de exit pas open gaan, geen idee hoe we dat doen op een polymorfe manier.
        //public bool IsOpen { get; set; }
        public Exit()
        {
            OwnSymbol = '0';
        }

        public override void PlaceEntity(Entity entity, Tile next)
        {
            if (OwnSymbol == '0')
            {
                if (this.Entity == null)
                {
                    entity.Tile.Entity = null;
                    entity.Tile = this;
                    this.Entity = entity;
                    
                }
            }
        }

        
    }
}
