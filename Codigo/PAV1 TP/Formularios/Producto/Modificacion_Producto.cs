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
using PAV1_TP.Negocios.EstructurasNegocios;
namespace PAV1_TP.Formularios.Producto
{

    public partial class Modificacion_Producto : Form
    {
        public string ID { get; set; }
        Ng_Producto producto = new Ng_Producto();
        public Modificacion_Producto()
        {
            InitializeComponent();
        }

        private void Modificacion_Producto_Load(object sender, EventArgs e)
        {
            cmb_TipoProducto.Cargar();
            chk_CompuestoProducto.Cargar2();
            cmb_EstadoProd.Cargar();
            //Recuperar la tabla producto
            DataTable tablaProducto = new DataTable();
            tablaProducto = producto.RecuperarProducto(ID);

            //Recuperar la tabla TipoProducto
            DataTable tablaTipoProducto = new DataTable();
            tablaTipoProducto = producto.RecuperarTipoProducto(cmb_TipoProducto.Text = tablaProducto.Rows[0]["Tipo"].ToString());

            //Llenar atributos de producto
            txt_IdProducto.Text = ID;
            txt_NombreProducto.Text = tablaProducto.Rows[0]["Nombre"].ToString();
            cmb_TipoProducto.Text = tablaTipoProducto.Rows[0]["Nombre"].ToString();
            txt_StockProducto.Text = tablaProducto.Rows[0]["Stock"].ToString();
            txt_CostoProd.Text = tablaProducto.Rows[0]["Costo"].ToString();
            txt_PrecioProducto.Text = tablaProducto.Rows[0]["Precio"].ToString();

            int items = int.Parse(chk_CompuestoProducto.SelectedItems.Count.ToString());

            if (tablaProducto.Rows[0]["Composicion"].ToString() != "0")
            {
                //Recuperar tabla de Composición
                DataTable tablaComposicion = new DataTable();
                tablaComposicion = producto.RecuperarComposicion(tablaProducto.Rows[0]["Composicion"].ToString());

                //Llenar atributos de composición
                txt_CantProdComp1.Text = (tablaComposicion.Rows[0]["Cod_Prod_Compuesto"].ToString());
                txt_CantProdComp2.Text = (tablaComposicion.Rows[0]["Cod_Prod_Componente"].ToString());

            }
        }

        private void btn_RegistrarProducto_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales tratamiento = new TratamientosEspeciales();
            Es_Producto _ep = new Es_Producto();
            Es_ProductoCompuesto _epc = new Es_ProductoCompuesto();



            if (tratamiento.validar(this.Controls) == TratamientosEspeciales.Validacion.correcta)
            {

                if (chk_CompuestoProducto.CheckedItems.Count > 2)
                {
                    MessageBox.Show("Seleccione solamente 2 productos para la composicion");
                    return;
                }
                if (chk_CompuestoProducto.CheckedItems.Count < 2 && cmb_TipoProducto.SelectedValue.ToString() == "4")
                {
                    MessageBox.Show("Seleccione  2 productos para la composicion");
                    return;
                }
                if (chk_CompuestoProducto.CheckedItems.Count > 0 && cmb_TipoProducto.SelectedValue.ToString() != "4")
                {
                    MessageBox.Show("Seleccione tipo compuesto para registrar un producto compuesto");
                    return;
                }

                if (cmb_TipoProducto.SelectedValue.ToString() == "4")
                {
                    //recuperar tablas
                    DataTable tablaProducto = new DataTable();
                    tablaProducto = producto.RecuperarProducto(ID);
                    DataTable tablaComposicion = new DataTable();
                    tablaComposicion = producto.RecuperarComposicion(tablaProducto.Rows[0]["Composicion"].ToString());

                    var items = chk_CompuestoProducto.CheckedItems.Count;
                    DataTable tabla = new DataTable();
                    _epc.ID = tablaComposicion.Rows[0]["ID"].ToString();
                    _ep.Codigo = txt_IdProducto.Text;

                    for (int i = 0; i <= items; i++)
                    {
                        _ep.Composicion = tablaComposicion.Rows[0]["ID"].ToString();
                        _ep.Nombre = txt_NombreProducto.Text;
                        _ep.Tipo = cmb_TipoProducto.SelectedValue.ToString();
                        _ep.Stock = txt_StockProducto.Text;
                        _ep.Costo = txt_CostoProd.Text;
                        _ep.Precio = txt_PrecioProducto.Text;
                        _ep.Estado = cmb_EstadoProd.SelectedValue.ToString();
                        string prod_compuesto = chk_CompuestoProducto.CheckedItems[i].ToString();
                        _epc.Cod_Prod_Compuesto = producto.Recuperar_id(prod_compuesto).ToString();
                        string prod_componente = chk_CompuestoProducto.CheckedItems[i + 1].ToString();
                        _epc.Cod_Prod_Componente = producto.Recuperar_id(prod_componente).ToString();
                        _epc.Cant_Compuesto = txt_CantProdComp1.Text;
                        _epc.Cant_Componente = txt_CantProdComp2.Text;

                        producto.ModificarProducto(_ep);
                        producto.ModificarComposicion(_epc);
                        break;


                    }
                    MessageBox.Show("Producto modificado correctamente");
                    this.Close();
                }
                else
                {
                    _ep.Codigo = txt_IdProducto.Text;
                    _ep.Nombre = txt_NombreProducto.Text;
                    _ep.Tipo = cmb_TipoProducto.SelectedValue.ToString();
                    _ep.Stock = txt_StockProducto.Text;
                    _ep.Costo = txt_CostoProd.Text;
                    _ep.Composicion = null;
                    _ep.Precio = txt_PrecioProducto.Text;
                    _ep.Estado = cmb_EstadoProd.SelectedValue.ToString();

                    producto.ModificarProducto(_ep);
                    MessageBox.Show("Producto modificado correctamente");
                    this.Close();
                }
            }
        }

        private void btn_CancelarProducto_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
