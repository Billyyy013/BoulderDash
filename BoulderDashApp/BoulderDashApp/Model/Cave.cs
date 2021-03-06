﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoulderDashApp.Model
{
    public class Cave
    {
        public Rockford Rockford { get; set; }

        public int LevelTime { get; set; }

        public int PlayTime { get; set; }

        public Tile First { get; set; }

        public int AmountOfDiamonds{get;set;}

        public List<Entity> Movables { get; set; }

        public Exit Exit { get; set; }

        public Cave()
        {
            Rockford = new Rockford();
            Movables = new List<Entity>();
        }

        public void MoveMovables()
        {
            foreach (Entity e in Movables)
            {
                e.Move();
            }
        }

        public int GetScore()
        {
            int score = 0;
            foreach (Entity e in Movables)
            {
                score += e.WorthPoints;
            }
            return score;
        }
    }
}
