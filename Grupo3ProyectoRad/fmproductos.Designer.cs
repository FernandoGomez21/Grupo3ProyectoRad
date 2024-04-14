namespace Grupo3ProyectoRad
{
    partial class fmproductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmproductos));
            this.dgvproducto = new System.Windows.Forms.DataGridView();
            this.txtUnidadMedida = new System.Windows.Forms.TextBox();
            this.txtCategoriaModels = new System.Windows.Forms.TextBox();
            this.txtPrecioCompra = new System.Windows.Forms.TextBox();
            this.txtProductosId = new System.Windows.Forms.TextBox();
            this.checkBox1Estado = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CHKActivos = new System.Windows.Forms.CheckBox();
            this.TxtLimpiar = new System.Windows.Forms.Button();
            this.BTNEliminar = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.CBXUnidadMedidaId = new System.Windows.Forms.ComboBox();
            this.CBXCategoriaId = new System.Windows.Forms.ComboBox();
            this.TXTProductoDetalle = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvproducto
            // 
            this.dgvproducto.AllowUserToOrderColumns = true;
            this.dgvproducto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvproducto.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvproducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvproducto.Location = new System.Drawing.Point(26, 326);
            this.dgvproducto.Name = "dgvproducto";
            this.dgvproducto.RowHeadersWidth = 51;
            this.dgvproducto.RowTemplate.Height = 24;
            this.dgvproducto.Size = new System.Drawing.Size(946, 243);
            this.dgvproducto.TabIndex = 35;
            this.dgvproducto.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvproducto_RowHeaderMouseClick);
            this.dgvproducto.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvproducto_RowHeaderMouseDoubleClick);
            // 
            // txtUnidadMedida
            // 
            this.txtUnidadMedida.Enabled = false;
            this.txtUnidadMedida.Location = new System.Drawing.Point(563, 130);
            this.txtUnidadMedida.Name = "txtUnidadMedida";
            this.txtUnidadMedida.Size = new System.Drawing.Size(217, 22);
            this.txtUnidadMedida.TabIndex = 33;
            // 
            // txtCategoriaModels
            // 
            this.txtCategoriaModels.Enabled = false;
            this.txtCategoriaModels.Location = new System.Drawing.Point(179, 212);
            this.txtCategoriaModels.Name = "txtCategoriaModels";
            this.txtCategoriaModels.Size = new System.Drawing.Size(217, 22);
            this.txtCategoriaModels.TabIndex = 31;
            // 
            // txtPrecioCompra
            // 
            this.txtPrecioCompra.Location = new System.Drawing.Point(179, 291);
            this.txtPrecioCompra.Name = "txtPrecioCompra";
            this.txtPrecioCompra.Size = new System.Drawing.Size(128, 22);
            this.txtPrecioCompra.TabIndex = 29;
            // 
            // txtProductosId
            // 
            this.txtProductosId.Enabled = false;
            this.txtProductosId.Location = new System.Drawing.Point(179, 94);
            this.txtProductosId.Name = "txtProductosId";
            this.txtProductosId.Size = new System.Drawing.Size(217, 22);
            this.txtProductosId.TabIndex = 28;
            // 
            // checkBox1Estado
            // 
            this.checkBox1Estado.AutoSize = true;
            this.checkBox1Estado.Location = new System.Drawing.Point(179, 250);
            this.checkBox1Estado.Name = "checkBox1Estado";
            this.checkBox1Estado.Size = new System.Drawing.Size(18, 17);
            this.checkBox1Estado.TabIndex = 27;
            this.checkBox1Estado.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(32, 287);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 20);
            this.label8.TabIndex = 26;
            this.label8.Text = "PrecioCompra";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(76, 245);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 20);
            this.label7.TabIndex = 25;
            this.label7.Text = "Estado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "CategoriaModels";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(41, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "CategoriaId";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(414, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "UnidadMedida";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "UnidadMedidaId";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "ProductosId";
            // 
            // CHKActivos
            // 
            this.CHKActivos.AutoSize = true;
            this.CHKActivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CHKActivos.Location = new System.Drawing.Point(867, 291);
            this.CHKActivos.Name = "CHKActivos";
            this.CHKActivos.Size = new System.Drawing.Size(105, 29);
            this.CHKActivos.TabIndex = 38;
            this.CHKActivos.Text = "Activos";
            this.CHKActivos.UseVisualStyleBackColor = true;
            this.CHKActivos.CheckedChanged += new System.EventHandler(this.CHKActivos_CheckedChanged);
            // 
            // TxtLimpiar
            // 
            this.TxtLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtLimpiar.Location = new System.Drawing.Point(626, 272);
            this.TxtLimpiar.Name = "TxtLimpiar";
            this.TxtLimpiar.Size = new System.Drawing.Size(100, 38);
            this.TxtLimpiar.TabIndex = 83;
            this.TxtLimpiar.Text = "Limpiar";
            this.TxtLimpiar.UseVisualStyleBackColor = true;
            this.TxtLimpiar.Click += new System.EventHandler(this.TxtLimpiar_Click);
            // 
            // BTNEliminar
            // 
            this.BTNEliminar.Enabled = false;
            this.BTNEliminar.Image = ((System.Drawing.Image)(resources.GetObject("BTNEliminar.Image")));
            this.BTNEliminar.Location = new System.Drawing.Point(749, 271);
            this.BTNEliminar.Name = "BTNEliminar";
            this.BTNEliminar.Size = new System.Drawing.Size(57, 42);
            this.BTNEliminar.TabIndex = 82;
            this.BTNEliminar.UseVisualStyleBackColor = true;
            this.BTNEliminar.Click += new System.EventHandler(this.BTNEliminar_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardar.Image = global::Grupo3ProyectoRad.Properties.Resources.guardar;
            this.btnguardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnguardar.Location = new System.Drawing.Point(478, 272);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(122, 38);
            this.btnguardar.TabIndex = 81;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // CBXUnidadMedidaId
            // 
            this.CBXUnidadMedidaId.FormattingEnabled = true;
            this.CBXUnidadMedidaId.Location = new System.Drawing.Point(181, 130);
            this.CBXUnidadMedidaId.Name = "CBXUnidadMedidaId";
            this.CBXUnidadMedidaId.Size = new System.Drawing.Size(217, 24);
            this.CBXUnidadMedidaId.TabIndex = 84;
            this.CBXUnidadMedidaId.SelectionChangeCommitted += new System.EventHandler(this.CBXUnidadMedidaId_SelectionChangeCommitted);
            // 
            // CBXCategoriaId
            // 
            this.CBXCategoriaId.FormattingEnabled = true;
            this.CBXCategoriaId.Location = new System.Drawing.Point(179, 172);
            this.CBXCategoriaId.Name = "CBXCategoriaId";
            this.CBXCategoriaId.Size = new System.Drawing.Size(217, 24);
            this.CBXCategoriaId.TabIndex = 85;
            this.CBXCategoriaId.SelectionChangeCommitted += new System.EventHandler(this.CBXCategoriaId_SelectionChangeCommitted);
            // 
            // TXTProductoDetalle
            // 
            this.TXTProductoDetalle.Location = new System.Drawing.Point(563, 94);
            this.TXTProductoDetalle.Name = "TXTProductoDetalle";
            this.TXTProductoDetalle.Size = new System.Drawing.Size(217, 22);
            this.TXTProductoDetalle.TabIndex = 87;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(461, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 20);
            this.label6.TabIndex = 86;
            this.label6.Text = "Detalle";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(398, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(182, 20);
            this.label9.TabIndex = 88;
            this.label9.Text = "Todos los Productos";
            // 
            // fmproductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(994, 588);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TXTProductoDetalle);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CBXCategoriaId);
            this.Controls.Add(this.CBXUnidadMedidaId);
            this.Controls.Add(this.TxtLimpiar);
            this.Controls.Add(this.BTNEliminar);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.CHKActivos);
            this.Controls.Add(this.dgvproducto);
            this.Controls.Add(this.txtUnidadMedida);
            this.Controls.Add(this.txtCategoriaModels);
            this.Controls.Add(this.txtPrecioCompra);
            this.Controls.Add(this.txtProductosId);
            this.Controls.Add(this.checkBox1Estado);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "fmproductos";
            this.Text = "fmproductos";
            this.Load += new System.EventHandler(this.fmproductos_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.checkBox1Estado, 0);
            this.Controls.SetChildIndex(this.txtProductosId, 0);
            this.Controls.SetChildIndex(this.txtPrecioCompra, 0);
            this.Controls.SetChildIndex(this.txtCategoriaModels, 0);
            this.Controls.SetChildIndex(this.txtUnidadMedida, 0);
            this.Controls.SetChildIndex(this.dgvproducto, 0);
            this.Controls.SetChildIndex(this.CHKActivos, 0);
            this.Controls.SetChildIndex(this.btnguardar, 0);
            this.Controls.SetChildIndex(this.BTNEliminar, 0);
            this.Controls.SetChildIndex(this.TxtLimpiar, 0);
            this.Controls.SetChildIndex(this.CBXUnidadMedidaId, 0);
            this.Controls.SetChildIndex(this.CBXCategoriaId, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.TXTProductoDetalle, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvproducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvproducto;
        private System.Windows.Forms.TextBox txtUnidadMedida;
        private System.Windows.Forms.TextBox txtCategoriaModels;
        private System.Windows.Forms.TextBox txtPrecioCompra;
        private System.Windows.Forms.TextBox txtProductosId;
        private System.Windows.Forms.CheckBox checkBox1Estado;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox CHKActivos;
        private System.Windows.Forms.Button TxtLimpiar;
        private System.Windows.Forms.Button BTNEliminar;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox CBXCategoriaId;
        private System.Windows.Forms.ComboBox CBXUnidadMedidaId;
        private System.Windows.Forms.TextBox TXTProductoDetalle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
    }
}