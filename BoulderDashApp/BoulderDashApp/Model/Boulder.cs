﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoulderDashApp.Model
{
    class Boulder : Fallable
    {
        public Boulder()
        {
            Symbol = 'o';
        }

        public override void Collision(Entity entity)
        {
            //een rockford kan een boulder 1 plaats opschuiven
            if (entity.Symbol == '@')
            {
               
            }
            return;
        }
    }
}
