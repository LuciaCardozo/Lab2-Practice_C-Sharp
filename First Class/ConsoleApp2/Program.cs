using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Pido al usuario 5 numeros y muestro el minimo, maximo y promedio
namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            int numberMax = Int32.MinValue;
            int numberMin = Int32.MaxValue;
            int result = 0;
            for(int i = 0; i<5; i++)
            {
                Console.Write("Ingrese numero {0}: ", i);
                
                if(int.TryParse(Console.ReadLine(), out number))
                {
                    if(numberMax < number)
                    {
                        numberMax = number;
                    }
                    else if(numberMin > number)
                    {
                        numberMin = number;
                    }
                    result += number;
                }
                else
                {
                    Console.WriteLine("ERRoR");                   
                }
            }
            Console.WriteLine("Numero minimo: {0}",numberMin);
            Console.WriteLine("Numero maximo: {0}",numberMax);
            Console.WriteLine("Promedio: {0}",(float)result/5);
            Console.ReadKey();

        }
    }
}
