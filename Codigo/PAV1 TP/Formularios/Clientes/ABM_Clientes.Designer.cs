namespace PAV1_TP.Formularios.Clientes
{
    partial class ABM_Clientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ABM_Clientes));
            this.chk_ClientesInactivos = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_AgregarCli = new System.Windows.Forms.PictureBox();
            this.btn_EditarCli = new System.Windows.Forms.PictureBox();
            this.btn_SalirCli = new System.Windows.Forms.PictureBox();
            this.btn_EliminarCli = new System.Windows.Forms.PictureBox();
            this.Grid_Cliente = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Domicilio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Altura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_ConsultarCli = new System.Windows.Forms.Button();
            this.chk_ClientesActivos = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_ApellidoCliente = new PAV1_TP.Clases.TextBox01();
            this.txt_NDocCliente = new PAV1_TP.Clases.TextBox01();
            this.txt_NombreCliente = new PAV1_TP.Clases.TextBox01();
            ((System.ComponentModel.ISupportInitialize)(this.btn_AgregarCli)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_EditarCli)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_SalirCli)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_EliminarCli)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Cliente)).BeginInit();
            this.SuspendLayout();
            // 
            // chk_ClientesInactivos
            // 
            this.chk_ClientesInactivos.AutoSize = true;
            this.chk_ClientesInactivos.BackColor = System.Drawing.Color.Transparent;
            this.chk_ClientesInactivos.Location = new System.Drawing.Point(184, 114);
            this.chk_ClientesInactivos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chk_ClientesInactivos.Name = "chk_ClientesInactivos";
            this.chk_ClientesInactivos.Size = new System.Drawing.Size(85, 21);
            this.chk_ClientesInactivos.TabIndex = 5;
            this.chk_ClientesInactivos.Text = "Inactivos";
            this.chk_ClientesInactivos.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(24, 18);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 26;
            this.label3.Text = "Nro Doc";
            // 
            // btn_AgregarCli
            // 
            this.btn_AgregarCli.BackColor = System.Drawing.Color.Transparent;
            this.btn_AgregarCli.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_AgregarCli.BackgroundImage")));
            this.btn_AgregarCli.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_AgregarCli.Location = new System.Drawing.Point(8, 448);
            this.btn_AgregarCli.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_AgregarCli.Name = "btn_AgregarCli";
            this.btn_AgregarCli.Size = new System.Drawing.Size(79, 62);
            this.btn_AgregarCli.TabIndex = 35;
            this.btn_AgregarCli.TabStop = false;
            this.btn_AgregarCli.Click += new System.EventHandler(this.btn_AgregarCli_Click);
            // 
            // btn_EditarCli
            // 
            this.btn_EditarCli.BackColor = System.Drawing.Color.Transparent;
            this.btn_EditarCli.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_EditarCli.BackgroundImage")));
            this.btn_EditarCli.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_EditarCli.Location = new System.Drawing.Point(97, 448);
            this.btn_EditarCli.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_EditarCli.Name = "btn_EditarCli";
            this.btn_EditarCli.Size = new System.Drawing.Size(79, 62);
            this.btn_EditarCli.TabIndex = 34;
            this.btn_EditarCli.TabStop = false;
            this.btn_EditarCli.Click += new System.EventHandler(this.btn_EditarCli_Click);
            // 
            // btn_SalirCli
            // 
            this.btn_SalirCli.BackColor = System.Drawing.Color.Transparent;
            this.btn_SalirCli.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_SalirCli.BackgroundImage")));
            this.btn_SalirCli.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_SalirCli.Location = new System.Drawing.Point(864, 448);
            this.btn_SalirCli.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_SalirCli.Name = "btn_SalirCli";
            this.btn_SalirCli.Size = new System.Drawing.Size(79, 62);
            this.btn_SalirCli.TabIndex = 33;
            this.btn_SalirCli.TabStop = false;
            this.btn_SalirCli.Click += new System.EventHandler(this.btn_SalirCli_Click);
            // 
            // btn_EliminarCli
            // 
            this.btn_EliminarCli.BackColor = System.Drawing.Color.Transparent;
            this.btn_EliminarCli.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_EliminarCli.BackgroundImage")));
            this.btn_EliminarCli.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_EliminarCli.Location = new System.Drawing.Point(196, 448);
            this.btn_EliminarCli.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_EliminarCli.Name = "btn_EliminarCli";
            this.btn_EliminarCli.Size = new System.Drawing.Size(79, 62);
            this.btn_EliminarCli.TabIndex = 32;
            this.btn_EliminarCli.TabStop = false;
            this.btn_EliminarCli.Click += new System.EventHandler(this.btn_EliminarCli_Click);
            // 
            // Grid_Cliente
            // 
            this.Grid_Cliente.AllowUserToDeleteRows = false;
            this.Grid_Cliente.AllowUserToResizeColumns = false;
            this.Grid_Cliente.AllowUserToResizeRows = false;
            this.Grid_Cliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_Cliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nombre,
            this.Apellido,
            this.Tipo,
            this.Domicilio,
            this.Altura,
            this.Email});
            this.Grid_Cliente.Location = new System.Drawing.Point(11, 148);
            this.Grid_Cliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Grid_Cliente.Name = "Grid_Cliente";
            this.Grid_Cliente.ReadOnly = true;
            this.Grid_Cliente.RowHeadersWidth = 51;
            this.Grid_Cliente.Size = new System.Drawing.Size(935, 292);
            this.Grid_Cliente.StandardTab = true;
            this.Grid_Cliente.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.HeaderText = "Nro Doc";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 150;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 150;
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.MinimumWidth = 6;
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            this.Apellido.Width = 150;
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Telefono";
            this.Tipo.MinimumWidth = 6;
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            this.Tipo.Width = 120;
            // 
            // Domicilio
            // 
            this.Domicilio.HeaderText = "Calle";
            this.Domicilio.MinimumWidth = 6;
            this.Domicilio.Name = "Domicilio";
            this.Domicilio.ReadOnly = true;
            this.Domicilio.Width = 130;
            // 
            // Altura
            // 
            this.Altura.HeaderText = "Altura";
            this.Altura.MinimumWidth = 6;
            this.Altura.Name = "Altura";
            this.Altura.ReadOnly = true;
            this.Altura.Width = 125;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 150;
            // 
            // btn_ConsultarCli
            // 
            this.btn_ConsultarCli.Location = new System.Drawing.Point(315, 80);
            this.btn_ConsultarCli.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_ConsultarCli.Name = "btn_ConsultarCli";
            this.btn_ConsultarCli.Size = new System.Drawing.Size(100, 28);
            this.btn_ConsultarCli.TabIndex = 6;
            this.btn_ConsultarCli.Text = "Consultar";
            this.btn_ConsultarCli.UseVisualStyleBackColor = true;
            this.btn_ConsultarCli.Click += new System.EventHandler(this.btn_ConsultarCli_Click);
            // 
            // chk_ClientesActivos
            // 
            this.chk_ClientesActivos.AutoSize = true;
            this.chk_ClientesActivos.BackColor = System.Drawing.Color.Transparent;
            this.chk_ClientesActivos.Location = new System.Drawing.Point(101, 116);
            this.chk_ClientesActivos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chk_ClientesActivos.Name = "chk_ClientesActivos";
            this.chk_ClientesActivos.Size = new System.Drawing.Size(75, 21);
            this.chk_ClientesActivos.TabIndex = 4;
            this.chk_ClientesActivos.Text = "Activos";
            this.chk_ClientesActivos.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(35, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 28;
            this.label2.Text = "Apellido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(35, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 29;
            this.label1.Text = "Nombre";
            // 
            // txt_ApellidoCliente
            // 
            this.txt_ApellidoCliente.Location = new System.Drawing.Point(97, 80);
            this.txt_ApellidoCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_ApellidoCliente.Name = "txt_ApellidoCliente";
            this.txt_ApellidoCliente.Pp_mensajeError = null;
            this.txt_ApellidoCliente.Pp_nombre_campo = null;
            this.txt_ApellidoCliente.Pp_nombre_tabla = null;
            this.txt_ApellidoCliente.Pp_validable = false;
            this.txt_ApellidoCliente.Size = new System.Drawing.Size(208, 22);
            this.txt_ApellidoCliente.TabIndex = 3;
            // 
            // txt_NDocCliente
            // 
            this.txt_NDocCliente.Location = new System.Drawing.Point(95, 15);
            this.txt_NDocCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_NDocCliente.Name = "txt_NDocCliente";
            this.txt_NDocCliente.Pp_mensajeError = null;
            this.txt_NDocCliente.Pp_nombre_campo = null;
            this.txt_NDocCliente.Pp_nombre_tabla = null;
            this.txt_NDocCliente.Pp_validable = false;
            this.txt_NDocCliente.Size = new System.Drawing.Size(208, 22);
            this.txt_NDocCliente.TabIndex = 1;
            // 
            // txt_NombreCliente
            // 
            this.txt_NombreCliente.Location = new System.Drawing.Point(97, 47);
            this.txt_NombreCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_NombreCliente.Name = "txt_NombreCliente";
            this.txt_NombreCliente.Pp_mensajeError = null;
            this.txt_NombreCliente.Pp_nombre_campo = null;
            this.txt_NombreCliente.Pp_nombre_tabla = null;
            this.txt_NombreCliente.Pp_validable = false;
            this.txt_NombreCliente.Size = new System.Drawing.Size(208, 22);
            this.txt_NombreCliente.TabIndex = 2;
            // 
            // ABM_Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(959, 521);
            this.Controls.Add(this.txt_NombreCliente);
            this.Controls.Add(this.txt_NDocCliente);
            this.Controls.Add(this.txt_ApellidoCliente);
            this.Controls.Add(this.chk_ClientesInactivos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_AgregarCli);
            this.Controls.Add(this.btn_EditarCli);
            this.Controls.Add(this.btn_SalirCli);
            this.Controls.Add(this.btn_EliminarCli);
            this.Controls.Add(this.Grid_Cliente);
            this.Controls.Add(this.btn_ConsultarCli);
            this.Controls.Add(this.chk_ClientesActivos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "ABM_Clientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ABM_Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.btn_AgregarCli)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_EditarCli)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_SalirCli)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_EliminarCli)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Cliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chk_ClientesInactivos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox btn_AgregarCli;
        private System.Windows.Forms.PictureBox btn_EditarCli;
        private System.Windows.Forms.PictureBox btn_SalirCli;
        private System.Windows.Forms.PictureBox btn_EliminarCli;
        private System.Windows.Forms.DataGridView Grid_Cliente;
        private System.Windows.Forms.Button btn_ConsultarCli;
        private System.Windows.Forms.CheckBox chk_ClientesActivos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Clases.TextBox01 txt_ApellidoCliente;
        private Clases.TextBox01 txt_NDocCliente;
        private Clases.TextBox01 txt_NombreCliente;
		private System.Windows.Forms.DataGridViewTextBoxColumn Id;
		private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
		private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
		private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
		private System.Windows.Forms.DataGridViewTextBoxColumn Domicilio;
		private System.Windows.Forms.DataGridViewTextBoxColumn Altura;
		private System.Windows.Forms.DataGridViewTextBoxColumn Email;
	}
}