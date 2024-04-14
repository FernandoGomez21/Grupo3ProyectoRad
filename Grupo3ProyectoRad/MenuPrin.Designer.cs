namespace Grupo3ProyectoRad
{
    partial class MenuPrin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.menuPrincipalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.grupoDescuentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.condicionDePagoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.unidadDeMedidaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.facturasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidosToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidoDetalleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuPrincipalToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.productosToolStripMenuItem,
            this.facturasToolStripMenuItem});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(800, 28);
            this.Menu.TabIndex = 4;
            this.Menu.Text = "Menu";
            // 
            // menuPrincipalToolStripMenuItem
            // 
            this.menuPrincipalToolStripMenuItem.Name = "menuPrincipalToolStripMenuItem";
            this.menuPrincipalToolStripMenuItem.Size = new System.Drawing.Size(121, 24);
            this.menuPrincipalToolStripMenuItem.Text = "Menu Principal";
            this.menuPrincipalToolStripMenuItem.Click += new System.EventHandler(this.menuPrincipalToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem1,
            this.grupoDescuentoToolStripMenuItem,
            this.condicionDePagoToolStripMenuItem1});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // clientesToolStripMenuItem1
            // 
            this.clientesToolStripMenuItem1.Name = "clientesToolStripMenuItem1";
            this.clientesToolStripMenuItem1.Size = new System.Drawing.Size(217, 26);
            this.clientesToolStripMenuItem1.Text = "Clientes";
            this.clientesToolStripMenuItem1.Click += new System.EventHandler(this.clientesToolStripMenuItem1_Click);
            // 
            // grupoDescuentoToolStripMenuItem
            // 
            this.grupoDescuentoToolStripMenuItem.Name = "grupoDescuentoToolStripMenuItem";
            this.grupoDescuentoToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.grupoDescuentoToolStripMenuItem.Text = "GrupoDescuento";
            this.grupoDescuentoToolStripMenuItem.Click += new System.EventHandler(this.grupoDescuentoToolStripMenuItem_Click);
            // 
            // condicionDePagoToolStripMenuItem1
            // 
            this.condicionDePagoToolStripMenuItem1.Name = "condicionDePagoToolStripMenuItem1";
            this.condicionDePagoToolStripMenuItem1.Size = new System.Drawing.Size(217, 26);
            this.condicionDePagoToolStripMenuItem1.Text = "Condicion de Pago";
            this.condicionDePagoToolStripMenuItem1.Click += new System.EventHandler(this.condicionDePagoToolStripMenuItem1_Click);
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productosToolStripMenuItem1,
            this.unidadDeMedidaToolStripMenuItem,
            this.categoriaToolStripMenuItem1});
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.productosToolStripMenuItem.Text = "Productos";
            // 
            // productosToolStripMenuItem1
            // 
            this.productosToolStripMenuItem1.Name = "productosToolStripMenuItem1";
            this.productosToolStripMenuItem1.Size = new System.Drawing.Size(216, 26);
            this.productosToolStripMenuItem1.Text = "Productos";
            this.productosToolStripMenuItem1.Click += new System.EventHandler(this.productosToolStripMenuItem1_Click);
            // 
            // unidadDeMedidaToolStripMenuItem
            // 
            this.unidadDeMedidaToolStripMenuItem.Name = "unidadDeMedidaToolStripMenuItem";
            this.unidadDeMedidaToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.unidadDeMedidaToolStripMenuItem.Text = "Unidad de Medida";
            this.unidadDeMedidaToolStripMenuItem.Click += new System.EventHandler(this.unidadDeMedidaToolStripMenuItem_Click);
            // 
            // categoriaToolStripMenuItem1
            // 
            this.categoriaToolStripMenuItem1.Name = "categoriaToolStripMenuItem1";
            this.categoriaToolStripMenuItem1.Size = new System.Drawing.Size(216, 26);
            this.categoriaToolStripMenuItem1.Text = "Categoria";
            this.categoriaToolStripMenuItem1.Click += new System.EventHandler(this.categoriaToolStripMenuItem1_Click);
            // 
            // facturasToolStripMenuItem
            // 
            this.facturasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pedidosToolStripMenuItem2,
            this.pedidoDetalleToolStripMenuItem});
            this.facturasToolStripMenuItem.Name = "facturasToolStripMenuItem";
            this.facturasToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.facturasToolStripMenuItem.Text = "Facturar";
            // 
            // pedidosToolStripMenuItem2
            // 
            this.pedidosToolStripMenuItem2.Name = "pedidosToolStripMenuItem2";
            this.pedidosToolStripMenuItem2.Size = new System.Drawing.Size(224, 26);
            this.pedidosToolStripMenuItem2.Text = "Pedidos";
            this.pedidosToolStripMenuItem2.Click += new System.EventHandler(this.pedidosToolStripMenuItem2_Click);
            // 
            // pedidoDetalleToolStripMenuItem
            // 
            this.pedidoDetalleToolStripMenuItem.Name = "pedidoDetalleToolStripMenuItem";
            this.pedidoDetalleToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.pedidoDetalleToolStripMenuItem.Text = "PedidoDetalle";
            this.pedidoDetalleToolStripMenuItem.Click += new System.EventHandler(this.pedidoDetalleToolStripMenuItem_Click);
            // 
            // pedidosToolStripMenuItem1
            // 
            this.pedidosToolStripMenuItem1.Name = "pedidosToolStripMenuItem1";
            this.pedidosToolStripMenuItem1.Size = new System.Drawing.Size(186, 26);
            this.pedidosToolStripMenuItem1.Text = "Pedidos";
            this.pedidosToolStripMenuItem1.Click += new System.EventHandler(this.pedidosToolStripMenuItem1_Click);
            // 
            // pedidosToolStripMenuItem
            // 
            this.pedidosToolStripMenuItem.Name = "pedidosToolStripMenuItem";
            this.pedidosToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.pedidosToolStripMenuItem.Text = "PedidoDetalle";
            this.pedidosToolStripMenuItem.Click += new System.EventHandler(this.pedidosToolStripMenuItem_Click);
            // 
            // MenuPrin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Menu);
            this.Name = "MenuPrin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private new System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grupoDescuentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unidadDeMedidaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pedidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pedidosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem categoriaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem condicionDePagoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem menuPrincipalToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem facturasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pedidosToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem pedidoDetalleToolStripMenuItem;
    }
}

