using System;
using System.Collections.Generic;
using System.Text;

namespace RPGBlowa
{
    class Player
    {
        public string Name { get; set; }
        public int Hp { get; set; }
        public int Def { get; set; }
        public int Atk { get; set; }
        public int Gold { get; set; }
        public int Level { get; set; }
        public int Exp { get; set; }

        public double HitChance { get; set; }
        public double DodgeChance { get; set; }
        public double CritChance { get; set; }
        public double CritMulti { get; set; }


        public Player(string Name)
        {
            this.Name = Name;
            this.Hp = 100;
            this.Def = 5;
            this.Atk = 10;
            this.Gold = 0;
            this.HitChance = .8;
            this.DodgeChance = .1;
            this.CritChance = .05;
            this.CritMulti = 1.2;
        }

        public void StatView()
        {
            Console.WriteLine("Name: " + this.Name);
            Console.WriteLine("Hp: " + this.Hp);
            Console.WriteLine("Def: " + this.Def);
            Console.WriteLine("Atk: " + this.Atk);
            Console.WriteLine("Gold: " + this.Gold);
            Console.WriteLine("HitChance: " + this.HitChance);
            Console.WriteLine("DodgeChance: " + this.DodgeChance);
            Console.WriteLine("CritChance: " + this.CritChance);
            Console.WriteLine("CritMulti: " + this.CritMulti);
        }
    }
}
