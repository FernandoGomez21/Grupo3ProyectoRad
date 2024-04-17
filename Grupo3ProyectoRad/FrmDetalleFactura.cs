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
    public partial class FrmDetalleFactura : Form
    {

        string fechain, fechafin;

        private NFacturaDetalle nFacturaDetalle; 

        public FrmDetalleFactura()
        {
            InitializeComponent();
            nFacturaDetalle = new NFacturaDetalle();
        }

        private void setvalue()
        {
            fechain = DtpIn.Text;
            fechafin = DtpFin.Text;
        }

        private void FrmDetalleFactura_Load(object sender, EventArgs e)
        {

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
