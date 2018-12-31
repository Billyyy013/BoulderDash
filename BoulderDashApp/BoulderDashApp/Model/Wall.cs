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

        public override bool PlaceEntity(Moveable entity, Tile next)
        {
            return false;
        }
    }
}
