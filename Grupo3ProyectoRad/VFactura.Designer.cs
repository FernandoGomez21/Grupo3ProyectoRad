
namespace Grupo3ProyectoRad
{
    partial class fmrfactura
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmrfactura));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.CHKEstado = new System.Windows.Forms.CheckBox();
            this.txtFacturaId = new System.Windows.Forms.TextBox();
            this.txtClienteId = new System.Windows.Forms.TextBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.txtPedidoId = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.dgvfactura = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.DTPFechaFactura = new System.Windows.Forms.DateTimePicker();
            this.BTNEliminar = new System.Windows.Forms.Button();
            this.BTNLimpiar = new System.Windows.Forms.Button();
            this.BTNGuardar = new System.Windows.Forms.Button();
            this.BTNBuscar = new System.Windows.Forms.Button();
            this.BTNBuscarCliente = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.TxtActivas = new System.Windows.Forms.CheckBox();
            this.DTPFechaPedido = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvfactura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "FacturaId";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "ClienteId";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cliente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "PedidoId";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(34, 322);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "FechaFactura";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(353, 248);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 25);
            this.label9.TabIndex = 8;
            this.label9.Text = "Total";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(30, 254);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 25);
            this.label10.TabIndex = 9;
            this.label10.Text = "SubTotal";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(299, 212);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(115, 25);
            this.label11.TabIndex = 10;
            this.label11.Text = "Descuento";
            // 
            // CHKEstado
            // 
            this.CHKEstado.AutoSize = true;
            this.CHKEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CHKEstado.Location = new System.Drawing.Point(78, 290);
            this.CHKEstado.Name = "CHKEstado";
            this.CHKEstado.Size = new System.Drawing.Size(101, 29);
            this.CHKEstado.TabIndex = 11;
            this.CHKEstado.Text = "Estado";
            this.CHKEstado.UseVisualStyleBackColor = true;
            this.CHKEstado.CheckedChanged += new System.EventHandler(this.cbEstado_CheckedChanged);
            // 
            // txtFacturaId
            // 
            this.txtFacturaId.Enabled = false;
            this.txtFacturaId.Location = new System.Drawing.Point(161, 94);
            this.txtFacturaId.Name = "txtFacturaId";
            this.txtFacturaId.Size = new System.Drawing.Size(126, 22);
            this.txtFacturaId.TabIndex = 12;
            // 
            // txtClienteId
            // 
            this.txtClienteId.Enabled = false;
            this.txtClienteId.Location = new System.Drawing.Point(161, 176);
            this.txtClienteId.Name = "txtClienteId";
            this.txtClienteId.Size = new System.Drawing.Size(126, 22);
            this.txtClienteId.TabIndex = 13;
            // 
            // txtCliente
            // 
            this.txtCliente.Enabled = false;
            this.txtCliente.Location = new System.Drawing.Point(161, 216);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(126, 22);
            this.txtCliente.TabIndex = 14;
            // 
            // txtPedidoId
            // 
            this.txtPedidoId.Location = new System.Drawing.Point(161, 135);
            this.txtPedidoId.Name = "txtPedidoId";
            this.txtPedidoId.Size = new System.Drawing.Size(126, 22);
            this.txtPedidoId.TabIndex = 15;
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(433, 248);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(126, 22);
            this.txtTotal.TabIndex = 19;
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Enabled = false;
            this.txtSubTotal.Location = new System.Drawing.Point(161, 254);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.Size = new System.Drawing.Size(132, 22);
            this.txtSubTotal.TabIndex = 20;
            // 
            // txtDescuento
            // 
            this.txtDescuento.Enabled = false;
            this.txtDescuento.Location = new System.Drawing.Point(433, 212);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(126, 22);
            this.txtDescuento.TabIndex = 21;
            // 
            // dgvfactura
            // 
            this.dgvfactura.AllowUserToOrderColumns = true;
            this.dgvfactura.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvfactura.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvfactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvfactura.Location = new System.Drawing.Point(12, 353);
            this.dgvfactura.Name = "dgvfactura";
            this.dgvfactura.RowHeadersWidth = 51;
            this.dgvfactura.RowTemplate.Height = 24;
            this.dgvfactura.Size = new System.Drawing.Size(984, 218);
            this.dgvfactura.TabIndex = 22;
            this.dgvfactura.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvfactura_RowHeaderMouseClick);
            this.dgvfactura.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvfactura_RowHeaderMouseDoubleClick);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(362, 54);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(197, 25);
            this.label12.TabIndex = 25;
            this.label12.Text = "Todas las Facturas";
            // 
            // DTPFechaFactura
            // 
            this.DTPFechaFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTPFechaFactura.Location = new System.Drawing.Point(218, 317);
            this.DTPFechaFactura.Name = "DTPFechaFactura";
            this.DTPFechaFactura.Size = new System.Drawing.Size(434, 30);
            this.DTPFechaFactura.TabIndex = 26;
            // 
            // BTNEliminar
            // 
            this.BTNEliminar.Enabled = false;
            this.BTNEliminar.Image = ((System.Drawing.Image)(resources.GetObject("BTNEliminar.Image")));
            this.BTNEliminar.Location = new System.Drawing.Point(842, 286);
            this.BTNEliminar.Name = "BTNEliminar";
            this.BTNEliminar.Size = new System.Drawing.Size(60, 61);
            this.BTNEliminar.TabIndex = 180;
            this.BTNEliminar.UseVisualStyleBackColor = true;
            this.BTNEliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // BTNLimpiar
            // 
            this.BTNLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BTNLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNLimpiar.Image = global::Grupo3ProyectoRad.Properties.Resources.cancelar;
            this.BTNLimpiar.Location = new System.Drawing.Point(908, 286);
            this.BTNLimpiar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTNLimpiar.Name = "BTNLimpiar";
            this.BTNLimpiar.Size = new System.Drawing.Size(64, 61);
            this.BTNLimpiar.TabIndex = 179;
            this.BTNLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTNLimpiar.UseVisualStyleBackColor = false;
            this.BTNLimpiar.Click += new System.EventHandler(this.BTNLimpiar_Click);
            // 
            // BTNGuardar
            // 
            this.BTNGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BTNGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNGuardar.Image = global::Grupo3ProyectoRad.Properties.Resources.guardar;
            this.BTNGuardar.Location = new System.Drawing.Point(767, 286);
            this.BTNGuardar.Name = "BTNGuardar";
            this.BTNGuardar.Size = new System.Drawing.Size(69, 61);
            this.BTNGuardar.TabIndex = 178;
            this.BTNGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTNGuardar.UseVisualStyleBackColor = false;
            this.BTNGuardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // BTNBuscar
            // 
            this.BTNBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNBuscar.Image = ((System.Drawing.Image)(resources.GetObject("BTNBuscar.Image")));
            this.BTNBuscar.Location = new System.Drawing.Point(306, 118);
            this.BTNBuscar.Name = "BTNBuscar";
            this.BTNBuscar.Size = new System.Drawing.Size(51, 40);
            this.BTNBuscar.TabIndex = 220;
            this.BTNBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTNBuscar.UseVisualStyleBackColor = true;
            this.BTNBuscar.Click += new System.EventHandler(this.BTNBuscar_Click);
            // 
            // BTNBuscarCliente
            // 
            this.BTNBuscarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNBuscarCliente.Image = global::Grupo3ProyectoRad.Properties.Resources.matricula;
            this.BTNBuscarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNBuscarCliente.Location = new System.Drawing.Point(377, 117);
            this.BTNBuscarCliente.Name = "BTNBuscarCliente";
            this.BTNBuscarCliente.Size = new System.Drawing.Size(199, 40);
            this.BTNBuscarCliente.TabIndex = 219;
            this.BTNBuscarCliente.Text = "Buscar Pedido";
            this.BTNBuscarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTNBuscarCliente.UseVisualStyleBackColor = true;
            this.BTNBuscarCliente.Click += new System.EventHandler(this.BTNBuscarCliente_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // TxtActivas
            // 
            this.TxtActivas.AutoSize = true;
            this.TxtActivas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtActivas.Location = new System.Drawing.Point(992, 322);
            this.TxtActivas.Name = "TxtActivas";
            this.TxtActivas.Size = new System.Drawing.Size(213, 29);
            this.TxtActivas.TabIndex = 221;
            this.TxtActivas.Text = "Todas Las Activas";
            this.TxtActivas.UseVisualStyleBackColor = true;
            this.TxtActivas.CheckedChanged += new System.EventHandler(this.TxtActivas_CheckedChanged);
            // 
            // DTPFechaPedido
            // 
            this.DTPFechaPedido.Enabled = false;
            this.DTPFechaPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTPFechaPedido.Location = new System.Drawing.Point(455, 171);
            this.DTPFechaPedido.Name = "DTPFechaPedido";
            this.DTPFechaPedido.Size = new System.Drawing.Size(381, 30);
            this.DTPFechaPedido.TabIndex = 222;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(310, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 25);
            this.label5.TabIndex = 223;
            this.label5.Text = "FechaPedido";
            // 
            // fmrfactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 583);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DTPFechaPedido);
            this.Controls.Add(this.TxtActivas);
            this.Controls.Add(this.BTNBuscar);
            this.Controls.Add(this.BTNBuscarCliente);
            this.Controls.Add(this.BTNEliminar);
            this.Controls.Add(this.BTNLimpiar);
            this.Controls.Add(this.BTNGuardar);
            this.Controls.Add(this.DTPFechaFactura);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dgvfactura);
            this.Controls.Add(this.txtDescuento);
            this.Controls.Add(this.txtSubTotal);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtPedidoId);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.txtClienteId);
            this.Controls.Add(this.txtFacturaId);
            this.Controls.Add(this.CHKEstado);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "fmrfactura";
            this.Text = "VFactura";
            this.Load += new System.EventHandler(this.fmrfactura_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.label11, 0);
            this.Controls.SetChildIndex(this.CHKEstado, 0);
            this.Controls.SetChildIndex(this.txtFacturaId, 0);
            this.Controls.SetChildIndex(this.txtClienteId, 0);
            this.Controls.SetChildIndex(this.txtCliente, 0);
            this.Controls.SetChildIndex(this.txtPedidoId, 0);
            this.Controls.SetChildIndex(this.txtTotal, 0);
            this.Controls.SetChildIndex(this.txtSubTotal, 0);
            this.Controls.SetChildIndex(this.txtDescuento, 0);
            this.Controls.SetChildIndex(this.dgvfactura, 0);
            this.Controls.SetChildIndex(this.label12, 0);
            this.Controls.SetChildIndex(this.DTPFechaFactura, 0);
            this.Controls.SetChildIndex(this.BTNGuardar, 0);
            this.Controls.SetChildIndex(this.BTNLimpiar, 0);
            this.Controls.SetChildIndex(this.BTNEliminar, 0);
            this.Controls.SetChildIndex(this.BTNBuscarCliente, 0);
            this.Controls.SetChildIndex(this.BTNBuscar, 0);
            this.Controls.SetChildIndex(this.TxtActivas, 0);
            this.Controls.SetChildIndex(this.DTPFechaPedido, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvfactura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox CHKEstado;
        private System.Windows.Forms.TextBox txtFacturaId;
        private System.Windows.Forms.TextBox txtClienteId;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.TextBox txtPedidoId;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.DataGridView dgvfactura;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker DTPFechaFactura;
        private System.Windows.Forms.Button BTNEliminar;
        private System.Windows.Forms.Button BTNLimpiar;
        private System.Windows.Forms.Button BTNGuardar;
        private System.Windows.Forms.Button BTNBuscar;
        private System.Windows.Forms.Button BTNBuscarCliente;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.CheckBox TxtActivas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker DTPFechaPedido;
    }
}