using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoulderDashApp.Model
{
    public class TNT : Fallable
    {
        private int ticksPassed = 0;
        private bool hasFallen = false;
        public TNT()
        {
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
                this.IsDestroyed = true;
            }
            else
            {
                Explode();
            }
        }

        public override void Destroy()
        {
            Explode();
        }

        public override bool Move()
        {
            
            if (this.IsDestroyed) { return false; }
            ticksPassed++;
            if (ticksPassed == 90)
            {
                Explode();
                return false;
            }
            MoveDirection = Direction.DOWN;
            if (!this.Tile.Tilelink.GetTile(MoveDirection).PlaceEntity(this))
            {
                if (hasFallen) { Explode(); return false; }
                if (Tile.Tilelink.Below.Entity != null)
                {
                    return FallSideWays();
                }
                return false;
            }
            hasFallen = true;
            return true;
        }

        private void Explode()
        {
            if (this.IsDestroyed) { return; }
            RedoReferences(this.Tile.Tilelink.Above.Tilelink.Left);
            RedoReferences(this.Tile.Tilelink.Above);

            RedoReferences(this.Tile.Tilelink.Left.Tilelink.Below);
            RedoReferences(this.Tile.Tilelink.Left);

            RedoReferences(this.Tile.Tilelink.Below.Tilelink.Right);
            RedoReferences(this.Tile.Tilelink.Below);

            RedoReferences(this.Tile.Tilelink.Right.Tilelink.Above);
            RedoReferences(this.Tile.Tilelink.Right);

            this.Tile.Entity = null;
            this.IsDestroyed = true;
        }

        private void RedoReferences(Tile tile)
        {
            if (tile.CanBeDestroyed)
            {
                if (tile.Entity != null)
                {
                    if (!tile.Entity.IsDestroyed)
                    {
                        tile.Entity.Destroy();
                    }
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
}
