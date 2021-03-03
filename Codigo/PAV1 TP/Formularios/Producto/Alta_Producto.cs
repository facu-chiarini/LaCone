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

namespace PAV1_TP.Formularios.Producto
{
    public partial class Alta_Producto : Form
    {
        Ng_Producto producto = new Ng_Producto();
        public Alta_Producto()
        {
            InitializeComponent();
        }

        private void Alta_Producto_Load(object sender, EventArgs e)
        {
            cmb_TipoProducto.Cargar();
            cmb_EstadoProd.Cargar();
            chk_TipoProductos.Cargar2();
        }

        private void btn_RegistrarPlanta_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales tratamiento = new TratamientosEspeciales();
            Es_Producto _ep = new Es_Producto();
            Es_ProductoCompuesto _epc = new Es_ProductoCompuesto();
        
            if (tratamiento.validar(this.Controls) == TratamientosEspeciales.Validacion.correcta)
            {
                if (chk_TipoProductos.CheckedItems.Count > 2)
                {
                    MessageBox.Show("Seleccione solamente 2 productos para la composicion");
                    return;
                }
                if (chk_TipoProductos.CheckedItems.Count < 2 && cmb_TipoProducto.SelectedValue.ToString() == "4")
                {
                    MessageBox.Show("Seleccione  2 productos para la composicion");
                    return;
                }
                if (chk_TipoProductos.CheckedItems.Count > 0 && cmb_TipoProducto.SelectedValue.ToString() != "4")
                {
                    MessageBox.Show("Seleccione tipo compuesto para registrar un producto compuesto");
                    return;
                }
               
                if (cmb_TipoProducto.SelectedValue.ToString() == "4")
                {
                    var items = chk_TipoProductos.CheckedItems.Count;
                    DataTable tabla = new DataTable();
                    _epc.ID = producto.NuevoIdComposicion();
                    _ep.Codigo = producto.NuevoId();

                    for (int i = 0; i <= items ; i++)
                    {
                        _ep.Composicion = producto.NuevoIdComposicion();
                        _ep.Nombre = txt_NombreProducto.Text;
                        _ep.Tipo = cmb_TipoProducto.SelectedValue.ToString();
                        _ep.Stock = txt_StockProducto.Text;
                        _ep.Costo = txt_CostoProd.Text;
                        _ep.Precio = txt_PrecioProducto.Text;
                        _ep.Estado = cmb_EstadoProd.SelectedValue.ToString();
                        string prod_compuesto = chk_TipoProductos.CheckedItems[i].ToString();
                        _epc.Cod_Prod_Compuesto = producto.Recuperar_id(prod_compuesto).ToString();
                        string prod_componente = chk_TipoProductos.CheckedItems[i + 1].ToString();
                        _epc.Cod_Prod_Componente = producto.Recuperar_id(prod_componente).ToString();
                        _epc.Cant_Compuesto = txt_CantProdComp1.Text;
                        _epc.Cant_Componente = txt_CantProdComp2.Text;

                        producto.InsertarCompuesto(_epc);
                        producto.Insertar(_ep);
                        break;
                       

                    }
                    MessageBox.Show("Producto registrado correctamente");
                    this.Close();

                }
                else
                {
                    _ep.Codigo = producto.NuevoId();
                    _ep.Nombre = txt_NombreProducto.Text;
                    _ep.Tipo = cmb_TipoProducto.SelectedValue.ToString();
                    _ep.Stock = txt_StockProducto.Text;
                    _ep.Costo = txt_CostoProd.Text;
                    _ep.Composicion = 0.ToString();
                    _ep.Precio = txt_PrecioProducto.Text;
                    _ep.Estado = cmb_EstadoProd.SelectedValue.ToString();

                    producto.Insertar(_ep);
                    MessageBox.Show("Producto registrado correctamente");
                    this.Close();
                }
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
