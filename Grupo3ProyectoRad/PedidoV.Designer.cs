namespace Grupo3ProyectoRad
{
    partial class PedidoV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PedidoV));
            this.BTNLimpiar = new System.Windows.Forms.Button();
            this.TxtCategoria = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.TxtCategoriaId = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.TxtUniDescripcion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtPedidoDetalleId = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.TxtUnidadId = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtProductoId = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.TxtPrecioUnitario = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.CHKRealizado = new System.Windows.Forms.CheckBox();
            this.TxtSubTotal = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvdetalle = new System.Windows.Forms.DataGridView();
            this.ProductoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalLinea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DTPFechaPedido = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.TxtProductoDetalle = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.BTNLimpiarTodo = new System.Windows.Forms.Button();
            this.BTNBuscarPedido = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.BTNBuscarCliente = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtApellido = new System.Windows.Forms.TextBox();
            this.TxtCondicionPago = new System.Windows.Forms.TextBox();
            this.TxtDias = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BTNLimpiarClientes = new System.Windows.Forms.Button();
            this.BTNBuscarClientes = new System.Windows.Forms.Button();
            this.BTNBuscarPedidos = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.TxtPedidoId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtClienteId = new System.Windows.Forms.TextBox();
            this.TxtBuscarClientes = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.TxtBuscarPedidos = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.LBLFechaCreacion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // BTNLimpiar
            // 
            this.BTNLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BTNLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNLimpiar.Location = new System.Drawing.Point(909, 331);
            this.BTNLimpiar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTNLimpiar.Name = "BTNLimpiar";
            this.BTNLimpiar.Size = new System.Drawing.Size(229, 38);
            this.BTNLimpiar.TabIndex = 179;
            this.BTNLimpiar.Text = "Limpiar Productos";
            this.BTNLimpiar.UseVisualStyleBackColor = false;
            this.BTNLimpiar.Click += new System.EventHandler(this.BTNLimpiar_Click);
            // 
            // TxtCategoria
            // 
            this.TxtCategoria.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TxtCategoria.Enabled = false;
            this.TxtCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCategoria.Location = new System.Drawing.Point(774, 388);
            this.TxtCategoria.Name = "TxtCategoria";
            this.TxtCategoria.Size = new System.Drawing.Size(122, 27);
            this.TxtCategoria.TabIndex = 178;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(658, 391);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(96, 20);
            this.label18.TabIndex = 177;
            this.label18.Text = "Categoria:";
            // 
            // TxtCategoriaId
            // 
            this.TxtCategoriaId.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TxtCategoriaId.Enabled = false;
            this.TxtCategoriaId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCategoriaId.Location = new System.Drawing.Point(774, 353);
            this.TxtCategoriaId.Name = "TxtCategoriaId";
            this.TxtCategoriaId.Size = new System.Drawing.Size(122, 27);
            this.TxtCategoriaId.TabIndex = 176;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(637, 356);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(117, 20);
            this.label17.TabIndex = 175;
            this.label17.Text = "Categoria Id:";
            // 
            // TxtUniDescripcion
            // 
            this.TxtUniDescripcion.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TxtUniDescripcion.Enabled = false;
            this.TxtUniDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUniDescripcion.Location = new System.Drawing.Point(499, 390);
            this.TxtUniDescripcion.Name = "TxtUniDescripcion";
            this.TxtUniDescripcion.Size = new System.Drawing.Size(131, 27);
            this.TxtUniDescripcion.TabIndex = 174;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(343, 393);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 20);
            this.label5.TabIndex = 173;
            this.label5.Text = "Unidad Medida:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(314, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 172;
            this.label4.Text = "Nombre:";
            // 
            // TxtPedidoDetalleId
            // 
            this.TxtPedidoDetalleId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.TxtPedidoDetalleId.Enabled = false;
            this.TxtPedidoDetalleId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPedidoDetalleId.Location = new System.Drawing.Point(213, 226);
            this.TxtPedidoDetalleId.Name = "TxtPedidoDetalleId";
            this.TxtPedidoDetalleId.Size = new System.Drawing.Size(122, 27);
            this.TxtPedidoDetalleId.TabIndex = 168;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(30, 229);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(159, 20);
            this.label14.TabIndex = 167;
            this.label14.Text = "Pedido Detalle Id:";
            // 
            // TxtUnidadId
            // 
            this.TxtUnidadId.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TxtUnidadId.Enabled = false;
            this.TxtUnidadId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUnidadId.Location = new System.Drawing.Point(499, 351);
            this.TxtUnidadId.Name = "TxtUnidadId";
            this.TxtUnidadId.Size = new System.Drawing.Size(131, 27);
            this.TxtUnidadId.TabIndex = 166;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(368, 356);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(114, 20);
            this.label12.TabIndex = 165;
            this.label12.Text = "Unidades Id:";
            // 
            // txtProductoId
            // 
            this.txtProductoId.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtProductoId.Enabled = false;
            this.txtProductoId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductoId.Location = new System.Drawing.Point(202, 316);
            this.txtProductoId.Name = "txtProductoId";
            this.txtProductoId.Size = new System.Drawing.Size(122, 27);
            this.txtProductoId.TabIndex = 164;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(202, 389);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(122, 27);
            this.txtCantidad.TabIndex = 163;
            // 
            // TxtPrecioUnitario
            // 
            this.TxtPrecioUnitario.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TxtPrecioUnitario.Enabled = false;
            this.TxtPrecioUnitario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPrecioUnitario.Location = new System.Drawing.Point(202, 355);
            this.TxtPrecioUnitario.Name = "TxtPrecioUnitario";
            this.TxtPrecioUnitario.Size = new System.Drawing.Size(122, 27);
            this.TxtPrecioUnitario.TabIndex = 162;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(80, 356);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 20);
            this.label7.TabIndex = 161;
            this.label7.Text = "Precio Unit:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(96, 394);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 20);
            this.label6.TabIndex = 160;
            this.label6.Text = "Cantidad:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(78, 315);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 20);
            this.label8.TabIndex = 159;
            this.label8.Text = "Producto Id:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(47, 275);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(170, 20);
            this.label16.TabIndex = 155;
            this.label16.Text = "Buscar productos: ";
            // 
            // CHKRealizado
            // 
            this.CHKRealizado.AutoSize = true;
            this.CHKRealizado.Enabled = false;
            this.CHKRealizado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CHKRealizado.Location = new System.Drawing.Point(625, 274);
            this.CHKRealizado.Name = "CHKRealizado";
            this.CHKRealizado.Size = new System.Drawing.Size(129, 29);
            this.CHKRealizado.TabIndex = 154;
            this.CHKRealizado.Text = "Realizado";
            this.CHKRealizado.UseVisualStyleBackColor = true;
            // 
            // TxtSubTotal
            // 
            this.TxtSubTotal.Enabled = false;
            this.TxtSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSubTotal.Location = new System.Drawing.Point(450, 745);
            this.TxtSubTotal.Name = "TxtSubTotal";
            this.TxtSubTotal.Size = new System.Drawing.Size(122, 27);
            this.TxtSubTotal.TabIndex = 153;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(338, 748);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(89, 20);
            this.label15.TabIndex = 152;
            this.label15.Text = "SubTotal:";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(749, 745);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(122, 27);
            this.txtTotal.TabIndex = 146;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(618, 748);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(120, 20);
            this.label11.TabIndex = 145;
            this.label11.Text = "Total Pedido:";
            // 
            // txtDescuento
            // 
            this.txtDescuento.Enabled = false;
            this.txtDescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescuento.Location = new System.Drawing.Point(202, 745);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(122, 27);
            this.txtDescuento.TabIndex = 143;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(85, 748);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 20);
            this.label10.TabIndex = 142;
            this.label10.Text = "Descuento: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1035, 167);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(170, 20);
            this.label9.TabIndex = 141;
            this.label9.Text = "Condicion de pago:";
            // 
            // dgvdetalle
            // 
            this.dgvdetalle.AllowUserToAddRows = false;
            this.dgvdetalle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvdetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductoId,
            this.Descripcion,
            this.Precio,
            this.Cantidad,
            this.Descuento,
            this.SubTotal,
            this.TotalLinea});
            this.dgvdetalle.Location = new System.Drawing.Point(24, 420);
            this.dgvdetalle.Name = "dgvdetalle";
            this.dgvdetalle.RowHeadersWidth = 51;
            this.dgvdetalle.RowTemplate.Height = 24;
            this.dgvdetalle.Size = new System.Drawing.Size(1114, 299);
            this.dgvdetalle.TabIndex = 140;
            // 
            // ProductoId
            // 
            this.ProductoId.HeaderText = "ProductoId";
            this.ProductoId.MinimumWidth = 6;
            this.ProductoId.Name = "ProductoId";
            this.ProductoId.Width = 90;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.MinimumWidth = 6;
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Width = 150;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.MinimumWidth = 6;
            this.Precio.Name = "Precio";
            this.Precio.Width = 90;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Width = 90;
            // 
            // Descuento
            // 
            this.Descuento.HeaderText = "Descuento";
            this.Descuento.MinimumWidth = 6;
            this.Descuento.Name = "Descuento";
            this.Descuento.Width = 90;
            // 
            // SubTotal
            // 
            this.SubTotal.HeaderText = "SubTotal";
            this.SubTotal.MinimumWidth = 6;
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.Width = 90;
            // 
            // TotalLinea
            // 
            this.TotalLinea.HeaderText = "TotalLinea";
            this.TotalLinea.MinimumWidth = 6;
            this.TotalLinea.Name = "TotalLinea";
            this.TotalLinea.Width = 90;
            // 
            // DTPFechaPedido
            // 
            this.DTPFechaPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTPFechaPedido.Location = new System.Drawing.Point(213, 191);
            this.DTPFechaPedido.Name = "DTPFechaPedido";
            this.DTPFechaPedido.Size = new System.Drawing.Size(404, 27);
            this.DTPFechaPedido.TabIndex = 139;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 20);
            this.label2.TabIndex = 138;
            this.label2.Text = "Fecha Pedido:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // TxtProductoDetalle
            // 
            this.TxtProductoDetalle.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TxtProductoDetalle.Enabled = false;
            this.TxtProductoDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtProductoDetalle.Location = new System.Drawing.Point(499, 318);
            this.TxtProductoDetalle.Name = "TxtProductoDetalle";
            this.TxtProductoDetalle.Size = new System.Drawing.Size(212, 27);
            this.TxtProductoDetalle.TabIndex = 181;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(392, 321);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(90, 20);
            this.label19.TabIndex = 180;
            this.label19.Text = "Producto:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(569, 163);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(82, 20);
            this.label20.TabIndex = 183;
            this.label20.Text = "Apellido:";
            // 
            // BTNLimpiarTodo
            // 
            this.BTNLimpiarTodo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BTNLimpiarTodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNLimpiarTodo.Location = new System.Drawing.Point(909, 373);
            this.BTNLimpiarTodo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTNLimpiarTodo.Name = "BTNLimpiarTodo";
            this.BTNLimpiarTodo.Size = new System.Drawing.Size(229, 38);
            this.BTNLimpiarTodo.TabIndex = 185;
            this.BTNLimpiarTodo.Text = "Limpiar Todo";
            this.BTNLimpiarTodo.UseVisualStyleBackColor = false;
            this.BTNLimpiarTodo.Click += new System.EventHandler(this.BTNLimpiarTodo_Click);
            // 
            // BTNBuscarPedido
            // 
            this.BTNBuscarPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNBuscarPedido.Image = global::Grupo3ProyectoRad.Properties.Resources.matricula;
            this.BTNBuscarPedido.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNBuscarPedido.Location = new System.Drawing.Point(374, 34);
            this.BTNBuscarPedido.Name = "BTNBuscarPedido";
            this.BTNBuscarPedido.Size = new System.Drawing.Size(198, 40);
            this.BTNBuscarPedido.TabIndex = 186;
            this.BTNBuscarPedido.Text = "Buscar Pedido";
            this.BTNBuscarPedido.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTNBuscarPedido.UseVisualStyleBackColor = true;
            this.BTNBuscarPedido.Click += new System.EventHandler(this.BTNBuscarPedido_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(372, 270);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(147, 40);
            this.btnAgregar.TabIndex = 158;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(237, 270);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(129, 40);
            this.btnBuscar.TabIndex = 157;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // BTNBuscarCliente
            // 
            this.BTNBuscarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNBuscarCliente.Image = ((System.Drawing.Image)(resources.GetObject("BTNBuscarCliente.Image")));
            this.BTNBuscarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNBuscarCliente.Location = new System.Drawing.Point(372, 101);
            this.BTNBuscarCliente.Name = "BTNBuscarCliente";
            this.BTNBuscarCliente.Size = new System.Drawing.Size(198, 40);
            this.BTNBuscarCliente.TabIndex = 151;
            this.BTNBuscarCliente.Text = "Buscar Cliente";
            this.BTNBuscarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTNBuscarCliente.UseVisualStyleBackColor = true;
            this.BTNBuscarCliente.Click += new System.EventHandler(this.BTNBuscarCliente_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.Location = new System.Drawing.Point(539, 270);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(58, 40);
            this.btnEliminar.TabIndex = 148;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirmar.Image")));
            this.btnConfirmar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirmar.Location = new System.Drawing.Point(909, 727);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(132, 43);
            this.btnConfirmar.TabIndex = 147;
            this.btnConfirmar.Text = "Guardar";
            this.btnConfirmar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // TxtNombre
            // 
            this.TxtNombre.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TxtNombre.Enabled = false;
            this.TxtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre.Location = new System.Drawing.Point(412, 156);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(131, 27);
            this.TxtNombre.TabIndex = 188;
            // 
            // TxtApellido
            // 
            this.TxtApellido.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TxtApellido.Enabled = false;
            this.TxtApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtApellido.Location = new System.Drawing.Point(662, 160);
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.Size = new System.Drawing.Size(131, 27);
            this.TxtApellido.TabIndex = 189;
            // 
            // TxtCondicionPago
            // 
            this.TxtCondicionPago.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TxtCondicionPago.Enabled = false;
            this.TxtCondicionPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCondicionPago.Location = new System.Drawing.Point(1220, 167);
            this.TxtCondicionPago.Name = "TxtCondicionPago";
            this.TxtCondicionPago.Size = new System.Drawing.Size(131, 27);
            this.TxtCondicionPago.TabIndex = 190;
            // 
            // TxtDias
            // 
            this.TxtDias.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TxtDias.Enabled = false;
            this.TxtDias.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDias.Location = new System.Drawing.Point(884, 163);
            this.TxtDias.Name = "TxtDias";
            this.TxtDias.Size = new System.Drawing.Size(131, 27);
            this.TxtDias.TabIndex = 192;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(815, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 191;
            this.label1.Text = "Dias:";
            // 
            // BTNLimpiarClientes
            // 
            this.BTNLimpiarClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BTNLimpiarClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNLimpiarClientes.Location = new System.Drawing.Point(909, 287);
            this.BTNLimpiarClientes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTNLimpiarClientes.Name = "BTNLimpiarClientes";
            this.BTNLimpiarClientes.Size = new System.Drawing.Size(229, 38);
            this.BTNLimpiarClientes.TabIndex = 193;
            this.BTNLimpiarClientes.Text = "Limpiar Clientes";
            this.BTNLimpiarClientes.UseVisualStyleBackColor = false;
            this.BTNLimpiarClientes.Click += new System.EventHandler(this.button1_Click);
            // 
            // BTNBuscarClientes
            // 
            this.BTNBuscarClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNBuscarClientes.Image = ((System.Drawing.Image)(resources.GetObject("BTNBuscarClientes.Image")));
            this.BTNBuscarClientes.Location = new System.Drawing.Point(309, 104);
            this.BTNBuscarClientes.Name = "BTNBuscarClientes";
            this.BTNBuscarClientes.Size = new System.Drawing.Size(51, 40);
            this.BTNBuscarClientes.TabIndex = 219;
            this.BTNBuscarClientes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTNBuscarClientes.UseVisualStyleBackColor = true;
            this.BTNBuscarClientes.Click += new System.EventHandler(this.button2_Click);
            // 
            // BTNBuscarPedidos
            // 
            this.BTNBuscarPedidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNBuscarPedidos.Image = ((System.Drawing.Image)(resources.GetObject("BTNBuscarPedidos.Image")));
            this.BTNBuscarPedidos.Location = new System.Drawing.Point(311, 34);
            this.BTNBuscarPedidos.Name = "BTNBuscarPedidos";
            this.BTNBuscarPedidos.Size = new System.Drawing.Size(51, 40);
            this.BTNBuscarPedidos.TabIndex = 220;
            this.BTNBuscarPedidos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTNBuscarPedidos.UseVisualStyleBackColor = true;
            this.BTNBuscarPedidos.Click += new System.EventHandler(this.BTNBuscarPedidos_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(46, 75);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(93, 20);
            this.label13.TabIndex = 149;
            this.label13.Text = "Pedido Id:";
            // 
            // TxtPedidoId
            // 
            this.TxtPedidoId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.TxtPedidoId.Enabled = false;
            this.TxtPedidoId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPedidoId.Location = new System.Drawing.Point(156, 75);
            this.TxtPedidoId.Name = "TxtPedidoId";
            this.TxtPedidoId.Size = new System.Drawing.Size(122, 27);
            this.TxtPedidoId.TabIndex = 150;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 169;
            this.label3.Text = "ClienteId:";
            // 
            // TxtClienteId
            // 
            this.TxtClienteId.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TxtClienteId.Enabled = false;
            this.TxtClienteId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtClienteId.Location = new System.Drawing.Point(156, 156);
            this.TxtClienteId.Name = "TxtClienteId";
            this.TxtClienteId.Size = new System.Drawing.Size(131, 27);
            this.TxtClienteId.TabIndex = 187;
            // 
            // TxtBuscarClientes
            // 
            this.TxtBuscarClientes.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TxtBuscarClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBuscarClientes.Location = new System.Drawing.Point(156, 118);
            this.TxtBuscarClientes.Name = "TxtBuscarClientes";
            this.TxtBuscarClientes.Size = new System.Drawing.Size(131, 27);
            this.TxtBuscarClientes.TabIndex = 224;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(12, 121);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(140, 20);
            this.label21.TabIndex = 223;
            this.label21.Text = "Buscar Cliente:";
            // 
            // TxtBuscarPedidos
            // 
            this.TxtBuscarPedidos.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.TxtBuscarPedidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBuscarPedidos.Location = new System.Drawing.Point(156, 42);
            this.TxtBuscarPedidos.Name = "TxtBuscarPedidos";
            this.TxtBuscarPedidos.Size = new System.Drawing.Size(122, 27);
            this.TxtBuscarPedidos.TabIndex = 222;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(12, 42);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(138, 20);
            this.label22.TabIndex = 221;
            this.label22.Text = "Buscar Pedido:";
            // 
            // LBLFechaCreacion
            // 
            this.LBLFechaCreacion.AutoSize = true;
            this.LBLFechaCreacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLFechaCreacion.Location = new System.Drawing.Point(595, 82);
            this.LBLFechaCreacion.Name = "LBLFechaCreacion";
            this.LBLFechaCreacion.Size = new System.Drawing.Size(129, 20);
            this.LBLFechaCreacion.TabIndex = 225;
            this.LBLFechaCreacion.Text = "Fecha Pedido:";
            // 
            // PedidoV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1150, 779);
            this.Controls.Add(this.LBLFechaCreacion);
            this.Controls.Add(this.TxtBuscarClientes);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.TxtBuscarPedidos);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.BTNBuscarPedidos);
            this.Controls.Add(this.BTNBuscarClientes);
            this.Controls.Add(this.BTNLimpiarClientes);
            this.Controls.Add(this.TxtDias);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtCondicionPago);
            this.Controls.Add(this.TxtApellido);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.TxtClienteId);
            this.Controls.Add(this.BTNBuscarPedido);
            this.Controls.Add(this.BTNLimpiarTodo);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.TxtProductoDetalle);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.BTNLimpiar);
            this.Controls.Add(this.TxtCategoria);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.TxtCategoriaId);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.TxtUniDescripcion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtPedidoDetalleId);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.TxtUnidadId);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtProductoId);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.TxtPrecioUnitario);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.CHKRealizado);
            this.Controls.Add(this.TxtSubTotal);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.BTNBuscarCliente);
            this.Controls.Add(this.TxtPedidoId);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtDescuento);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dgvdetalle);
            this.Controls.Add(this.DTPFechaPedido);
            this.Controls.Add(this.label2);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "PedidoV";
            this.Text = "PedidoV";
            this.Load += new System.EventHandler(this.PedidoV_Load);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.DTPFechaPedido, 0);
            this.Controls.SetChildIndex(this.dgvdetalle, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.txtDescuento, 0);
            this.Controls.SetChildIndex(this.label11, 0);
            this.Controls.SetChildIndex(this.txtTotal, 0);
            this.Controls.SetChildIndex(this.btnConfirmar, 0);
            this.Controls.SetChildIndex(this.btnEliminar, 0);
            this.Controls.SetChildIndex(this.label13, 0);
            this.Controls.SetChildIndex(this.TxtPedidoId, 0);
            this.Controls.SetChildIndex(this.BTNBuscarCliente, 0);
            this.Controls.SetChildIndex(this.label15, 0);
            this.Controls.SetChildIndex(this.TxtSubTotal, 0);
            this.Controls.SetChildIndex(this.CHKRealizado, 0);
            this.Controls.SetChildIndex(this.label16, 0);
            this.Controls.SetChildIndex(this.btnBuscar, 0);
            this.Controls.SetChildIndex(this.btnAgregar, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.TxtPrecioUnitario, 0);
            this.Controls.SetChildIndex(this.txtCantidad, 0);
            this.Controls.SetChildIndex(this.txtProductoId, 0);
            this.Controls.SetChildIndex(this.label12, 0);
            this.Controls.SetChildIndex(this.TxtUnidadId, 0);
            this.Controls.SetChildIndex(this.label14, 0);
            this.Controls.SetChildIndex(this.TxtPedidoDetalleId, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.TxtUniDescripcion, 0);
            this.Controls.SetChildIndex(this.label17, 0);
            this.Controls.SetChildIndex(this.TxtCategoriaId, 0);
            this.Controls.SetChildIndex(this.label18, 0);
            this.Controls.SetChildIndex(this.TxtCategoria, 0);
            this.Controls.SetChildIndex(this.BTNLimpiar, 0);
            this.Controls.SetChildIndex(this.label19, 0);
            this.Controls.SetChildIndex(this.TxtProductoDetalle, 0);
            this.Controls.SetChildIndex(this.label20, 0);
            this.Controls.SetChildIndex(this.BTNLimpiarTodo, 0);
            this.Controls.SetChildIndex(this.BTNBuscarPedido, 0);
            this.Controls.SetChildIndex(this.TxtClienteId, 0);
            this.Controls.SetChildIndex(this.TxtNombre, 0);
            this.Controls.SetChildIndex(this.TxtApellido, 0);
            this.Controls.SetChildIndex(this.TxtCondicionPago, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.TxtDias, 0);
            this.Controls.SetChildIndex(this.BTNLimpiarClientes, 0);
            this.Controls.SetChildIndex(this.BTNBuscarClientes, 0);
            this.Controls.SetChildIndex(this.BTNBuscarPedidos, 0);
            this.Controls.SetChildIndex(this.label22, 0);
            this.Controls.SetChildIndex(this.TxtBuscarPedidos, 0);
            this.Controls.SetChildIndex(this.label21, 0);
            this.Controls.SetChildIndex(this.TxtBuscarClientes, 0);
            this.Controls.SetChildIndex(this.LBLFechaCreacion, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNLimpiar;
        private System.Windows.Forms.TextBox TxtCategoria;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox TxtCategoriaId;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox TxtUniDescripcion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtPedidoDetalleId;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox TxtUnidadId;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtProductoId;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox TxtPrecioUnitario;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.CheckBox CHKRealizado;
        private System.Windows.Forms.TextBox TxtSubTotal;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button BTNBuscarCliente;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvdetalle;
        private System.Windows.Forms.DateTimePicker DTPFechaPedido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox TxtProductoDetalle;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductoId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalLinea;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button BTNLimpiarTodo;
        private System.Windows.Forms.Button BTNBuscarPedido;
        private System.Windows.Forms.TextBox TxtCondicionPago;
        private System.Windows.Forms.TextBox TxtApellido;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtDias;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTNLimpiarClientes;
        private System.Windows.Forms.Button BTNBuscarClientes;
        private System.Windows.Forms.Button BTNBuscarPedidos;
        private System.Windows.Forms.TextBox TxtBuscarClientes;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox TxtBuscarPedidos;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox TxtClienteId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtPedidoId;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label LBLFechaCreacion;
    }
}