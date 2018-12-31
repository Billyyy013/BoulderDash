using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoulderDashApp.Model
{
    public class Rockford : Moveable
    {

        public Rockford()
        {
            Symbol = '@';
        }

        public override void Collision(Moveable entity, Tile next)
        {
            
        }

        public override void Destroy()
        {
            //MOETEN WE NOG NAAR EEN ANDERE LOCATIE VERPLAATSEN
            Console.Clear();
            Console.WriteLine("Rockfort Exploded. Game Over!");
            Console.ReadLine();
            Environment.Exit(0);
        }

        //public void Move(Tile tile, Tile next)
        //{
        //    //this.Tile.Entity = null;
        //    //this.Tile = above;
        //    //above.Entity = this;
        //    tile.PlaceEntity(this, next);
        //}

        public override void Move(Tile tile, Tile next)
        {
            tile.PlaceEntity(this, next);
        }
    }
}
