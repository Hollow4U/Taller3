using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Rectangle : Shape
    {
        private float w;
        private float l;

        public Rectangle(float width, float length)
        {
            name = "Rectangulo";
            this.w = width;
            this.l = length;
        }

        public override float CalculateArea()
        {
            return w * l;
        }
    }
}
