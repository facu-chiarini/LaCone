using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PAV1_TP.Clases;
using System.Data;
using PAV1_TP.Negocios.EstructurasNegocios;

namespace PAV1_TP.Negocios
{
    class Ng_TipoPlanta
    {
        Be_BaseDeDatos _BD = new Be_BaseDeDatos();

        public DataTable Tipo_Plantas_Activas()
        {
            string sql = "SELECT * FROM TipoPlanta WHERE Estado = 1";
            DataTable tabla = new DataTable();
            tabla = _BD.Consulta(sql);
            return tabla;
        }
        public DataTable Tipo_Plantas_Inactivas()
        {
            string sql = "SELECT * FROM TipoPlanta WHERE Estado = 2";
            DataTable tabla = new DataTable();
            tabla = _BD.Consulta(sql);
            return tabla;
        }
        public DataTable Todos_Tipos_Plantas()
        {
            string sql = "SELECT * FROM TipoPlanta";
            DataTable tabla = new DataTable();
            tabla = _BD.Consulta(sql);
            return tabla;
        }
        public string NuevoId()
        {
            DataTable tabla = new DataTable();
            string sql = "SELECT * FROM TipoPlanta";
            tabla = _BD.Consulta(sql);
            int id = tabla.Rows.Count;
            int NuevaId = id + 1;
            return NuevaId.ToString();
        }
        public DataTable Recuperar_Tipo_Planta(string ID)
        {
            return _BD.Consulta("SELECT * FROM TipoPlanta WHERE ID = " + ID);
        }
        public DataTable Buscar_Planta(string ID, string Nombre)
        {
            string sql = "SELECT * FROM TipoPlanta WHERE ID LIKE '%" + ID + "%' AND Nombre LIKE '%" + Nombre + "%'";
            DataTable tabla = new DataTable();
            tabla = _BD.Consulta(sql);
            return tabla;
        }
        public string Insertar(Es_TipoPlanta datos)
        {

            string sqlInsert = @"INSERT INTO TipoPlanta(ID, Nombre, Descripcion, Estado) VALUES (";
            sqlInsert += "'" + datos.ID + "'";
            sqlInsert += ",'" + datos.Nombre + "'";
            sqlInsert += ", '" + datos.Descripcion + "'";
            sqlInsert += ", '" + datos.Estado + "')";

            return _BD.Insertar(sqlInsert);

        }
        public void Modificar(Es_TipoPlanta datos)
        {
            string sqlUpdate = "UPDATE TipoPlanta SET ";
            sqlUpdate += "Nombre = " + _BD.FormatearDato(datos.Nombre, "String");
            sqlUpdate += ", Descripcion = " + _BD.FormatearDato(datos.Descripcion, "String");
            sqlUpdate += ", Estado = " + _BD.FormatearDato(datos.Estado, "String");
            sqlUpdate += " WHERE ID = " + datos.ID;

            _BD.Modificar(sqlUpdate);
        }
        public void Eliminar(string ID)
        {
            string sqlEliminar = "UPDATE TipoPlanta SET Estado = 2 WHERE ID = " + ID;
            _BD.Modificar(sqlEliminar);

        }
    }
}

