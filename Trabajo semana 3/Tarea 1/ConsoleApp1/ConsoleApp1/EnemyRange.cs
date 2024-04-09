using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class EnemyRange : Character
    {
        public float HP;
        public float DMG;
        public int ROUNDS;

        public EnemyRange(string name, float hp, float dmg, int rounds) : base(hp, dmg)
        {
            this.name = name;
            this.HP = hp;
            this.DMG = dmg;
            this.ROUNDS = rounds;
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

        public virtual int GetRounds()
        {
            return ROUNDS;
        }
    }
}
