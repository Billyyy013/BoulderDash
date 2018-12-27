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

        public override void PlaceEntity(Entity entity)
        {
            if (this.Entity == null)
            {
                entity.Tile.Entity = null;
                entity.Tile = this;
                this.Entity = entity;
            }
        }

        public override bool PutEntityOnThisField(Cave cave, Tile previous, Tile next)
        {
            throw new NotImplementedException();
        }
    }
}
