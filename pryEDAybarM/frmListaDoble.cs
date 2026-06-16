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
    public partial class frmListaDoble : Form
    {
        clsListaDoble lista = new clsListaDoble();

        public frmListaDoble()
        {
            InitializeComponent();

            this.Load                           += frmListaDoble_Load;
            this.btnAgregar.Click               += btnAgregar_Click;
            this.btnEliminar.Click              += btnEliminar_Click;
            this.rdbAscendentes.CheckedChanged  += rdbAscendentes_CheckedChanged;
            this.rdbDescendentes.CheckedChanged += rdbDescendentes_CheckedChanged;
        }

        private void frmListaDoble_Load(object sender, EventArgs e)
        {
            if (dvgListaDoble.Columns.Count == 0)
            {
                dvgListaDoble.Columns.Add("Codigo",  "Codigo");
                dvgListaDoble.Columns.Add("Nombre",  "Nombre");
                dvgListaDoble.Columns.Add("Tramite", "Tramite");
            }
            rdbAscendentes.Checked = true;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodigo.Text) ||
                string.IsNullOrWhiteSpace(txtNombre.Text)  ||
                string.IsNullOrWhiteSpace(txtTramite.Text))
            {
                MessageBox.Show("Por favor completÃ¡ todos los campos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtCodigo.Text, out int cod))
            {
                MessageBox.Show("El cÃ³digo debe ser un nÃºmero entero.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            clsNodo nvo = new clsNodo();
            nvo.Codigo  = cod;
            nvo.Nombre  = txtNombre.Text.Trim();
            nvo.Tramite = txtTramite.Text.Trim();

            try
            {
                if (lista.Primero == null)
                {
                    lista.Primero = nvo;
                    lista.Ultimo  = nvo;
                }
                else
                {
                    lista.Agregar(nvo);
                }

                Recorrer();
                ActualizarCombo();

                txtCodigo.Clear();
                txtNombre.Clear();
                txtTramite.Clear();
                txtCodigo.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (cmbCodigo.SelectedItem == null)
            {
                MessageBox.Show("SeleccionÃ¡ un cÃ³digo del combo para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (lista.Primero == null)
            {
                MessageBox.Show("La lista estÃ¡ vacÃ­a.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int cod = Convert.ToInt32(cmbCodigo.SelectedItem);
                lista.Eliminar(cod);
                Recorrer();
                ActualizarCombo();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Recorrer()
        {
            if (lista.Primero == null) return;

            if (rdbAscendentes.Checked)
            {
                lista.Recorrer(dvgListaDoble);
                lista.Recorrer(lstListaDoble);
            }
            else
            {
                dvgListaDoble.Rows.Clear();
                lstListaDoble.Items.Clear();
                clsNodo aux = lista.Ultimo;
                while (aux != null)
                {
                    dvgListaDoble.Rows.Add(aux.Codigo, aux.Nombre, aux.Tramite);
                    lstListaDoble.Items.Add(aux.Codigo);
                    aux = aux.Anterior;
                }
            }
        }

        private void ActualizarCombo()
        {
            cmbCodigo.Items.Clear();
            clsNodo nodo = lista.Primero;
            while (nodo != null)
            {
                cmbCodigo.Items.Add(nodo.Codigo);
                nodo = nodo.Siguiente;
            }
        }

        private void rdbAscendentes_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbAscendentes.Checked) Recorrer();
        }

        private void rdbDescendentes_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbDescendentes.Checked) Recorrer();
        }

        private void pcb1_Click(object sender, EventArgs e) { }

        private void groupBox1_Enter(object sender, EventArgs e) { }
    }
}
