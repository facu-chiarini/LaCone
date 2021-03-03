namespace PAV1_TP.Reportes.ReportesPlantas
{
    partial class Frm_ReportesPlantas
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
            this.Rv_Plantas = new Microsoft.Reporting.WinForms.ReportViewer();
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
            this.tabControl1.Size = new System.Drawing.Size(775, 436);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Rv_Plantas);
            this.tabPage1.Controls.Add(this.btn_Buscar);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(767, 410);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Sin restriccion";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(767, 410);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Plantas vendidas por mes";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(767, 410);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Tipo de planta vendida por mes";
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
            // Rv_Plantas
            // 
            this.Rv_Plantas.Location = new System.Drawing.Point(4, 37);
            this.Rv_Plantas.Name = "Rv_Plantas";
            this.Rv_Plantas.ServerReport.BearerToken = null;
            this.Rv_Plantas.Size = new System.Drawing.Size(757, 366);
            this.Rv_Plantas.TabIndex = 1;
            // 
            // Frm_ReportesPlantas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Frm_ReportesPlantas";
            this.Text = "Frm_ReportesPlantas";
            this.Load += new System.EventHandler(this.Frm_ReportesPlantas_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private Microsoft.Reporting.WinForms.ReportViewer Rv_Plantas;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.TabPage tabPage3;
    }
}