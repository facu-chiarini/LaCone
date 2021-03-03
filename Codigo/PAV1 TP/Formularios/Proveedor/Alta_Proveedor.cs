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

namespace PAV1_TP.Formularios.Proveedor
{
    public partial class Alta_Proveedor : Form
    {
        Ng_Proveedor proveedor = new Ng_Proveedor();
        public Alta_Proveedor()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Alta_Proveedor_Load(object sender, EventArgs e)
        {
            cmb_BarrioProveedor.Cargar();
            cmb_EstadoProveedor.Cargar();
            cmb_LocalidadProveedor.Cargar();
        }

        private void cmb_BarrioProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_RegistrarProveedor_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales tratamiento = new TratamientosEspeciales();
            Es_Proveedor _ep = new Es_Proveedor();

            if (tratamiento.validar(this.Controls) == TratamientosEspeciales.Validacion.correcta)
            {
                _ep.ID = proveedor.NuevoId();
                _ep.Nombre = txt_NombreProveedor.Text;
                _ep.Calle = txt_CalleProveedor.Text;
                _ep.Nro_Calle = txt_NCalleProveedor.Text;
                _ep.Localidad = cmb_LocalidadProveedor.SelectedValue.ToString();
                _ep.Barrio = cmb_BarrioProveedor.SelectedValue.ToString();
                _ep.Telefono = txt_TelefonoProveedor.Text;
                _ep.Razon_Social = txt_RSProveedor.Text;
                _ep.Estado = cmb_EstadoProveedor.SelectedValue.ToString();

                proveedor.Insertar(_ep);
                MessageBox.Show("Proveedor registrado correctamente");
                this.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
