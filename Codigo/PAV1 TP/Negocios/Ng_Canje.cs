using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using PAV1_TP.Clases;

namespace PAV1_TP.Negocios
{
    class Ng_Canje
    {
        Be_BaseDeDatos _BD = new Be_BaseDeDatos();
        public DataTable BuscarCatalogo(string ID)
        {
            string sql = "SELECT * FROM Catalogo WHERE ID = " + ID;
            DataTable tabla = new DataTable();
            tabla = _BD.Consulta(sql);
            return tabla;
        }

        public DataTable RecuperarPlanta(string id)
        {
            string sql = "SELECT * FROM Plantas WHERE Codigo = " + id;
            DataTable tabla = new DataTable();
            tabla = _BD.Consulta(sql);
            return tabla;

        }
        public string NuevoId()
        {
            DataTable tabla = new DataTable();
            string sql = "SELECT * FROM Canje";
            tabla = _BD.Consulta(sql);
            int id = tabla.Rows.Count;
            int NuevaId = id + 1;
            return NuevaId.ToString();
        }
        public DataTable RecuperarTipoDoc(string DNI)
        {
            string sql = "SELECT * FROM Cliente WHERE NroDoc = " + DNI;
            DataTable tabla = new DataTable();
            tabla = _BD.Consulta(sql);
            return tabla;
        }
        public DataTable PuntosTotales(string DNI)
        {
            DataTable tabla = new DataTable();
            return tabla = _BD.Consulta("SELECT sum(Cantidad) as Puntos FROM Puntos WHERE NroDoc = '" + DNI + "'");
        }
        public void insertarCanje(string ID, string TipoDoc, string NroDoc, string Id_Catalogo,
                             string Id_Planta, string Fecha, string Puntos_Necesarios)
        {
            string insert_Canje = "INSERT INTO Canje (ID, TipoDoc, NroDoc, Id_Catalogo, Id_Planta, Fecha, Puntos_a_Restar) VALUES (";
            insert_Canje += ID + ", " + TipoDoc + ", " + NroDoc + ", " + Id_Catalogo + ", "
                             + Id_Planta + ",  CONVERT(VARCHAR(30), GETDATE(), 113) , " + Puntos_Necesarios + ")";
            _BD.Insertar(insert_Canje);
        }
        public void insertarPuntos(string TipoDoc, string NroDoc, string Tipo_Factura, string Nro_Factura,
                                       string puntos, string Fecha)
        {
            string insert_Puntos = "INSERT INTO Puntos (TipoDoc, NroDoc, Tipo_Factura, Nro_Factura, Cantidad, Fecha) VALUES (";
            insert_Puntos += TipoDoc + ", " + NroDoc + ", " + Tipo_Factura + ", "
                             + Nro_Factura + ", " + "-" + puntos + ",  CONVERT(VARCHAR(30), GETDATE(), 113))";
            _BD.Insertar(insert_Puntos);
        }
    }
}
