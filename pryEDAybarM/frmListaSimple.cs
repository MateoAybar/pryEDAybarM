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
    public partial class frmListaSimple : Form
    {
        clsListaSimple Lista = new clsListaSimple();
        public frmListaSimple()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmListaSimple_Load(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo nuevo = new clsNodo();
            nuevo.Codigo = Convert.ToInt32(txtCodigo.Text);
            nuevo.Nombre = txtNombre.Text;
            nuevo.Tramite = txtTramite.Text;

            Lista.Agregar(nuevo);
           // Lista.Recorrer(dvgLista);
            Lista.Recorrer(lstLista);
            Lista.Recorrer();

            lblCodigo.Text = "";
            lblNombre.Text = "";
            lblTramite.Text = "";
        }
    }
}
