using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoulderDashApp.Model
{
    public class TNT : Fallable
    {
        public TNT()
        {
            Symbol = 'T';
        }

        public override void Collision(Entity entity)
        {
            if (entity.Symbol == '@')
            {
                this.Tile.Entity = null;
                this.Tile.PlaceEntity(entity);
            }
            else
            {
                explode();
            }
        }
        private void explode()
        {
        }
    }
}
