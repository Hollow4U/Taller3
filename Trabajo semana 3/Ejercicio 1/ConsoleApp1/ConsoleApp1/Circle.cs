using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Circle : Shape
    {
        private float r;

        public Circle (float r)
        {
            name = "Circulo";
            this.r = r;
        }

        public override float GetArea()
        {
            return r* r * 3.14f;
        }
    }
}
