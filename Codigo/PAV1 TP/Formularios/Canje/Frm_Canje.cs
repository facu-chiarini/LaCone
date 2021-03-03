using PAV1_TP.Clases;
using PAV1_TP.Negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAV1_TP.Formularios.Canje
{
    public partial class Frm_Canje : Form
    {
        TratamientosEspeciales tratamiento = new TratamientosEspeciales();
        Be_BaseDeDatos _BD = new Be_BaseDeDatos();
        Ng_Canje canje = new Ng_Canje();
        string IdPlanta { get; set; }
        string Puntos { get; set; }
        string TipoDoc { get; set; }
        string PuntosTotales { get; set; }
        public Frm_Canje()
        {
            InitializeComponent();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_Canje_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_Consultar_Click(object sender, EventArgs e)
        {
            if (txt_IdCatalogo.Text != "")
            {
                Cargar_Grilla(canje.BuscarCatalogo(txt_IdCatalogo.Text));
            }
            else
            {
                MessageBox.Show("No se ingreso el id de catalogo");
            }
        }
        private void Cargar_Grilla(DataTable tabla)
        {
            Grid_Canje.Rows.Clear();
            DataTable tablaplanta = new DataTable();
            

            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                tablaplanta = canje.RecuperarPlanta(tabla.Rows[i]["Id_Planta"].ToString());
                Grid_Canje.Rows.Add();
                Grid_Canje.Rows[i].Cells[0].Value = tabla.Rows[i]["Id_Planta"].ToString();
                Grid_Canje.Rows[i].Cells[1].Value = tablaplanta.Rows[0]["NombreComun"].ToString();
                Grid_Canje.Rows[i].Cells[2].Value = tabla.Rows[i]["Puntos_Necesarios"].ToString();

            }
        }

        private void btn_Fehca_Click(object sender, EventArgs e)
        {
            txt_Fecha.Text = _BD.FechaHora();
        }

        private void btn_Registrar_Click(object sender, EventArgs e)
        {
            if (tratamiento.validar(this.Controls) == TratamientosEspeciales.Validacion.correcta)
            {
                DataTable tabla = new DataTable();
                tabla = canje.RecuperarTipoDoc(txt_NroDoc.Text);
                if (tabla.Rows.Count > 0)
                {
                    DataTable tabla2 = new DataTable();
                    tabla2 = canje.PuntosTotales(txt_NroDoc.Text);
                    PuntosTotales = tabla2.Rows[0]["Puntos"].ToString();
                    IdPlanta = Grid_Canje.CurrentRow.Cells[0].Value.ToString();
                    Puntos = Grid_Canje.CurrentRow.Cells[2].Value.ToString();
                    TipoDoc = tabla.Rows[0]["TipoDoc"].ToString();
                    if (PuntosTotales == "")
                    {
                        MessageBox.Show("El cliente no tiene puntos");
                    }
                    else
                    {
                        if (int.Parse(PuntosTotales) >= int.Parse(Puntos))
                        {
                            canje.insertarCanje(canje.NuevoId(), TipoDoc, txt_NroDoc.Text, txt_IdCatalogo.Text,
                                                IdPlanta, txt_Fecha.Text, Puntos);
                            canje.insertarPuntos(TipoDoc, txt_NroDoc.Text, 0.ToString(), 0.ToString(), Puntos, txt_Fecha.Text);
                            MessageBox.Show("Canje efectuado correctamente y puntos actualizados");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Puntos insuficientes");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Cliente no registrado");
                }
            }
        }
    }
}
