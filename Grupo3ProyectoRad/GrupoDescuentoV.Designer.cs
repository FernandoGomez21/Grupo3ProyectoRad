﻿namespace Grupo3PrimerFase
{
    partial class GrupoDescuentoV
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
            this.TxtPorcentaje = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.TxtDescuentoId = new System.Windows.Forms.TextBox();
            this.CHKActivo = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CHKActivos = new System.Windows.Forms.CheckBox();
            this.DGVDatos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.BTNLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtPorcentaje
            // 
            this.TxtPorcentaje.Location = new System.Drawing.Point(166, 201);
            this.TxtPorcentaje.Name = "TxtPorcentaje";
            this.TxtPorcentaje.Size = new System.Drawing.Size(337, 22);
            this.TxtPorcentaje.TabIndex = 81;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 25);
            this.label5.TabIndex = 80;
            this.label5.Text = "Porcentaje";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(355, 300);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(117, 38);
            this.btnEliminar.TabIndex = 79;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.Image = global::Grupo3ProyectoRad.Properties.Resources.guardar;
            this.BtnAgregar.Location = new System.Drawing.Point(222, 300);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(117, 38);
            this.BtnAgregar.TabIndex = 78;
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.Location = new System.Drawing.Point(166, 161);
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(337, 22);
            this.TxtDescripcion.TabIndex = 77;
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Location = new System.Drawing.Point(166, 123);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(337, 22);
            this.TxtCodigo.TabIndex = 76;
            // 
            // TxtDescuentoId
            // 
            this.TxtDescuentoId.Enabled = false;
            this.TxtDescuentoId.Location = new System.Drawing.Point(166, 83);
            this.TxtDescuentoId.Name = "TxtDescuentoId";
            this.TxtDescuentoId.ReadOnly = true;
            this.TxtDescuentoId.Size = new System.Drawing.Size(100, 22);
            this.TxtDescuentoId.TabIndex = 75;
            // 
            // CHKActivo
            // 
            this.CHKActivo.AutoSize = true;
            this.CHKActivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CHKActivo.Location = new System.Drawing.Point(53, 237);
            this.CHKActivo.Name = "CHKActivo";
            this.CHKActivo.Size = new System.Drawing.Size(94, 29);
            this.CHKActivo.TabIndex = 74;
            this.CHKActivo.Text = "Activo";
            this.CHKActivo.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 25);
            this.label4.TabIndex = 73;
            this.label4.Text = "Descripcion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(66, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 25);
            this.label3.TabIndex = 72;
            this.label3.Text = "Codigo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 25);
            this.label2.TabIndex = 71;
            this.label2.Text = "DescuentoId";
            // 
            // CHKActivos
            // 
            this.CHKActivos.AutoSize = true;
            this.CHKActivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CHKActivos.Location = new System.Drawing.Point(909, 314);
            this.CHKActivos.Name = "CHKActivos";
            this.CHKActivos.Size = new System.Drawing.Size(227, 29);
            this.CHKActivos.TabIndex = 70;
            this.CHKActivos.Text = "Mostrar solo activas";
            this.CHKActivos.UseVisualStyleBackColor = true;
            this.CHKActivos.CheckedChanged += new System.EventHandler(this.CHKActivos_CheckedChanged);
            // 
            // DGVDatos
            // 
            this.DGVDatos.AllowUserToAddRows = false;
            this.DGVDatos.AllowUserToDeleteRows = false;
            this.DGVDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVDatos.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.DGVDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVDatos.Location = new System.Drawing.Point(12, 349);
            this.DGVDatos.Name = "DGVDatos";
            this.DGVDatos.RowHeadersWidth = 51;
            this.DGVDatos.RowTemplate.Height = 24;
            this.DGVDatos.Size = new System.Drawing.Size(1104, 313);
            this.DGVDatos.TabIndex = 69;
            this.DGVDatos.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGVDatos_RowHeaderMouseClick);
            this.DGVDatos.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGVDatos_RowHeaderMouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(448, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 25);
            this.label1.TabIndex = 68;
            this.label1.Text = "GrupoDescuento";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // BTNLimpiar
            // 
            this.BTNLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BTNLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNLimpiar.Image = global::Grupo3ProyectoRad.Properties.Resources.cancelar;
            this.BTNLimpiar.Location = new System.Drawing.Point(489, 300);
            this.BTNLimpiar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTNLimpiar.Name = "BTNLimpiar";
            this.BTNLimpiar.Size = new System.Drawing.Size(117, 38);
            this.BTNLimpiar.TabIndex = 94;
            this.BTNLimpiar.UseVisualStyleBackColor = false;
            this.BTNLimpiar.Click += new System.EventHandler(this.BTNLimpiar_Click);
            // 
            // GrupoDescuentoV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1139, 674);
            this.Controls.Add(this.BTNLimpiar);
            this.Controls.Add(this.TxtPorcentaje);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.TxtDescripcion);
            this.Controls.Add(this.TxtCodigo);
            this.Controls.Add(this.TxtDescuentoId);
            this.Controls.Add(this.CHKActivo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CHKActivos);
            this.Controls.Add(this.DGVDatos);
            this.Controls.Add(this.label1);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "GrupoDescuentoV";
            this.Text = "GrupoDescuentoV";
            this.Load += new System.EventHandler(this.GrupoDescuentoV_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.DGVDatos, 0);
            this.Controls.SetChildIndex(this.CHKActivos, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.CHKActivo, 0);
            this.Controls.SetChildIndex(this.TxtDescuentoId, 0);
            this.Controls.SetChildIndex(this.TxtCodigo, 0);
            this.Controls.SetChildIndex(this.TxtDescripcion, 0);
            this.Controls.SetChildIndex(this.BtnAgregar, 0);
            this.Controls.SetChildIndex(this.btnEliminar, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.TxtPorcentaje, 0);
            this.Controls.SetChildIndex(this.BTNLimpiar, 0);
            ((System.ComponentModel.ISupportInitialize)(this.DGVDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtPorcentaje;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.TextBox TxtDescripcion;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.TextBox TxtDescuentoId;
        private System.Windows.Forms.CheckBox CHKActivo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox CHKActivos;
        private System.Windows.Forms.DataGridView DGVDatos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button BTNLimpiar;
    }
}