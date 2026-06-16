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
    public partial class frmArbol : Form
    {
        clsArbolBinario arbol = new clsArbolBinario();

        public frmArbol()
        {
            InitializeComponent();

            this.Load                          += frmArbol_Load;
            this.btnAgregar.Click              += btnAgregar_Click;
            this.btnEliminar.Click             += btnEliminar_Click;
            this.btnEquilibrar.Click           += btnEquilibrar_Click;
            this.rdbInorden.CheckedChanged     += rdbInorden_CheckedChanged;
            this.rdbpreorden.CheckedChanged    += rdbpreorden_CheckedChanged;
            this.rdbpPostorden.CheckedChanged  += rdbpPostorden_CheckedChanged;
        }

        private void frmArbol_Load(object sender, EventArgs e)
        {
            if (dvgArbol.Columns.Count == 0)
            {
                dvgArbol.Columns.Add("Codigo",  "Codigo");
                dvgArbol.Columns.Add("Nombre",  "Nombre");
                dvgArbol.Columns.Add("Tramite", "Tramite");
            }
            rdbInorden.Checked = true;
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
                arbol.Agregar(nvo);
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
                MessageBox.Show("SeleccionÃ¡ un nodo del combo para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (arbol.Raiz == null)
            {
                MessageBox.Show("El Ã¡rbol estÃ¡ vacÃ­o.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string seleccionado = cmbCodigo.SelectedItem.ToString();
                int cod = int.Parse(seleccionado.Split('-')[0].Trim());

                arbol.Raiz = EliminarRecursivo(arbol.Raiz, cod);
                Recorrer();
                ActualizarCombo();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private clsNodo EliminarRecursivo(clsNodo nodo, int cod)
        {
            if (nodo == null) return null;

            if (cod < nodo.Codigo)
                nodo.Izquierdo = EliminarRecursivo(nodo.Izquierdo, cod);
            else if (cod > nodo.Codigo)
                nodo.Derecho = EliminarRecursivo(nodo.Derecho, cod);
            else
            {
                if (nodo.Izquierdo == null) return nodo.Derecho;
                if (nodo.Derecho   == null) return nodo.Izquierdo;

                clsNodo minimo = MinimoDerecho(nodo.Derecho);
                nodo.Codigo  = minimo.Codigo;
                nodo.Nombre  = minimo.Nombre;
                nodo.Tramite = minimo.Tramite;
                nodo.Derecho = EliminarRecursivo(nodo.Derecho, minimo.Codigo);
            }
            return nodo;
        }

        private clsNodo MinimoDerecho(clsNodo nodo)
        {
            while (nodo.Izquierdo != null)
                nodo = nodo.Izquierdo;
            return nodo;
        }

        private void btnEquilibrar_Click(object sender, EventArgs e)
        {
            if (arbol.Raiz == null)
            {
                MessageBox.Show("El Ã¡rbol estÃ¡ vacÃ­o.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<clsNodo> nodos = new List<clsNodo>();
            RecolectarNodos(arbol.Raiz, nodos);
            nodos = nodos.OrderBy(n => n.Codigo).ToList();

            arbol.Raiz = null;
            InsertarEquilibrado(nodos, 0, nodos.Count - 1);

            Recorrer();
            ActualizarCombo();
        }

        private void RecolectarNodos(clsNodo nodo, List<clsNodo> lista)
        {
            if (nodo == null) return;
            RecolectarNodos(nodo.Izquierdo, lista);
            lista.Add(nodo);
            RecolectarNodos(nodo.Derecho, lista);
        }

        private void InsertarEquilibrado(List<clsNodo> nodos, int inicio, int fin)
        {
            if (inicio > fin) return;
            int medio = (inicio + fin) / 2;

            clsNodo nvo = new clsNodo();
            nvo.Codigo  = nodos[medio].Codigo;
            nvo.Nombre  = nodos[medio].Nombre;
            nvo.Tramite = nodos[medio].Tramite;
            arbol.Agregar(nvo);

            InsertarEquilibrado(nodos, inicio, medio - 1);
            InsertarEquilibrado(nodos, medio + 1, fin);
        }

        private void Recorrer()
        {
            if (arbol.Raiz == null) return;

            if (rdbInorden.Checked)
                arbol.Recorrer(dvgArbol);
            else if (rdbpreorden.Checked)
                arbol.RecorridoPreOrden(dvgArbol);
            else if (rdbpPostorden.Checked)
                arbol.RecorridoPostOrden(dvgArbol);

            arbol.Recorrer(trvArbol);
        }

        private void ActualizarCombo()
        {
            arbol.Recorrer(cmbCodigo);
        }

        private void rdbInorden_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbInorden.Checked) Recorrer();
        }

        private void rdbpreorden_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbpreorden.Checked) Recorrer();
        }

        private void rdbpPostorden_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbpPostorden.Checked) Recorrer();
        }
    }
}
