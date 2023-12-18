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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void cmdCargaDeProducto_Click(object sender, EventArgs e)
        {
            frmCargaDeProducto Producto = new frmCargaDeProducto();
            Producto.ShowDialog(); 
        }

        private void cmdCargaDeVentas_Click(object sender, EventArgs e)
        {
            frmCargaDeVenta Ventas = new frmCargaDeVenta();
            Ventas.ShowDialog();
        }

        private void cmdImpresion_Click(object sender, EventArgs e)
        {
            frmImpresion impresion = new frmImpresion();
            impresion.ShowDialog();
        }
    }
}
