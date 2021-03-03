namespace PAV1_TP.Formularios.Plantas.TipoPlanta
{
    partial class ABM_TipoPlanta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ABM_TipoPlanta));
            this.txt_NombreTipoProducto = new System.Windows.Forms.TextBox();
            this.chk_TipoPlantasInactivas = new System.Windows.Forms.CheckBox();
            this.chk_TipoPlantasActivas = new System.Windows.Forms.CheckBox();
            this.btn_ConsultarTipoProducto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Grid_TipoPlanta = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_ModificarTipoProducto = new System.Windows.Forms.PictureBox();
            this.btn_Cancelar = new System.Windows.Forms.PictureBox();
            this.btn_EliminarTipoProducto = new System.Windows.Forms.PictureBox();
            this.btn_AgregarTipoProducto = new System.Windows.Forms.PictureBox();
            this.txt_IdTipoProducto = new PAV1_TP.Clases.TextBox01();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_TipoPlanta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_ModificarTipoProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Cancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_EliminarTipoProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_AgregarTipoProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_NombreTipoProducto
            // 
            this.txt_NombreTipoProducto.Location = new System.Drawing.Point(93, 39);
            this.txt_NombreTipoProducto.Name = "txt_NombreTipoProducto";
            this.txt_NombreTipoProducto.Size = new System.Drawing.Size(100, 20);
            this.txt_NombreTipoProducto.TabIndex = 2;
            // 
            // chk_TipoPlantasInactivas
            // 
            this.chk_TipoPlantasInactivas.AutoSize = true;
            this.chk_TipoPlantasInactivas.BackColor = System.Drawing.Color.Transparent;
            this.chk_TipoPlantasInactivas.Location = new System.Drawing.Point(150, 65);
            this.chk_TipoPlantasInactivas.Name = "chk_TipoPlantasInactivas";
            this.chk_TipoPlantasInactivas.Size = new System.Drawing.Size(69, 17);
            this.chk_TipoPlantasInactivas.TabIndex = 4;
            this.chk_TipoPlantasInactivas.Text = "Inactivas";
            this.chk_TipoPlantasInactivas.UseVisualStyleBackColor = false;
            // 
            // chk_TipoPlantasActivas
            // 
            this.chk_TipoPlantasActivas.AutoSize = true;
            this.chk_TipoPlantasActivas.BackColor = System.Drawing.Color.Transparent;
            this.chk_TipoPlantasActivas.Location = new System.Drawing.Point(93, 65);
            this.chk_TipoPlantasActivas.Name = "chk_TipoPlantasActivas";
            this.chk_TipoPlantasActivas.Size = new System.Drawing.Size(61, 17);
            this.chk_TipoPlantasActivas.TabIndex = 3;
            this.chk_TipoPlantasActivas.Text = "Activas";
            this.chk_TipoPlantasActivas.UseVisualStyleBackColor = false;
            // 
            // btn_ConsultarTipoProducto
            // 
            this.btn_ConsultarTipoProducto.Location = new System.Drawing.Point(199, 39);
            this.btn_ConsultarTipoProducto.Name = "btn_ConsultarTipoProducto";
            this.btn_ConsultarTipoProducto.Size = new System.Drawing.Size(75, 23);
            this.btn_ConsultarTipoProducto.TabIndex = 5;
            this.btn_ConsultarTipoProducto.Text = "Consultar";
            this.btn_ConsultarTipoProducto.UseVisualStyleBackColor = true;
            this.btn_ConsultarTipoProducto.Click += new System.EventHandler(this.btn_ConsultarTipoPlanta_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(61, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(35, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Nombre";
            // 
            // Grid_TipoPlanta
            // 
            this.Grid_TipoPlanta.AllowUserToDeleteRows = false;
            this.Grid_TipoPlanta.AllowUserToResizeColumns = false;
            this.Grid_TipoPlanta.AllowUserToResizeRows = false;
            this.Grid_TipoPlanta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_TipoPlanta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nombre,
            this.Apellido});
            this.Grid_TipoPlanta.Location = new System.Drawing.Point(12, 88);
            this.Grid_TipoPlanta.Name = "Grid_TipoPlanta";
            this.Grid_TipoPlanta.ReadOnly = true;
            this.Grid_TipoPlanta.Size = new System.Drawing.Size(533, 237);
            this.Grid_TipoPlanta.StandardTab = true;
            this.Grid_TipoPlanta.TabIndex = 0;
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
            // btn_ModificarTipoProducto
            // 
            this.btn_ModificarTipoProducto.BackColor = System.Drawing.Color.Transparent;
            this.btn_ModificarTipoProducto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_ModificarTipoProducto.BackgroundImage")));
            this.btn_ModificarTipoProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ModificarTipoProducto.Location = new System.Drawing.Point(75, 348);
            this.btn_ModificarTipoProducto.Name = "btn_ModificarTipoProducto";
            this.btn_ModificarTipoProducto.Size = new System.Drawing.Size(59, 50);
            this.btn_ModificarTipoProducto.TabIndex = 30;
            this.btn_ModificarTipoProducto.TabStop = false;
            this.btn_ModificarTipoProducto.Click += new System.EventHandler(this.btn_ModificarTipoPlanta_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.BackColor = System.Drawing.Color.Transparent;
            this.btn_Cancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Cancelar.BackgroundImage")));
            this.btn_Cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Cancelar.Location = new System.Drawing.Point(486, 348);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(59, 50);
            this.btn_Cancelar.TabIndex = 29;
            this.btn_Cancelar.TabStop = false;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_EliminarTipoProducto
            // 
            this.btn_EliminarTipoProducto.BackColor = System.Drawing.Color.Transparent;
            this.btn_EliminarTipoProducto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_EliminarTipoProducto.BackgroundImage")));
            this.btn_EliminarTipoProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_EliminarTipoProducto.Location = new System.Drawing.Point(140, 348);
            this.btn_EliminarTipoProducto.Name = "btn_EliminarTipoProducto";
            this.btn_EliminarTipoProducto.Size = new System.Drawing.Size(59, 50);
            this.btn_EliminarTipoProducto.TabIndex = 28;
            this.btn_EliminarTipoProducto.TabStop = false;
            this.btn_EliminarTipoProducto.Click += new System.EventHandler(this.btn_EliminarTipoPlanta_Click);
            // 
            // btn_AgregarTipoProducto
            // 
            this.btn_AgregarTipoProducto.Image = ((System.Drawing.Image)(resources.GetObject("btn_AgregarTipoProducto.Image")));
            this.btn_AgregarTipoProducto.Location = new System.Drawing.Point(11, 348);
            this.btn_AgregarTipoProducto.Margin = new System.Windows.Forms.Padding(2);
            this.btn_AgregarTipoProducto.Name = "btn_AgregarTipoProducto";
            this.btn_AgregarTipoProducto.Size = new System.Drawing.Size(59, 50);
            this.btn_AgregarTipoProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_AgregarTipoProducto.TabIndex = 27;
            this.btn_AgregarTipoProducto.TabStop = false;
            this.btn_AgregarTipoProducto.Click += new System.EventHandler(this.btn_AgregarTipoPlanta_Click);
            // 
            // txt_IdTipoProducto
            // 
            this.txt_IdTipoProducto.Location = new System.Drawing.Point(93, 12);
            this.txt_IdTipoProducto.Name = "txt_IdTipoProducto";
            this.txt_IdTipoProducto.Pp_mensajeError = null;
            this.txt_IdTipoProducto.Pp_nombre_campo = null;
            this.txt_IdTipoProducto.Pp_nombre_tabla = null;
            this.txt_IdTipoProducto.Pp_validable = false;
            this.txt_IdTipoProducto.Size = new System.Drawing.Size(100, 20);
            this.txt_IdTipoProducto.TabIndex = 1;
            // 
            // ABM_TipoPlanta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(559, 408);
            this.Controls.Add(this.btn_ModificarTipoProducto);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_EliminarTipoProducto);
            this.Controls.Add(this.btn_AgregarTipoProducto);
            this.Controls.Add(this.Grid_TipoPlanta);
            this.Controls.Add(this.txt_NombreTipoProducto);
            this.Controls.Add(this.chk_TipoPlantasInactivas);
            this.Controls.Add(this.chk_TipoPlantasActivas);
            this.Controls.Add(this.txt_IdTipoProducto);
            this.Controls.Add(this.btn_ConsultarTipoProducto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ABM_TipoPlanta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ABM_TipoPlanta";
            ((System.ComponentModel.ISupportInitialize)(this.Grid_TipoPlanta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_ModificarTipoProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Cancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_EliminarTipoProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_AgregarTipoProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_NombreTipoProducto;
        private System.Windows.Forms.CheckBox chk_TipoPlantasInactivas;
        private System.Windows.Forms.CheckBox chk_TipoPlantasActivas;
        private Clases.TextBox01 txt_IdTipoProducto;
        private System.Windows.Forms.Button btn_ConsultarTipoProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView Grid_TipoPlanta;
        private System.Windows.Forms.PictureBox btn_ModificarTipoProducto;
        private System.Windows.Forms.PictureBox btn_Cancelar;
        private System.Windows.Forms.PictureBox btn_EliminarTipoProducto;
        private System.Windows.Forms.PictureBox btn_AgregarTipoProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
    }
}