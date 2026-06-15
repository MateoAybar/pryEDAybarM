using System;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Windows.Forms;

namespace pryEDAybarM
{
    public class clsConexion
    {
        private string CadenaConexion
        {
            get
            {
                string ruta = Path.Combine(Application.StartupPath, "Base De Datos", "Libreria.mdb");
                return @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + ruta;
            }
        }

        public void Listar(DataGridView dgv, string instruccionSQL)
        {
            OleDbConnection conexion = null;
            try
            {
                conexion = new OleDbConnection(CadenaConexion);
                conexion.Open();

                OleDbCommand comando = new OleDbCommand();
                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = instruccionSQL;

                OleDbDataAdapter adaptador = new OleDbDataAdapter(comando);
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);

                dgv.DataSource = tabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la consulta: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conexion != null && conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
        }
    }
}
