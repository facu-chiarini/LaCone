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
    class Ng_Puntos
    {
        Be_BaseDeDatos _BD = new Be_BaseDeDatos();
        public DataTable RecuperarCliente(string DNI)
        {
            DataTable tabla = new DataTable();
            return tabla = _BD.Consulta("SELECT * FROM Cliente WHERE NroDoc = " + DNI);
        }

        public DataTable RecuperarDNI(string NroFactura)
        {
            DataTable tabla = new DataTable();
            return tabla = _BD.Consulta("SELECT * FROM Factura WHERE Nro_Factura = '" + NroFactura + "'");
        }
        public DataTable RecuperarTipoFactura(string NroFactura)
        {
            DataTable tabla = new DataTable();
            return tabla = _BD.Consulta("SELECT * FROM Factura WHERE Nro_Factura = '" + NroFactura + "'");
        }
        public DataTable RecuperarIdFactura()
        {
            DataTable tabla = new DataTable();
            return tabla = _BD.Consulta("SELECT MAX(Nro_Factura) as ID FROM Factura");
        }
        public DataTable PuntosASumar(string NroFactura)
        {
            DataTable tabla = new DataTable();
            return tabla = _BD.Consulta("SELECT sum(Monto/20) as Puntos FROM Factura WHERE Nro_Factura = '" + NroFactura + "'");
        }
        public void insertar(string TipoDoc, string NroDoc, string Tipo_Factura, string Nro_Factura, string Cantidad,
                           string fecha)
        {

            string sqlInsert = "INSERT INTO Puntos (TipoDoc, NroDoc, Tipo_Factura, Nro_Factura, Cantidad, fecha) VALUES (";
            sqlInsert += TipoDoc + ", " + NroDoc + ", " + Tipo_Factura + ", " + Nro_Factura + ", " + Cantidad + ", "
                            + _BD.FormatearDato(fecha, "DateTime") + ")";

            _BD.Insertar(sqlInsert);

        }
        public DataTable PuntosTotales(string DNI)
        {
            DataTable tabla = new DataTable();
            return tabla = _BD.Consulta("SELECT sum(Cantidad) as Puntos FROM Puntos WHERE NroDoc = '" + DNI + "'");
        }
        public DataTable RecuperarFactura(string DNI)
        {
            DataTable tabla = new DataTable();
            return tabla = _BD.Consulta("SELECT * FROM Puntos WHERE NroDoc = '" + DNI + "'");
        }

    }
}
