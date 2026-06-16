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
            cmbOperaciones.Items.Clear();

            cmbOperaciones.Items.Add("ProyecciÃ³n simple â€” Solo Nombre de Pais");
            cmbOperaciones.Items.Add("ProyecciÃ³n multiatributo â€” IdPais y Nombre");
            cmbOperaciones.Items.Add("Juntar â€” Libro con Pais por IdPais");
            cmbOperaciones.Items.Add("SelecciÃ³n simple â€” Idioma con IdIdioma = 1");
            cmbOperaciones.Items.Add("SelecciÃ³n multiatributo â€” Pais donde IdPais > 1 y Nombre contiene 'U'");
            cmbOperaciones.Items.Add("SelecciÃ³n por convoluciÃ³n â€” Pais cuyo Nombre empieza con 'R'");
            cmbOperaciones.Items.Add("UniÃ³n â€” Nombres de Pais e Idioma");
            cmbOperaciones.Items.Add("IntersecciÃ³n â€” Nombres en Pais que tambiÃ©n estÃ¡n en Idioma");
            cmbOperaciones.Items.Add("Diferencia â€” Nombres en Pais que NO estÃ¡n en Idioma");
            cmbOperaciones.Items.Add("ProyecciÃ³n PaÃ­s â€” Todos los PaÃ­ses");
            cmbOperaciones.Items.Add("ProyecciÃ³n Idioma â€” Todos los Idiomas");

            cmbOperaciones.SelectedIndex = 0;
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            if (cmbOperaciones.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor seleccione una operaciÃ³n.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sql = "";

            switch (cmbOperaciones.SelectedIndex)
            {
                case 0:
                    sql = "SELECT Nombre FROM Pais";
                    break;
                case 1:
                    sql = "SELECT IdPais, Nombre FROM Pais";
                    break;
                case 2:
                    sql = "SELECT Libro.*, Pais.Nombre AS NombrePais FROM Libro INNER JOIN Pais ON Libro.IdPais = Pais.IdPais";
                    break;
                case 3:
                    sql = "SELECT * FROM Idioma WHERE IdIdioma = 1";
                    break;
                case 4:
                    sql = "SELECT * FROM Pais WHERE IdPais > 1 AND Nombre LIKE '%U%'";
                    break;
                case 5:
                    sql = "SELECT * FROM Pais WHERE Nombre LIKE 'R%'";
                    break;
                case 6:
                    sql = "SELECT Nombre FROM Pais UNION SELECT Nombre FROM Idioma";
                    break;
                case 7:
                    sql = "SELECT Nombre FROM Pais WHERE Nombre IN (SELECT Nombre FROM Idioma)";
                    break;
                case 8:
                    sql = "SELECT Nombre FROM Pais WHERE Nombre NOT IN (SELECT Nombre FROM Idioma)";
                    break;
                case 9:
                    sql = "SELECT IdPais, Nombre FROM Pais";
                    break;
                case 10:
                    sql = "SELECT IdIdioma, Nombre FROM Idioma";
                    break;
            }

            txtConsulta.Text = sql;
            new clsConexion().Listar(dgvResultados, sql);
        }
    }
}
