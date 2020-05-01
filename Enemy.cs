using System;
using System.Collections.Generic;
using System.Text;

namespace RPGBlowa
{
    class Enemy : Entity
    {
        public int GoldReward;
        public int ExpReward;

        public void StatView()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Hp: " + Hp);
            Console.WriteLine("Def: " + Def);
            Console.WriteLine("Atk: " + Atk);
            Console.WriteLine("GoldReward: " + GoldReward);
            Console.WriteLine("ExpReward: " + ExpReward);
            Console.WriteLine("HitChance: " + HitChance);
            Console.WriteLine("DodgeChance: " + DodgeChance);
            Console.WriteLine("CritChance: " + CritChance);
            Console.WriteLine("CritMulti: " + CritMulti);
        }
    }
}
