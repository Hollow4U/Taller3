using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Shape
    {
        protected string name;

        public string Name
        {
            get
            {
                return name;
            }
        }

        public virtual float CalculateArea()
        {
            return 0;
        }
    }
}
