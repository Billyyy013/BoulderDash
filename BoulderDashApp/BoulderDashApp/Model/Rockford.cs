using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoulderDashApp.Model
{
    public class Rockford : Moveable
    {

        public Rockford()
        {
            Symbol = '@';
        }

        public override void Collision(Entity entity, Tile next)
        {
            
        }

        public void Move(Tile tile, Tile next)
        {
            //this.Tile.Entity = null;
            //this.Tile = above;
            //above.Entity = this;
            tile.PlaceEntity(this, next);
        }
    }
}
