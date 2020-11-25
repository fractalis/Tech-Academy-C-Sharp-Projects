using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_174
{
    class Player
    {
        public string PlayerName { get; private set; }
        public int PlayerScore { get; private set; }

        public int PlayerLevel { get; private set; }

        public Player()
        {

        }

        public Player(string Name, int Score, int Level)
        {
            PlayerName = Name;
            PlayerScore = Score;
            PlayerLevel = Level;
        }

        public override bool Equals(object obj)
        {
            return obj is Player player &&
                   PlayerName == player.PlayerName &&
                   PlayerScore == player.PlayerScore &&
                   PlayerLevel == player.PlayerLevel;
        }

        public override int GetHashCode()
        {
            int hashCode = 1819657947;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(PlayerName);
            hashCode = hashCode * -1521134295 + PlayerScore.GetHashCode();
            hashCode = hashCode * -1521134295 + PlayerLevel.GetHashCode();
            return hashCode;
        }
    }
}
