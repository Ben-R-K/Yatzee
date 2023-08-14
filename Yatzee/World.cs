using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yatzee
{
    public static class World
    {
        public static readonly Dictionary<string, int?> YatzeeCard = new Dictionary<string, int?>();
        public static readonly List<Player> players = new List<Player>();

        private static void PopulateYatzeeCard()
        {
            YatzeeCard.Add("Aces", null);
            YatzeeCard.Add("Twos", null);
            YatzeeCard.Add("Threes", null);
            YatzeeCard.Add("Fours", null);
            YatzeeCard.Add("Fives", null);
            YatzeeCard.Add("Sixes", null);
            YatzeeCard.Add("ThreeOfAKinde", null);
            YatzeeCard.Add("FourOfAKinde", null);
            YatzeeCard.Add("FullHouse", null);
            YatzeeCard.Add("SmallStright", null);
            YatzeeCard.Add("LargeSttright", null);
            YatzeeCard.Add("Yatzee", null);
            YatzeeCard.Add("Chance", null);

        }


        public static void PlayerCount(int NumOfPlayers)
        {

            for (int i = 0; i < NumOfPlayers; i++)
            {
                Player player = new Player(i+1, YatzeeCard);
                players.Add(player);
            }

            foreach(Player p in players)
            {
                
            }
        }
    }
}
