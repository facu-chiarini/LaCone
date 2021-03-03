namespace PAV1_TP.Formularios
{
    partial class Frm_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Login));
            this.btn_ingresar = new System.Windows.Forms.Button();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.txt_contraseña = new System.Windows.Forms.TextBox();
            this.lv_contraseña = new System.Windows.Forms.Label();
            this.lv_usuario = new System.Windows.Forms.Label();
            this.img_login = new System.Windows.Forms.PictureBox();
            this.panel_login = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.img_login)).BeginInit();
            this.panel_login.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_ingresar
            // 
            this.btn_ingresar.Location = new System.Drawing.Point(291, 69);
            this.btn_ingresar.Name = "btn_ingresar";
            this.btn_ingresar.Size = new System.Drawing.Size(75, 23);
            this.btn_ingresar.TabIndex = 3;
            this.btn_ingresar.Text = "Ingresar";
            this.btn_ingresar.UseVisualStyleBackColor = true;
            this.btn_ingresar.Click += new System.EventHandler(this.btn_ingresar_Click_1);
            // 
            // txt_usuario
            // 
            this.txt_usuario.Location = new System.Drawing.Point(185, 37);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(100, 20);
            this.txt_usuario.TabIndex = 1;
            // 
            // txt_contraseña
            // 
            this.txt_contraseña.Location = new System.Drawing.Point(185, 69);
            this.txt_contraseña.Name = "txt_contraseña";
            this.txt_contraseña.PasswordChar = '*';
            this.txt_contraseña.Size = new System.Drawing.Size(100, 20);
            this.txt_contraseña.TabIndex = 2;
            // 
            // lv_contraseña
            // 
            this.lv_contraseña.AutoSize = true;
            this.lv_contraseña.Location = new System.Drawing.Point(118, 72);
            this.lv_contraseña.Name = "lv_contraseña";
            this.lv_contraseña.Size = new System.Drawing.Size(61, 13);
            this.lv_contraseña.TabIndex = 0;
            this.lv_contraseña.Text = "Contraseña";
            // 
            // lv_usuario
            // 
            this.lv_usuario.AutoSize = true;
            this.lv_usuario.Location = new System.Drawing.Point(136, 44);
            this.lv_usuario.Name = "lv_usuario";
            this.lv_usuario.Size = new System.Drawing.Size(43, 13);
            this.lv_usuario.TabIndex = 0;
            this.lv_usuario.Text = "Usuario";
            // 
            // img_login
            // 
            this.img_login.BackColor = System.Drawing.SystemColors.Control;
            this.img_login.Image = ((System.Drawing.Image)(resources.GetObject("img_login.Image")));
            this.img_login.Location = new System.Drawing.Point(25, 28);
            this.img_login.Name = "img_login";
            this.img_login.Size = new System.Drawing.Size(84, 64);
            this.img_login.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_login.TabIndex = 6;
            this.img_login.TabStop = false;
            // 
            // panel_login
            // 
            this.panel_login.Controls.Add(this.img_login);
            this.panel_login.Controls.Add(this.btn_ingresar);
            this.panel_login.Controls.Add(this.txt_contraseña);
            this.panel_login.Controls.Add(this.lv_usuario);
            this.panel_login.Controls.Add(this.lv_contraseña);
            this.panel_login.Controls.Add(this.txt_usuario);
            this.panel_login.Location = new System.Drawing.Point(304, 266);
            this.panel_login.Name = "panel_login";
            this.panel_login.Size = new System.Drawing.Size(395, 138);
            this.panel_login.TabIndex = 7;
            this.panel_login.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Frm_Login
            // 
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(994, 567);
            this.Controls.Add(this.panel_login);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Login";
            this.Text = "Frm_Login";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.img_login)).EndInit();
            this.panel_login.ResumeLayout(false);
            this.panel_login.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_ingresar;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.TextBox txt_contraseña;
        private System.Windows.Forms.Label lv_contraseña;
        private System.Windows.Forms.Label lv_usuario;
        private System.Windows.Forms.PictureBox img_login;
        private System.Windows.Forms.Panel panel_login;
    }
}