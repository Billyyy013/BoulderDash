using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoulderDashApp.Model
{
    public class Rubble : Fallable
    {
        public Rubble()
        {
            Symbol = 'R';
        }

        public override void Collision(Entity entity)
        {
            this.Tile.Entity = null;
        }

        public override void Destroy()
        {
            throw new NotImplementedException();
        }
    }
}
