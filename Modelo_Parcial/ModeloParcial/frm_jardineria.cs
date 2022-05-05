using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Jardineria;


namespace ModeloParcial
{
    public partial class frm_jardineria : Form
    {
        Jardineria.Jardin jardin;

        public frm_jardineria()
        {
            InitializeComponent();
        }

        private void frm_jardineria_Load(object sender, EventArgs e)
        {
            this.jardin = new Jardin(100);
            bool pudo = this.jardin + new Arbusto("Arbusto 1", 10);
            pudo = this.jardin + new Arbusto("Arbusto 2", 15);
            pudo = this.jardin + new Rosal("Rosa 1", 20, Rosal.Colores.Amarilla);
            pudo = this.jardin + new Rosal("Rosa clásica", 25);
            pudo = this.jardin + new Banano("Banano ecuador", 30, "ECU001");
            if (!(this.jardin + new Banano("No carga", 1, "ARG028")))
            {
                MessageBox.Show("ERROR AL INGRESAR", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_mostrar_Click(object sender, EventArgs e)
        {
            rtxt_jardin.Text = jardin.ToString();
        }
    }
}
