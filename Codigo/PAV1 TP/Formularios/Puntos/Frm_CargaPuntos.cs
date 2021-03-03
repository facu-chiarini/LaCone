using PAV1_TP.Clases;
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

namespace PAV1_TP.Formularios.Puntos
{
    public partial class Frm_CargaPuntos : Form
    {
        Ng_Puntos puntos = new Ng_Puntos();
        TratamientosEspeciales tratamiento = new TratamientosEspeciales();
        public Frm_CargaPuntos()
        {
            InitializeComponent();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Cargar_Click(object sender, EventArgs e)
        {
            if (tratamiento.validar(this.Controls) == TratamientosEspeciales.Validacion.correcta)
            {
                if (txt_NroDoc.Text != "")
                {
                    puntos.insertar(txt_TipoDoc.Text, txt_NroDoc.Text, txt_TipoFactura.Text, txt_NroFactura.Text,
                            txt_Puntos.Text, txt_Fecha.Text);
                    MessageBox.Show("Puntos cargados correctamente");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Presione el boton buscar para recuperar los datos");
                }
            }
                
                
        }

        private void Frm_CargaPuntos_Load(object sender, EventArgs e)
        {
            DataTable tabla4 = new DataTable();
            tabla4 = puntos.RecuperarIdFactura();
            txt_NroFactura.Text = tabla4.Rows[0]["ID"].ToString();
            DataTable tabla = new DataTable();
            tabla = puntos.PuntosASumar(txt_NroFactura.Text);
            txt_Puntos.Text = tabla.Rows[0]["Puntos"].ToString();
            DataTable tabla2 = new DataTable();
            tabla2 = puntos.RecuperarDNI(txt_NroFactura.Text);
            txt_NroDoc.Text = tabla2.Rows[0]["NroDoc"].ToString();
            txt_TipoDoc.Text = tabla2.Rows[0]["TipoDoc"].ToString();
            txt_Fecha.Text = tabla2.Rows[0]["Fecha"].ToString();
            DataTable tabla3 = new DataTable();
            tabla3 = puntos.RecuperarTipoFactura(txt_NroFactura.Text);
            txt_TipoFactura.Text = tabla3.Rows[0]["Tipo_Factura"].ToString();
        }
    }
}
