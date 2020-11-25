using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_172
{
    public class UndeadDwarf : Monster
    {
        public UndeadDwarf() : base("Undead Dwarf", 45, 5)
        {

        }

        public override void Attack()
        {
            Console.WriteLine("The decaying undead dwarf charges with his wooden shield.");
        }
    }
}
