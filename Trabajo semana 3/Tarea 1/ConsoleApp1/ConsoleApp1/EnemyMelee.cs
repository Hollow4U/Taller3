using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class EnemyMelee : Character
    {
        public float HP;
        public float DMG;


        public EnemyMelee(string name, float hp, float dmg) : base(hp, dmg)
        {
            this.name = name;
            this.HP = hp;
            this.DMG = dmg;
        }

        public virtual string GetName()
        {
            return name;
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
