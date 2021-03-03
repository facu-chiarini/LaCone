using PAV1_TP.Formularios.Producto.TipoProducto;
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

namespace PAV1_TP.Formularios.Producto
{
    public partial class ABM_Productos : Form
    {
        Ng_Producto producto = new Ng_Producto();
        public ABM_Productos()
        {
            InitializeComponent();
        }

        private void ABM_Productos_Load(object sender, EventArgs e)
        {

        }
        private void Cargar_Grilla(DataTable tabla)
        {
            Grid_Producto.Rows.Clear();

            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                Grid_Producto.Rows.Add();
                Grid_Producto.Rows[i].Cells[0].Value = tabla.Rows[i]["Codigo"].ToString();
                Grid_Producto.Rows[i].Cells[1].Value = tabla.Rows[i]["Nombre"].ToString();
                Grid_Producto.Rows[i].Cells[2].Value = tabla.Rows[i]["Tipo"].ToString();
                Grid_Producto.Rows[i].Cells[3].Value = tabla.Rows[i]["Stock"].ToString();
                Grid_Producto.Rows[i].Cells[4].Value = tabla.Rows[i]["Precio"].ToString();
                Grid_Producto.Rows[i].Cells[5].Value = tabla.Rows[i]["Costo"].ToString();
            }
        }

        private void btn_AgregarProveedor_Click(object sender, EventArgs e)
        {
            Form Alta_Producto = new Alta_Producto();
            Alta_Producto.Show();
        }

        private void btn_ModifProveedor_Click(object sender, EventArgs e)
        {
            Modificacion_Producto Modif = new Modificacion_Producto();
            if (Grid_Producto.CurrentCell == null)
            {
                MessageBox.Show("No se selecciono ningun catalogo para modificar");
            }
            else
            {
                Modif.ID = Grid_Producto.CurrentRow.Cells[0].Value.ToString();
                Modif.ShowDialog();
                Modif.Dispose();
            }
        }

        private void btn_ConsultarProducto_Click(object sender, EventArgs e)
        {
            if (chk_ActivosProducto.Checked == true && chk_InacctivosProducto.Checked == true)
            {
                Cargar_Grilla(producto.Todos_Los_Productos());
                return;
            }
            if(chk_ActivosProducto.Checked == true)
            {
                Cargar_Grilla(producto.Productos_Activos());
                return;
            }
            if (chk_InacctivosProducto.Checked == true)
            {
                Cargar_Grilla(producto.Productos_Inactivos());
                return;
            }
            if (txt_IdProducto.Text == "" && txt_NombreProducto.Text == "" && txt_TipoProducto.Text == "")
            {
                MessageBox.Show("No hay restricciones para realizar la búsqueda");
                return;
            }
            if (txt_IdProducto.Text != "" || txt_NombreProducto.Text != "" || txt_TipoProducto.Text != "")
            {
                Cargar_Grilla(producto.Buscar_Producto(txt_IdProducto.Text, txt_NombreProducto.Text, txt_TipoProducto.Text));
            }
        }

        private void btn_CancelarProducto_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_EliminarProducto_Click(object sender, EventArgs e)
        {
            if (Grid_Producto.CurrentCell.Value == null)
            {
                MessageBox.Show("No se selecciono ningun producto para eliminar");
            }
            else
            {
                string ID = Grid_Producto.CurrentRow.Cells[0].Value.ToString();
                DialogResult dialogResult = MessageBox.Show("¿Esta seguro que desea eliminar el usuario seleccionado?", "IMPORTANTE", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (dialogResult == DialogResult.Yes)
                {
                    producto.Eliminar(ID);
                }
            }
        }

        private void btn_TipoPlanta_Click(object sender, EventArgs e)
        {
            Form ABM_TipoProducto = new ABM_TipoProducto();
            ABM_TipoProducto.Show();
        }
    }
}
