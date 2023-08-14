using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yatzee
{
    public class Player
    {
        public Dictionary<string, int?> YatzeeCard = new Dictionary<string, int?>();

        public Player(Dictionary<string, int?> yatzeeCard)
        {
            YatzeeCard = yatzeeCard;
        }
    }
}
