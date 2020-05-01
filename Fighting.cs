using System;
using System.Collections.Generic;
using System.Text;
using ExtensionMethods;

namespace RPGBlowa
{
    class Fighting
    {
        public static Random rand = new Random();
        public static void Fight(Player p, Enemy e)
        {
            int playerActualHp = p.Hp;
            int enemyActualHp = e.Hp;

            int playerDmg, enemyDmg;

            while (playerActualHp > 0 || enemyActualHp > 0)
            {
                playerDmg = CalculateDamage(p.Atk, p.HitChance, p.CritChance, p.CritMulti);
                enemyDmg = CalculateDamage(e.Atk, e.HitChance, e.CritChance, e.CritMulti);

            }

        }

        public static int CalculateDamage(int atk, double hitChance, double critChance, double critMulti)
        {
            if (rand.DoesHit(hitChance))
            {
                if (rand.IsCritical(critChance))
                    return (int)Math.Round((atk * critMulti), MidpointRounding.AwayFromZero);
                else
                    return atk;
            }
            else
            {
                return 0;
            }
        }
    }
}
