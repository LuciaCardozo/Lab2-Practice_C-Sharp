using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Centralita
    {
        private List<Llamada> listaDeLlamada;
        protected string razonSocial;

        public float GananciasPorLocal
        {
            get
            {
                return this.CalcularGanancia(Llamada.TipoLlamada.Local);
            }
        }

        public float GananciasPorProvincia
        {
            get
            {
                return this.CalcularGanancia(Llamada.TipoLlamada.Provincial);
            }
        }

        public float GananciasPorTotal
        {
            get
            {
                return this.CalcularGanancia(Llamada.TipoLlamada.Todas);
            }
        }

        public List<Llamada> Llamadas
        {
            get
            {
                return this.listaDeLlamada;
            }
        }

        public Centralita()
        {
            this.listaDeLlamada = new List<Llamada>();
        }

        public Centralita(string nombreEmpresa): this()
        {
            this.razonSocial = nombreEmpresa;
        }

        private float CalcularGanancia(Llamada.TipoLlamada tipo)
        {
            float ganancias = 0;
            foreach (Llamada llamada in listaDeLlamada)
            {
                if(tipo == Llamada.TipoLlamada.Local || tipo == Llamada.TipoLlamada.Todas)
                {
                    if(llamada is Local)
                    {
                        ganancias += ((Local)llamada).CostoLlamada;
                    }
                }
                else if(tipo == Llamada.TipoLlamada.Provincial || tipo == Llamada.TipoLlamada.Todas)
                {
                    if(llamada is Provincial)
                    {
                        ganancias += ((Provincial)llamada).CostoDeLlamada;
                    }
                }
            }
            return ganancias;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Razon social: {this.razonSocial}");
            sb.AppendLine($"Ganancia Total: {this.GananciasPorTotal}");
            sb.AppendLine($"Ganancia por llamados locales: {this.GananciasPorLocal}");
            sb.AppendLine($"Ganancia por llamados provinciales: {this.GananciasPorProvincia}");
            foreach(Llamada llamada in listaDeLlamada)
            {   
                sb.AppendLine($"\nDetalle de la llamada\n {llamada.Mostrar()}");
                sb.AppendLine($"\n---------------------------");
            }
            return sb.ToString();
        }

        public void OrdenarLlamadas()
        {
            listaDeLlamada.Sort(Llamada.OrdenarPorDuracion);
        }
    }
}
