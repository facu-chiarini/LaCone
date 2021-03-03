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

namespace PAV1_TP.Formularios.Catalogos
{
    public partial class ABM_Catalogos : Form
    {
        Ng_Catalogo catalogo = new Ng_Catalogo();
        public ABM_Catalogos()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form AltaCatalogo = new Alta_Catalogos();
            AltaCatalogo.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Modificacion_Catalogos Modif = new Modificacion_Catalogos();

            if (Grid_Catalogos.CurrentCell.Value == null)
            {
                MessageBox.Show("No se selecciono ningun catalogo para modificar");
            }
            else
            {
                Modif.ID = Grid_Catalogos.CurrentRow.Cells[0].Value.ToString();
                Modif.IDPlanta = Grid_Catalogos.CurrentRow.Cells[1].Value.ToString();
                Modif.ShowDialog();
                Modif.Dispose();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (chk_CatalogosActivos.Checked == true && chk_CatalogosInactivos.Checked == true)
            {
                Cargar_Grilla(catalogo.Todos_Los_Catalogos());
                return;
            }
            if (chk_CatalogosActivos.Checked == true)
            {
                Cargar_Grilla(catalogo.Catalogos_Activos());
                return;
            }
            if (chk_CatalogosInactivos.Checked == true)
            {
                Cargar_Grilla(catalogo.Catalogos_Inactivos());
                return;
            }
            if (txt_IdCatalogo.Text == "" && txt_IdCatalogoPlanta.Text == "" )
            {
                MessageBox.Show("No hay restricciones para realizar la búsqueda");
                return;
            }
            if (txt_IdCatalogo.Text != "" || txt_IdCatalogoPlanta.Text != "" )
            {
                Cargar_Grilla(catalogo.Buscar_Catalogo(txt_IdCatalogo.Text, txt_IdCatalogoPlanta.Text));
            }
        }
        private void Cargar_Grilla(DataTable tabla)
        {
            Grid_Catalogos.Rows.Clear();

            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                Grid_Catalogos.Rows.Add();
                Grid_Catalogos.Rows[i].Cells[0].Value = tabla.Rows[i]["ID"].ToString();
                Grid_Catalogos.Rows[i].Cells[1].Value = tabla.Rows[i]["Id_Planta"].ToString();
                Grid_Catalogos.Rows[i].Cells[2].Value = tabla.Rows[i]["Puntos_Necesarios"].ToString();
            }
        }

        private void btn_SalirCatalogo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ABM_Catalogos_Load(object sender, EventArgs e)
        {

        }

        private void btn_EliminarCatalogo_Click(object sender, EventArgs e)
        {
            if (Grid_Catalogos.CurrentCell.Value == null)
            {
                MessageBox.Show("No se selecciono ningun Catalogo para eliminar");
            }
            else
            {
                string ID = Grid_Catalogos.CurrentRow.Cells[0].Value.ToString();
                DialogResult dialogResult = MessageBox.Show("¿Esta seguro que desea eliminar el usuario seleccionado?", "IMPORTANTE", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (dialogResult == DialogResult.Yes)
                {
                    catalogo.Eliminar(ID);
                    Cargar_Grilla(catalogo.Catalogos_Activos());
                }
            }
        }

		private void txt_IdCatalogo_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
