using PAV1_TP.Negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace PAV1_TP.Reportes.ReportesEmpleados
{
    public partial class Frm_ReporteEmpleados : Form
    {
        Ng_Empleados empleado = new Ng_Empleados();
        DataTable TablaEmpleados = new DataTable();
        string restriccion = "";
        public Frm_ReporteEmpleados()
        {
            InitializeComponent();
        }
        private void BuscarEmpleado()
        {
            TablaEmpleados = empleado.Empleados_Activos();
            return;
        }
        private void ArmarReporte()
        {
            ReportDataSource Datos = new ReportDataSource("DataSet1", TablaEmpleados);
            Rv_Empleado.LocalReport.ReportEmbeddedResource = "PAV1_TP.Reportes.ReportesEmpleados.InformeEmpleados.rdlc";
            ReportParameter[] parametros = new ReportParameter[1];
            parametros[0] = new ReportParameter("RP01", "Restringido por " + restriccion);
            Rv_Empleado.LocalReport.DataSources.Clear();
            Rv_Empleado.LocalReport.DataSources.Add(Datos);
            Rv_Empleado.RefreshReport();
        }

        private void Frm_ReporteEmpleados_Load_1(object sender, EventArgs e)
        {

            //this.Rv_Empleado.RefreshReport();
        }

        private void btn_Buscar_Click_1(object sender, EventArgs e)
        {
            BuscarEmpleado();
            ArmarReporte();
        }
    }
}
