using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Circulo
    {
        private float R;

        public Circulo(float R)
        {
            this.R = R;
        }

        public float Area(float R)
        {
            return (3.14f *(R * R));
        }
    }
}
