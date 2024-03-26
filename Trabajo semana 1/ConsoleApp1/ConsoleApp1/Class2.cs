using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Class2
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
                Console.WriteLine("4. Concluir operaciones");

                int eleccion = int.Parse(Console.ReadLine());

                switch(eleccion)
                {
                    case 1:
                        Circulo();
                        break;
                    case 2:
                        Triangulo();
                        break;
                    case 3:
                        Rectangulo();
                        break;
                    case 4:
                        continueFlag = false;
                        break;
                    default:
                        Console.WriteLine("No existe la opcion");
                        break;
                }
            }
        }

        void Circulo()
        {
            Console.WriteLine("Introduce el radio del circulo: ");
            float r = float.Parse(Console.ReadLine());

            Console.WriteLine("1. Calcular el area");
            Console.WriteLine("2. Calcular el perimetro");
            int eleccion = int.Parse(Console.ReadLine());

            switch (eleccion)
            {
                case 1:
                    Console.WriteLine($"El area es: {3.14f * (r * r)}");
                    break;
                case 2:
                    Console.WriteLine($"El perimetro es: {2 * 3.14f * r}");
                    break;
                default:
                    Console.WriteLine("No existe la opcion");
                    break;
            }
        }

        void Triangulo()
        {
            Console.WriteLine("Introduce la base del triangulo: ");
            float B = float.Parse(Console.ReadLine());
            Console.WriteLine("Introduce la altura del triangulo: ");
            float H = float.Parse(Console.ReadLine());

            Console.WriteLine("1. Calcular el area");
            int eleccion = int.Parse(Console.ReadLine());

            switch (eleccion)
            {
                case 1:
                    Console.WriteLine($"El area es: {(H * B) / 2}");
                    break;
                default:
                    Console.WriteLine("No existe la opcion");
                    break;
            }
        }

        void Rectangulo()
        {
            Console.WriteLine("Introduce la base del rectangulo: ");
            float B = float.Parse(Console.ReadLine());
            Console.WriteLine("Introduce la altura del rectangulo: ");
            float H = float.Parse(Console.ReadLine());

            Console.WriteLine("1. Calcular el area");
            Console.WriteLine("2. Calcular el perimetro");
            int eleccion = int.Parse(Console.ReadLine());

            switch (eleccion)
            {
                case 1:
                    Console.WriteLine($"El area es: {B * H}");
                    break;
                case 2:
                    Console.WriteLine($"El perimetro es: {2 *(B + H)}");
                    break;
                default:
                    Console.WriteLine("No existe la opcion");
                    break;
            }
        }
    }
}
