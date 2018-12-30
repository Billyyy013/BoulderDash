﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoulderDashApp.Model
{
    public abstract class Moveable : Entity
    {
        public abstract void Move(Tile tile, Tile next);

    }
}
