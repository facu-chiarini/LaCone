namespace PAV1_TP.Formularios.Producto
{
    partial class ABM_Productos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ABM_Productos));
            this.btn_AgregarProducto = new System.Windows.Forms.PictureBox();
            this.btn_ModifProducto = new System.Windows.Forms.PictureBox();
            this.btn_CancelarProducto = new System.Windows.Forms.PictureBox();
            this.btn_EliminarProducto = new System.Windows.Forms.PictureBox();
            this.Grid_Producto = new System.Windows.Forms.DataGridView();
            this.Doc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_ConsultarProducto = new System.Windows.Forms.Button();
            this.chk_ActivosProducto = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_IdProducto = new PAV1_TP.Clases.TextBox01();
            this.txt_NombreProducto = new PAV1_TP.Clases.TextBox01();
            this.txt_TipoProducto = new PAV1_TP.Clases.TextBox01();
            this.chk_InacctivosProducto = new System.Windows.Forms.CheckBox();
            this.btn_TipoPlanta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.btn_AgregarProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_ModifProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_CancelarProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_EliminarProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Producto)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_AgregarProducto
            // 
            this.btn_AgregarProducto.BackColor = System.Drawing.Color.Transparent;
            this.btn_AgregarProducto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_AgregarProducto.BackgroundImage")));
            this.btn_AgregarProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_AgregarProducto.Location = new System.Drawing.Point(8, 342);
            this.btn_AgregarProducto.Name = "btn_AgregarProducto";
            this.btn_AgregarProducto.Size = new System.Drawing.Size(59, 50);
            this.btn_AgregarProducto.TabIndex = 36;
            this.btn_AgregarProducto.TabStop = false;
            this.btn_AgregarProducto.Click += new System.EventHandler(this.btn_AgregarProveedor_Click);
            // 
            // btn_ModifProducto
            // 
            this.btn_ModifProducto.BackColor = System.Drawing.Color.Transparent;
            this.btn_ModifProducto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_ModifProducto.BackgroundImage")));
            this.btn_ModifProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ModifProducto.Location = new System.Drawing.Point(75, 342);
            this.btn_ModifProducto.Name = "btn_ModifProducto";
            this.btn_ModifProducto.Size = new System.Drawing.Size(59, 50);
            this.btn_ModifProducto.TabIndex = 35;
            this.btn_ModifProducto.TabStop = false;
            this.btn_ModifProducto.Click += new System.EventHandler(this.btn_ModifProveedor_Click);
            // 
            // btn_CancelarProducto
            // 
            this.btn_CancelarProducto.BackColor = System.Drawing.Color.Transparent;
            this.btn_CancelarProducto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_CancelarProducto.BackgroundImage")));
            this.btn_CancelarProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_CancelarProducto.Location = new System.Drawing.Point(607, 342);
            this.btn_CancelarProducto.Name = "btn_CancelarProducto";
            this.btn_CancelarProducto.Size = new System.Drawing.Size(59, 50);
            this.btn_CancelarProducto.TabIndex = 34;
            this.btn_CancelarProducto.TabStop = false;
            this.btn_CancelarProducto.Click += new System.EventHandler(this.btn_CancelarProducto_Click);
            // 
            // btn_EliminarProducto
            // 
            this.btn_EliminarProducto.BackColor = System.Drawing.Color.Transparent;
            this.btn_EliminarProducto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_EliminarProducto.BackgroundImage")));
            this.btn_EliminarProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_EliminarProducto.Location = new System.Drawing.Point(149, 342);
            this.btn_EliminarProducto.Name = "btn_EliminarProducto";
            this.btn_EliminarProducto.Size = new System.Drawing.Size(59, 50);
            this.btn_EliminarProducto.TabIndex = 33;
            this.btn_EliminarProducto.TabStop = false;
            this.btn_EliminarProducto.Click += new System.EventHandler(this.btn_EliminarProducto_Click);
            // 
            // Grid_Producto
            // 
            this.Grid_Producto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_Producto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Doc,
            this.Nombre,
            this.Apellido,
            this.Tipo,
            this.Precio,
            this.Costo});
            this.Grid_Producto.Location = new System.Drawing.Point(8, 111);
            this.Grid_Producto.Name = "Grid_Producto";
            this.Grid_Producto.ReadOnly = true;
            this.Grid_Producto.Size = new System.Drawing.Size(658, 212);
            this.Grid_Producto.TabIndex = 32;
            // 
            // Doc
            // 
            this.Doc.HeaderText = "ID";
            this.Doc.Name = "Doc";
            this.Doc.ReadOnly = true;
            this.Doc.Width = 50;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 150;
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Tipo";
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            this.Apellido.Width = 120;
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Stock";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // Costo
            // 
            this.Costo.HeaderText = "Costo";
            this.Costo.Name = "Costo";
            this.Costo.ReadOnly = true;
            // 
            // btn_ConsultarProducto
            // 
            this.btn_ConsultarProducto.Location = new System.Drawing.Point(252, 62);
            this.btn_ConsultarProducto.Name = "btn_ConsultarProducto";
            this.btn_ConsultarProducto.Size = new System.Drawing.Size(75, 23);
            this.btn_ConsultarProducto.TabIndex = 31;
            this.btn_ConsultarProducto.Text = "Consultar";
            this.btn_ConsultarProducto.UseVisualStyleBackColor = true;
            this.btn_ConsultarProducto.Click += new System.EventHandler(this.btn_ConsultarProducto_Click);
            // 
            // chk_ActivosProducto
            // 
            this.chk_ActivosProducto.AutoSize = true;
            this.chk_ActivosProducto.BackColor = System.Drawing.Color.Transparent;
            this.chk_ActivosProducto.Location = new System.Drawing.Point(137, 88);
            this.chk_ActivosProducto.Name = "chk_ActivosProducto";
            this.chk_ActivosProducto.Size = new System.Drawing.Size(61, 17);
            this.chk_ActivosProducto.TabIndex = 30;
            this.chk_ActivosProducto.Text = "Activos";
            this.chk_ActivosProducto.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(56, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Tipo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(56, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(56, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "ID";
            // 
            // txt_IdProducto
            // 
            this.txt_IdProducto.Location = new System.Drawing.Point(137, 9);
            this.txt_IdProducto.Name = "txt_IdProducto";
            this.txt_IdProducto.Pp_mensajeError = null;
            this.txt_IdProducto.Pp_nombre_campo = null;
            this.txt_IdProducto.Pp_nombre_tabla = null;
            this.txt_IdProducto.Pp_validable = false;
            this.txt_IdProducto.Size = new System.Drawing.Size(71, 20);
            this.txt_IdProducto.TabIndex = 37;
            // 
            // txt_NombreProducto
            // 
            this.txt_NombreProducto.Location = new System.Drawing.Point(137, 36);
            this.txt_NombreProducto.Name = "txt_NombreProducto";
            this.txt_NombreProducto.Pp_mensajeError = null;
            this.txt_NombreProducto.Pp_nombre_campo = null;
            this.txt_NombreProducto.Pp_nombre_tabla = null;
            this.txt_NombreProducto.Pp_validable = false;
            this.txt_NombreProducto.Size = new System.Drawing.Size(100, 20);
            this.txt_NombreProducto.TabIndex = 38;
            // 
            // txt_TipoProducto
            // 
            this.txt_TipoProducto.Location = new System.Drawing.Point(137, 62);
            this.txt_TipoProducto.Name = "txt_TipoProducto";
            this.txt_TipoProducto.Pp_mensajeError = null;
            this.txt_TipoProducto.Pp_nombre_campo = null;
            this.txt_TipoProducto.Pp_nombre_tabla = null;
            this.txt_TipoProducto.Pp_validable = false;
            this.txt_TipoProducto.Size = new System.Drawing.Size(100, 20);
            this.txt_TipoProducto.TabIndex = 39;
            // 
            // chk_InacctivosProducto
            // 
            this.chk_InacctivosProducto.AutoSize = true;
            this.chk_InacctivosProducto.BackColor = System.Drawing.Color.Transparent;
            this.chk_InacctivosProducto.Location = new System.Drawing.Point(199, 88);
            this.chk_InacctivosProducto.Name = "chk_InacctivosProducto";
            this.chk_InacctivosProducto.Size = new System.Drawing.Size(69, 17);
            this.chk_InacctivosProducto.TabIndex = 40;
            this.chk_InacctivosProducto.Text = "Inactivos";
            this.chk_InacctivosProducto.UseVisualStyleBackColor = false;
            // 
            // btn_TipoPlanta
            // 
            this.btn_TipoPlanta.Location = new System.Drawing.Point(559, 82);
            this.btn_TipoPlanta.Name = "btn_TipoPlanta";
            this.btn_TipoPlanta.Size = new System.Drawing.Size(107, 23);
            this.btn_TipoPlanta.TabIndex = 41;
            this.btn_TipoPlanta.Text = "Tipos de productos";
            this.btn_TipoPlanta.UseVisualStyleBackColor = true;
            this.btn_TipoPlanta.Click += new System.EventHandler(this.btn_TipoPlanta_Click);
            // 
            // ABM_Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(671, 393);
            this.Controls.Add(this.btn_TipoPlanta);
            this.Controls.Add(this.chk_InacctivosProducto);
            this.Controls.Add(this.txt_TipoProducto);
            this.Controls.Add(this.txt_NombreProducto);
            this.Controls.Add(this.txt_IdProducto);
            this.Controls.Add(this.btn_AgregarProducto);
            this.Controls.Add(this.btn_ModifProducto);
            this.Controls.Add(this.btn_CancelarProducto);
            this.Controls.Add(this.btn_EliminarProducto);
            this.Controls.Add(this.Grid_Producto);
            this.Controls.Add(this.btn_ConsultarProducto);
            this.Controls.Add(this.chk_ActivosProducto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ABM_Productos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ABM_Productos";
            this.Load += new System.EventHandler(this.ABM_Productos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btn_AgregarProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_ModifProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_CancelarProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_EliminarProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Producto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btn_AgregarProducto;
        private System.Windows.Forms.PictureBox btn_ModifProducto;
        private System.Windows.Forms.PictureBox btn_CancelarProducto;
        private System.Windows.Forms.PictureBox btn_EliminarProducto;
        private System.Windows.Forms.DataGridView Grid_Producto;
        private System.Windows.Forms.Button btn_ConsultarProducto;
        private System.Windows.Forms.CheckBox chk_ActivosProducto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Doc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Costo;
        private Clases.TextBox01 txt_IdProducto;
        private Clases.TextBox01 txt_NombreProducto;
        private Clases.TextBox01 txt_TipoProducto;
        private System.Windows.Forms.CheckBox chk_InacctivosProducto;
        private System.Windows.Forms.Button btn_TipoPlanta;
    }
}