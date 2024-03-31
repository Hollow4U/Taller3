using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Weapons
    {
        protected string name;
        public string nick;

        public string Name
        {
            get
            {
                return name;
            }
        }
        
        public virtual string GetName()
        {
            return nick;
        }

        public virtual float GetDamage()
        {
            return 0;
        }

        public virtual float GetDPS()
        {
            return 0;
        }

        public virtual float GetPrice()
        {
            return 0;
        }
    }
}
