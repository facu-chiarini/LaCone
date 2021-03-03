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
    class Ng_Planta
    {
        Be_BaseDeDatos _BD = new Be_BaseDeDatos();

        public DataTable Plantas_Activas()
        {
            string sql = "SELECT * FROM Plantas WHERE Estado = 1";
            DataTable tabla = new DataTable();
            tabla = _BD.Consulta(sql);
            return tabla;
        }
        public DataTable Plantas_Inactivas()
        {
            string sql = "SELECT * FROM Plantas WHERE Estado = 2";
            DataTable tabla = new DataTable();
            tabla = _BD.Consulta(sql);
            return tabla;
        }
        public DataTable Todas_las_Plantas()
        {
            string sql = "SELECT * FROM Plantas";
            DataTable tabla = new DataTable();
            tabla = _BD.Consulta(sql);
            return tabla;
        }
        public string NuevoId()
        {
            DataTable tabla = new DataTable();
            string sql = "SELECT * FROM Plantas";
            tabla = _BD.Consulta(sql);
            int id = tabla.Rows.Count;
            int NuevaId = id;
            return NuevaId.ToString();
        }
        public DataTable Recuperar_Planta(string Codigo)
        {
            return _BD.Consulta("SELECT * FROM Plantas WHERE Codigo = " + Codigo);
        }
        public DataTable Buscar_Planta(string Codigo, string NombreComun)
        {
            string sql = "SELECT * FROM Plantas WHERE Codigo LIKE '%" + Codigo + "%' AND NombreComun LIKE '%" + NombreComun + "%'";
            DataTable tabla = new DataTable();
            tabla = _BD.Consulta(sql);
            return tabla;
        }
        public string Insertar(Es_Planta datos)
        {

            string sqlInsert = @"INSERT INTO Plantas(Codigo, NombreCientifico, NombreComun, Tipo, Precio, Stock,Estado) VALUES (";
            sqlInsert += "'" + datos.Codigo + "'";
            sqlInsert += ",'" + datos.NombreCientifico + "'";
            sqlInsert += ", '" + datos.NombreComun + "'";
            sqlInsert += ", '" + datos.Tipo + "'";
            sqlInsert += ", '" + datos.Precio + "'";
            sqlInsert += ", '" + datos.Stock + "'";
            sqlInsert += ", '" + datos.Estado + "')";

            return _BD.Insertar(sqlInsert);

        }
        public void Modificar(Es_Planta datos)
        {
            string sqlUpdate = "UPDATE Plantas SET ";
            sqlUpdate += "NombreCientifico = " + _BD.FormatearDato(datos.NombreCientifico, "String");
            sqlUpdate += ", NombreComun = " + _BD.FormatearDato(datos.NombreComun, "String");
            sqlUpdate += ", Tipo = " + _BD.FormatearDato(datos.Tipo, "String");
            sqlUpdate += ", Precio = " + _BD.FormatearDato(datos.Precio, "String");
            sqlUpdate += ", Stock = " + _BD.FormatearDato(datos.Stock, "String");
            sqlUpdate += ", Estado = " + _BD.FormatearDato(datos.Estado, "String");
            sqlUpdate += " WHERE Codigo = " + datos.Codigo;

            _BD.Modificar(sqlUpdate);
        }
        public void Eliminar(string Codigo)
        {
            string sqlEliminar = "UPDATE Plantas SET Estado = 2 WHERE Codigo = " + Codigo;
            _BD.Modificar(sqlEliminar);

        }
    }
}
