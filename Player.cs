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
            Hp = 100;
            Def = 5;
            Atk = 10;
            Gold = 0;
            HitChance = .8;
            DodgeChance = .1;
            CritChance = .05;
            CritMulti = 1.2;
        }

        public void StatView()
        {
            Console.WriteLine("Name: " + Name);
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
