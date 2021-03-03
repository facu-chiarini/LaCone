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
    class Ng_Catalogo
    {
        Be_BaseDeDatos _BD = new Be_BaseDeDatos();
        public DataTable Catalogos_Activos()
        {
            string sql = "SELECT * FROM Catalogo WHERE Estado = 1";
            DataTable tabla = new DataTable();
            tabla = _BD.Consulta(sql);
            return tabla;
        }
        public DataTable Catalogos_Inactivos()
        {
            string sql = "SELECT * FROM Catalogo WHERE Estado = 2";
            DataTable tabla = new DataTable();
            tabla = _BD.Consulta(sql);
            return tabla;
        }
        public DataTable Todos_Los_Catalogos()
        {
            string sql = "SELECT * FROM Catalogo WHERE Estado = 1 or Estado = 2";
            DataTable tabla = new DataTable();
            tabla = _BD.Consulta(sql);
            return tabla;
        }
        public DataTable Buscar_Catalogo(string ID_cat, string Idplanta_cat)
        {
            string sql = "SELECT * FROM Catalogo WHERE ID LIKE '%" + ID_cat + "%' AND Id_Planta LIKE '%" + Idplanta_cat + "%'";
            DataTable tabla = new DataTable();
            tabla = _BD.Consulta(sql);
            return tabla;
        }
        public int Recuperar_id(string planta)
        {
            
            string sql = "SELECT * FROM Plantas WHERE NombreComun = '" + planta + "'";
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
        public string NuevoId()
        {
            DataTable tabla = new DataTable();
            string sql = "SELECT DISTINCT ID FROM Catalogo";
            tabla = _BD.Consulta(sql);
            int id = tabla.Rows.Count;
            int NuevaId = id + 1;
            return NuevaId.ToString();
        }
        public DataTable Recuperar_Catalogo(string ID, string IdPlanta)
        {
            return _BD.Consulta("SELECT * FROM Catalogo WHERE ID = " + int.Parse(ID) + " AND Id_Planta = " + int.Parse(IdPlanta));
        }

        public DataTable Recuperar_Planta(string NombrePlanta)
        {
            return _BD.Consulta("SELECT * FROM Plantas WHERE NombreComun = '" + NombrePlanta+ "'");
        }
        public string Insertar(Es_Catalogo datos)
        {

            string sqlInsert = @"INSERT INTO Catalogo(ID,Id_Planta, Puntos_Necesarios, Estado) VALUES (";
            sqlInsert += "'" + datos.ID + "'";
            sqlInsert += ",'" + datos.Id_Planta  + "'";
            sqlInsert += ", '" + datos.Puntos_Necesarios + "'";
            sqlInsert += ", '" + datos.Estado + "')";

            return _BD.Insertar(sqlInsert);

        }
        public void Modificar(Es_Catalogo datos)
        {
            string sqlUpdate = "UPDATE Catalogo SET ";
            sqlUpdate += "ID = " + _BD.FormatearDato(datos.ID, "String");
            sqlUpdate += ", Id_Planta = " + _BD.FormatearDato(datos.Id_Planta.ToString(), "String");
            sqlUpdate += ", Puntos_Necesarios = " + _BD.FormatearDato(datos.Puntos_Necesarios, "String");
            sqlUpdate += ", Estado = " + _BD.FormatearDato(datos.Estado, "String");
            sqlUpdate += " WHERE ID = " + datos.ID;
            sqlUpdate += " AND Id_Planta = " + datos.Idactual;



            _BD.Modificar(sqlUpdate);

        }
        public void ModificarParical(Es_Catalogo datos)
        {
            string sqlUpdate = "UPDATE Catalogo SET ";
            sqlUpdate += "Puntos_Necesarios = " + _BD.FormatearDato(datos.Puntos_Necesarios, "String");
            sqlUpdate += ", Estado = " + _BD.FormatearDato(datos.Estado, "String");
            sqlUpdate += " WHERE ID = " + datos.ID;
            sqlUpdate += " AND Id_Planta = " + datos.Idactual;



            _BD.Modificar(sqlUpdate);

        }
        public void Eliminar(string ID)
        {
            string sqlEliminar = "UPDATE Catalogo SET Estado = 2 WHERE ID = " + ID;
            _BD.Modificar(sqlEliminar);

        }
    }
}
