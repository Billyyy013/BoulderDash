using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoulderDashApp.Model
{
    public class Firefly : Moveable
    {
        public Firefly()
        {
            Symbol = '◙';
        }

        public override void Collision(Moveable entity, Tile next)
        {
            if (entity.Symbol == 'o')
            {
                this.Tile.Entity = null;
                this.Tile.PlaceEntity(entity, next);
            }
            else if (entity.Symbol == '@')
            {
                //MOETEN WE NOG NAAR EEN ANDERE LOCATIE VERPLAATSEN
                Console.Clear();
                Console.WriteLine("Rockfort hit a Firefly. Game Over!");
                Console.ReadLine();
                Environment.Exit(0);
            }
        }

        public override void Destroy()
        {
            Explode();
        }

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
            emptyTIle.Entity.Tile = emptyTIle;

            tile.Above.Below = emptyTIle;
            tile.Below.Above = emptyTIle;
            tile.Left.Right = emptyTIle;
            tile.Right.Left = emptyTIle;
        }

        //public void Move(Tile tile)
        //{
        //    tile.PlaceEntity(this, null);
        //}

        public override void Move(Tile tile, Tile next)
        {
            tile.PlaceEntity(this, null);
        }
    }
}
