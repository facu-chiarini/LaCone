using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAV1_TP.Negocios.EstructurasNegocios
{
    class Es_ProductoCompuesto
    {
        public string ID { get; set; }
        public string Cod_Prod_Compuesto { get; set; }
        public string Cod_Prod_Componente { get; set; }
        public string Cant_Compuesto { get; set; }
        public string Cant_Componente { get; set; }
    }
}
