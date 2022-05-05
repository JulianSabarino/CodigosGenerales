using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jardineria
{
    public class Arbusto : Planta
    {
        protected override bool TieneFlores
        {
            get { return false; }
        }

        protected override bool TieneFrutos
        {
            get { return false; }
        }

        public Arbusto(string nombre, int tamanio) : base(nombre, tamanio){}
    }
}
