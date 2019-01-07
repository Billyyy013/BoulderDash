using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoulderDashApp.Model
{
    public class Rockford : Entity
    {

        public Rockford()
        {
            Symbol = '@';
            CanDie = true;
            CanDig = true;
            CanKill = false;
            IsCollectible = false;
        }

        public override void Collision(Entity entity)
        {
            if (CanKill && !IsCollectible)
            {
                this.Destroy();
            }
        }

        public override void Destroy()
        {
            //MOETEN WE NOG NAAR EEN ANDERE LOCATIE VERPLAATSEN
            Console.Clear();
            Console.WriteLine("Rockfort Exploded. Game Over!");
            Console.ReadLine();
            Environment.Exit(0);
        }

        public override bool Move()
        {
            return Tile.Tilelink.GetTile(MoveDirection).PlaceEntity(this);           
        }
    }
}
