using pryEDAybarM;
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
        clsListaDoble miListaCientifica = new clsListaDoble();
        public frmListaDoble()
        {
            InitializeComponent();
        }
        clsListaDoble Lista = new clsListaDoble();
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo nuevo = new clsNodo();

            nuevo.Nombre = txtNombre.Text;
            nuevo.Codigo = Convert.ToInt32(txtCodigo.Text);
            cmbListaDoble.Items.Add(nuevo.Codigo);
            nuevo.Tramite = txtTramite.Text;

            Lista.Agregar(nuevo);
            Lista.Recorrer(dvgListaDoble);
            Lista.Recorrer(lstListaDoble);

            txtCodigo.Clear();
            txtNombre.Clear();
            txtTramite.Clear();
            txtCodigo.Focus();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (Lista.Primero != null)
            {
                Int32 codigo = Convert.ToInt32(cmbListaDoble.Text);
                Lista.Eliminar(codigo);
                Lista.Recorrer(dgvListaDoble);
                Lista.Recorrer(lstListaDoble);
                Lista.Recorrer();

                cmbLista.Items.Remove(codigo);
                cmbLista.Focus();
                btnBorrar.Enabled = false;
            }
        }


        private void rdbDescendente_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbDescendente.Checked)
            {
                Lista.RecorrerDes(dgvListaDoble);
                Lista.RecorrerDes(lstListaDoble);
            }
            else
            {
                Lista.Recorrer(dgvListaDoble);
                Lista.Recorrer(lstListaDoble);
            }
        }

        private void cmbLista_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnBorrar.Enabled = true;
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            if (txtCodigo.Text != "" && txtNombre.Text != "" && txtTramite.Text != "")
            {
                btnAgregar.Enabled = true;
            }
            else
            {
                btnAgregar.Enabled = false;
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (txtCodigo.Text != "" && txtNombre.Text != "" && txtTramite.Text != "")
            {
                btnAgregar.Enabled = true;
            }
            else
            {
                btnAgregar.Enabled = false;
            }
        }

        private void txtTramite_TextChanged(object sender, EventArgs e)
        {
            if (txtCodigo.Text != "" && txtNombre.Text != "" && txtTramite.Text != "")
            {
                btnAgregar.Enabled = true;
            }
            else
            {
                btnAgregar.Enabled = false;
            }
        }
    }
}


