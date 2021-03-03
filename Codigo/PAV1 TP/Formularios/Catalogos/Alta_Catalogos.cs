using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PAV1_TP.Clases;
using PAV1_TP.Negocios;
using PAV1_TP.Negocios.EstructurasNegocios;

namespace PAV1_TP.Formularios.Catalogos
{
    public partial class Alta_Catalogos : Form
    {
        Ng_Catalogo catalogo = new Ng_Catalogo();
        public Alta_Catalogos()
        {
            InitializeComponent();
        }

        private void Alta_Catalogos_Load(object sender, EventArgs e)
        {
            chk_Id_Plantas_Catalogos.Cargar();
            cmb_EstadoCatalogo.Cargar();
        }

        private void chk_Id_Plantas_Catalogos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_RegistrarCatalogo_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales tratamiento = new TratamientosEspeciales();
            Es_Catalogo _ec = new Es_Catalogo();

            
            
                var items = chk_Id_Plantas_Catalogos.CheckedItems.Count;
                DataTable tabla = new DataTable();
                _ec.ID = catalogo.NuevoId();
                for (int i = 0; i < items; i++)
                {
                    string planta = chk_Id_Plantas_Catalogos.CheckedItems[i].ToString();
                    _ec.Id_Planta = int.Parse(catalogo.Recuperar_id(planta).ToString());
                    _ec.Puntos_Necesarios = txt_PuntosNecesarios.Text;
                    _ec.Estado = cmb_EstadoCatalogo.SelectedValue.ToString();

                    catalogo.Insertar(_ec);
                }

                MessageBox.Show("Catalogo registrado Correctamente");
                this.Close();


            
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
