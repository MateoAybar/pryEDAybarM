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
    public partial class frmConsultasBaseDatos : Form
    {
        public frmConsultasBaseDatos()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtConsultaSQL.Text))
            {
                MessageBox.Show("Por favor ingrese una consulta SQL");
                return;
            }

            clsConexion objConexion = new clsConexion();
            objConexion.Listar(dgvResultados, txtConsultaSQL.Text);
        }
    }
}
