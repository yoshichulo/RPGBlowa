using System;
using System.Collections.Generic;
using System.Text;

namespace RPGBlowa
{
    abstract class Entity
    {
        public string Name { get; set; }
        public int Hp { get; set; }
        public int Def { get; set; }
        public int Atk { get; set; }

        public double HitChance { get; set; }
        public double DodgeChance { get; set; }
        public double CritChance { get; set; }
        public double CritMulti { get; set; }
    }
}
