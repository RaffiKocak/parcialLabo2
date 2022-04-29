namespace Primer_Parcial_Labo_2
{
    partial class FormIngresarCantidad
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
            this.lbl_cantidad = new System.Windows.Forms.Label();
            this.nud_cantidadIngresada = new System.Windows.Forms.NumericUpDown();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nud_cantidadIngresada)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_cantidad
            // 
            this.lbl_cantidad.AutoSize = true;
            this.lbl_cantidad.Location = new System.Drawing.Point(28, 24);
            this.lbl_cantidad.Name = "lbl_cantidad";
            this.lbl_cantidad.Size = new System.Drawing.Size(100, 15);
            this.lbl_cantidad.TabIndex = 0;
            this.lbl_cantidad.Text = "Ingrese cantidad: ";
            // 
            // nud_cantidadIngresada
            // 
            this.nud_cantidadIngresada.Location = new System.Drawing.Point(28, 59);
            this.nud_cantidadIngresada.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nud_cantidadIngresada.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_cantidadIngresada.Name = "nud_cantidadIngresada";
            this.nud_cantidadIngresada.Size = new System.Drawing.Size(100, 23);
            this.nud_cantidadIngresada.TabIndex = 1;
            this.nud_cantidadIngresada.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Location = new System.Drawing.Point(28, 104);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(77, 26);
            this.btn_aceptar.TabIndex = 2;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(111, 104);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(77, 26);
            this.btn_cancelar.TabIndex = 3;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // FormIngresarCantidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 159);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.nud_cantidadIngresada);
            this.Controls.Add(this.lbl_cantidad);
            this.Name = "FormIngresarCantidad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormIngresarCantidad";
            this.Load += new System.EventHandler(this.FormIngresarCantidad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_cantidadIngresada)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_cantidad;
        private System.Windows.Forms.NumericUpDown nud_cantidadIngresada;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.Button btn_cancelar;
    }
}