using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoulderDashApp.Model;

namespace BoulderDashApp.View
{
    public abstract class Visitor
    {

        public abstract void Visit(EmptyTIle tile);
        public abstract void Visit(Boulder boulder);
        public abstract void Visit(Diamond diamond);
        public abstract void Visit(Exit exit);
        public abstract void Visit(Firefly firefly);
        public abstract void Visit(HardenedMud hardenedMud);
        public abstract void Visit(Mud mud);
        public abstract void Visit(Rockford rockford);
        public abstract void Visit(Rubble rubble);
        public abstract void Visit(Steelwall steelwall);
        public abstract void Visit(TNT tnt);
        public abstract void Visit(Wall wall);


    }
}
