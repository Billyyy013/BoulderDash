using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoulderDashApp.Model
{
    public abstract class OriginClass
    {
        public abstract void Accept(View.Visitor visitor);

        public bool CanSupport { get; set; }

        public OriginClass()
        {
            CanSupport = false;
        }
    }
}
