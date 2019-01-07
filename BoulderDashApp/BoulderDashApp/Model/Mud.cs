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
                emptyTIle.Entity = this.Entity;

                this.Tilelink.Above.Tilelink.Below = emptyTIle;
                this.Tilelink.Below.Tilelink.Above = emptyTIle;
                this.Tilelink.Left.Tilelink.Right = emptyTIle;
                this.Tilelink.Right.Tilelink.Left = emptyTIle;

                //emptyTIle.PlaceEntity(entity);
            }

            return false;
        }
    }
}
