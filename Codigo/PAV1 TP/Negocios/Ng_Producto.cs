using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using PAV1_TP.Clases;
using PAV1_TP.Negocios.EstructurasNegocios;

namespace PAV1_TP.Negocios
{
    class Ng_Producto
    {
        Be_BaseDeDatos _BD = new Be_BaseDeDatos();
        public DataTable Productos_Activos()
        {
            string sql = "SELECT * FROM Producto WHERE Estado = 1";
            DataTable tabla = new DataTable();
            tabla = _BD.Consulta(sql);
            return tabla;
        }
        public DataTable Productos_Inactivos()
        {
            string sql = "SELECT * FROM Producto WHERE Estado = 2";
            DataTable tabla = new DataTable();
            tabla = _BD.Consulta(sql);
            return tabla;
        }
        public DataTable Todos_Los_Productos()
        {
            string sql = "SELECT * FROM Producto WHERE Estado = 1 or Estado = 2";
            DataTable tabla = new DataTable();
            tabla = _BD.Consulta(sql);
            return tabla;
        }
        public DataTable Buscar_Producto(string Cod_prod, string nom_prod, string tipo_prod)
        {
            string sql = "SELECT * FROM Producto WHERE Codigo LIKE '%" + Cod_prod + "%' AND Nombre LIKE '%" + nom_prod + "%' AND Tipo LIKE '%" + tipo_prod + "%'";
            DataTable tabla = new DataTable();
            tabla = _BD.Consulta(sql);
            return tabla;
        }
        public int Recuperar_id(string Prod)
        {

            string sql = "SELECT * FROM Producto WHERE Nombre = '" + Prod + "'";
            DataTable tabla = new DataTable();
            tabla = _BD.Consulta(sql);

            if (tabla.Rows.Count == 0)
            {
                return 0;
            }
            else
            {
                return int.Parse(tabla.Rows[0]["Codigo"].ToString());
            }
        }
        public int Recuperar_idCompuesto(string Composicion)
        {

            string sql = "SELECT * FROM Producto WHERE Composicion = '" + Composicion + "'";
            DataTable tabla = new DataTable();
            tabla = _BD.Consulta(sql);

            if (tabla.Rows.Count == 0)
            {
                return 0;
            }
            else
            {
                return int.Parse(tabla.Rows[0]["ID"].ToString());
            }
        }

        public string NuevoId()
        {
            DataTable tabla = new DataTable();
            string sql = "SELECT * FROM Producto";
            tabla = _BD.Consulta(sql);
            int id = tabla.Rows.Count;
            int NuevaId = id;
            return NuevaId.ToString();
        }
        public string NuevoIdComposicion()
        {
            DataTable tabla = new DataTable();
            string sql = "SELECT * FROM Composicion";
            tabla = _BD.Consulta(sql);
            int id = tabla.Rows.Count;
            int NuevaIdComposicion = id + 1;
            return NuevaIdComposicion.ToString();
        }
        public string Insertar(Es_Producto datos)
        {

            string sqlInsert = @"INSERT INTO Producto(Codigo, Nombre, Tipo, Stock, Costo, Precio
                                 , Composicion, Estado) VALUES (";
            sqlInsert += "'" + datos.Codigo + "'";
            sqlInsert += ",'" + datos.Nombre + "'";
            sqlInsert += ", '" + datos.Tipo + "'";
            sqlInsert += ", '" + datos.Stock + "'";
            sqlInsert += ", '" + datos.Costo + "'";
            sqlInsert += ", '" + datos.Precio + "'";
            sqlInsert += ", '" + datos.Composicion + "'";
            sqlInsert += ", '" + datos.Estado + "')";

            return _BD.Insertar(sqlInsert);

        }
        public string InsertarCompuesto(Es_ProductoCompuesto datos)
        {

            string sqlInsert = @"INSERT INTO Composicion(ID,Cod_Prod_Compuesto, Cod_Prod_Componente, Cant_Compuesto, Cant_Componente) VALUES (";
            sqlInsert += "'" + datos.ID + "'";
            sqlInsert += ",'" + datos.Cod_Prod_Compuesto + "'";
            sqlInsert += ",'" + datos.Cod_Prod_Componente + "'";
            sqlInsert += ", '" + datos.Cant_Compuesto + "'";
            sqlInsert += ", '" + datos.Cant_Componente + "')";

            return _BD.Insertar(sqlInsert);

        }

        public DataTable RecuperarProducto(string ID)
        {
            DataTable tabla = new DataTable();
            return tabla = _BD.Consulta("SELECT * FROM Producto WHERE Codigo = " + ID);

        }

        public DataTable RecuperarTipoProducto(string ID)
        {
            DataTable tabla = new DataTable();
            return tabla = _BD.Consulta("SELECT * FROM TipoProducto WHERE ID = " + ID);

        }

        public DataTable RecuperarComposicion (string ID)
        {
            DataTable tabla = new DataTable();
            return tabla = _BD.Consulta("SELECT * FROM Composicion WHERE ID = " + ID );
        }

        public void ModificarProducto(Es_Producto dato)
        {
            string sqlUpdate = "UPDATE Producto SET ";
            sqlUpdate += "Nombre = " + _BD.FormatearDato(dato.Nombre.ToString(), "String");
            sqlUpdate += ", Tipo = " + _BD.FormatearDato(dato.Tipo, "String");
            sqlUpdate += ", Stock = " + _BD.FormatearDato(dato.Stock, "String");
            sqlUpdate += ", Costo = " + _BD.FormatearDato(dato.Costo, "String");
            sqlUpdate += ", Composicion = " + _BD.FormatearDato(dato.Composicion, "String");
            sqlUpdate += ", Precio = " + _BD.FormatearDato(dato.Precio, "String");
            sqlUpdate += ", Estado = " + _BD.FormatearDato(dato.Estado, "String");
            sqlUpdate += " WHERE Codigo = " + dato.Codigo;
           
            _BD.Modificar(sqlUpdate);
        }

        public void ModificarComposicion(Es_ProductoCompuesto dato)
        {
            string sqlUpdate = "UPDATE Composicion SET ";
            sqlUpdate += "Cod_Prod_Compuesto = " + _BD.FormatearDato(dato.Cod_Prod_Compuesto, "String");
            sqlUpdate += ", Cod_Prod_Componente = " + _BD.FormatearDato(dato.Cod_Prod_Componente, "String");
            sqlUpdate += ", Cant_Compuesto = " + _BD.FormatearDato(dato.Cant_Compuesto, "String");
            sqlUpdate += ", Cant_Componente = " + _BD.FormatearDato(dato.Cant_Componente, "String");
            sqlUpdate += " WHERE ID = " + dato.ID;
            _BD.Modificar(sqlUpdate);
        }

        public void Eliminar(string ID)
        {
            _BD.Modificar("UPDATE Producto SET Estado = 2 WHERE  Codigo = " + ID);
        }

    } 
}
