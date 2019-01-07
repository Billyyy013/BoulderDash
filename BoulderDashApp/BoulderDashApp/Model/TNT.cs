using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoulderDashApp.Model
{
    public class TNT : Fallable
    {
        public TNT()
        {
            this.MoveDirection = Direction.DOWN;
            Symbol = 'T';
            CanDie = false;
            CanDig = false;
            CanKill = false;
            IsCollectible = true;
        }

        public override void Collision(Entity entity)
        {
            if (entity.CanDig)
            {
                this.Tile.Entity = null;
                this.Tile.PlaceEntity(entity);
            }
            else
            {
                // 30 seconden moeten nog geimplementeerd worden en als het ergens op valt moet het ook expoderen
                Explode();
            }
        }

        public override void Destroy()
        {
            Explode();
        }

        //public override bool Move()
        //{
        //    return this.Tile.Tilelink.GetTile(MoveDirection).PlaceEntity(this);
        //}

        private void Explode()
        {
            RedoReferences(this.Tile.Tilelink.Above.Tilelink.Left);
            RedoReferences(this.Tile.Tilelink.Above);

            RedoReferences(this.Tile.Tilelink.Left.Tilelink.Below);
            RedoReferences(this.Tile.Tilelink.Left);

            RedoReferences(this.Tile.Tilelink.Below.Tilelink.Right);
            RedoReferences(this.Tile.Tilelink.Below);

            RedoReferences(this.Tile.Tilelink.Right.Tilelink.Above);
            RedoReferences(this.Tile.Tilelink.Right);
        }

        private void RedoReferences(Tile tile)
        {
            if (tile.Entity != null)
            {
                tile.Entity.Destroy();
            }
            EmptyTIle emptyTIle = new EmptyTIle();
            emptyTIle.Tilelink.Left = tile.Tilelink.Left;
            emptyTIle.Tilelink.Right = tile.Tilelink.Right;
            emptyTIle.Tilelink.Above = tile.Tilelink.Above;
            emptyTIle.Tilelink.Below = tile.Tilelink.Below;
            emptyTIle.Entity = tile.Entity;
            if (emptyTIle.Entity != null)
            {
                emptyTIle.Entity.Tile = emptyTIle;
            }

            tile.Tilelink.Above.Tilelink.Below = emptyTIle;
            tile.Tilelink.Below.Tilelink.Above = emptyTIle;
            tile.Tilelink.Left.Tilelink.Right = emptyTIle;
            tile.Tilelink.Right.Tilelink.Left = emptyTIle;
        }
    }
}
