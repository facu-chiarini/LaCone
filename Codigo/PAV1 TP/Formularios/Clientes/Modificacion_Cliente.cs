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

namespace PAV1_TP.Formularios.Clientes
{
    public partial class Modificacion_Cliente : Form
    {
        Ng_Cliente Cliente = new Ng_Cliente();
        public string NroDoc { get; set; }

        public string DNI { get; set; }
        public Modificacion_Cliente()
        {
            InitializeComponent();
        }

        private void Modificacion_Cliente_Load(object sender, EventArgs e)
        {
            cmb_LocalidadCliente.Cargar();
            cmb_BarrioCliente.Cargar();
            cmb_TipoDoc.Cargar();
            cmb_Estado.Cargar();
            DataTable tabla = new DataTable();
            tabla = Cliente.RecuperarDNI(DNI);

            txt_NombreCliente.Text = tabla.Rows[0]["Nombre"].ToString();
            txt_ApellidoCliente.Text = tabla.Rows[0]["Apellido"].ToString();
            txt_MailCliente.Text = tabla.Rows[0]["Email"].ToString();
            txt_NDocCliente.Text = tabla.Rows[0]["NroDoc"].ToString();
            txt_CalleCliente.Text = tabla.Rows[0]["Calle"].ToString();
            txt_NCalleCliente.Text = tabla.Rows[0]["NroCalle"].ToString();
            txt_TelefonoCliente.Text = tabla.Rows[0]["Telefono"].ToString();
            cmb_BarrioCliente.SelectedValue = int.Parse(tabla.Rows[0]["Barrio"].ToString());
            cmb_LocalidadCliente.SelectedValue = int.Parse(tabla.Rows[0]["Localidad"].ToString());
            cmb_TipoDoc.SelectedValue = int.Parse(tabla.Rows[0]["TipoDoc"].ToString());
            cmb_Estado.SelectedValue = int.Parse(tabla.Rows[0]["Estado"].ToString());
        }


        private void btn_ModificarCliente_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales tratamiento = new TratamientosEspeciales();
            Es_Cliente _ee = new Es_Cliente();

            if (tratamiento.validar(this.Controls) == TratamientosEspeciales.Validacion.correcta)
            {
                _ee.TipoDoc = cmb_TipoDoc.SelectedValue.ToString();
                _ee.NroDoc = txt_NDocCliente.Text;
                _ee.Nombre = txt_NombreCliente.Text;
                _ee.Apellido = txt_ApellidoCliente.Text;
                _ee.Telefono = txt_TelefonoCliente.Text;
                _ee.Calle = txt_CalleCliente.Text;
                _ee.NroCalle = txt_NCalleCliente.Text;
                _ee.Localidad = cmb_LocalidadCliente.SelectedValue.ToString();
                _ee.Barrio = cmb_BarrioCliente.SelectedValue.ToString();

                _ee.Email = txt_MailCliente.Text;
                _ee.Estado = cmb_Estado.SelectedValue.ToString();

                Cliente.Modificar(_ee, NroDoc);


                MessageBox.Show("Cliente modificado correctamente");
                this.Close();

            }

        }

        private void comboBox012_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_CancelarCliente_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

	


