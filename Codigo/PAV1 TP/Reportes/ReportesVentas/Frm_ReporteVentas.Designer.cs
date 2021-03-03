namespace PAV1_TP.Reportes.ReportesVentas
{
    partial class Frm_ReporteVentas
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.chk_TodasLasVentas = new System.Windows.Forms.CheckBox();
            this.txt_NroDoc = new PAV1_TP.Clases.TextBox01();
            this.Rv_Ventas = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Rv_VentasXMonto = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Buscar = new System.Windows.Forms.Button();
            this.txt_Monto = new PAV1_TP.Clases.TextBox01();
            this.label02 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.check_MenorV = new System.Windows.Forms.CheckBox();
            this.check_MayorV = new System.Windows.Forms.CheckBox();
            this.Rv_VentasXMes = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txt_Mes = new PAV1_TP.Clases.TextBox01();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.Rv_PPM = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btn_PPM = new System.Windows.Forms.Button();
            this.txt_MesPPM = new PAV1_TP.Clases.TextBox01();
            this.label3 = new System.Windows.Forms.Label();
            this.Rv_TPPM = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btn_TPPM = new System.Windows.Forms.Button();
            this.txt_MesTPPM = new PAV1_TP.Clases.TextBox01();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(12, 14);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.chk_TodasLasVentas);
            this.tabPage1.Controls.Add(this.txt_NroDoc);
            this.tabPage1.Controls.Add(this.Rv_Ventas);
            this.tabPage1.Controls.Add(this.btn_Buscar);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 400);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Sin reestriccion";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nro Doc ";
            // 
            // chk_TodasLasVentas
            // 
            this.chk_TodasLasVentas.AutoSize = true;
            this.chk_TodasLasVentas.Location = new System.Drawing.Point(62, 42);
            this.chk_TodasLasVentas.Name = "chk_TodasLasVentas";
            this.chk_TodasLasVentas.Size = new System.Drawing.Size(107, 17);
            this.chk_TodasLasVentas.TabIndex = 4;
            this.chk_TodasLasVentas.Text = "Todas las ventas";
            this.chk_TodasLasVentas.UseVisualStyleBackColor = true;
            // 
            // txt_NroDoc
            // 
            this.txt_NroDoc.Location = new System.Drawing.Point(62, 16);
            this.txt_NroDoc.Name = "txt_NroDoc";
            this.txt_NroDoc.Pp_mensajeError = null;
            this.txt_NroDoc.Pp_nombre_campo = null;
            this.txt_NroDoc.Pp_nombre_tabla = null;
            this.txt_NroDoc.Pp_validable = false;
            this.txt_NroDoc.Size = new System.Drawing.Size(130, 20);
            this.txt_NroDoc.TabIndex = 2;
            // 
            // Rv_Ventas
            // 
            this.Rv_Ventas.LocalReport.ReportEmbeddedResource = "PAV1_TP.Reportes.ReportesVentas.InformeVentas.rdlc";
            this.Rv_Ventas.Location = new System.Drawing.Point(6, 65);
            this.Rv_Ventas.Name = "Rv_Ventas";
            this.Rv_Ventas.ServerReport.BearerToken = null;
            this.Rv_Ventas.Size = new System.Drawing.Size(756, 316);
            this.Rv_Ventas.TabIndex = 1;
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Location = new System.Drawing.Point(198, 36);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_Buscar.TabIndex = 0;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Rv_VentasXMonto);
            this.tabPage2.Controls.Add(this.Buscar);
            this.tabPage2.Controls.Add(this.txt_Monto);
            this.tabPage2.Controls.Add(this.label02);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 400);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ventas por monto";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Rv_VentasXMonto
            // 
            this.Rv_VentasXMonto.Location = new System.Drawing.Point(7, 41);
            this.Rv_VentasXMonto.Name = "Rv_VentasXMonto";
            this.Rv_VentasXMonto.ServerReport.BearerToken = null;
            this.Rv_VentasXMonto.Size = new System.Drawing.Size(755, 353);
            this.Rv_VentasXMonto.TabIndex = 3;
            // 
            // Buscar
            // 
            this.Buscar.Location = new System.Drawing.Point(156, 11);
            this.Buscar.Name = "Buscar";
            this.Buscar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Buscar.Size = new System.Drawing.Size(75, 23);
            this.Buscar.TabIndex = 2;
            this.Buscar.Text = "Buscar";
            this.Buscar.UseVisualStyleBackColor = true;
            this.Buscar.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // txt_Monto
            // 
            this.txt_Monto.Location = new System.Drawing.Point(50, 11);
            this.txt_Monto.Name = "txt_Monto";
            this.txt_Monto.Pp_mensajeError = null;
            this.txt_Monto.Pp_nombre_campo = null;
            this.txt_Monto.Pp_nombre_tabla = null;
            this.txt_Monto.Pp_validable = false;
            this.txt_Monto.Size = new System.Drawing.Size(100, 20);
            this.txt_Monto.TabIndex = 1;
            // 
            // label02
            // 
            this.label02.AutoSize = true;
            this.label02.Location = new System.Drawing.Point(7, 16);
            this.label02.Name = "label02";
            this.label02.Size = new System.Drawing.Size(37, 13);
            this.label02.TabIndex = 0;
            this.label02.Text = "Monto";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.check_MenorV);
            this.tabPage3.Controls.Add(this.check_MayorV);
            this.tabPage3.Controls.Add(this.Rv_VentasXMes);
            this.tabPage3.Controls.Add(this.btnBuscar);
            this.tabPage3.Controls.Add(this.txt_Mes);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(768, 400);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Dias de mayor y menor ventas";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // check_MenorV
            // 
            this.check_MenorV.AutoSize = true;
            this.check_MenorV.Location = new System.Drawing.Point(161, 37);
            this.check_MenorV.Name = "check_MenorV";
            this.check_MenorV.Size = new System.Drawing.Size(121, 17);
            this.check_MenorV.TabIndex = 10;
            this.check_MenorV.Text = "Día de menor venta";
            this.check_MenorV.UseVisualStyleBackColor = true;
            // 
            // check_MayorV
            // 
            this.check_MayorV.AutoSize = true;
            this.check_MayorV.Location = new System.Drawing.Point(40, 37);
            this.check_MayorV.Name = "check_MayorV";
            this.check_MayorV.Size = new System.Drawing.Size(120, 17);
            this.check_MayorV.TabIndex = 9;
            this.check_MayorV.Text = "Día de mayor venta";
            this.check_MayorV.UseVisualStyleBackColor = true;
            // 
            // Rv_VentasXMes
            // 
            this.Rv_VentasXMes.LocalReport.ReportEmbeddedResource = "PAV1_TP.Reportes.ReportesVentas.InformeVentas.rdlc";
            this.Rv_VentasXMes.Location = new System.Drawing.Point(6, 60);
            this.Rv_VentasXMes.Name = "Rv_VentasXMes";
            this.Rv_VentasXMes.ServerReport.BearerToken = null;
            this.Rv_VentasXMes.Size = new System.Drawing.Size(756, 333);
            this.Rv_VentasXMes.TabIndex = 8;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(288, 10);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 7;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txt_Mes
            // 
            this.txt_Mes.Location = new System.Drawing.Point(40, 11);
            this.txt_Mes.Name = "txt_Mes";
            this.txt_Mes.Pp_mensajeError = null;
            this.txt_Mes.Pp_nombre_campo = null;
            this.txt_Mes.Pp_nombre_tabla = null;
            this.txt_Mes.Pp_validable = false;
            this.txt_Mes.Size = new System.Drawing.Size(242, 20);
            this.txt_Mes.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mes";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.Rv_PPM);
            this.tabPage4.Controls.Add(this.btn_PPM);
            this.tabPage4.Controls.Add(this.txt_MesPPM);
            this.tabPage4.Controls.Add(this.label3);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(768, 400);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Plantas por mes";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.Rv_TPPM);
            this.tabPage5.Controls.Add(this.btn_TPPM);
            this.tabPage5.Controls.Add(this.txt_MesTPPM);
            this.tabPage5.Controls.Add(this.label4);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(768, 400);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Tipo de planta por mes";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // Rv_PPM
            // 
            this.Rv_PPM.Location = new System.Drawing.Point(7, 39);
            this.Rv_PPM.Name = "Rv_PPM";
            this.Rv_PPM.ServerReport.BearerToken = null;
            this.Rv_PPM.Size = new System.Drawing.Size(755, 353);
            this.Rv_PPM.TabIndex = 7;
            // 
            // btn_PPM
            // 
            this.btn_PPM.Location = new System.Drawing.Point(156, 9);
            this.btn_PPM.Name = "btn_PPM";
            this.btn_PPM.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_PPM.Size = new System.Drawing.Size(75, 23);
            this.btn_PPM.TabIndex = 6;
            this.btn_PPM.Text = "Buscar";
            this.btn_PPM.UseVisualStyleBackColor = true;
            this.btn_PPM.Click += new System.EventHandler(this.btn_PPM_Click);
            // 
            // txt_MesPPM
            // 
            this.txt_MesPPM.Location = new System.Drawing.Point(50, 9);
            this.txt_MesPPM.Name = "txt_MesPPM";
            this.txt_MesPPM.Pp_mensajeError = null;
            this.txt_MesPPM.Pp_nombre_campo = null;
            this.txt_MesPPM.Pp_nombre_tabla = null;
            this.txt_MesPPM.Pp_validable = false;
            this.txt_MesPPM.Size = new System.Drawing.Size(100, 20);
            this.txt_MesPPM.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mes";
            // 
            // Rv_TPPM
            // 
            this.Rv_TPPM.Location = new System.Drawing.Point(7, 39);
            this.Rv_TPPM.Name = "Rv_TPPM";
            this.Rv_TPPM.ServerReport.BearerToken = null;
            this.Rv_TPPM.Size = new System.Drawing.Size(755, 353);
            this.Rv_TPPM.TabIndex = 11;
            // 
            // btn_TPPM
            // 
            this.btn_TPPM.Location = new System.Drawing.Point(156, 9);
            this.btn_TPPM.Name = "btn_TPPM";
            this.btn_TPPM.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_TPPM.Size = new System.Drawing.Size(75, 23);
            this.btn_TPPM.TabIndex = 10;
            this.btn_TPPM.Text = "Buscar";
            this.btn_TPPM.UseVisualStyleBackColor = true;
            this.btn_TPPM.Click += new System.EventHandler(this.btn_TPPM_Click);
            // 
            // txt_MesTPPM
            // 
            this.txt_MesTPPM.Location = new System.Drawing.Point(50, 9);
            this.txt_MesTPPM.Name = "txt_MesTPPM";
            this.txt_MesTPPM.Pp_mensajeError = null;
            this.txt_MesTPPM.Pp_nombre_campo = null;
            this.txt_MesTPPM.Pp_nombre_tabla = null;
            this.txt_MesTPPM.Pp_validable = false;
            this.txt_MesTPPM.Size = new System.Drawing.Size(100, 20);
            this.txt_MesTPPM.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Mes";
            // 
            // Frm_ReporteVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Frm_ReporteVentas";
            this.Text = "Frm_ReporteVentas";
            this.Load += new System.EventHandler(this.Frm_ReporteVentas_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private Microsoft.Reporting.WinForms.ReportViewer Rv_Ventas;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chk_TodasLasVentas;
        private Clases.TextBox01 txt_NroDoc;
        private Microsoft.Reporting.WinForms.ReportViewer Rv_VentasXMonto;
        private System.Windows.Forms.Button Buscar;
        private Clases.TextBox01 txt_Monto;
        private System.Windows.Forms.Label label02;
		private System.Windows.Forms.Button btnBuscar;
		private Clases.TextBox01 txt_Mes;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.CheckBox check_MenorV;
		private System.Windows.Forms.CheckBox check_MayorV;
		private Microsoft.Reporting.WinForms.ReportViewer Rv_VentasXMes;
        private System.Windows.Forms.TabPage tabPage4;
        private Microsoft.Reporting.WinForms.ReportViewer Rv_PPM;
        private System.Windows.Forms.Button btn_PPM;
        private Clases.TextBox01 txt_MesPPM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage5;
        private Microsoft.Reporting.WinForms.ReportViewer Rv_TPPM;
        private System.Windows.Forms.Button btn_TPPM;
        private Clases.TextBox01 txt_MesTPPM;
        private System.Windows.Forms.Label label4;
    }
}