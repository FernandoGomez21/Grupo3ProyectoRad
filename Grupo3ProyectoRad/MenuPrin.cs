﻿using System;
using System.Windows.Forms;
using Grupo3PrimerFase;

namespace Grupo3ProyectoRad
{
    public partial class MenuPrin : Form
    {
        public MenuPrin()
        {
            InitializeComponent();
        }
        private void grupoDescuentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GrupoDescuentoV grupoDescuento = new GrupoDescuentoV();
            grupoDescuento.Show();
            this.Hide();
        }

        private void unidadDeMedidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VUnidadMedida unidadMedida = new VUnidadMedida();
            unidadMedida.Show();
            this.Hide();
        }
        private void pedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PedidoV descuento = new PedidoV();
            descuento.Show();
            this.Hide();
        }

        private void pedidosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            VPedidos pedidos = new VPedidos();
            pedidos.Show();
            this.Hide();
        }
        private void categoriaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CategoriaV categoria = new CategoriaV();
            categoria.Show();
            this.Hide();
        }
        private void condicionDePagoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            VCondicionPago condicionPago = new VCondicionPago();
            condicionPago.Show();
            this.Hide();
        }

        private void menuPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuPrin menuPrin = new MenuPrin();
            menuPrin.Show();
            this.Hide();
        }
        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FmrClientes menuPrin = new FmrClientes();
            menuPrin.Show();
            this.Hide();
        }

        private void productosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fmproductos menuPrin = new fmproductos();
            menuPrin.Show();
            this.Hide();
        }
        private void pedidosToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            VPedidos pedidos = new VPedidos();
            pedidos.Show();
            this.Hide();
        }

        private void pedidoDetalleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PedidoV descuento = new PedidoV();
            descuento.Show();
            this.Hide();
        }
    }
}
