using System;
using System.Collections;
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
    public partial class frmListaDoble : Form
    {
        clsListaDoble ListaDoble = new clsListaDoble();
        public frmListaDoble()
        {
            InitializeComponent();
        }

        private void pcb1_Click(object sender, EventArgs e)
        {

        }

        private void dvgCola_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmListaDoble_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo nuevo = new clsNodo();
            nuevo.Codigo = Convert.ToInt32(txtCodigo.Text);
            nuevo.Nombre = txtNombre.Text;
            nuevo.Tramite = txtTramite.Text;

            ListaDoble.Agregar(nuevo);
            ListaDoble.Recorrer(lstListaDoble);
            ListaDoble.Recorrer(dvgListaDoble);

            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";

            cmbCodigo.Items.Add(nuevo.Codigo);
        }
    }
    
}
