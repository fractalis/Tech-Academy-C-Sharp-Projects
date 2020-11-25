using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_172
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int randomEncounter = random.Next(4);
            Monster monster;

            if (randomEncounter == 0 )
            {
                monster = new Dragon();
                monster.Attack();
            } else if(randomEncounter == 1)
            {
                monster = new Orc();
                monster.Attack();
            } else if(randomEncounter == 2)
            {
                monster = new UndeadDwarf();
                monster.Attack();
            } else
            {
                Console.WriteLine("You encounter no monsters");
            }

            Console.Read();


        }
    }
}
