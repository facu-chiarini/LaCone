namespace PAV1_TP.Formularios.Proveedor
{
    partial class ABM_Proveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ABM_Proveedor));
            this.btn_AgregarProveedor = new System.Windows.Forms.PictureBox();
            this.btn_ModifProveedor = new System.Windows.Forms.PictureBox();
            this.btn_CancelarProveedor = new System.Windows.Forms.PictureBox();
            this.btn_EliminarProveedor = new System.Windows.Forms.PictureBox();
            this.btn_ConsultarProveedor = new System.Windows.Forms.Button();
            this.chk_ActivosProveedores = new System.Windows.Forms.CheckBox();
            this.txt_RSProveedor = new System.Windows.Forms.TextBox();
            this.txt_NombreProveedor = new System.Windows.Forms.TextBox();
            this.txt_IdProveedor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chk_InactivosProveedor = new System.Windows.Forms.CheckBox();
            this.Grid_Proveedor = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Domicilio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.btn_AgregarProveedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_ModifProveedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_CancelarProveedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_EliminarProveedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Proveedor)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_AgregarProveedor
            // 
            this.btn_AgregarProveedor.BackColor = System.Drawing.Color.Transparent;
            this.btn_AgregarProveedor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_AgregarProveedor.BackgroundImage")));
            this.btn_AgregarProveedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_AgregarProveedor.Location = new System.Drawing.Point(3, 347);
            this.btn_AgregarProveedor.Name = "btn_AgregarProveedor";
            this.btn_AgregarProveedor.Size = new System.Drawing.Size(59, 50);
            this.btn_AgregarProveedor.TabIndex = 23;
            this.btn_AgregarProveedor.TabStop = false;
            this.btn_AgregarProveedor.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // btn_ModifProveedor
            // 
            this.btn_ModifProveedor.BackColor = System.Drawing.Color.Transparent;
            this.btn_ModifProveedor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_ModifProveedor.BackgroundImage")));
            this.btn_ModifProveedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ModifProveedor.Location = new System.Drawing.Point(70, 347);
            this.btn_ModifProveedor.Name = "btn_ModifProveedor";
            this.btn_ModifProveedor.Size = new System.Drawing.Size(59, 50);
            this.btn_ModifProveedor.TabIndex = 22;
            this.btn_ModifProveedor.TabStop = false;
            this.btn_ModifProveedor.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // btn_CancelarProveedor
            // 
            this.btn_CancelarProveedor.BackColor = System.Drawing.Color.Transparent;
            this.btn_CancelarProveedor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_CancelarProveedor.BackgroundImage")));
            this.btn_CancelarProveedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_CancelarProveedor.Location = new System.Drawing.Point(610, 348);
            this.btn_CancelarProveedor.Name = "btn_CancelarProveedor";
            this.btn_CancelarProveedor.Size = new System.Drawing.Size(59, 50);
            this.btn_CancelarProveedor.TabIndex = 21;
            this.btn_CancelarProveedor.TabStop = false;
            this.btn_CancelarProveedor.Click += new System.EventHandler(this.btn_CancelarProveedor_Click);
            // 
            // btn_EliminarProveedor
            // 
            this.btn_EliminarProveedor.BackColor = System.Drawing.Color.Transparent;
            this.btn_EliminarProveedor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_EliminarProveedor.BackgroundImage")));
            this.btn_EliminarProveedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_EliminarProveedor.Location = new System.Drawing.Point(144, 347);
            this.btn_EliminarProveedor.Name = "btn_EliminarProveedor";
            this.btn_EliminarProveedor.Size = new System.Drawing.Size(59, 50);
            this.btn_EliminarProveedor.TabIndex = 20;
            this.btn_EliminarProveedor.TabStop = false;
            this.btn_EliminarProveedor.Click += new System.EventHandler(this.btn_EliminarProveedor_Click);
            // 
            // btn_ConsultarProveedor
            // 
            this.btn_ConsultarProveedor.Location = new System.Drawing.Point(300, 67);
            this.btn_ConsultarProveedor.Name = "btn_ConsultarProveedor";
            this.btn_ConsultarProveedor.Size = new System.Drawing.Size(75, 23);
            this.btn_ConsultarProveedor.TabIndex = 6;
            this.btn_ConsultarProveedor.Text = "Consultar";
            this.btn_ConsultarProveedor.UseVisualStyleBackColor = true;
            this.btn_ConsultarProveedor.Click += new System.EventHandler(this.btn_ConsultarProveedor_Click);
            // 
            // chk_ActivosProveedores
            // 
            this.chk_ActivosProveedores.AutoSize = true;
            this.chk_ActivosProveedores.BackColor = System.Drawing.Color.Transparent;
            this.chk_ActivosProveedores.Location = new System.Drawing.Point(132, 93);
            this.chk_ActivosProveedores.Name = "chk_ActivosProveedores";
            this.chk_ActivosProveedores.Size = new System.Drawing.Size(61, 17);
            this.chk_ActivosProveedores.TabIndex = 4;
            this.chk_ActivosProveedores.Text = "Activos";
            this.chk_ActivosProveedores.UseVisualStyleBackColor = false;
            // 
            // txt_RSProveedor
            // 
            this.txt_RSProveedor.Location = new System.Drawing.Point(132, 67);
            this.txt_RSProveedor.Name = "txt_RSProveedor";
            this.txt_RSProveedor.Size = new System.Drawing.Size(162, 20);
            this.txt_RSProveedor.TabIndex = 3;
            // 
            // txt_NombreProveedor
            // 
            this.txt_NombreProveedor.Location = new System.Drawing.Point(132, 41);
            this.txt_NombreProveedor.Name = "txt_NombreProveedor";
            this.txt_NombreProveedor.Size = new System.Drawing.Size(162, 20);
            this.txt_NombreProveedor.TabIndex = 2;
            // 
            // txt_IdProveedor
            // 
            this.txt_IdProveedor.Location = new System.Drawing.Point(132, 11);
            this.txt_IdProveedor.Name = "txt_IdProveedor";
            this.txt_IdProveedor.Size = new System.Drawing.Size(56, 20);
            this.txt_IdProveedor.TabIndex = 1;
            this.txt_IdProveedor.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(51, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Razon social";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(51, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(51, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // chk_InactivosProveedor
            // 
            this.chk_InactivosProveedor.AutoSize = true;
            this.chk_InactivosProveedor.BackColor = System.Drawing.Color.Transparent;
            this.chk_InactivosProveedor.Location = new System.Drawing.Point(194, 93);
            this.chk_InactivosProveedor.Name = "chk_InactivosProveedor";
            this.chk_InactivosProveedor.Size = new System.Drawing.Size(69, 17);
            this.chk_InactivosProveedor.TabIndex = 5;
            this.chk_InactivosProveedor.Text = "Inactivos";
            this.chk_InactivosProveedor.UseVisualStyleBackColor = false;
            // 
            // Grid_Proveedor
            // 
            this.Grid_Proveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_Proveedor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn2,
            this.Domicilio,
            this.dataGridViewTextBoxColumn4});
            this.Grid_Proveedor.Location = new System.Drawing.Point(3, 116);
            this.Grid_Proveedor.MultiSelect = false;
            this.Grid_Proveedor.Name = "Grid_Proveedor";
            this.Grid_Proveedor.ReadOnly = true;
            this.Grid_Proveedor.Size = new System.Drawing.Size(666, 223);
            this.Grid_Proveedor.StandardTab = true;
            this.Grid_Proveedor.TabIndex = 0;
            this.Grid_Proveedor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_Proveedor_CellContentClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "ID";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 50;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Telefono";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 120;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Razon Social";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 250;
            // 
            // Domicilio
            // 
            this.Domicilio.HeaderText = "Calle";
            this.Domicilio.Name = "Domicilio";
            this.Domicilio.ReadOnly = true;
            this.Domicilio.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Altura";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // ABM_Proveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(676, 404);
            this.Controls.Add(this.Grid_Proveedor);
            this.Controls.Add(this.chk_InactivosProveedor);
            this.Controls.Add(this.btn_AgregarProveedor);
            this.Controls.Add(this.btn_ModifProveedor);
            this.Controls.Add(this.btn_CancelarProveedor);
            this.Controls.Add(this.btn_EliminarProveedor);
            this.Controls.Add(this.btn_ConsultarProveedor);
            this.Controls.Add(this.chk_ActivosProveedores);
            this.Controls.Add(this.txt_RSProveedor);
            this.Controls.Add(this.txt_NombreProveedor);
            this.Controls.Add(this.txt_IdProveedor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ABM_Proveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ABM_Proveedor";
            ((System.ComponentModel.ISupportInitialize)(this.btn_AgregarProveedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_ModifProveedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_CancelarProveedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_EliminarProveedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Proveedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btn_AgregarProveedor;
        private System.Windows.Forms.PictureBox btn_ModifProveedor;
        private System.Windows.Forms.PictureBox btn_CancelarProveedor;
        private System.Windows.Forms.PictureBox btn_EliminarProveedor;
        private System.Windows.Forms.Button btn_ConsultarProveedor;
        private System.Windows.Forms.CheckBox chk_ActivosProveedores;
        private System.Windows.Forms.TextBox txt_RSProveedor;
        private System.Windows.Forms.TextBox txt_NombreProveedor;
        private System.Windows.Forms.TextBox txt_IdProveedor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chk_InactivosProveedor;
        private System.Windows.Forms.DataGridView Grid_Proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Domicilio;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}