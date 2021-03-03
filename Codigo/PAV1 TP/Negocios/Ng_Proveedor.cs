using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using PAV1_TP.Clases;
using PAV1_TP.Negocios.EstructurasNegocios;

namespace PAV1_TP.Negocios
{
    class Ng_Proveedor
    {
        Be_BaseDeDatos _BD = new Be_BaseDeDatos();
        public DataTable Proveedores_Activos()
        {
            string sql = "SELECT * FROM Proveedor WHERE Estado = 1";
            DataTable tabla = new DataTable();
            tabla = _BD.Consulta(sql);
            return tabla;
        }
        public DataTable Todos_Los_Proveedores()
        {
            string sql = "SELECT * FROM Proveedor WHERE Estado = 1 or Estado = 2";
            DataTable tabla = new DataTable();
            tabla = _BD.Consulta(sql);
            return tabla;
        }
        public DataTable Proveedores_Inactivos()
        {
            string sql = "SELECT * FROM Proveedor WHERE Estado = 2";
            DataTable tabla = new DataTable();
            tabla = _BD.Consulta(sql);
            return tabla;
        }
        public DataTable Buscar_Proveedor(string ID_prov, string nom_prov, string rs_prov)
        {
            string sql = "SELECT * FROM Proveedor WHERE ID LIKE '%" + ID_prov + "%' AND Nombre LIKE '%" + nom_prov+ "%' AND Razon_Social LIKE '%" + rs_prov + "%'";
            DataTable tabla = new DataTable();
            tabla = _BD.Consulta(sql);
            return tabla;
        }
        public DataTable Recuperar_Usuario(string ID)
        {
            return _BD.Consulta("SELECT * FROM Proveedor WHERE ID = " + ID);
        }
        public string NuevoId()
        {
            DataTable tabla = new DataTable();
            string sql = "SELECT * FROM Proveedor";
            tabla = _BD.Consulta(sql);
            int id = tabla.Rows.Count;
            int NuevaId = id + 1;
            return NuevaId.ToString();
        }
        public string Insertar(Es_Proveedor datos)
        {

            string sqlInsert = @"INSERT INTO Proveedor(ID,Nombre, Calle, Nro_Calle
                                 , Barrio, Localidad, Telefono, Razon_Social, Estado) VALUES (";
            sqlInsert += "'" + datos.ID + "'";
            sqlInsert += ",'" + datos.Nombre + "'";
            sqlInsert += ", '" + datos.Calle + "'";
            sqlInsert += ", '" + datos.Nro_Calle + "'";
            sqlInsert += ", '" + datos.Barrio + "'";
            sqlInsert += ", '" + datos.Localidad + "'";
            sqlInsert += ", '" + datos.Telefono + "'";
            sqlInsert += ", '" + datos.Razon_Social + "'";
            sqlInsert += ", '" + datos.Estado + "')";

            return _BD.Insertar(sqlInsert);

        }
        public void Modificar(Es_Proveedor datos)
        {
            string sqlUpdate = "UPDATE Proveedor SET ";
            sqlUpdate += "Nombre = " + _BD.FormatearDato(datos.Nombre, "String");
            sqlUpdate += ", Calle = " + _BD.FormatearDato(datos.Calle, "String");
            sqlUpdate += ", Nro_Calle = " + _BD.FormatearDato(datos.Nro_Calle, "String");
            sqlUpdate += ", Localidad = " + _BD.FormatearDato(datos.Localidad, "String");
            sqlUpdate += ", Barrio = " + _BD.FormatearDato(datos.Barrio, "String");
            sqlUpdate += ", Telefono = " + _BD.FormatearDato(datos.Telefono, "String");
            sqlUpdate += ", Estado = " + _BD.FormatearDato(datos.Estado, "String");
            sqlUpdate += " WHERE ID = " + datos.ID;



            _BD.Modificar(sqlUpdate);

        }
        public void Eliminar(string ID)
        {
            string sqlEliminar = "UPDATE Proveedor SET Estado = 2 WHERE ID = " + ID;
            _BD.Modificar(sqlEliminar);

        }

    }
}
