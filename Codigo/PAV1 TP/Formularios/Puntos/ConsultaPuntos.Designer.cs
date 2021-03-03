namespace PAV1_TP.Formularios.Puntos
{
    partial class ConsultaPuntos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaPuntos));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Consultar = new System.Windows.Forms.Button();
            this.txt_Puntos = new PAV1_TP.Clases.TextBox01();
            this.txt_NroDoc = new PAV1_TP.Clases.TextBox01();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Puntos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(5, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nro Doc";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(17, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Puntos";
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(171, 108);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancelar.TabIndex = 6;
            this.btn_Cancelar.Text = "Salir";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Consultar
            // 
            this.btn_Consultar.Location = new System.Drawing.Point(171, 51);
            this.btn_Consultar.Name = "btn_Consultar";
            this.btn_Consultar.Size = new System.Drawing.Size(75, 23);
            this.btn_Consultar.TabIndex = 7;
            this.btn_Consultar.Text = "Consultar";
            this.btn_Consultar.UseVisualStyleBackColor = true;
            this.btn_Consultar.Click += new System.EventHandler(this.btn_Consultar_Click);
            // 
            // txt_Puntos
            // 
            this.txt_Puntos.Enabled = false;
            this.txt_Puntos.Location = new System.Drawing.Point(58, 89);
            this.txt_Puntos.Name = "txt_Puntos";
            this.txt_Puntos.Pp_mensajeError = null;
            this.txt_Puntos.Pp_nombre_campo = null;
            this.txt_Puntos.Pp_nombre_tabla = null;
            this.txt_Puntos.Pp_validable = false;
            this.txt_Puntos.Size = new System.Drawing.Size(66, 20);
            this.txt_Puntos.TabIndex = 2;
            // 
            // txt_NroDoc
            // 
            this.txt_NroDoc.Location = new System.Drawing.Point(58, 53);
            this.txt_NroDoc.Name = "txt_NroDoc";
            this.txt_NroDoc.Pp_mensajeError = "No ingreso Nro Doc";
            this.txt_NroDoc.Pp_nombre_campo = null;
            this.txt_NroDoc.Pp_nombre_tabla = null;
            this.txt_NroDoc.Pp_validable = true;
            this.txt_NroDoc.Size = new System.Drawing.Size(100, 20);
            this.txt_NroDoc.TabIndex = 1;
            // 
            // ConsultaPuntos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(257, 143);
            this.Controls.Add(this.btn_Consultar);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Puntos);
            this.Controls.Add(this.txt_NroDoc);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "ConsultaPuntos";
            this.Text = "ConsultaPuntos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Clases.TextBox01 txt_NroDoc;
        private Clases.TextBox01 txt_Puntos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Consultar;
    }
}