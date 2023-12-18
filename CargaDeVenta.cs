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
    public partial class frmCargaDeVenta : Form
    {
        string[,] MatrizProductos = new string[10, 4];
        frmImpresion impresion = new frmImpresion(); 
        conexion oCargar2 = new conexion();
        int fila = 0;
        public frmCargaDeVenta()
        {
            InitializeComponent();
        }

        private void frmCargaDeVenta_Load(object sender, EventArgs e)
        {

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
                    oCargar2.grabar2(Convert.ToInt32(txtId.Text), dtpFecha.Value, txtProducto.Text, nudCantidad);
                }
            }
            else
            {
                MessageBox.Show("Agregue un Producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmdConsultar_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "")
            {
                if (dtpFecha.Value < DateTime.Today)
                {
                    MessageBox.Show("Indique una fecha actual o posterior a la de hoy", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int n = dgvConsulta.Rows.Add();
                    dgvConsulta.Rows[n].Cells[0].Value = "";
                    dgvConsulta.Rows[n].Cells[1].Value = dtpFecha.Text;
                    dgvConsulta.Rows[n].Cells[2].Value = txtProducto.Text;
                    dgvConsulta.Rows[n].Cells[3].Value = nudCantidad;
                    impresion.MatrizProductos[fila, 0] = (fila + 1).ToString();
                    impresion.MatrizProductos[fila, 2] = txtProducto.Text;
                    impresion.MatrizProductos[fila, 4] = nudCantidad.Text;
                    impresion.MatrizProductos[fila, 3] = dtpFecha.Text;
                    dgvConsulta.Rows.Add(MatrizProductos[fila, 0], MatrizProductos[fila, 2], MatrizProductos[fila, 3], MatrizProductos[fila, 4]);
                    fila++;

                }
            }
            else
            {
                MessageBox.Show("Agregue un Producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmdImpresion_Click(object sender, EventArgs e)
        {
            frmImpresion impresion = new frmImpresion();
            impresion.ShowDialog();
        }
    }
}
