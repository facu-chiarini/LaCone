using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PAV1_TP.Negocios;
using PAV1_TP.Negocios.EstructurasNegocios;
using PAV1_TP.Clases;

namespace PAV1_TP.Formularios.Plantas
{
    public partial class Modificacion_Plantas : Form
    {
        Ng_Planta planta = new Ng_Planta();
        public string Codigo { get; set; }
        public Modificacion_Plantas()
        {
            InitializeComponent();
        }

        private void Modificacion_Plantas_Load(object sender, EventArgs e)
        {
            cmb_TipoPlanta.Cargar();
            cmb_EstadoPlanta.Cargar();
            DataTable tabla = new DataTable();
            tabla = planta.Recuperar_Planta(Codigo);
            txt_CodPlanta.Text = Codigo;
            txt_NomCienPlanta.Text = tabla.Rows[0]["NombreCientifico"].ToString();
            txt_NomComPlanta.Text = tabla.Rows[0]["NombreComun"].ToString();
            txt_PrecioPlanta.Text = tabla.Rows[0]["Precio"].ToString();
            txt_StockPlanta.Text = tabla.Rows[0]["Stock"].ToString();
            cmb_EstadoPlanta.SelectedValue = int.Parse(tabla.Rows[0]["Estado"].ToString());
            cmb_TipoPlanta.SelectedValue = int.Parse(tabla.Rows[0]["Tipo"].ToString());
        }

        private void btn_ModificarPlanta_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales tratamiento = new TratamientosEspeciales();
            Es_Planta _ep = new Es_Planta();

            if (tratamiento.validar(this.Controls) == TratamientosEspeciales.Validacion.correcta)
            {
                _ep.Codigo = txt_CodPlanta.Text;
                _ep.NombreCientifico = txt_NomCienPlanta.Text;
                _ep.NombreComun = txt_NomComPlanta.Text;
                _ep.Precio = txt_PrecioPlanta.Text;
                _ep.Stock = txt_StockPlanta.Text;
                _ep.Tipo = cmb_TipoPlanta.SelectedValue.ToString();
                _ep.Estado = cmb_EstadoPlanta.SelectedValue.ToString();

                planta.Modificar(_ep);
                MessageBox.Show("Planta modificada correctamente");
                this.Close();
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
