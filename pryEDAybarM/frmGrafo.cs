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
    public partial class frmGrafo : Form
    {
        private clsGrafo grafo;

        public frmGrafo()
        {
            InitializeComponent();
            grafo = new clsGrafo();
            InicializarForm();
        }

        private void InicializarForm()
        {
            grafo.MostrarCiudades(cmbCargaOrigen);
            grafo.MostrarCiudades(cmbCargaDestino);
            grafo.MostrarCiudades(cmbConsultaOrigen);
            grafo.MostrarCiudades(cmbConsultaDestino);
            grafo.MostrarCiudades(cmbListarDesde);
            grafo.MostrarCiudades(cmbListarHasta);
        }

        private void pnlGrafo_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            if (cmbCargaOrigen.SelectedIndex < 0 || cmbCargaDestino.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor seleccione origen y destino");
                return;
            }

            if (string.IsNullOrEmpty(txtCargaPrecio.Text))
            {
                MessageBox.Show("Por favor ingrese un precio");
                return;
            }

            if (!decimal.TryParse(txtCargaPrecio.Text, out decimal precio) || precio <= 0)
            {
                MessageBox.Show("Por favor ingrese un precio válido (mayor a 0)");
                return;
            }

            int origen = cmbCargaOrigen.SelectedIndex;
            int destino = cmbCargaDestino.SelectedIndex;

            grafo.Agregar(origen, destino, precio);

            MessageBox.Show($"Viaje cargado: {cmbCargaOrigen.SelectedItem} → {cmbCargaDestino.SelectedItem}: ${precio}");
            txtCargaPrecio.Clear();
        }

        private void btnBorrarTodo_Click(object sender, EventArgs e)
        {
            grafo.BorrarTodo();
            MessageBox.Show("Se han borrado todos los datos");
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (cmbConsultaOrigen.SelectedIndex < 0 || cmbConsultaDestino.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor seleccione origen y destino");
                return;
            }

            int origen = cmbConsultaOrigen.SelectedIndex;
            int destino = cmbConsultaDestino.SelectedIndex;

            decimal precio = grafo.Consultar(origen, destino);

            if (precio > 0)
            {
                txtConsultaPrecio.Text = precio.ToString("F2");
            }
            else
            {
                txtConsultaPrecio.Text = "No existe ruta";
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txtConsultaPrecio.Clear();
        }

        private void btnListarDestinos_Click(object sender, EventArgs e)
        {
            if (cmbListarDesde.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor seleccione una ciudad de origen");
                return;
            }

            int origen = cmbListarDesde.SelectedIndex;
            grafo.MostrarDestinos(origen, dgvViajes);
        }

        private void btnListarOrigenes_Click(object sender, EventArgs e)
        {
            if (cmbListarHasta.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor seleccione una ciudad de destino");
                return;
            }

            int destino = cmbListarHasta.SelectedIndex;
            grafo.MostrarOrigenes(destino, dgvViajes);
        }

        private void btnVerTodosViajes_Click(object sender, EventArgs e)
        {
            grafo.MostrarTodo(dgvViajes);
        }
    }
}
