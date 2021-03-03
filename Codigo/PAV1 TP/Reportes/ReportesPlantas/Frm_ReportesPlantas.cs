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

namespace PAV1_TP.Reportes.ReportesPlantas
{
    public partial class Frm_ReportesPlantas : Form
    {
        Ng_Planta planta = new Ng_Planta();
        DataTable TablaPlantas = new DataTable();
        string restriccion = "";
        public Frm_ReportesPlantas()
        {
            InitializeComponent();
        }

        private void Frm_ReportesPlantas_Load(object sender, EventArgs e)
        {

            //this.Rv_Plantas.RefreshReport();
        }
        private void BuscarPlantas()
        {
            TablaPlantas = planta.Plantas_Activas();
            return;
        }
        private void ArmarReporte()
        {
            ReportDataSource Datos = new ReportDataSource("DataSet1", TablaPlantas);
            Rv_Plantas.LocalReport.ReportEmbeddedResource = "PAV1_TP.Reportes.ReportesPlantas.InformePlantas.rdlc";
            ReportParameter[] parametros = new ReportParameter[1];
            parametros[0] = new ReportParameter("RP01", "Restringido por " + restriccion);
            Rv_Plantas.LocalReport.DataSources.Clear();
            Rv_Plantas.LocalReport.DataSources.Add(Datos);
            Rv_Plantas.RefreshReport();
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            BuscarPlantas();
            ArmarReporte();
        }
    }
}
