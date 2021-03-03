using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PAV1_TP.Clases;
using System.Data;
using System.Windows.Forms;
using PAV1_TP.Negocios.EstructurasNegocios;

namespace PAV1_TP.Negocios
{
    class Ng_Empleados
    {
        public enum Respuesta { validacion_correcta, validacion_incorrecta };
        Be_BaseDeDatos _BD = new Be_BaseDeDatos();
        public Respuesta Validar_usuario(string usr, string pssw)
        {
            string sql = "";
            sql = "SELECT * FROM Empleado WHERE Nombre = '" + usr + "' AND Contraseña = '" + pssw + "'";
            DataTable tabla = new DataTable();
            tabla = _BD.Consulta(sql);

            if (tabla.Rows.Count == 0)
            {
                return Respuesta.validacion_incorrecta;
            }
            else
            {
                return Respuesta.validacion_correcta;
            }

        }
        public int Recuperar_id(string usr, string pssw)
        {
            string sql = "";
            sql = "SELECT * FROM Empleado WHERE Nombre = '" + usr + "' AND Contraseña= '" + pssw + "'";
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
        public DataTable Recuperar_Usuario (string ID)
        {
            return _BD.Consulta("SELECT * FROM Empleado WHERE ID = "+ ID);
        }

        public DataTable Empleados_Activos()
        {
            string sql = "SELECT * FROM Empleado WHERE Estado = 1";
            DataTable tabla = new DataTable();
            tabla = _BD.Consulta(sql);
            return tabla;
        }
        public DataTable Empleados_Inactivos()
        {
            string sql = "SELECT * FROM Empleado WHERE Estado = 2";
            DataTable tabla = new DataTable();
            tabla = _BD.Consulta(sql);
            return tabla;
        }
        public DataTable Todos_Los_Empleados()
        {
            string sql = "SELECT * FROM Empleado WHERE Estado = 1 or Estado = 2";
            DataTable tabla = new DataTable();
            tabla = _BD.Consulta(sql);
            return tabla;
        }
        public DataTable Buscar_empleado(string ID_emp, string nom_emp, string ap_emp)
        {
            string sql = "SELECT * FROM Empleado WHERE ID LIKE '%" + ID_emp + "%' AND Nombre LIKE '%" + nom_emp + "%' AND Apellido LIKE '%" + ap_emp + "%'";
            DataTable tabla = new DataTable();
            tabla = _BD.Consulta(sql);
            return tabla;
        }

        public string NuevoId()
        {
            DataTable tabla = new DataTable();
            string sql = "SELECT * FROM Empleado";
            tabla = _BD.Consulta(sql);
            int id = tabla.Rows.Count;
            int NuevaId = id + 1;
            return NuevaId.ToString();
        }
        
        
        public string Insertar(Es_Empleado datos)
        {
            
            string sqlInsert = @"INSERT INTO Empleado(ID,Nombre, Apellido, Telefono, Calle, Nro_Calle
                                 , Barrio, Localidad, Contraseña, Estado) VALUES (";
            sqlInsert += " '" + datos.ID + "'"; 
            sqlInsert += ", '" + datos.Nombre + "'";
            sqlInsert += ", '" + datos.Apellido + "'";
            sqlInsert += ", '" + datos.Telefono + "'";
            sqlInsert += ", '" + datos.Calle + "'";
            sqlInsert += ", '" + datos.Nro_Calle + "'";
            sqlInsert += ", '" + datos.Barrio + "'";
            sqlInsert += ", '" + datos.Localidad + "'";
            sqlInsert += ", '" + datos.Contraseña + "'";
            sqlInsert += ", '" + datos.Estado + "')";

            return _BD.Insertar(sqlInsert);

        }

        public void Modificar(Es_Empleado datos)
        {
            string sqlUpdate = "UPDATE Empleado SET ";
            sqlUpdate += "Nombre = " + _BD.FormatearDato(datos.Nombre, "String");
            sqlUpdate += ", Apellido = " + _BD.FormatearDato(datos.Apellido, "String");
            sqlUpdate += ", Contraseña = " + _BD.FormatearDato(datos.Contraseña, "String");
            sqlUpdate += ", Telefono = " + _BD.FormatearDato(datos.Telefono, "String");
            sqlUpdate += ", Calle = " + _BD.FormatearDato(datos.Calle, "String");
            sqlUpdate += ", Nro_Calle = " + _BD.FormatearDato(datos.Nro_Calle, "String");
            sqlUpdate += ", Localidad = " + _BD.FormatearDato(datos.Localidad, "String");
            sqlUpdate += ", Barrio = " + _BD.FormatearDato(datos.Barrio, "String");
            sqlUpdate += ", Estado = " + _BD.FormatearDato(datos.Estado, "String");
            sqlUpdate += " WHERE ID = " + datos.ID;
            
           
            
            _BD.Modificar(sqlUpdate);

        }

        public void Eliminar(string ID)
        {
            string sqlEliminar = "UPDATE Empleado SET Estado = 2 WHERE ID = " + ID;
            _BD.Modificar(sqlEliminar);

        }
            
    }
}
