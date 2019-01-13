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
        private bool hasFallen = false;

        public Rubble()
        {
            CanDie = true;
            CanDig = false;
            CanKill = true;
            IsCollectible = false;
            IsDestroyed = false;
            CanSupport = false;
        }

        public override void Accept(Visitor visitor)
        {
            if (falling || hasFallen)
            {
                visitor.Visit(this);
                return;
            }
            Entity e = this.Tile.Entity;
            this.Tile.Entity = null;
            this.Tile.Accept(visitor);
            this.Tile.Entity = e;
        }

        public override void Collision(Entity entity)
        {
            return;
        }

        public override void Destroy()
        {
            this.Tile.Entity = null;
            IsDestroyed = true;
        }

        public override bool Move()
        {
            if (this.IsDestroyed)
            {
                if (this.Tile != null)
                {
                    this.Tile.Entity = null;
                    this.Tile = null;
                }
                return false;
            }

            if (CountConnectedSides())
            {
                if (falling)
                {
                    hasFallen = true;
                    RedoReferences(this.Tile, new Mud(), this);
                }
                falling = false;
                return false;
            }
            Tile t = this.Tile;
            this.RedoReferences(this.Tile, new EmptyTIle(), this);
            bool b = this.Tile.Tilelink.GetTile(MoveDirection).PlaceEntity(this);
            if (!this.IsDestroyed)
            {
                this.RedoReferences(this.Tile,t ,this);
            }
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
                   
            if (counter > 1)
            {
                return true;
            }
            return false;
        }

        private void RedoReferences(Tile tile, Tile newTile, Entity e)
        {
            newTile.Tilelink.Left = tile.Tilelink.Left;
            newTile.Tilelink.Right = tile.Tilelink.Right;
            newTile.Tilelink.Above = tile.Tilelink.Above;
            newTile.Tilelink.Below = tile.Tilelink.Below;


            tile.Tilelink.Above.Tilelink.Below = newTile;
            tile.Tilelink.Below.Tilelink.Above = newTile;
            tile.Tilelink.Left.Tilelink.Right = newTile;
            tile.Tilelink.Right.Tilelink.Left = newTile;

            if (e != null)
            {
                newTile.Entity = e;
                e.Tile = newTile;
            }
        }

    }
}


