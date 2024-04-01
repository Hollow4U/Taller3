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
        int arrow = 0;
        int bullet = 0;

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
                Console.WriteLine("4. Flechas");
                Console.WriteLine("5. Balas");

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
                    case 4:
                        money -= 5;
                        arrow += 20;
                        Console.WriteLine($"Compraste 20 flechas, se desconto 5 de dinero y te quedan {money} de dinero");    
                        break;
                    case 5:
                        money -= 15;
                        bullet += 20;
                        Console.WriteLine($"Compraste 20 balas, se desconto 15 de dinero y te quedan {money} de dinero");
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
                Console.WriteLine("Esta arma requiere flechas cada una hace 20 de daño");
                Console.WriteLine("Introducir el daño del arma:");
                float DMG = float.Parse(Console.ReadLine());
                if (arrow > 0)
                {
                    DMG = DMG + 20;
                }
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
                Console.WriteLine("Esta arma requiere balas y cada una hace 50 de daño");
                Console.WriteLine("Introducir el daño del arma:");
                float DMG = float.Parse(Console.ReadLine());
                if (bullet > 0)
                {
                    DMG = DMG + 50;
                }
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
                Console.WriteLine("2. Eliminar arma");

                int option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        foreach(Weapons NICK in listArmas)
                        {
                            Console.WriteLine($"{NICK.GetName()}");
                        }
                        break;
                    case 2:
                        foreach (Weapons NICK in listArmas)
                        {
                            Console.WriteLine($"{NICK.GetName()}");
                        }
                        Console.WriteLine("Ingrese el numero del arma que desea eliminar: ");
                        int i = int.Parse(Console.ReadLine());
                        listArmas.RemoveAt(i);
                        break;
                    default:
                        Console.WriteLine("No existe la opcion");
                        break;
                }
            }
        }
    }
}
