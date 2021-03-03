using Microsoft.Reporting.WinForms;
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

namespace PAV1_TP.Reportes.ReportesVentas
{
    public partial class Frm_ReporteVentas : Form
    {
        Ng_Factura factura = new Ng_Factura();
        DataTable TablaVentas = new DataTable();
        string restriccion = "";
        public Frm_ReporteVentas()
        {
            InitializeComponent();
        }

        private void Frm_ReporteVentas_Load(object sender, EventArgs e)
        {

            //this.reportViewer1.RefreshReport();
            //this.Rv_VentasXMonto.RefreshReport();
			//this.Rv_VentasXMes.RefreshReport();
        }
        private void BuscarVentas()
        {
            if (txt_NroDoc.Text == "" && chk_TodasLasVentas.Checked == false)
            {
                MessageBox.Show("No se realizó selección para la búsqueda");
                return;
            }
            if (chk_TodasLasVentas.Checked == true)
            {
                TablaVentas = factura.Buscar_Todas_Facturas();
                return;
            }
            if (txt_NroDoc.Text != "")
            {
                TablaVentas = factura.Buscar_Factura(txt_NroDoc.Text);
                return;
            }
        }


        private void ArmarReporte()
        {
            ReportDataSource Datos = new ReportDataSource("DataSet1", TablaVentas);
            Rv_Ventas.LocalReport.ReportEmbeddedResource = "PAV1_TP.Reportes.ReportesVentas.InformeVentas.rdlc";
            ReportParameter[] parametros = new ReportParameter[1];
            parametros[0] = new ReportParameter("RP01", "Restringido por " + restriccion);
            Rv_Ventas.LocalReport.DataSources.Clear();
            Rv_Ventas.LocalReport.DataSources.Add(Datos);
            Rv_Ventas.RefreshReport();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			BuscarVentas();
			ArmarReporte();
		}


		private void BuscarPlantaXMonto()
        {
            TablaVentas = factura.BuscarFacturaXMonto(txt_Monto.Text);
            return;
        }
        private void ArmarReporteXMonto()
        {
            ReportDataSource Datos = new ReportDataSource("DataSet1", TablaVentas);
            Rv_VentasXMonto.LocalReport.ReportEmbeddedResource = "PAV1_TP.Reportes.ReportesVentas.InformeVentas.rdlc";
            ReportParameter[] parametros = new ReportParameter[1];
            parametros[0] = new ReportParameter("RP01", "Restringido por " + restriccion);
            Rv_VentasXMonto.LocalReport.DataSources.Clear();
            Rv_VentasXMonto.LocalReport.DataSources.Add(Datos);
            Rv_VentasXMonto.RefreshReport();
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            if (txt_Monto.Text == "")
            {
                MessageBox.Show("Ingrese un monto");
            }
            else
            {
                BuscarPlantaXMonto();
                ArmarReporteXMonto();
            }
        }


		private void BuscarVentasPorMes()
		{
			if (txt_Mes.Text == "" && check_MayorV.Checked == false && check_MenorV.Checked == false)
			{
				MessageBox.Show("No se realizó selección para la búsqueda");
				return;
			}
			if (txt_Mes.Text == "" && (check_MayorV.Checked == true || check_MenorV.Checked == true))
			{
				MessageBox.Show("Ingrese un mes");
				return;
			}
			if (txt_Mes.Text != "" && (check_MayorV.Checked == false && check_MenorV.Checked == false))
			{
				MessageBox.Show("Seleccione si desea conocer el día con menor y/o mayor venta");
				return;
			}
			if (txt_Mes.Text != "" && check_MayorV.Checked == true && check_MenorV.Checked == true)
			{
				TablaVentas = factura.Buscar_MyM_Ventas_Mes(txt_Mes.Text);
				return;
			}
			if (txt_Mes.Text != "" && check_MayorV.Checked == true && check_MenorV.Checked == false)
			{
				TablaVentas = factura.Buscar_Mayor_Venta_Mes(txt_Mes.Text);
				return;
			}
			if (txt_Mes.Text != "" && check_MayorV.Checked == false && check_MenorV.Checked == true)
			{
				TablaVentas = factura.Buscar_Menor_Venta_Mes(txt_Mes.Text);
				return;
			}
		}

		private void ArmarReportesPorMes()
		{
			ReportDataSource Datos = new ReportDataSource("DataSet1", TablaVentas);
			Rv_VentasXMes.LocalReport.ReportEmbeddedResource = "PAV1_TP.Reportes.ReportesVentas.InformeVentas.rdlc";
			ReportParameter[] parametros = new ReportParameter[1];
			parametros[0] = new ReportParameter("RP01", "Restringido por " + restriccion);
			Rv_VentasXMes.LocalReport.DataSources.Clear();
			Rv_VentasXMes.LocalReport.DataSources.Add(Datos);
			Rv_VentasXMes.RefreshReport();
		}

		private void btnBuscar_Click(object sender, EventArgs e)
		{
			BuscarVentasPorMes();
			ArmarReportesPorMes();
		}

        //***********************************************************Reportes Facu**************************************************************

        //REPORTE DE PLANTAS POR MES

        DataTable tablaPPM = new DataTable();
        int TotalPlantas = 0;
        private void BuscarPPM()
        {
            if (txt_MesPPM.Text != "")
            {
                if (int.Parse(txt_MesPPM.Text) > 12 | int.Parse(txt_MesPPM.Text) == 0)
                {
                    MessageBox.Show("Ingrese un mes correcto");
                    txt_MesPPM.Focus();

                }
                else
                {
                    tablaPPM = factura.ReportePPM(txt_MesPPM.Text);
                    if (tablaPPM.Rows.Count == 0)
                    {
                        MessageBox.Show("No hubo ventas en el mes ingresado","ATENCIÓN");
                    }
                }

            }
            else
            {
                MessageBox.Show("Ingresar Mes","ATENCIÓN");
                txt_MesPPM.Focus();
            }
        }

        private void CalcularPPM()
        {

            for (int i = 0; i < tablaPPM.Rows.Count; i++)
            {
                TotalPlantas += int.Parse(tablaPPM.Rows[i][1].ToString());
            }

        }
        private void ArmarReportePPM()
        {

            ReportDataSource Datos = new ReportDataSource("DataSetPPM", tablaPPM);
            Rv_PPM.LocalReport.ReportEmbeddedResource = "PAV1_TP.Reportes.ReportesVentas.InformePPM.rdlc";
            ReportParameter[] parametros1 = new ReportParameter[1];
            parametros1[0] = new ReportParameter("RP01", "Mes: " + txt_MesPPM.Text);
            ReportParameter[] parametros2 = new ReportParameter[1];
            parametros2[0] = new ReportParameter("RP02", "Total de plantas vendidas: " + TotalPlantas.ToString());
            Rv_PPM.LocalReport.SetParameters(parametros1);
            Rv_PPM.LocalReport.SetParameters(parametros2);
            Rv_PPM.LocalReport.DataSources.Clear();
            Rv_PPM.LocalReport.DataSources.Add(Datos);
            Rv_PPM.RefreshReport();
        }

        private void btn_PPM_Click(object sender, EventArgs e)
        {
            BuscarPPM();
            if (tablaPPM.Rows.Count > 0)
            {
                CalcularPPM();
                ArmarReportePPM();
                TotalPlantas = 0;
            }
        }

        //REPORTE TIPO PLANTA POR MES

        DataTable tablaTPPM = new DataTable();

        private void BuscarTPPM()
        {
            if (txt_MesTPPM.Text != "")
            {
                if (int.Parse(txt_MesTPPM.Text) > 12 | int.Parse(txt_MesTPPM.Text) == 0)
                {
                    MessageBox.Show("Ingrese un mes correcto");
                    txt_MesTPPM.Focus();
                    return;
                }
                else
                {
                    tablaTPPM = factura.ReporteTPPM(txt_MesTPPM.Text);
                    if (tablaTPPM.Rows.Count == 0)
                    {
                        MessageBox.Show("No hubo ventas en el mes ingresado","ATENCIÓN");
                    }
                }


            }
            else
            {
                MessageBox.Show("Ingresar Mes","ATENCIÓN");
                txt_MesTPPM.Focus();
            }
        }

        private void ArmarReporteTPPM()
        {
            ReportDataSource DatosTPPM = new ReportDataSource("DataSetTPPM", tablaTPPM);
            Rv_TPPM.LocalReport.ReportEmbeddedResource = "PAV1_TP.Reportes.ReportesVentas.InformeTPPM.rdlc";
            ReportParameter[] parametrostppm = new ReportParameter[1];
            parametrostppm[0] = new ReportParameter("RPM", "Mes: " + txt_MesTPPM.Text);
            Rv_TPPM.LocalReport.SetParameters(parametrostppm);
            Rv_TPPM.LocalReport.DataSources.Clear();
            Rv_TPPM.LocalReport.DataSources.Add(DatosTPPM);
            Rv_TPPM.RefreshReport();
        }

        private void btn_TPPM_Click(object sender, EventArgs e)
        {
            BuscarTPPM();
            if (tablaTPPM.Rows.Count > 0)
            {
                ArmarReporteTPPM();
            }
        }
    }
}
