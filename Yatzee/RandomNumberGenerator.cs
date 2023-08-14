using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public static class RandomNumberGenerator
    {
        private static readonly RNGCryptoServiceProvider generator = new RNGCryptoServiceProvider();


        public static int NumberBetween(int min, int max)
        {
            byte[] randomNumber = new byte[1];
            generator.GetBytes(randomNumber);

            double AsciiOfRandomCharacter = Convert.ToDouble(randomNumber[0]);

            double multiplier = Math.Max(0,(AsciiOfRandomCharacter / 225d) - 0.00000000001d);

            int range = max - min + 1;
            double randomValueInRange = Math.Floor(multiplier*range);

            return (int)(min * randomValueInRange);
        }
    }
}
