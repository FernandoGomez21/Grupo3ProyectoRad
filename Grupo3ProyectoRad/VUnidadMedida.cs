using Datos.BaseDatos.Models;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grupo3ProyectoRad
{
    public partial class VUnidadMedida : Form
    {
        NCondicionPago nCondicionPago;

        public VUnidadMedida()
        {
            InitializeComponent();
            nCondicionPago = new NCondicionPago();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                var condicionPago = new CondicionPago()
                {
                    Codigo = TxtCodigo.Text,
                    DescripcionCP = TxtDescripcion.Text,
                    Estado = CHKActivo.Checked,

                    FechaCreacion = DateTime.Now
                };

                if (!string.IsNullOrEmpty(TxtCondicionPago.Text))
                    condicionPago.CondicionPagoId = Convert.ToInt32(TxtCondicionPago.Text);

                nCondicionPago.AgregarCondicionPago(condicionPago);
                LimpiarDatos();
                CargarDatos();
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea eliminar?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (!string.IsNullOrEmpty(TxtCondicionPago.Text))
                {
                    var condicionPagoId = Convert.ToInt32(TxtCondicionPago.Text);
                    nCondicionPago.EliminarCondicionPago(condicionPagoId);
                    LimpiarDatos();
                    CargarDatos();
                }
            }
        }

        private void LimpiarDatos()
        {
            TxtCondicionPago.Clear();
            TxtCodigo.Clear();
            TxtDescripcion.Clear();
            CHKActivo.Checked = false;

        }

        private void DGVDatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (DGVDatos.CurrentRow != null)
            {
                var row = DGVDatos.CurrentRow;

                TxtCondicionPago.Text = row.Cells["CondicionPagoId"].Value.ToString();
                TxtCodigo.Text = row.Cells["Codigo"].Value.ToString();
                TxtDescripcion.Text = row.Cells["DescripcionCP"].Value.ToString();
                CHKActivo.Checked = Convert.ToBoolean(row.Cells["Estado"].Value);

            }
        }
        private bool ValidarDatos()
        {
            bool formularioValido = true;

            if (string.IsNullOrWhiteSpace(TxtCodigo.Text))
            {
                formularioValido = false;

            }

            if (string.IsNullOrWhiteSpace(TxtDescripcion.Text))
            {
                formularioValido = false;

            }

            return formularioValido;
        }

        private void CargarDatos()
        {
            DGVDatos.DataSource = nCondicionPago.ObtenerTodasCondicionesPago();
        }

        private void VUnidadMedida_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }
    }
}
