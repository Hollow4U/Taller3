using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Class1
    {
        public float b;
        public float h;

        public float Perimetro(float P)
        {
            P = 2*(b + h);
            return P;
        }
        public float Area(float A)
        {
            A = b * h;
            return A;
        }
    }
}
