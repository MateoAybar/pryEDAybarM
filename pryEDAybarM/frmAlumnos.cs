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
        // instancia para manejar archivo de texto (usa los procedimientos ya existentes)
        clsArchivoTexto Archivo = new clsArchivoTexto();
        public frmAlumnos()
        {
            InitializeComponent();
            // suscribir el evento del botón aquí (el diseñador no lo asignó)
            this.btnGrabar.Click += new EventHandler(this.btnGrabar_Click);
        }

        private void frmAlumnos_Load(object sender, EventArgs e)
        {
            // al cargar el formulario, mostrar los registros en la grilla
            try
            {
                Archivo.Recorrer(this.dgvCarreras);
            }
            catch (Exception)
            {
                // si no existe el archivo aún, no hacer nada
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            // obtener datos desde los controles
            string codigo = txtCodigo.Text.Trim();
            string nombre = txtNombre.Text.Trim();
            string carrera = (lstCarreras.SelectedItem != null) ? lstCarreras.SelectedItem.ToString() : string.Empty;

            // validaciones simples
            if (string.IsNullOrEmpty(codigo) || string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(carrera))
            {
                MessageBox.Show("Complete Código, Nombre y Carrera antes de grabar.", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // usar el procedimiento existente que graba 3 datos
                Archivo.Grabar(codigo, nombre, carrera);
                MessageBox.Show("Se grabó correctamente.", "Grabado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // refrescar la grilla para mostrar el nuevo registro
                Archivo.Recorrer(this.dgvCarreras);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al grabar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
