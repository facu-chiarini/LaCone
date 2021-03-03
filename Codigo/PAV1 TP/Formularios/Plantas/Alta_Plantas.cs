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
using PAV1_TP.Negocios;
using PAV1_TP.Negocios.EstructurasNegocios;

namespace PAV1_TP.Formularios.Plantas
{
    public partial class Alta_Plantas : Form
    {
        Ng_Planta planta = new Ng_Planta();
        public Alta_Plantas()
        {
            InitializeComponent();
        }

        private void Alta_Plantas_Load(object sender, EventArgs e)
        {
            cmb_EstadoPlanta.Cargar();
            cmb_TipoPlanta.Cargar();
        }

        private void btn_RegistrarPlanta_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales tratamiento = new TratamientosEspeciales();
            Es_Planta _ep = new Es_Planta();

            if (tratamiento.validar(this.Controls) == TratamientosEspeciales.Validacion.correcta)
            {
              
                    _ep.Codigo = planta.NuevoId();
                    _ep.NombreCientifico = txt_NCientPlanta.Text;
                    _ep.NombreComun = txt_NomComPlanta.Text;
                    _ep.Precio = txt_PrecioPlanta.Text;
                    _ep.Stock = txt_StockPlanta.Text;
                    _ep.Estado = cmb_EstadoPlanta.SelectedValue.ToString();
                    _ep.Tipo = cmb_TipoPlanta.SelectedValue.ToString();

                    planta.Insertar(_ep);
                    MessageBox.Show("Planta registrado correctamente");
                    this.Close();
                }
            }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
