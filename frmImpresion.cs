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
    public partial class frmImpresion : Form
    {
        public string[,] MatrizProductos = new string[10, 4];
        public frmImpresion()
        {
            InitializeComponent();
        }

        private void frmImpresion_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                if (MatrizProductos[i, 2] != null)
                {
                    if (cboFiltroProducto.Items.Contains(MatrizProductos[i, 2]) == false)
                    {
                        cboFiltroProducto.Items.Add(MatrizProductos[i, 2]);
                    }
                }
            }
        }

        private void cmdFiltrar_Click(object sender, EventArgs e)
        {
            dgvImpresion.Rows.Clear();
            if (optProducto.Checked)
            {
                for (int i = 0; i < 10; i++)
                {
                    if (MatrizProductos[i, 2] == cboFiltroProducto.Text)
                    {
                        dgvImpresion.Rows.Add(MatrizProductos[i, 0], MatrizProductos[i, 1], MatrizProductos[i, 2], MatrizProductos[i, 3]);
                    }
                }
            }
            else
            {
                for (int i = 0; i < 10; i++)
                {
                    if (MatrizProductos[i, 3] == txtBuscar.Text)
                    {
                        dgvImpresion.Rows.Add(MatrizProductos[i, 0], MatrizProductos[i, 1], MatrizProductos[i, 2], MatrizProductos[i, 3]);
                    }
                }
            }
        }

        private void cmdVerTodo_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                if (MatrizProductos[i, 1] != null)
                {
                    dgvImpresion.Rows.Add(MatrizProductos[i, 0], MatrizProductos[i, 1], MatrizProductos[i, 2], MatrizProductos[i, 3], MatrizProductos[i, 4]);
                }
            }
        }
    }
}
