using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Class3
    {
        public int _year;

        public void Año()
        {
            Console.WriteLine("Escribe el año: ");
            int _year = int.Parse(Console.ReadLine());

            if(_year % 4 == 0)
            {
                if (_year % 100 == 0)
                {
                    if (_year % 400 == 0)
                    {
                        Console.WriteLine($"{_year} es un año bisiesto");
                    }
                    else 
                    {
                        Console.WriteLine($"{_year} no es un año bisiesto");
                    }
                }
                else
                {
                    Console.WriteLine($"{_year} es un año bisiesto");
                }
            }
            else
            {
                Console.WriteLine($"{_year} no es un año bisiesto");
            }
        }

    }
}
