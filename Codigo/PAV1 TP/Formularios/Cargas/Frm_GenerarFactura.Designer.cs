namespace PAV1_TP.Formularios.Cargas
{
    partial class Frm_GenerarFactura
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_GenerarFactura));
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Fehca = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_AgregarPlanta = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_AgregarProd = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.txt_IdEmpleado = new PAV1_TP.Clases.TextBox01();
            this.txt_NroDoc = new PAV1_TP.Clases.TextBox01();
            this.txt_ValorPlanta = new PAV1_TP.Clases.TextBox01();
            this.txt_ValorProd = new PAV1_TP.Clases.TextBox01();
            this.grid_Productos = new PAV1_TP.Clases.Grid01();
            this.grid_Plantas = new PAV1_TP.Clases.Grid01();
            this.txt_CantidadProd = new PAV1_TP.Clases.TextBox01();
            this.txt_CantidadPlant = new PAV1_TP.Clases.TextBox01();
            this.cmb_Productos = new PAV1_TP.Clases.ComboBox01();
            this.cmb_Plantas = new PAV1_TP.Clases.ComboBox01();
            this.txt_Monto = new PAV1_TP.Clases.TextBox01();
            this.ltxt_Fecha = new PAV1_TP.Clases.LabelText01();
            this.cmb_TipoFactura = new PAV1_TP.Clases.ComboBox01();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Productos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Plantas)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(22, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tipo de factura";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Generar Factura";
            // 
            // btn_Fehca
            // 
            this.btn_Fehca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Fehca.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Fehca.Location = new System.Drawing.Point(202, 138);
            this.btn_Fehca.Name = "btn_Fehca";
            this.btn_Fehca.Size = new System.Drawing.Size(36, 23);
            this.btn_Fehca.TabIndex = 4;
            this.btn_Fehca.Text = "...";
            this.btn_Fehca.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Fehca.UseVisualStyleBackColor = true;
            this.btn_Fehca.Click += new System.EventHandler(this.btn_Fehca_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(38, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Monto Total";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(340, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Plantas";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(453, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 20;
            this.label7.Tag = "Cantidad";
            this.label7.Text = "Cantidad";
            // 
            // btn_AgregarPlanta
            // 
            this.btn_AgregarPlanta.Location = new System.Drawing.Point(577, 75);
            this.btn_AgregarPlanta.Name = "btn_AgregarPlanta";
            this.btn_AgregarPlanta.Size = new System.Drawing.Size(75, 23);
            this.btn_AgregarPlanta.TabIndex = 9;
            this.btn_AgregarPlanta.Text = "Agregar";
            this.btn_AgregarPlanta.UseVisualStyleBackColor = true;
            this.btn_AgregarPlanta.Click += new System.EventHandler(this.btn_AgregarPlanta_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(349, 249);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Productos";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(453, 278);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 20;
            this.label9.Tag = "Cantidad";
            this.label9.Text = "Cantidad";
            // 
            // btn_AgregarProd
            // 
            this.btn_AgregarProd.Location = new System.Drawing.Point(583, 273);
            this.btn_AgregarProd.Name = "btn_AgregarProd";
            this.btn_AgregarProd.Size = new System.Drawing.Size(75, 23);
            this.btn_AgregarProd.TabIndex = 13;
            this.btn_AgregarProd.Text = "Agregar";
            this.btn_AgregarProd.UseVisualStyleBackColor = true;
            this.btn_AgregarProd.Click += new System.EventHandler(this.btn_AgregarProd_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(341, 278);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 28;
            this.label10.Tag = "Cantidad";
            this.label10.Text = "Valor";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(341, 82);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 13);
            this.label11.TabIndex = 30;
            this.label11.Tag = "Cantidad";
            this.label11.Text = "Valor";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(69, 221);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Generar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(150, 221);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(54, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Nro Doc";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(35, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Id Empleado";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(202, 172);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(58, 23);
            this.button3.TabIndex = 38;
            this.button3.Text = "Calcular";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txt_IdEmpleado
            // 
            this.txt_IdEmpleado.Location = new System.Drawing.Point(107, 112);
            this.txt_IdEmpleado.Name = "txt_IdEmpleado";
            this.txt_IdEmpleado.Pp_mensajeError = null;
            this.txt_IdEmpleado.Pp_nombre_campo = null;
            this.txt_IdEmpleado.Pp_nombre_tabla = null;
            this.txt_IdEmpleado.Pp_validable = false;
            this.txt_IdEmpleado.Size = new System.Drawing.Size(89, 20);
            this.txt_IdEmpleado.TabIndex = 2;
            // 
            // txt_NroDoc
            // 
            this.txt_NroDoc.Location = new System.Drawing.Point(107, 56);
            this.txt_NroDoc.Name = "txt_NroDoc";
            this.txt_NroDoc.Pp_mensajeError = null;
            this.txt_NroDoc.Pp_nombre_campo = null;
            this.txt_NroDoc.Pp_nombre_tabla = null;
            this.txt_NroDoc.Pp_validable = false;
            this.txt_NroDoc.Size = new System.Drawing.Size(90, 20);
            this.txt_NroDoc.TabIndex = 0;
            // 
            // txt_ValorPlanta
            // 
            this.txt_ValorPlanta.Location = new System.Drawing.Point(378, 77);
            this.txt_ValorPlanta.Name = "txt_ValorPlanta";
            this.txt_ValorPlanta.Pp_mensajeError = null;
            this.txt_ValorPlanta.Pp_nombre_campo = null;
            this.txt_ValorPlanta.Pp_nombre_tabla = null;
            this.txt_ValorPlanta.Pp_validable = true;
            this.txt_ValorPlanta.Size = new System.Drawing.Size(69, 20);
            this.txt_ValorPlanta.TabIndex = 7;
            // 
            // txt_ValorProd
            // 
            this.txt_ValorProd.Location = new System.Drawing.Point(378, 273);
            this.txt_ValorProd.Name = "txt_ValorProd";
            this.txt_ValorProd.Pp_mensajeError = null;
            this.txt_ValorProd.Pp_nombre_campo = null;
            this.txt_ValorProd.Pp_nombre_tabla = null;
            this.txt_ValorProd.Pp_validable = false;
            this.txt_ValorProd.Size = new System.Drawing.Size(69, 20);
            this.txt_ValorProd.TabIndex = 11;
            // 
            // grid_Productos
            // 
            this.grid_Productos.AllowUserToAddRows = false;
            this.grid_Productos.AllowUserToDeleteRows = false;
            this.grid_Productos.AllowUserToResizeColumns = false;
            this.grid_Productos.AllowUserToResizeRows = false;
            this.grid_Productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_Productos.Location = new System.Drawing.Point(343, 304);
            this.grid_Productos.Name = "grid_Productos";
            this.grid_Productos.Size = new System.Drawing.Size(315, 131);
            this.grid_Productos.TabIndex = 27;
            this.grid_Productos.tabla = null;
            // 
            // grid_Plantas
            // 
            this.grid_Plantas.AllowUserToAddRows = false;
            this.grid_Plantas.AllowUserToDeleteRows = false;
            this.grid_Plantas.AllowUserToResizeColumns = false;
            this.grid_Plantas.AllowUserToResizeRows = false;
            this.grid_Plantas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_Plantas.Location = new System.Drawing.Point(337, 109);
            this.grid_Plantas.Name = "grid_Plantas";
            this.grid_Plantas.Size = new System.Drawing.Size(315, 131);
            this.grid_Plantas.TabIndex = 26;
            this.grid_Plantas.tabla = null;
            // 
            // txt_CantidadProd
            // 
            this.txt_CantidadProd.Location = new System.Drawing.Point(508, 275);
            this.txt_CantidadProd.Name = "txt_CantidadProd";
            this.txt_CantidadProd.Pp_mensajeError = null;
            this.txt_CantidadProd.Pp_nombre_campo = null;
            this.txt_CantidadProd.Pp_nombre_tabla = null;
            this.txt_CantidadProd.Pp_validable = false;
            this.txt_CantidadProd.Size = new System.Drawing.Size(69, 20);
            this.txt_CantidadProd.TabIndex = 12;
            // 
            // txt_CantidadPlant
            // 
            this.txt_CantidadPlant.Location = new System.Drawing.Point(502, 77);
            this.txt_CantidadPlant.Multiline = true;
            this.txt_CantidadPlant.Name = "txt_CantidadPlant";
            this.txt_CantidadPlant.Pp_mensajeError = "Falta cargar cantidad de plantas";
            this.txt_CantidadPlant.Pp_nombre_campo = null;
            this.txt_CantidadPlant.Pp_nombre_tabla = null;
            this.txt_CantidadPlant.Pp_validable = false;
            this.txt_CantidadPlant.Size = new System.Drawing.Size(69, 20);
            this.txt_CantidadPlant.TabIndex = 8;
            // 
            // cmb_Productos
            // 
            this.cmb_Productos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Productos.FormattingEnabled = true;
            this.cmb_Productos.Location = new System.Drawing.Point(410, 246);
            this.cmb_Productos.Name = "cmb_Productos";
            this.cmb_Productos.Pp_Display = "Nombre";
            this.cmb_Productos.Pp_mensajeError = null;
            this.cmb_Productos.Pp_nombre_campo = null;
            this.cmb_Productos.Pp_nombre_tabla = null;
            this.cmb_Productos.Pp_seleccionado = false;
            this.cmb_Productos.Pp_Tabla = "Producto";
            this.cmb_Productos.Pp_validable = false;
            this.cmb_Productos.Pp_Value = "Codigo";
            this.cmb_Productos.Size = new System.Drawing.Size(188, 21);
            this.cmb_Productos.TabIndex = 10;
            this.cmb_Productos.SelectionChangeCommitted += new System.EventHandler(this.cmb_Productos_SelectionChangeCommitted);
            // 
            // cmb_Plantas
            // 
            this.cmb_Plantas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Plantas.FormattingEnabled = true;
            this.cmb_Plantas.Location = new System.Drawing.Point(388, 45);
            this.cmb_Plantas.Name = "cmb_Plantas";
            this.cmb_Plantas.Pp_Display = "NombreComun";
            this.cmb_Plantas.Pp_mensajeError = null;
            this.cmb_Plantas.Pp_nombre_campo = null;
            this.cmb_Plantas.Pp_nombre_tabla = null;
            this.cmb_Plantas.Pp_seleccionado = false;
            this.cmb_Plantas.Pp_Tabla = "Plantas";
            this.cmb_Plantas.Pp_validable = false;
            this.cmb_Plantas.Pp_Value = "Codigo";
            this.cmb_Plantas.Size = new System.Drawing.Size(188, 21);
            this.cmb_Plantas.TabIndex = 6;
            this.cmb_Plantas.SelectionChangeCommitted += new System.EventHandler(this.cmb_Plantas_SelectionChangeCommitted);
            // 
            // txt_Monto
            // 
            this.txt_Monto.Enabled = false;
            this.txt_Monto.Location = new System.Drawing.Point(107, 174);
            this.txt_Monto.Name = "txt_Monto";
            this.txt_Monto.Pp_mensajeError = "No se cargo el monto total";
            this.txt_Monto.Pp_nombre_campo = null;
            this.txt_Monto.Pp_nombre_tabla = null;
            this.txt_Monto.Pp_validable = false;
            this.txt_Monto.Size = new System.Drawing.Size(90, 20);
            this.txt_Monto.TabIndex = 5;
            // 
            // ltxt_Fecha
            // 
            this.ltxt_Fecha.BackColor = System.Drawing.Color.Transparent;
            this.ltxt_Fecha.Location = new System.Drawing.Point(57, 138);
            this.ltxt_Fecha.Name = "ltxt_Fecha";
            this.ltxt_Fecha.Pp_Etiqueta = "Fecha";
            this.ltxt_Fecha.Pp_Mascara = "00/00/0000";
            this.ltxt_Fecha.Pp_mensajeError = null;
            this.ltxt_Fecha.Pp_nombre_campo = null;
            this.ltxt_Fecha.Pp_nombre_tabla = null;
            this.ltxt_Fecha.Pp_Text = "  /  /";
            this.ltxt_Fecha.Pp_validable = false;
            this.ltxt_Fecha.Size = new System.Drawing.Size(177, 30);
            this.ltxt_Fecha.TabIndex = 3;
            // 
            // cmb_TipoFactura
            // 
            this.cmb_TipoFactura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_TipoFactura.FormattingEnabled = true;
            this.cmb_TipoFactura.Location = new System.Drawing.Point(107, 82);
            this.cmb_TipoFactura.Name = "cmb_TipoFactura";
            this.cmb_TipoFactura.Pp_Display = "Nombre";
            this.cmb_TipoFactura.Pp_mensajeError = null;
            this.cmb_TipoFactura.Pp_nombre_campo = null;
            this.cmb_TipoFactura.Pp_nombre_tabla = "TipoFactura";
            this.cmb_TipoFactura.Pp_seleccionado = false;
            this.cmb_TipoFactura.Pp_Tabla = "TipoFactura";
            this.cmb_TipoFactura.Pp_validable = false;
            this.cmb_TipoFactura.Pp_Value = "ID";
            this.cmb_TipoFactura.Size = new System.Drawing.Size(90, 21);
            this.cmb_TipoFactura.TabIndex = 1;
            // 
            // Frm_GenerarFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(664, 443);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_IdEmpleado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_NroDoc);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_ValorPlanta);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt_ValorProd);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.grid_Productos);
            this.Controls.Add(this.grid_Plantas);
            this.Controls.Add(this.btn_AgregarProd);
            this.Controls.Add(this.btn_AgregarPlanta);
            this.Controls.Add(this.txt_CantidadProd);
            this.Controls.Add(this.txt_CantidadPlant);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmb_Productos);
            this.Controls.Add(this.cmb_Plantas);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_Monto);
            this.Controls.Add(this.btn_Fehca);
            this.Controls.Add(this.ltxt_Fecha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_TipoFactura);
            this.MaximizeBox = false;
            this.Name = "Frm_GenerarFactura";
            this.Text = "Frm_GenerarFactura";
            this.Load += new System.EventHandler(this.Frm_GenerarFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_Productos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Plantas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Clases.ComboBox01 cmb_TipoFactura;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private Clases.LabelText01 ltxt_Fecha;
        private System.Windows.Forms.Button btn_Fehca;
        private System.Windows.Forms.Label label5;
        private Clases.TextBox01 txt_Monto;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label6;
        private Clases.ComboBox01 cmb_Plantas;
        private System.Windows.Forms.Label label7;
        private Clases.TextBox01 txt_CantidadPlant;
        private System.Windows.Forms.Button btn_AgregarPlanta;
        private System.Windows.Forms.Label label8;
        private Clases.ComboBox01 cmb_Productos;
        private System.Windows.Forms.Label label9;
        private Clases.TextBox01 txt_CantidadProd;
        private System.Windows.Forms.Button btn_AgregarProd;
        private Clases.Grid01 grid_Plantas;
        private Clases.Grid01 grid_Productos;
        private Clases.TextBox01 txt_ValorProd;
        private System.Windows.Forms.Label label10;
        private Clases.TextBox01 txt_ValorPlanta;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private Clases.TextBox01 txt_NroDoc;
        private System.Windows.Forms.Label label1;
        private Clases.TextBox01 txt_IdEmpleado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
    }
}