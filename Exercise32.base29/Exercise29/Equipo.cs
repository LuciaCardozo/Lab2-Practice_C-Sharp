using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise29
{
    public class Equipo
    {
        private short cantidadDeJugadores;
        private List<Jugador> jugadores;
        private string nombre;

        private Equipo()
        {
            this.jugadores = new List<Jugador>();
        }

        public Equipo(short cantidad,string nombre): this()
        {
            this.cantidadDeJugadores = cantidad;
            this.nombre = nombre;
        }

        public static bool operator +(Equipo equipo, Jugador jugador)
        {
            bool estaEnLaLista = false;
            bool seAgregoJugador = false;
            if (equipo.jugadores.Count < equipo.cantidadDeJugadores)
            {
                foreach (Jugador auxJugador in equipo.jugadores)
                {
                    if (jugador == auxJugador)
                    {
                        estaEnLaLista = true;
                        break;
                    }
                }

                if (!estaEnLaLista)
                {
                    equipo.jugadores.Add(jugador);
                    seAgregoJugador = true;
                }
            }
            return seAgregoJugador;
        }
    }
}
