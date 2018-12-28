﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoulderDashApp.Model
{
    public class EmptyTIle : Tile
    {

        public EmptyTIle()
        {
            OwnSymbol = '.';
        }

        public override void PlaceEntity(Entity entity, Tile next)
        {
            if (this.Entity == null)
            {
                entity.Tile.Entity = null;
                entity.Tile = this;
                this.Entity = entity;
            }
            else
            {
                this.Entity.Collision(entity, next);
            }
        }
    }
}
