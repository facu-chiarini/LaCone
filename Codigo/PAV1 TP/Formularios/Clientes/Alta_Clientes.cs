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
    public partial class Alta_Clientes : Form
    {
		Ng_Cliente cliente = new Ng_Cliente();
        public Alta_Clientes()
        {
            InitializeComponent();
        }

        private void Alta_Clientes_Load(object sender, EventArgs e)
        {
			cmb_LocalidadCliente.Cargar();
			cmb_BarrioCliente.Cargar();
			cmb_TipoDocCliente.Cargar();
			cmb_EstadoCliente.Cargar();

		}


		private void btn_RegistrarCliente_Click(object sender, EventArgs e)
		{
			TratamientosEspeciales tratamiento = new TratamientosEspeciales();
			Es_Cliente _ee = new Es_Cliente();

			if (tratamiento.validar(this.Controls) == TratamientosEspeciales.Validacion.correcta)
            {
				DataTable TIpoDoc = new DataTable();
				TIpoDoc = cliente.RecuperarTipoDoc(cmb_TipoDocCliente.Text);
				_ee.TipoDoc = TIpoDoc.Rows[0]["ID"].ToString();

				_ee.NroDoc = txt_NDocCliente.Text;
				_ee.Nombre = txt_NombreCliente.Text;
				_ee.Apellido = txt_ApellidoCliente.Text;
				_ee.Telefono = txt_TelefonoCliente.Text;
				_ee.Calle = txt_CalleCliente.Text;
				_ee.NroCalle = txt_NCalleCliente.Text;
				_ee.Localidad = cmb_LocalidadCliente.SelectedValue.ToString();
				_ee.Barrio = cmb_BarrioCliente.SelectedValue.ToString();
				_ee.Email = txt_MailCliente.Text;
				_ee.Estado = cmb_EstadoCliente.SelectedValue.ToString();


				cliente.Insertar(_ee);

				MessageBox.Show("Cliente registrado correctamente");
				this.Close();
			}

		}

		private void comboBox013_SelectedIndexChanged(object sender, EventArgs e)
		{

		}


		private void btn_CancelarCliente_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
