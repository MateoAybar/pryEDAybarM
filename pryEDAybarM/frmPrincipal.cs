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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDatosDesarrollador x = new frmDatosDesarrollador();
            x.ShowDialog();
            
        }

        private void programacònToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void coloresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmColores x = new frmColores();
            x.ShowDialog();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClientes x = new frmClientes();  
            x.ShowDialog();
        }

        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAlumnos x = new frmAlumnos();
            x.ShowDialog();
        }

        private void mesesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMeses x = new frmMeses();
            x.ShowDialog();
        }

        private void carrerasToolStripMenuItem_Click(object sender, EventArgs e)
        { 
        
        }
           

        private void colaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCola x = new frmCola();
            x.ShowDialog();
        }

        private void pilaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPila x = new frmPila();
            x.ShowDialog();
        }

        private void estrucutraDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listaSimpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListaSimple x = new frmListaSimple();    
            x.ShowDialog();
        }

        private void listaDobleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListaDoble x = new frmListaDoble();  
            x.ShowDialog();
        }

        private void arbolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmArbol x = new frmArbol();
            x.ShowDialog();
        }

        private void grafoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGrafo x = new frmGrafo();
            x.ShowDialog();
        }

        private void consultaDeUnaTablaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultasBaseDatos x = new frmConsultasBaseDatos();
            x.ShowDialog();
        }

        private void consultaDeBaseDeDaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBaseDatos x = new frmBaseDatos();
            x.ShowDialog();
        }

        private void repasoDeOperacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRepasoOperacionesBaseDatos x = new frmRepasoOperacionesBaseDatos();
            x.ShowDialog();
        }
