using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoulderDashApp.Model
{
    public abstract class Entity
    {
       public virtual char Symbol { get; set; }
       public Tile Tile { get; set; }

    }
}
