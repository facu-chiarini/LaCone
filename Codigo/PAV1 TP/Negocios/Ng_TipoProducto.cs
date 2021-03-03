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
    class Ng_TipoProducto
    {
        Be_BaseDeDatos _BD = new Be_BaseDeDatos();

        public DataTable Tipo_Producto_Activos()
        {
            string sql = "SELECT * FROM TipoProducto WHERE Estado = 1";
            DataTable tabla = new DataTable();
            tabla = _BD.Consulta(sql);
            return tabla;
        }
        public DataTable Tipo_Producto_Inactivos()
        {
            string sql = "SELECT * FROM TipoProducto WHERE Estado = 2";
            DataTable tabla = new DataTable();
            tabla = _BD.Consulta(sql);
            return tabla;
        }
        public DataTable Todos_Tipos_Producto()
        {
            string sql = "SELECT * FROM TipoProducto";
            DataTable tabla = new DataTable();
            tabla = _BD.Consulta(sql);
            return tabla;
        }
        public string NuevoId()
        {
            DataTable tabla = new DataTable();
            string sql = "SELECT * FROM TipoProducto";
            tabla = _BD.Consulta(sql);
            int id = tabla.Rows.Count;
            int NuevaId = id + 1;
            return NuevaId.ToString();
        }
        public DataTable Recuperar_Tipo_Producto(string ID)
        {
            return _BD.Consulta("SELECT * FROM TipoProducto WHERE ID = " + ID);
        }
        public DataTable Buscar_TipoProducto(string ID, string Nombre)
        {
            string sql = "SELECT * FROM TipoProducto WHERE ID LIKE '%" + ID + "%' AND Nombre LIKE '%" + Nombre + "%'";
            DataTable tabla = new DataTable();
            tabla = _BD.Consulta(sql);
            return tabla;
        }
        public string Insertar(Es_TipoProducto datos)
        {

            string sqlInsert = @"INSERT INTO TipoProducto(ID, Nombre, Descripcion, Estado) VALUES (";
            sqlInsert += "'" + datos.ID + "'";
            sqlInsert += ",'" + datos.Nombre + "'";
            sqlInsert += ", '" + datos.Descripcion + "'";
            sqlInsert += ", '" + datos.Estado + "')";

            return _BD.Insertar(sqlInsert);

        }
        public void Modificar(Es_TipoProducto datos)
        {
            string sqlUpdate = "UPDATE TipoProducto SET ";
            sqlUpdate += "Nombre = " + _BD.FormatearDato(datos.Nombre, "String");
            sqlUpdate += ", Descripcion = " + _BD.FormatearDato(datos.Descripcion, "String");
            sqlUpdate += ", Estado = " + _BD.FormatearDato(datos.Estado, "String");
            sqlUpdate += " WHERE ID = " + datos.ID;

            _BD.Modificar(sqlUpdate);
        }
        public void Eliminar(string ID)
        {
            string sqlEliminar = "UPDATE TipoProducto SET Estado = 2 WHERE ID = " + ID;
            _BD.Modificar(sqlEliminar);

        }
    }
}
