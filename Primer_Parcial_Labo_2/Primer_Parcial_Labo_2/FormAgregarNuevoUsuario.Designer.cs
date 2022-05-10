namespace Primer_Parcial_Labo_2
{
    partial class FormAgregarNuevoUsuario
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
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.lbl_dni = new System.Windows.Forms.Label();
            this.lbl_apellido = new System.Windows.Forms.Label();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.txt_dni = new System.Windows.Forms.TextBox();
            this.chk_esAdmin = new System.Windows.Forms.CheckBox();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.lbl_error = new System.Windows.Forms.Label();
            this.lbl_nombreUser = new System.Windows.Forms.Label();
            this.txt_userLogin = new System.Windows.Forms.TextBox();
            this.txt_passwd = new System.Windows.Forms.TextBox();
            this.lbl_passwd = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_titulo.Location = new System.Drawing.Point(12, 9);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(205, 25);
            this.lbl_titulo.TabIndex = 7;
            this.lbl_titulo.Text = "Agregar nuevo usuario";
            // 
            // txt_apellido
            // 
            this.txt_apellido.Location = new System.Drawing.Point(171, 91);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(157, 23);
            this.txt_apellido.TabIndex = 12;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(171, 53);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(157, 23);
            this.txt_nombre.TabIndex = 11;
            // 
            // lbl_dni
            // 
            this.lbl_dni.AutoSize = true;
            this.lbl_dni.Location = new System.Drawing.Point(52, 130);
            this.lbl_dni.Name = "lbl_dni";
            this.lbl_dni.Size = new System.Drawing.Size(30, 15);
            this.lbl_dni.TabIndex = 10;
            this.lbl_dni.Text = "DNI:";
            // 
            // lbl_apellido
            // 
            this.lbl_apellido.AutoSize = true;
            this.lbl_apellido.Location = new System.Drawing.Point(52, 93);
            this.lbl_apellido.Name = "lbl_apellido";
            this.lbl_apellido.Size = new System.Drawing.Size(54, 15);
            this.lbl_apellido.TabIndex = 9;
            this.lbl_apellido.Text = "Apellido:";
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(52, 56);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(54, 15);
            this.lbl_nombre.TabIndex = 8;
            this.lbl_nombre.Text = "Nombre:";
            // 
            // txt_dni
            // 
            this.txt_dni.Location = new System.Drawing.Point(171, 128);
            this.txt_dni.Name = "txt_dni";
            this.txt_dni.Size = new System.Drawing.Size(157, 23);
            this.txt_dni.TabIndex = 13;
            // 
            // chk_esAdmin
            // 
            this.chk_esAdmin.AutoSize = true;
            this.chk_esAdmin.Location = new System.Drawing.Point(105, 240);
            this.chk_esAdmin.Name = "chk_esAdmin";
            this.chk_esAdmin.Size = new System.Drawing.Size(224, 19);
            this.chk_esAdmin.TabIndex = 15;
            this.chk_esAdmin.Text = "¿El nuevo usuario será administrador?";
            this.chk_esAdmin.UseVisualStyleBackColor = true;
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Location = new System.Drawing.Point(27, 298);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(179, 41);
            this.btn_aceptar.TabIndex = 16;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(231, 298);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(179, 41);
            this.btn_cancelar.TabIndex = 17;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // lbl_error
            // 
            this.lbl_error.AutoSize = true;
            this.lbl_error.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_error.ForeColor = System.Drawing.Color.Red;
            this.lbl_error.Location = new System.Drawing.Point(93, 264);
            this.lbl_error.Name = "lbl_error";
            this.lbl_error.Size = new System.Drawing.Size(245, 21);
            this.lbl_error.TabIndex = 18;
            this.lbl_error.Text = "Por favor introduzca datos válidos";
            this.lbl_error.Visible = false;
            // 
            // lbl_nombreUser
            // 
            this.lbl_nombreUser.AutoSize = true;
            this.lbl_nombreUser.Location = new System.Drawing.Point(52, 167);
            this.lbl_nombreUser.Name = "lbl_nombreUser";
            this.lbl_nombreUser.Size = new System.Drawing.Size(96, 15);
            this.lbl_nombreUser.TabIndex = 19;
            this.lbl_nombreUser.Text = "Usuario de login:";
            // 
            // txt_userLogin
            // 
            this.txt_userLogin.Location = new System.Drawing.Point(171, 164);
            this.txt_userLogin.Name = "txt_userLogin";
            this.txt_userLogin.Size = new System.Drawing.Size(157, 23);
            this.txt_userLogin.TabIndex = 20;
            // 
            // txt_passwd
            // 
            this.txt_passwd.Location = new System.Drawing.Point(171, 202);
            this.txt_passwd.Name = "txt_passwd";
            this.txt_passwd.PasswordChar = '*';
            this.txt_passwd.Size = new System.Drawing.Size(157, 23);
            this.txt_passwd.TabIndex = 22;
            // 
            // lbl_passwd
            // 
            this.lbl_passwd.AutoSize = true;
            this.lbl_passwd.Location = new System.Drawing.Point(52, 205);
            this.lbl_passwd.Name = "lbl_passwd";
            this.lbl_passwd.Size = new System.Drawing.Size(70, 15);
            this.lbl_passwd.TabIndex = 21;
            this.lbl_passwd.Text = "Contraseña:";
            // 
            // FormAgregarNuevoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 364);
            this.Controls.Add(this.txt_passwd);
            this.Controls.Add(this.lbl_passwd);
            this.Controls.Add(this.txt_userLogin);
            this.Controls.Add(this.lbl_nombreUser);
            this.Controls.Add(this.lbl_error);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.chk_esAdmin);
            this.Controls.Add(this.txt_dni);
            this.Controls.Add(this.txt_apellido);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.lbl_dni);
            this.Controls.Add(this.lbl_apellido);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.lbl_titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAgregarNuevoUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormAgregarNuevoUsuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.TextBox txt_apellido;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label lbl_dni;
        private System.Windows.Forms.Label lbl_apellido;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.TextBox txt_dni;
        private System.Windows.Forms.CheckBox chk_esAdmin;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Label lbl_error;
        private System.Windows.Forms.Label lbl_nombreUser;
        private System.Windows.Forms.TextBox txt_userLogin;
        private System.Windows.Forms.TextBox txt_passwd;
        private System.Windows.Forms.Label lbl_passwd;
    }
}