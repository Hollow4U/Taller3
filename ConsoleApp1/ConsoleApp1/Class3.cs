using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Class3
    {
        public void Ejecutar()
        {
            bool continueFlag = true;

            while (continueFlag)
            {
                Console.WriteLine("Elige figura geometrica: ");
                Console.WriteLine("1. Circulo");
                Console.WriteLine("2. Triangulo");
                Console.WriteLine("3. Rectangulo");

                int eleccion = int.Parse(Console.ReadLine());

                switch (eleccion)
                {
                    case 1:
                        Console.WriteLine("Introduce el radio del circulo: ");
                        int R = int.Parse(Console.ReadLine());
                        Circulo area_C = new Circulo(R);

                        Console.WriteLine($"El area del circulo es : {area_C.Area(R)}");
                        Continuar();
                        break;
                    case 2:
                        Console.WriteLine("Introduce la base del triangulo: ");
                        float B_t = float.Parse(Console.ReadLine());
                        Console.WriteLine("Introduce la altura del triangulo: ");
                        float H_t = float.Parse(Console.ReadLine());

                        Triangulo area_T = new Triangulo(B_t, H_t);
                        Console.WriteLine($"El area del triangulo es : {area_T.Area(B_t,H_t)}");
                        Continuar();
                        break;
                    case 3:
                        Console.WriteLine("Introduce la base del rectangulo: ");
                        float B_r = float.Parse(Console.ReadLine());
                        Console.WriteLine("Introduce la altura del rectangulo: ");
                        float H_r = float.Parse(Console.ReadLine());

                        Rectangulo area_R = new Rectangulo(B_r, H_r);
                        Console.WriteLine($"El area del rectangulo es : {area_R.Area(B_r, H_r)}");
                        Continuar();
                        break;
                    default:
                        Console.WriteLine("No existe la opcion");
                        break;
                }
            }
            void Continuar()
            {
                Console.WriteLine("¿Desea continuar?");
                Console.WriteLine("1. Si");
                Console.WriteLine("2. No");

                int eleccion2 = int.Parse(Console.ReadLine());

                switch (eleccion2)
                {
                    case 1:
                        Console.WriteLine("Continuar...");
                        break;
                    case 2:
                        continueFlag = false;
                        break;
                }
            }
        }
    }
}
