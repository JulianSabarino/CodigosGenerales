using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jardineria
{
    public class Rosal : Planta
    {
        public enum Colores
        {
            Roja,
            Blanca,
            Amarilla,
            Rosa,
            Azul
        }

        private Colores florColor;

        protected override bool TieneFlores
        {
            get { return true; }
        }

        protected override bool TieneFrutos
        {
            get { return false; }
        }

        public override string ResumenDeDatos()
        {
            StringBuilder datos = new StringBuilder();
            datos.AppendLine(base.ResumenDeDatos());
            datos.AppendLine($"Flores de color {this.florColor}");
            return datos.ToString();
        }

        public Rosal(string nombre, int tamanio) : base(nombre, tamanio)
        {
            this.florColor = Colores.Rosa;
        }

        public Rosal(string nombre, int tamanio, Colores florColor) : base(nombre, tamanio)
        {
            this.florColor = florColor;
        }
    }
}
