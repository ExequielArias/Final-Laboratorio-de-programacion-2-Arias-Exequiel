
namespace Final_Laboratorio_de_programacion_2_Arias_Exequiel
{
    partial class frmCargaDeProducto
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
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.gbRegistro = new System.Windows.Forms.GroupBox();
            this.cmdCargar = new System.Windows.Forms.Button();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.cmdConsulta = new System.Windows.Forms.Button();
            this.dgvConsultas = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmdImpresion = new System.Windows.Forms.Button();
            this.gbRegistro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultas)).BeginInit();
            this.SuspendLayout();
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(147, 23);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(57, 20);
            this.txtId.TabIndex = 1;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(147, 49);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(200, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(147, 75);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha.TabIndex = 3;
            // 
            // gbRegistro
            // 
            this.gbRegistro.Controls.Add(this.cmdCargar);
            this.gbRegistro.Controls.Add(this.lblFecha);
            this.gbRegistro.Controls.Add(this.lblNombre);
            this.gbRegistro.Controls.Add(this.lblId);
            this.gbRegistro.Controls.Add(this.txtId);
            this.gbRegistro.Controls.Add(this.dtpFecha);
            this.gbRegistro.Controls.Add(this.txtNombre);
            this.gbRegistro.Location = new System.Drawing.Point(12, 12);
            this.gbRegistro.Name = "gbRegistro";
            this.gbRegistro.Size = new System.Drawing.Size(382, 165);
            this.gbRegistro.TabIndex = 4;
            this.gbRegistro.TabStop = false;
            this.gbRegistro.Text = "Registro de ventas";
            // 
            // cmdCargar
            // 
            this.cmdCargar.Location = new System.Drawing.Point(301, 136);
            this.cmdCargar.Name = "cmdCargar";
            this.cmdCargar.Size = new System.Drawing.Size(75, 23);
            this.cmdCargar.TabIndex = 7;
            this.cmdCargar.Text = "Cargar";
            this.cmdCargar.UseVisualStyleBackColor = true;
            this.cmdCargar.Click += new System.EventHandler(this.cmdCargar_Click);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(42, 81);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(94, 13);
            this.lblFecha.TabIndex = 6;
            this.lblFecha.Text = "Fecha de Registro";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(42, 52);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 5;
            this.lblNombre.Text = "Nombre";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(42, 26);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(18, 13);
            this.lblId.TabIndex = 4;
            this.lblId.Text = "ID";
            // 
            // cmdConsulta
            // 
            this.cmdConsulta.Location = new System.Drawing.Point(12, 183);
            this.cmdConsulta.Name = "cmdConsulta";
            this.cmdConsulta.Size = new System.Drawing.Size(75, 23);
            this.cmdConsulta.TabIndex = 5;
            this.cmdConsulta.Text = "Consultar";
            this.cmdConsulta.UseVisualStyleBackColor = true;
            this.cmdConsulta.Click += new System.EventHandler(this.cmdConsulta_Click);
            // 
            // dgvConsultas
            // 
            this.dgvConsultas.AllowUserToAddRows = false;
            this.dgvConsultas.AllowUserToDeleteRows = false;
            this.dgvConsultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nombre,
            this.Fecha});
            this.dgvConsultas.Location = new System.Drawing.Point(12, 212);
            this.dgvConsultas.Name = "dgvConsultas";
            this.dgvConsultas.ReadOnly = true;
            this.dgvConsultas.Size = new System.Drawing.Size(382, 304);
            this.dgvConsultas.TabIndex = 6;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // cmdImpresion
            // 
            this.cmdImpresion.Location = new System.Drawing.Point(328, 548);
            this.cmdImpresion.Name = "cmdImpresion";
            this.cmdImpresion.Size = new System.Drawing.Size(75, 23);
            this.cmdImpresion.TabIndex = 7;
            this.cmdImpresion.Text = "Impresion";
            this.cmdImpresion.UseVisualStyleBackColor = true;
            this.cmdImpresion.Click += new System.EventHandler(this.cmdImpresion_Click);
            // 
            // frmCargaDeProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 574);
            this.Controls.Add(this.cmdImpresion);
            this.Controls.Add(this.dgvConsultas);
            this.Controls.Add(this.cmdConsulta);
            this.Controls.Add(this.gbRegistro);
            this.Name = "frmCargaDeProducto";
            this.Text = "CargaDeProducto";
            this.Load += new System.EventHandler(this.frmCargaDeProducto_Load);
            this.gbRegistro.ResumeLayout(false);
            this.gbRegistro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.GroupBox gbRegistro;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button cmdConsulta;
        private System.Windows.Forms.Button cmdCargar;
        private System.Windows.Forms.DataGridView dgvConsultas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.Button cmdImpresion;
    }
}