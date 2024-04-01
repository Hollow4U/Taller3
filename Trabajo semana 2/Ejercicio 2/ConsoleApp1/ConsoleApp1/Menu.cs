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
        List<Weapons> listArmas = new List<Weapons>();

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
                        EditWeapons();
                        break;
                    case 3:
                        continueFlag = false;
                        break;
                    default:
                        Console.WriteLine("No existe la opcion");
                        break;
                }

            }
            void AddArmas()
            {
                Console.WriteLine("¿Que arma quieres comprar?:");
                Console.WriteLine("1. Espada");
                Console.WriteLine("2. Arco");
                Console.WriteLine("3. Pistola");

                int option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        GetSword();
                        break;
                    case 2:
                        GetBow();
                        break;
                    case 3:
                        GetPistol();
                        break;
                    default:
                        Console.WriteLine("No existe la opcion");
                        break;
                }
            }

            Sword GetSword()
            {
                Console.WriteLine("Introducir el daño del arma:");
                float DMG = float.Parse(Console.ReadLine());
                Console.WriteLine("Introducir la velocidad de ataque del arma:");
                float DPS = float.Parse(Console.ReadLine());
                Console.WriteLine("Introducir el precio deseado:");
                float PRICE = float.Parse(Console.ReadLine());
                if(PRICE > money)
                {
                    Console.WriteLine("No tienes suficiente dinero para comprar esta arma");
                    return null;
                }
                else
                {
                    money = money - PRICE;
                    Console.WriteLine("Nombra tu arma:");
                    string NICK = Console.ReadLine();
                    Console.WriteLine($"Te quedan {money} para comprar");

                    listArmas.Add(new Sword(NICK, DMG, DPS, PRICE));
                    return new Sword(NICK, DMG, DPS, PRICE);
                }
            }

            Bow GetBow()
            {
                Console.WriteLine("Introducir el daño del arma:");
                float DMG = float.Parse(Console.ReadLine());
                Console.WriteLine("Introducir la velocidad de ataque del arma:");
                float DPS = float.Parse(Console.ReadLine());
                Console.WriteLine("Introducir el precio deseado:");
                float PRICE = float.Parse(Console.ReadLine());
                if (PRICE > money)
                {
                    Console.WriteLine("No tienes suficiente dinero para comprar esta arma");
                    return null;
                }
                else
                {
                    money = money - PRICE;
                    Console.WriteLine("Nombra tu arma:");
                    string NICK = Console.ReadLine();
                    Console.WriteLine($"Te quedan {money} para comprar");

                    listArmas.Add(new Bow(NICK, DMG, DPS, PRICE));
                    return new Bow(NICK, DMG, DPS, PRICE);
                }
            }

            Pistol GetPistol()
            {
                Console.WriteLine("Introducir el daño del arma:");
                float DMG = float.Parse(Console.ReadLine());
                Console.WriteLine("Introducir la velocidad de ataque del arma:");
                float DPS = float.Parse(Console.ReadLine());
                Console.WriteLine("Introducir el precio deseado:");
                float PRICE = float.Parse(Console.ReadLine());
                if (PRICE > money)
                {
                    Console.WriteLine("No tienes suficiente dinero para comprar esta arma");
                    return null;
                }
                else
                {
                    money = money - PRICE;
                    Console.WriteLine("Nombra tu arma:");
                    string NICK = Console.ReadLine();
                    Console.WriteLine($"Te quedan {money} para comprar");

                    listArmas.Add(new Pistol(NICK, DMG, DPS, PRICE));
                    return new Pistol(NICK, DMG, DPS, PRICE);
                }
            }

            void EditWeapons()
            {
                Console.WriteLine("¿Que operacion quieres realizar?:");
                Console.WriteLine("1. Ver las armas disponibles");
                Console.WriteLine("2. Vender arma");

                int option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        foreach(Weapons Nick in listArmas)
                        {
                            Console.WriteLine($"{Nick.ToString()}");
                        }
                        break;
                    case 2:
                        Console.WriteLine("No existe la opcion");
                        break;
                    default:
                        Console.WriteLine("No existe la opcion");
                        break;
                }
            }
        }
    }
}
