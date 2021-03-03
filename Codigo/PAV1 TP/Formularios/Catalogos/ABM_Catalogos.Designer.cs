namespace PAV1_TP.Formularios.Catalogos
{
    partial class ABM_Catalogos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ABM_Catalogos));
            this.btn_AgregarCatalogo = new System.Windows.Forms.PictureBox();
            this.btn_EditarCatalogo = new System.Windows.Forms.PictureBox();
            this.btn_SalirCatalogo = new System.Windows.Forms.PictureBox();
            this.btn_EliminarCatalogo = new System.Windows.Forms.PictureBox();
            this.Grid_Catalogos = new System.Windows.Forms.DataGridView();
            this.Doc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.chk_CatalogosActivos = new System.Windows.Forms.CheckBox();
            this.txt_IdCatalogoPlanta = new System.Windows.Forms.TextBox();
            this.txt_IdCatalogo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chk_CatalogosInactivos = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.btn_AgregarCatalogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_EditarCatalogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_SalirCatalogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_EliminarCatalogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Catalogos)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_AgregarCatalogo
            // 
            this.btn_AgregarCatalogo.BackColor = System.Drawing.Color.Transparent;
            this.btn_AgregarCatalogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_AgregarCatalogo.BackgroundImage")));
            this.btn_AgregarCatalogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_AgregarCatalogo.Location = new System.Drawing.Point(8, 311);
            this.btn_AgregarCatalogo.Name = "btn_AgregarCatalogo";
            this.btn_AgregarCatalogo.Size = new System.Drawing.Size(48, 41);
            this.btn_AgregarCatalogo.TabIndex = 23;
            this.btn_AgregarCatalogo.TabStop = false;
            this.btn_AgregarCatalogo.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // btn_EditarCatalogo
            // 
            this.btn_EditarCatalogo.BackColor = System.Drawing.Color.Transparent;
            this.btn_EditarCatalogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_EditarCatalogo.BackgroundImage")));
            this.btn_EditarCatalogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_EditarCatalogo.Location = new System.Drawing.Point(75, 311);
            this.btn_EditarCatalogo.Name = "btn_EditarCatalogo";
            this.btn_EditarCatalogo.Size = new System.Drawing.Size(48, 41);
            this.btn_EditarCatalogo.TabIndex = 22;
            this.btn_EditarCatalogo.TabStop = false;
            this.btn_EditarCatalogo.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // btn_SalirCatalogo
            // 
            this.btn_SalirCatalogo.BackColor = System.Drawing.Color.Transparent;
            this.btn_SalirCatalogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_SalirCatalogo.BackgroundImage")));
            this.btn_SalirCatalogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_SalirCatalogo.Location = new System.Drawing.Point(303, 311);
            this.btn_SalirCatalogo.Name = "btn_SalirCatalogo";
            this.btn_SalirCatalogo.Size = new System.Drawing.Size(48, 41);
            this.btn_SalirCatalogo.TabIndex = 21;
            this.btn_SalirCatalogo.TabStop = false;
            this.btn_SalirCatalogo.Click += new System.EventHandler(this.btn_SalirCatalogo_Click);
            // 
            // btn_EliminarCatalogo
            // 
            this.btn_EliminarCatalogo.BackColor = System.Drawing.Color.Transparent;
            this.btn_EliminarCatalogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_EliminarCatalogo.BackgroundImage")));
            this.btn_EliminarCatalogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_EliminarCatalogo.Location = new System.Drawing.Point(133, 311);
            this.btn_EliminarCatalogo.Name = "btn_EliminarCatalogo";
            this.btn_EliminarCatalogo.Size = new System.Drawing.Size(48, 41);
            this.btn_EliminarCatalogo.TabIndex = 20;
            this.btn_EliminarCatalogo.TabStop = false;
            this.btn_EliminarCatalogo.Click += new System.EventHandler(this.btn_EliminarCatalogo_Click);
            // 
            // Grid_Catalogos
            // 
            this.Grid_Catalogos.AllowUserToDeleteRows = false;
            this.Grid_Catalogos.AllowUserToResizeColumns = false;
            this.Grid_Catalogos.AllowUserToResizeRows = false;
            this.Grid_Catalogos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_Catalogos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Doc,
            this.Nombre,
            this.Apellido});
            this.Grid_Catalogos.Location = new System.Drawing.Point(11, 88);
            this.Grid_Catalogos.MultiSelect = false;
            this.Grid_Catalogos.Name = "Grid_Catalogos";
            this.Grid_Catalogos.ReadOnly = true;
            this.Grid_Catalogos.Size = new System.Drawing.Size(340, 212);
            this.Grid_Catalogos.StandardTab = true;
            this.Grid_Catalogos.TabIndex = 0;
            // 
            // Doc
            // 
            this.Doc.HeaderText = "ID Catalogo";
            this.Doc.Name = "Doc";
            this.Doc.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "ID Planta";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Puntos necesarios";
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(187, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Consultar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chk_CatalogosActivos
            // 
            this.chk_CatalogosActivos.AutoSize = true;
            this.chk_CatalogosActivos.BackColor = System.Drawing.Color.Transparent;
            this.chk_CatalogosActivos.Location = new System.Drawing.Point(93, 65);
            this.chk_CatalogosActivos.Name = "chk_CatalogosActivos";
            this.chk_CatalogosActivos.Size = new System.Drawing.Size(61, 17);
            this.chk_CatalogosActivos.TabIndex = 3;
            this.chk_CatalogosActivos.Text = "Activos";
            this.chk_CatalogosActivos.UseVisualStyleBackColor = false;
            // 
            // txt_IdCatalogoPlanta
            // 
            this.txt_IdCatalogoPlanta.Location = new System.Drawing.Point(93, 39);
            this.txt_IdCatalogoPlanta.Name = "txt_IdCatalogoPlanta";
            this.txt_IdCatalogoPlanta.Size = new System.Drawing.Size(88, 20);
            this.txt_IdCatalogoPlanta.TabIndex = 2;
            // 
            // txt_IdCatalogo
            // 
            this.txt_IdCatalogo.Location = new System.Drawing.Point(93, 9);
            this.txt_IdCatalogo.Name = "txt_IdCatalogo";
            this.txt_IdCatalogo.Size = new System.Drawing.Size(88, 20);
            this.txt_IdCatalogo.TabIndex = 1;
            this.txt_IdCatalogo.TextChanged += new System.EventHandler(this.txt_IdCatalogo_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID Planta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Catalogo";
            // 
            // chk_CatalogosInactivos
            // 
            this.chk_CatalogosInactivos.AutoSize = true;
            this.chk_CatalogosInactivos.BackColor = System.Drawing.Color.Transparent;
            this.chk_CatalogosInactivos.Location = new System.Drawing.Point(155, 65);
            this.chk_CatalogosInactivos.Name = "chk_CatalogosInactivos";
            this.chk_CatalogosInactivos.Size = new System.Drawing.Size(69, 17);
            this.chk_CatalogosInactivos.TabIndex = 4;
            this.chk_CatalogosInactivos.Text = "Inactivos";
            this.chk_CatalogosInactivos.UseVisualStyleBackColor = false;
            // 
            // ABM_Catalogos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(360, 359);
            this.Controls.Add(this.chk_CatalogosInactivos);
            this.Controls.Add(this.btn_AgregarCatalogo);
            this.Controls.Add(this.btn_EditarCatalogo);
            this.Controls.Add(this.btn_SalirCatalogo);
            this.Controls.Add(this.btn_EliminarCatalogo);
            this.Controls.Add(this.Grid_Catalogos);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chk_CatalogosActivos);
            this.Controls.Add(this.txt_IdCatalogoPlanta);
            this.Controls.Add(this.txt_IdCatalogo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ABM_Catalogos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ABM_Catalogos";
            this.Load += new System.EventHandler(this.ABM_Catalogos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btn_AgregarCatalogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_EditarCatalogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_SalirCatalogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_EliminarCatalogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Catalogos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btn_AgregarCatalogo;
        private System.Windows.Forms.PictureBox btn_EditarCatalogo;
        private System.Windows.Forms.PictureBox btn_SalirCatalogo;
        private System.Windows.Forms.PictureBox btn_EliminarCatalogo;
        private System.Windows.Forms.DataGridView Grid_Catalogos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox chk_CatalogosActivos;
        private System.Windows.Forms.TextBox txt_IdCatalogoPlanta;
        private System.Windows.Forms.TextBox txt_IdCatalogo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Doc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.CheckBox chk_CatalogosInactivos;
    }
}