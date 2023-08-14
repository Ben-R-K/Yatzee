using Engine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yatzee
{
    public class Dice
    {
        public int Id { get; set; }
        public int Sides { get; set; }

        public Dice(int id, int sides)
        {
            Id= id;
            Sides = sides;
        }

        public int Roll()
        {
            return RandomNumberGenerator.NumberBetween(0, Sides);
        }
    }
}
