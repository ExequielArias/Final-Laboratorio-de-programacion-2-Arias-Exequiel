using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Laboratorio_de_programacion_2_Arias_Exequiel
{
    public partial class frmCargaDeProducto : Form
    {
        frmImpresion impresion = new frmImpresion();
        string[,] MatrizProductos = new string[10, 4];
        conexion oCargar = new conexion();
        int fila = 0;
        public frmCargaDeProducto()
        {
            InitializeComponent();
        }

        private void cmdConsulta_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "")
            {
                if (dtpFecha.Value < DateTime.Today)
                {
                    MessageBox.Show("Indique una fecha actual o posterior a la de hoy", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int n = dgvConsultas.Rows.Add();
                    dgvConsultas.Rows[n].Cells[0].Value = "";
                    dgvConsultas.Rows[n].Cells[1].Value = txtNombre.Text;
                    dgvConsultas.Rows[n].Cells[2].Value = dtpFecha.Text;
                    impresion.MatrizProductos[fila, 0] = (fila + 1).ToString();
                    impresion.MatrizProductos[fila, 1] = txtNombre.Text;
                    dgvConsultas.Rows.Add(MatrizProductos[fila, 0], MatrizProductos[fila, 1]);
                }
            }
            else
            {
                MessageBox.Show("Agregue un Producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmdCargar_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "")
            {
                if (dtpFecha.Value < DateTime.Today)
                {
                    MessageBox.Show("Indique una fecha actual o posterior a la de hoy", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    oCargar.grabar(Convert.ToInt32(txtId.Text), txtNombre.Text, dtpFecha.Value); 
                }
            }
            else
            {
                MessageBox.Show("Agregue un Producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmCargaDeProducto_Load(object sender, EventArgs e)
        {
            
        }

        private void cmdImpresion_Click(object sender, EventArgs e)
        {
            frmImpresion impresion = new frmImpresion();
            impresion.ShowDialog();
        }
    }
}
