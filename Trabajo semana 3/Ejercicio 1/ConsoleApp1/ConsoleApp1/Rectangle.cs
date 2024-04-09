using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Rectangle : Shape
    {
        private float b;
        private float h;

        public Rectangle(float b, float h)
        {
            name = "Rectangulo";
            this.b = b;
            this.h = h;
        }

        public override float GetArea()
        {
            return b * h;
        }
    }
}
