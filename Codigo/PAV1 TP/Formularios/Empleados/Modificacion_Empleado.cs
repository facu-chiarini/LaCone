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
using PAV1_TP.Clases;
using PAV1_TP.Negocios.EstructurasNegocios;

namespace PAV1_TP.Formularios.Empleados
{
    public partial class Modificacion_Empleado : Form
    {
        Ng_Empleados Empleado = new Ng_Empleados();


        public string ID { get; set; }

        public Modificacion_Empleado()
        {
            InitializeComponent();
        }

        private void Modificacion_Empleado_Load(object sender, EventArgs e)
        {
            cmb_BarrioEmpleado.Cargar();
            cmb_EstadoEmp.Cargar();
            cmb_LocalidadEmpleado.Cargar();
            DataTable tabla = new DataTable();
            tabla = Empleado.Recuperar_Usuario(ID);
            txt_IdEmpleado.Text = ID;
            txt_NombreEmpleado.Text = tabla.Rows[0]["Nombre"].ToString();
            txt_Contraseña.Text = tabla.Rows[0]["Contraseña"].ToString();
            txt_Contraseña2.Text = txt_Contraseña.Text;
            txt_ApellidoEmpleado.Text = tabla.Rows[0]["Apellido"].ToString();
            txt_TelefonoEmpleado.Text = tabla.Rows[0]["Telefono"].ToString();
            txt_CalleEmpleado.Text = tabla.Rows[0]["Calle"].ToString();
            txt_NCalleEmpleado.Text = tabla.Rows[0]["Nro_Calle"].ToString();
            cmb_BarrioEmpleado.SelectedValue = int.Parse(tabla.Rows[0]["Barrio"].ToString());
            cmb_LocalidadEmpleado.SelectedValue = int.Parse(tabla.Rows[0]["Localidad"].ToString());
            cmb_EstadoEmp.SelectedValue = int.Parse(tabla.Rows[0]["Estado"].ToString());

        }

        private void btn_RegistrarEmpleado_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales tratamiento = new TratamientosEspeciales();
            Es_Empleado _ee = new Es_Empleado();

            if (tratamiento.validar(this.Controls) == TratamientosEspeciales.Validacion.correcta)
            {
                if (txt_Contraseña.Text == txt_Contraseña2.Text)
                {


                    _ee.ID = txt_IdEmpleado.Text;
                    _ee.Nombre = txt_NombreEmpleado.Text;
                    _ee.Apellido = txt_ApellidoEmpleado.Text;
                    _ee.Telefono = txt_TelefonoEmpleado.Text;
                    _ee.Calle = txt_CalleEmpleado.Text;
                    _ee.Nro_Calle = txt_NCalleEmpleado.Text;
                    _ee.Localidad = cmb_LocalidadEmpleado.SelectedValue.ToString();
                    _ee.Barrio = cmb_BarrioEmpleado.SelectedValue.ToString();
                    _ee.Contraseña = txt_Contraseña.Text;
                    _ee.Estado = cmb_EstadoEmp.SelectedValue.ToString();

                    Empleado.Modificar(_ee);
                    MessageBox.Show("Empleado modificado correctamente");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Las contraseñas no coinciden");
                }
            }
        }

        private void btn_CancelarEmpleado_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (txt_Contraseña.PasswordChar == '*')
            {
                this.txt_Contraseña.PasswordChar = '\0';
                this.txt_Contraseña2.PasswordChar = '\0';
            }
            else
            {
                this.txt_Contraseña.PasswordChar = '*';
                this.txt_Contraseña2.PasswordChar = '*';
            }
        }

        private void cmb_EstadoEmp_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmb_LocalidadEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmb_BarrioEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}


