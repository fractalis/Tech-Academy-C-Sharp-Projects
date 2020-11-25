using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_172
{
    public class Orc : Monster
    {
        public Orc() : base("Orc", 25, 2)
        {
            
        }

        public override void Attack()
        {
            Console.WriteLine("The savage Orc swings his blade!");
        }
    }
}
