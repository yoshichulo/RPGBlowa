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
                playerDmg = CalculateDamage(p, e.DodgeChance);
                enemyDmg = CalculateDamage(e, p.DodgeChance);

                Console.WriteLine("Player deals: " + playerDmg);
                Console.WriteLine("Enemy deals: " + enemyDmg);
            }

        }

        public static int CalculateDamage(Entity e, double dodgeChance)
        {
            if (rand.DoesHit(e.HitChance, dodgeChance))
            {
                if (rand.IsCritical(e.CritChance))
                    return (int)Math.Round((e.Atk * e.CritMulti), MidpointRounding.AwayFromZero);
                else
                    return e.Atk;
            }
            else
            {
                return 0;
            }
        }
    }
}
