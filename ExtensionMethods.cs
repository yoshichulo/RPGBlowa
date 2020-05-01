using System;
using System.Collections.Generic;
using System.Text;

namespace ExtensionMethods
{
    public static class RandomExtensions
    {

        public static bool IsCritical(this Random rand, double critChance)
        {
            return rand.NextDouble() <= critChance;
        }

        public static bool DoesHit(this Random rand, double hitChance, double dodgeChance)
        {
            return rand.NextDouble() <= hitChance * (1-dodgeChance);
        }
    }
}
