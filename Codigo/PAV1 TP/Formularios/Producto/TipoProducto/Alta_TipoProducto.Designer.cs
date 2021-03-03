namespace PAV1_TP.Formularios.Producto.TipoProducto
{
    partial class Alta_TipoProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Alta_TipoProducto));
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_RegistrarTipoProducto = new System.Windows.Forms.Button();
            this.cmb_EstadoTipoProducto = new PAV1_TP.Clases.ComboBox01();
            this.txt_DescripTipoProducto = new PAV1_TP.Clases.TextBox01();
            this.txt_NombreTipoProducto = new PAV1_TP.Clases.TextBox01();
            this.txt_IdTipoProducto = new PAV1_TP.Clases.TextBox01();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(21, 116);
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
            this.label7.Location = new System.Drawing.Point(49, 84);
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
            this.label6.Location = new System.Drawing.Point(89, 49);
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
            this.label1.Location = new System.Drawing.Point(49, 153);
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
            this.label5.Location = new System.Drawing.Point(20, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(227, 32);
            this.label5.TabIndex = 32;
            this.label5.Text = "Registrar tipo producto";
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(142, 202);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancelar.TabIndex = 31;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_RegistrarTipoProducto
            // 
            this.btn_RegistrarTipoProducto.Location = new System.Drawing.Point(61, 202);
            this.btn_RegistrarTipoProducto.Name = "btn_RegistrarTipoProducto";
            this.btn_RegistrarTipoProducto.Size = new System.Drawing.Size(75, 23);
            this.btn_RegistrarTipoProducto.TabIndex = 30;
            this.btn_RegistrarTipoProducto.Text = "Registrar";
            this.btn_RegistrarTipoProducto.UseVisualStyleBackColor = true;
            this.btn_RegistrarTipoProducto.Click += new System.EventHandler(this.btn_RegistrarTipoPlanta_Click);
            // 
            // cmb_EstadoTipoProducto
            // 
            this.cmb_EstadoTipoProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_EstadoTipoProducto.FormattingEnabled = true;
            this.cmb_EstadoTipoProducto.Location = new System.Drawing.Point(117, 153);
            this.cmb_EstadoTipoProducto.Name = "cmb_EstadoTipoProducto";
            this.cmb_EstadoTipoProducto.Pp_Display = "Descripcion";
            this.cmb_EstadoTipoProducto.Pp_mensajeError = "No se selecciono un estado";
            this.cmb_EstadoTipoProducto.Pp_nombre_campo = null;
            this.cmb_EstadoTipoProducto.Pp_nombre_tabla = null;
            this.cmb_EstadoTipoProducto.Pp_seleccionado = false;
            this.cmb_EstadoTipoProducto.Pp_Tabla = "Estado";
            this.cmb_EstadoTipoProducto.Pp_validable = true;
            this.cmb_EstadoTipoProducto.Pp_Value = "ID";
            this.cmb_EstadoTipoProducto.Size = new System.Drawing.Size(100, 21);
            this.cmb_EstadoTipoProducto.TabIndex = 29;
            // 
            // txt_DescripTipoProducto
            // 
            this.txt_DescripTipoProducto.Location = new System.Drawing.Point(117, 116);
            this.txt_DescripTipoProducto.Name = "txt_DescripTipoProducto";
            this.txt_DescripTipoProducto.Pp_mensajeError = "No se ingreso la descripcion";
            this.txt_DescripTipoProducto.Pp_nombre_campo = null;
            this.txt_DescripTipoProducto.Pp_nombre_tabla = null;
            this.txt_DescripTipoProducto.Pp_validable = true;
            this.txt_DescripTipoProducto.Size = new System.Drawing.Size(100, 20);
            this.txt_DescripTipoProducto.TabIndex = 28;
            // 
            // txt_NombreTipoProducto
            // 
            this.txt_NombreTipoProducto.Location = new System.Drawing.Point(117, 84);
            this.txt_NombreTipoProducto.Name = "txt_NombreTipoProducto";
            this.txt_NombreTipoProducto.Pp_mensajeError = "No se ingreso el nombre";
            this.txt_NombreTipoProducto.Pp_nombre_campo = null;
            this.txt_NombreTipoProducto.Pp_nombre_tabla = null;
            this.txt_NombreTipoProducto.Pp_validable = true;
            this.txt_NombreTipoProducto.Size = new System.Drawing.Size(100, 20);
            this.txt_NombreTipoProducto.TabIndex = 27;
            // 
            // txt_IdTipoProducto
            // 
            this.txt_IdTipoProducto.Enabled = false;
            this.txt_IdTipoProducto.Location = new System.Drawing.Point(117, 49);
            this.txt_IdTipoProducto.Name = "txt_IdTipoProducto";
            this.txt_IdTipoProducto.Pp_mensajeError = null;
            this.txt_IdTipoProducto.Pp_nombre_campo = null;
            this.txt_IdTipoProducto.Pp_nombre_tabla = null;
            this.txt_IdTipoProducto.Pp_validable = false;
            this.txt_IdTipoProducto.Size = new System.Drawing.Size(56, 20);
            this.txt_IdTipoProducto.TabIndex = 26;
            // 
            // Alta_TipoProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(257, 238);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_RegistrarTipoProducto);
            this.Controls.Add(this.cmb_EstadoTipoProducto);
            this.Controls.Add(this.txt_DescripTipoProducto);
            this.Controls.Add(this.txt_NombreTipoProducto);
            this.Controls.Add(this.txt_IdTipoProducto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Alta_TipoProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Alta_TipoProducto";
            this.Load += new System.EventHandler(this.Alta_TipoProducto_Load);
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
        private System.Windows.Forms.Button btn_RegistrarTipoProducto;
        private Clases.ComboBox01 cmb_EstadoTipoProducto;
        private Clases.TextBox01 txt_DescripTipoProducto;
        private Clases.TextBox01 txt_NombreTipoProducto;
        private Clases.TextBox01 txt_IdTipoProducto;
    }
}