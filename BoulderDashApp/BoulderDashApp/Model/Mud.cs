using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoulderDashApp.View;

namespace BoulderDashApp.Model
{
    public class Mud : Tile
    {
        public int HP { get; set; }
        public Mud()
        {
            HP = 1;
            CanSupport = true;
        }

        public override bool PlaceEntity(Entity entity)
        {
            if (!entity.CanDig)
            {
                return false;
            }

            HP--;
            if (HP == 0)
            {
                EmptyTIle emptyTIle = new EmptyTIle();
                emptyTIle.Tilelink.Left = this.Tilelink.Left;
                emptyTIle.Tilelink.Right = this.Tilelink.Right;
                emptyTIle.Tilelink.Above = this.Tilelink.Above;
                emptyTIle.Tilelink.Below = this.Tilelink.Below;
                emptyTIle.Entity = null;
                if (this.Entity != null) { this.Entity.Destroy(); }
                this.Tilelink.Above.Tilelink.Below = emptyTIle;
                this.Tilelink.Below.Tilelink.Above = emptyTIle;
                this.Tilelink.Left.Tilelink.Right = emptyTIle;
                this.Tilelink.Right.Tilelink.Left = emptyTIle;
            }

            return false;
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
