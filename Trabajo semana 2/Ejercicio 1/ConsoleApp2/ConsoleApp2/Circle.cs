using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Circle : Shape
    {
        private float _r;
        
        public Circle(float radius)
        {
            name = "Circulo";
            this._r = radius;
        }

        public override float CalculateArea()
        {
            return _r * _r * 3.14f;
        }
    }
}
