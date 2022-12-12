using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cejka_20221212
{
    internal class Soldier
    {
        Random random = new Random();
        public string Name { get; set; }
        public int HP { get; set; }
        public int MaxHP { get; set; }
        public int DMG { get; set; }
        public int Shield { get; set; }
        public int MaxShield { get; set; }
        public int Level { get; set; }
        public Soldier(string name)
        {
            Name = name;
            HP = 0;
            MaxHP = 100;
            DMG = 0;
            Shield = 0;
            MaxShield = 100;
            Level = 1;
        }
        public void Attack(Soldier Enemy)
        {

        }
        public void Heal()
        {

        }
        public void LevelUp()
        {

        }
    }
}
