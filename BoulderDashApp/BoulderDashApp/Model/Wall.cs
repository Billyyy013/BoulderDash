﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoulderDashApp.Model
{
    class Wall : Tile
    {

        public Wall()
        {
            OwnSymbol = '=';
        }

        public override void PlaceEntity(Entity entity, Tile next)
        {
            return;
        }
    }
}
