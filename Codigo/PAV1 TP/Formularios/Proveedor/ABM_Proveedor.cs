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

namespace PAV1_TP.Formularios.Proveedor
{
    public partial class ABM_Proveedor : Form
    {
        Ng_Proveedor proveedor = new Ng_Proveedor();
        public ABM_Proveedor()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form AltaProveedor = new Alta_Proveedor();
            AltaProveedor.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Modificacion_Proveedor Modif = new Modificacion_Proveedor();
            if (Grid_Proveedor.CurrentCell.Value == null)
            {
                MessageBox.Show("No se selecciono ningun proveedor para modificar");
            }
            else
            {
                Modif.ID = Grid_Proveedor.CurrentRow.Cells[0].Value.ToString();
                Modif.ShowDialog();
                Modif.Dispose();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void Cargar_Grilla(DataTable tabla)
        {
            Grid_Proveedor.Rows.Clear();

            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                Grid_Proveedor.Rows.Add();
                Grid_Proveedor.Rows[i].Cells[0].Value = tabla.Rows[i]["ID"].ToString();
                Grid_Proveedor.Rows[i].Cells[1].Value = tabla.Rows[i]["Nombre"].ToString();
                Grid_Proveedor.Rows[i].Cells[2].Value = tabla.Rows[i]["Telefono"].ToString();
                Grid_Proveedor.Rows[i].Cells[3].Value = tabla.Rows[i]["Razon_Social"].ToString();
                Grid_Proveedor.Rows[i].Cells[4].Value = tabla.Rows[i]["Calle"].ToString();
                Grid_Proveedor.Rows[i].Cells[5].Value = tabla.Rows[i]["Nro_Calle"].ToString();
            }
        }

        private void btn_ConsultarProveedor_Click(object sender, EventArgs e)
        {
            if(chk_ActivosProveedores.Checked == true && chk_InactivosProveedor.Checked == true)
            {
                Cargar_Grilla(proveedor.Todos_Los_Proveedores());
                return;
            }
            if (chk_ActivosProveedores.Checked == true)
            {
                Cargar_Grilla(proveedor.Proveedores_Activos());
                return;
            }
            if (chk_InactivosProveedor.Checked == true)
            {
                Cargar_Grilla(proveedor.Proveedores_Inactivos());
                return;
            }
            if (txt_IdProveedor.Text == "" && txt_NombreProveedor.Text == "" && txt_RSProveedor.Text == "")
            {
                MessageBox.Show("No hay restricciones para realizar la búsqueda");
                return;
            }
            if (txt_IdProveedor.Text != "" || txt_NombreProveedor.Text != "" || txt_RSProveedor.Text != "")
            {
                Cargar_Grilla(proveedor.Buscar_Proveedor(txt_IdProveedor.Text, txt_NombreProveedor.Text, txt_RSProveedor.Text));
            }

        }

        private void btn_CancelarProveedor_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Grid_Proveedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_EliminarProveedor_Click(object sender, EventArgs e)
        {
            if (Grid_Proveedor.CurrentCell.Value == null)
            {
                MessageBox.Show("No se selecciono ningun proveedor para eliminar");
            }
            else
            {
                string ID = Grid_Proveedor.CurrentRow.Cells[0].Value.ToString();
                DialogResult dialogResult = MessageBox.Show("¿Esta seguro que desea eliminar el usuario seleccionado?", "IMPORTANTE", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (dialogResult == DialogResult.Yes)
                {
                    proveedor.Eliminar(ID);
                    Cargar_Grilla(proveedor.Proveedores_Activos());
                }
            }

        }
    }
}
