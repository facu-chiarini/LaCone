namespace PAV1_TP.Formularios.Cargas
{
    partial class Consulta_Factura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Consulta_Factura));
            this.grid_Factura = new System.Windows.Forms.DataGridView();
            this.Tipo_Factura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nro_Factura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NroDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_Empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_ConsultFactura = new System.Windows.Forms.Button();
            this.btn_GenerarFactura = new System.Windows.Forms.Button();
            this.btn_DetalleFactura = new System.Windows.Forms.Button();
            this.btn_SalirFactura = new System.Windows.Forms.Button();
            this.txt_NroDoc = new PAV1_TP.Clases.TextBox01();
            this.chk_Todos = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Factura)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_Factura
            // 
            this.grid_Factura.AllowUserToAddRows = false;
            this.grid_Factura.AllowUserToDeleteRows = false;
            this.grid_Factura.AllowUserToOrderColumns = true;
            this.grid_Factura.AllowUserToResizeColumns = false;
            this.grid_Factura.AllowUserToResizeRows = false;
            this.grid_Factura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_Factura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tipo_Factura,
            this.Nro_Factura,
            this.TipoDoc,
            this.NroDoc,
            this.Fecha,
            this.Id_Empleado,
            this.Monto});
            this.grid_Factura.Location = new System.Drawing.Point(3, 65);
            this.grid_Factura.Name = "grid_Factura";
            this.grid_Factura.Size = new System.Drawing.Size(542, 251);
            this.grid_Factura.TabIndex = 0;
            // 
            // Tipo_Factura
            // 
            this.Tipo_Factura.HeaderText = "Tipo_Factura";
            this.Tipo_Factura.Name = "Tipo_Factura";
            this.Tipo_Factura.Width = 80;
            // 
            // Nro_Factura
            // 
            this.Nro_Factura.HeaderText = "Nro_Factura";
            this.Nro_Factura.Name = "Nro_Factura";
            this.Nro_Factura.Width = 130;
            // 
            // TipoDoc
            // 
            this.TipoDoc.HeaderText = "TipoDoc";
            this.TipoDoc.Name = "TipoDoc";
            this.TipoDoc.Width = 60;
            // 
            // NroDoc
            // 
            this.NroDoc.HeaderText = "NroDoc";
            this.NroDoc.Name = "NroDoc";
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            // 
            // Id_Empleado
            // 
            this.Id_Empleado.HeaderText = "Id_Empleado";
            this.Id_Empleado.Name = "Id_Empleado";
            this.Id_Empleado.Width = 80;
            // 
            // Monto
            // 
            this.Monto.HeaderText = "Monto";
            this.Monto.Name = "Monto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(48, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nro Doc";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_ConsultFactura
            // 
            this.btn_ConsultFactura.Location = new System.Drawing.Point(208, 37);
            this.btn_ConsultFactura.Name = "btn_ConsultFactura";
            this.btn_ConsultFactura.Size = new System.Drawing.Size(75, 23);
            this.btn_ConsultFactura.TabIndex = 3;
            this.btn_ConsultFactura.Text = "Consultar";
            this.btn_ConsultFactura.UseVisualStyleBackColor = true;
            this.btn_ConsultFactura.Click += new System.EventHandler(this.btn_ConsultFactura_Click);
            // 
            // btn_GenerarFactura
            // 
            this.btn_GenerarFactura.Location = new System.Drawing.Point(12, 332);
            this.btn_GenerarFactura.Name = "btn_GenerarFactura";
            this.btn_GenerarFactura.Size = new System.Drawing.Size(98, 23);
            this.btn_GenerarFactura.TabIndex = 4;
            this.btn_GenerarFactura.Text = "Generar Factura";
            this.btn_GenerarFactura.UseVisualStyleBackColor = true;
            this.btn_GenerarFactura.Click += new System.EventHandler(this.btn_GenerarFactura_Click);
            // 
            // btn_DetalleFactura
            // 
            this.btn_DetalleFactura.Location = new System.Drawing.Point(116, 332);
            this.btn_DetalleFactura.Name = "btn_DetalleFactura";
            this.btn_DetalleFactura.Size = new System.Drawing.Size(91, 23);
            this.btn_DetalleFactura.TabIndex = 5;
            this.btn_DetalleFactura.Text = "Detalle Factura";
            this.btn_DetalleFactura.UseVisualStyleBackColor = true;
            this.btn_DetalleFactura.Click += new System.EventHandler(this.btn_DetalleFactura_Click);
            // 
            // btn_SalirFactura
            // 
            this.btn_SalirFactura.Location = new System.Drawing.Point(466, 332);
            this.btn_SalirFactura.Name = "btn_SalirFactura";
            this.btn_SalirFactura.Size = new System.Drawing.Size(75, 23);
            this.btn_SalirFactura.TabIndex = 6;
            this.btn_SalirFactura.Text = "Salir";
            this.btn_SalirFactura.UseVisualStyleBackColor = true;
            this.btn_SalirFactura.Click += new System.EventHandler(this.btn_SalirFactura_Click);
            // 
            // txt_NroDoc
            // 
            this.txt_NroDoc.Location = new System.Drawing.Point(101, 15);
            this.txt_NroDoc.Name = "txt_NroDoc";
            this.txt_NroDoc.Pp_mensajeError = null;
            this.txt_NroDoc.Pp_nombre_campo = null;
            this.txt_NroDoc.Pp_nombre_tabla = null;
            this.txt_NroDoc.Pp_validable = false;
            this.txt_NroDoc.Size = new System.Drawing.Size(100, 20);
            this.txt_NroDoc.TabIndex = 1;
            // 
            // chk_Todos
            // 
            this.chk_Todos.AutoSize = true;
            this.chk_Todos.BackColor = System.Drawing.Color.Transparent;
            this.chk_Todos.Location = new System.Drawing.Point(102, 41);
            this.chk_Todos.Name = "chk_Todos";
            this.chk_Todos.Size = new System.Drawing.Size(56, 17);
            this.chk_Todos.TabIndex = 2;
            this.chk_Todos.Text = "Todas";
            this.chk_Todos.UseVisualStyleBackColor = false;
            // 
            // Consulta_Factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(557, 360);
            this.Controls.Add(this.chk_Todos);
            this.Controls.Add(this.btn_SalirFactura);
            this.Controls.Add(this.btn_DetalleFactura);
            this.Controls.Add(this.btn_GenerarFactura);
            this.Controls.Add(this.btn_ConsultFactura);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_NroDoc);
            this.Controls.Add(this.grid_Factura);
            this.MaximizeBox = false;
            this.Name = "Consulta_Factura";
            this.Text = "Consulta_Factura";
            ((System.ComponentModel.ISupportInitialize)(this.grid_Factura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grid_Factura;
        private Clases.TextBox01 txt_NroDoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_ConsultFactura;
        private System.Windows.Forms.Button btn_GenerarFactura;
        private System.Windows.Forms.Button btn_DetalleFactura;
        private System.Windows.Forms.Button btn_SalirFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo_Factura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nro_Factura;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
        private System.Windows.Forms.CheckBox chk_Todos;
    }
}