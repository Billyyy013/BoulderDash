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
            Symbol = 'R';
        }

        public void Move(Tile MoveTo)
        {
            throw new NotImplementedException();
        }
    }
}
