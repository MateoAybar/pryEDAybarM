using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEDAybarM
{
    public partial class frmRepasoOperacionesBaseDatos : Form
    {
        public frmRepasoOperacionesBaseDatos()
        {
            InitializeComponent();
            InicializarComboBox();
        }

        private void InicializarComboBox()
        {
            cmbOperaciones.Items.Add("Proyección simple");
            cmbOperaciones.Items.Add("Proyección multiatributo");
            cmbOperaciones.Items.Add("Juntar");
            cmbOperaciones.Items.Add("Selección simple");
            cmbOperaciones.Items.Add("Selección multiatributo");
            cmbOperaciones.Items.Add("Selección por convolución");
            cmbOperaciones.Items.Add("Unión");
            cmbOperaciones.Items.Add("Intersección");
            cmbOperaciones.Items.Add("Diferencia");
            cmbOperaciones.Items.Add("Proyección País");
            cmbOperaciones.Items.Add("Proyección Idioma");
            cmbOperaciones.SelectedIndex = 0;
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            if (cmbOperaciones.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor seleccione una operación");
                return;
            }

            string sql = "";

            switch (cmbOperaciones.SelectedIndex)
            {
                case 0: // Proyección simple
                    sql = "SELECT Titulo FROM Libros";
                    break;
                case 1: // Proyección multiatributo
                    sql = "SELECT Titulo, Autor, Precio FROM Libros";
                    break;
                case 2: // Juntar
                    sql = "SELECT * FROM Libros INNER JOIN Autores ON Libros.IdAutor = Autores.Id";
                    break;
                case 3: // Selección simple
                    sql = "SELECT * FROM Libros WHERE Precio > 100";
                    break;
                case 4: // Selección multiatributo
                    sql = "SELECT * FROM Libros WHERE Precio > 100 AND IdAutor = 1";
                    break;
                case 5: // Selección por convolución
                    sql = "SELECT * FROM Libros WHERE Titulo LIKE '%A%'";
                    break;
                case 6: // Unión
                    sql = "SELECT Nombre FROM Autores UNION SELECT Nombre FROM Editoriales";
                    break;
                case 7: // Intersección (simulada en Access)
                    sql = "SELECT Nombre FROM Autores WHERE Nombre IN (SELECT Nombre FROM Clientes)";
                    break;
                case 8: // Diferencia (simulada en Access)
                    sql = "SELECT Nombre FROM Autores WHERE Nombre NOT IN (SELECT Nombre FROM Clientes)";
                    break;
                case 9: // Proyección País
                    sql = "SELECT IdPais, Nombre FROM Pais";
                    break;
                case 10: // Proyección Idioma
                    sql = "SELECT IdIdioma, Nombre FROM Idioma";
                    break;
            }

            txtConsulta.Text = sql;
            
            clsConexion objConexion = new clsConexion();
            objConexion.Listar(dgvResultados, sql);
        }
    }
}
