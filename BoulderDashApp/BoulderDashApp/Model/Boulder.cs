using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoulderDashApp.Model
{
    public class Boulder : Fallable
    {
        public Boulder()
        {
            Symbol = 'o';
        }

        public override void Collision(Entity entity, Tile next)
        {
            //een rockford kan een boulder 1 plaats opschuiven
            if (entity.Symbol == '@')
            {
                this.Move(next);
            } else if(entity.Symbol == 'o')
            {
                
            }
            return;
        }

        // al de move methodes die los in de entity klassen staan moeten nog overerven van 1 move klasse. die moet dus nog gemaakt worden in entity of movable
        public void Move(Tile tile)
        {
            tile.PlaceEntity(this, null);
        }
    }
}
