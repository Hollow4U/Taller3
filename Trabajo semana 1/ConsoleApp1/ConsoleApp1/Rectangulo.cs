using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Rectangulo
    {
        private float B;
        private float H;

        public Rectangulo(float B, float H)
        {
            this.B = B;
            this.H = H;
        }

        public float Area(float B, float H)
        {
            return B * H;
        }
    }
}
