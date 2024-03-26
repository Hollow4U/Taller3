using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Triangulo
    {
        private float B;
        private float H;

        public Triangulo(float B, float H)
        {
            this.B = B;
            this.H = H;
        }

        public float Area(float B, float H)
        {
            return (B * H) / 2;
        }
    }
}
