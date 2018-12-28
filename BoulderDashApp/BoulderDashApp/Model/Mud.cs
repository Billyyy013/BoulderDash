using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoulderDashApp.Model
{
    public class Mud : Tile
    {
        public int HP { get; set; }
        public Mud()
        {
            OwnSymbol = '▒';
            HP = 1;
        }

        //public override bool PutEntityOnThisField(Cave cave, Tile previous, Tile next)
        //{
        //    if (Entity == null)
        //    {
        //        Entity = previous.Entity;
        //        previous.Entity = null;
        //        return true;
        //    }
        //    else
        //    {
        //        if (next.Entity != null) { return false; }
        //        if (next.PutEntityOnThisField(cave, this, next))
        //        {
        //            Entity = previous.Entity;
        //            previous.Entity = null;
        //            return true;
        //        }
        //        return false;
        //    }
        //}

        public override void PlaceEntity(Entity entity, Tile next)
        {
            if(entity.Symbol == 'o')
            {
                return;
            }
            if (HP == 0)
            {
                entity.Tile.Entity = null;
                entity.Tile = this;
                this.Entity = entity;
            }
            else
            {
                HP--;
                if (HP == 0)
                {
                    EmptyTIle emptyTIle = new EmptyTIle();
                    emptyTIle.Left = this.Left;
                    emptyTIle.Right = this.Right;
                    emptyTIle.Above = this.Above;
                    emptyTIle.Below = this.Below;
                    emptyTIle.Entity = this.Entity;

                    this.Above.Below = emptyTIle;
                    this.Below.Above = emptyTIle;
                    this.Left.Right = emptyTIle;
                    this.Right.Left = emptyTIle;
                }
            }
        }
    }
}
