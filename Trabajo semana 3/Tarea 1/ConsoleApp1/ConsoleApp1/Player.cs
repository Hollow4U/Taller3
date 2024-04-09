using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Player : Character 
    {
        public float HP;
        public float DMG;

        public Player(float hp, float dmg) : base(hp, dmg)
        {
            name = "Heroe";
            this.HP = hp;
            this.DMG = dmg;
        }

        public virtual float GetHP()
        {
            return HP;
        }

        public virtual float GetDamage()
        {
            return DMG;
        }
    }
}
