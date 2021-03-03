namespace PAV1_TP.Formularios.Plantas.TipoPlanta
{
    partial class Modificacion_TipoPlanta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Modificacion_TipoPlanta));
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_ModifTipoPlanta = new System.Windows.Forms.Button();
            this.cmb_EstadoTipoPlanta = new PAV1_TP.Clases.ComboBox01();
            this.txt_DescripTipoPlanta = new PAV1_TP.Clases.TextBox01();
            this.txt_NombreTipoPlanta = new PAV1_TP.Clases.TextBox01();
            this.txt_IdTipoPlanta = new PAV1_TP.Clases.TextBox01();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(26, 125);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 16);
            this.label8.TabIndex = 36;
            this.label8.Text = "Descripcion";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(54, 93);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 16);
            this.label7.TabIndex = 35;
            this.label7.Text = "Nombre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(94, 58);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 16);
            this.label6.TabIndex = 34;
            this.label6.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(54, 162);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 33;
            this.label1.Text = "Estado";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(42, 18);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(227, 32);
            this.label5.TabIndex = 32;
            this.label5.Text = "Modificar tipo planta";
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(147, 211);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancelar.TabIndex = 31;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_ModifTipoPlanta
            // 
            this.btn_ModifTipoPlanta.Location = new System.Drawing.Point(66, 211);
            this.btn_ModifTipoPlanta.Name = "btn_ModifTipoPlanta";
            this.btn_ModifTipoPlanta.Size = new System.Drawing.Size(75, 23);
            this.btn_ModifTipoPlanta.TabIndex = 30;
            this.btn_ModifTipoPlanta.Text = "Modificar";
            this.btn_ModifTipoPlanta.UseVisualStyleBackColor = true;
            this.btn_ModifTipoPlanta.Click += new System.EventHandler(this.btn_ModifTipoPlanta_Click);
            // 
            // cmb_EstadoTipoPlanta
            // 
            this.cmb_EstadoTipoPlanta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_EstadoTipoPlanta.FormattingEnabled = true;
            this.cmb_EstadoTipoPlanta.Location = new System.Drawing.Point(122, 162);
            this.cmb_EstadoTipoPlanta.Name = "cmb_EstadoTipoPlanta";
            this.cmb_EstadoTipoPlanta.Pp_Display = "Descripcion";
            this.cmb_EstadoTipoPlanta.Pp_mensajeError = "No se selecciono un estado";
            this.cmb_EstadoTipoPlanta.Pp_nombre_campo = null;
            this.cmb_EstadoTipoPlanta.Pp_nombre_tabla = null;
            this.cmb_EstadoTipoPlanta.Pp_seleccionado = false;
            this.cmb_EstadoTipoPlanta.Pp_Tabla = "Estado";
            this.cmb_EstadoTipoPlanta.Pp_validable = true;
            this.cmb_EstadoTipoPlanta.Pp_Value = "ID";
            this.cmb_EstadoTipoPlanta.Size = new System.Drawing.Size(100, 21);
            this.cmb_EstadoTipoPlanta.TabIndex = 29;
            // 
            // txt_DescripTipoPlanta
            // 
            this.txt_DescripTipoPlanta.Location = new System.Drawing.Point(122, 125);
            this.txt_DescripTipoPlanta.Name = "txt_DescripTipoPlanta";
            this.txt_DescripTipoPlanta.Pp_mensajeError = "No se ingreso una descipcion";
            this.txt_DescripTipoPlanta.Pp_nombre_campo = null;
            this.txt_DescripTipoPlanta.Pp_nombre_tabla = null;
            this.txt_DescripTipoPlanta.Pp_validable = true;
            this.txt_DescripTipoPlanta.Size = new System.Drawing.Size(100, 20);
            this.txt_DescripTipoPlanta.TabIndex = 28;
            // 
            // txt_NombreTipoPlanta
            // 
            this.txt_NombreTipoPlanta.Location = new System.Drawing.Point(122, 93);
            this.txt_NombreTipoPlanta.Name = "txt_NombreTipoPlanta";
            this.txt_NombreTipoPlanta.Pp_mensajeError = "No se ingreso un estado";
            this.txt_NombreTipoPlanta.Pp_nombre_campo = null;
            this.txt_NombreTipoPlanta.Pp_nombre_tabla = null;
            this.txt_NombreTipoPlanta.Pp_validable = true;
            this.txt_NombreTipoPlanta.Size = new System.Drawing.Size(100, 20);
            this.txt_NombreTipoPlanta.TabIndex = 27;
            // 
            // txt_IdTipoPlanta
            // 
            this.txt_IdTipoPlanta.Enabled = false;
            this.txt_IdTipoPlanta.Location = new System.Drawing.Point(122, 58);
            this.txt_IdTipoPlanta.Name = "txt_IdTipoPlanta";
            this.txt_IdTipoPlanta.Pp_mensajeError = null;
            this.txt_IdTipoPlanta.Pp_nombre_campo = null;
            this.txt_IdTipoPlanta.Pp_nombre_tabla = null;
            this.txt_IdTipoPlanta.Pp_validable = false;
            this.txt_IdTipoPlanta.Size = new System.Drawing.Size(56, 20);
            this.txt_IdTipoPlanta.TabIndex = 26;
            // 
            // Modificacion_TipoPlanta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(251, 242);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_ModifTipoPlanta);
            this.Controls.Add(this.cmb_EstadoTipoPlanta);
            this.Controls.Add(this.txt_DescripTipoPlanta);
            this.Controls.Add(this.txt_NombreTipoPlanta);
            this.Controls.Add(this.txt_IdTipoPlanta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Modificacion_TipoPlanta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Modificacion_TipoPlanta";
            this.Load += new System.EventHandler(this.Modificacion_TipoPlanta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_ModifTipoPlanta;
        private Clases.ComboBox01 cmb_EstadoTipoPlanta;
        private Clases.TextBox01 txt_DescripTipoPlanta;
        private Clases.TextBox01 txt_NombreTipoPlanta;
        private Clases.TextBox01 txt_IdTipoPlanta;
    }
}