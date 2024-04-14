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
    public partial class VBuscarPedido : Form
    {
        NPedido nPedido;

        public string PedidoId { get; set; }
        public string ClienteId { get; set; }
        public string FechaCreacion { get; set; }
        public string FechaPedido { get; set; }
        public string Estado { get; set; }

        public VBuscarPedido()
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
                            r.FechaCreacion,
                            r.FechaPedido,
                            r.Estado,
                        };
            dgvProductos.DataSource = lista.ToList();

        }
        private void VBuscarPedido_Load(object sender, EventArgs e)
        {
            cargarDatos();
        }

        private void dgvProductos_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            PedidoId = dgvProductos.CurrentRow.Cells["PedidoId"].Value.ToString();
            ClienteId = dgvProductos.CurrentRow.Cells["ClienteId"].Value.ToString();
            FechaCreacion = dgvProductos.CurrentRow.Cells["FechaCreacion"].Value.ToString();
            FechaPedido = dgvProductos.CurrentRow.Cells["FechaPedido"].Value.ToString();
            Estado = dgvProductos.CurrentRow.Cells["Estado"].Value.ToString();
           
            this.Visible = false;
        }
    }
}
