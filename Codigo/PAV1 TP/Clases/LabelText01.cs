using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection.Emit;

namespace PAV1_TP.Clases
{
    public partial class LabelText01 : UserControl
    {
        public string Pp_Etiqueta
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }
        
        public string Pp_Mascara
        {
            get { return txt_Dato.Mask; }
            set { txt_Dato.Mask = value; }
        }
        public bool Pp_validable { get; set; }
        public string Pp_nombre_campo { get; set; }
        public string Pp_nombre_tabla { get; set; }
        public string Pp_mensajeError { get; set; }

        public string Pp_Text
        {
            get { return txt_Dato.Text; }
            set { txt_Dato.Text = value; }
        }
        public LabelText01()
        {
            InitializeComponent();
        }
    }
}
