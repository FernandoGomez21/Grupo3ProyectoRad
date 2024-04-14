using System;
using System.Drawing;
using System.Windows.Forms;
using Datos.BaseDatos.Models;
using Negocio;

namespace Grupo3ProyectoRad
{
    public partial class VCondicionPago : MenuPrin
    {
        NCondicionPago nCondicionPago;
        public VCondicionPago()
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
                    Dias = int.Parse(TxtDias.Text),
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
                    MessageBox.Show("Eliminado con Exito!!");
                }
            }
        }

        private void LimpiarDatos()
        {
            TxtCondicionPago.Clear();
            TxtCodigo.Clear();
            TxtDescripcion.Clear();
            CHKActivo.Checked = false;
            TxtDias.Clear();
        }

        private void CargarDatos()
        {
            DGVDatos.DataSource = nCondicionPago.ObtenerTodasCondicionesPago();
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
            if (string.IsNullOrWhiteSpace(TxtDias.Text))
            {
                formularioValido = false;
            }
            return formularioValido;
        }

        private void VCondicionPago_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void DGVDatos_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            TxtCondicionPago.Text = DGVDatos.CurrentRow.Cells["CondicionPagoId"].Value.ToString();
            TxtCodigo.Text = DGVDatos.CurrentRow.Cells["Codigo"].Value.ToString();
            TxtDescripcion.Text = DGVDatos.CurrentRow.Cells["DescripcionCP"].Value.ToString();
            TxtDias.Text = DGVDatos.CurrentRow.Cells["Dias"].Value.ToString();
            CHKActivo.Checked = bool.Parse(DGVDatos.CurrentRow.Cells["Estado"].Value.ToString());
            btnEliminar.Enabled = false;
            btnEliminar.BackColor = Color.White;
        }

        private void DGVDatos_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            TxtCondicionPago.Text = DGVDatos.CurrentRow.Cells["CondicionPagoId"].Value.ToString();
            TxtCodigo.Text = DGVDatos.CurrentRow.Cells["Codigo"].Value.ToString();
            TxtDescripcion.Text = DGVDatos.CurrentRow.Cells["DescripcionCP"].Value.ToString();
            TxtDias.Text = DGVDatos.CurrentRow.Cells["Dias"].Value.ToString();
            CHKActivo.Checked = bool.Parse(DGVDatos.CurrentRow.Cells["Estado"].Value.ToString());
            btnEliminar.Enabled = true;
            btnEliminar.BackColor = Color.Red;
        }

        private void CHKActivos_CheckedChanged(object sender, EventArgs e)
        {
            if (CHKActivos.Checked == true)
            {
                DGVDatos.DataSource = nCondicionPago.CondicionesPagoActivas();
            }
            else
            {
                CargarDatos();
            }
        }

        private void BTNLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarDatos();
        }
    }
}
