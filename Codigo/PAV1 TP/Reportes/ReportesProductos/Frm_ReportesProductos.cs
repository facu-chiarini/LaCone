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
using PAV1_TP.Negocios;

namespace PAV1_TP.Reportes.ReportesProdcutos
{
    public partial class Frm_ReportesProductos : Form
    {
        Ng_Producto producto = new Ng_Producto();
        DataTable TablaProductos = new DataTable();
        string restriccion = "";
        public Frm_ReportesProductos()
        {
            InitializeComponent();
        }

        private void Frm_ReportesProductos_Load(object sender, EventArgs e)
        {

            //this.reportViewer1.RefreshReport();
        }
        private void BuscarProductos()
        {
            TablaProductos = producto.Productos_Activos();
            return;
        }
        private void ArmarReporte()
        {
            ReportDataSource Datos = new ReportDataSource("DataSet1", TablaProductos);
            Rv_Productos.LocalReport.ReportEmbeddedResource = "PAV1_TP.Reportes.ReportesProductos.InformeProductos.rdlc";
            ReportParameter[] parametros = new ReportParameter[1];
            parametros[0] = new ReportParameter("RP01", "Restringido por " + restriccion);
            Rv_Productos.LocalReport.DataSources.Clear();
            Rv_Productos.LocalReport.DataSources.Add(Datos);
            Rv_Productos.RefreshReport();
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            BuscarProductos();
            ArmarReporte();
        }
    }
}
