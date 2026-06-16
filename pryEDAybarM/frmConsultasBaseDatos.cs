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
            string sql = txtConsultaSQL.Text.Trim();

            if (string.IsNullOrWhiteSpace(sql))
            {
                MessageBox.Show("Por favor ingrese una consulta SQL.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            new clsConexion().Listar(dgvResultados, sql);
        }
    }
}
