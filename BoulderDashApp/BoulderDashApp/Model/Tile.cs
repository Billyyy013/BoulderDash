﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoulderDashApp.Model
{
    public abstract class Tile
    {
        public char Symbol
        {
            get
            {
                if (Entity != null)
                {
                    return Entity.Symbol;
                }
                else
                {
                    return OwnSymbol;
                }
            }
        }
        
        public char OwnSymbol { get; set; }

        public Entity Entity { get; set; }

        public abstract bool PlaceEntity(Entity entity);

        public TileLink Tilelink { get; set; }

        public Tile()
        {
            Tilelink = new TileLink();
        }
        
        public class TileLink
        {
            public Tile Above { get; set; }
            public Tile Below { get; set; }
            public Tile Left { get; set; }
            public Tile Right { get; set; }

            public Tile GetTile(Direction dir)
            {
                switch (dir)
                {
                    case Direction.UP: return Above;
                    case Direction.DOWN: return Below;
                    case Direction.LEFT: return Left;
                    default: return Right;
                }
            }
        }
    }
}
