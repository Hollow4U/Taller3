using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Menu
    {
        public void Execute()
        {
            bool continueFlag = true;

            while (continueFlag)
            {
                Shape shape = null;

                Console.WriteLine("Elegir la forma:");
                Console.WriteLine("1. Rectangulo");
                Console.WriteLine("2. Circulo");
                Console.WriteLine("3. Triangulo");
                Console.WriteLine("4. Salir");


                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        shape = GetRectangle();
                        break;
                    case "2":
                        shape =  GetCircle();
                        break;
                    case "3":
                        shape = GetTriangle();
                        break;
                    case "4":
                        continueFlag = false;
                        break;
                    default:
                        Console.WriteLine("No existe lo opcion");
                        break;
                }

                if (shape != null)
                {
                    Console.WriteLine($"El area del {shape.Name} es {shape.CalculateArea()}");
                }
            }
        }

        private Circle GetCircle()
        {
            Console.WriteLine("Introducir el radio del ciruclo:");
            float r = float.Parse(Console.ReadLine());
            return new Circle(r);
        }

        private Triangle GetTriangle()
        {
            Console.WriteLine("Introducir la base del triangulo:");
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine("Introducir la altura del triangulo:");
            float h = float.Parse(Console.ReadLine());
            return new Triangle(b, h);
        }

        private Rectangle GetRectangle()
        {
            Console.WriteLine("Introducir la base del rectangulo:");
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine("Introducir la altura del rectangulo:");
            float h = float.Parse(Console.ReadLine());
            return new Rectangle(b, h);
        }
    }
}
