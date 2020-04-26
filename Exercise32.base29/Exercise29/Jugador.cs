using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise29
{
    public class Jugador
    {
        private int dni;
        private string nombre;
        private int partidosJugados;
        private int totalGoles;

        //public float GetPromedioGoles()
        //{
        //    this.promedioGoles = (float)this.totalGoles / this.partidosJugados;
        //    if (this.promedioGoles>0)
        //    {
        //        return this.promedioGoles;
        //    }
        //    else
        //    {
        //        return 0;
        //    }
        //}

        private Jugador() 
        {
            //this.promedioGoles = 0;
            this.totalGoles = 0;
            this.partidosJugados = 0;
        }

        public Jugador(int dni, string nombre): this()
        {
            this.dni = dni;
            this.nombre = nombre;
        }

        public Jugador(int dni,string nombre,int totalGoles, int totalPartido): this(dni,nombre)
        {
            this.totalGoles = totalGoles;
            this.partidosJugados = totalPartido;
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Nombre: {0}\n",this.nombre);
            sb.AppendFormat("Dni: {0}\n", this.dni);
            sb.AppendFormat("Total de Goles: {0}\n", this.totalGoles);
            sb.AppendFormat("Partidos Jugados: {0}\n", this.partidosJugados);
            sb.AppendFormat("Promedio de Goles: {0}\n", this.PromedioGoles);
            return sb.ToString();
        }

        public static bool operator ==(Jugador j1,Jugador j2)
        {
            return j1.dni == j2.dni;
        }

        public static bool operator !=(Jugador j1,Jugador j2)
        {
            return !(j1 == j2);//reutilizamos el codigo == no hace falta .dni
        }

        public int PartidosJugados
        {
            get
            {
                return this.partidosJugados;
            }
        }

        public float PromedioGoles
        {
            get
            {
                if(partidosJugados>0)
                {
                     return (float)this.totalGoles/this.partidosJugados; 
                }
                else 
                {
                    return 0;
                }
            }
            
        }
         public int TotalGoles
        {
            get
            {
                return this.totalGoles;
            }
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                if(value.Length>0)
                {
                    this.nombre = value;
                }
                else
                {
                    this.nombre = "Null";
                }
            }
        }

        public int Dni
        {
            get
            {
                return this.dni;
            }
            set
            {
                if(value>0)
                {
                    this.dni = value;
                }
                else
                {
                    this.dni = 0;
                }
            }
        }
    }
}
