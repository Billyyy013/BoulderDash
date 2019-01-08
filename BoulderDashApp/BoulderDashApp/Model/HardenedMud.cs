using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoulderDashApp.Model
{
    class HardenedMud : Mud
    {
        public int FallCounter { get; set; }
        public HardenedMud()
        {
            OwnSymbol = 'H';
            HP = 3;
        }

        public int CanFall()
        {

            if (this.Tilelink.Above.Entity.CanKill || this.Tilelink.Above.OwnSymbol == 'H' || this.Tilelink.Above.OwnSymbol == '▒')
            {
                FallCounter++;
            }
            if (this.Tilelink.Right.Entity.CanKill || this.Tilelink.Right.OwnSymbol == 'H' || this.Tilelink.Right.OwnSymbol == '▒')
            {
                FallCounter++;
            }
            if (this.Tilelink.Below.Entity.CanKill || this.Tilelink.Below.OwnSymbol == 'H' || this.Tilelink.Below.OwnSymbol == '▒')
            {
                FallCounter++;
            }
            if (this.Tilelink.Left.Entity.CanKill || this.Tilelink.Left.OwnSymbol == 'H' || this.Tilelink.Left.OwnSymbol == '▒')
            {
                FallCounter++;
            }
            return FallCounter;
        }

        public bool MakeHardenedMudRubble()
        {
            if(FallCounter < 2)
            {
                Rubble rubble = new Rubble();
                this.Entity = rubble;
                return true;
            }
            return false;
        }
    }
}
