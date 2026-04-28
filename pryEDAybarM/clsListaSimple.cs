using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

    }
}
