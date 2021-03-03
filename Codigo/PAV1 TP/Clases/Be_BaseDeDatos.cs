using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace PAV1_TP.Clases
{
    class Be_BaseDeDatos
    {
        public enum TipoConexion { simple, transaccional };
        public enum EstadoTransaccion { correcta, error };

        SqlConnection Conexion = new SqlConnection();
        SqlCommand Cmd = new SqlCommand();
        SqlTransaction Transaccion;

        public TipoConexion ControlConexion { get; set; } = TipoConexion.simple;
        public EstadoTransaccion ControlTransaccion { get; set; } = EstadoTransaccion.correcta;
        //Acuerdense de cambiar el link de conexion y poner el de c/uno
        string Cadena_conexion = "Data Source=LAPTOP-C87F44FH;Initial Catalog = Vivero; Integrated Security = True";
        //Cadena Agus: "Data Source=DESKTOP-7MV1FIL;Initial Catalog=Vivero;Integrated Security=True";
        //Cadena Facu: "Data Source=LAPTOP-C87F44FH;Initial Catalog = Vivero; Integrated Security = True";
        public void IniciarTransaccion()
        {
            ControlConexion = TipoConexion.transaccional;
            ControlTransaccion = EstadoTransaccion.correcta;
        }
        public EstadoTransaccion CerrarTransaccion()
        {
            if (ControlConexion == TipoConexion.transaccional)
            {
                if (ControlTransaccion == EstadoTransaccion.correcta)
                {
                    // terminar por commit
                    Transaccion.Commit();
                }
                else
                {
                    // terminar por rollback
                    Transaccion.Rollback();
                }
                ControlConexion = TipoConexion.simple;
                Desconectar();
            }
            return ControlTransaccion;
        }

        private void Conectar()
        {
            if (Conexion.State == ConnectionState.Closed)
            {
                Conexion.ConnectionString = Cadena_conexion;
                Conexion.Open();
                Cmd.Connection = Conexion;
                Cmd.CommandType = System.Data.CommandType.Text;
                if (ControlConexion == TipoConexion.transaccional)
                {
                    Transaccion = Conexion.BeginTransaction(IsolationLevel.ReadCommitted);
                    Cmd.Transaction = Transaccion;
                }
            }
        }

        private void Desconectar()
        {
            if (ControlConexion == TipoConexion.simple)
            {
                Conexion.Close();
            }
        }

        public DataTable Consulta(string sql)
        {
            Conectar();
            Cmd.CommandText = sql;
            DataTable tabla = new DataTable();
            try
            {
                tabla.Load(Cmd.ExecuteReader());
            }
            catch (Exception e)
            {
                ControlTransaccion = EstadoTransaccion.error;
                MessageBox.Show("Error con la Base de Datos" + "\n"
                                + "En el comando:" + "\n"
                                + sql + "\n"
                                + "El mensaje es:" + "\n"
                                + e.Message);
            }
            Desconectar();
            return tabla;
        }
        private string EjecutarNoSelect(string sql)
        {
            Conectar();
            Cmd.CommandText = sql;
            try
            {
                Cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                ControlTransaccion = EstadoTransaccion.error;
                MessageBox.Show("Error con la Base de Datos" + "\n"
                                + "En el comando:" + "\n"
                                + sql + "\n"
                                + "El mensaje es:" + "\n"
                                + e.Message);
            }

            if (sql.ToUpper().IndexOf("INSERT") >= 0)
            {
                DataTable tabla = new DataTable();
                Cmd.CommandText = "SELECT @@Identity";
                try
                {
                    tabla.Load(Cmd.ExecuteReader());
                }
                catch (Exception e)
                {
                    ControlTransaccion = EstadoTransaccion.error;
                    MessageBox.Show("Error con la Base de Datos" + "\n"
                                    + "En el comando:" + "\n"
                                    + sql + "\n"
                                    + "El mensaje es:" + "\n"
                                    + e.Message);

                }
                Desconectar();
                return tabla.Rows[0][0].ToString();
            }
            else
            {
                Desconectar();
                return "";
            }
        }

        public string FormatearDato(string dato, string formato)
        {
            switch (formato)
            {
                case "String":
                    return "'" + dato + "'";
                case "Date":
                    return "convert(date,'" + dato + "', 127)";
                case "DateTime":
                    return "convert(date,'" + dato + "', 103)";
                // dd/mm/yyyyy
                default:
                    return dato;
            }
        }

        public string Insertar(string sql)
        {
            return EjecutarNoSelect(sql);
        }
        public void Modificar(string sql)
        {
            EjecutarNoSelect(sql);
        }
        public string Fecha()
        {
            string sql = "select convert (char(10), getdate(),103)";
            DataTable tabla = new DataTable();
            tabla = Consulta(sql);
            return tabla.Rows[0][0].ToString();
        }
        public string FechaHora()
        {
            string sql = "SELECT CONVERT(VARCHAR(30),GETDATE(),113)";
            DataTable tabla = new DataTable();
            tabla = Consulta(sql);
            return tabla.Rows[0][0].ToString();
        }

    }
}
    


       
        
  

