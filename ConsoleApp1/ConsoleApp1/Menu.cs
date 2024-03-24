using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Menu
    {
        public void Execute()
        {
            bool continueFlag = true;
            while (continueFlag)
            {
                Console.WriteLine("Elegir (#):");
                Console.WriteLine("1. Area y perimetro de un Rectangulo");
                Console.WriteLine("2. Area de Triangulo");
                Console.WriteLine("3. Año bisiesto");
                Console.WriteLine("4. Calculadora");
                Console.WriteLine("5. Crear forma");
                Console.WriteLine("6. Operar figuras");
                int option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        {
                            Rectangulo();
                            break;
                        }
                    case 2:
                        {
                            Triangulo();
                            break;
                        }
                    case 3:
                        {
                            break;
                        }
                    case 4:
                        {
                            break;
                        }
                    case 5:
                        {
                            break;
                        }
                    case 6:
                        {
                            break;
                        }
                    default:
                        Console.WriteLine("No existe la opcion");
                        break;
                }

            }
        }
        private void Rectangulo()
        {
            float h;
            float b;
            Console.WriteLine("Introduce la base del rectangulo");
            b = float.Parse(Console.ReadLine());
            Console.WriteLine("Introduce la altura del rectangulo");
            h = float.Parse(Console.ReadLine());
            Console.WriteLine($"El area del rectangulo es: {b * h}");
            Console.WriteLine($"El perimetro del rectangulo es: {2 * (b + h)}");
        }
        private void Triangulo()
        {
            float L1;
            float L2;
            float L3;
            Console.WriteLine("Introduce el lado inferior del triangulo");
            L1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Introduce el lado derecho del triangulo");
            L2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Introduce el lado izquierdo del triangulo");
            L3 = float.Parse(Console.ReadLine());
            Console.WriteLine($"El are de un triangulo e: {(L1 + L2 + L3) / 2}");
        }
        private void Años()
        {

        }
    }
}
