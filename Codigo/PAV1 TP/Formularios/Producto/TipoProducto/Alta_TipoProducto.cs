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
using PAV1_TP.Negocios.EstructurasNegocios;

namespace PAV1_TP.Formularios.Producto.TipoProducto
{
    public partial class Alta_TipoProducto : Form
    {
        Ng_TipoProducto tipoProducto = new Ng_TipoProducto();
        public Alta_TipoProducto()
        {
            InitializeComponent();
        }

        private void Alta_TipoProducto_Load(object sender, EventArgs e)
        {
            cmb_EstadoTipoProducto.Cargar();
        }

        private void btn_RegistrarTipoPlanta_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales tratamiento = new TratamientosEspeciales();
            Es_TipoProducto _etp = new Es_TipoProducto();

            if (tratamiento.validar(this.Controls) == TratamientosEspeciales.Validacion.correcta)
            {

                _etp.ID = tipoProducto.NuevoId();
                _etp.Nombre = txt_NombreTipoProducto.Text;
                _etp.Descripcion = txt_DescripTipoProducto.Text;
                _etp.Estado = cmb_EstadoTipoProducto.SelectedValue.ToString();

                tipoProducto.Insertar(_etp);
                MessageBox.Show("Tipo de producto registrado correctamente");
                this.Close();
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
