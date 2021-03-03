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

namespace PAV1_TP.Formularios.Plantas.TipoPlanta
{
    public partial class Alta_TipoPlanta : Form
    {
        Ng_TipoPlanta tipoPlanta = new Ng_TipoPlanta();
        public Alta_TipoPlanta()
        {
            InitializeComponent();
        }

        private void Alta_TipoPlanta_Load(object sender, EventArgs e)
        {
            cmb_EstadoTipoPlanta.Cargar();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_RegistrarTipoPlanta_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales tratamiento = new TratamientosEspeciales();
            Es_TipoPlanta _etp = new Es_TipoPlanta();

            if (tratamiento.validar(this.Controls) == TratamientosEspeciales.Validacion.correcta)
            {

                _etp.ID = tipoPlanta.NuevoId();
                _etp.Nombre = txt_NombreTipoPlanta.Text;
                _etp.Descripcion = txt_DescripTipoPlanta.Text;
                _etp.Estado = cmb_EstadoTipoPlanta.SelectedValue.ToString();

                tipoPlanta.Insertar(_etp);
                MessageBox.Show("Tipo de planta registrado correctamente");
                this.Close();
            }
        }
    }
    
}
