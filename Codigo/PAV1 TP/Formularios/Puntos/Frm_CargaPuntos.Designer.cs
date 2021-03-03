namespace PAV1_TP.Formularios.Puntos
{
    partial class Frm_CargaPuntos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_CargaPuntos));
            this.btn_Cargar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_TipoFactura = new PAV1_TP.Clases.TextBox01();
            this.txt_Fecha = new PAV1_TP.Clases.TextBox01();
            this.txt_Puntos = new PAV1_TP.Clases.TextBox01();
            this.txt_NroFactura = new PAV1_TP.Clases.TextBox01();
            this.txt_NroDoc = new PAV1_TP.Clases.TextBox01();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_TipoDoc = new PAV1_TP.Clases.TextBox01();
            this.SuspendLayout();
            // 
            // btn_Cargar
            // 
            this.btn_Cargar.Location = new System.Drawing.Point(154, 167);
            this.btn_Cargar.Name = "btn_Cargar";
            this.btn_Cargar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cargar.TabIndex = 4;
            this.btn_Cargar.Text = "Cargar";
            this.btn_Cargar.UseVisualStyleBackColor = true;
            this.btn_Cargar.Click += new System.EventHandler(this.btn_Cargar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Cargar Puntos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(26, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nro Doc";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(197, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nro Factura";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(220, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Puntos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(38, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Fecha";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(197, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Tipo Factura";
            // 
            // txt_TipoFactura
            // 
            this.txt_TipoFactura.Enabled = false;
            this.txt_TipoFactura.Location = new System.Drawing.Point(269, 97);
            this.txt_TipoFactura.Name = "txt_TipoFactura";
            this.txt_TipoFactura.Pp_mensajeError = null;
            this.txt_TipoFactura.Pp_nombre_campo = null;
            this.txt_TipoFactura.Pp_nombre_tabla = null;
            this.txt_TipoFactura.Pp_validable = false;
            this.txt_TipoFactura.Size = new System.Drawing.Size(43, 20);
            this.txt_TipoFactura.TabIndex = 13;
            // 
            // txt_Fecha
            // 
            this.txt_Fecha.Enabled = false;
            this.txt_Fecha.Location = new System.Drawing.Point(79, 123);
            this.txt_Fecha.Name = "txt_Fecha";
            this.txt_Fecha.Pp_mensajeError = null;
            this.txt_Fecha.Pp_nombre_campo = null;
            this.txt_Fecha.Pp_nombre_tabla = null;
            this.txt_Fecha.Pp_validable = false;
            this.txt_Fecha.Size = new System.Drawing.Size(59, 20);
            this.txt_Fecha.TabIndex = 11;
            // 
            // txt_Puntos
            // 
            this.txt_Puntos.Enabled = false;
            this.txt_Puntos.Location = new System.Drawing.Point(269, 127);
            this.txt_Puntos.Name = "txt_Puntos";
            this.txt_Puntos.Pp_mensajeError = null;
            this.txt_Puntos.Pp_nombre_campo = null;
            this.txt_Puntos.Pp_nombre_tabla = null;
            this.txt_Puntos.Pp_validable = false;
            this.txt_Puntos.Size = new System.Drawing.Size(43, 20);
            this.txt_Puntos.TabIndex = 2;
            // 
            // txt_NroFactura
            // 
            this.txt_NroFactura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_NroFactura.Enabled = false;
            this.txt_NroFactura.Location = new System.Drawing.Point(269, 62);
            this.txt_NroFactura.Name = "txt_NroFactura";
            this.txt_NroFactura.Pp_mensajeError = "No ingreso Nro Factura";
            this.txt_NroFactura.Pp_nombre_campo = null;
            this.txt_NroFactura.Pp_nombre_tabla = null;
            this.txt_NroFactura.Pp_validable = true;
            this.txt_NroFactura.Size = new System.Drawing.Size(100, 20);
            this.txt_NroFactura.TabIndex = 1;
            // 
            // txt_NroDoc
            // 
            this.txt_NroDoc.Enabled = false;
            this.txt_NroDoc.Location = new System.Drawing.Point(79, 62);
            this.txt_NroDoc.Name = "txt_NroDoc";
            this.txt_NroDoc.Pp_mensajeError = null;
            this.txt_NroDoc.Pp_nombre_campo = null;
            this.txt_NroDoc.Pp_nombre_tabla = null;
            this.txt_NroDoc.Pp_validable = false;
            this.txt_NroDoc.Size = new System.Drawing.Size(100, 20);
            this.txt_NroDoc.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(22, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Tipo Doc";
            // 
            // txt_TipoDoc
            // 
            this.txt_TipoDoc.Enabled = false;
            this.txt_TipoDoc.Location = new System.Drawing.Point(79, 93);
            this.txt_TipoDoc.Name = "txt_TipoDoc";
            this.txt_TipoDoc.Pp_mensajeError = null;
            this.txt_TipoDoc.Pp_nombre_campo = null;
            this.txt_TipoDoc.Pp_nombre_tabla = null;
            this.txt_TipoDoc.Pp_validable = false;
            this.txt_TipoDoc.Size = new System.Drawing.Size(43, 20);
            this.txt_TipoDoc.TabIndex = 15;
            // 
            // Frm_CargaPuntos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(403, 202);
            this.ControlBox = false;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_TipoDoc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_TipoFactura);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_Fecha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Cargar);
            this.Controls.Add(this.txt_Puntos);
            this.Controls.Add(this.txt_NroFactura);
            this.Controls.Add(this.txt_NroDoc);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_CargaPuntos";
            this.Text = "Frm_CargaPuntos";
            this.Load += new System.EventHandler(this.Frm_CargaPuntos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Clases.TextBox01 txt_NroDoc;
        private Clases.TextBox01 txt_NroFactura;
        private Clases.TextBox01 txt_Puntos;
        private System.Windows.Forms.Button btn_Cargar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Clases.TextBox01 txt_Fecha;
        private System.Windows.Forms.Label label6;
        private Clases.TextBox01 txt_TipoFactura;
        private System.Windows.Forms.Label label7;
        private Clases.TextBox01 txt_TipoDoc;
    }
}