using PAV1_TP.Clases;
using PAV1_TP.Negocios;
using PAV1_TP.Negocios.EstructurasNegocios;
using System;
using System.Windows.Forms;

namespace PAV1_TP.Formularios.Empleados
{
    public partial class Alta_Empleado : Form
    {
        Ng_Empleados empleados = new Ng_Empleados();
        public Alta_Empleado()
        {
            InitializeComponent();
        }
        private void Alta_Empleado_Load(object sender, EventArgs e)
        {
            cmb_LocalidadEmpleado.Cargar();
            cmb_BarrioEmpleado.Cargar();
            cmb_EstadoEmp.Cargar();
        }

        private void btn_RegistrarEmpleado_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales tratamiento = new TratamientosEspeciales();
            Es_Empleado _ee = new Es_Empleado();

            if (tratamiento.validar(this.Controls)==TratamientosEspeciales.Validacion.correcta)
            {
                if (txt_Contraseña.Text == txt_Contraseña2.Text)
                {


                    _ee.ID = empleados.NuevoId();
                    _ee.Nombre = txt_NombreEmpleado.Text;
                    _ee.Apellido = txt_ApellidoEmpleado.Text;
                    _ee.Telefono = txt_TelefonoEmpleado.Text;
                    _ee.Calle = txt_CalleEmpleado.Text;
                    _ee.Nro_Calle = txt_NCalleEmpleado.Text;
                    _ee.Localidad = cmb_LocalidadEmpleado.SelectedValue.ToString();
                    _ee.Barrio = cmb_BarrioEmpleado.SelectedValue.ToString();
                    _ee.Contraseña = txt_Contraseña.Text;
                    _ee.Estado = cmb_EstadoEmp.SelectedValue.ToString();

                    empleados.Insertar(_ee);
                    MessageBox.Show("Empleado registrado correctamente");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Los Password no coinciden");
                }
            }
        }

        private void btn_CancelarEmpleado_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_IdEmpleado_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmb_LocalidadEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {

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
    }
}
