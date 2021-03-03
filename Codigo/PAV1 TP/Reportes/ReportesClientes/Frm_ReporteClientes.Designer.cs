namespace PAV1_TP.Formularios.Reportes
{
    partial class Frm_ReporteClientes
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
            this.tbControl1 = new System.Windows.Forms.TabControl();
            this.SinRestricción = new System.Windows.Forms.TabPage();
            this.Rv_Clientes = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.chk_TodosClientes = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_ApellidoCliente = new PAV1_TP.Clases.TextBox01();
            this.txt_DniCliente = new PAV1_TP.Clases.TextBox01();
            this.txt_NombreCliente = new PAV1_TP.Clases.TextBox01();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tbControl1.SuspendLayout();
            this.SinRestricción.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbControl1
            // 
            this.tbControl1.Controls.Add(this.SinRestricción);
            this.tbControl1.Controls.Add(this.tabPage2);
            this.tbControl1.Location = new System.Drawing.Point(2, 6);
            this.tbControl1.Name = "tbControl1";
            this.tbControl1.SelectedIndex = 0;
            this.tbControl1.Size = new System.Drawing.Size(682, 399);
            this.tbControl1.TabIndex = 0;
            // 
            // SinRestricción
            // 
            this.SinRestricción.Controls.Add(this.Rv_Clientes);
            this.SinRestricción.Controls.Add(this.btn_Buscar);
            this.SinRestricción.Controls.Add(this.chk_TodosClientes);
            this.SinRestricción.Controls.Add(this.label3);
            this.SinRestricción.Controls.Add(this.label2);
            this.SinRestricción.Controls.Add(this.label1);
            this.SinRestricción.Controls.Add(this.txt_ApellidoCliente);
            this.SinRestricción.Controls.Add(this.txt_DniCliente);
            this.SinRestricción.Controls.Add(this.txt_NombreCliente);
            this.SinRestricción.Location = new System.Drawing.Point(4, 22);
            this.SinRestricción.Name = "SinRestricción";
            this.SinRestricción.Padding = new System.Windows.Forms.Padding(3);
            this.SinRestricción.Size = new System.Drawing.Size(674, 373);
            this.SinRestricción.TabIndex = 0;
            this.SinRestricción.Text = "Sin Restricción";
            this.SinRestricción.UseVisualStyleBackColor = true;
            // 
            // Rv_Clientes
            // 
            this.Rv_Clientes.LocalReport.ReportEmbeddedResource = "PAV1_TP.Reportes.ReportesClientes.InformeCliente.rdlc";
            this.Rv_Clientes.Location = new System.Drawing.Point(6, 86);
            this.Rv_Clientes.Name = "Rv_Clientes";
            this.Rv_Clientes.ServerReport.BearerToken = null;
            this.Rv_Clientes.Size = new System.Drawing.Size(668, 284);
            this.Rv_Clientes.TabIndex = 13;
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Location = new System.Drawing.Point(360, 57);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(58, 23);
            this.btn_Buscar.TabIndex = 12;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // chk_TodosClientes
            // 
            this.chk_TodosClientes.AutoSize = true;
            this.chk_TodosClientes.Location = new System.Drawing.Point(242, 61);
            this.chk_TodosClientes.Name = "chk_TodosClientes";
            this.chk_TodosClientes.Size = new System.Drawing.Size(112, 17);
            this.chk_TodosClientes.TabIndex = 11;
            this.chk_TodosClientes.Text = "Todos los Clientes";
            this.chk_TodosClientes.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Apellido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Dni";
            // 
            // txt_ApellidoCliente
            // 
            this.txt_ApellidoCliente.Location = new System.Drawing.Point(75, 58);
            this.txt_ApellidoCliente.Name = "txt_ApellidoCliente";
            this.txt_ApellidoCliente.Pp_mensajeError = null;
            this.txt_ApellidoCliente.Pp_nombre_campo = null;
            this.txt_ApellidoCliente.Pp_nombre_tabla = null;
            this.txt_ApellidoCliente.Pp_validable = false;
            this.txt_ApellidoCliente.Size = new System.Drawing.Size(161, 20);
            this.txt_ApellidoCliente.TabIndex = 5;
            // 
            // txt_DniCliente
            // 
            this.txt_DniCliente.Location = new System.Drawing.Point(75, 6);
            this.txt_DniCliente.Name = "txt_DniCliente";
            this.txt_DniCliente.Pp_mensajeError = null;
            this.txt_DniCliente.Pp_nombre_campo = null;
            this.txt_DniCliente.Pp_nombre_tabla = null;
            this.txt_DniCliente.Pp_validable = false;
            this.txt_DniCliente.Size = new System.Drawing.Size(161, 20);
            this.txt_DniCliente.TabIndex = 6;
            // 
            // txt_NombreCliente
            // 
            this.txt_NombreCliente.Location = new System.Drawing.Point(75, 32);
            this.txt_NombreCliente.Name = "txt_NombreCliente";
            this.txt_NombreCliente.Pp_mensajeError = null;
            this.txt_NombreCliente.Pp_nombre_campo = null;
            this.txt_NombreCliente.Pp_nombre_tabla = null;
            this.txt_NombreCliente.Pp_validable = false;
            this.txt_NombreCliente.Size = new System.Drawing.Size(161, 20);
            this.txt_NombreCliente.TabIndex = 7;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(674, 373);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Con Restricción";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Frm_ReporteClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 406);
            this.Controls.Add(this.tbControl1);
            this.Name = "Frm_ReporteClientes";
            this.Text = "Reporte de Clientes";
            this.Load += new System.EventHandler(this.Frm_ReporteClientes_Load);
            this.tbControl1.ResumeLayout(false);
            this.SinRestricción.ResumeLayout(false);
            this.SinRestricción.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbControl1;
        private System.Windows.Forms.TabPage SinRestricción;
        private Microsoft.Reporting.WinForms.ReportViewer Rv_Clientes;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.CheckBox chk_TodosClientes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Clases.TextBox01 txt_ApellidoCliente;
        private Clases.TextBox01 txt_DniCliente;
        private Clases.TextBox01 txt_NombreCliente;
        private System.Windows.Forms.TabPage tabPage2;
    }
}