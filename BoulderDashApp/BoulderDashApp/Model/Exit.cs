using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoulderDashApp.View;

namespace BoulderDashApp.Model
{
    public class Exit : Tile
    {
        public bool IsOpen { get; set; }
        public Exit()
        {
            IsOpen = false;
            CanBeDestroyed = false;
        }

        public override bool PlaceEntity(Entity entity)
        {
            if (IsOpen && entity.CanDig)
            {
                if (this.Entity == null)
                {
                    entity.Tile.Entity = null;
                    entity.Tile = this;
                    this.Entity = entity;
                    return true;
                }
            }
            return false;
        }

        internal void Open()
        {
            IsOpen = true;
        }

        public override void Accept(Visitor visitor)
        {
            if (Entity != null)
            {
                Entity.Accept(visitor);
            }
            else
            {
                visitor.Visit(this);
            }
        }
    }
}
