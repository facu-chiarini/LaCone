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
using PAV1_TP.Negocios.EstructurasNegocios;
using PAV1_TP.Clases;

namespace PAV1_TP.Formularios.Proveedor
{
    public partial class Modificacion_Proveedor : Form
    {
        Ng_Proveedor proveedor = new Ng_Proveedor();
        public string ID { get; set; }
        public Modificacion_Proveedor()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales tratamiento = new TratamientosEspeciales();
            Es_Proveedor _ep = new Es_Proveedor();
            if (tratamiento.validar(this.Controls) == TratamientosEspeciales.Validacion.correcta)
            {
                _ep.ID = txt_IdProveedor.Text;
                _ep.Nombre = txt_NombreProveedor.Text;
                _ep.Telefono = txt_TelefonoProveedor.Text;
                _ep.Calle = txt_CalleProveedor.Text;
                _ep.Nro_Calle = txt_NCalleProveedor.Text;
                _ep.Localidad = cmb_LocalidadProveedor.SelectedValue.ToString();
                _ep.Barrio = cmb_BarrioProveedor.SelectedValue.ToString();
                _ep.Estado = cmb_EstadoProveedor.SelectedValue.ToString();
                

                proveedor.Modificar(_ep);
                MessageBox.Show("Empleado modificado correctamente");
                this.Close();
            }
        }

        private void Modificacion_Proveedor_Load(object sender, EventArgs e)
        {
            cmb_BarrioProveedor.Cargar();
            cmb_LocalidadProveedor.Cargar();
            cmb_EstadoProveedor.Cargar();
            DataTable tabla = new DataTable();
            tabla = proveedor.Recuperar_Usuario(ID);
            txt_IdProveedor.Text = ID;
            txt_NombreProveedor.Text = tabla.Rows[0]["Nombre"].ToString();
            txt_CalleProveedor.Text = tabla.Rows[0]["Calle"].ToString();
            txt_NCalleProveedor.Text = tabla.Rows[0]["Nro_Calle"].ToString();
            txt_TelefonoProveedor.Text = tabla.Rows[0]["Telefono"].ToString();
            txt_RSProveedor.Text = tabla.Rows[0]["Razon_Social"].ToString();
            cmb_BarrioProveedor.SelectedValue = int.Parse(tabla.Rows[0]["Barrio"].ToString());
            cmb_LocalidadProveedor.SelectedValue = int.Parse(tabla.Rows[0]["Localidad"].ToString());
        }
    }
}
