using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEDAybarM
{

    class clsListaDoble
    {
        private clsNodo pri;
        private clsNodo ult;

        public clsNodo Primero
        {
            get { return pri; }
            set { pri = value; }
        }

        public clsNodo Ultimo
        {
            get { return ult; }
            set { ult = value; }
        }

        public void Agregar(clsNodo Nvo)
        {
            if (Nvo.Codigo < Primero.Codigo)
            {
                Nvo.Siguiente = Primero;
                Primero.Anterior = Nvo;
                Primero = Nvo;
            }
            else if (Nvo.Codigo > Ultimo.Codigo)
            {
                Ultimo.Siguiente = Nvo;
                Nvo.Anterior = Ultimo;
                Ultimo = Nvo;
            }
            else
            {
                clsNodo aux = Primero;
                clsNodo ant = Primero;
                while (aux.Codigo < Nvo.Codigo)
                {
                    ant = aux;
                    aux = aux.Siguiente;
                }
                Nvo.Siguiente = aux;
                Nvo.Anterior = ant;
                ant.Siguiente = Nvo;
                aux.Anterior = Nvo;
            }
        }

        public void Recorrer(ListBox ListaDoble)
        {
            clsNodo aux = Primero;
            ListaDoble.Items.Clear();
            while (aux != null)
            {
                ListaDoble.Items.Add(aux.Codigo);
                aux = aux.Siguiente;
            }

        }

        public void Recorrer(DataGridView dvgListaDoble)
        {
            clsNodo aux = Primero;

            if (dvgListaDoble.Columns.Count == 0)
            {
                dvgListaDoble.Columns.Add("Codigo", "Codigo");
                dvgListaDoble.Columns.Add("Nombre", "Nombre");
                dvgListaDoble.Columns.Add("Tramite", "Tramite");
            }

            dvgListaDoble.Rows.Clear();
            while (aux != null)
            {
                dvgListaDoble.Rows.Add(aux.Codigo, aux.Nombre, aux.Tramite);
                aux = aux.Siguiente;
            }
        }

        public void Eliminar(Int32 Cod)
        {
            if (Primero.Codigo == Cod)
            {
                Primero = Primero.Siguiente;
                if (Primero != null) Primero.Anterior = null;
            }
            else if (Ultimo.Codigo == Cod)
            {
                Ultimo = Ultimo.Anterior;
                if (Ultimo != null) Ultimo.Siguiente = null;
            }
            else
            {
                clsNodo aux = Primero;
                clsNodo ant = Primero;
                while (aux.Codigo < Cod)
                {
                    ant = aux;
                    aux = aux.Siguiente;
                }
                if (aux != null && aux.Codigo == Cod)
                {
                    ant.Siguiente = aux.Siguiente;
                    if (aux.Siguiente != null) aux.Siguiente.Anterior = ant;
                }
            }

        }
    }
}
    
