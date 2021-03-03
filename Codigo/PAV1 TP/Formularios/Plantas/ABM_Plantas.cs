using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PAV1_TP.Formularios.Plantas;
using PAV1_TP.Formularios.Plantas.TipoPlanta;
using PAV1_TP.Negocios;

namespace PAV1_TP.Formularios.Plantas
{
    public partial class ABM_Plantas : Form
    {
        Ng_Planta planta = new Ng_Planta();
        public ABM_Plantas()
        {
            InitializeComponent();
        }
        private void Cargar_Grilla(DataTable tabla)
        {
            Grid_Planta.Rows.Clear();

            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                Grid_Planta.Rows.Add();
                Grid_Planta.Rows[i].Cells[0].Value = tabla.Rows[i]["Codigo"].ToString();
                Grid_Planta.Rows[i].Cells[1].Value = tabla.Rows[i]["NombreCientifico"].ToString();
                Grid_Planta.Rows[i].Cells[2].Value = tabla.Rows[i]["NombreComun"].ToString();
                Grid_Planta.Rows[i].Cells[3].Value = tabla.Rows[i]["Tipo"].ToString();
                Grid_Planta.Rows[i].Cells[4].Value = tabla.Rows[i]["Precio"].ToString();
                Grid_Planta.Rows[i].Cells[5].Value = tabla.Rows[i]["Stock"].ToString();
            }
        }

        private void btn_ConsultarPlanta_Click(object sender, EventArgs e)
        {
            if (chk_PlantasActivas.Checked == true && chk_PlantasInactivas.Checked == true)
            {
                Cargar_Grilla(planta.Todas_las_Plantas());
                return;
            }
            if (chk_PlantasActivas.Checked == true)
            {
                Cargar_Grilla(planta.Plantas_Activas());
                return;
            }
            if (chk_PlantasInactivas.Checked == true)
            {
                Cargar_Grilla(planta.Plantas_Inactivas());
                return;
            }
            if (txt_CodPlanta.Text == "" && txt_NComun.Text == "")
            {
                MessageBox.Show("No hay restricciones para realizar la búsqueda");
                return;
            }
            if (txt_CodPlanta.Text != "" || txt_NComun.Text != "")
            {
                Cargar_Grilla(planta.Buscar_Planta(txt_CodPlanta.Text, txt_NComun.Text));
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_AgregarPlanta_Click(object sender, EventArgs e)
        {
            Form Alta_Plantas = new Alta_Plantas();
            Alta_Plantas.Show();
        }

        private void btn_ModificarPlanta_Click(object sender, EventArgs e)
        {
            Modificacion_Plantas Modif = new Modificacion_Plantas();
            if (Grid_Planta.CurrentCell.Value == null)
            {
                MessageBox.Show("No se selecciono ninguna planta para modificar");
            }
            else
            {
                Modif.Codigo = Grid_Planta.CurrentRow.Cells[0].Value.ToString();
                Modif.ShowDialog();
                Modif.Dispose();
            }
        }

        private void btn_EliminarPlanta_Click(object sender, EventArgs e)
        {
            if (Grid_Planta.CurrentCell.Value == null)
            {
                MessageBox.Show("No se selecciono ninguna planta para eliminar");
            }
            else
            {
                string Codigo = Grid_Planta.CurrentRow.Cells[0].Value.ToString();
                DialogResult dialogResult = MessageBox.Show("¿Esta seguro que desea eliminar la planta seleccionada?", "IMPORTANTE", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (dialogResult == DialogResult.Yes)
                {
                    planta.Eliminar(Codigo);
                    Cargar_Grilla(planta.Plantas_Activas());
                }
            }
        }

        private void btn_TipoPlanta_Click(object sender, EventArgs e)
        {
            Form ABM_TipoPlanta = new ABM_TipoPlanta();
            ABM_TipoPlanta.Show();
        }

        private void ABM_Plantas_Load(object sender, EventArgs e)
        {

        }
    }
}
