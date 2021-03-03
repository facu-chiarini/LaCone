namespace PAV1_TP.Formularios.Plantas
{
    partial class Alta_Plantas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Alta_Plantas));
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_RegistrarPlanta = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_EstadoPlanta = new PAV1_TP.Clases.ComboBox01();
            this.cmb_TipoPlanta = new PAV1_TP.Clases.ComboBox01();
            this.txt_StockPlanta = new PAV1_TP.Clases.TextBox01();
            this.txt_PrecioPlanta = new PAV1_TP.Clases.TextBox01();
            this.txt_NomComPlanta = new PAV1_TP.Clases.TextBox01();
            this.txt_NCientPlanta = new PAV1_TP.Clases.TextBox01();
            this.txt_CodPlanta = new PAV1_TP.Clases.TextBox01();
            this.SuspendLayout();
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(495, 283);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(82, 23);
            this.btn_Cancelar.TabIndex = 22;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_RegistrarPlanta
            // 
            this.btn_RegistrarPlanta.Location = new System.Drawing.Point(414, 283);
            this.btn_RegistrarPlanta.Name = "btn_RegistrarPlanta";
            this.btn_RegistrarPlanta.Size = new System.Drawing.Size(75, 23);
            this.btn_RegistrarPlanta.TabIndex = 21;
            this.btn_RegistrarPlanta.Text = "Registrar";
            this.btn_RegistrarPlanta.UseVisualStyleBackColor = true;
            this.btn_RegistrarPlanta.Click += new System.EventHandler(this.btn_RegistrarPlanta_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(66, 130);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Nombre Científico";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(339, 183);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 16);
            this.label10.TabIndex = 15;
            this.label10.Text = "Stock";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(335, 130);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 16);
            this.label9.TabIndex = 16;
            this.label9.Text = "Precio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(347, 78);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Tipo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(66, 183);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 16);
            this.label8.TabIndex = 18;
            this.label8.Text = "Nombre Común";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(122, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Código";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 32);
            this.label1.TabIndex = 20;
            this.label1.Text = "Registrar planta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(122, 230);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 16);
            this.label5.TabIndex = 29;
            this.label5.Text = "Estado";
            // 
            // cmb_EstadoPlanta
            // 
            this.cmb_EstadoPlanta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_EstadoPlanta.FormattingEnabled = true;
            this.cmb_EstadoPlanta.Location = new System.Drawing.Point(195, 230);
            this.cmb_EstadoPlanta.Name = "cmb_EstadoPlanta";
            this.cmb_EstadoPlanta.Pp_Display = "Descripcion";
            this.cmb_EstadoPlanta.Pp_mensajeError = null;
            this.cmb_EstadoPlanta.Pp_nombre_campo = null;
            this.cmb_EstadoPlanta.Pp_nombre_tabla = null;
            this.cmb_EstadoPlanta.Pp_seleccionado = false;
            this.cmb_EstadoPlanta.Pp_Tabla = "Estado";
            this.cmb_EstadoPlanta.Pp_validable = false;
            this.cmb_EstadoPlanta.Pp_Value = "ID";
            this.cmb_EstadoPlanta.Size = new System.Drawing.Size(121, 21);
            this.cmb_EstadoPlanta.TabIndex = 31;
            // 
            // cmb_TipoPlanta
            // 
            this.cmb_TipoPlanta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_TipoPlanta.FormattingEnabled = true;
            this.cmb_TipoPlanta.Location = new System.Drawing.Point(394, 78);
            this.cmb_TipoPlanta.Name = "cmb_TipoPlanta";
            this.cmb_TipoPlanta.Pp_Display = "Nombre";
            this.cmb_TipoPlanta.Pp_mensajeError = null;
            this.cmb_TipoPlanta.Pp_nombre_campo = null;
            this.cmb_TipoPlanta.Pp_nombre_tabla = null;
            this.cmb_TipoPlanta.Pp_seleccionado = false;
            this.cmb_TipoPlanta.Pp_Tabla = "TipoPlanta";
            this.cmb_TipoPlanta.Pp_validable = false;
            this.cmb_TipoPlanta.Pp_Value = "ID";
            this.cmb_TipoPlanta.Size = new System.Drawing.Size(121, 21);
            this.cmb_TipoPlanta.TabIndex = 30;
            // 
            // txt_StockPlanta
            // 
            this.txt_StockPlanta.Location = new System.Drawing.Point(394, 179);
            this.txt_StockPlanta.Name = "txt_StockPlanta";
            this.txt_StockPlanta.Pp_mensajeError = "Falta cargar stock";
            this.txt_StockPlanta.Pp_nombre_campo = null;
            this.txt_StockPlanta.Pp_nombre_tabla = null;
            this.txt_StockPlanta.Pp_validable = true;
            this.txt_StockPlanta.Size = new System.Drawing.Size(117, 20);
            this.txt_StockPlanta.TabIndex = 28;
            // 
            // txt_PrecioPlanta
            // 
            this.txt_PrecioPlanta.Location = new System.Drawing.Point(394, 130);
            this.txt_PrecioPlanta.Name = "txt_PrecioPlanta";
            this.txt_PrecioPlanta.Pp_mensajeError = "Falta cargar precio";
            this.txt_PrecioPlanta.Pp_nombre_campo = null;
            this.txt_PrecioPlanta.Pp_nombre_tabla = null;
            this.txt_PrecioPlanta.Pp_validable = true;
            this.txt_PrecioPlanta.Size = new System.Drawing.Size(117, 20);
            this.txt_PrecioPlanta.TabIndex = 27;
            // 
            // txt_NomComPlanta
            // 
            this.txt_NomComPlanta.Location = new System.Drawing.Point(195, 184);
            this.txt_NomComPlanta.Name = "txt_NomComPlanta";
            this.txt_NomComPlanta.Pp_mensajeError = "Falta cargar nombre comun";
            this.txt_NomComPlanta.Pp_nombre_campo = "";
            this.txt_NomComPlanta.Pp_nombre_tabla = null;
            this.txt_NomComPlanta.Pp_validable = true;
            this.txt_NomComPlanta.Size = new System.Drawing.Size(116, 20);
            this.txt_NomComPlanta.TabIndex = 25;
            // 
            // txt_NCientPlanta
            // 
            this.txt_NCientPlanta.Location = new System.Drawing.Point(195, 129);
            this.txt_NCientPlanta.Name = "txt_NCientPlanta";
            this.txt_NCientPlanta.Pp_mensajeError = "Falta cargar nombre cientifico";
            this.txt_NCientPlanta.Pp_nombre_campo = null;
            this.txt_NCientPlanta.Pp_nombre_tabla = null;
            this.txt_NCientPlanta.Pp_validable = true;
            this.txt_NCientPlanta.Size = new System.Drawing.Size(116, 20);
            this.txt_NCientPlanta.TabIndex = 24;
            // 
            // txt_CodPlanta
            // 
            this.txt_CodPlanta.Enabled = false;
            this.txt_CodPlanta.Location = new System.Drawing.Point(195, 78);
            this.txt_CodPlanta.Name = "txt_CodPlanta";
            this.txt_CodPlanta.Pp_mensajeError = null;
            this.txt_CodPlanta.Pp_nombre_campo = null;
            this.txt_CodPlanta.Pp_nombre_tabla = null;
            this.txt_CodPlanta.Pp_validable = false;
            this.txt_CodPlanta.Size = new System.Drawing.Size(119, 20);
            this.txt_CodPlanta.TabIndex = 23;
            // 
            // Alta_Plantas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(592, 320);
            this.Controls.Add(this.cmb_EstadoPlanta);
            this.Controls.Add(this.cmb_TipoPlanta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_StockPlanta);
            this.Controls.Add(this.txt_PrecioPlanta);
            this.Controls.Add(this.txt_NomComPlanta);
            this.Controls.Add(this.txt_NCientPlanta);
            this.Controls.Add(this.txt_CodPlanta);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_RegistrarPlanta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Alta_Plantas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Alta_Plantas";
            this.Load += new System.EventHandler(this.Alta_Plantas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Clases.TextBox01 txt_StockPlanta;
        private Clases.TextBox01 txt_PrecioPlanta;
        private Clases.TextBox01 txt_NomComPlanta;
        private Clases.TextBox01 txt_NCientPlanta;
        private Clases.TextBox01 txt_CodPlanta;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_RegistrarPlanta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private Clases.ComboBox01 cmb_TipoPlanta;
        private Clases.ComboBox01 cmb_EstadoPlanta;
    }
}