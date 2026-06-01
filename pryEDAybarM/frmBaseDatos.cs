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
    public partial class frmBaseDatos : Form
    {
        public frmBaseDatos()
        {
            InitializeComponent();
        }

        private void btnProyeccionSimple_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Proyección simple ejecutada");
        }

        private void btnProyeccionMultiatributo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Proyección multiatributo ejecutada");
        }

        private void btnJuntar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Operación Juntar ejecutada");
        }

        private void btnSeleccionSimple_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Selección simple ejecutada");
        }

        private void btnSeleccionMultiatributo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Selección multiatributo ejecutada");
        }

        private void btnSeleccionConvolucion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Selección por convolución ejecutada");
        }

        private void btnUnion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Operación Unión ejecutada");
        }

        private void btnInterseccion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Operación Intersección ejecutada");
        }

        private void btnDiferencia_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Operación Diferencia ejecutada");
        }
    }
}
