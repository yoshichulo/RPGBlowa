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
            Console.WriteLine("Name: " + this.Name);
            Console.WriteLine("Hp: " + this.Hp);
            Console.WriteLine("Def: " + this.Def);
            Console.WriteLine("Atk: " + this.Atk);
            Console.WriteLine("GoldRewardMin: " + this.GoldRewardMin);
            Console.WriteLine("GoldRewardMax: " + this.GoldRewardMax);
            Console.WriteLine("HitChance: " + this.HitChance);
            Console.WriteLine("DodgeChance: " + this.DodgeChance);
            Console.WriteLine("CritChance: " + this.CritChance);
            Console.WriteLine("CritMulti: " + this.CritMulti);
        }
    }
}
