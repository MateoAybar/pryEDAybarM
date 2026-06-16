using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Runtime.InteropServices.ComTypes;

namespace pryEDAybarM
{
    internal class clsArchivoTexto
    {

        public String NomArchi = "Colores.txt";

        public void Grabar()
        {
            using (var AD = new StreamWriter(NomArchi, true))
            {
                AD.WriteLine("ROJO");
            }
        }
        public void Grabar(String Dato)
        {
            using (var AD = new StreamWriter(NomArchi, true))
            {
                AD.WriteLine(Dato);
            }
        }
        public void Grabar(String Nombre, String Codigo)
        {
            using (var AD = new StreamWriter(NomArchi, true))
            {
                AD.WriteLine($"{Codigo};{Nombre}");
            }
        }

        public void Recorrer(ListBox lst)
        {
            String DatoLeido;
            lst.Items.Clear();
            if (!File.Exists(NomArchi)) return;
            using (var AD = new StreamReader(NomArchi))
            {
                DatoLeido = AD.ReadLine();
                while (DatoLeido != null)
                {
                    lst.Items.Add(DatoLeido);
                    DatoLeido = AD.ReadLine();
                }
            }
        }

        public void Grabar(String Dato1, String Dato2, String Dato3)
        {
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
            String DatoLeido;
            lst.Items.Clear();
            if (!File.Exists(NomArchi)) return;
            using (var AD = new StreamReader(NomArchi))
            {
                DatoLeido = AD.ReadLine();
                while (DatoLeido != null)
                {
                    lst.Items.Add(DatoLeido);
                    DatoLeido = AD.ReadLine();
                }
            }
            if (lst.Items.Count > 0) lst.SelectedIndex = 0;
        }
        public void Recorrer(DataGridView Grilla)
        {
            String DatoLeido;
            Grilla.Rows.Clear();
            if (!File.Exists(NomArchi)) return;

            if (Grilla.Columns.Count < 3)
            {
                Grilla.Columns.Clear();
                Grilla.Columns.Add("Codigo", "Codigo");
                Grilla.Columns.Add("Nombre", "Nombre");
                Grilla.Columns.Add("Carrera", "Carrera");
            }

            using (var AD = new StreamReader(NomArchi))
            {
                DatoLeido = AD.ReadLine();
                while (DatoLeido != null)
                {
                    var partes = DatoLeido.Split(new[] { ';' });
                    if (partes.Length >= 3)
                    {
                        Grilla.Rows.Add(partes[0], partes[1], partes[2]);
                    }
                    else
                    {
                        Grilla.Rows.Add(DatoLeido);
                    }
                    DatoLeido = AD.ReadLine();
                }
            }
        }

    }

}
