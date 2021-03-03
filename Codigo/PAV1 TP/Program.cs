using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using PAV1_TP.Formularios;
using PAV1_TP.Formularios.Empleados;
using PAV1_TP.Formularios.Proveedor;
using PAV1_TP.Formularios.Catalogos;
using PAV1_TP.Formularios.Producto;
using PAV1_TP.Formularios.Plantas;
using PAV1_TP.Formularios.Plantas.TipoPlanta;
using PAV1_TP.Formularios.Clientes;
using PAV1_TP.Formularios.Producto.TipoProducto;
using PAV1_TP.Formularios.Cargas;
using PAV1_TP.Formularios.Puntos;
using PAV1_TP.Formularios.Canje;
using PAV1_TP.Reportes;
using PAV1_TP.Formularios.Reportes;
using PAV1_TP.Reportes.ReportesVentas;
using PAV1_TP.Reportes.ReportesEmpleados;
using PAV1_TP.Reportes.ReportesPlantas;
using PAV1_TP.Reportes.ReportesProdcutos;

namespace PAV1_TP
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>qqq
        /// qqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqaqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqa
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Frm_Escritorio());
            








        }
    }
}
