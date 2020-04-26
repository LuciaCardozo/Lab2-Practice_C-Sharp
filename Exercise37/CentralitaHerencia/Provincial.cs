using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Provincial: Llamada
    {
        protected Franja franjaHoraria;

        public Provincial(Franja miFranja,Llamada llamada):this(llamada.NroOrigen,miFranja, llamada.Duracion,llamada.NroDestino)
        {
            this.franjaHoraria = miFranja;
        }

        public Provincial(string origen,Franja miFranja,float duracion,string destino):base(duracion,destino,origen)
        {
            this.franjaHoraria = miFranja;
        }


        public float CostoDeLlamada
        {
            get
            {
                return this.CalcularCosto();
            }
        }

        private float CalcularCosto()
        {
            float resultado = 0;
            switch(this.franjaHoraria)
            {
                case Franja.Franja_01:
                    resultado = this.duracion *0.99f;
                    break;
                case Franja.Franja_02:
                    resultado = this.duracion * 1.25f;
                    break;
                case Franja.Franja_03:
                    resultado = this.duracion * 0.66f;
                    break;
            }
            return resultado;
        }

        public new string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"Franja horaria: {this.franjaHoraria}");
            sb.AppendLine($"Costo: {this.CostoDeLlamada}");
            return "";
        }
        public enum Franja
        {
            Franja_01,
            Franja_02,
            Franja_03
        }
    }
}
