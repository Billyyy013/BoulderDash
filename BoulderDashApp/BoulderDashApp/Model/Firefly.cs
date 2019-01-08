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
            this.MoveDirection = Direction.RIGHT;
            Symbol = 'F';
            CanDie = true;
            CanDig = false;
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
                this.IsDestroyed = true;
            }
            else if (entity.CanDig)
            {
                entity.IsDestroyed = true;
            }
        }

        public override void Destroy()
        {
            Explode();
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
            this.IsDestroyed = true;
            this.Tile.Entity = null;
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


        public override bool Move()
        {
            if (this.IsDestroyed) { return false; }
            if (checkForRockford()) { return false; }
            Direction currentDirection = MoveDirection;
            MoveDirection = GetLeft(currentDirection);
            if (!Tile.Tilelink.GetTile(MoveDirection).PlaceEntity(this))
            {
                MoveDirection = currentDirection;
                if (!Tile.Tilelink.GetTile(MoveDirection).PlaceEntity(this))
                {
                    MoveDirection = GetRight(currentDirection);
                    bool i = Tile.Tilelink.GetTile(MoveDirection).PlaceEntity(this);
                    if (checkForRockford()) { return false; }
                    return i;
                }

                if (checkForRockford()) { return false; }
                return true;
            }

            if (checkForRockford()) { return false; }
            return true;
        }

        private bool checkForRockford()
        {
            if (checkForRockford(Tile.Tilelink.Above) || 
                checkForRockford(Tile.Tilelink.Below) ||
                checkForRockford(Tile.Tilelink.Left) ||
                checkForRockford(Tile.Tilelink.Right))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool checkForRockford(Tile tile)
        {
            if (tile.Entity != null)
            {
                if (tile.Entity.CanDig)
                {
                    Explode();
                    return true;
                }
            }
            return false;
        }

        private Direction GetLeft(Direction d)
        {
            switch (d)
            {
                case Direction.UP:
                    return Direction.LEFT;

                case Direction.LEFT:
                    return Direction.DOWN;

                case Direction.RIGHT:
                    return Direction.UP;
                default:
                    return Direction.RIGHT;
            }
        }

        private Direction GetRight(Direction d)
        {
            switch (d)
            {
                case Direction.UP:
                    return Direction.RIGHT;

                case Direction.LEFT:
                    return Direction.UP;

                case Direction.RIGHT:
                    return Direction.DOWN;
                default:
                    return Direction.LEFT;
            }
        }
    }
}
