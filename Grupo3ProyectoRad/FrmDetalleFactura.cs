using Datos;
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
    public partial class FrmDetalleFactura : MenuPrin
    {

        string fechain, fechafin;

        private NFacturaDetalle nFacturaDetalle;
        private NFactura nFactura;
        public FrmDetalleFactura()
        {
            InitializeComponent();
            nFacturaDetalle = new NFacturaDetalle();
             nFactura = new NFactura();
    }

        private void setvalue()
        {
            fechain = DtpIn.Text;
            fechafin = DtpFin.Text;
        }
        private void CargarDatos()
        {
            var clientes = nFactura.FacturaInactivas().Select(c => new { c.FacturaId, c.ClienteId, c.Cliente.Nombres, c.Cliente.Apellidos, c.Pedido.PedidoId, c.FechaFactura, c.Descuento, c.SubTotal, c.Total });
            dgvproducto.DataSource = clientes.ToList();

        }
        private void FrmDetalleFactura_Load(object sender, EventArgs e)
        {
            CargarDatos();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dgvproducto_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Factura factura = new Factura()
            {
                PedidoId = int.Parse(dgvproducto.CurrentRow.Cells["PedidoId"].Value.ToString()),
                ClienteId = int.Parse(dgvproducto.CurrentRow.Cells["ClienteId"].Value.ToString()),
                FechaCreacion = DateTime.Now,
                FechaFactura = DateTime.Parse(dgvproducto.CurrentRow.Cells["FechaFactura"].Value.ToString()),
                Estado = true,
                Total = decimal.Parse(dgvproducto.CurrentRow.Cells["Total"].Value.ToString()),
                SubTotal = decimal.Parse(dgvproducto.CurrentRow.Cells["SubTotal"].Value.ToString()),
                Descuento = decimal.Parse(dgvproducto.CurrentRow.Cells["Descuento"].Value.ToString()),
            };
            if (!string.IsNullOrEmpty(dgvproducto.CurrentRow.Cells["FacturaId"].Value.ToString()) || !string.IsNullOrWhiteSpace(dgvproducto.CurrentRow.Cells["FacturaId"].Value.ToString()))
            {
                if (int.Parse(dgvproducto.CurrentRow.Cells["FacturaId"].Value.ToString()) != 0)
                {
                    factura.FacturaId = int.Parse(dgvproducto.CurrentRow.Cells["FacturaId"].Value.ToString());
                }
            }
            nFactura.AgregarFactura(factura);
            CargarDatos();
            MessageBox.Show("Factura Realizada");
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
          
            DateTime fechaInicio = DtpIn.Value;
            DateTime fechaFin = DtpFin.Value;


            List<FacturaDetalle> detallesFactura = nFacturaDetalle.ObtenerTodosLosDetalles()
                .Where(fd => fd.FechaCreacion >= fechaInicio && fd.FechaCreacion <= fechaFin)
                .ToList();
            dgvproducto.DataSource = detallesFactura;

            decimal sumaTotal = detallesFactura.Sum(fd => fd.Total);
            TxtSumaTotal.Text = sumaTotal.ToString("C");
        }
    }

}
