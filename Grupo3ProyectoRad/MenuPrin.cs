using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Grupo3PrimerFase;

namespace Grupo3ProyectoRad
{
    public partial class MenuPrin : Form
    {
        public MenuPrin()
        {
            InitializeComponent();
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CategoriaV categoria = new CategoriaV();
            categoria.Show();

        }

        private void grupoDescuentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GrupoDescuentoV descuento = new GrupoDescuentoV();
            descuento.Show();
        }

        private void unidadDeMedidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VUnidadMedida descuento = new VUnidadMedida();
            descuento.Show();
        }

        private void condicionDePagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VCondicionPago descuento = new VCondicionPago();
            descuento.Show();
        }
    }
}
