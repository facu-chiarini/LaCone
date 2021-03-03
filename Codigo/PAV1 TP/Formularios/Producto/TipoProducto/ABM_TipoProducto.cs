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

namespace PAV1_TP.Formularios.Producto.TipoProducto
{
    public partial class ABM_TipoProducto : Form
    {
        Ng_TipoProducto tipoProducto = new Ng_TipoProducto();
        public ABM_TipoProducto()
        {
            InitializeComponent();
        }
        private void Cargar_Grilla(DataTable tabla)
        {
            Grid_TipoProducto.Rows.Clear();

            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                Grid_TipoProducto.Rows.Add();
                Grid_TipoProducto.Rows[i].Cells[0].Value = tabla.Rows[i]["ID"].ToString();
                Grid_TipoProducto.Rows[i].Cells[1].Value = tabla.Rows[i]["Nombre"].ToString();
                Grid_TipoProducto.Rows[i].Cells[2].Value = tabla.Rows[i]["Descripcion"].ToString();
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ConsultarTipoPlanta_Click(object sender, EventArgs e)
        {
            if (chk_TipoProductosActivos.Checked == true && chk_TipoProductoInactivos.Checked == true)
            {
                Cargar_Grilla(tipoProducto.Todos_Tipos_Producto());
                return;
            }
            if (chk_TipoProductosActivos.Checked == true)
            {
                Cargar_Grilla(tipoProducto.Tipo_Producto_Activos());
                return;
            }
            if (chk_TipoProductoInactivos.Checked == true)
            {
                Cargar_Grilla(tipoProducto.Tipo_Producto_Inactivos());
                return;
            }
            if (txt_IdTipoPlanta.Text == "" && txt_NombreTipoPlanta.Text == "")
            {
                MessageBox.Show("No hay restricciones para realizar la búsqueda");
                return;
            }
            if (txt_IdTipoPlanta.Text != "" || txt_NombreTipoPlanta.Text != "")
            {
                Cargar_Grilla(tipoProducto.Buscar_TipoProducto(txt_IdTipoPlanta.Text, txt_NombreTipoPlanta.Text));
            }
        }

        private void btn_AgregarTipoPlanta_Click(object sender, EventArgs e)
        {
            Form Alta_TipoProducto = new Alta_TipoProducto();
            Alta_TipoProducto.Show();
        }

        private void btn_ModificarTipoProducto_Click(object sender, EventArgs e)
        {
            Modificacion_TipoProducto Modif = new Modificacion_TipoProducto();
            if (Grid_TipoProducto.CurrentCell.Value == null)
            {
                MessageBox.Show("No se selecciono ninguna planta para modificar");
            }
            else
            {
                Modif.ID = Grid_TipoProducto.CurrentRow.Cells[0].Value.ToString();
                Modif.ShowDialog();
                Modif.Dispose();
            }
        }

        private void btn_EliminarTipoPlanta_Click(object sender, EventArgs e)
        {
            if (Grid_TipoProducto.CurrentCell.Value == null)
            {
                MessageBox.Show("No se selecciono ningun tipo de producto para eliminar para eliminar");
            }
            else
            {
                string ID = Grid_TipoProducto.CurrentRow.Cells[0].Value.ToString();
                DialogResult dialogResult = MessageBox.Show("¿Esta seguro que desea eliminar el tipo de producto seleccionado?", "IMPORTANTE", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (dialogResult == DialogResult.Yes)
                {
                    tipoProducto.Eliminar(ID);
                    Cargar_Grilla(tipoProducto.Tipo_Producto_Activos());
                }
            }
        }
    }
}
