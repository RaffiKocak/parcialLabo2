namespace Primer_Parcial_Labo_2
{
    partial class FormNuevaComida
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
            this.lbl_descripcion = new System.Windows.Forms.Label();
            this.lbl_precioUnitario = new System.Windows.Forms.Label();
            this.lbl_tipo = new System.Windows.Forms.Label();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.txt_precioUnitario = new System.Windows.Forms.TextBox();
            this.cmb_tipoComida = new System.Windows.Forms.ComboBox();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.chk_esVegano = new System.Windows.Forms.CheckBox();
            this.lbl_error = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_descripcion
            // 
            this.lbl_descripcion.AutoSize = true;
            this.lbl_descripcion.Location = new System.Drawing.Point(49, 56);
            this.lbl_descripcion.Name = "lbl_descripcion";
            this.lbl_descripcion.Size = new System.Drawing.Size(72, 15);
            this.lbl_descripcion.TabIndex = 0;
            this.lbl_descripcion.Text = "Descripción:";
            // 
            // lbl_precioUnitario
            // 
            this.lbl_precioUnitario.AutoSize = true;
            this.lbl_precioUnitario.Location = new System.Drawing.Point(49, 93);
            this.lbl_precioUnitario.Name = "lbl_precioUnitario";
            this.lbl_precioUnitario.Size = new System.Drawing.Size(88, 15);
            this.lbl_precioUnitario.TabIndex = 1;
            this.lbl_precioUnitario.Text = "Precio Unitario:";
            // 
            // lbl_tipo
            // 
            this.lbl_tipo.AutoSize = true;
            this.lbl_tipo.Location = new System.Drawing.Point(49, 130);
            this.lbl_tipo.Name = "lbl_tipo";
            this.lbl_tipo.Size = new System.Drawing.Size(33, 15);
            this.lbl_tipo.TabIndex = 2;
            this.lbl_tipo.Text = "Tipo:";
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Location = new System.Drawing.Point(159, 52);
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(157, 23);
            this.txt_descripcion.TabIndex = 3;
            // 
            // txt_precioUnitario
            // 
            this.txt_precioUnitario.Location = new System.Drawing.Point(159, 90);
            this.txt_precioUnitario.Name = "txt_precioUnitario";
            this.txt_precioUnitario.Size = new System.Drawing.Size(157, 23);
            this.txt_precioUnitario.TabIndex = 4;
            // 
            // cmb_tipoComida
            // 
            this.cmb_tipoComida.FormattingEnabled = true;
            this.cmb_tipoComida.Location = new System.Drawing.Point(159, 127);
            this.cmb_tipoComida.Name = "cmb_tipoComida";
            this.cmb_tipoComida.Size = new System.Drawing.Size(157, 23);
            this.cmb_tipoComida.TabIndex = 5;
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_titulo.Location = new System.Drawing.Point(23, 9);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(203, 25);
            this.lbl_titulo.TabIndex = 6;
            this.lbl_titulo.Text = "Agregar nueva comida";
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(49, 209);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(122, 32);
            this.btn_agregar.TabIndex = 7;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(194, 209);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(122, 32);
            this.btn_cancelar.TabIndex = 8;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // chk_esVegano
            // 
            this.chk_esVegano.AutoSize = true;
            this.chk_esVegano.Location = new System.Drawing.Point(110, 174);
            this.chk_esVegano.Name = "chk_esVegano";
            this.chk_esVegano.Size = new System.Drawing.Size(145, 19);
            this.chk_esVegano.TabIndex = 9;
            this.chk_esVegano.Text = "Esta comida es vegana";
            this.chk_esVegano.UseVisualStyleBackColor = true;
            // 
            // lbl_error
            // 
            this.lbl_error.ForeColor = System.Drawing.Color.Red;
            this.lbl_error.Location = new System.Drawing.Point(232, 9);
            this.lbl_error.Name = "lbl_error";
            this.lbl_error.Size = new System.Drawing.Size(104, 31);
            this.lbl_error.TabIndex = 24;
            this.lbl_error.Text = "No todos los datos son válidos!";
            this.lbl_error.Visible = false;
            // 
            // FormNuevaComida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 267);
            this.Controls.Add(this.lbl_error);
            this.Controls.Add(this.chk_esVegano);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.lbl_titulo);
            this.Controls.Add(this.cmb_tipoComida);
            this.Controls.Add(this.txt_precioUnitario);
            this.Controls.Add(this.txt_descripcion);
            this.Controls.Add(this.lbl_tipo);
            this.Controls.Add(this.lbl_precioUnitario);
            this.Controls.Add(this.lbl_descripcion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormNuevaComida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormNuevaConsumision";
            this.Load += new System.EventHandler(this.FormNuevaConsumision_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_descripcion;
        private System.Windows.Forms.Label lbl_precioUnitario;
        private System.Windows.Forms.Label lbl_tipo;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.TextBox txt_precioUnitario;
        private System.Windows.Forms.ComboBox cmb_tipoComida;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox chk_esVegano;
        private System.Windows.Forms.Label lbl_error;
    }
}