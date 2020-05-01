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
            Def = 6;
            Atk = 13;
            Gold = 0;
            Level = 1;
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
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Level: " + Level);
            Console.WriteLine("Exp: {0}/{1}", Exp, ExpNeeded());
            Console.WriteLine("Hp: " + Hp);
            Console.WriteLine("Def: " + Def);
            Console.WriteLine("Atk: " + Atk);
            Console.WriteLine("Gold: " + Gold);
            Console.WriteLine("HitChance: " + HitChance);
            Console.WriteLine("DodgeChance: " + DodgeChance);
            Console.WriteLine("CritChance: " + CritChance);
            Console.WriteLine("CritMulti: " + CritMulti);
        }
    }
}
