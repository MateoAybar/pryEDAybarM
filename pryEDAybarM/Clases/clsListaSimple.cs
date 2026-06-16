using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pryEDAybarM
{

    internal class clsListaSimple
    {

        private clsNodo pri;
        public clsNodo Primero
        {
            get { return pri; }
            set { pri = value; }

        }

        public void Agregar(clsNodo Nuevo)
        {
            if (Primero == null)
            {
                Primero = Nuevo;
            }
            else
            {
                if (Nuevo.Codigo <= Primero.Codigo)
                {

                    Nuevo.Siguiente = Primero;
                    Primero = Nuevo;

                }
                else
                {
                    clsNodo aux = Primero;
                    clsNodo ant = Primero;

                    while (Nuevo.Codigo > aux.Codigo)
                    {
                        ant = aux;
                        aux = aux.Siguiente;
                        if (aux == null) break;
                    }
                    Nuevo.Siguiente = aux;
                    ant.Siguiente = Nuevo;
                }

            }
        }

        public void Eliminar(int Codigo)
        {
            if (Primero != null)
            {
                if (Primero.Codigo == Codigo)
                {
                    Primero = Primero.Siguiente;
                }
                else
                {
                    clsNodo aux = Primero;
                    clsNodo ant = Primero;
                    while (Codigo != aux.Codigo)
                    {
                        ant = aux;
                        aux = aux.Siguiente;
                        if (aux == null) break;
                    }
                    if (aux != null)
                    {
                        ant.Siguiente = aux.Siguiente;
                    }
                }
            }
        }
        public void Recorrer(ListBox ListaSimple)
        {
            clsNodo aux = Primero;
            ListaSimple.Items.Clear();
            while (aux != null)
            {
                ListaSimple.Items.Add(aux.Codigo);
                aux = aux.Siguiente;
            }
        }

        public void Recorrer(DataGridView dvgListaSimple)
        {
            clsNodo aux = Primero;

            if (dvgListaSimple.Columns.Count == 0)
            {
                dvgListaSimple.Columns.Add("Codigo", "Codigo");
                dvgListaSimple.Columns.Add("Nombre", "Nombre");
                dvgListaSimple.Columns.Add("Tramite", "Tramite");
            }

            dvgListaSimple.Rows.Clear();
            while (aux != null)
            {
                dvgListaSimple.Rows.Add(aux.Codigo, aux.Nombre, aux.Tramite);
                aux = aux.Siguiente;
            }
        }
    }

}
