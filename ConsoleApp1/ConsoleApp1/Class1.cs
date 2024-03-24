using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Class1
    {

        static public float b;
        static public float h;
        
        static public float Perimetro(float P)
        {
            P = 2 * (b + h);
            return P;
        }

        static public float Area(float A)
        {
            A = b * h;
            return A;
        }
    }
}
