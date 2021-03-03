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
using PAV1_TP.Clases;
using Microsoft.Reporting.WinForms;

namespace PAV1_TP.Formularios.Reportes
{
    public partial class Frm_ReporteClientes : Form
    {
        Ng_Cliente cliente = new Ng_Cliente();
        DataTable TablaCliente = new DataTable();
        string restriccion = "";
        public Frm_ReporteClientes()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Frm_ReporteClientes_Load(object sender, EventArgs e)
        {

           // this.reportViewer1.RefreshReport();
        }

        private void BuscarClientes()
        {
            
            if (chk_TodosClientes.Checked == false & txt_ApellidoCliente.Text == "" & txt_DniCliente.Text == "" & txt_NombreCliente.Text == "")
            {
                MessageBox.Show("No se seleccionó ningún criterio de búsqueda");
                return;
            }
            if (chk_TodosClientes.Checked == true)
            {
                TablaCliente = cliente.BuscarCliente(true,"","","");
                restriccion += "sin restricción";
                return;
            }
            else
            {
                if (txt_NombreCliente.Text != "" & txt_ApellidoCliente.Text == "" & txt_DniCliente.Text == "")
                {
                    TablaCliente = cliente.BuscarCliente(false,txt_NombreCliente.Text,"","");
                    restriccion += "Nombre";
                    return;
                }

                if (txt_NombreCliente.Text == "" & txt_ApellidoCliente.Text != "" & txt_DniCliente.Text == "")
                {
                    TablaCliente = cliente.BuscarCliente(false,"",txt_ApellidoCliente.Text,"");
                    restriccion += "Apellido";
                    return;
                }

                if (txt_NombreCliente.Text == "" & txt_ApellidoCliente.Text == "" & txt_DniCliente.Text != "")
                {
                    TablaCliente = cliente.BuscarCliente(false,"","",txt_DniCliente.Text);
                    restriccion += "Dni";
                    return;
                }

                if (txt_NombreCliente.Text != "" & txt_NombreCliente.Text != "" & txt_DniCliente.Text != "")
                {
                    TablaCliente = cliente.BuscarCliente(false,txt_NombreCliente.Text, txt_ApellidoCliente.Text,txt_DniCliente.Text);
                    restriccion += "Nombre, Apellido y Dni";
                    return;
                }
            }
        }
        private void ArmarReporteCliente()
        {
            
            
            ReportDataSource Datos = new ReportDataSource("DataSet1", TablaCliente);
            Rv_Clientes.LocalReport.ReportEmbeddedResource = "PAV1_TP.Reportes.ReportesClientes.InformeCliente.rdlc";
            ReportParameter[] parametros = new ReportParameter[1];
            if (chk_TodosClientes.Checked == true)
            {
                parametros[0] = new ReportParameter("RP01", "Sin restriccion");
            }
            else
            {
                parametros[0] = new ReportParameter("RP01", "Restringido por " + restriccion);
            }
            
            Rv_Clientes.LocalReport.SetParameters(parametros);
            Rv_Clientes.LocalReport.DataSources.Clear();
            Rv_Clientes.LocalReport.DataSources.Add(Datos);
            Rv_Clientes.RefreshReport();
            

        }
        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            
            BuscarClientes();
            ArmarReporteCliente();
            restriccion = "";

            
        }
    }
}
