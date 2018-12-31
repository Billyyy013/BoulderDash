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
            else if (entity.Symbol == 'o')
            {
                // hier moet de eerste boulder(entity) bewogen worden oftewel van de tweede boulder afglijden.
                //entity.Move(null, entity.Tile.Right);
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

            next.PlaceEntity(this, null);

        }


    }
}
