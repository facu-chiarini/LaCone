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


namespace PAV1_TP.Formularios
{
    public partial class Frm_Login : Form
    {
        public string Usuario { get; set; }
        public string Password
        {
            get { return txt_contraseña.Text; }
            set { txt_contraseña.Text = value; }
        }

        public Frm_Login()
        {
            InitializeComponent();
        }
        private void Frm_Login_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Panel p = sender as Panel;
            ControlPaint.DrawBorder(e.Graphics, p.DisplayRectangle, Color.Black, ButtonBorderStyle.Solid);
        }

        private void btn_ingresar_Click_1(object sender, EventArgs e)
        {
            if (this.txt_usuario.Text == "")
            {
                MessageBox.Show("No está cargado el usuario", "IMPORTANTE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_usuario.Focus();
                return;
            }
            if (this.txt_contraseña.Text == "")
            {
                MessageBox.Show("No está cargada la contraseña", "IMPORTANTE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_contraseña.Focus();
                return;
            }
            Ng_Empleados Usuario = new Ng_Empleados();
            if (Usuario.Validar_usuario(txt_usuario.Text, txt_contraseña.Text) == Ng_Empleados.Respuesta.validacion_correcta)
            {
                this.Usuario = txt_usuario.Text;
                this.Close();
            }
            else
            {
                MessageBox.Show("Este usuario y password " +
                                "no está registrado en la base de datos"
                                , "Importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    
    }
}
