using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoulderDashApp.View;

namespace BoulderDashApp.Model
{
    public class HardenedMud : Mud
    {
        public int FallCounter { get; set; }
        public HardenedMud()
        {
            HP = 3;
        }
        public override void Accept(Visitor visitor)
        {
            if (Entity != null)
            {
                Entity.Accept(visitor);
            }
            else
            {
                visitor.Visit(this);
            }
        }
    }
}
