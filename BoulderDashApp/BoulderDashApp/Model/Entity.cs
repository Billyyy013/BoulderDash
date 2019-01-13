using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoulderDashApp.Model
{
    public abstract class Entity : OriginClass
    {
        public Tile Tile { get; set; }

        public List<Entity> CollectedEntities { get; set; }

        public int WorthPoints = 0;

        public Entity()
        {
            IsDestroyed = false;
            CollectedEntities = new List<Entity>();
        }


        public abstract void Collision(Entity entity);

        public abstract void Destroy();

        public Direction MoveDirection { get; set; }

        public abstract bool Move();

        public bool CanDie { get; set; }
        
        public bool CanDig { get; set; }

        public bool CanKill { get; set; }

        public bool IsCollectible { get; set; }

        public bool IsDestroyed { get; set; }
    }
}
