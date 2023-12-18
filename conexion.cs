
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Final_Laboratorio_de_programacion_2_Arias_Exequiel
{
    class conexion
    {
        OleDbConnection conector;
        OleDbCommand comando;
        OleDbDataAdapter adaptador;
        DataTable tabla;
        public conexion()
        {
            conector = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=c:Arias.accdb");
            comando = new OleDbCommand();

            comando.Connection = conector;
            comando.CommandType = CommandType.TableDirect;
            comando.CommandText = "Productos";

            adaptador = new OleDbDataAdapter(comando);

            tabla = new DataTable();
            adaptador.Fill(tabla);
        }
        public DataTable getData()
        {
            return tabla;
        }
        public bool grabar(Int32 id, string Nombre, DateTime fecha)
        {
            bool ok = true;
            DataRow filaBuscar = tabla.Rows.Find(id);
            DataRow fila = tabla.NewRow();
            fila["FechaRegistro"] = fecha;
            fila["Nombre"] = Nombre;
            tabla.Rows.Add(fila);
            OleDbCommandBuilder cb = new OleDbCommandBuilder(adaptador);
            adaptador.Update(tabla);
            ok = true;
            return ok;
        }
        public bool grabar2(Int32 id, DateTime fecha, string Producto, NumericUpDown cantidad)
        {
            bool ok = true;
            DataRow filaBuscar = tabla.Rows.Find(id);
            DataRow fila = tabla.NewRow();
            fila["FechaVenta"] = fecha;
            fila["Producto"] = Producto;
            fila["Cantidad"] = cantidad; 
            tabla.Rows.Add(fila);
            OleDbCommandBuilder cb = new OleDbCommandBuilder(adaptador);
            adaptador.Update(tabla);
            ok = true;
            return ok;
        }
    }
    
}
