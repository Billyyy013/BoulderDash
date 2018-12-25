using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoulderDashApp.Model
{
    class Exit : Tile
    {
        public override char Symbol { get; set; }

        public Exit()
        {
            Symbol = '0';
        }
    }
}
