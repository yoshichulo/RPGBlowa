using System;
using System.Collections.Generic;
using System.Text;

namespace RPGBlowa
{
    class Enemy
    {
        public string Name { get; set; }
        public int Hp { get; set; }
        public int Def { get; set; }
        public int Atk { get; set; }
        public int GoldRewardMin { get; set; }
        public int GoldRewardMax { get; set; }

        public double HitChance { get; set; }
        public double DodgeChance { get; set; }
        public double CritChance { get; set; }
        public double CritMulti { get; set; }


        public void StatView()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Hp: " + Hp);
            Console.WriteLine("Def: " + Def);
            Console.WriteLine("Atk: " + Atk);
            Console.WriteLine("GoldRewardMin: " + GoldRewardMin);
            Console.WriteLine("GoldRewardMax: " + GoldRewardMax);
            Console.WriteLine("HitChance: " + HitChance);
            Console.WriteLine("DodgeChance: " + DodgeChance);
            Console.WriteLine("CritChance: " + CritChance);
            Console.WriteLine("CritMulti: " + CritMulti);
        }
    }
}
