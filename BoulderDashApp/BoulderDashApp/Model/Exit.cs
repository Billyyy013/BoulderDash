using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoulderDashApp.Model
{
    public class Exit : Tile
    {
        // als alle diamonds gevonden zijn moet de exit pas open gaan, geen idee hoe we dat doen op een polymorfe manier.
        // ownsymbol moet nog aangepast worden maar voor testredenen op 0 gezet.
        public bool IsOpen { get; set; }
        public Exit()
        {
            OwnSymbol = '0';
            IsOpen = false;
            CanBeDestroyed = false;
        }

        public override bool PlaceEntity(Entity entity)
        {
            if (IsOpen && entity.CanDig)
            {
                if (this.Entity == null)
                {
                    entity.Tile.Entity = null;
                    entity.Tile = this;
                    this.Entity = entity;
                    //Spel is afgelopen
                    Console.Clear();
                    Console.WriteLine("Gefeliciflapstaart je hebt gewonnen");
                    Console.ReadLine();
                    
                    return true;
                }
            }
            return false;
        }

        internal void Open()
        {
            IsOpen = true;
            OwnSymbol = 'E';
        }
    }
}
