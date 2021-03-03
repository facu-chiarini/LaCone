namespace PAV1_TP.Formularios.Canje
{
    partial class Frm_Canje
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Canje));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Grid_Canje = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Consultar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Registrar = new System.Windows.Forms.Button();
            this.btn_Fehca = new System.Windows.Forms.Button();
            this.txt_IdCatalogo = new PAV1_TP.Clases.TextBox01();
            this.txt_NroDoc = new PAV1_TP.Clases.TextBox01();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Fecha = new PAV1_TP.Clases.TextBox01();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Canje)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registrar Canje";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(7, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nro Doc";
            // 
            // Grid_Canje
            // 
            this.Grid_Canje.AllowUserToAddRows = false;
            this.Grid_Canje.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_Canje.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Nombre,
            this.Column2});
            this.Grid_Canje.Location = new System.Drawing.Point(227, 72);
            this.Grid_Canje.Name = "Grid_Canje";
            this.Grid_Canje.Size = new System.Drawing.Size(303, 144);
            this.Grid_Canje.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(224, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Id Catalogo";
            // 
            // btn_Consultar
            // 
            this.btn_Consultar.Location = new System.Drawing.Point(455, 45);
            this.btn_Consultar.Name = "btn_Consultar";
            this.btn_Consultar.Size = new System.Drawing.Size(75, 23);
            this.btn_Consultar.TabIndex = 14;
            this.btn_Consultar.Text = "Consultar";
            this.btn_Consultar.UseVisualStyleBackColor = true;
            this.btn_Consultar.Click += new System.EventHandler(this.btn_Consultar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(98, 193);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancelar.TabIndex = 15;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Registrar
            // 
            this.btn_Registrar.Location = new System.Drawing.Point(17, 193);
            this.btn_Registrar.Name = "btn_Registrar";
            this.btn_Registrar.Size = new System.Drawing.Size(75, 23);
            this.btn_Registrar.TabIndex = 16;
            this.btn_Registrar.Text = "Registrar";
            this.btn_Registrar.UseVisualStyleBackColor = true;
            this.btn_Registrar.Click += new System.EventHandler(this.btn_Registrar_Click);
            // 
            // btn_Fehca
            // 
            this.btn_Fehca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Fehca.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Fehca.Location = new System.Drawing.Point(179, 72);
            this.btn_Fehca.Name = "btn_Fehca";
            this.btn_Fehca.Size = new System.Drawing.Size(36, 23);
            this.btn_Fehca.TabIndex = 20;
            this.btn_Fehca.Text = "...";
            this.btn_Fehca.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Fehca.UseVisualStyleBackColor = true;
            this.btn_Fehca.Click += new System.EventHandler(this.btn_Fehca_Click);
            // 
            // txt_IdCatalogo
            // 
            this.txt_IdCatalogo.Location = new System.Drawing.Point(291, 47);
            this.txt_IdCatalogo.Name = "txt_IdCatalogo";
            this.txt_IdCatalogo.Pp_mensajeError = "No se ingreso Id Catalogo";
            this.txt_IdCatalogo.Pp_nombre_campo = null;
            this.txt_IdCatalogo.Pp_nombre_tabla = null;
            this.txt_IdCatalogo.Pp_validable = true;
            this.txt_IdCatalogo.Size = new System.Drawing.Size(102, 20);
            this.txt_IdCatalogo.TabIndex = 19;
            // 
            // txt_NroDoc
            // 
            this.txt_NroDoc.Location = new System.Drawing.Point(60, 42);
            this.txt_NroDoc.Name = "txt_NroDoc";
            this.txt_NroDoc.Pp_mensajeError = null;
            this.txt_NroDoc.Pp_nombre_campo = "No se ingreso Nro Doc";
            this.txt_NroDoc.Pp_nombre_tabla = null;
            this.txt_NroDoc.Pp_validable = true;
            this.txt_NroDoc.Size = new System.Drawing.Size(100, 20);
            this.txt_NroDoc.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(7, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Fecha";
            // 
            // txt_Fecha
            // 
            this.txt_Fecha.Enabled = false;
            this.txt_Fecha.Location = new System.Drawing.Point(60, 72);
            this.txt_Fecha.Name = "txt_Fecha";
            this.txt_Fecha.Pp_mensajeError = "No se ingreso la fecha";
            this.txt_Fecha.Pp_nombre_campo = null;
            this.txt_Fecha.Pp_nombre_tabla = null;
            this.txt_Fecha.Pp_validable = true;
            this.txt_Fecha.Size = new System.Drawing.Size(113, 20);
            this.txt_Fecha.TabIndex = 22;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id Planta";
            this.Column1.Name = "Column1";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Puntos necesarios";
            this.Column2.Name = "Column2";
            // 
            // Frm_Canje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(542, 228);
            this.Controls.Add(this.txt_Fecha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Fehca);
            this.Controls.Add(this.txt_IdCatalogo);
            this.Controls.Add(this.btn_Registrar);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Consultar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Grid_Canje);
            this.Controls.Add(this.txt_NroDoc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Frm_Canje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Frm_Canje";
            this.Load += new System.EventHandler(this.Frm_Canje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Canje)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private Clases.TextBox01 txt_NroDoc;
        private System.Windows.Forms.DataGridView Grid_Canje;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Consultar;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Registrar;
        private Clases.TextBox01 txt_IdCatalogo;
        private System.Windows.Forms.Button btn_Fehca;
        private System.Windows.Forms.Label label2;
        private Clases.TextBox01 txt_Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}