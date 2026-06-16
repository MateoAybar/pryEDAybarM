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
    public partial class frmPila : Form
    {
        public frmPila()
        {
            InitializeComponent();
        }

        clsPila Pila = new clsPila();
        private void btnAgregar_Click(object sender, EventArgs e)
        {

            clsNodo nuevo = new clsNodo();
            nuevo.Codigo = Convert.ToInt32(txtCodigo.Text);
            nuevo.Nombre = txtNombre.Text;
            nuevo.Tramite = txtTramite.Text;

            Pila.Agregar(nuevo);
            Pila.Recorrer(dvgPila);
            Pila.Recorrer(lstPila);
            Pila.Recorrer("ArchivoPila.csv");

            lblCodigoM.Text = "";
            lblNombreM.Text = "";
            lblTramiteM.Text = "";

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Pila.Primero != null)
            {
                lblCodigoM.Text = Pila.Primero.Codigo.ToString();
                lblNombreM.Text = Pila.Primero.Nombre;
                lblTramiteM.Text = Pila.Primero.Tramite;
                Pila.Eliminar();
                Pila.Recorrer(dvgPila);
                Pila.Recorrer(lstPila);
                Pila.Recorrer("ArchivoPila.csv");
            }
            else 
            {
                lblCodigoM.Text = "";
                lblNombreM.Text = "";
                lblTramiteM.Text = "";

            }
        }

        private void frmPila_Load(object sender, EventArgs e)
        {

        }
    }
}
