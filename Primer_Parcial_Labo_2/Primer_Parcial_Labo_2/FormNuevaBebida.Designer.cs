namespace Primer_Parcial_Labo_2
{
    partial class FormNuevaBebida
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
            this.chk_tieneTacc = new System.Windows.Forms.CheckBox();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.cmb_tipoBebida = new System.Windows.Forms.ComboBox();
            this.txt_precioUnitario = new System.Windows.Forms.TextBox();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.lbl_tipo = new System.Windows.Forms.Label();
            this.lbl_precioUnitario = new System.Windows.Forms.Label();
            this.lbl_descripcion = new System.Windows.Forms.Label();
            this.chk_tieneAlcohol = new System.Windows.Forms.CheckBox();
            this.cmb_envase = new System.Windows.Forms.ComboBox();
            this.lbl_envase = new System.Windows.Forms.Label();
            this.lbl_error = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chk_tieneTacc
            // 
            this.chk_tieneTacc.AutoSize = true;
            this.chk_tieneTacc.Location = new System.Drawing.Point(196, 208);
            this.chk_tieneTacc.Name = "chk_tieneTacc";
            this.chk_tieneTacc.Size = new System.Drawing.Size(106, 19);
            this.chk_tieneTacc.TabIndex = 19;
            this.chk_tieneTacc.Text = "Contiene TACC";
            this.chk_tieneTacc.UseVisualStyleBackColor = true;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(194, 240);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(122, 32);
            this.btn_cancelar.TabIndex = 18;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(49, 240);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(122, 32);
            this.btn_agregar.TabIndex = 17;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_titulo.Location = new System.Drawing.Point(25, 13);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(199, 25);
            this.lbl_titulo.TabIndex = 16;
            this.lbl_titulo.Text = "Agregar nueva bebida";
            // 
            // cmb_tipoBebida
            // 
            this.cmb_tipoBebida.FormattingEnabled = true;
            this.cmb_tipoBebida.Location = new System.Drawing.Point(161, 131);
            this.cmb_tipoBebida.Name = "cmb_tipoBebida";
            this.cmb_tipoBebida.Size = new System.Drawing.Size(157, 23);
            this.cmb_tipoBebida.TabIndex = 15;
            // 
            // txt_precioUnitario
            // 
            this.txt_precioUnitario.Location = new System.Drawing.Point(161, 94);
            this.txt_precioUnitario.Name = "txt_precioUnitario";
            this.txt_precioUnitario.Size = new System.Drawing.Size(157, 23);
            this.txt_precioUnitario.TabIndex = 14;
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Location = new System.Drawing.Point(161, 56);
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(157, 23);
            this.txt_descripcion.TabIndex = 13;
            // 
            // lbl_tipo
            // 
            this.lbl_tipo.AutoSize = true;
            this.lbl_tipo.Location = new System.Drawing.Point(51, 134);
            this.lbl_tipo.Name = "lbl_tipo";
            this.lbl_tipo.Size = new System.Drawing.Size(33, 15);
            this.lbl_tipo.TabIndex = 12;
            this.lbl_tipo.Text = "Tipo:";
            // 
            // lbl_precioUnitario
            // 
            this.lbl_precioUnitario.AutoSize = true;
            this.lbl_precioUnitario.Location = new System.Drawing.Point(51, 97);
            this.lbl_precioUnitario.Name = "lbl_precioUnitario";
            this.lbl_precioUnitario.Size = new System.Drawing.Size(88, 15);
            this.lbl_precioUnitario.TabIndex = 11;
            this.lbl_precioUnitario.Text = "Precio Unitario:";
            // 
            // lbl_descripcion
            // 
            this.lbl_descripcion.AutoSize = true;
            this.lbl_descripcion.Location = new System.Drawing.Point(51, 60);
            this.lbl_descripcion.Name = "lbl_descripcion";
            this.lbl_descripcion.Size = new System.Drawing.Size(72, 15);
            this.lbl_descripcion.TabIndex = 10;
            this.lbl_descripcion.Text = "Descripción:";
            // 
            // chk_tieneAlcohol
            // 
            this.chk_tieneAlcohol.AutoSize = true;
            this.chk_tieneAlcohol.Location = new System.Drawing.Point(51, 208);
            this.chk_tieneAlcohol.Name = "chk_tieneAlcohol";
            this.chk_tieneAlcohol.Size = new System.Drawing.Size(116, 19);
            this.chk_tieneAlcohol.TabIndex = 20;
            this.chk_tieneAlcohol.Text = "Contiene alcohol";
            this.chk_tieneAlcohol.UseVisualStyleBackColor = true;
            // 
            // cmb_envase
            // 
            this.cmb_envase.FormattingEnabled = true;
            this.cmb_envase.Location = new System.Drawing.Point(161, 170);
            this.cmb_envase.Name = "cmb_envase";
            this.cmb_envase.Size = new System.Drawing.Size(157, 23);
            this.cmb_envase.TabIndex = 22;
            // 
            // lbl_envase
            // 
            this.lbl_envase.AutoSize = true;
            this.lbl_envase.Location = new System.Drawing.Point(51, 173);
            this.lbl_envase.Name = "lbl_envase";
            this.lbl_envase.Size = new System.Drawing.Size(46, 15);
            this.lbl_envase.TabIndex = 21;
            this.lbl_envase.Text = "Envase:";
            // 
            // lbl_error
            // 
            this.lbl_error.ForeColor = System.Drawing.Color.Red;
            this.lbl_error.Location = new System.Drawing.Point(231, 18);
            this.lbl_error.Name = "lbl_error";
            this.lbl_error.Size = new System.Drawing.Size(104, 31);
            this.lbl_error.TabIndex = 23;
            this.lbl_error.Text = "No todos los datos son válidos!";
            this.lbl_error.Visible = false;
            // 
            // FormNuevaBebida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 300);
            this.Controls.Add(this.lbl_error);
            this.Controls.Add(this.cmb_envase);
            this.Controls.Add(this.lbl_envase);
            this.Controls.Add(this.chk_tieneAlcohol);
            this.Controls.Add(this.chk_tieneTacc);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.lbl_titulo);
            this.Controls.Add(this.cmb_tipoBebida);
            this.Controls.Add(this.txt_precioUnitario);
            this.Controls.Add(this.txt_descripcion);
            this.Controls.Add(this.lbl_tipo);
            this.Controls.Add(this.lbl_precioUnitario);
            this.Controls.Add(this.lbl_descripcion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormNuevaBebida";
            this.Text = "FormNuevaBebida";
            this.Load += new System.EventHandler(this.FormNuevaBebida_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chk_tieneTacc;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.ComboBox cmb_tipoBebida;
        private System.Windows.Forms.TextBox txt_precioUnitario;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.Label lbl_tipo;
        private System.Windows.Forms.Label lbl_precioUnitario;
        private System.Windows.Forms.Label lbl_descripcion;
        private System.Windows.Forms.CheckBox chk_tieneAlcohol;
        private System.Windows.Forms.ComboBox cmb_envase;
        private System.Windows.Forms.Label lbl_envase;
        private System.Windows.Forms.Label lbl_error;
    }
}