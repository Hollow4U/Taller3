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
                Shape shape = null;

                Console.WriteLine("Introducir el numero de la operacion a realizar");
                Console.WriteLine("1. Triangulo");
                Console.WriteLine("2. Rectangulo");
                Console.WriteLine("3. Circulo");
                Console.WriteLine("4. Terminar programa");

                int option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        GetTriangle();
                        break;
                    case 2:
                        GetRectangle();
                        break;
                    case 3:
                        GetCircle();
                        break;
                    case 4:
                        continueFlag = false;
                        break;
                    default:
                        Console.WriteLine("Esa opcion no existe");
                        break;

                }
            }
        }

        private Triangle GetTriangle()
        {
            Console.WriteLine("Introduce la base del triangulo");
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine("Introduce la altura del triangulo");
            float h = float.Parse(Console.ReadLine());
            return new Triangle(b, h);
        }

        private Rectangle GetRectangle()
        {
            Console.WriteLine("Introduce la base del rectangulo");
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine("Introduce la altura del rectangulo");
            float h = float.Parse(Console.ReadLine());
            return new Rectangle(b, h);
        }

        private Circle GetCircle()
        {
            Console.WriteLine("Introduce el radio del ciruclo");
            float r = float.Parse(Console.ReadLine());
            return new Circle(r);
        }
    }
}
