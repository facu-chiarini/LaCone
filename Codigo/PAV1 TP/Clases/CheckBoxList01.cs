using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

 namespace PAV1_TP.Clases
{
    class CheckBoxList01 : CheckedListBox
    {
        public string Pp_Tabla { get; set; }
        public string Pp_Display { get; set; }
        public string Pp_Value { get; set; }
        public bool Pp_seleccionado { get; set; }

        public bool Pp_validable { get; set; }
        public string Pp_nombre_campo { get; set; }
        public string Pp_nombre_tabla { get; set; }
        public string Pp_mensajeError { get; set; }
        public void Cargar()
        {
            Be_BaseDeDatos _BD = new Be_BaseDeDatos();
            DataTable tabla = new DataTable();
            tabla = _BD.Consulta("SELECT * FROM " + Pp_Tabla);
            int filas = tabla.Rows.Count;

            for (int i = 0; i < filas; i ++)
            {
                string Plantas = tabla.Rows[i]["NombreComun"].ToString();
                this.Items.Add(Plantas);
            }
        }
        public void Cargar2()
        {
            Be_BaseDeDatos _BD = new Be_BaseDeDatos();
            DataTable tabla = new DataTable();
            tabla = _BD.Consulta("SELECT * FROM " + Pp_Tabla);
            int filas = tabla.Rows.Count;

            for (int i = 0; i < filas; i++)
            {
                string Plantas = tabla.Rows[i]["Nombre"].ToString();
                this.Items.Add(Plantas);
            }
        }
    }
}
