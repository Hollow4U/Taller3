using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Menu
    {
        public void Ejecutar()
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
                int eleccion = int.Parse(Console.ReadLine());

                switch (eleccion)
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
                            Años();
                            break;
                        }
                    case 4:
                        {
                            Calculadora();
                            break;
                        }
                    case 5:
                        {
                            Formas();
                            break;
                        }
                    case 6:
                        {
                            Constructor();
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
            float B;
            float H;
            Console.WriteLine("Introduce la base del triangulo");
            B = float.Parse(Console.ReadLine());
            Console.WriteLine("Introduce la altura derecho del triangulo");
            H = float.Parse(Console.ReadLine());
            Console.WriteLine($"El area de un triangulo es: {(B * H)/ 2}");
        }
        private void Años()
        {
            Console.WriteLine("Introduce el año: ");
            int año = int.Parse(Console.ReadLine());

            if(año % 4 == 0)
            {
                if (año % 100 == 0)
                {
                    if(año % 400 == 0)
                    {
                        Console.WriteLine($"{año} es un año bisiesto");
                    }
                    else
                    {
                        Console.WriteLine($"{año} no es un año bisiesto");
                    }
                }
                else
                {
                    Console.WriteLine($"{año} es un año bisiesto");
                }
            }
            else
            {
                Console.WriteLine($"{año} no es un año bisiesto");
            }
        }

        private void Calculadora()
        {
            Class1 calculadora = new Class1();
            calculadora.Ejecutar();
        }

        private void Formas()
        {
            Class2 formas = new Class2();
            formas.Ejecutar();
        }
        
        private void Constructor()
        {
            Class3 constructor = new Class3();
            constructor.Ejecutar();
        }

    }
}
