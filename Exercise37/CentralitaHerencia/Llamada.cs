using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Llamada
    {
        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        public float Duracion
        {
            get
            {
                return this.duracion;
            }
        }
         
        public string NroDestino
        {
            get
            {
                return this.nroDestino;
            }
        }

        public string NroOrigen
        {
            get
            {
                return this.nroOrigen;
            }
        }

        public Llamada (float duracion,string nroDestino,string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Duracion: {this.duracion}");
            sb.AppendLine($"Numero de destino: {this.nroDestino}");
            sb.AppendLine($"Numero de Origen: {this.nroOrigen}");
            return sb.ToString();
        }

        public static int OrdenarPorDuracion(Llamada llamadaUno,Llamada llamadaDos)
        {
            if(llamadaUno.duracion == llamadaDos.duracion)
            {
                return 0;
            }
            else if(llamadaUno.duracion > llamadaDos.duracion)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }
        public enum TipoLlamada
        {
            Local,
            Provincial,
            Todas
        }
    }
}
