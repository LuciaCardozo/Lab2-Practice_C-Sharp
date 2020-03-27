using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Pido al usuario que ingrese 10 numeros, valido y muestro el por pantalla(minimo, maximo y promedio)
namespace Clase2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            int result = 0;
            int numberMax = int.MinValue;
            int numberMin = int.MaxValue;
            float promedio;
            for(int i=0 ; i<10; i++)
            {
                Console.Write("Ingrese numero {0}:",i);
                if (int.TryParse(Console.ReadLine(), out number))
                {
                    if (Validacion.Validar(number, -100, 100))
                    {
                        if (numberMin > number)
                        {
                            numberMin = number;
                        }
                        else if (numberMax < number)
                        {
                            numberMax = number;
                        }
                        result += number;
                    }
                    else
                    {
                        Console.WriteLine("ERROR, Excediste el minimo o maximo");
                    }
                }
                else
                {
                    Console.WriteLine("ERROR, No es un numero");
                }
            }
            promedio = (float)result / 10;
            Console.WriteLine("Numero minimo {0}",numberMin);
            Console.WriteLine("Numero maximo {0}",numberMax);
            Console.WriteLine("Numero promedio {0}",promedio);
            Console.ReadKey();
        }
    }
}
