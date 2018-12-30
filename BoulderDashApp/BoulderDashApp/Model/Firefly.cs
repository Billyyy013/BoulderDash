﻿using System;
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
