using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Menu
    {
        string name;
        List<Armas> listArmas = new List<Armas>();

        public void Execute()
        {
            bool continueFlag = true;

            Console.WriteLine("Ingresa la cantidad de dinero que tienes");
            float money = float.Parse(Console.ReadLine());

            while(continueFlag)
            {
                Console.WriteLine("Elige una de las siguientes opciones:");
                Console.WriteLine("1. Comprar armas y/o municion");
                Console.WriteLine("2. Editar lista");
                Console.WriteLine("3. Salir");

                int option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        AddArmas();
                        break;
                    case 2:
                        break;
                    case 3:
                        continueFlag = false;
                        break;
                    default:
                        Console.WriteLine("No existe la opcion");
                        break;
                }

            }

        }

                for (int i = 0; i > listArmas.Count; i++)
            {
            
            }

        public void AddArmas()
        {

            Console.WriteLine("¿Que arma quieres comprar?:");
            Console.WriteLine("1. Espada");
            Console.WriteLine("2. Arco");
            Console.WriteLine("3. Pistola");

            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    
                    Console.WriteLine("Introducir nombre del arma:");
                     = Console.ReadLine();

                    break;
                case 2:
                    break;
                case 3:
                    break;
            }


        }

        private Sword GetSword()
        {
            Console.WriteLine("Introducir el daño del arma:");
            float DMG = float.Parse(Console.ReadLine());
            Console.WriteLine("Introducir la velocidad de ataque del arma:");
            float DPS = float.Parse(Console.ReadLine());
            Console.WriteLine("Introducir el precio deseado:");
            float PRICE = float.Parse(Console.ReadLine());

            return new Sword(DMG,DPS,PRICE);
        }

    }
}
