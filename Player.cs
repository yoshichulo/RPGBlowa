using System;
using System.Collections.Generic;
using System.Text;

namespace RPGBlowa
{
    class Player : Entity
    {
        public int Gold { get; set; }
        public int Level { get; set; }
        public int Exp { get; set; }

        public Player(string Name)
        {
            this.Name = Name;
            this.Hp = 100;
            this.Def = 5;
            this.Atk = 10;
            this.Gold = 0;
            this.HitChance = .8;
            this.DodgeChance = .1;
            this.CritChance = .1;
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
