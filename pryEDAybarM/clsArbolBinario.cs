using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEDAybarM
{
    internal class clsArbolBinario
    {
        private clsNodo PrimerNodo;

        public clsNodo Raiz
        {
            get { return PrimerNodo; }
            set { PrimerNodo = value; }
        }

        public void Agregar(clsNodo Nvo)
        {
            if (Raiz == null)
            {
                Raiz = Nvo;
            }
            else
            {
                clsNodo Ant = Raiz;
                clsNodo Aux = Raiz;
                while (Aux != null)
                {
                    Ant = Aux;
                    if (Nvo.Codigo < Aux.Codigo) Aux = Aux.Izquierdo;
                    else Aux = Aux.Derecho;
                }
                if (Nvo.Codigo < Ant.Codigo) Ant.Izquierdo = Nvo;
                else Ant.Derecho = Nvo;
            }
        }
        public void Recorrer(DataGridView Grilla) 
        {
            Grilla.Rows.Clear();
            InOrdenAsc(Grilla, Raiz);
        
        }
        public void InOrdenAsc(DataGridView Dvg, clsNodo R) 
        { 
            if(R.Izquierdo != null) InOrdenAsc(Dvg, R.Izquierdo);
            Dvg.Rows.Add(R.Codigo, R.Nombre, R.Tramite);
            if(R.Derecho != null) InOrdenAsc(Dvg, R.Derecho);
        }
        public void Recorrer(TreeView tree) 
        {
            tree.Nodes.Clear();
            TreeNode NodoPadre = new TreeNode("Arbol");
            tree.Nodes.Add(NodoPadre);
            PreOrden(Raiz, NodoPadre);
            tree.ExpandAll();
        
        }
        public void PreOrden(clsNodo R, TreeNode nodoTreeView) 
        { 
            TreeNode NodoPadre = new TreeNode(R.Codigo.ToString());
            nodoTreeView.Nodes.Add(NodoPadre);
            if(R.Izquierdo !=null) PreOrden(R.Izquierdo, NodoPadre);
            if (R.Derecho != null) PreOrden(R.Derecho, NodoPadre);
        }

        
        public void Recorrer(ComboBox cmb)
        {
            cmb.Items.Clear();
            InOrdenComboBox(cmb, Raiz);
        }

        public void InOrdenComboBox(ComboBox cmb, clsNodo R)
        {
            if (R == null) return;
            if (R.Izquierdo != null) InOrdenComboBox(cmb, R.Izquierdo);
            cmb.Items.Add(R.Codigo + " - " + R.Nombre);
            if (R.Derecho != null) InOrdenComboBox(cmb, R.Derecho);
        }

        
        public int[] RecorridoInOrdenVector()
        {
            List<int> lista = new List<int>();
            InOrdenVector(Raiz, lista);
            return lista.ToArray();
        }

        public void InOrdenVector(clsNodo R, List<int> lista)
        {
            if (R == null) return;
            if (R.Izquierdo != null) InOrdenVector(R.Izquierdo, lista);
            lista.Add(R.Codigo);
            if (R.Derecho != null) InOrdenVector(R.Derecho, lista);
        }


        public void RecorridoPreOrden(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            PreOrdenGrilla(Grilla, Raiz);
        }

        public void PreOrdenGrilla(DataGridView Dvg, clsNodo R)
        {
            if (R == null) return;
            Dvg.Rows.Add(R.Codigo, R.Nombre, R.Tramite);
            if (R.Izquierdo != null) PreOrdenGrilla(Dvg, R.Izquierdo);
            if (R.Derecho != null) PreOrdenGrilla(Dvg, R.Derecho);
        }

        
        public void RecorridoPostOrden(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            PostOrdenGrilla(Grilla, Raiz);
        }

        public void PostOrdenGrilla(DataGridView Dvg, clsNodo R)
        {
            if (R == null) return;
            if (R.Izquierdo != null) PostOrdenGrilla(Dvg, R.Izquierdo);
            if (R.Derecho != null) PostOrdenGrilla(Dvg, R.Derecho);
            Dvg.Rows.Add(R.Codigo, R.Nombre, R.Tramite);
        }
    }
}
