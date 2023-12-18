
namespace Final_Laboratorio_de_programacion_2_Arias_Exequiel
{
    partial class frmMenu
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
            this.cmdCargaDeProducto = new System.Windows.Forms.Button();
            this.cmdCargaDeVentas = new System.Windows.Forms.Button();
            this.cmdImpresion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdCargaDeProducto
            // 
            this.cmdCargaDeProducto.Location = new System.Drawing.Point(12, 23);
            this.cmdCargaDeProducto.Name = "cmdCargaDeProducto";
            this.cmdCargaDeProducto.Size = new System.Drawing.Size(104, 40);
            this.cmdCargaDeProducto.TabIndex = 0;
            this.cmdCargaDeProducto.Text = "Carga de Productos";
            this.cmdCargaDeProducto.UseVisualStyleBackColor = true;
            this.cmdCargaDeProducto.Click += new System.EventHandler(this.cmdCargaDeProducto_Click);
            // 
            // cmdCargaDeVentas
            // 
            this.cmdCargaDeVentas.Location = new System.Drawing.Point(122, 23);
            this.cmdCargaDeVentas.Name = "cmdCargaDeVentas";
            this.cmdCargaDeVentas.Size = new System.Drawing.Size(104, 40);
            this.cmdCargaDeVentas.TabIndex = 1;
            this.cmdCargaDeVentas.Text = "Carga de Ventas";
            this.cmdCargaDeVentas.UseVisualStyleBackColor = true;
            this.cmdCargaDeVentas.Click += new System.EventHandler(this.cmdCargaDeVentas_Click);
            // 
            // cmdImpresion
            // 
            this.cmdImpresion.Location = new System.Drawing.Point(232, 23);
            this.cmdImpresion.Name = "cmdImpresion";
            this.cmdImpresion.Size = new System.Drawing.Size(104, 40);
            this.cmdImpresion.TabIndex = 2;
            this.cmdImpresion.Text = "Impresion";
            this.cmdImpresion.UseVisualStyleBackColor = true;
            this.cmdImpresion.Click += new System.EventHandler(this.cmdImpresion_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 83);
            this.Controls.Add(this.cmdImpresion);
            this.Controls.Add(this.cmdCargaDeVentas);
            this.Controls.Add(this.cmdCargaDeProducto);
            this.Name = "frmMenu";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdCargaDeProducto;
        private System.Windows.Forms.Button cmdCargaDeVentas;
        private System.Windows.Forms.Button cmdImpresion;
    }
}

