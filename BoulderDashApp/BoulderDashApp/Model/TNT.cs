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
            Symbol = 'T';
        }

        public override void Collision(Moveable entity, Tile next)
        {
            if (entity.Symbol == '@')
            {
                this.Tile.Entity = null;
                this.Tile.PlaceEntity(entity, next);
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

        //zou moeten werken maar werkt nog niet naar behoren
        private void Explode()
        {
            RedoReferences(this.Tile.Above.Left);
            RedoReferences(this.Tile.Above);

            RedoReferences(this.Tile.Left.Below);
            RedoReferences(this.Tile.Left);

            RedoReferences(this.Tile.Below.Right);
            RedoReferences(this.Tile.Below);

            RedoReferences(this.Tile.Right.Above);
            RedoReferences(this.Tile.Right);

            this.Tile.Entity = null;
        }

        private void RedoReferences(Tile tile)
        {
            if (tile.Entity != null)
            {
                tile.Entity.Destroy();
            }
            EmptyTIle emptyTIle = new EmptyTIle();
            emptyTIle.Left = tile.Left;
            emptyTIle.Right = tile.Right;
            emptyTIle.Above = tile.Above;
            emptyTIle.Below = tile.Below;
            emptyTIle.Entity = tile.Entity;
            if (emptyTIle.Entity != null)
            {
                emptyTIle.Entity.Tile = emptyTIle;
            }
            tile.Above.Below = emptyTIle;
            tile.Below.Above = emptyTIle;
            tile.Left.Right = emptyTIle;
            tile.Right.Left = emptyTIle;
        }
    }
}
