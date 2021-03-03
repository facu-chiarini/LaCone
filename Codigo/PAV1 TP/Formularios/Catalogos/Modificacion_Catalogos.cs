using PAV1_TP.Negocios.EstructurasNegocios;
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
using System.Runtime.Remoting.Messaging;

namespace PAV1_TP.Formularios.Catalogos
{
    public partial class Modificacion_Catalogos : Form
    {
        Ng_Catalogo catalogo = new Ng_Catalogo();
        public string ID { get; set; }
        public string IDPlanta { get; set; }
        public Modificacion_Catalogos()
        {
            InitializeComponent();
        }

        private void Modificacion_Catalogos_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = catalogo.Recuperar_Catalogo(ID,IDPlanta);
            txt_IdCatalogo.Text = ID;
            txt_PuntosNecesarios.Text = tabla.Rows[0]["Puntos_Necesarios"].ToString();
            cmb_EstadoCatalogo.Cargar();
            chk_Id_Plantas_Catalogos.Cargar();
            //chk_Id_Plantas_Catalogos.SetItemChecked(int.Parse(IDPlanta) -1 , true);


        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales tratamiento = new TratamientosEspeciales();
            Es_Catalogo _ec = new Es_Catalogo();

            if (tratamiento.validar(this.Controls) == TratamientosEspeciales.Validacion.correcta)
            {

                
                if (chk_Id_Plantas_Catalogos.CheckedItems.Count > 1)
                {
                    MessageBox.Show("Selecciona solamente una opcion de Id de planta");
                    return;
                }
                if (chk_Id_Plantas_Catalogos.CheckedItems.Count == 0)
                {
                    MessageBox.Show("No se selecciono ninguna opcion de Id de planta");
                    return;
                }
                if (chk_Id_Plantas_Catalogos.CheckedItems.Count == 1)
                {
                    _ec.ID = txt_IdCatalogo.Text;
                    
                    //Recuperar El codigo de planta a través del ID
                    
                    string planta = chk_Id_Plantas_Catalogos.SelectedItem.ToString();
                    DataTable tabla = new DataTable();
                    tabla = catalogo.Recuperar_Planta(planta);
                    _ec.Id_Planta = int.Parse(tabla.Rows[0][0].ToString());
                    var IdConsulta = tabla.Rows[0][0].ToString();
                    _ec.Puntos_Necesarios = txt_PuntosNecesarios.Text;
                    _ec.Estado = cmb_EstadoCatalogo.SelectedValue.ToString();
                    _ec.Idactual = int.Parse(IDPlanta);

                    if (catalogo.Recuperar_Catalogo(ID, IdConsulta).Rows.Count == 0 )
                    {
                        catalogo.Modificar(_ec);

                        MessageBox.Show("Catalogo modificado correctamente");
                        this.Close();
                    }
                    else
                    {
                        catalogo.ModificarParical(_ec);
                        MessageBox.Show("El catalogo ya incluye esta planta");
                        this.Close();

                    }

                }
            }
        }

        private void chk_Id_Plantas_Catalogos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
