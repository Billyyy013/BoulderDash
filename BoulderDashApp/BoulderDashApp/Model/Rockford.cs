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

        public override void Collision(Entity entity)
        {
            throw new NotImplementedException();
        }

        public void Move(Tile moveTo)
        {
            moveTo = moveTo.Above;
        }
    }
}
