using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_172
{
    public abstract class Monster
    {
        public string Name { get; private set; }
        public int HitPoints { get; private set; }
        public int Level { get; private set; }

        public Monster()
        {

        }

        public Monster(string Name, int HitPoints, int Level)
        {
            this.Name = Name;
            this.HitPoints = HitPoints;
            this.Level = Level;
        }

        public abstract void Attack();
    }
}
