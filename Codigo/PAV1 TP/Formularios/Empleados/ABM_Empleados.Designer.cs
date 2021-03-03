namespace PAV1_TP.Formularios.Empleados
{
    partial class ABM_Empleados
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ABM_Empleados));
            this.btn_AgregarEmp = new System.Windows.Forms.PictureBox();
            this.btn_EditarEmp = new System.Windows.Forms.PictureBox();
            this.btn_SalirEmp = new System.Windows.Forms.PictureBox();
            this.btn_EliminarEmp = new System.Windows.Forms.PictureBox();
            this.btn_ConsultarEmp = new System.Windows.Forms.Button();
            this.chk_Activos = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Grid_Emp = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Domicilio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Altura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.chk_Inactivos = new System.Windows.Forms.CheckBox();
            this.txt_NombreEmpleado = new PAV1_TP.Clases.TextBox01();
            this.txt_ApellidoEmpleado = new PAV1_TP.Clases.TextBox01();
            this.txt_IdEmpleado = new PAV1_TP.Clases.TextBox01();
            ((System.ComponentModel.ISupportInitialize)(this.btn_AgregarEmp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_EditarEmp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_SalirEmp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_EliminarEmp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Emp)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_AgregarEmp
            // 
            this.btn_AgregarEmp.BackColor = System.Drawing.Color.Transparent;
            this.btn_AgregarEmp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_AgregarEmp.BackgroundImage")));
            this.btn_AgregarEmp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_AgregarEmp.Location = new System.Drawing.Point(12, 359);
            this.btn_AgregarEmp.Name = "btn_AgregarEmp";
            this.btn_AgregarEmp.Size = new System.Drawing.Size(59, 50);
            this.btn_AgregarEmp.TabIndex = 23;
            this.btn_AgregarEmp.TabStop = false;
            this.btn_AgregarEmp.Click += new System.EventHandler(this.btn_AgregarEmp_Click);
            // 
            // btn_EditarEmp
            // 
            this.btn_EditarEmp.BackColor = System.Drawing.Color.Transparent;
            this.btn_EditarEmp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_EditarEmp.BackgroundImage")));
            this.btn_EditarEmp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_EditarEmp.Location = new System.Drawing.Point(79, 359);
            this.btn_EditarEmp.Name = "btn_EditarEmp";
            this.btn_EditarEmp.Size = new System.Drawing.Size(59, 50);
            this.btn_EditarEmp.TabIndex = 22;
            this.btn_EditarEmp.TabStop = false;
            this.btn_EditarEmp.Click += new System.EventHandler(this.btn_EditarEmp_Click);
            // 
            // btn_SalirEmp
            // 
            this.btn_SalirEmp.BackColor = System.Drawing.Color.Transparent;
            this.btn_SalirEmp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_SalirEmp.BackgroundImage")));
            this.btn_SalirEmp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_SalirEmp.Location = new System.Drawing.Point(654, 359);
            this.btn_SalirEmp.Name = "btn_SalirEmp";
            this.btn_SalirEmp.Size = new System.Drawing.Size(59, 50);
            this.btn_SalirEmp.TabIndex = 21;
            this.btn_SalirEmp.TabStop = false;
            this.btn_SalirEmp.Click += new System.EventHandler(this.btn_SalirEmp_Click);
            // 
            // btn_EliminarEmp
            // 
            this.btn_EliminarEmp.BackColor = System.Drawing.Color.Transparent;
            this.btn_EliminarEmp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_EliminarEmp.BackgroundImage")));
            this.btn_EliminarEmp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_EliminarEmp.Location = new System.Drawing.Point(153, 359);
            this.btn_EliminarEmp.Name = "btn_EliminarEmp";
            this.btn_EliminarEmp.Size = new System.Drawing.Size(59, 50);
            this.btn_EliminarEmp.TabIndex = 20;
            this.btn_EliminarEmp.TabStop = false;
            this.btn_EliminarEmp.Click += new System.EventHandler(this.btn_EliminarEmp_Click);
            // 
            // btn_ConsultarEmp
            // 
            this.btn_ConsultarEmp.Location = new System.Drawing.Point(250, 63);
            this.btn_ConsultarEmp.Name = "btn_ConsultarEmp";
            this.btn_ConsultarEmp.Size = new System.Drawing.Size(75, 23);
            this.btn_ConsultarEmp.TabIndex = 6;
            this.btn_ConsultarEmp.Text = "Consultar";
            this.btn_ConsultarEmp.UseVisualStyleBackColor = true;
            this.btn_ConsultarEmp.Click += new System.EventHandler(this.btn_ConsultarEmp_Click);
            // 
            // chk_Activos
            // 
            this.chk_Activos.AutoSize = true;
            this.chk_Activos.BackColor = System.Drawing.Color.Transparent;
            this.chk_Activos.Location = new System.Drawing.Point(82, 89);
            this.chk_Activos.Name = "chk_Activos";
            this.chk_Activos.Size = new System.Drawing.Size(61, 17);
            this.chk_Activos.TabIndex = 4;
            this.chk_Activos.Text = "Activos";
            this.chk_Activos.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(32, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Apellido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(32, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(60, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Id";
            // 
            // Grid_Emp
            // 
            this.Grid_Emp.AllowUserToDeleteRows = false;
            this.Grid_Emp.AllowUserToResizeColumns = false;
            this.Grid_Emp.AllowUserToResizeRows = false;
            this.Grid_Emp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_Emp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nombre,
            this.Apellido,
            this.Tipo,
            this.Domicilio,
            this.Altura});
            this.Grid_Emp.Location = new System.Drawing.Point(12, 116);
            this.Grid_Emp.Name = "Grid_Emp";
            this.Grid_Emp.ReadOnly = true;
            this.Grid_Emp.Size = new System.Drawing.Size(701, 237);
            this.Grid_Emp.StandardTab = true;
            this.Grid_Emp.TabIndex = 0;
            this.Grid_Emp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_Emp_CellContentClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Id.Width = 50;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Nombre.Width = 150;
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            this.Apellido.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Apellido.Width = 150;
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Telefono";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            this.Tipo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Tipo.Width = 120;
            // 
            // Domicilio
            // 
            this.Domicilio.HeaderText = "Calle";
            this.Domicilio.Name = "Domicilio";
            this.Domicilio.ReadOnly = true;
            this.Domicilio.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Domicilio.Width = 130;
            // 
            // Altura
            // 
            this.Altura.HeaderText = "Altura";
            this.Altura.Name = "Altura";
            this.Altura.ReadOnly = true;
            this.Altura.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // chk_Inactivos
            // 
            this.chk_Inactivos.AutoSize = true;
            this.chk_Inactivos.BackColor = System.Drawing.Color.Transparent;
            this.chk_Inactivos.Location = new System.Drawing.Point(144, 88);
            this.chk_Inactivos.Name = "chk_Inactivos";
            this.chk_Inactivos.Size = new System.Drawing.Size(69, 17);
            this.chk_Inactivos.TabIndex = 5;
            this.chk_Inactivos.Text = "Inactivos";
            this.chk_Inactivos.UseVisualStyleBackColor = false;
            this.chk_Inactivos.CheckedChanged += new System.EventHandler(this.chk_Inactivos_CheckedChanged);
            // 
            // txt_NombreEmpleado
            // 
            this.txt_NombreEmpleado.Location = new System.Drawing.Point(82, 33);
            this.txt_NombreEmpleado.Name = "txt_NombreEmpleado";
            this.txt_NombreEmpleado.Pp_mensajeError = null;
            this.txt_NombreEmpleado.Pp_nombre_campo = null;
            this.txt_NombreEmpleado.Pp_nombre_tabla = null;
            this.txt_NombreEmpleado.Pp_validable = false;
            this.txt_NombreEmpleado.Size = new System.Drawing.Size(162, 20);
            this.txt_NombreEmpleado.TabIndex = 2;
            this.txt_NombreEmpleado.TextChanged += new System.EventHandler(this.textBox011_TextChanged);
            // 
            // txt_ApellidoEmpleado
            // 
            this.txt_ApellidoEmpleado.Location = new System.Drawing.Point(82, 62);
            this.txt_ApellidoEmpleado.Name = "txt_ApellidoEmpleado";
            this.txt_ApellidoEmpleado.Pp_mensajeError = null;
            this.txt_ApellidoEmpleado.Pp_nombre_campo = null;
            this.txt_ApellidoEmpleado.Pp_nombre_tabla = null;
            this.txt_ApellidoEmpleado.Pp_validable = false;
            this.txt_ApellidoEmpleado.Size = new System.Drawing.Size(162, 20);
            this.txt_ApellidoEmpleado.TabIndex = 3;
            this.txt_ApellidoEmpleado.TextChanged += new System.EventHandler(this.textBox011_TextChanged);
            // 
            // txt_IdEmpleado
            // 
            this.txt_IdEmpleado.Location = new System.Drawing.Point(82, 7);
            this.txt_IdEmpleado.Name = "txt_IdEmpleado";
            this.txt_IdEmpleado.Pp_mensajeError = null;
            this.txt_IdEmpleado.Pp_nombre_campo = null;
            this.txt_IdEmpleado.Pp_nombre_tabla = null;
            this.txt_IdEmpleado.Pp_validable = false;
            this.txt_IdEmpleado.Size = new System.Drawing.Size(162, 20);
            this.txt_IdEmpleado.TabIndex = 1;
            this.txt_IdEmpleado.TextChanged += new System.EventHandler(this.textBox011_TextChanged);
            // 
            // ABM_Empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(725, 416);
            this.Controls.Add(this.chk_Inactivos);
            this.Controls.Add(this.txt_NombreEmpleado);
            this.Controls.Add(this.txt_ApellidoEmpleado);
            this.Controls.Add(this.txt_IdEmpleado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_AgregarEmp);
            this.Controls.Add(this.btn_EditarEmp);
            this.Controls.Add(this.btn_SalirEmp);
            this.Controls.Add(this.btn_EliminarEmp);
            this.Controls.Add(this.Grid_Emp);
            this.Controls.Add(this.btn_ConsultarEmp);
            this.Controls.Add(this.chk_Activos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ABM_Empleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ABM_Empleados";
            this.Load += new System.EventHandler(this.ABM_Empleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btn_AgregarEmp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_EditarEmp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_SalirEmp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_EliminarEmp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Emp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btn_AgregarEmp;
        private System.Windows.Forms.PictureBox btn_EditarEmp;
        private System.Windows.Forms.PictureBox btn_SalirEmp;
        private System.Windows.Forms.PictureBox btn_EliminarEmp;
        private System.Windows.Forms.Button btn_ConsultarEmp;
        private System.Windows.Forms.CheckBox chk_Activos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView Grid_Emp;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private Clases.TextBox01 txt_IdEmpleado;
        private Clases.TextBox01 txt_NombreEmpleado;
        private Clases.TextBox01 txt_ApellidoEmpleado;
        private System.Windows.Forms.CheckBox chk_Inactivos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Domicilio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Altura;
    }
}