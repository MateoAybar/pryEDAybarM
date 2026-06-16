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
    public partial class frmAlumnos : Form
    {
        clsArchivoTexto Archivo = new clsArchivoTexto();
        public frmAlumnos()
        {
            InitializeComponent();
            this.btnGrabar.Click += new EventHandler(this.btnGrabar_Click);
        }

        private void frmAlumnos_Load(object sender, EventArgs e)
        {
            try
            {
                Archivo.Recorrer(this.dgvCarreras);
            }
            catch (Exception)
            {
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            string codigo = txtCodigo.Text.Trim();
            string nombre = txtNombre.Text.Trim();
            string carrera = (lstCarreras.SelectedItem != null) ? lstCarreras.SelectedItem.ToString() : string.Empty;

            if (string.IsNullOrEmpty(codigo) || string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(carrera))
            {
                MessageBox.Show("Complete Código, Nombre y Carrera antes de grabar.", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Archivo.Grabar(codigo, nombre, carrera);
                MessageBox.Show("Se grabó correctamente.", "Grabado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Archivo.Recorrer(this.dgvCarreras);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al grabar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
