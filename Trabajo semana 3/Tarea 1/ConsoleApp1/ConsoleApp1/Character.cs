using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Character
    {
        protected string name;
        protected float DMG;
        protected float HP;


        public Character(float hp, float dmg)
        {
            this.HP = hp;
            this.DMG = dmg;
        }
    }
}
