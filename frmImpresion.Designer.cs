
namespace Final_Laboratorio_de_programacion_2_Arias_Exequiel
{
    partial class frmImpresion
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
            this.dgvImpresion = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbFiltrar = new System.Windows.Forms.GroupBox();
            this.cmdVerTodo = new System.Windows.Forms.Button();
            this.cmdFiltrar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.cboFiltroProducto = new System.Windows.Forms.ComboBox();
            this.optCantidad = new System.Windows.Forms.RadioButton();
            this.optProducto = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImpresion)).BeginInit();
            this.gbFiltrar.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvImpresion
            // 
            this.dgvImpresion.AllowUserToAddRows = false;
            this.dgvImpresion.AllowUserToDeleteRows = false;
            this.dgvImpresion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvImpresion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nombre,
            this.Producto,
            this.Fecha,
            this.Cantidad});
            this.dgvImpresion.Location = new System.Drawing.Point(12, 12);
            this.dgvImpresion.Name = "dgvImpresion";
            this.dgvImpresion.ReadOnly = true;
            this.dgvImpresion.Size = new System.Drawing.Size(543, 206);
            this.dgvImpresion.TabIndex = 0;
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
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // gbFiltrar
            // 
            this.gbFiltrar.Controls.Add(this.cmdVerTodo);
            this.gbFiltrar.Controls.Add(this.cmdFiltrar);
            this.gbFiltrar.Controls.Add(this.txtBuscar);
            this.gbFiltrar.Controls.Add(this.cboFiltroProducto);
            this.gbFiltrar.Controls.Add(this.optCantidad);
            this.gbFiltrar.Controls.Add(this.optProducto);
            this.gbFiltrar.Location = new System.Drawing.Point(75, 235);
            this.gbFiltrar.Name = "gbFiltrar";
            this.gbFiltrar.Size = new System.Drawing.Size(392, 169);
            this.gbFiltrar.TabIndex = 1;
            this.gbFiltrar.TabStop = false;
            this.gbFiltrar.Text = "Filtrar";
            // 
            // cmdVerTodo
            // 
            this.cmdVerTodo.Location = new System.Drawing.Point(164, 140);
            this.cmdVerTodo.Name = "cmdVerTodo";
            this.cmdVerTodo.Size = new System.Drawing.Size(75, 23);
            this.cmdVerTodo.TabIndex = 9;
            this.cmdVerTodo.Text = "Ver Todo";
            this.cmdVerTodo.UseVisualStyleBackColor = true;
            this.cmdVerTodo.Click += new System.EventHandler(this.cmdVerTodo_Click);
            // 
            // cmdFiltrar
            // 
            this.cmdFiltrar.Location = new System.Drawing.Point(164, 111);
            this.cmdFiltrar.Name = "cmdFiltrar";
            this.cmdFiltrar.Size = new System.Drawing.Size(75, 23);
            this.cmdFiltrar.TabIndex = 8;
            this.cmdFiltrar.Text = "Filtrar";
            this.cmdFiltrar.UseVisualStyleBackColor = true;
            this.cmdFiltrar.Click += new System.EventHandler(this.cmdFiltrar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(222, 69);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(123, 20);
            this.txtBuscar.TabIndex = 7;
            // 
            // cboFiltroProducto
            // 
            this.cboFiltroProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFiltroProducto.FormattingEnabled = true;
            this.cboFiltroProducto.Location = new System.Drawing.Point(62, 68);
            this.cboFiltroProducto.Name = "cboFiltroProducto";
            this.cboFiltroProducto.Size = new System.Drawing.Size(128, 21);
            this.cboFiltroProducto.TabIndex = 6;
            // 
            // optCantidad
            // 
            this.optCantidad.AutoSize = true;
            this.optCantidad.Location = new System.Drawing.Point(222, 32);
            this.optCantidad.Name = "optCantidad";
            this.optCantidad.Size = new System.Drawing.Size(67, 17);
            this.optCantidad.TabIndex = 1;
            this.optCantidad.TabStop = true;
            this.optCantidad.Text = "Cantidad";
            this.optCantidad.UseVisualStyleBackColor = true;
            // 
            // optProducto
            // 
            this.optProducto.AutoSize = true;
            this.optProducto.Checked = true;
            this.optProducto.Location = new System.Drawing.Point(62, 32);
            this.optProducto.Name = "optProducto";
            this.optProducto.Size = new System.Drawing.Size(67, 17);
            this.optProducto.TabIndex = 0;
            this.optProducto.TabStop = true;
            this.optProducto.Text = "producto";
            this.optProducto.UseVisualStyleBackColor = true;
            // 
            // frmImpresion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 435);
            this.Controls.Add(this.gbFiltrar);
            this.Controls.Add(this.dgvImpresion);
            this.Name = "frmImpresion";
            this.Text = "frmImpresion";
            this.Load += new System.EventHandler(this.frmImpresion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvImpresion)).EndInit();
            this.gbFiltrar.ResumeLayout(false);
            this.gbFiltrar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvImpresion;
        private System.Windows.Forms.GroupBox gbFiltrar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.ComboBox cboFiltroProducto;
        private System.Windows.Forms.RadioButton optCantidad;
        private System.Windows.Forms.RadioButton optProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.Button cmdVerTodo;
        private System.Windows.Forms.Button cmdFiltrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
    }
}