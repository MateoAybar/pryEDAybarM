using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Runtime.InteropServices.ComTypes;  //ESPACIO DE NOMBRES PARA ARCHIVOS  


namespace pryEDAybarM
{
    internal class clsArchivoTexto
    {

        public String NomArchi = "Colores.txt"; //NOMBRE DEL ARCHIVO DE TEXTO




        public void Grabar()
        {
            using (var AD = new StreamWriter(NomArchi, true)) // append
            {
                AD.WriteLine("ROJO"); //GRABA EN EL ARCHIVO DE TEXTO
            }
        }
        public void Grabar(String Dato)
        {
            using (var AD = new StreamWriter(NomArchi, true)) // append
            {
                AD.WriteLine(Dato); //GRABA EN EL ARCHIVO DE TEXTO
            }
        }
        public void Grabar(String Nombre, String Codigo)
        {
            // escribir en una sola linea: Codigo;Nombre
            using (var AD = new StreamWriter(NomArchi, true))
            {
                AD.WriteLine($"{Codigo};{Nombre}");
            }
        }





        public void Recorrer(ListBox lst)
        {
            String DatoLeido; //VARIABLE PARA LEER EL DATO DEL ARCHIVO DE TEXTO 
            lst.Items.Clear(); //LIMPIA EL LISTBOX ANTES DE RECORRER EL ARCHIVO DE TEXTO
            if (!File.Exists(NomArchi)) return;
            using (var AD = new StreamReader(NomArchi)) //CREA EL OBJETO PARA LEER EL ARCHIVO DE TEXTO
            {
                DatoLeido = AD.ReadLine(); //LEE EL PRIMER DATO DEL ARCHIVO DE TEXTO
                while (DatoLeido != null)
                {
                    lst.Items.Add(DatoLeido); //AGREGA EL DATO LEIDO AL LISTBOX
                    DatoLeido = AD.ReadLine(); //LEE EL SIGUIENTE DATO DEL ARCHIVO DE TEXTO
                }
            }
        }

        public void Grabar(String Dato1, String Dato2, String Dato3)
        {
            // escribir en formato Codigo;Nombre;Carrera en una linea y en modo append
            using (var AD = new StreamWriter(NomArchi, true))
            {
                AD.Write(Dato1);
                AD.Write(";");
                AD.Write(Dato2);
                AD.Write(";");
                AD.WriteLine(Dato3);
            }
        }


        public void Recorrer(ComboBox lst)
        {
            String DatoLeido; //VARIABLE PARA LEER EL DATO DEL ARCHIVO DE TEXTO 
            lst.Items.Clear(); //LIMPIA EL LISTBOX ANTES DE RECORRER EL ARCHIVO DE TEXTO
            if (!File.Exists(NomArchi)) return;
            using (var AD = new StreamReader(NomArchi)) //CREA EL OBJETO PARA LEER EL ARCHIVO DE TEXTO
            {
                DatoLeido = AD.ReadLine(); //LEE EL PRIMER DATO DEL ARCHIVO DE TEXTO
                while (DatoLeido != null)
                {
                    lst.Items.Add(DatoLeido); //AGREGA EL DATO LEIDO AL LISTBOX
                    DatoLeido = AD.ReadLine(); //LEE EL SIGUIENTE DATO DEL ARCHIVO DE TEXTO
                }
            }
            if (lst.Items.Count > 0) lst.SelectedIndex = 0; //SELECCIONA EL PRIMER ITEM DEL COMBOBOX
        }
        public void Recorrer(DataGridView Grilla)
        {
            String DatoLeido; //VARIABLE PARA LEER EL DATO DEL ARCHIVO DE TEXTO 
            Grilla.Rows.Clear(); //LIMPIA EL LISTBOX ANTES DE RECORRER EL ARCHIVO DE TEXTO
            if (!File.Exists(NomArchi)) return;

            // Asegurar que la grilla tenga columnas para Codigo, Nombre, Carrera
            if (Grilla.Columns.Count < 3)
            {
                Grilla.Columns.Clear();
                Grilla.Columns.Add("Codigo", "Codigo");
                Grilla.Columns.Add("Nombre", "Nombre");
                Grilla.Columns.Add("Carrera", "Carrera");
            }

            using (var AD = new StreamReader(NomArchi)) //CREA EL OBJETO PARA LEER EL ARCHIVO DE TEXTO
            {
                DatoLeido = AD.ReadLine(); //LEE EL PRIMER DATO DEL ARCHIVO DE TEXTO
                while (DatoLeido != null)
                {
                    var partes = DatoLeido.Split(new[] { ';' });
                    if (partes.Length >= 3)
                    {
                        Grilla.Rows.Add(partes[0], partes[1], partes[2]);
                    }
                    else
                    {
                        // si la linea tiene formato diferente, añadir como única celda
                        Grilla.Rows.Add(DatoLeido);
                    }
                    DatoLeido = AD.ReadLine(); //LEE EL SIGUIENTE DATO DEL ARCHIVO DE TEXTO
                }
            }
        }


    }

}