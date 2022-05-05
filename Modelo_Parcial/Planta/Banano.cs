using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jardineria
{
    public class Banano : Planta
    {
        string codigo;

        protected override bool TieneFlores
        {
            get { return true; }
        }

        protected override bool TieneFrutos
        {
            get { return true; }
        }

        public Banano(string nombre, int tamanio, string codigo) : base(nombre, tamanio)
        {
            this.codigo = codigo;
        }

        public override string ResumenDeDatos()
        {
            StringBuilder datos = new StringBuilder();
            datos.AppendLine(base.ResumenDeDatos());
            datos.AppendLine($"Codigo Internacional{this.codigo}");
            return datos.ToString();
        }

    }
}
