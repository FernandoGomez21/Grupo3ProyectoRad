using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Datos.BaseDatos.Models;
using Negocio;

namespace Grupo3ProyectoRad
{
    public partial class vBuscarProducto : Form
    {
        NProductoModels nProducto;

        public string ProductosId { get; set; }
        public string ProductoDetalle { get; set; }
        public string UnidadMedidaId { get; set; }
        public string DescripcionUM { get; set; }
        public string CategoriaId { get; set; }
        public string DescripcionCM { get; set; }
        public string PrecioCompra { get; set; }

        public vBuscarProducto()
        {
            InitializeComponent();
            nProducto = new NProductoModels();

        }

        private void cargarDatos()
        {
            var productos = nProducto.TodoslosProductos();
            var lista = from r in productos
                        select new
                        {
                            r.ProductosId,
                            r.ProductoDetalle,
                            r.UnidadMedidaId,
                            r.UnidadMedida.DescripcionUM,
                            r.CategoriaId,
                            r.CategoriaModels.DescripcionCM,
                            r.PrecioCompra,

                        };
            dgvProductos.DataSource = lista.ToList();

        }
        private void vBuscarProducto_Load(object sender, EventArgs e)
        {
            cargarDatos();
        }
        private void eliminar()
        {
            this.Visible = false;
        }
        private void dgvProductos_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ProductosId = dgvProductos.CurrentRow.Cells["ProductosId"].Value.ToString();
            ProductoDetalle = dgvProductos.CurrentRow.Cells["ProductoDetalle"].Value.ToString();
            UnidadMedidaId = dgvProductos.CurrentRow.Cells["UnidadMedidaId"].Value.ToString();
            DescripcionUM = dgvProductos.CurrentRow.Cells["DescripcionUM"].Value.ToString();
            CategoriaId = dgvProductos.CurrentRow.Cells["CategoriaId"].Value.ToString();
            DescripcionCM = dgvProductos.CurrentRow.Cells["DescripcionCM"].Value.ToString();
            PrecioCompra = dgvProductos.CurrentRow.Cells["PrecioCompra"].Value.ToString();
            eliminar();
        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
