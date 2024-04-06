using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
using Datos.BaseDatos.Models;
using Negocio;

namespace Grupo3PrimerFase
{
    public partial class CategoriaV : Form
    {
        private NCategoriaModels ncategoria;
        public CategoriaV()
        {
            InitializeComponent();
            ncategoria = new NCategoriaModels();
        }
        private void cargarDatos()
        {
            DGVDatos.DataSource = ncategoria.TodaslasCategorias();
        }

        private void LimpiarDatos()
        {
            TxtCategoriaId.Text = "";
            TxtCodigo.Text = "";
            TxtDescripcion.Text = "";
            CHKActivo.Checked = false;
            errorProvider1.Clear();
        }
        private void CategoriaV_Load(object sender, EventArgs e)
        {
            cargarDatos();
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
            return FormularioValido;
        }

        private void CHKActivos_CheckedChanged(object sender, EventArgs e)
        {
            if (CHKActivos.Checked == true)
            {
                DGVDatos.DataSource = ncategoria.CategoriasActivas();
            }
            else
            {
                cargarDatos();
            }
        }

        private void DGVDatos_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            TxtCategoriaId.Text = DGVDatos.CurrentRow.Cells["CategoriaId"].Value.ToString();
            TxtCodigo.Text = DGVDatos.CurrentRow.Cells["Codigo"].Value.ToString();
            TxtDescripcion.Text = DGVDatos.CurrentRow.Cells["DescripcionCM"].Value.ToString();
            CHKActivo.Checked = bool.Parse(DGVDatos.CurrentRow.Cells["Estado"].Value.ToString());
            btnEliminar.Enabled = false;
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                CategoriaModels Cliente = new CategoriaModels()
                {
                    Codigo = TxtCodigo.Text.ToString(),
                    DescripcionCM = TxtDescripcion.Text.ToString(),
                    FechadeCreacion = DateTime.Now,
                    Estado = CHKActivo.Checked
                };
                if (!string.IsNullOrEmpty(TxtCategoriaId.Text) || !string.IsNullOrWhiteSpace(TxtCategoriaId.Text))
                {
                    if (int.Parse(TxtCategoriaId.Text.ToString()) != 0)
                    {
                        Cliente.CategoriaId = int.Parse(TxtCategoriaId.Text.ToString());
                    }
                }
                ncategoria.AgregarCategoria(Cliente);
                LimpiarDatos();
                cargarDatos();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro que decea Eliminar", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                if (!string.IsNullOrEmpty(TxtCategoriaId.Text.ToString()) ||
                  !string.IsNullOrWhiteSpace(TxtCategoriaId.Text.ToString()))
                {
                    if (int.Parse(TxtCategoriaId.Text.ToString()) != 0)
                    {
                        var clienteId = int.Parse(TxtCategoriaId.Text.ToString());
                        ncategoria.EliminarCategoria(clienteId);
                        cargarDatos();
                        LimpiarDatos();
                    }
                }
            }

        }

        private void DGVDatos_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            TxtCategoriaId.Text = DGVDatos.CurrentRow.Cells["CategoriaId"].Value.ToString();
            TxtCodigo.Text = DGVDatos.CurrentRow.Cells["Codigo"].Value.ToString();
            TxtDescripcion.Text = DGVDatos.CurrentRow.Cells["DescripcionCM"].Value.ToString();
            CHKActivo.Checked = bool.Parse(DGVDatos.CurrentRow.Cells["Estado"].Value.ToString());
            btnEliminar.Enabled = true;
            btnEliminar.BackColor = Color.Red;
        }
    }
}
