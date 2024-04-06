using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos.BaseDatos.Models;
using Negocio;

namespace Grupo3PrimerFase
{
    public partial class GrupoDescuentoV : Form
    {
        private NGrupoDescuento ndescuento;
        public GrupoDescuentoV()
        {
            InitializeComponent();
            ndescuento = new NGrupoDescuento();
        }

        private void GrupoDescuentoV_Load(object sender, EventArgs e)
        {
            cargarDatos();
        }
        private void cargarDatos()
        {
            DGVDatos.DataSource = ndescuento.TodoslosDescuentos();
        }

        private void LimpiarDatos()
        {
            TxtDescuentoId.Text = "";
            TxtCodigo.Text = "";
            TxtDescripcion.Text = "";
            TxtPorcentaje.Text = "";
            CHKActivo.Checked = false;
            errorProvider1.Clear();
        }
        private bool ValidarDatos()
        {
            var FormularioValido = true;
            if (string.IsNullOrEmpty(TxtCodigo.Text.ToString()) || string.IsNullOrWhiteSpace(TxtCodigo.Text.ToString()))
            {
                FormularioValido = false;
                errorProvider1.SetError(TxtCodigo, "Debe ingresar el Codigo ");
                return FormularioValido;
            }
            if (string.IsNullOrEmpty(TxtDescripcion.Text.ToString()) || string.IsNullOrWhiteSpace(TxtDescripcion.Text.ToString()))
            {
                FormularioValido = false;
                errorProvider1.SetError(TxtDescripcion, "Debe ingresar la Descripcion ");
                return FormularioValido;
            }
            if (string.IsNullOrEmpty(TxtPorcentaje.Text.ToString()) || string.IsNullOrWhiteSpace(TxtPorcentaje.Text.ToString()))
            {
                FormularioValido = false;
                errorProvider1.SetError(TxtPorcentaje, "Debe ingresar El Porcentaje ");
                return FormularioValido;
            }
            return FormularioValido;
        }


        private void CHKActivos_CheckedChanged(object sender, EventArgs e)
        {
            if (CHKActivos.Checked == true)
            {
                DGVDatos.DataSource = ndescuento.DescuentosActivos();
            }
            else
            {
                cargarDatos();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro que decea Eliminar", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                if (!string.IsNullOrEmpty(TxtDescuentoId.Text.ToString()) ||
                  !string.IsNullOrWhiteSpace(TxtDescuentoId.Text.ToString()))
                {
                    if (int.Parse(TxtDescuentoId.Text.ToString()) != 0)
                    {
                        var descuentoid = int.Parse(TxtDescuentoId.Text.ToString());
                        ndescuento.EliminarDescuentos(descuentoid);
                        cargarDatos();
                        LimpiarDatos();
                    }
                }
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {

            if (ValidarDatos())
            {
                GrupoDescuento Cliente = new GrupoDescuento()
                {
                    Codigo = TxtCodigo.Text.ToString(),
                    DescripcionGD = TxtDescripcion.Text.ToString(),
                    FechaCreacion = DateTime.Now,
                    Porcentaje = int.Parse(TxtPorcentaje.Text.ToString()),
                    Estado = CHKActivo.Checked
                };
                if (!string.IsNullOrEmpty(TxtDescuentoId.Text) || !string.IsNullOrWhiteSpace(TxtDescuentoId.Text))
                {
                    if (int.Parse(TxtDescuentoId.Text.ToString()) != 0)
                    {
                        Cliente.GrupoDescuentoId = int.Parse(TxtDescuentoId.Text.ToString());
                    }
                }
                ndescuento.AgregarDescuentos(Cliente);
                LimpiarDatos();
                cargarDatos();
            }
        }

        private void DGVDatos_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            TxtDescuentoId.Text = DGVDatos.CurrentRow.Cells["GrupoDescuentoId"].Value.ToString();
            TxtCodigo.Text = DGVDatos.CurrentRow.Cells["Codigo"].Value.ToString();
            TxtDescripcion.Text = DGVDatos.CurrentRow.Cells["DescripcionGD"].Value.ToString();
            CHKActivo.Checked = bool.Parse(DGVDatos.CurrentRow.Cells["Estado"].Value.ToString());
            TxtPorcentaje.Text = DGVDatos.CurrentRow.Cells["Porcentaje"].Value.ToString();
            btnEliminar.Enabled = false;
        }

        private void DGVDatos_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            TxtDescuentoId.Text = DGVDatos.CurrentRow.Cells["GrupoDescuentoId"].Value.ToString();
            TxtCodigo.Text = DGVDatos.CurrentRow.Cells["Codigo"].Value.ToString();
            TxtDescripcion.Text = DGVDatos.CurrentRow.Cells["DescripcionGD"].Value.ToString();
            CHKActivo.Checked = bool.Parse(DGVDatos.CurrentRow.Cells["Estado"].Value.ToString());
            TxtPorcentaje.Text = DGVDatos.CurrentRow.Cells["Porcentaje"].Value.ToString();
            btnEliminar.Enabled = true;
            btnEliminar.BackColor = Color.Red;
        }
    }
}
