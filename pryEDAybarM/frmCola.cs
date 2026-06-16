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
    public partial class frmCola : Form
    {
        public frmCola()
        {
            InitializeComponent();
        }

        private void lblListado_Click(object sender, EventArgs e)
        {

        }

        private void lblCodigoM_Click(object sender, EventArgs e)
        {

        }

        clsCola fila = new clsCola();

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            clsNodo n = new clsNodo();
            n.Nombre = (txtNombre.Text);
            n.Tramite = (txtTramite.Text);

            if (!int.TryParse(txtCodigo.Text.Trim(), out int codigo))
            {
                MessageBox.Show("Ingrese un código numérico válido.", "Entrada inválida",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodigo.Focus();
                return;
            }

            n.Codigo = Convert.ToInt32(txtCodigo.Text);

            fila.Agregar(n);
            fila.Recorrer(dvgCola);
            fila.Recorrer(lstCola);

            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (fila.Primero != null)
            {
                lblCodigoM.Text = fila.Primero.Codigo.ToString();
                lblNombreM.Text = fila.Primero.Nombre;
                lblTramiteM.Text = fila.Primero.Tramite;
                fila.Eliminar();
                fila.Recorrer(dvgCola);
                fila.Recorrer(lstCola);
                fila.Recorrer();
            }
            else
            {
                lblCodigoM.Text = "";
                lblNombreM.Text = "";
                lblTramiteM.Text = "";
                MessageBox.Show("La fila esta vacia");
            }

        }

        private void frmCola_Load(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {

        }
    }
}
