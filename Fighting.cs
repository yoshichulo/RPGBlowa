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

            Console.WriteLine("You found a {0}!", e.Name);

            // Fight until someone dies
            while (playerActualHp > 0 && enemyActualHp > 0)
            {
                playerDmg = Math.Max(CalculateDamage(p, e.DodgeChance) - e.Def, 0);
                enemyDmg = Math.Max(CalculateDamage(e, p.DodgeChance) - p.Def, 0);

                Console.WriteLine("You have dealt {0} damage to the {1}!", enemyDmg, e.Name);
                enemyActualHp -= playerDmg;

                // If enemy is still alive, attacks
                if (enemyActualHp > 0)
                {
                    Console.WriteLine("Enemy has dealt {0} damage to you!", enemyDmg);
                    playerActualHp -= enemyDmg;
                }

                
                Console.WriteLine("Player HP: {0}/{1}", Math.Max(playerActualHp, 0), p.Hp);
                Console.WriteLine("Enemy HP: {0}/{1}", Math.Max(enemyActualHp, 0), e.Hp);
            }

            if (playerActualHp > 0)
            {
                Console.WriteLine("You have defeated the {0}!\nGold Rewarded: {1}\nEXP Gained: {2}", e.Name, e.GoldReward, e.ExpReward);
                p.Gold += e.GoldReward;
                p.Exp += e.ExpReward;
                if (p.Exp >= p.ExpNeeded())
                {
                    Console.WriteLine("You have leveled up!");
                    p.LevelUp();
                }
                Console.WriteLine("==============================\n\n");
            }
            else
            {
                Console.WriteLine("You have died. The {0} has stolen 20% of your EXP and your gold", e.Name);
                p.Gold = Math.Max((int)(p.Gold * .8), 0);
                p.Exp = Math.Max((int)(p.Exp * .8), 0);
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
