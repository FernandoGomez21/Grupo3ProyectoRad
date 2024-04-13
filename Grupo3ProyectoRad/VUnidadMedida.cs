using System;
using System.Drawing;
using System.Windows.Forms;
using Datos.BaseDatos.Models;
using Negocio;

namespace Grupo3ProyectoRad
{
    public partial class VUnidadMedida : Form
    {
        NUnidadMedida nUnidaMedidad;

        public VUnidadMedida()
        {
            InitializeComponent();
            nUnidaMedidad = new NUnidadMedida();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                UnidadMedida Cliente = new UnidadMedida()
                {
                    Codigo = TxtCodigo.Text.ToString(),
                    DescripcionUM = TxtDescripcion.Text.ToString(),
                    FechaCreacion = DateTime.Now,
                    Estado = CHKActivo.Checked
                };
                if (!string.IsNullOrEmpty(TxtUnidadMedidaId.Text) || !string.IsNullOrWhiteSpace(TxtUnidadMedidaId.Text))
                {
                    if (int.Parse(TxtUnidadMedidaId.Text.ToString()) != 0)
                    {
                        Cliente.UnidadMedidaId = int.Parse(TxtUnidadMedidaId.Text.ToString());
                    }
                }
                nUnidaMedidad.AgregarUnidadMedida(Cliente);
                LimpiarDatos();
                CargarDatos();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea eliminar?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (!string.IsNullOrEmpty(TxtUnidadMedidaId.Text))
                {
                    var condicionPagoId = Convert.ToInt32(TxtUnidadMedidaId.Text);
                    nUnidaMedidad.EliminarUnidadMedida(condicionPagoId);
                    LimpiarDatos();
                    CargarDatos();
                    MessageBox.Show("Eliminado con Exito!!");
                }
            }
        }

        private void LimpiarDatos()
        {
            TxtUnidadMedidaId.Clear();
            TxtCodigo.Clear();
            TxtDescripcion.Clear();
            CHKActivo.Checked = false;

        }

        private void DGVDatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (DGVDatos.CurrentRow != null)
            {
                var row = DGVDatos.CurrentRow;

                TxtUnidadMedidaId.Text = row.Cells["CondicionPagoId"].Value.ToString();
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
            DGVDatos.DataSource = nUnidaMedidad.TodasLasUnidadesMedida();
        }

        private void VUnidadMedida_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void CHKActivos_CheckedChanged(object sender, EventArgs e)
        {
            if (CHKActivos.Checked == true)
            {
                DGVDatos.DataSource = nUnidaMedidad.UnidadesMedidaActivas();
            }
            else
            {
                CargarDatos();
            }
        }

        private void DGVDatos_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            TxtUnidadMedidaId.Text = DGVDatos.CurrentRow.Cells["UnidadMedidaId"].Value.ToString();
            TxtCodigo.Text = DGVDatos.CurrentRow.Cells["Codigo"].Value.ToString();
            TxtDescripcion.Text = DGVDatos.CurrentRow.Cells["DescripcionUM"].Value.ToString();
            CHKActivo.Checked = bool.Parse(DGVDatos.CurrentRow.Cells["Estado"].Value.ToString());
            btnEliminar.Enabled = false;
            btnEliminar.BackColor = Color.White;
        }

        private void DGVDatos_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            TxtUnidadMedidaId.Text = DGVDatos.CurrentRow.Cells["UnidadMedidaId"].Value.ToString();
            TxtCodigo.Text = DGVDatos.CurrentRow.Cells["Codigo"].Value.ToString();
            TxtDescripcion.Text = DGVDatos.CurrentRow.Cells["DescripcionUM"].Value.ToString();
            CHKActivo.Checked = bool.Parse(DGVDatos.CurrentRow.Cells["Estado"].Value.ToString());
            btnEliminar.Enabled = true;
            btnEliminar.BackColor = Color.Red;
        }

        private void BTNLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarDatos();
        }
    }
}
