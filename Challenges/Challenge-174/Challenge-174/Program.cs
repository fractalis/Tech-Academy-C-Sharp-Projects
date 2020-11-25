using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_174
{
    class Program
    {
        static void Main(string[] args)
        {
            var player1 = new Player("bobtheplayer", 0, 1);
            var player2 = new Player("bobtheplayer", 0, 1);

            if (player1 != player2)
            {
                Console.WriteLine("Even though the objects are equal, the references they refer to are different.");
            }
            if(player1.Equals(player2))
            {
                Console.WriteLine("player1.Equals(player2)");
            }

        }
    }
}
