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
        public Dictionary<string, int?> PlayerCard = new Dictionary<string, int?>();

        public Player(int id, Dictionary<string, int?> playercard)
        {
            Id = id;
            PlayerCard = playercard;
        }
    }
}
