using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise29
{
    class Program
    {
        static void Main(string[] args)
        {   
            //Pruebita del codigo
            Equipo equipoUno = new Equipo(20, "LolaMento");
            Jugador jugadorUno = new Jugador(123, "pepe", 20, 5);
            Jugador jugadorDos = new Jugador(321, "argento");
            Jugador jugadorTres = new Jugador(321, "lele");

            bool equipo;
            equipo = equipoUno + jugadorUno;
            if(equipo)
            {
                Console.WriteLine("Se agrego {0}",jugadorUno.MostrarDatos());
            }
            equipo = equipoUno + jugadorDos;
            
            if (equipo)
            {
                Console.WriteLine("Se agrego {0}", jugadorDos.MostrarDatos());
            }
            equipo = equipoUno + jugadorTres;
            if (equipo)
            {
                Console.WriteLine("Se agrego {0}", jugadorTres.MostrarDatos());
            }
            else
            {
                Console.WriteLine("jugador ya existe en el equipo");
            }
            Console.ReadKey();
        }
    }
}
