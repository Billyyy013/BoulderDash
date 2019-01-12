using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoulderDashApp.View;

namespace BoulderDashApp.Model
{
    public class Rubble : Fallable
    {

        public override void Accept(Visitor visitor)
        {
            visitor.Visit(this);
        }

        public override void Collision(Entity entity)
        {
            this.Tile.Entity = null;
        }

        public override void Destroy()
        {
            throw new NotImplementedException();
        }

        public override bool Move()
        {
            if (CountConnectedSides())
            {
                //this.Tile.Entity = null;
                return false;
            }
            //Hier moven
            return this.Tile.Tilelink.GetTile(MoveDirection).PlaceEntity(this);
        }

        private bool CountConnectedSides()
        {
            if (this.Tile.Tilelink.Below.CanSupport || this.Tile.Tilelink.Below.Entity.CanSupport)
            {
                return true;
            }
            int counter = 0;
            if (this.Tile.Tilelink.Above.CanSupport || this.Tile.Tilelink.Above.Entity.CanSupport)
            {
                counter++;
            }
            if (this.Tile.Tilelink.Right.CanSupport || this.Tile.Tilelink.Right.Entity.CanSupport)
            {
                counter++;
            }
            if (this.Tile.Tilelink.Left.CanSupport || this.Tile.Tilelink.Left.Entity.CanSupport)
            {
                counter++;
            }
            if (counter >= 2)
            {
                return true;
            }
            return false;
        }


    }
}

