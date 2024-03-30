using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Triangle : Shape
    {
        private float b;
        private float a;

        public Triangle(float width, float length)
        {
            name = "Triangulo";
            this.b = width;
            this.a = length;
        }

        public override float CalculateArea()
        {
            return (b * a) / 2;
        }

    }
}
