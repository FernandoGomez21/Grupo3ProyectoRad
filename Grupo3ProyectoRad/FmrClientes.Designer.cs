namespace Grupo3ProyectoRad
{
    partial class FmrClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmrClientes));
            this.btnguardar = new System.Windows.Forms.Button();
            this.dgvclientes = new System.Windows.Forms.DataGridView();
            this.CHKEstado = new System.Windows.Forms.CheckBox();
            this.TxtCondicionPagDias = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtClienteId = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CHKActivos = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtPorcentaje = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.CBXCondicionPagId = new System.Windows.Forms.ComboBox();
            this.CBXGrupoDescId = new System.Windows.Forms.ComboBox();
            this.BTNEliminar = new System.Windows.Forms.Button();
            this.TxtLimpiar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvclientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnguardar
            // 
            this.btnguardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnguardar.Image = global::Grupo3ProyectoRad.Properties.Resources.guardar;
            this.btnguardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnguardar.Location = new System.Drawing.Point(478, 369);
            this.btnguardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(148, 48);
            this.btnguardar.TabIndex = 44;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnguardar.UseVisualStyleBackColor = false;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // dgvclientes
            // 
            this.dgvclientes.AllowUserToOrderColumns = true;
            this.dgvclientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvclientes.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvclientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvclientes.Location = new System.Drawing.Point(16, 424);
            this.dgvclientes.Margin = new System.Windows.Forms.Padding(4);
            this.dgvclientes.Name = "dgvclientes";
            this.dgvclientes.RowHeadersWidth = 51;
            this.dgvclientes.RowTemplate.Height = 24;
            this.dgvclientes.Size = new System.Drawing.Size(1078, 262);
            this.dgvclientes.TabIndex = 43;
            this.dgvclientes.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvclientes_RowHeaderMouseClick);
            this.dgvclientes.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvclientes_RowHeaderMouseDoubleClick);
            // 
            // CHKEstado
            // 
            this.CHKEstado.AutoSize = true;
            this.CHKEstado.Location = new System.Drawing.Point(631, 216);
            this.CHKEstado.Margin = new System.Windows.Forms.Padding(4);
            this.CHKEstado.Name = "CHKEstado";
            this.CHKEstado.Size = new System.Drawing.Size(18, 17);
            this.CHKEstado.TabIndex = 42;
            this.CHKEstado.UseVisualStyleBackColor = true;
            // 
            // TxtCondicionPagDias
            // 
            this.TxtCondicionPagDias.Enabled = false;
            this.TxtCondicionPagDias.Location = new System.Drawing.Point(631, 162);
            this.TxtCondicionPagDias.Margin = new System.Windows.Forms.Padding(4);
            this.TxtCondicionPagDias.Name = "TxtCondicionPagDias";
            this.TxtCondicionPagDias.Size = new System.Drawing.Size(206, 27);
            this.TxtCondicionPagDias.TabIndex = 40;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(236, 260);
            this.txtApellidos.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(193, 27);
            this.txtApellidos.TabIndex = 36;
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(236, 206);
            this.txtNombres.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(193, 27);
            this.txtNombres.TabIndex = 35;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(236, 153);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(193, 27);
            this.txtCodigo.TabIndex = 34;
            // 
            // txtClienteId
            // 
            this.txtClienteId.Enabled = false;
            this.txtClienteId.Location = new System.Drawing.Point(236, 105);
            this.txtClienteId.Margin = new System.Windows.Forms.Padding(4);
            this.txtClienteId.Name = "txtClienteId";
            this.txtClienteId.Size = new System.Drawing.Size(193, 27);
            this.txtClienteId.TabIndex = 33;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(539, 213);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 20);
            this.label9.TabIndex = 31;
            this.label9.Text = "Estado";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(559, 169);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 20);
            this.label8.TabIndex = 30;
            this.label8.Text = "Dias";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(455, 106);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 20);
            this.label7.TabIndex = 29;
            this.label7.Text = "CondicionPagoId";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(39, 324);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 20);
            this.label5.TabIndex = 27;
            this.label5.Text = "GrupoDescuentoId";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(116, 264);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "Apellidos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(116, 213);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 25;
            this.label3.Text = "Nombres";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(134, 160);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "Codigo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(123, 109);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "ClienteId";
            // 
            // CHKActivos
            // 
            this.CHKActivos.AutoSize = true;
            this.CHKActivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CHKActivos.Location = new System.Drawing.Point(947, 380);
            this.CHKActivos.Margin = new System.Windows.Forms.Padding(4);
            this.CHKActivos.Name = "CHKActivos";
            this.CHKActivos.Size = new System.Drawing.Size(155, 29);
            this.CHKActivos.TabIndex = 46;
            this.CHKActivos.Text = "Solo Activos";
            this.CHKActivos.UseVisualStyleBackColor = true;
            this.CHKActivos.CheckedChanged += new System.EventHandler(this.CHKActivos_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(105, 374);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 20);
            this.label6.TabIndex = 28;
            this.label6.Text = "Porcentaje";
            // 
            // TxtPorcentaje
            // 
            this.TxtPorcentaje.Enabled = false;
            this.TxtPorcentaje.Location = new System.Drawing.Point(236, 366);
            this.TxtPorcentaje.Margin = new System.Windows.Forms.Padding(4);
            this.TxtPorcentaje.Name = "TxtPorcentaje";
            this.TxtPorcentaje.Size = new System.Drawing.Size(193, 27);
            this.TxtPorcentaje.TabIndex = 38;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // CBXCondicionPagId
            // 
            this.CBXCondicionPagId.FormattingEnabled = true;
            this.CBXCondicionPagId.Location = new System.Drawing.Point(631, 106);
            this.CBXCondicionPagId.Margin = new System.Windows.Forms.Padding(4);
            this.CBXCondicionPagId.Name = "CBXCondicionPagId";
            this.CBXCondicionPagId.Size = new System.Drawing.Size(206, 28);
            this.CBXCondicionPagId.TabIndex = 47;
            this.CBXCondicionPagId.SelectionChangeCommitted += new System.EventHandler(this.CBXCondicionPagId_SelectionChangeCommitted);
            // 
            // CBXGrupoDescId
            // 
            this.CBXGrupoDescId.FormattingEnabled = true;
            this.CBXGrupoDescId.Location = new System.Drawing.Point(236, 314);
            this.CBXGrupoDescId.Margin = new System.Windows.Forms.Padding(4);
            this.CBXGrupoDescId.Name = "CBXGrupoDescId";
            this.CBXGrupoDescId.Size = new System.Drawing.Size(193, 28);
            this.CBXGrupoDescId.TabIndex = 48;
            this.CBXGrupoDescId.SelectionChangeCommitted += new System.EventHandler(this.CBXGrupoDescId_SelectionChangeCommitted);
            // 
            // BTNEliminar
            // 
            this.BTNEliminar.Enabled = false;
            this.BTNEliminar.Image = ((System.Drawing.Image)(resources.GetObject("BTNEliminar.Image")));
            this.BTNEliminar.Location = new System.Drawing.Point(843, 366);
            this.BTNEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.BTNEliminar.Name = "BTNEliminar";
            this.BTNEliminar.Size = new System.Drawing.Size(78, 52);
            this.BTNEliminar.TabIndex = 79;
            this.BTNEliminar.UseVisualStyleBackColor = true;
            this.BTNEliminar.Click += new System.EventHandler(this.BTNEliminar_Click_1);
            // 
            // TxtLimpiar
            // 
            this.TxtLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TxtLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtLimpiar.Location = new System.Drawing.Point(663, 369);
            this.TxtLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.TxtLimpiar.Name = "TxtLimpiar";
            this.TxtLimpiar.Size = new System.Drawing.Size(138, 48);
            this.TxtLimpiar.TabIndex = 80;
            this.TxtLimpiar.Text = "Limpiar";
            this.TxtLimpiar.UseVisualStyleBackColor = false;
            this.TxtLimpiar.Click += new System.EventHandler(this.TxtLimpiar_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(422, 59);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(166, 20);
            this.label10.TabIndex = 81;
            this.label10.Text = "Todos los Clientes";
            // 
            // FmrClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 701);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TxtLimpiar);
            this.Controls.Add(this.BTNEliminar);
            this.Controls.Add(this.CBXGrupoDescId);
            this.Controls.Add(this.CBXCondicionPagId);
            this.Controls.Add(this.CHKActivos);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.dgvclientes);
            this.Controls.Add(this.CHKEstado);
            this.Controls.Add(this.TxtCondicionPagDias);
            this.Controls.Add(this.TxtPorcentaje);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.txtClienteId);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Location = new System.Drawing.Point(0, 0);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FmrClientes";
            this.Text = "FmrClientes";
            this.Load += new System.EventHandler(this.FmrClientes_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.txtClienteId, 0);
            this.Controls.SetChildIndex(this.txtCodigo, 0);
            this.Controls.SetChildIndex(this.txtNombres, 0);
            this.Controls.SetChildIndex(this.txtApellidos, 0);
            this.Controls.SetChildIndex(this.TxtPorcentaje, 0);
            this.Controls.SetChildIndex(this.TxtCondicionPagDias, 0);
            this.Controls.SetChildIndex(this.CHKEstado, 0);
            this.Controls.SetChildIndex(this.dgvclientes, 0);
            this.Controls.SetChildIndex(this.btnguardar, 0);
            this.Controls.SetChildIndex(this.CHKActivos, 0);
            this.Controls.SetChildIndex(this.CBXCondicionPagId, 0);
            this.Controls.SetChildIndex(this.CBXGrupoDescId, 0);
            this.Controls.SetChildIndex(this.BTNEliminar, 0);
            this.Controls.SetChildIndex(this.TxtLimpiar, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvclientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.DataGridView dgvclientes;
        private System.Windows.Forms.CheckBox CHKEstado;
        private System.Windows.Forms.TextBox TxtCondicionPagDias;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtClienteId;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox CHKActivos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtPorcentaje;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox CBXGrupoDescId;
        private System.Windows.Forms.ComboBox CBXCondicionPagId;
        private System.Windows.Forms.Button BTNEliminar;
        private System.Windows.Forms.Button TxtLimpiar;
        private System.Windows.Forms.Label label10;
    }
}