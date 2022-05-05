using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jardineria
{
    public class Jardin
    {
        public enum Tipo
        {
            Terrozo,
            Arenozo
        }

        private int espacioTotal;
        private List<Planta> plantas;
        static Tipo tipo = Tipo.Terrozo;

        public Tipo TipoSuelo
        {
            set { tipo = value; }
        }

        private int EspacioOcupado()
        {
            int totalSize = 0;
            foreach (Planta planta in plantas)
            {
                totalSize = totalSize + planta.Tamanio;
            }
            return totalSize;
        }

        private int EspacioOcupado(Planta planta)
        {
            return (EspacioOcupado() + planta.Tamanio);
        }

        private Jardin()
        {
            this.plantas = new List<Planta>();
        }

        public Jardin(int espacioTotal): this()
        {
            this.espacioTotal = espacioTotal;
        }

        public static bool operator +(Jardin jardin, Planta planta)
        {
            int totalSize = jardin.EspacioOcupado(planta);
            bool pudo = false;
            if (jardin.espacioTotal >= totalSize)
            {
                jardin.plantas.Add(planta);
                pudo = true;
            }

            return pudo;
        }

        public override string ToString() //nothing -> override
        {
            StringBuilder lista = new StringBuilder();
            foreach (Planta planta in plantas)
            {
                lista.Append($"------------------------{Environment.NewLine}");
                lista.Append(planta.ResumenDeDatos());
            }
            return lista.ToString();
        }

    }
}
