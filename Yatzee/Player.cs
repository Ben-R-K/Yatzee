using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yatzee
{
    public class Player
    {
        public int Id;
        public List<Dice> PlayerDices = new List<Dice>();
        public Dictionary<string, int?> PlayerCard = new Dictionary<string, int?>();

        public Player(int id, List<Dice> playerdices, Dictionary<string, int?> playercard)
        {
            Id = id;
            PlayerDices= playerdices;
            PlayerCard = playercard;
        }
    }
}
