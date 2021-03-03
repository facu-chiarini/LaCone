namespace PAV1_TP.Formularios.Producto.TipoProducto
{
    partial class ABM_TipoProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ABM_TipoProducto));
            this.btn_ModificarTipoProducto = new System.Windows.Forms.PictureBox();
            this.btn_Cancelar = new System.Windows.Forms.PictureBox();
            this.btn_EliminarTipoPlanta = new System.Windows.Forms.PictureBox();
            this.btn_AgregarTipoPlanta = new System.Windows.Forms.PictureBox();
            this.Grid_TipoProducto = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_NombreTipoPlanta = new System.Windows.Forms.TextBox();
            this.chk_TipoProductoInactivos = new System.Windows.Forms.CheckBox();
            this.chk_TipoProductosActivos = new System.Windows.Forms.CheckBox();
            this.btn_ConsultarTipoPlanta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_IdTipoPlanta = new PAV1_TP.Clases.TextBox01();
            ((System.ComponentModel.ISupportInitialize)(this.btn_ModificarTipoProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Cancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_EliminarTipoPlanta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_AgregarTipoPlanta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_TipoProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_ModificarTipoProducto
            // 
            this.btn_ModificarTipoProducto.BackColor = System.Drawing.Color.Transparent;
            this.btn_ModificarTipoProducto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_ModificarTipoProducto.BackgroundImage")));
            this.btn_ModificarTipoProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ModificarTipoProducto.Location = new System.Drawing.Point(74, 348);
            this.btn_ModificarTipoProducto.Name = "btn_ModificarTipoProducto";
            this.btn_ModificarTipoProducto.Size = new System.Drawing.Size(59, 50);
            this.btn_ModificarTipoProducto.TabIndex = 42;
            this.btn_ModificarTipoProducto.TabStop = false;
            this.btn_ModificarTipoProducto.Click += new System.EventHandler(this.btn_ModificarTipoProducto_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.BackColor = System.Drawing.Color.Transparent;
            this.btn_Cancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Cancelar.BackgroundImage")));
            this.btn_Cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Cancelar.Location = new System.Drawing.Point(485, 348);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(59, 50);
            this.btn_Cancelar.TabIndex = 41;
            this.btn_Cancelar.TabStop = false;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_EliminarTipoPlanta
            // 
            this.btn_EliminarTipoPlanta.BackColor = System.Drawing.Color.Transparent;
            this.btn_EliminarTipoPlanta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_EliminarTipoPlanta.BackgroundImage")));
            this.btn_EliminarTipoPlanta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_EliminarTipoPlanta.Location = new System.Drawing.Point(139, 348);
            this.btn_EliminarTipoPlanta.Name = "btn_EliminarTipoPlanta";
            this.btn_EliminarTipoPlanta.Size = new System.Drawing.Size(59, 50);
            this.btn_EliminarTipoPlanta.TabIndex = 40;
            this.btn_EliminarTipoPlanta.TabStop = false;
            this.btn_EliminarTipoPlanta.Click += new System.EventHandler(this.btn_EliminarTipoPlanta_Click);
            // 
            // btn_AgregarTipoPlanta
            // 
            this.btn_AgregarTipoPlanta.Image = ((System.Drawing.Image)(resources.GetObject("btn_AgregarTipoPlanta.Image")));
            this.btn_AgregarTipoPlanta.Location = new System.Drawing.Point(10, 348);
            this.btn_AgregarTipoPlanta.Margin = new System.Windows.Forms.Padding(2);
            this.btn_AgregarTipoPlanta.Name = "btn_AgregarTipoPlanta";
            this.btn_AgregarTipoPlanta.Size = new System.Drawing.Size(59, 50);
            this.btn_AgregarTipoPlanta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_AgregarTipoPlanta.TabIndex = 39;
            this.btn_AgregarTipoPlanta.TabStop = false;
            this.btn_AgregarTipoPlanta.Click += new System.EventHandler(this.btn_AgregarTipoPlanta_Click);
            // 
            // Grid_TipoProducto
            // 
            this.Grid_TipoProducto.AllowUserToDeleteRows = false;
            this.Grid_TipoProducto.AllowUserToResizeColumns = false;
            this.Grid_TipoProducto.AllowUserToResizeRows = false;
            this.Grid_TipoProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_TipoProducto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nombre,
            this.Apellido});
            this.Grid_TipoProducto.Location = new System.Drawing.Point(11, 88);
            this.Grid_TipoProducto.Name = "Grid_TipoProducto";
            this.Grid_TipoProducto.ReadOnly = true;
            this.Grid_TipoProducto.Size = new System.Drawing.Size(533, 237);
            this.Grid_TipoProducto.StandardTab = true;
            this.Grid_TipoProducto.TabIndex = 31;
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
            this.Apellido.HeaderText = "Descripcion";
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            this.Apellido.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Apellido.Width = 300;
            // 
            // txt_NombreTipoPlanta
            // 
            this.txt_NombreTipoPlanta.Location = new System.Drawing.Point(92, 39);
            this.txt_NombreTipoPlanta.Name = "txt_NombreTipoPlanta";
            this.txt_NombreTipoPlanta.Size = new System.Drawing.Size(100, 20);
            this.txt_NombreTipoPlanta.TabIndex = 33;
            // 
            // chk_TipoProductoInactivos
            // 
            this.chk_TipoProductoInactivos.AutoSize = true;
            this.chk_TipoProductoInactivos.BackColor = System.Drawing.Color.Transparent;
            this.chk_TipoProductoInactivos.Location = new System.Drawing.Point(149, 65);
            this.chk_TipoProductoInactivos.Name = "chk_TipoProductoInactivos";
            this.chk_TipoProductoInactivos.Size = new System.Drawing.Size(69, 17);
            this.chk_TipoProductoInactivos.TabIndex = 35;
            this.chk_TipoProductoInactivos.Text = "Inactivas";
            this.chk_TipoProductoInactivos.UseVisualStyleBackColor = false;
            // 
            // chk_TipoProductosActivos
            // 
            this.chk_TipoProductosActivos.AutoSize = true;
            this.chk_TipoProductosActivos.BackColor = System.Drawing.Color.Transparent;
            this.chk_TipoProductosActivos.Location = new System.Drawing.Point(92, 65);
            this.chk_TipoProductosActivos.Name = "chk_TipoProductosActivos";
            this.chk_TipoProductosActivos.Size = new System.Drawing.Size(61, 17);
            this.chk_TipoProductosActivos.TabIndex = 34;
            this.chk_TipoProductosActivos.Text = "Activas";
            this.chk_TipoProductosActivos.UseVisualStyleBackColor = false;
            // 
            // btn_ConsultarTipoPlanta
            // 
            this.btn_ConsultarTipoPlanta.Location = new System.Drawing.Point(198, 39);
            this.btn_ConsultarTipoPlanta.Name = "btn_ConsultarTipoPlanta";
            this.btn_ConsultarTipoPlanta.Size = new System.Drawing.Size(75, 23);
            this.btn_ConsultarTipoPlanta.TabIndex = 36;
            this.btn_ConsultarTipoPlanta.Text = "Consultar";
            this.btn_ConsultarTipoPlanta.UseVisualStyleBackColor = true;
            this.btn_ConsultarTipoPlanta.Click += new System.EventHandler(this.btn_ConsultarTipoPlanta_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(60, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(34, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Nombre";
            // 
            // txt_IdTipoPlanta
            // 
            this.txt_IdTipoPlanta.Location = new System.Drawing.Point(92, 12);
            this.txt_IdTipoPlanta.Name = "txt_IdTipoPlanta";
            this.txt_IdTipoPlanta.Pp_mensajeError = null;
            this.txt_IdTipoPlanta.Pp_nombre_campo = null;
            this.txt_IdTipoPlanta.Pp_nombre_tabla = null;
            this.txt_IdTipoPlanta.Pp_validable = false;
            this.txt_IdTipoPlanta.Size = new System.Drawing.Size(100, 20);
            this.txt_IdTipoPlanta.TabIndex = 32;
            // 
            // ABM_TipoProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(557, 406);
            this.Controls.Add(this.btn_ModificarTipoProducto);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_EliminarTipoPlanta);
            this.Controls.Add(this.btn_AgregarTipoPlanta);
            this.Controls.Add(this.Grid_TipoProducto);
            this.Controls.Add(this.txt_NombreTipoPlanta);
            this.Controls.Add(this.chk_TipoProductoInactivos);
            this.Controls.Add(this.chk_TipoProductosActivos);
            this.Controls.Add(this.txt_IdTipoPlanta);
            this.Controls.Add(this.btn_ConsultarTipoPlanta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ABM_TipoProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ABM_TipoProducto";
            ((System.ComponentModel.ISupportInitialize)(this.btn_ModificarTipoProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Cancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_EliminarTipoPlanta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_AgregarTipoPlanta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_TipoProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btn_ModificarTipoProducto;
        private System.Windows.Forms.PictureBox btn_Cancelar;
        private System.Windows.Forms.PictureBox btn_EliminarTipoPlanta;
        private System.Windows.Forms.PictureBox btn_AgregarTipoPlanta;
        private System.Windows.Forms.DataGridView Grid_TipoProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.TextBox txt_NombreTipoPlanta;
        private System.Windows.Forms.CheckBox chk_TipoProductoInactivos;
        private System.Windows.Forms.CheckBox chk_TipoProductosActivos;
        private Clases.TextBox01 txt_IdTipoPlanta;
        private System.Windows.Forms.Button btn_ConsultarTipoPlanta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}