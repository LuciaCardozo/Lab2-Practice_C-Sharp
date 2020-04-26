using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CentralitaHerencia;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Centralita c = new Centralita("Fede Center");

            Local l1 = new Local("Bernal", 30, "Rosario", 2.65f);
            Provincial l2 = new Provincial("Moron", Provincial.Franja.Franja_01, 21, "Bernal");
            Local l3 = new Local("Lanus",45,"San Rafael",1.99f);
            Provincial l4 = new Provincial(Provincial.Franja.Franja_03,l2);

            c.Llamadas.Add(l1);
            Console.WriteLine(c.Mostrar());
            c.Llamadas.Add(l2);
            Console.WriteLine(c.Mostrar());
            c.Llamadas.Add(l3);
            Console.WriteLine(c.Mostrar());
            c.Llamadas.Add(l4);
            Console.WriteLine(c.Mostrar());

            c.OrdenarLlamadas();
            Console.WriteLine(c.Mostrar());
            Console.ReadKey();

        }
    }
}
