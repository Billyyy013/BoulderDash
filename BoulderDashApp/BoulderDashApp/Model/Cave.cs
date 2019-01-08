using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoulderDashApp.Model
{
    public class Cave
    {
        public Rockford Rockford { get; set; }

        public Tile First { get; set; }

        public List<Diamond> Diamonds { get; }

        public List<Entity> Movables { get; set; }

        public Cave()
        {
            Rockford = new Rockford();
            Diamonds = new List<Diamond>();
            Movables = new List<Entity>();
        }

        public void MoveMovables()
        {
            foreach (Entity e in Movables)
            {
                e.Move();
            }
        }
    }
}
