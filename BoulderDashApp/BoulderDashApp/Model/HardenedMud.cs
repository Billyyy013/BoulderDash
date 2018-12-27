using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoulderDashApp.Model
{
    class HardenedMud : Mud
    {
        public HardenedMud()
        {
            OwnSymbol = 'H';
            HP = 3;
        }
    }
}
