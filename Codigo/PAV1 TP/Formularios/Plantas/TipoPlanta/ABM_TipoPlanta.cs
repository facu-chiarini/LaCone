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

namespace PAV1_TP.Formularios.Plantas.TipoPlanta
{
    public partial class ABM_TipoPlanta : Form
    {
        Ng_TipoPlanta tipoPlanta = new Ng_TipoPlanta();
        public ABM_TipoPlanta()
        {
            InitializeComponent();
        }
        private void Cargar_Grilla(DataTable tabla)
        {
            Grid_TipoPlanta.Rows.Clear();

            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                Grid_TipoPlanta.Rows.Add();
                Grid_TipoPlanta.Rows[i].Cells[0].Value = tabla.Rows[i]["ID"].ToString();
                Grid_TipoPlanta.Rows[i].Cells[1].Value = tabla.Rows[i]["Nombre"].ToString();
                Grid_TipoPlanta.Rows[i].Cells[2].Value = tabla.Rows[i]["Descripcion"].ToString();     
            }
        }

        private void btn_ConsultarTipoPlanta_Click(object sender, EventArgs e)
        {
            if (chk_TipoPlantasActivas.Checked == true && chk_TipoPlantasInactivas.Checked == true)
            {
                Cargar_Grilla(tipoPlanta.Todos_Tipos_Plantas());
                return;
            }
            if (chk_TipoPlantasActivas.Checked == true)
            {
                Cargar_Grilla(tipoPlanta.Tipo_Plantas_Activas());
                return;
            }
            if (chk_TipoPlantasInactivas.Checked == true)
            {
                Cargar_Grilla(tipoPlanta.Tipo_Plantas_Inactivas());
                return;
            }
            if (txt_IdTipoProducto.Text == "" && txt_NombreTipoProducto.Text == "")
            {
                MessageBox.Show("No hay restricciones para realizar la búsqueda");
                return;
            }
            if (txt_IdTipoProducto.Text != "" || txt_NombreTipoProducto.Text != "")
            {
                Cargar_Grilla(tipoPlanta.Buscar_Planta(txt_IdTipoProducto.Text, txt_NombreTipoProducto.Text));
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_AgregarTipoPlanta_Click(object sender, EventArgs e)
        {
            Form Alta_TipoPlanta = new Alta_TipoPlanta();
            Alta_TipoPlanta.Show();
        }

        private void btn_ModificarTipoPlanta_Click(object sender, EventArgs e)
        {
            Modificacion_TipoPlanta Modif = new Modificacion_TipoPlanta();
            if (Grid_TipoPlanta.CurrentCell.Value == null)
            {
                MessageBox.Show("No se selecciono ninguna planta para modificar");
            }
            else
            {
                Modif.ID = Grid_TipoPlanta.CurrentRow.Cells[0].Value.ToString();
                Modif.ShowDialog();
                Modif.Dispose();
            }
        }

        private void btn_EliminarTipoPlanta_Click(object sender, EventArgs e)
        {
            if (Grid_TipoPlanta.CurrentCell.Value == null)
            {
                MessageBox.Show("No se selecciono ninguna planta para eliminar");
            }
            else
            {
                string ID = Grid_TipoPlanta.CurrentRow.Cells[0].Value.ToString();
                DialogResult dialogResult = MessageBox.Show("¿Esta seguro que desea eliminar la planta seleccionada?", "IMPORTANTE", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (dialogResult == DialogResult.Yes)
                {
                    tipoPlanta.Eliminar(ID);
                    Cargar_Grilla(tipoPlanta.Tipo_Plantas_Activas());
                }
            }
        }
    }
}
