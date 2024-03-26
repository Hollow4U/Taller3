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
        
        public void Ejecutar()
        {
            bool continueFlag = true;

            while(continueFlag)
            {
                Console.WriteLine("Introduce el primer numero (#):");
                this.b = float.Parse(Console.ReadLine());
                Console.WriteLine("Introduce el segundo numero (#):");
                this.h = float.Parse(Console.ReadLine());

                Console.WriteLine("Elige la operacion a realizar (#):");
                Console.WriteLine("1. Suma");
                Console.WriteLine("2. Resta");
                Console.WriteLine("3. Multiplicacion");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. Modulo");
                Console.WriteLine("6. Concluir operaciones");

                int eleccion = int.Parse(Console.ReadLine());

                switch(eleccion)
                {
                    case 1:
                        Suma();
                        break;
                    case 2:
                        Resta();
                        break;
                    case 3:
                        Multiplicacion();
                        break;
                    case 4:
                        Division();
                        break;
                    case 5:
                        Modulo();
                        break;
                    case 6:
                        continueFlag = false;
                        break;
                    default:
                        Console.WriteLine("No existe la opcion");
                        break;
                }
            }
            void Suma()
            {
                Console.WriteLine($"La suma de estos dos numeros es: {b + h}");
            }

            void Resta()
            {
                Console.WriteLine($"La resta de estos dos numeros es: {b - h}");
            }

            void Multiplicacion()
            {
                Console.WriteLine($"La multiplicacion de estos dos numeros es: {b * h}");
            }

            void Division()
            {
                Console.WriteLine($"La division de estos dos numeros es: {b / h}");
            }

            void Modulo()
            {
                Console.WriteLine($"El residuo de estos dos numeros es: {b % h}");
            }
        }
    }
}
