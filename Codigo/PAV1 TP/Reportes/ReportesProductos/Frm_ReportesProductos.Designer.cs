namespace PAV1_TP.Reportes.ReportesProdcutos
{
    partial class Frm_ReportesProductos
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.Rv_Productos = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(782, 437);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Rv_Productos);
            this.tabPage1.Controls.Add(this.btn_Buscar);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(774, 411);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Sin restriccion";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(774, 411);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tipo producto mas vendido";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(774, 411);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Producto mas vendido";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Location = new System.Drawing.Point(7, 7);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_Buscar.TabIndex = 0;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // Rv_Productos
            // 
            this.Rv_Productos.Location = new System.Drawing.Point(7, 47);
            this.Rv_Productos.Name = "Rv_Productos";
            this.Rv_Productos.ServerReport.BearerToken = null;
            this.Rv_Productos.Size = new System.Drawing.Size(751, 356);
            this.Rv_Productos.TabIndex = 1;
            // 
            // Frm_ReportesProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Frm_ReportesProductos";
            this.Text = "Frm_ReportesProductos";
            this.Load += new System.EventHandler(this.Frm_ReportesProductos_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private Microsoft.Reporting.WinForms.ReportViewer Rv_Productos;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.TabPage tabPage3;
    }
}