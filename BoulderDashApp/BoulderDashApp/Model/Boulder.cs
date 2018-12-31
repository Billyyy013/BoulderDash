using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoulderDashApp.Model
{
    public class Boulder : Moveable
    {
        public Boulder()
        {
            Symbol = 'o';
        }

        public override void Collision(Moveable entity, Tile next)
        {
            //een rockford kan een boulder 1 plaats opschuiven
            if (entity.Symbol == '@')
            {
                this.Move(null, next);
            }
            return;
        }

        public override void Destroy()
        {
            return;
        }

        // al de move methodes die los in de entity klassen staan moeten nog overerven van 1 move klasse. die moet dus nog gemaakt worden
        public override void Move(Tile tile, Tile next)
        {
            if (!next.PlaceEntity(this, null))
            {
                if (this.Tile.Below.Entity != null)
                {
                    if (this.Tile.Left.Entity == null && this.Tile.Left.Below.Entity == null)
                    {
                        if (this.Tile.Left.PlaceEntity(this, null))
                        {
                            if (!this.Tile.Below.PlaceEntity(this, null))
                            {
                                this.Tile.Right.PlaceEntity(this, null);
                            }
                        }

                    }
                    else if (this.Tile.Right.Entity == null && this.Tile.Right.Below.Entity == null)
                    {
                        if (this.Tile.Right.PlaceEntity(this, null))
                        {
                            if (!this.Tile.Below.PlaceEntity(this, null))
                            {
                                this.Tile.Left.PlaceEntity(this, null);
                            }
                        }
                    }
                }
            }
        }


    }
}
