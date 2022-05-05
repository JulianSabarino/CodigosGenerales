using System;
using System.Text;

namespace Jardineria
{
    public abstract class Planta
    {
        private string nombre;
        private int tamanio;

        public int Tamanio
        {
            get { return tamanio; }
        }

        protected virtual bool TieneFlores
        {
            get;
        }

        protected virtual bool TieneFrutos
        {
            get;
        }

        public Planta(string nombre, int tamanio)
        {
            this.nombre = nombre;
            this.tamanio = tamanio;
        }

        virtual public string ResumenDeDatos()
        {
            StringBuilder datos = new StringBuilder();
            //datos.AppendLine(string.Format("Esto es un ejemplo de string format {0}",this.Tamanio));
            datos.AppendLine($"{this.nombre} tiene un tamaño de {this.Tamanio}");
            datos.AppendLine($"Tiene Flores {this.TieneFlores}");
            datos.AppendLine($"Tiene Frutos {this.TieneFrutos}");
            
            return datos.ToString();
        }

    }
}
