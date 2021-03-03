namespace PAV1_TP.Formularios.Cargas
{
    partial class Frm_DetalleFactura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_DetalleFactura));
            this.label1 = new System.Windows.Forms.Label();
            this.grid_DetalleFactura = new PAV1_TP.Clases.Grid01();
            this.Id_Planta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grid_DetalleFactura)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(128, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Detalle Factura";
            // 
            // grid_DetalleFactura
            // 
            this.grid_DetalleFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_DetalleFactura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Planta,
            this.Id_Producto,
            this.Cantidad,
            this.Precio});
            this.grid_DetalleFactura.Location = new System.Drawing.Point(12, 48);
            this.grid_DetalleFactura.Name = "grid_DetalleFactura";
            this.grid_DetalleFactura.Size = new System.Drawing.Size(434, 262);
            this.grid_DetalleFactura.TabIndex = 0;
            this.grid_DetalleFactura.tabla = null;
            // 
            // Id_Planta
            // 
            this.Id_Planta.HeaderText = "Id_Planta";
            this.Id_Planta.Name = "Id_Planta";
            // 
            // Id_Producto
            // 
            this.Id_Producto.HeaderText = "Id_Producto";
            this.Id_Producto.Name = "Id_Producto";
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            // 
            // Frm_DetalleFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(458, 324);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grid_DetalleFactura);
            this.Name = "Frm_DetalleFactura";
            this.Text = "Frm_DetalleFactura";
            this.Load += new System.EventHandler(this.Frm_DetalleFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_DetalleFactura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Clases.Grid01 grid_DetalleFactura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Planta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
    }
}