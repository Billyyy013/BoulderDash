using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoulderDashApp.Model
{
    public class Firefly : Entity
    {
        public Firefly()
        {
            this.MoveDirection = Direction.LEFT;
            Symbol = '◙';
            CanDie = true;
            CanDig = true;
            CanKill = true;
            IsCollectible = false;
        }

        public override void Collision(Entity entity)
        {
            if (entity.CanKill)
            {
                Explode();
                this.Tile.Entity = null;
                this.Tile.PlaceEntity(entity);
            }
            else if (entity.CanDig)
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
            emptyTIle.Entity.Tile = emptyTIle;

            tile.Tilelink.Above.Tilelink.Below = emptyTIle;
            tile.Tilelink.Below.Tilelink.Above = emptyTIle;
            tile.Tilelink.Left.Tilelink.Right = emptyTIle;
            tile.Tilelink.Right.Tilelink.Left = emptyTIle;
        }

        //public void Move(Tile tile)
        //{
        //    tile.PlaceEntity(this, null);
        //}

        public override void Move()
        {
            Tile.Tilelink.GetTile(MoveDirection).PlaceEntity(this);
        }
    }
}
