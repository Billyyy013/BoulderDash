using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoulderDashApp.Model
{
    public abstract class Tile
    {
        abstract public char Symbol { get; set; }

        public Tile Above { get; set; }
        public Tile Below { get; set; }
        public Tile Left { get; set; }
        public Tile Right { get; set; }

        public Entity Entity { get; set; }
    }
}
