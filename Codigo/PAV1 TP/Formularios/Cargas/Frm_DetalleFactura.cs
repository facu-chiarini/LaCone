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
    public partial class Frm_DetalleFactura : Form
    {
        public string Factura { get; set; }
        Ng_Factura Detalle = new Ng_Factura();

        public Frm_DetalleFactura()
        {
            InitializeComponent();
        }
        private void Cargar_Grilla(DataTable tabla)
        {
            grid_DetalleFactura.Rows.Clear();

            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grid_DetalleFactura.Rows.Add();
                grid_DetalleFactura.Rows[i].Cells[0].Value = tabla.Rows[i]["Id_Planta"].ToString();
                grid_DetalleFactura.Rows[i].Cells[1].Value = tabla.Rows[i]["Id_Producto"].ToString();
                grid_DetalleFactura.Rows[i].Cells[2].Value = tabla.Rows[i]["Cantidad"].ToString();
                grid_DetalleFactura.Rows[i].Cells[3].Value = tabla.Rows[i]["Precio"].ToString();
            }
        }

        private void Frm_DetalleFactura_Load(object sender, EventArgs e)
        {
            Cargar_Grilla(Detalle.Buscar_Detalle_Factura(Factura));
        }
    }
}
