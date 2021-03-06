﻿using PAV1_TP.Negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PAV1_TP.Clases;
using PAV1_TP.Negocios.EstructurasNegocios;

namespace PAV1_TP.Formularios.Producto.TipoProducto
{
    public partial class Modificacion_TipoProducto : Form
    {
        Ng_TipoProducto tipoProducto = new Ng_TipoProducto();
        public string ID { get; set; }
        public Modificacion_TipoProducto()
        {
            InitializeComponent();
        }

        private void Modificacion_TipoProducto_Load(object sender, EventArgs e)
        {
            cmb_EstadoTipoPlanta.Cargar();
            DataTable tabla = new DataTable();
            tabla = tipoProducto.Recuperar_Tipo_Producto(ID);
            txt_IdTipoPlanta.Text = ID;
            txt_NombreTipoPlanta.Text = tabla.Rows[0]["Nombre"].ToString();
            txt_DescripTipoPlanta.Text = tabla.Rows[0]["Descripcion"].ToString();
            cmb_EstadoTipoPlanta.SelectedValue = int.Parse(tabla.Rows[0]["Estado"].ToString());
        }

        private void btn_ModifTipoPlanta_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales tratamiento = new TratamientosEspeciales();
            Es_TipoProducto _etp = new Es_TipoProducto();

            if (tratamiento.validar(this.Controls) == TratamientosEspeciales.Validacion.correcta)
            {
                _etp.ID = txt_IdTipoPlanta.Text;
                _etp.Nombre = txt_NombreTipoPlanta.Text;
                _etp.Descripcion = txt_DescripTipoPlanta.Text;
                _etp.Estado = cmb_EstadoTipoPlanta.SelectedValue.ToString();

                tipoProducto.Modificar(_etp);
                MessageBox.Show("Tipo planta modificado correctamente");
                this.Close();
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
