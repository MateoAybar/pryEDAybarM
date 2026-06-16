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
    public partial class frmBaseDatos : Form
    {
        public frmBaseDatos()
        {
            InitializeComponent();
        }

        private void btnProyeccionSimple_Click(object sender, EventArgs e)
        {
            new clsConexion().Listar(dgvResultados,
                "SELECT Nombre FROM Pais");
        }

        private void btnProyeccionMultiatributo_Click(object sender, EventArgs e)
        {
            new clsConexion().Listar(dgvResultados,
                "SELECT IdPais, Nombre FROM Pais");
        }

        private void btnJuntar_Click(object sender, EventArgs e)
        {
            new clsConexion().Listar(dgvResultados,
                "SELECT Libro.*, Pais.Nombre AS NombrePais " +
                "FROM Libro INNER JOIN Pais ON Libro.IdPais = Pais.IdPais");
        }

        private void btnSeleccionSimple_Click(object sender, EventArgs e)
        {
            new clsConexion().Listar(dgvResultados,
                "SELECT * FROM Idioma WHERE IdIdioma = 1");
        }

        private void btnSeleccionMultiatributo_Click(object sender, EventArgs e)
        {
            new clsConexion().Listar(dgvResultados,
                "SELECT * FROM Pais WHERE IdPais > 1 AND Nombre LIKE '%U%'");
        }

        private void btnSeleccionConvolucion_Click(object sender, EventArgs e)
        {
            new clsConexion().Listar(dgvResultados,
                "SELECT * FROM Pais WHERE Nombre LIKE 'R%'");
        }

        private void btnUnion_Click(object sender, EventArgs e)
        {
            new clsConexion().Listar(dgvResultados,
                "SELECT Nombre FROM Pais UNION SELECT Nombre FROM Idioma");
        }

        private void btnInterseccion_Click(object sender, EventArgs e)
        {
            new clsConexion().Listar(dgvResultados,
                "SELECT Nombre FROM Pais WHERE Nombre IN (SELECT Nombre FROM Idioma)");
        }

        private void btnDiferencia_Click(object sender, EventArgs e)
        {
            new clsConexion().Listar(dgvResultados,
                "SELECT Nombre FROM Pais WHERE Nombre NOT IN (SELECT Nombre FROM Idioma)");
        }
    }
}
