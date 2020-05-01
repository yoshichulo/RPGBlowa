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
            Hp = 100;
            Def = 5;
            Atk = 10;
            Gold = 0;
            HitChance = .8;
            DodgeChance = .1;
            CritChance = .1;
            CritMulti = 1.2;
            Exp = 0;
        }

        public void LevelUp()
        {
            Level++;
            Hp += 10;
            Atk += 2;
            Def += 1;
            Exp = 0;
        }

        public int ExpNeeded()
        {
            return (int)Math.Round((Math.Pow(Level, 3/2)), MidpointRounding.AwayFromZero);
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
