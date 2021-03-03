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

namespace PAV1_TP.Formularios.Clientes
{
	public partial class ABM_Clientes : Form
	{
		Ng_Cliente Cliente = new Ng_Cliente();

		public ABM_Clientes()
		{
			InitializeComponent();
		}

		private void ABM_Cliente_Load(object sender, EventArgs e)
		{

		}

		private void btn_ConsultarCli_Click(object sender, EventArgs e)
		{
			if (chk_ClientesActivos.Checked == true && chk_ClientesInactivos.Checked == true)
			{
				Cargar_Grilla(Cliente.TodosLosClientes());
				return;
			}
			if (chk_ClientesActivos.Checked == true)
			{
				Cargar_Grilla(Cliente.ClientesActivos());
				return;
			}
			if (chk_ClientesInactivos.Checked == true)
			{
				Cargar_Grilla(Cliente.ClientesInactivos());
				return;
			}
			if (txt_NDocCliente.Text == "" && txt_NombreCliente.Text == "" && txt_ApellidoCliente.Text == "")
			{
				MessageBox.Show("No hay restricciones para realizar la búsqueda");
				return;
			}

			if (txt_NDocCliente.Text != "" || txt_NombreCliente.Text != "" || txt_ApellidoCliente.Text != "")
			{
				Cargar_Grilla(Cliente.BuscarClienteConTodosLosDatos(txt_NDocCliente.Text, txt_NombreCliente.Text, txt_ApellidoCliente.Text));
			}
		}

		private void Cargar_Grilla(DataTable tabla)
		{
			Grid_Cliente.Rows.Clear();

			for (int i = 0; i < tabla.Rows.Count; i++)
			{
				Grid_Cliente.Rows.Add();
				Grid_Cliente.Rows[i].Cells[0].Value = tabla.Rows[i]["NroDoc"].ToString();
				Grid_Cliente.Rows[i].Cells[1].Value = tabla.Rows[i]["Nombre"].ToString();
				Grid_Cliente.Rows[i].Cells[2].Value = tabla.Rows[i]["Apellido"].ToString();
				Grid_Cliente.Rows[i].Cells[3].Value = tabla.Rows[i]["Telefono"].ToString();
				Grid_Cliente.Rows[i].Cells[4].Value = tabla.Rows[i]["Calle"].ToString();
				Grid_Cliente.Rows[i].Cells[5].Value = tabla.Rows[i]["NroCalle"].ToString();
				Grid_Cliente.Rows[i].Cells[6].Value = tabla.Rows[i]["Email"].ToString();

			}
		}

		private void btn_AgregarCli_Click(object sender, EventArgs e)
		{
			Form Alta_Clientes = new Alta_Clientes();
			Alta_Clientes.Show();
		}

		private void btn_EditarCli_Click(object sender, EventArgs e)
		{
			Modificacion_Cliente Modif = new Modificacion_Cliente();
			if (Grid_Cliente.CurrentCell.Value == null)
			{
				MessageBox.Show("No se selecciono ningun cliente para modificar");
			}
			else
			{
				Modif.DNI = Grid_Cliente.CurrentRow.Cells[0].Value.ToString();
				Modif.NroDoc = Grid_Cliente.CurrentRow.Cells[0].Value.ToString();
				Modif.ShowDialog();
				Modif.Dispose();
			}

		}

		private void btn_EliminarCli_Click(object sender, EventArgs e)
		{
			if (Grid_Cliente.CurrentCell.Value == null)
			{
				MessageBox.Show("No se selecciono ningun cliente para eliminar");
			}
			else
			{
				string DNI = Grid_Cliente.CurrentRow.Cells[0].Value.ToString();
				DialogResult dialogResult = MessageBox.Show("¿Esta seguro que desea eliminar el cliente seleccionado?", "IMPORTANTE", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
				if (dialogResult == DialogResult.Yes)
				{
					Cliente.Eliminar(DNI);
					Cargar_Grilla(Cliente.ClientesActivos());
				}
			}
		}


		private void btn_SalirCli_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
