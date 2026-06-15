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
            new clsConexion().Listar(dgvResultados, "SELECT Titulo FROM Libro");
        }

        private void btnProyeccionMultiatributo_Click(object sender, EventArgs e)
        {
            new clsConexion().Listar(dgvResultados, "SELECT Titulo, Autor, Precio FROM Libro");
        }

        private void btnJuntar_Click(object sender, EventArgs e)
        {
            new clsConexion().Listar(dgvResultados, "SELECT * FROM Libro INNER JOIN Autor ON Libro.IdAutor = Autor.Id");
        }

        private void btnSeleccionSimple_Click(object sender, EventArgs e)
        {
            new clsConexion().Listar(dgvResultados, "SELECT * FROM Libro WHERE Precio > 100");
        }

        private void btnSeleccionMultiatributo_Click(object sender, EventArgs e)
        {
            new clsConexion().Listar(dgvResultados, "SELECT * FROM Libro WHERE Precio > 100 AND IdAutor = 1");
        }

        private void btnSeleccionConvolucion_Click(object sender, EventArgs e)
        {
            new clsConexion().Listar(dgvResultados, "SELECT * FROM Libro WHERE Titulo LIKE '%A%'");
        }

        private void btnUnion_Click(object sender, EventArgs e)
        {
            new clsConexion().Listar(dgvResultados, "SELECT Nombre FROM Autor UNION SELECT Nombre FROM Editoriales");
        }

        private void btnInterseccion_Click(object sender, EventArgs e)
        {
            new clsConexion().Listar(dgvResultados, "SELECT Nombre FROM Autor WHERE Nombre IN (SELECT Nombre FROM Clientes)");
        }

        private void btnDiferencia_Click(object sender, EventArgs e)
        {
            new clsConexion().Listar(dgvResultados, "SELECT Nombre FROM Autor WHERE Nombre NOT IN (SELECT Nombre FROM Clientes)");
        }
    }
}
