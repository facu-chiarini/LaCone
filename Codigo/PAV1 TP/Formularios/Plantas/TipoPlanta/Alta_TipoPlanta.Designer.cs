namespace PAV1_TP.Formularios.Plantas.TipoPlanta
{
    partial class Alta_TipoPlanta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Alta_TipoPlanta));
            this.txt_IdTipoPlanta = new PAV1_TP.Clases.TextBox01();
            this.txt_NombreTipoPlanta = new PAV1_TP.Clases.TextBox01();
            this.txt_DescripTipoPlanta = new PAV1_TP.Clases.TextBox01();
            this.cmb_EstadoTipoPlanta = new PAV1_TP.Clases.ComboBox01();
            this.btn_RegistrarTipoPlanta = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_IdTipoPlanta
            // 
            this.txt_IdTipoPlanta.Enabled = false;
            this.txt_IdTipoPlanta.Location = new System.Drawing.Point(105, 49);
            this.txt_IdTipoPlanta.Name = "txt_IdTipoPlanta";
            this.txt_IdTipoPlanta.Pp_mensajeError = null;
            this.txt_IdTipoPlanta.Pp_nombre_campo = null;
            this.txt_IdTipoPlanta.Pp_nombre_tabla = null;
            this.txt_IdTipoPlanta.Pp_validable = false;
            this.txt_IdTipoPlanta.Size = new System.Drawing.Size(56, 20);
            this.txt_IdTipoPlanta.TabIndex = 0;
            // 
            // txt_NombreTipoPlanta
            // 
            this.txt_NombreTipoPlanta.Location = new System.Drawing.Point(105, 84);
            this.txt_NombreTipoPlanta.Name = "txt_NombreTipoPlanta";
            this.txt_NombreTipoPlanta.Pp_mensajeError = "No se ingreso el nombre";
            this.txt_NombreTipoPlanta.Pp_nombre_campo = null;
            this.txt_NombreTipoPlanta.Pp_nombre_tabla = null;
            this.txt_NombreTipoPlanta.Pp_validable = true;
            this.txt_NombreTipoPlanta.Size = new System.Drawing.Size(100, 20);
            this.txt_NombreTipoPlanta.TabIndex = 1;
            // 
            // txt_DescripTipoPlanta
            // 
            this.txt_DescripTipoPlanta.Location = new System.Drawing.Point(105, 116);
            this.txt_DescripTipoPlanta.Name = "txt_DescripTipoPlanta";
            this.txt_DescripTipoPlanta.Pp_mensajeError = "No se ingreso descripcion";
            this.txt_DescripTipoPlanta.Pp_nombre_campo = null;
            this.txt_DescripTipoPlanta.Pp_nombre_tabla = null;
            this.txt_DescripTipoPlanta.Pp_validable = true;
            this.txt_DescripTipoPlanta.Size = new System.Drawing.Size(100, 20);
            this.txt_DescripTipoPlanta.TabIndex = 2;
            // 
            // cmb_EstadoTipoPlanta
            // 
            this.cmb_EstadoTipoPlanta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_EstadoTipoPlanta.FormattingEnabled = true;
            this.cmb_EstadoTipoPlanta.Location = new System.Drawing.Point(105, 153);
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
            this.cmb_EstadoTipoPlanta.TabIndex = 3;
            // 
            // btn_RegistrarTipoPlanta
            // 
            this.btn_RegistrarTipoPlanta.Location = new System.Drawing.Point(49, 202);
            this.btn_RegistrarTipoPlanta.Name = "btn_RegistrarTipoPlanta";
            this.btn_RegistrarTipoPlanta.Size = new System.Drawing.Size(75, 23);
            this.btn_RegistrarTipoPlanta.TabIndex = 8;
            this.btn_RegistrarTipoPlanta.Text = "Registrar";
            this.btn_RegistrarTipoPlanta.UseVisualStyleBackColor = true;
            this.btn_RegistrarTipoPlanta.Click += new System.EventHandler(this.btn_RegistrarTipoPlanta_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(130, 202);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancelar.TabIndex = 9;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(25, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(227, 32);
            this.label5.TabIndex = 21;
            this.label5.Text = "Registrar tipo planta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(37, 153);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "Estado";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(77, 49);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 16);
            this.label6.TabIndex = 23;
            this.label6.Text = "ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(37, 84);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 16);
            this.label7.TabIndex = 24;
            this.label7.Text = "Nombre";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(9, 116);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 16);
            this.label8.TabIndex = 25;
            this.label8.Text = "Descripcion";
            // 
            // Alta_TipoPlanta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(235, 236);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_RegistrarTipoPlanta);
            this.Controls.Add(this.cmb_EstadoTipoPlanta);
            this.Controls.Add(this.txt_DescripTipoPlanta);
            this.Controls.Add(this.txt_NombreTipoPlanta);
            this.Controls.Add(this.txt_IdTipoPlanta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Alta_TipoPlanta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Alta_TipoPlanta";
            this.Load += new System.EventHandler(this.Alta_TipoPlanta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Clases.TextBox01 txt_IdTipoPlanta;
        private Clases.TextBox01 txt_NombreTipoPlanta;
        private Clases.TextBox01 txt_DescripTipoPlanta;
        private Clases.ComboBox01 cmb_EstadoTipoPlanta;
        private System.Windows.Forms.Button btn_RegistrarTipoPlanta;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}