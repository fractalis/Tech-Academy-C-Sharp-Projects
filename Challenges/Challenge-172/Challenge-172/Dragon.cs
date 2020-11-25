using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_172
{
    public class Dragon : Monster
    {
        public Dragon() : base("Dragon", 650, 18)
        {
        }

        public override void Attack()
        {
            Console.WriteLine("The mighty Dragon breathes out a pillar of fire.");
        }
    }
}
