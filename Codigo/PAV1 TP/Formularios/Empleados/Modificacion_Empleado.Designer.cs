namespace PAV1_TP.Formularios.Empleados
{
    partial class Modificacion_Empleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Modificacion_Empleado));
            this.label3 = new System.Windows.Forms.Label();
            this.btn_CancelarEmpleado = new System.Windows.Forms.Button();
            this.btn_ModificarEmpleado = new System.Windows.Forms.Button();
            this.txt_Contraseña = new PAV1_TP.Clases.TextBox01();
            this.txt_Contraseña2 = new PAV1_TP.Clases.TextBox01();
            this.txt_TelefonoEmpleado = new PAV1_TP.Clases.TextBox01();
            this.txt_CalleEmpleado = new PAV1_TP.Clases.TextBox01();
            this.txt_NCalleEmpleado = new PAV1_TP.Clases.TextBox01();
            this.txt_ApellidoEmpleado = new PAV1_TP.Clases.TextBox01();
            this.txt_NombreEmpleado = new PAV1_TP.Clases.TextBox01();
            this.txt_IdEmpleado = new PAV1_TP.Clases.TextBox01();
            this.label14 = new System.Windows.Forms.Label();
            this.cmb_EstadoEmp = new PAV1_TP.Clases.ComboBox01();
            this.label13 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmb_LocalidadEmpleado = new PAV1_TP.Clases.ComboBox01();
            this.cmb_BarrioEmpleado = new PAV1_TP.Clases.ComboBox01();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Modificar empleado";
            // 
            // btn_CancelarEmpleado
            // 
            this.btn_CancelarEmpleado.Location = new System.Drawing.Point(543, 354);
            this.btn_CancelarEmpleado.Name = "btn_CancelarEmpleado";
            this.btn_CancelarEmpleado.Size = new System.Drawing.Size(82, 23);
            this.btn_CancelarEmpleado.TabIndex = 10;
            this.btn_CancelarEmpleado.Text = "Cancelar";
            this.btn_CancelarEmpleado.UseVisualStyleBackColor = true;
            this.btn_CancelarEmpleado.Click += new System.EventHandler(this.btn_CancelarEmpleado_Click);
            // 
            // btn_ModificarEmpleado
            // 
            this.btn_ModificarEmpleado.Location = new System.Drawing.Point(462, 354);
            this.btn_ModificarEmpleado.Name = "btn_ModificarEmpleado";
            this.btn_ModificarEmpleado.Size = new System.Drawing.Size(75, 23);
            this.btn_ModificarEmpleado.TabIndex = 9;
            this.btn_ModificarEmpleado.Text = "Modificar";
            this.btn_ModificarEmpleado.UseVisualStyleBackColor = true;
            this.btn_ModificarEmpleado.Click += new System.EventHandler(this.btn_RegistrarEmpleado_Click);
            // 
            // txt_Contraseña
            // 
            this.txt_Contraseña.Location = new System.Drawing.Point(399, 76);
            this.txt_Contraseña.Name = "txt_Contraseña";
            this.txt_Contraseña.PasswordChar = '*';
            this.txt_Contraseña.Pp_mensajeError = "Falta cargar contraseña";
            this.txt_Contraseña.Pp_nombre_campo = "Contraseña";
            this.txt_Contraseña.Pp_nombre_tabla = "Empleado";
            this.txt_Contraseña.Pp_validable = true;
            this.txt_Contraseña.Size = new System.Drawing.Size(191, 20);
            this.txt_Contraseña.TabIndex = 71;
            // 
            // txt_Contraseña2
            // 
            this.txt_Contraseña2.Location = new System.Drawing.Point(399, 122);
            this.txt_Contraseña2.Name = "txt_Contraseña2";
            this.txt_Contraseña2.PasswordChar = '*';
            this.txt_Contraseña2.Pp_mensajeError = "Falta cargar contraseña 2";
            this.txt_Contraseña2.Pp_nombre_campo = null;
            this.txt_Contraseña2.Pp_nombre_tabla = "Empleado";
            this.txt_Contraseña2.Pp_validable = true;
            this.txt_Contraseña2.Size = new System.Drawing.Size(191, 20);
            this.txt_Contraseña2.TabIndex = 72;
            // 
            // txt_TelefonoEmpleado
            // 
            this.txt_TelefonoEmpleado.Location = new System.Drawing.Point(399, 218);
            this.txt_TelefonoEmpleado.Name = "txt_TelefonoEmpleado";
            this.txt_TelefonoEmpleado.Pp_mensajeError = null;
            this.txt_TelefonoEmpleado.Pp_nombre_campo = "Telefono";
            this.txt_TelefonoEmpleado.Pp_nombre_tabla = "Empleado";
            this.txt_TelefonoEmpleado.Pp_validable = false;
            this.txt_TelefonoEmpleado.Size = new System.Drawing.Size(191, 20);
            this.txt_TelefonoEmpleado.TabIndex = 78;
            // 
            // txt_CalleEmpleado
            // 
            this.txt_CalleEmpleado.Location = new System.Drawing.Point(102, 288);
            this.txt_CalleEmpleado.Name = "txt_CalleEmpleado";
            this.txt_CalleEmpleado.Pp_mensajeError = "Falta cargar calle";
            this.txt_CalleEmpleado.Pp_nombre_campo = "Calle";
            this.txt_CalleEmpleado.Pp_nombre_tabla = "Empleado";
            this.txt_CalleEmpleado.Pp_validable = true;
            this.txt_CalleEmpleado.Size = new System.Drawing.Size(191, 20);
            this.txt_CalleEmpleado.TabIndex = 76;
            // 
            // txt_NCalleEmpleado
            // 
            this.txt_NCalleEmpleado.Location = new System.Drawing.Point(102, 323);
            this.txt_NCalleEmpleado.Name = "txt_NCalleEmpleado";
            this.txt_NCalleEmpleado.Pp_mensajeError = "Falta cargar Nro de calle";
            this.txt_NCalleEmpleado.Pp_nombre_campo = "Nro_Calle";
            this.txt_NCalleEmpleado.Pp_nombre_tabla = "Empleado";
            this.txt_NCalleEmpleado.Pp_validable = true;
            this.txt_NCalleEmpleado.Size = new System.Drawing.Size(191, 20);
            this.txt_NCalleEmpleado.TabIndex = 77;
            // 
            // txt_ApellidoEmpleado
            // 
            this.txt_ApellidoEmpleado.Location = new System.Drawing.Point(83, 144);
            this.txt_ApellidoEmpleado.Name = "txt_ApellidoEmpleado";
            this.txt_ApellidoEmpleado.Pp_mensajeError = "Falta cargar apellido";
            this.txt_ApellidoEmpleado.Pp_nombre_campo = "Apellido";
            this.txt_ApellidoEmpleado.Pp_nombre_tabla = "Empleado";
            this.txt_ApellidoEmpleado.Pp_validable = true;
            this.txt_ApellidoEmpleado.Size = new System.Drawing.Size(191, 20);
            this.txt_ApellidoEmpleado.TabIndex = 70;
            // 
            // txt_NombreEmpleado
            // 
            this.txt_NombreEmpleado.Location = new System.Drawing.Point(83, 104);
            this.txt_NombreEmpleado.Name = "txt_NombreEmpleado";
            this.txt_NombreEmpleado.Pp_mensajeError = "Falta cargar nombre";
            this.txt_NombreEmpleado.Pp_nombre_campo = "Nombre";
            this.txt_NombreEmpleado.Pp_nombre_tabla = "Empleado";
            this.txt_NombreEmpleado.Pp_validable = true;
            this.txt_NombreEmpleado.Size = new System.Drawing.Size(191, 20);
            this.txt_NombreEmpleado.TabIndex = 69;
            // 
            // txt_IdEmpleado
            // 
            this.txt_IdEmpleado.Enabled = false;
            this.txt_IdEmpleado.Location = new System.Drawing.Point(83, 72);
            this.txt_IdEmpleado.Name = "txt_IdEmpleado";
            this.txt_IdEmpleado.Pp_mensajeError = "";
            this.txt_IdEmpleado.Pp_nombre_campo = "";
            this.txt_IdEmpleado.Pp_nombre_tabla = "";
            this.txt_IdEmpleado.Pp_validable = false;
            this.txt_IdEmpleado.Size = new System.Drawing.Size(63, 20);
            this.txt_IdEmpleado.TabIndex = 64;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(306, 165);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 16);
            this.label14.TabIndex = 82;
            this.label14.Text = "Estado";
            // 
            // cmb_EstadoEmp
            // 
            this.cmb_EstadoEmp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_EstadoEmp.FormattingEnabled = true;
            this.cmb_EstadoEmp.Location = new System.Drawing.Point(399, 164);
            this.cmb_EstadoEmp.Name = "cmb_EstadoEmp";
            this.cmb_EstadoEmp.Pp_Display = "Descripcion";
            this.cmb_EstadoEmp.Pp_mensajeError = "Falta seleccionar localidad";
            this.cmb_EstadoEmp.Pp_nombre_campo = "Estado";
            this.cmb_EstadoEmp.Pp_nombre_tabla = "Empleado";
            this.cmb_EstadoEmp.Pp_seleccionado = false;
            this.cmb_EstadoEmp.Pp_Tabla = "Estado";
            this.cmb_EstadoEmp.Pp_validable = true;
            this.cmb_EstadoEmp.Pp_Value = "ID";
            this.cmb_EstadoEmp.Size = new System.Drawing.Size(191, 21);
            this.cmb_EstadoEmp.TabIndex = 73;
            this.cmb_EstadoEmp.SelectedIndexChanged += new System.EventHandler(this.cmb_EstadoEmp_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(306, 76);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(87, 16);
            this.label13.TabIndex = 81;
            this.label13.Text = "Contraseña";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(306, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 32);
            this.label6.TabIndex = 80;
            this.label6.Text = "Repetir \r\nContraseña";
            // 
            // cmb_LocalidadEmpleado
            // 
            this.cmb_LocalidadEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_LocalidadEmpleado.FormattingEnabled = true;
            this.cmb_LocalidadEmpleado.Location = new System.Drawing.Point(102, 215);
            this.cmb_LocalidadEmpleado.Name = "cmb_LocalidadEmpleado";
            this.cmb_LocalidadEmpleado.Pp_Display = "Nombre";
            this.cmb_LocalidadEmpleado.Pp_mensajeError = "Falta seleccionar localidad";
            this.cmb_LocalidadEmpleado.Pp_nombre_campo = "Localidad";
            this.cmb_LocalidadEmpleado.Pp_nombre_tabla = "Empleado";
            this.cmb_LocalidadEmpleado.Pp_seleccionado = false;
            this.cmb_LocalidadEmpleado.Pp_Tabla = "Localidad";
            this.cmb_LocalidadEmpleado.Pp_validable = true;
            this.cmb_LocalidadEmpleado.Pp_Value = "ID";
            this.cmb_LocalidadEmpleado.Size = new System.Drawing.Size(191, 21);
            this.cmb_LocalidadEmpleado.TabIndex = 74;
            this.cmb_LocalidadEmpleado.SelectedIndexChanged += new System.EventHandler(this.cmb_LocalidadEmpleado_SelectedIndexChanged);
            // 
            // cmb_BarrioEmpleado
            // 
            this.cmb_BarrioEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_BarrioEmpleado.FormattingEnabled = true;
            this.cmb_BarrioEmpleado.Location = new System.Drawing.Point(102, 249);
            this.cmb_BarrioEmpleado.Name = "cmb_BarrioEmpleado";
            this.cmb_BarrioEmpleado.Pp_Display = "Nombre";
            this.cmb_BarrioEmpleado.Pp_mensajeError = "Falta seleccionar Barrio";
            this.cmb_BarrioEmpleado.Pp_nombre_campo = "Barrio";
            this.cmb_BarrioEmpleado.Pp_nombre_tabla = "Empleado";
            this.cmb_BarrioEmpleado.Pp_seleccionado = false;
            this.cmb_BarrioEmpleado.Pp_Tabla = "Barrio";
            this.cmb_BarrioEmpleado.Pp_validable = true;
            this.cmb_BarrioEmpleado.Pp_Value = "ID";
            this.cmb_BarrioEmpleado.Size = new System.Drawing.Size(191, 21);
            this.cmb_BarrioEmpleado.TabIndex = 75;
            this.cmb_BarrioEmpleado.SelectedIndexChanged += new System.EventHandler(this.cmb_BarrioEmpleado_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 20);
            this.label5.TabIndex = 67;
            this.label5.Text = "Datos de Domicilio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 20);
            this.label4.TabIndex = 66;
            this.label4.Text = "Datos personales";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(34, 327);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 16);
            this.label11.TabIndex = 65;
            this.label11.Text = "N° Calle";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(52, 289);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 16);
            this.label10.TabIndex = 63;
            this.label10.Text = "Calle";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(46, 254);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 16);
            this.label9.TabIndex = 62;
            this.label9.Text = "Barrio";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(323, 222);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 16);
            this.label12.TabIndex = 61;
            this.label12.Text = "Teléfono";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(19, 220);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 16);
            this.label8.TabIndex = 60;
            this.label8.Text = "Localidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 79;
            this.label2.Text = "Apellido";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 16);
            this.label7.TabIndex = 68;
            this.label7.Text = "Id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 59;
            this.label1.Text = "Nombre";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(601, 122);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 20);
            this.pictureBox1.TabIndex = 83;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Modificacion_Empleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(641, 391);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_Contraseña);
            this.Controls.Add(this.txt_Contraseña2);
            this.Controls.Add(this.txt_TelefonoEmpleado);
            this.Controls.Add(this.txt_CalleEmpleado);
            this.Controls.Add(this.txt_NCalleEmpleado);
            this.Controls.Add(this.txt_ApellidoEmpleado);
            this.Controls.Add(this.txt_NombreEmpleado);
            this.Controls.Add(this.txt_IdEmpleado);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.cmb_EstadoEmp);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmb_LocalidadEmpleado);
            this.Controls.Add(this.cmb_BarrioEmpleado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_CancelarEmpleado);
            this.Controls.Add(this.btn_ModificarEmpleado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Modificacion_Empleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Modificacion_Empleado";
            this.Load += new System.EventHandler(this.Modificacion_Empleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_CancelarEmpleado;
        private System.Windows.Forms.Button btn_ModificarEmpleado;
        private Clases.TextBox01 txt_Contraseña;
        private Clases.TextBox01 txt_Contraseña2;
        private Clases.TextBox01 txt_TelefonoEmpleado;
        private Clases.TextBox01 txt_CalleEmpleado;
        private Clases.TextBox01 txt_NCalleEmpleado;
        private Clases.TextBox01 txt_ApellidoEmpleado;
        private Clases.TextBox01 txt_NombreEmpleado;
        private Clases.TextBox01 txt_IdEmpleado;
        private System.Windows.Forms.Label label14;
        private Clases.ComboBox01 cmb_EstadoEmp;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label6;
        private Clases.ComboBox01 cmb_LocalidadEmpleado;
        private Clases.ComboBox01 cmb_BarrioEmpleado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}