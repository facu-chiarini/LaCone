namespace PAV1_TP.Formularios.Plantas
{
    partial class ABM_Plantas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ABM_Plantas));
            this.chk_PlantasInactivas = new System.Windows.Forms.CheckBox();
            this.chk_PlantasActivas = new System.Windows.Forms.CheckBox();
            this.txt_CodPlanta = new PAV1_TP.Clases.TextBox01();
            this.btn_ModificarPlanta = new System.Windows.Forms.PictureBox();
            this.btn_Cancelar = new System.Windows.Forms.PictureBox();
            this.btn_EliminarPlanta = new System.Windows.Forms.PictureBox();
            this.btn_ConsultarPlanta = new System.Windows.Forms.Button();
            this.Grid_Planta = new System.Windows.Forms.DataGridView();
            this.Código = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columna2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_AgregarPlanta = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_NComun = new System.Windows.Forms.TextBox();
            this.btn_TipoPlanta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.btn_ModificarPlanta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Cancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_EliminarPlanta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Planta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_AgregarPlanta)).BeginInit();
            this.SuspendLayout();
            // 
            // chk_PlantasInactivas
            // 
            this.chk_PlantasInactivas.AutoSize = true;
            this.chk_PlantasInactivas.BackColor = System.Drawing.Color.Transparent;
            this.chk_PlantasInactivas.Location = new System.Drawing.Point(183, 59);
            this.chk_PlantasInactivas.Name = "chk_PlantasInactivas";
            this.chk_PlantasInactivas.Size = new System.Drawing.Size(69, 17);
            this.chk_PlantasInactivas.TabIndex = 4;
            this.chk_PlantasInactivas.Text = "Inactivas";
            this.chk_PlantasInactivas.UseVisualStyleBackColor = false;
            // 
            // chk_PlantasActivas
            // 
            this.chk_PlantasActivas.AutoSize = true;
            this.chk_PlantasActivas.BackColor = System.Drawing.Color.Transparent;
            this.chk_PlantasActivas.Location = new System.Drawing.Point(126, 59);
            this.chk_PlantasActivas.Name = "chk_PlantasActivas";
            this.chk_PlantasActivas.Size = new System.Drawing.Size(61, 17);
            this.chk_PlantasActivas.TabIndex = 3;
            this.chk_PlantasActivas.Text = "Activas";
            this.chk_PlantasActivas.UseVisualStyleBackColor = false;
            // 
            // txt_CodPlanta
            // 
            this.txt_CodPlanta.Location = new System.Drawing.Point(126, 7);
            this.txt_CodPlanta.Name = "txt_CodPlanta";
            this.txt_CodPlanta.Pp_mensajeError = null;
            this.txt_CodPlanta.Pp_nombre_campo = null;
            this.txt_CodPlanta.Pp_nombre_tabla = null;
            this.txt_CodPlanta.Pp_validable = false;
            this.txt_CodPlanta.Size = new System.Drawing.Size(100, 20);
            this.txt_CodPlanta.TabIndex = 1;
            // 
            // btn_ModificarPlanta
            // 
            this.btn_ModificarPlanta.BackColor = System.Drawing.Color.Transparent;
            this.btn_ModificarPlanta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_ModificarPlanta.BackgroundImage")));
            this.btn_ModificarPlanta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ModificarPlanta.Location = new System.Drawing.Point(70, 312);
            this.btn_ModificarPlanta.Name = "btn_ModificarPlanta";
            this.btn_ModificarPlanta.Size = new System.Drawing.Size(59, 50);
            this.btn_ModificarPlanta.TabIndex = 25;
            this.btn_ModificarPlanta.TabStop = false;
            this.btn_ModificarPlanta.Click += new System.EventHandler(this.btn_ModificarPlanta_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.BackColor = System.Drawing.Color.Transparent;
            this.btn_Cancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Cancelar.BackgroundImage")));
            this.btn_Cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Cancelar.Location = new System.Drawing.Point(544, 312);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(59, 50);
            this.btn_Cancelar.TabIndex = 24;
            this.btn_Cancelar.TabStop = false;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_EliminarPlanta
            // 
            this.btn_EliminarPlanta.BackColor = System.Drawing.Color.Transparent;
            this.btn_EliminarPlanta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_EliminarPlanta.BackgroundImage")));
            this.btn_EliminarPlanta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_EliminarPlanta.Location = new System.Drawing.Point(135, 312);
            this.btn_EliminarPlanta.Name = "btn_EliminarPlanta";
            this.btn_EliminarPlanta.Size = new System.Drawing.Size(59, 50);
            this.btn_EliminarPlanta.TabIndex = 23;
            this.btn_EliminarPlanta.TabStop = false;
            this.btn_EliminarPlanta.Click += new System.EventHandler(this.btn_EliminarPlanta_Click);
            // 
            // btn_ConsultarPlanta
            // 
            this.btn_ConsultarPlanta.Location = new System.Drawing.Point(232, 33);
            this.btn_ConsultarPlanta.Name = "btn_ConsultarPlanta";
            this.btn_ConsultarPlanta.Size = new System.Drawing.Size(75, 23);
            this.btn_ConsultarPlanta.TabIndex = 5;
            this.btn_ConsultarPlanta.Text = "Consultar";
            this.btn_ConsultarPlanta.UseVisualStyleBackColor = true;
            this.btn_ConsultarPlanta.Click += new System.EventHandler(this.btn_ConsultarPlanta_Click);
            // 
            // Grid_Planta
            // 
            this.Grid_Planta.AllowUserToDeleteRows = false;
            this.Grid_Planta.AllowUserToResizeColumns = false;
            this.Grid_Planta.AllowUserToResizeRows = false;
            this.Grid_Planta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_Planta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Código,
            this.Columna2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.Grid_Planta.Location = new System.Drawing.Point(10, 87);
            this.Grid_Planta.Margin = new System.Windows.Forms.Padding(2);
            this.Grid_Planta.Name = "Grid_Planta";
            this.Grid_Planta.ReadOnly = true;
            this.Grid_Planta.RowHeadersWidth = 51;
            this.Grid_Planta.RowTemplate.Height = 24;
            this.Grid_Planta.Size = new System.Drawing.Size(593, 206);
            this.Grid_Planta.StandardTab = true;
            this.Grid_Planta.TabIndex = 0;
            // 
            // Código
            // 
            this.Código.HeaderText = "Código";
            this.Código.MinimumWidth = 6;
            this.Código.Name = "Código";
            this.Código.ReadOnly = true;
            this.Código.Width = 50;
            // 
            // Columna2
            // 
            this.Columna2.HeaderText = "Nombre Científico";
            this.Columna2.MinimumWidth = 6;
            this.Columna2.Name = "Columna2";
            this.Columna2.ReadOnly = true;
            this.Columna2.Width = 160;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Nombre Común";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Tipo";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Precio";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Stock";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 125;
            // 
            // btn_AgregarPlanta
            // 
            this.btn_AgregarPlanta.Image = ((System.Drawing.Image)(resources.GetObject("btn_AgregarPlanta.Image")));
            this.btn_AgregarPlanta.Location = new System.Drawing.Point(6, 312);
            this.btn_AgregarPlanta.Margin = new System.Windows.Forms.Padding(2);
            this.btn_AgregarPlanta.Name = "btn_AgregarPlanta";
            this.btn_AgregarPlanta.Size = new System.Drawing.Size(59, 50);
            this.btn_AgregarPlanta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_AgregarPlanta.TabIndex = 21;
            this.btn_AgregarPlanta.TabStop = false;
            this.btn_AgregarPlanta.Click += new System.EventHandler(this.btn_AgregarPlanta_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(84, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(43, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Nombre común";
            // 
            // txt_NComun
            // 
            this.txt_NComun.Location = new System.Drawing.Point(126, 33);
            this.txt_NComun.Name = "txt_NComun";
            this.txt_NComun.Size = new System.Drawing.Size(100, 20);
            this.txt_NComun.TabIndex = 2;
            // 
            // btn_TipoPlanta
            // 
            this.btn_TipoPlanta.Location = new System.Drawing.Point(494, 59);
            this.btn_TipoPlanta.Name = "btn_TipoPlanta";
            this.btn_TipoPlanta.Size = new System.Drawing.Size(97, 23);
            this.btn_TipoPlanta.TabIndex = 26;
            this.btn_TipoPlanta.Text = "Tipos de plantas";
            this.btn_TipoPlanta.UseVisualStyleBackColor = true;
            this.btn_TipoPlanta.Click += new System.EventHandler(this.btn_TipoPlanta_Click);
            // 
            // ABM_Plantas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(617, 369);
            this.Controls.Add(this.btn_TipoPlanta);
            this.Controls.Add(this.txt_NComun);
            this.Controls.Add(this.chk_PlantasInactivas);
            this.Controls.Add(this.chk_PlantasActivas);
            this.Controls.Add(this.txt_CodPlanta);
            this.Controls.Add(this.btn_ModificarPlanta);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_EliminarPlanta);
            this.Controls.Add(this.btn_ConsultarPlanta);
            this.Controls.Add(this.Grid_Planta);
            this.Controls.Add(this.btn_AgregarPlanta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ABM_Plantas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ABM_Plantas";
            this.Load += new System.EventHandler(this.ABM_Plantas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btn_ModificarPlanta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Cancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_EliminarPlanta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Planta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_AgregarPlanta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chk_PlantasInactivas;
        private System.Windows.Forms.CheckBox chk_PlantasActivas;
        private Clases.TextBox01 txt_CodPlanta;
        private System.Windows.Forms.PictureBox btn_ModificarPlanta;
        private System.Windows.Forms.PictureBox btn_Cancelar;
        private System.Windows.Forms.PictureBox btn_EliminarPlanta;
        private System.Windows.Forms.Button btn_ConsultarPlanta;
        private System.Windows.Forms.DataGridView Grid_Planta;
        private System.Windows.Forms.PictureBox btn_AgregarPlanta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_NComun;
        private System.Windows.Forms.DataGridViewTextBoxColumn Código;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columna2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Button btn_TipoPlanta;
    }
}