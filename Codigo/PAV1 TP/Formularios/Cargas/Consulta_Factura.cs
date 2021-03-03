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

namespace PAV1_TP.Formularios.Cargas
{
    public partial class Consulta_Factura : Form
    {
        Ng_Factura factura = new Ng_Factura();
        public Consulta_Factura()
        {
            InitializeComponent();
        }

        private void btn_SalirFactura_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_GenerarFactura_Click(object sender, EventArgs e)
        {
            Form Factura = new Frm_GenerarFactura();
            Factura.Show();
        }

        private void btn_ConsultFactura_Click(object sender, EventArgs e)
        {
            if (txt_NroDoc.Text == "" && chk_Todos.Checked == false)
            {
                MessageBox.Show("No hay restricciones para realizar la búsqueda");
                return;
            }
            if (chk_Todos.Checked == true)
            {
                Cargar_Grilla(factura.Buscar_Todas_Facturas());
                return;
            }
            if (txt_NroDoc.Text != "")
            {
                Cargar_Grilla(factura.Buscar_Factura(txt_NroDoc.Text));
                return;
            }
        }
        private void Cargar_Grilla(DataTable tabla)
        {
            grid_Factura.Rows.Clear();

            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grid_Factura.Rows.Add();
                grid_Factura.Rows[i].Cells[0].Value = tabla.Rows[i]["Tipo_Factura"].ToString();
                grid_Factura.Rows[i].Cells[1].Value = tabla.Rows[i]["Nro_Factura"].ToString();
                grid_Factura.Rows[i].Cells[2].Value = tabla.Rows[i]["TipoDoc"].ToString();
                grid_Factura.Rows[i].Cells[3].Value = tabla.Rows[i]["NroDoc"].ToString();
                grid_Factura.Rows[i].Cells[4].Value = tabla.Rows[i]["Fecha"].ToString();
                grid_Factura.Rows[i].Cells[5].Value = tabla.Rows[i]["Id_Empleado"].ToString();
                grid_Factura.Rows[i].Cells[6].Value = tabla.Rows[i]["Monto"].ToString();
            }
        }

        private void btn_DetalleFactura_Click(object sender, EventArgs e)
        {
            Frm_DetalleFactura Modif = new Frm_DetalleFactura();
            if (grid_Factura.Rows.Count == 0)
            {
                MessageBox.Show("No se selecciono ninguna factura para consultar");
            }
            else
            {
                Modif.Factura = grid_Factura.CurrentRow.Cells[1].Value.ToString();
                Modif.ShowDialog();
                Modif.Dispose();
            }
        }
    }
}
