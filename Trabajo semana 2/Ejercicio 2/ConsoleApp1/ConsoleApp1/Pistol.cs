using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Pistol : Weapons 
    {
        private string Sname;
        private float D;
        private float DPS;
        private float cost;

        public Pistol(string Sname, float Damage, float DamageS, float price)
        {
            name = "Pistola";
            this.Sname = Sname;
            this.D = Damage;
            this.DPS = DamageS;
            this.cost = price;
        }

        public override string GetName()
        {
            return Sname;
        }

        public override float GetDamage()
        {
            return D;
        }

        public override float GetDPS()
        {
            return DPS;
        }

        public override float GetPrice()
        {
            return cost;
        }
    }
}
