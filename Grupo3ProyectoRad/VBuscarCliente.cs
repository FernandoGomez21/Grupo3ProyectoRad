using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Negocio;

namespace Grupo3ProyectoRad
{
    public partial class VBuscarCliente : Form
    {
        NClienteModels nCliente;

        public string ClienteId { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Descripcion { get; set; }
        public string Dias { get; set; }
        public string Porcentaje { get; set; }

        public VBuscarCliente()
        {
            InitializeComponent();
            nCliente = new NClienteModels();
        }
        private void cargarDatos()
        {
            var productos = nCliente.ClientesActivos();
            var lista = from r in productos
                        select new
                        {
                            r.ClienteId,
                            r.Estado,
                            r.Nombres,
                            r.Apellidos,
                            r.CondicionPago.Dias,
                            r.CondicionPago.DescripcionCP,
                            r.GrupoDescuento.Porcentaje,
                            
                        };
            dgvProductos.DataSource = lista.ToList();
            
        }
        private void VBuscarCliente_Load(object sender, EventArgs e)
        {
            cargarDatos();
        }
        private void dgvProductos_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ClienteId = dgvProductos.CurrentRow.Cells["ClienteId"].Value.ToString();
            Nombres = dgvProductos.CurrentRow.Cells["Nombres"].Value.ToString();
            Apellidos = dgvProductos.CurrentRow.Cells["Apellidos"].Value.ToString();
            Descripcion = dgvProductos.CurrentRow.Cells["DescripcionCP"].Value.ToString();
            Dias = dgvProductos.CurrentRow.Cells["Dias"].Value.ToString();
            Porcentaje = dgvProductos.CurrentRow.Cells["Porcentaje"].Value.ToString();
            this.Visible = false;
        }
    }
}
