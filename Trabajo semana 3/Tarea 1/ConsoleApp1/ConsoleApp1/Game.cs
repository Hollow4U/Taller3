using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Game
    {
        private bool continueFlag = true;
        private bool HeroCreation = true;
        private int Final;

        private List<Player> player;
        private List<EnemyMelee> Guerreros;
        private List<EnemyRange> Arqueros;

        public Game()
        {
            player = new List<Player>();
            Guerreros = new List<EnemyMelee>();
            Arqueros = new List<EnemyRange>();
        }

        public void Execute()
        {
            Guerreros.Add(new EnemyMelee("Guerrero Bravo", 70F, 15F));
            Guerreros.Add(new EnemyMelee("Guerrero Audaz", 50F, 10F));
            Arqueros.Add(new EnemyRange("Arquero rapaz", 30F, 20F, 2));
            Arqueros.Add(new EnemyRange("Arquero de medio tiempo (mal pagado)", 1f, 1f, 4));

            while (HeroCreation)
            {
                player.Add(CreateHero());
            }

            while (continueFlag)
            {
                Console.WriteLine("----------------------------------------------------");
                Console.WriteLine("Eres embocasco abruptamente por...");
                Console.WriteLine("----------------------------------------------------");
                foreach (EnemyMelee NICK in Guerreros)
                {
                    Console.WriteLine($"{NICK.GetName()}");
                }
                foreach (EnemyRange NICK in Arqueros)
                {
                    Console.WriteLine($"{NICK.GetName()}");
                }
            AttackFront();

            if (Guerreros.Count == 0)
            {
                AttackBack();
            }
            if (Arqueros.Count == 0)
            {
                    Console.WriteLine("----------------------------------------------------");
                    Console.WriteLine("----------------------------------------------------");
                    Console.WriteLine("Hero ha salido victorioso!!!");
                    Console.WriteLine("[Ganaste!!!]");
                    Console.WriteLine("----------------------------------------------------");
                    Console.WriteLine("----------------------------------------------------");
                    Console.WriteLine("Escribe 0 para terminar...");
                    Final = int.Parse(Console.ReadLine());

                    if (Final == 0)
                    {
                        continueFlag = false;
                    }
                }
            }
        }

        private Player CreateHero()
        {
            while(true)
            {
            Console.WriteLine("Elige la vida de tu heroe");
            float hp = float.Parse(Console.ReadLine());
            Console.WriteLine("Elige el daño de tu heroe");
            float dmg = float.Parse(Console.ReadLine());

            if(hp <= 100 && dmg <= 100)
            {
                HeroCreation = false;
                return new Player(hp, dmg);
            }
            else
            {
                Console.WriteLine("----------------------------------------------------");
                Console.WriteLine("El heroe no puede tener mas de 100 de vida o de daño");
                Console.WriteLine("----------------------------------------------------");
            }
            }
        }

        private void AttackFront()
        {
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("Hero se da cuenta que mientras tenga a los guerreros delante no podra atacar a los arqueros... ");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("----------------------------------------------------");
            while (true)
            {
                Console.WriteLine("¿Cual posicion del guerrero quieres atacar?");
                int option = int.Parse(Console.ReadLine());

                if (option >= 0 && option < Guerreros.Count)
                {
                    Console.WriteLine("----------------------------------------------------");
                    Console.WriteLine("----------------------------------------------------");
                    Console.WriteLine("Atacaste al Guerrero");
                    Console.WriteLine("----------------------------------------------------");
                    Console.WriteLine("----------------------------------------------------");


                    Console.WriteLine($"Le bajaste {player[0].DMG} de vida al Guerrero");
                    Guerreros[option].HP -= player[0].DMG;
                    if (Guerreros[option].HP <= 0)
                    {
                        Guerreros.RemoveAt(option);
                    }
                    if (Guerreros.Count == 0)
                    {
                        break;
                    }

                    foreach (EnemyMelee NICK in Guerreros)
                    {
                        Console.WriteLine($"{NICK.GetName()} te ataca");
                        player[0].HP -= NICK.DMG;
                    }

                    foreach (EnemyRange NICK in Arqueros)
                    {
                        NICK.ROUNDS -= 1;

                        if (NICK.ROUNDS <= 0)
                        {
                            Console.WriteLine($"{NICK.GetName()} no tiene muncion para atacarte");
                        }
                        else
                        {
                            Console.WriteLine($"{NICK.GetName()} te ataca");
                            player[0].HP -= NICK.DMG;
                        }
                    }

                    Console.WriteLine("----------------------------------------------------");
                    Console.WriteLine("----------------------------------------------------");
                    if (player[0].HP <= 0)
                    {
                        Console.WriteLine("----------------------------------------------------");
                        Console.WriteLine("----------------------------------------------------");
                        Console.WriteLine("Hero fue derrotado");
                        Console.WriteLine("[Fin del Juego.]");
                        Console.WriteLine("----------------------------------------------------");
                        Console.WriteLine("----------------------------------------------------");
                        Console.WriteLine("Escribe 0 para terminar...");
                        Final = int.Parse(Console.ReadLine());

                        if (Final == 0)
                        {
                            continueFlag = false;
                        }
                        break;
                    }
                }
            }
        }

        private void AttackBack()
        {
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("Hero se da cuenta que los guerreros han sido derrotados y ahora puede atacar a los arqueros... ");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("----------------------------------------------------");
            while (true)
            {
                Console.WriteLine("¿Cual posicion del arquero quieres atacar?");
                int option = int.Parse(Console.ReadLine());

                if (option >= 0 && option < Arqueros.Count)
                {
                    Console.WriteLine("----------------------------------------------------");
                    Console.WriteLine("----------------------------------------------------");
                    Console.WriteLine("Atacaste al Arquero");
                    Console.WriteLine("----------------------------------------------------");
                    Console.WriteLine("----------------------------------------------------");


                    Console.WriteLine($"Le bajaste {player[0].DMG} de vida al Guerrero");
                    Arqueros[option].HP -= player[0].DMG;
                    if (Arqueros[option].HP <= 0)
                    {
                        Arqueros.RemoveAt(option);
                    }
                    if (Arqueros.Count == 0)
                    {
                        break;
                    }
                    foreach (EnemyRange NICK in Arqueros)
                    {
                        NICK.ROUNDS -= 1;

                        if (NICK.ROUNDS <= 0)
                        {
                            Console.WriteLine($"{NICK.GetName()} no tiene muncion para atacarte");
                        }
                        else
                        {
                            Console.WriteLine($"{NICK.GetName()} te ataca");
                            player[0].HP -= NICK.DMG;
                        }
                    }

                    Console.WriteLine("----------------------------------------------------");
                    Console.WriteLine("----------------------------------------------------");

                    if (player[0].HP <= 0)
                    {
                        Console.WriteLine("----------------------------------------------------");
                        Console.WriteLine("----------------------------------------------------");
                        Console.WriteLine("Hero fue derrotado");
                        Console.WriteLine("[Fin del Juego.]");
                        Console.WriteLine("----------------------------------------------------");
                        Console.WriteLine("----------------------------------------------------");
                        Console.WriteLine("Escribe 0 cosa para continuar");
                        Final = int.Parse(Console.ReadLine());

                        if (Final == 0)
                        {
                            continueFlag = false;
                        }
                        break;
                    }
                }
            }
        }
    }
}