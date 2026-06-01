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
    public partial class frmRepasoOperacionesBaseDatos : Form
    {
        public frmRepasoOperacionesBaseDatos()
        {
            InitializeComponent();
            InicializarComboBox();
        }

        private void InicializarComboBox()
        {
            cmbOperaciones.Items.Add("Proyección simple");
            cmbOperaciones.Items.Add("Proyección multiatributo");
            cmbOperaciones.Items.Add("Juntar");
            cmbOperaciones.Items.Add("Selección simple");
            cmbOperaciones.Items.Add("Selección multiatributo");
            cmbOperaciones.Items.Add("Selección por convolución");
            cmbOperaciones.Items.Add("Unión");
            cmbOperaciones.Items.Add("Intersección");
            cmbOperaciones.Items.Add("Diferencia");
            cmbOperaciones.SelectedIndex = 0;
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            if (cmbOperaciones.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor seleccione una operación");
                return;
            }

            string operacion = cmbOperaciones.SelectedItem.ToString();
            MessageBox.Show($"Ejecutando: {operacion}");

            // Limpiar y poblar la grilla según la operación seleccionada
            dgvResultados.Rows.Clear();
            dgvResultados.Columns.Clear();
        }
    }
}
