using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoulderDashApp.Model
{
    class Diamond : Fallable
    {
        public Diamond()
        {
            Symbol = 'D';
        }

        public override void Collision(Entity entity)
        {
            throw new NotImplementedException();
        }
    }
}
