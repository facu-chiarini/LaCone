using PAV1_TP.Clases;
using PAV1_TP.Negocios;
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
using PAV1_TP.Formularios.Puntos;

namespace PAV1_TP.Formularios.Cargas
{
    public partial class Frm_GenerarFactura : Form
    {
        Be_BaseDeDatos _BD = new Be_BaseDeDatos();
        Ng_Factura factura = new Ng_Factura();
        TratamientosEspeciales te = new TratamientosEspeciales();
        Ng_Producto producto = new Ng_Producto();
        Ng_Planta planta = new Ng_Planta();
        Ng_Cliente cliente = new Ng_Cliente();
        Es_Cliente clientes = new Es_Cliente();
        string tipoDoc { get; set; }
        public Frm_GenerarFactura()
        {
            InitializeComponent();
        }

        private void Frm_GenerarFactura_Load(object sender, EventArgs e)
        {
            cmb_TipoFactura.Cargar();
            cmb_Plantas.Cargar();
            cmb_Productos.Cargar();
            grid_Plantas.Formatear("id,30;Nombre,130;Cantidad,70;Valor,70");
            grid_Productos.Formatear("id,30;Nombre,130;Cantidad,70;Valor,70");
        }

        private void labelText014_Load(object sender, EventArgs e)
        {

        }

        private void btn_BuscarCliente_Click(object sender, EventArgs e)
        {
        }

        private void btn_AgregarPlanta_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmb_Plantas.Text))
            {
                MessageBox.Show("No se seleccionó ninguna planta");

            }
            else
            {
                if (txt_CantidadPlant.Text.ToString() == "")
                {
                    MessageBox.Show("Falta cargar la cantidad ");
                    txt_CantidadPlant.Focus();

                }
                else
                {
                    grid_Plantas.Rows.Add();
                    int ind = grid_Plantas.Rows.Count - 1;
                    grid_Plantas.Rows[ind].Cells[0].Value = cmb_Plantas.SelectedValue.ToString();
                    grid_Plantas.Rows[ind].Cells[1].Value = cmb_Plantas.Text;
                    grid_Plantas.Rows[ind].Cells[2].Value = txt_CantidadPlant.Text;
                    grid_Plantas.Rows[ind].Cells[3].Value = txt_ValorPlanta.Text;
                }
            }
        }

        private void cmb_Plantas_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = planta.Recuperar_Planta(cmb_Plantas.SelectedValue.ToString());
            txt_ValorPlanta.Text = tabla.Rows[0]["Precio"].ToString();
        }

        private void cmb_Productos_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = producto.RecuperarProducto(cmb_Productos.SelectedValue.ToString());
            txt_ValorProd.Text = tabla.Rows[0]["Precio"].ToString();
        }

        private void btn_AgregarProd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmb_Productos.Text))
            {
                MessageBox.Show("No se seleccionó ningún producto");

            }
            else
            {
                if (txt_CantidadProd.Text.ToString() == "")
                {
                    MessageBox.Show("Falta cargar la cantidad");
                    txt_CantidadProd.Focus();
                }
                else
                {
                    grid_Productos.Rows.Add();
                    int ind = grid_Productos.Rows.Count - 1;
                    grid_Productos.Rows[ind].Cells[0].Value = cmb_Productos.SelectedValue.ToString();
                    grid_Productos.Rows[ind].Cells[1].Value = cmb_Productos.Text;
                    grid_Productos.Rows[ind].Cells[2].Value = txt_CantidadProd.Text;
                    grid_Productos.Rows[ind].Cells[3].Value = txt_ValorProd.Text;
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (te.ValidarFecha(ltxt_Fecha.Pp_Text) == TratamientosEspeciales.Validacion.incorrecta)
            {
                ltxt_Fecha.Focus();
                return;
            }
            if (grid_Plantas.Rows.Count == 0 && grid_Productos.Rows.Count == 0)
            {
                MessageBox.Show("No se cargo ninguna plata o producto");
            }
            else
            {
                DataTable tabla = new DataTable();
                tabla = factura.RecuperarCliente(txt_NroDoc.Text.ToString());

                DataTable tabla2 = new DataTable();
                tabla2 = factura.RecuperarEmp(txt_IdEmpleado.Text.ToString());

                DataTable tabla3 = new DataTable();
                tabla3 = factura.RecuperarTipoDoc(txt_NroDoc.Text.ToString());

                

                if (tabla.Rows.Count > 0)
                {
                    if (tabla2.Rows.Count > 0)
                    {
                        if (txt_Monto.Text.ToString() != "")
                        {
                            tipoDoc = tabla3.Rows[0]["TipoDoc"].ToString();
                            factura.insertar(cmb_TipoFactura.SelectedValue.ToString(), factura.NuevoId(), tipoDoc, txt_NroDoc.Text,
                            ltxt_Fecha.Pp_Text, txt_IdEmpleado.Text, txt_Monto.Text, grid_Plantas, grid_Productos);
                            Form CargaPuntos = new Frm_CargaPuntos();
                            CargaPuntos.Show();
                            
                        }
                        else
                        {
                            MessageBox.Show("Falta calcular el monto");
                            
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se encontró el Empleado");
                    }
                    
                }
                else
                {
                    MessageBox.Show("El cliente no está registrado");
                }
            }   

        }

        private void btn_Fehca_Click(object sender, EventArgs e)
        {
            ltxt_Fecha.Pp_Text = _BD.Fecha();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int total = 0;
            if (grid_Plantas.Rows.Count == 0 && grid_Productos.Rows.Count == 0)
            {
                MessageBox.Show("No se selecciono ninguna planta o producto");
            }
            else
            {
                foreach (DataGridViewRow row in grid_Plantas.Rows)
                {
                    total += (Convert.ToInt32(row.Cells[3].Value) * Convert.ToInt32(row.Cells[2].Value));
                }
                foreach (DataGridViewRow row in grid_Productos.Rows)
                {
                    total += (Convert.ToInt32(row.Cells[3].Value) * Convert.ToInt32(row.Cells[2].Value));
                }
                txt_Monto.Text = total.ToString();
            }
        }
    }
}
