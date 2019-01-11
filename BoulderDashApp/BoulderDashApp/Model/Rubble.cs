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
        public bool falling = false;

        public Rubble()
        {
            CanDie = false;
            CanDig = false;
            CanKill = true;
            IsCollectible = false;
        }

        public override void Accept(Visitor visitor)
        {
            if (falling)
            {
                visitor.Visit(this);
                return;
            }
            this.Tile.Entity = null;
            this.Tile.Accept(visitor);
            this.Tile.Entity = this;
        }

        public override void Collision(Entity entity)
        {
            this.Tile.Entity = null;
        }

        public override void Destroy()
        {
            this.Tile.Entity = null;
        }

        public override bool Move()
        {
            if (CountConnectedSides())
            {
                falling = false;
                return false;
            }
            Tile t = this.Tile;
            this.RedoReferences(this.Tile, new EmptyTIle());
            bool b = this.Tile.Tilelink.GetTile(MoveDirection).PlaceEntity(this);
            this.RedoReferences(this.Tile, t);
            if (b)
            {
                falling = true;
            }
            return b;
        }

        
        private bool CountConnectedSides()
        {
            Tile tile = this.Tile.Tilelink.Below;
            if (tile.CanSupport || (tile.Entity != null && tile.Entity.CanSupport))
            {
                return true;
            }
            int counter = 0;
            foreach (Tile t in this.Tile.Tilelink.GetSurrounding())
            {
                if (t.CanSupport || (t.Entity != null && t.Entity.CanSupport))
                    counter++;
            }
                   
            if (counter >= 2)
            {
                return true;
            }
            return false;
        }

        private void RedoReferences(Tile tile, Tile newTile)
        {
            newTile.Tilelink.Left = tile.Tilelink.Left;
            newTile.Tilelink.Right = tile.Tilelink.Right;
            newTile.Tilelink.Above = tile.Tilelink.Above;
            newTile.Tilelink.Below = tile.Tilelink.Below;
            newTile.Entity = tile.Entity;
            if (newTile.Entity != null)
            {
                newTile.Entity.Tile = newTile;
            }

            tile.Tilelink.Above.Tilelink.Below = newTile;
            tile.Tilelink.Below.Tilelink.Above = newTile;
            tile.Tilelink.Left.Tilelink.Right = newTile;
            tile.Tilelink.Right.Tilelink.Left = newTile;
        }
    }
}


