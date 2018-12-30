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

        public List<Firefly> Fireflys { get; set; }
        public List<Diamond> Diamonds { get; }
        public List<Boulder> Boulders { get; set; }

        public Cave()
        {
            Rockford = new Rockford();
            Boulders = new List<Boulder>();
            Fireflys = new List<Firefly>();
            Diamonds = new List<Diamond>();
        }

        //internal void MoveFireflys()
        //{
        //    foreach (Firefly f in Fireflys)
        //    {
        //        f.Move();
        //    }
        //}
    }
}
