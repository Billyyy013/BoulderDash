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
            //Als hij dus naar beneden kan vallen dan doet hij dat en returned hij true anders false 
            if (!next.PlaceEntity(this, null))
            {
                //Als er een entity onder een boulder ofzo ligt dan kan een boulder ook schuin vallen anders niet
                if (this.Tile.Below.Entity != null)
                {
                    //dit is linksom vallen
                    //Als er geen entity links van de boulder en links onder van de boulder zit kan de boulder vallen
                    if (this.Tile.Left.Entity == null && this.Tile.Left.Below.Entity == null)
                    {
                        //Hier word de boulder eerst naar links gezet als dit lukt kan de boulder dus worden verplaatst naar links onder
                        //(als dit niet lukt betekent dit dat er bevoorbeeld een mud tile zit ofzo)
                        if (this.Tile.Left.PlaceEntity(this, null))
                        {
                            //hier word de boulder naar links onder verplaatst als dit niet lukt dan moet de verplaatsing die hierboven is gedaan terug gedraaid worden
                            if (!this.Tile.Below.PlaceEntity(this, null))
                            {
                                this.Tile.Right.PlaceEntity(this, null);
                            }
                        }

                    }
                    //dit is rechtsom vallen
                    //hetzelfde als hierboven
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
