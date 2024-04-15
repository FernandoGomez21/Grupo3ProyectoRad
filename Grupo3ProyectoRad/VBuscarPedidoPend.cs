using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;

namespace Grupo3ProyectoRad
{
    public partial class VBuscarPedidoPend : Form
    {
        NPedido nPedido;

        public string PedidoId { get; set; }
        public string ClienteId { get; set; }
        public string FechaCreacion { get; set; }
        public string FechaPedido { get; set; }
        public bool Estado { get; set; }
        public decimal Total { get; set; }

        public VBuscarPedidoPend()
        {
            InitializeComponent();
            nPedido = new NPedido();
        }
        private void cargarDatos()
        {
            var productos = nPedido.PedidosActivos();
            var lista = from r in productos
                        select new
                        {
                            r.PedidoId,
                            r.ClienteId,
                            r.Cliente.Nombres,
                            r.Cliente.Apellidos,
                            r.FechaCreacion,
                            r.FechaPedido,
                            r.Estado,
                            r.Total,
                        };
            dgvProductos.DataSource = lista.ToList();

        }

        private void dgvProductos_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            PedidoId = dgvProductos.CurrentRow.Cells["PedidoId"].Value.ToString();
            ClienteId = dgvProductos.CurrentRow.Cells["ClienteId"].Value.ToString();
            FechaCreacion = dgvProductos.CurrentRow.Cells["FechaCreacion"].Value.ToString();
            FechaPedido = dgvProductos.CurrentRow.Cells["FechaPedido"].Value.ToString();
            Estado = bool.Parse(dgvProductos.CurrentRow.Cells["Estado"].Value.ToString());
            Total = decimal.Parse(dgvProductos.CurrentRow.Cells["Total"].Value.ToString());
            this.Visible = false;
        }

        private void VBuscarPedido_Load(object sender, EventArgs e)
        {
            cargarDatos();
        }
    }
}
