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

        public Tile CurrentRockford { get; set; }

        public Tile First { get; set; }

        public List<Firefly> Fireflys { get; set; }

        public Cave()
        {
            Rockford = new Rockford();
        }

        internal void MoveFireflys()
        {
            foreach (Firefly f in Fireflys)
            {
                f.Move();
            }
        }
    }
}
