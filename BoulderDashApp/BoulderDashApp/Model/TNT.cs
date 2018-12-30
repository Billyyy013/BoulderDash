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

        //zou moeten werken maar werkt nog niet naar behoren
        private void Explode()
        {
            this.Tile.Above.Entity = null;
            this.Tile.Above.Above.Entity = null;
            this.Tile.Above = new EmptyTIle();
            this.Tile.Above.Above = new EmptyTIle();

            this.Tile.Left.Entity = null;
            this.Tile.Left.Left.Entity = null;
            this.Tile.Left = new EmptyTIle();
            this.Tile.Left.Left = new EmptyTIle();

            this.Tile.Below.Entity = null;
            this.Tile.Below.Below.Entity = null;
            this.Tile.Below = new EmptyTIle();
            this.Tile.Below.Below = new EmptyTIle();

            this.Tile.Right.Entity = null;
            this.Tile.Right.Right.Entity = null;
            this.Tile.Right = new EmptyTIle();
            this.Tile.Right.Right = new EmptyTIle();
        }
    }
}
